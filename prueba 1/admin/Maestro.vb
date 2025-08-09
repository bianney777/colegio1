Imports System.Data.SqlClient


Public Class Maestro
    Private Sub Maestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet8.VistaMaestroConUsuario1' Puede moverla o quitarla según sea necesario.
        Me.VistaMaestroConUsuario1TableAdapter1.Fill(Me.Colegio1DataSet8.VistaMaestroConUsuario1)
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet7.VistaMaestroConUsuario1' Puede moverla o quitarla según sea necesario.
        Me.VistaMaestroConUsuario1TableAdapter.Fill(Me.Colegio1DataSet7.VistaMaestroConUsuario1)
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet6.VistaMaestroConUsuario' Puede moverla o quitarla según sea necesario.
        Me.VistaMaestroConUsuarioTableAdapter.Fill(Me.Colegio1DataSet6.VistaMaestroConUsuario)
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet5.Maestro' Puede moverla o quitarla según sea necesario.
        Me.MaestroTableAdapter.Fill(Me.Colegio1DataSet5.Maestro)

        CargarMaestro()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = TextBoxNombre.Text
        Dim apellido As String = TextBoxApellido.Text
        Dim direccion As String = TextBoxDireccion.Text
        Dim sexo As String = ComboBoxSexo.Text

        Dim añoActual As String = DateTime.Now.Year.ToString()
        Dim username As String = nombre.ToLower() & añoActual
        Dim passwordHash As String = username ' ⚠️ Usar hashing si querés mayor seguridad

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            conn.Open()

            ' Insertar en Usuario
            Dim queryUsuario As String = "INSERT INTO Usuario (Username, PasswordHash, TipoUsuario) VALUES (@u, @p, 'maestro'); SELECT SCOPE_IDENTITY();"
            Using cmdUsuario As New SqlCommand(queryUsuario, conn)
                cmdUsuario.Parameters.AddWithValue("@u", username)
                cmdUsuario.Parameters.AddWithValue("@p", passwordHash)
                Dim usuarioID As Integer = Convert.ToInt32(cmdUsuario.ExecuteScalar())

                ' Insertar en Maestro
                Dim queryMaestro As String = "INSERT INTO Maestro (Nombre, Apellido, Direccion, Sexo, UsuarioID) VALUES (@n, @a, @d, @s, @id)"
                Using cmdMaestro As New SqlCommand(queryMaestro, conn)
                    cmdMaestro.Parameters.AddWithValue("@n", nombre)
                    cmdMaestro.Parameters.AddWithValue("@a", apellido)
                    cmdMaestro.Parameters.AddWithValue("@d", direccion)
                    cmdMaestro.Parameters.AddWithValue("@s", sexo)
                    cmdMaestro.Parameters.AddWithValue("@id", usuarioID)
                    cmdMaestro.ExecuteNonQuery()
                End Using
            End Using
        End Using
        CargarMaestro()

        MessageBox.Show("✅ Maestro creado exitosamente con usuario: " & username)
    End Sub

    Sub CargarMaestro()
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Dim query As String = "
        SELECT 
            m.MaestroID, 
            m.Nombre, 
            m.Apellido, 
            m.Direccion, 
            m.Sexo, 
            u.Username, 
            u.PasswordHash, 
            u.TipoUsuario
        FROM 
            Maestro m
        JOIN 
            Usuario u ON m.UsuarioID = u.UsuarioID
        WHERE 
            m.Estado = 'Activo'"

        Using conn As New SqlConnection(connString)
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim columnaEditada As String = DataGridView1.Columns(e.ColumnIndex).DataPropertyName
        If String.IsNullOrWhiteSpace(columnaEditada) Or columnaEditada.ToLower = "maestroid" Then Exit Sub

        Dim nuevoValor As String = fila.Cells(e.ColumnIndex).Value?.ToString()?.Trim()
        If String.IsNullOrWhiteSpace(nuevoValor) Then Exit Sub

        Dim maestroID As Object = fila.Cells("MaestroID").Value
        If maestroID Is Nothing OrElse Not IsNumeric(maestroID) Then Exit Sub

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                Dim query As String = ""
                Dim cmd As New SqlCommand()
                cmd.Connection = conn

                Select Case columnaEditada.ToLower
                    Case "Username", "PasswordHash"
                        ' Buscar UsuarioID según MaestroID
                        query = "SELECT UsuarioID FROM Usuarios WHERE MaestroID = @maestroID"
                        cmd.CommandText = query
                        cmd.Parameters.AddWithValue("@maestroID", maestroID)

                        Dim usuarioID As Object = cmd.ExecuteScalar()
                        cmd.Parameters.Clear()

                        If usuarioID Is Nothing Then
                            MessageBox.Show("⚠️ No se encontró un Usuario vinculado a este Maestro.", "Sin vínculo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                        ' Actualizar el valor en tabla Usuarios
                        query = $"UPDATE Usuario SET {columnaEditada} = @valor WHERE UsuarioID = @id"
                        cmd.CommandText = query
                        cmd.Parameters.AddWithValue("@valor", nuevoValor)
                        cmd.Parameters.AddWithValue("@id", usuarioID)

                    Case Else
                        ' Actualizar en tabla Maestro
                        query = $"UPDATE Maestro SET {columnaEditada} = @valor WHERE MaestroID = @id"
                        cmd.CommandText = query
                        cmd.Parameters.AddWithValue("@valor", nuevoValor)
                        cmd.Parameters.AddWithValue("@id", maestroID)
                End Select

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("✅ Cambios aplicados correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("❌ Error al guardar el cambio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim maestroID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("MaestroID").Value)

            Using conexion As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True")
                Try
                    conexion.Open()

                    Using comando As New SqlCommand("UPDATE Maestro SET Estado = 'Inactivo' WHERE MaestroID = @MaestroID", conexion)
                        comando.Parameters.AddWithValue("@MaestroID", maestroID)

                        comando.ExecuteNonQuery()
                        MessageBox.Show("Estado del maestro cambiado a inactivo.", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error al actualizar estado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Selecciona una fila primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class