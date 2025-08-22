Imports System.Data.SqlClient

Public Class clase
    Private Sub clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()

            ' Grado
            Dim cmdGrado As New SqlCommand("SELECT GradoID, NombreGrado FROM Grado", conn)
            Dim dtGrado As New DataTable()
            dtGrado.Load(cmdGrado.ExecuteReader())
            cboGrado.DataSource = dtGrado
            cboGrado.DisplayMember = "NombreGrado"
            cboGrado.ValueMember = "GradoID"

            ' Asignatura
            Dim cmdAsig As New SqlCommand("SELECT AsignaturaID, Nombre FROM Asignatura", conn)
            Dim dtAsig As New DataTable()
            dtAsig.Load(cmdAsig.ExecuteReader())
            cboAsignatura.DataSource = dtAsig
            cboAsignatura.DisplayMember = "Nombre"
            cboAsignatura.ValueMember = "AsignaturaID"

            ' Maestro
            Dim cmdMaestro As New SqlCommand("SELECT MaestroID, Nombre + ' ' + Apellido AS NombreCompleto FROM Maestro", conn)
            Dim dtMaestro As New DataTable()
            dtMaestro.Load(cmdMaestro.ExecuteReader())
            cboMaestro.DataSource = dtMaestro
            cboMaestro.DisplayMember = "NombreCompleto"
            cboMaestro.ValueMember = "MaestroID"

            ' Periodo
            Dim cmdPeriodo As New SqlCommand("SELECT PeriodoID, NombrePeriodo FROM Periodo", conn)
            Dim dtPeriodo As New DataTable()
            dtPeriodo.Load(cmdPeriodo.ExecuteReader())
            cboPeriodo.DataSource = dtPeriodo
            cboPeriodo.DisplayMember = "NombrePeriodo"
            cboPeriodo.ValueMember = "PeriodoID"
        End Using


    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand("
                INSERT INTO Clase (NombreClase, GradoID, MaestroID, PeriodoID, AsignaturaID)
                VALUES (@nombre, @grado, @maestro, @periodo, @asig)", conn)

                cmd.Parameters.AddWithValue("@nombre", txtNombreClase.Text.Trim())
                cmd.Parameters.AddWithValue("@grado", cboGrado.SelectedValue)
                cmd.Parameters.AddWithValue("@maestro", cboMaestro.SelectedValue)
                cmd.Parameters.AddWithValue("@periodo", cboPeriodo.SelectedValue)
                cmd.Parameters.AddWithValue("@asig", cboAsignatura.SelectedValue)

                cmd.ExecuteNonQuery()
                MessageBox.Show("✅ Clase creada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("❌ Error al crear la clase: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub
End Class