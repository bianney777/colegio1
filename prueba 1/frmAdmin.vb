Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmAdmin
    Private Sub MateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriaToolStripMenuItem.Click
        Materia.ShowDialog()

    End Sub

    Private Sub MatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriculaToolStripMenuItem.Click
        matricula.Show()
    End Sub
    Private Sub GradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradoToolStripMenuItem.Click
        Grado.Show()
    End Sub


    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTotalMatriculadosAnioActual()


        Dim dt As New DataTable()

        Using conn As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True")
            conn.Open()
            Using cmd As New SqlCommand("SELECT Sexo, COUNT(*) AS Total FROM Estudiante GROUP BY Sexo", conn)
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        ' Configurar gráfico
        ChartSexo.Series.Clear()
        ChartSexo.Titles.Clear()
        ChartSexo.Titles.Add("Distribución de Alumnos por Sexo")

        Dim serie As New Series("Sexo")
        serie.ChartType = SeriesChartType.Pie
        serie.IsValueShownAsLabel = True

        For Each row As DataRow In dt.Rows
            serie.Points.AddXY(row("Sexo").ToString(), Convert.ToInt32(row("Total")))
        Next

        ChartSexo.Series.Add(serie)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Grado.ShowDialog()
    End Sub

    Private Sub MaestroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroToolStripMenuItem.Click
        Maestro.Show()
    End Sub

    Private Sub InscripcionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionToolStripMenuItem.Click
        matricula1.Show()
    End Sub

    Private Sub PeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriodoToolStripMenuItem.Click
        periodo.Show()
    End Sub

    Private Sub ClaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClaseToolStripMenuItem.Click
        clase.Show()
    End Sub

    Private Sub ChartSexo_Click(sender As Object, e As EventArgs) Handles ChartSexo.Click

    End Sub

    Private Sub MostrarTotalMatriculadosAnioActual()
        Dim total As Integer = 0
        Dim anioActual As Integer = Date.Today.Year

        Using conn As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True")
            conn.Open()
            Using cmd As New SqlCommand("SELECT COUNT(*) FROM Matricula WHERE YEAR(FechaMatricula) = @Anio", conn)
                cmd.Parameters.AddWithValue("@Anio", anioActual)
                total = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        lblTotalAlumnos.Text = "Matriculados en " & anioActual.ToString() & ": " & total.ToString()
    End Sub

    Private Sub NotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaToolStripMenuItem.Click
        nota.Show()
    End Sub
End Class