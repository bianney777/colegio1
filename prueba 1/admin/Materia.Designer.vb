<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Materia
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AsignaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Colegio1DataSet = New prueba_1.colegio1DataSet()
        Me.txtNombreAsignatura = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.AsignaturaTableAdapter = New prueba_1.colegio1DataSetTableAdapters.AsignaturaTableAdapter()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.AsignaturaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(454, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AsignaturaID, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AsignaturaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(526, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'AsignaturaBindingSource
        '
        Me.AsignaturaBindingSource.DataMember = "Asignatura"
        Me.AsignaturaBindingSource.DataSource = Me.Colegio1DataSet
        '
        'Colegio1DataSet
        '
        Me.Colegio1DataSet.DataSetName = "colegio1DataSet"
        Me.Colegio1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombreAsignatura
        '
        Me.txtNombreAsignatura.Location = New System.Drawing.Point(44, 23)
        Me.txtNombreAsignatura.Name = "txtNombreAsignatura"
        Me.txtNombreAsignatura.Size = New System.Drawing.Size(165, 20)
        Me.txtNombreAsignatura.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(215, 23)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(233, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'AsignaturaTableAdapter
        '
        Me.AsignaturaTableAdapter.ClearBeforeFill = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(483, 205)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 4
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'AsignaturaID
        '
        Me.AsignaturaID.DataPropertyName = "AsignaturaID"
        Me.AsignaturaID.HeaderText = "AsignaturaID"
        Me.AsignaturaID.Name = "AsignaturaID"
        Me.AsignaturaID.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'Materia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 255)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreAsignatura)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Materia"
        Me.Text = "Materia"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNombreAsignatura As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Colegio1DataSet As colegio1DataSet
    Friend WithEvents AsignaturaBindingSource As BindingSource
    Friend WithEvents AsignaturaTableAdapter As colegio1DataSetTableAdapters.AsignaturaTableAdapter
    Friend WithEvents Eliminar As Button
    Friend WithEvents AsignaturaID As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
