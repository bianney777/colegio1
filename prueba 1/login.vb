Imports System.Data.SqlClient
Public Class login
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Open()

        Dim consulta As String = "SELECT TipoUsuario FROM Usuario WHERE Username = @user AND PasswordHash = @pass"
        comando = New SqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@user", textuser.Text)
        comando.Parameters.AddWithValue("@pass", textcontra.Text)

        Dim lector As SqlDataReader = comando.ExecuteReader()

        If lector.HasRows Then
            lector.Read()
            Dim tipoUsuario As String = lector("TipoUsuario").ToString()

            Me.Hide() ' Oculta el login

            Select Case tipoUsuario
                Case "Estudiante"
                    Dim frmEstudiante As New frmEstudiante()
                    frmEstudiante.ShowDialog()

                Case "Maestro"
                    Dim frmMaestro As New frmMaestro()
                    frmMaestro.ShowDialog()

                Case "Responsable"
                    Dim frmResponsable As New frmResponsable()
                    frmResponsable.ShowDialog()

                Case "Administrador"
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()

                Case Else
                    MessageBox.Show("Tipo de usuario no reconocido")

                    textcontra.Clear()
                    textuser.Clear()

            End Select

            Me.Show() ' Opcional: vuelve a mostrar el login si se cierra el formulario
        Else
            MessageBox.Show("Datos incorrectos")
        End If

        conexion.Close()

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New SqlConnection("server=(localdb)\MSSQLLocalDB;database=colegio1; integrated security=true")

    End Sub
End Class
