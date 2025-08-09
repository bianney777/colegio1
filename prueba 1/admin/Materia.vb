Imports System.Data.SqlClient

Public Class Materia
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNombreAsignatura.Text = "" Or txtDescripcion.Text = "" Then
            MessageBox.Show("Por favor completa todos los campos.")
            Exit Sub
        End If

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conexion As New SqlConnection(connString)
            Dim consulta As String = "INSERT INTO Asignatura (Nombre, Descripcion) VALUES (@nombre, @descripcion)"
            Dim comando As New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", txtNombreAsignatura.Text)
            comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)

            Try
                conexion.Open()
                comando.ExecuteNonQuery()
                MessageBox.Show("Asignatura agregada exitosamente.")
                txtDescripcion.Clear()
                txtNombreAsignatura.Clear()
            Catch ex As Exception
                MessageBox.Show("Error al agregar la asignatura: " & ex.Message)
            End Try
        End Using
        CargarAsignaturas()
    End Sub

    Private Sub CargarAsignaturas()
        Dim dt As New DataTable()
        Dim connectionString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT AsignaturaID, Nombre, Descripcion FROM Asignatura"
            Using adapter As New SqlDataAdapter(query, conn)
                adapter.Fill(dt)
            End Using
        End Using
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Materia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet.Asignatura' Puede moverla o quitarla según sea necesario.
        Me.AsignaturaTableAdapter.Fill(Me.Colegio1DataSet.Asignatura)

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona una asignatura para eliminar.")
            Exit Sub
        End If

        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta asignatura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resultado = DialogResult.No Then
            Exit Sub
        End If

        Dim asignaturaID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("AsignaturaID").Value)

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "DELETE FROM Asignatura WHERE AsignaturaID = @id"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", asignaturaID)
                cmd.ExecuteNonQuery()
            End Using
        End Using


        MessageBox.Show("Asignatura eliminada correctamente.")
        CargarAsignaturas() ' 🔁 Refresca el DataGridView

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Columns("AsignaturaID").Visible = False ' Opcional
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub ' Ignorar encabezado

        Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim asignaturaID As Integer = Convert.ToInt32(fila.Cells("AsignaturaID").Value)
        Dim nuevoValor As String = fila.Cells(e.ColumnIndex).Value.ToString()
        Dim columnaEditada As String = DataGridView1.Columns(e.ColumnIndex).DataPropertyName ' ✅ Usa el nombre real del campo en SQL

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = $"UPDATE Asignatura SET {columnaEditada} = @nuevoValor WHERE AsignaturaID = @id"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor)
                cmd.Parameters.AddWithValue("@id", asignaturaID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Cambios guardados correctamente.")
    End Sub

End Class