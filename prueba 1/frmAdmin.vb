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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class