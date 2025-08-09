<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maestro
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Colegio1DataSet5 = New prueba_1.colegio1DataSet5()
        Me.MaestroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaestroTableAdapter = New prueba_1.colegio1DataSet5TableAdapters.MaestroTableAdapter()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Colegio1DataSet6 = New prueba_1.colegio1DataSet6()
        Me.VistaMaestroConUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaMaestroConUsuarioTableAdapter = New prueba_1.colegio1DataSet6TableAdapters.VistaMaestroConUsuarioTableAdapter()
        Me.Colegio1DataSet7 = New prueba_1.colegio1DataSet7()
        Me.VistaMaestroConUsuario1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaMaestroConUsuario1TableAdapter = New prueba_1.colegio1DataSet7TableAdapters.VistaMaestroConUsuario1TableAdapter()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaestroID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordHash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colegio1DataSet8 = New prueba_1.colegio1DataSet8()
        Me.VistaMaestroConUsuario1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaMaestroConUsuario1TableAdapter1 = New prueba_1.colegio1DataSet8TableAdapters.VistaMaestroConUsuario1TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaestroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMaestroConUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMaestroConUsuario1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colegio1DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMaestroConUsuario1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaestroID, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.Username, Me.PasswordHash})
        Me.DataGridView1.DataSource = Me.VistaMaestroConUsuario1BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(77, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(828, 166)
        Me.DataGridView1.TabIndex = 0
        '
        'Colegio1DataSet5
        '
        Me.Colegio1DataSet5.DataSetName = "colegio1DataSet5"
        Me.Colegio1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaestroBindingSource
        '
        Me.MaestroBindingSource.DataMember = "Maestro"
        Me.MaestroBindingSource.DataSource = Me.Colegio1DataSet5
        '
        'MaestroTableAdapter
        '
        Me.MaestroTableAdapter.ClearBeforeFill = True
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(77, 129)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxNombre.TabIndex = 1
        '
        'Colegio1DataSet6
        '
        Me.Colegio1DataSet6.DataSetName = "colegio1DataSet6"
        Me.Colegio1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaMaestroConUsuarioBindingSource
        '
        Me.VistaMaestroConUsuarioBindingSource.DataMember = "VistaMaestroConUsuario"
        Me.VistaMaestroConUsuarioBindingSource.DataSource = Me.Colegio1DataSet6
        '
        'VistaMaestroConUsuarioTableAdapter
        '
        Me.VistaMaestroConUsuarioTableAdapter.ClearBeforeFill = True
        '
        'Colegio1DataSet7
        '
        Me.Colegio1DataSet7.DataSetName = "colegio1DataSet7"
        Me.Colegio1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaMaestroConUsuario1BindingSource
        '
        Me.VistaMaestroConUsuario1BindingSource.DataMember = "VistaMaestroConUsuario1"
        Me.VistaMaestroConUsuario1BindingSource.DataSource = Me.Colegio1DataSet7
        '
        'VistaMaestroConUsuario1TableAdapter
        '
        Me.VistaMaestroConUsuario1TableAdapter.ClearBeforeFill = True
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(433, 129)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxDireccion.TabIndex = 5
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(241, 129)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxApellido.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(665, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(430, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion"
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(668, 128)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSexo.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(830, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(830, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 45)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MaestroID
        '
        Me.MaestroID.DataPropertyName = "MaestroID"
        Me.MaestroID.HeaderText = "MaestroID"
        Me.MaestroID.Name = "MaestroID"
        Me.MaestroID.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'Username
        '
        Me.Username.DataPropertyName = "Username"
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'PasswordHash
        '
        Me.PasswordHash.DataPropertyName = "PasswordHash"
        Me.PasswordHash.HeaderText = "PasswordHash"
        Me.PasswordHash.Name = "PasswordHash"
        Me.PasswordHash.ReadOnly = True
        '
        'Colegio1DataSet8
        '
        Me.Colegio1DataSet8.DataSetName = "colegio1DataSet8"
        Me.Colegio1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaMaestroConUsuario1BindingSource1
        '
        Me.VistaMaestroConUsuario1BindingSource1.DataMember = "VistaMaestroConUsuario1"
        Me.VistaMaestroConUsuario1BindingSource1.DataSource = Me.Colegio1DataSet8
        '
        'VistaMaestroConUsuario1TableAdapter1
        '
        Me.VistaMaestroConUsuario1TableAdapter1.ClearBeforeFill = True
        '
        'Maestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 553)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxSexo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Maestro"
        Me.Text = "Maestro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaestroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMaestroConUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMaestroConUsuario1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colegio1DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMaestroConUsuario1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Colegio1DataSet5 As colegio1DataSet5
    Friend WithEvents MaestroBindingSource As BindingSource
    Friend WithEvents MaestroTableAdapter As colegio1DataSet5TableAdapters.MaestroTableAdapter
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Colegio1DataSet6 As colegio1DataSet6
    Friend WithEvents VistaMaestroConUsuarioBindingSource As BindingSource
    Friend WithEvents VistaMaestroConUsuarioTableAdapter As colegio1DataSet6TableAdapters.VistaMaestroConUsuarioTableAdapter
    Friend WithEvents Colegio1DataSet7 As colegio1DataSet7
    Friend WithEvents VistaMaestroConUsuario1BindingSource As BindingSource
    Friend WithEvents VistaMaestroConUsuario1TableAdapter As colegio1DataSet7TableAdapters.VistaMaestroConUsuario1TableAdapter
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MaestroID As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents PasswordHash As DataGridViewTextBoxColumn
    Friend WithEvents Colegio1DataSet8 As colegio1DataSet8
    Friend WithEvents VistaMaestroConUsuario1BindingSource1 As BindingSource
    Friend WithEvents VistaMaestroConUsuario1TableAdapter1 As colegio1DataSet8TableAdapters.VistaMaestroConUsuario1TableAdapter
End Class
