<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.txtNombreClase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboAsignatura = New System.Windows.Forms.ComboBox()
        Me.cboMaestro = New System.Windows.Forms.ComboBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de clase "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de la Clase"
        '
        'cboGrado
        '
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Location = New System.Drawing.Point(172, 116)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(121, 21)
        Me.cboGrado.TabIndex = 2
        '
        'txtNombreClase
        '
        Me.txtNombreClase.Location = New System.Drawing.Point(142, 74)
        Me.txtNombreClase.Name = "txtNombreClase"
        Me.txtNombreClase.Size = New System.Drawing.Size(195, 20)
        Me.txtNombreClase.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Crear Clase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "seleccionar Grado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Seleccionar Asignatura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Seleccionar Maestro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Seleccionar Periodo"
        '
        'cboAsignatura
        '
        Me.cboAsignatura.FormattingEnabled = True
        Me.cboAsignatura.Location = New System.Drawing.Point(172, 156)
        Me.cboAsignatura.Name = "cboAsignatura"
        Me.cboAsignatura.Size = New System.Drawing.Size(121, 21)
        Me.cboAsignatura.TabIndex = 9
        '
        'cboMaestro
        '
        Me.cboMaestro.FormattingEnabled = True
        Me.cboMaestro.Location = New System.Drawing.Point(172, 194)
        Me.cboMaestro.Name = "cboMaestro"
        Me.cboMaestro.Size = New System.Drawing.Size(121, 21)
        Me.cboMaestro.TabIndex = 10
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(174, 230)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cboPeriodo.TabIndex = 11
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(172, 273)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(134, 23)
        Me.Guardar.TabIndex = 12
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'clase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.cboMaestro)
        Me.Controls.Add(Me.cboAsignatura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreClase)
        Me.Controls.Add(Me.cboGrado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "clase"
        Me.Text = "clase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboGrado As ComboBox
    Friend WithEvents txtNombreClase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboAsignatura As ComboBox
    Friend WithEvents cboMaestro As ComboBox
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents Guardar As Button
End Class
