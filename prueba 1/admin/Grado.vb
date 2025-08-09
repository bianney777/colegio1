Imports System.Data.SqlClient

Public Class Grado
    Private Sub Grado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet3.Grado' Puede moverla o quitarla según sea necesario.
        Me.GradoTableAdapter.Fill(Me.Colegio1DataSet3.Grado)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Dim conn As New SqlConnection(connString)

        Dim query As String = "INSERT INTO Grado (NombreGrado) VALUES (@NombreGrado)"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@NombreGrado", txtNombreGrado.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Grado registrado correctamente.")
            CargarGrados()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona un grado para eliminar.")
            Exit Sub
        End If

        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este grado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resultado = DialogResult.No Then
            Exit Sub
        End If

        Dim gradoID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("GradoID").Value)

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "DELETE FROM Grado WHERE GradoID = @id"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", gradoID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("✅ Grado eliminado correctamente.")
        CargarGrados() ' 🔁 Refresca el DataGridView con los grados actualizados


    End Sub

    Private Sub CargarGrados()
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Dim query As String = "SELECT * FROM Grado"
        Dim conn As New SqlConnection(connString)
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim dt As New DataTable()

        adapter.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Try
            If e.RowIndex < 0 Then Exit Sub ' Ignorar encabezado

            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Validar si la celda editada no es vacía
            Dim nuevoValor As String = fila.Cells(e.ColumnIndex).Value?.ToString()?.Trim()
            If String.IsNullOrWhiteSpace(nuevoValor) Then Exit Sub

            ' Obtener el ID del grado desde la fila
            Dim GradoID As Integer = Convert.ToInt32(fila.Cells("GradoID").Value)

            ' Obtener el nombre de la columna editada
            Dim columnaEditada As String = DataGridView1.Columns(e.ColumnIndex).DataPropertyName ' nombre real del campo SQL

            ' Cadena de conexión (ajustá según tu servidor)
            Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

            ' Ejecutar el UPDATE
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = $"UPDATE Grado SET {columnaEditada} = @nuevoValor WHERE GradoID = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor)
                    cmd.Parameters.AddWithValue("@id", gradoID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("✅ Grado actualizado correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrados()
        Catch ex As Exception
            MessageBox.Show("❌ Error al actualizar el grado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class