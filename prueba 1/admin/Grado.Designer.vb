<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grado
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
        Me.components = New System.ComponentModel.Container()
        Me.GradoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Colegio1DataSet3 = New prueba_1.colegio1DataSet3()
        Me.GradoTableAdapter = New prueba_1.colegio1DataSet3TableAdapters.GradoTableAdapter()
        Me.txtNombreGrado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Colegio1DataSet4 = New prueba_1.colegio1DataSet4()
        Me.Colegio1DataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreGradoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GradoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradoBindingSource
        '
        Me.GradoBindingSource.DataMember = "Grado"
        Me.GradoBindingSource.DataSource = Me.Colegio1DataSet3
        '
        'Colegio1DataSet3
        '
        Me.Colegio1DataSet3.DataSetName = "colegio1DataSet3"
        Me.Colegio1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradoTableAdapter
        '
        Me.GradoTableAdapter.ClearBeforeFill = True
        '
        'txtNombreGrado
        '
        Me.txtNombreGrado.Location = New System.Drawing.Point(62, 110)
        Me.txtNombreGrado.Name = "txtNombreGrado"
        Me.txtNombreGrado.Size = New System.Drawing.Size(125, 20)
        Me.txtNombreGrado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Grado"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GradoID, Me.NombreGradoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GradoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(262, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(259, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'Colegio1DataSet4
        '
        Me.Colegio1DataSet4.DataSetName = "colegio1DataSet4"
        Me.Colegio1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Colegio1DataSet4BindingSource
        '
        Me.Colegio1DataSet4BindingSource.DataSource = Me.Colegio1DataSet4
        Me.Colegio1DataSet4BindingSource.Position = 0
        '
        'GradoID
        '
        Me.GradoID.DataPropertyName = "GradoID"
        Me.GradoID.HeaderText = "GradoID"
        Me.GradoID.Name = "GradoID"
        Me.GradoID.ReadOnly = True
        '
        'NombreGradoDataGridViewTextBoxColumn
        '
        Me.NombreGradoDataGridViewTextBoxColumn.DataPropertyName = "NombreGrado"
        Me.NombreGradoDataGridViewTextBoxColumn.HeaderText = "NombreGrado"
        Me.NombreGradoDataGridViewTextBoxColumn.Name = "NombreGradoDataGridViewTextBoxColumn"
        '
        'Grado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 347)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreGrado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Grado"
        Me.Text = "Grado"
        CType(Me.GradoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Colegio1DataSet3 As colegio1DataSet3
    Friend WithEvents GradoBindingSource As BindingSource
    Friend WithEvents GradoTableAdapter As colegio1DataSet3TableAdapters.GradoTableAdapter
    Friend WithEvents txtNombreGrado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Colegio1DataSet4BindingSource As BindingSource
    Friend WithEvents Colegio1DataSet4 As colegio1DataSet4
    Friend WithEvents GradoID As DataGridViewTextBoxColumn
    Friend WithEvents NombreGradoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
