Imports System.Data.SqlClient

Public Class periodo
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                Dim cmd As New SqlCommand("
                INSERT INTO Periodo (NombrePeriodo, FechaInicio, FechaFin)
                VALUES (@nombre, @inicio, @fin)", conn)

                cmd.Parameters.AddWithValue("@nombre", txtNombrePeriodo.Text.Trim())
                cmd.Parameters.AddWithValue("@inicio", dtpInicio.Value.Date)
                cmd.Parameters.AddWithValue("@fin", dtpFin.Value.Date)

                cmd.ExecuteNonQuery()

                MessageBox.Show("✅ Periodo creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("❌ Error al crear el periodo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


    End Sub
End Class