Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class matricula
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction()

            Try
                ' === DATOS ESTUDIANTE ===
                Dim nacimientoEst As Date = dtpNacimiento.Value
                Dim nombreEst As String = txtNombreEst.Text.Trim().ToLower()
                Dim apellidoEst As String = txtApellidoEst.Text.Trim().ToLower()
                Dim usuarioEst As String = nombreEst.Substring(0, 1) & apellidoEst & nacimientoEst.Year.ToString()
                Dim passEst As String = nacimientoEst.ToString("ddMMyyyy") & txtNombreEst.Text.Trim()

                ' === INSERT USUARIO ESTUDIANTE ===
                Dim cmdUserEst As New SqlCommand("
                INSERT INTO Usuario (Username, PasswordHash, TipoUsuario) 
                OUTPUT INSERTED.UsuarioID 
                VALUES (@u, @p, 'Estudiante')", conn, trans)
                cmdUserEst.Parameters.AddWithValue("@u", usuarioEst)
                cmdUserEst.Parameters.AddWithValue("@p", passEst)
                Dim usuarioID_Est As Integer = CInt(cmdUserEst.ExecuteScalar())

                ' === INSERT ESTUDIANTE ===
                Dim cmdEst As New SqlCommand("
                INSERT INTO Estudiante (CodigoEstudiante, Nombre, Apellido, Sexo, Direccion, FechaNacimiento, UsuarioID) 
                OUTPUT INSERTED.EstudianteID 
                VALUES (@cod, @nom, @ape, @sex, @dir, @fec, @uid)", conn, trans)
                cmdEst.Parameters.AddWithValue("@cod", txtCodigo.Text.Trim())
                cmdEst.Parameters.AddWithValue("@nom", txtNombreEst.Text.Trim())
                cmdEst.Parameters.AddWithValue("@ape", txtApellidoEst.Text.Trim())
                cmdEst.Parameters.AddWithValue("@sex", cboSexoEst.Text.Trim())
                cmdEst.Parameters.AddWithValue("@dir", txtDireccionEst.Text.Trim())
                cmdEst.Parameters.AddWithValue("@fec", nacimientoEst)
                cmdEst.Parameters.AddWithValue("@uid", usuarioID_Est)
                Dim estudianteID As Integer = CInt(cmdEst.ExecuteScalar())

                ' === VERIFICAR SI EL RESPONSABLE YA EXISTE POR CÉDULA ===
                Dim responsableID As Integer
                Dim cedulaResp As String = txtCedula.Text.Trim()

                Dim cmdBuscaResp As New SqlCommand("
                SELECT ResponsableID 
                FROM Responsable 
                WHERE Cedula = @ced", conn, trans)
                cmdBuscaResp.Parameters.AddWithValue("@ced", cedulaResp)
                Dim result = cmdBuscaResp.ExecuteScalar()

                If result IsNot Nothing Then
                    ' Ya existe el responsable
                    responsableID = CInt(result)
                Else
                    ' NO existe, entonces se crea

                    Dim nombreResp As String = txtNombreResp.Text.Trim().ToLower()
                    Dim apellidoResp As String = txtApellidoResp.Text.Trim().ToLower()
                    Dim cedulaSufijo As String = If(cedulaResp.Length >= 4, cedulaResp.Substring(cedulaResp.Length - 4), cedulaResp)
                    Dim usuarioResp As String = nombreResp.Substring(0, 1) & apellidoResp & cedulaSufijo.ToLower()
                    Dim passResp As String = cedulaResp & txtNombreResp.Text.Trim()

                    ' Usuario del responsable
                    Dim cmdUserResp As New SqlCommand("
                    INSERT INTO Usuario (Username, PasswordHash, TipoUsuario) 
                    OUTPUT INSERTED.UsuarioID 
                    VALUES (@u, @p, 'Responsable')", conn, trans)
                    cmdUserResp.Parameters.AddWithValue("@u", usuarioResp)
                    cmdUserResp.Parameters.AddWithValue("@p", passResp)
                    Dim usuarioID_Resp As Integer = CInt(cmdUserResp.ExecuteScalar())

                    ' Insertar responsable
                    Dim cmdResp As New SqlCommand("
                    INSERT INTO Responsable (Nombre, Apellido, Parentesco, Cedula, Telefono, Direccion, UsuarioID) 
                    OUTPUT INSERTED.ResponsableID 
                    VALUES (@nom, @ape, @par, @ced, @tel, @dir, @uid)", conn, trans)
                    cmdResp.Parameters.AddWithValue("@nom", txtNombreResp.Text.Trim())
                    cmdResp.Parameters.AddWithValue("@ape", txtApellidoResp.Text.Trim())
                    cmdResp.Parameters.AddWithValue("@par", txtParentesco.Text.Trim())
                    cmdResp.Parameters.AddWithValue("@ced", cedulaResp)
                    cmdResp.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim())
                    cmdResp.Parameters.AddWithValue("@dir", txtDireccionResp.Text.Trim())
                    cmdResp.Parameters.AddWithValue("@uid", usuarioID_Resp)
                    responsableID = CInt(cmdResp.ExecuteScalar())
                End If

                ' === RELACIÓN ESTUDIANTE-RESPONSABLE ===
                Dim cmdRelacion As New SqlCommand("
                INSERT INTO EstudianteResponsable (EstudianteID, ResponsableID) 
                VALUES (@eid, @rid)", conn, trans)
                cmdRelacion.Parameters.AddWithValue("@eid", estudianteID)
                cmdRelacion.Parameters.AddWithValue("@rid", responsableID)
                cmdRelacion.ExecuteNonQuery()

                trans.Commit()
                Me.ReportViewer1.RefreshReport()

                MessageBox.Show("✅ Registro exitoso." & vbCrLf &
                            "Estudiante - Usuario: " & usuarioEst & " | Clave: " & passEst)

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("❌ Error al registrar: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cboSexoEst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSexoEst.SelectedIndexChanged

    End Sub

    Private Sub matricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Colegio1DataSet2.ObtenerMatriculaPorCodigoEstudiante' Puede moverla o quitarla según sea necesario.
        Me.ObtenerMatriculaPorCodigoEstudianteTableAdapter.Fill(Me.Colegio1DataSet2.ObtenerMatriculaPorCodigoEstudiante)
        'TODO: esta línea de código carga datos en la tab
        OcultarCamposResponsable()
        CargarEstudiantesPorCodigo()
        CargarClases()
        CargarPeriodos()



        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub OcultarCamposResponsable()
        txtNombreResp.Visible = False
        txtApellidoResp.Visible = False
        txtParentesco.Visible = False
        txtTelefono.Visible = False
        txtDireccionResp.Visible = False
        lnp.Visible = False
        lap.Visible = False
        p.Visible = False
        Label5.Visible = False
        Label6.Visible = False


    End Sub

    Private Sub MostrarCamposResponsable()
        txtNombreResp.Visible = True
        txtApellidoResp.Visible = True
        txtParentesco.Visible = True
        txtTelefono.Visible = True
        txtDireccionResp.Visible = True
        lnp.Visible = True
        lap.Visible = True
        p.Visible = True
        Label5.Visible = True
        Label6.Visible = True
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        ' Verificamos si hay un código de estudiante en el TextBox
        Dim codigoEst As String = txtCodigo.Text.Trim()

        If String.IsNullOrWhiteSpace(codigoEst) Then
            MessageBox.Show("⚠️ Ingrese un código de estudiante antes de cargar el reporte.")
            Exit Sub
        End If

        ' Llamamos a la subrutina para cargar el reporte
        ImprimirMatriculaPorCodigo(codigoEst)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim codigo As String = TextBox1.Text.Trim()

        txtCodigo.Text = codigo

        If Not String.IsNullOrWhiteSpace(codigo) Then
            ImprimirMatriculaPorCodigo(codigo)
        End If

    End Sub

    Private Sub ImprimirMatriculaPorCodigo(codigoEst As String)
        Try
            ' Validar el código ingresado
            If String.IsNullOrWhiteSpace(codigoEst) Then
                MessageBox.Show("⚠️ Por favor, ingrese un código de estudiante válido.")
                Exit Sub
            End If

            ' Preparar DataTable para recibir los datos
            Dim dt As New DataTable()

            ' Conexión a la base de datos
            Using conn As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True")
                conn.Open()

                Using cmd As New SqlCommand("ObtenerMatriculaPorCodigoEstudiante", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@CodigoEstudiante", codigoEst)

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            ' Validar si hay resultados
            If dt.Rows.Count = 0 Then
                MessageBox.Show("❌ No se encontró matrícula con el código proporcionado.")
                Exit Sub
            End If

            ' Validar existencia del archivo RDLC
            Dim rdlcPath As String = Application.StartupPath & "\report1.rdlc"
            If Not File.Exists(rdlcPath) Then
                MessageBox.Show("❌ El archivo del reporte no fue encontrado: " & rdlcPath)
                Exit Sub
            End If

            ' Mostrar reporte en ReportViewer1
            ReportViewer1.Reset()
            ReportViewer1.LocalReport.ReportPath = rdlcPath
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("❌ Error al cargar el reporte: " & ex.Message)
        End Try
    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            conn.Open()

            Try
                Dim cedulaBuscada As String = txtCedula.Text.Trim()

                Dim cmdBusca As New SqlCommand("
                SELECT Nombre, Apellido, Parentesco, Telefono, Direccion 
                FROM Responsable 
                WHERE Cedula = @ced", conn)
                cmdBusca.Parameters.AddWithValue("@ced", cedulaBuscada)

                Using reader As SqlDataReader = cmdBusca.ExecuteReader()
                    If reader.Read() Then
                        ' Si encontró al responsable, rellenamos los campos
                        txtNombreResp.Text = reader("Nombre").ToString()
                        txtApellidoResp.Text = reader("Apellido").ToString()
                        txtParentesco.Text = reader("Parentesco").ToString()
                        txtTelefono.Text = reader("Telefono").ToString()
                        txtDireccionResp.Text = reader("Direccion").ToString()

                        MostrarCamposResponsable()


                        MessageBox.Show("✅ Responsable encontrado y datos rellenados correctamente.")
                    Else
                        txtNombreResp.Text = ""
                        txtApellidoResp.Text = ""
                        txtParentesco.Text = ""
                        txtTelefono.Text = ""
                        txtDireccionResp.Text = ""
                        MostrarCamposResponsable()

                        MessageBox.Show("⚠️ No se encontró ningún responsable con esa cédula.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("❌ Error al buscar responsable: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim codigo As String = txtCodigo.Text.Trim()

        If String.IsNullOrWhiteSpace(codigo) Then
            MessageBox.Show("⚠️ Ingrese un código de estudiante válido.")
            Exit Sub
        End If

        ImprimirMatriculaPorCodigo(codigo)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cboEstudiante.SelectedItem Is Nothing OrElse cboPeriodo.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione estudiante y periodo.")
            Exit Sub
        End If

        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Seleccione al menos un curso.")
            Exit Sub
        End If

        Dim row As DataRowView = CType(cboEstudiante.SelectedItem, DataRowView)
        Dim estudianteID As Integer = Convert.ToInt32(row("EstudianteID"))
        Dim periodoID As Integer = Convert.ToInt32(cboPeriodo.SelectedValue)
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                For Each item In CheckedListBox1.CheckedItems
                    Dim claseItem As ClaseItem = CType(item, ClaseItem)
                    Dim claseID As Integer = claseItem.ID

                    ' Validar si ya existe la matrícula
                    Dim validarCmd As New SqlCommand("
                    SELECT COUNT(*)  
                    FROM Matricula  
                    WHERE EstudianteID = @est AND ClaseID = @clase AND PeriodoID = @periodo", conn)
                    validarCmd.Parameters.AddWithValue("@est", estudianteID)
                    validarCmd.Parameters.AddWithValue("@clase", claseID)
                    validarCmd.Parameters.AddWithValue("@periodo", periodoID)

                    Dim existe As Integer = Convert.ToInt32(validarCmd.ExecuteScalar())
                    If existe = 0 Then
                        ' Insertar matrícula
                        Dim insertarCmd As New SqlCommand("
                        INSERT INTO Matricula (EstudianteID, ClaseID, PeriodoID, FechaMatricula)  
                        VALUES (@est, @clase, @periodo, @fecha)", conn)
                        insertarCmd.Parameters.AddWithValue("@est", estudianteID)
                        insertarCmd.Parameters.AddWithValue("@clase", claseID)
                        insertarCmd.Parameters.AddWithValue("@periodo", periodoID)
                        insertarCmd.Parameters.AddWithValue("@fecha", DateTime.Now.Date)
                        insertarCmd.ExecuteNonQuery()
                    End If
                Next

                MessageBox.Show("Matrícula registrada exitosamente.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al registrar matrícula: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarEstudiantesPorCodigo()
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT EstudianteID, CodigoEstudiante FROM Estudiante", conn)
            Dim dtEst As New DataTable()
            dtEst.Load(cmd.ExecuteReader())

            cboEstudiante.DisplayMember = "CodigoEstudiante"
            cboEstudiante.ValueMember = "EstudianteID"
            cboEstudiante.DataSource = dtEst
        End Using
    End Sub



    Private Sub CargarClases()

        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                Dim query As String = "
                SELECT 
                    c.ClaseID,
                    g.NombreGrado,
                    a.Nombre AS NombreAsignatura,
                    m.Nombre + ' ' + m.Apellido AS NombreMaestro,
                    p.NombrePeriodo
                FROM Clase c
                JOIN Grado g ON c.GradoID = g.GradoID
                JOIN Asignatura a ON c.AsignaturaID = a.AsignaturaID
                JOIN Maestro m ON c.MaestroID = m.MaestroID
                JOIN Periodo p ON c.PeriodoID = p.PeriodoID
            "

                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        CheckedListBox1.Items.Clear()

                        While reader.Read()
                            Dim descripcion As String = $"{reader("NombreGrado")} - {reader("NombreAsignatura")} - {reader("NombreMaestro")} - {reader("NombrePeriodo")}"
                            Dim claseID As Integer = Convert.ToInt32(reader("ClaseID"))

                            Dim item As New ClaseItem With {
                                .ID = claseID,
                                .Texto = descripcion
                            }

                            CheckedListBox1.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar clases: " & ex.Message)
        End Try






    End Sub




    Private Sub CargarPeriodos()
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT PeriodoID, NombrePeriodo FROM Periodo", conn)
            Dim dtPeriodo As New DataTable()
            dtPeriodo.Load(cmd.ExecuteReader())
            cboPeriodo.DataSource = dtPeriodo
            cboPeriodo.DisplayMember = "NombrePeriodo"
            cboPeriodo.ValueMember = "PeriodoID"
        End Using
    End Sub

    Private Sub cboEstudiante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstudiante.SelectedIndexChanged
        If cboEstudiante.SelectedItem IsNot Nothing Then
            Dim row As DataRowView = CType(cboEstudiante.SelectedItem, DataRowView)
            Dim estudianteID As Integer = Convert.ToInt32(row("EstudianteID"))

            Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim cmd As New SqlCommand("
                SELECT Nombre + ' ' + Apellido AS NombreCompleto 
                FROM Estudiante 
                WHERE EstudianteID = @id", conn)
                cmd.Parameters.AddWithValue("@id", estudianteID)
                Dim nombre As String = Convert.ToString(cmd.ExecuteScalar())
                lblNombreEstudiante.Text = nombre
            End Using
        End If


    End Sub

    Public Class ClaseItem
        Public Property ID As Integer
        Public Property Texto As String

        Public Overrides Function ToString() As String
            Return Texto
        End Function
    End Class


    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub


    Private Function ObtenerEstudianteID(nombreCompleto As String) As Integer
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "SELECT EstudianteID FROM Estudiante WHERE Nombre + ' ' + Apellido = @nombre"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", nombreCompleto)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return -1 ' No encontrado
    End Function


    Private Sub MostrarClasesDelEstudiantePorAño(estudianteID As Integer, añoActual As Integer)
        Dim connString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "
            SELECT c.NombreClase, a.Nombre AS Asignatura, p.NombrePeriodo
            FROM Matricula m
            JOIN Clase c ON m.ClaseID = c.ClaseID
            JOIN Asignatura a ON c.AsignaturaID = a.AsignaturaID
            JOIN Periodo p ON m.PeriodoID = p.PeriodoID
            WHERE m.EstudianteID = @id AND YEAR(m.FechaMatricula) = @año"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", estudianteID)
                cmd.Parameters.AddWithValue("@año", añoActual)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ListBox1.Items.Clear()
                    While reader.Read()
                        Dim claseInfo As String = $"{reader("NombreClase")} - {reader("Asignatura")} - {reader("NombrePeriodo")}"
                        ListBox1.Items.Add(claseInfo)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub lblNombreEstudiante_Click(sender As Object, e As EventArgs) Handles lblNombreEstudiante.Click

        Dim nombreCompleto As String = lblNombreEstudiante.Text.Trim()
        Dim estudianteID As Integer = ObtenerEstudianteID(nombreCompleto)
        If estudianteID <> -1 Then
            Dim añoActual As Integer = DateTime.Now.Year
            MostrarClasesDelEstudiantePorAño(estudianteID, añoActual)
        Else
            MessageBox.Show("Estudiante no encontrado.")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim codigo As String = cboEstudiante.Text.Trim()
        If codigo = "" Then
            MessageBox.Show("Ingrese el código del estudiante.")
            Exit Sub
        End If

        MostrarReporteMatricula(codigo)


    End Sub
    Private Sub MostrarReporteMatricula(codigoEstudiante As String)
        Dim dt As New DataTable()
        Dim query As String = "
        SELECT *
        FROM VistaReporteMatriculaEstudiante
        WHERE CodigoEstudiante = @Codigo
          AND YEAR(FechaMatricula) = YEAR(GETDATE());"

        Dim connectionString As String = "Server=(localdb)\MSSQLLocalDB;Database=colegio1;Integrated Security=True"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Codigo", codigoEstudiante)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        ' Configurar el ReportViewer
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = "Report2.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSetMatricula", dt))
        ReportViewer1.RefreshReport()
    End Sub


End Class