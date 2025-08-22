<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MateriaToolStripMenuItem, Me.MatriculaToolStripMenuItem, Me.GradoToolStripMenuItem, Me.MaestroToolStripMenuItem, Me.InscripcionToolStripMenuItem, Me.PeriodoToolStripMenuItem, Me.ClaseToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'MateriaToolStripMenuItem
        '
        Me.MateriaToolStripMenuItem.Name = "MateriaToolStripMenuItem"
        Me.MateriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MateriaToolStripMenuItem.Text = "Materia"
        '
        'MatriculaToolStripMenuItem
        '
        Me.MatriculaToolStripMenuItem.Name = "MatriculaToolStripMenuItem"
        Me.MatriculaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MatriculaToolStripMenuItem.Text = "Alumno"
        '
        'GradoToolStripMenuItem
        '
        Me.GradoToolStripMenuItem.Name = "GradoToolStripMenuItem"
        Me.GradoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GradoToolStripMenuItem.Text = "Grado"
        '
        'MaestroToolStripMenuItem
        '
        Me.MaestroToolStripMenuItem.Name = "MaestroToolStripMenuItem"
        Me.MaestroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MaestroToolStripMenuItem.Text = "Maestro"
        '
        'InscripcionToolStripMenuItem
        '
        Me.InscripcionToolStripMenuItem.Name = "InscripcionToolStripMenuItem"
        Me.InscripcionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InscripcionToolStripMenuItem.Text = "Inscripcion "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(681, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 73)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(2, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1902, 31)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PeriodoToolStripMenuItem
        '
        Me.PeriodoToolStripMenuItem.Name = "PeriodoToolStripMenuItem"
        Me.PeriodoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PeriodoToolStripMenuItem.Text = "periodo"
        '
        'ClaseToolStripMenuItem
        '
        Me.ClaseToolStripMenuItem.Name = "ClaseToolStripMenuItem"
        Me.ClaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClaseToolStripMenuItem.Text = "Clase"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents MaestroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscripcionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClaseToolStripMenuItem As ToolStripMenuItem
End Class
