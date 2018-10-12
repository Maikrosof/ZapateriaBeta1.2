<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModEmpl
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
        Dim ID_EmpLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Fec_NacimientoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Fec_ContrLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_EmpTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Fec_NacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Fec_ContrDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        ID_EmpLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Fec_NacimientoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Fec_ContrLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_EmpLabel
        '
        ID_EmpLabel.AutoSize = True
        ID_EmpLabel.Location = New System.Drawing.Point(15, 73)
        ID_EmpLabel.Name = "ID_EmpLabel"
        ID_EmpLabel.Size = New System.Drawing.Size(45, 13)
        ID_EmpLabel.TabIndex = 2
        ID_EmpLabel.Text = "ID Emp:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(15, 99)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 4
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(15, 125)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 6
        DNILabel.Text = "DNI:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(15, 151)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 8
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(15, 177)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 10
        ApellidoLabel.Text = "Apellido:"
        '
        'Fec_NacimientoLabel
        '
        Fec_NacimientoLabel.AutoSize = True
        Fec_NacimientoLabel.Location = New System.Drawing.Point(15, 204)
        Fec_NacimientoLabel.Name = "Fec_NacimientoLabel"
        Fec_NacimientoLabel.Size = New System.Drawing.Size(84, 13)
        Fec_NacimientoLabel.TabIndex = 12
        Fec_NacimientoLabel.Text = "Fec Nacimiento:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(15, 229)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 14
        DireccionLabel.Text = "Direccion:"
        '
        'NroLabel
        '
        NroLabel.AutoSize = True
        NroLabel.Location = New System.Drawing.Point(15, 255)
        NroLabel.Name = "NroLabel"
        NroLabel.Size = New System.Drawing.Size(27, 13)
        NroLabel.TabIndex = 16
        NroLabel.Text = "Nro:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(15, 281)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 18
        TelefonoLabel.Text = "Telefono:"
        '
        'Fec_ContrLabel
        '
        Fec_ContrLabel.AutoSize = True
        Fec_ContrLabel.Location = New System.Drawing.Point(15, 308)
        Fec_ContrLabel.Name = "Fec_ContrLabel"
        Fec_ContrLabel.Size = New System.Drawing.Size(56, 13)
        Fec_ContrLabel.TabIndex = 20
        Fec_ContrLabel.Text = "Fec Contr:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(15, 333)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(38, 13)
        CargoLabel.TabIndex = 22
        CargoLabel.Text = "Cargo:"
        '
        'ZapateriaDataSet
        '
        Me.ZapateriaDataSet.DataSetName = "ZapateriaDataSet"
        Me.ZapateriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(330, 70)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(628, 280)
        Me.EmpleadosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Emp"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Emp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fec_Nacimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fec_Nacimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nro"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nro"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fec_Contr"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fec_Contr"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ID_EmpTextBox
        '
        Me.ID_EmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "ID_Emp", True))
        Me.ID_EmpTextBox.Location = New System.Drawing.Point(105, 70)
        Me.ID_EmpTextBox.Name = "ID_EmpTextBox"
        Me.ID_EmpTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_EmpTextBox.TabIndex = 3
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(105, 96)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_LocalidadTextBox.TabIndex = 5
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(105, 122)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(200, 20)
        Me.DNITextBox.TabIndex = 7
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(105, 148)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 9
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(105, 174)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidoTextBox.TabIndex = 11
        '
        'Fec_NacimientoDateTimePicker
        '
        Me.Fec_NacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "Fec_Nacimiento", True))
        Me.Fec_NacimientoDateTimePicker.Location = New System.Drawing.Point(105, 200)
        Me.Fec_NacimientoDateTimePicker.Name = "Fec_NacimientoDateTimePicker"
        Me.Fec_NacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fec_NacimientoDateTimePicker.TabIndex = 13
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(105, 226)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox.TabIndex = 15
        '
        'NroTextBox
        '
        Me.NroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nro", True))
        Me.NroTextBox.Location = New System.Drawing.Point(105, 252)
        Me.NroTextBox.Name = "NroTextBox"
        Me.NroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NroTextBox.TabIndex = 17
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(105, 278)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoTextBox.TabIndex = 19
        '
        'Fec_ContrDateTimePicker
        '
        Me.Fec_ContrDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "Fec_Contr", True))
        Me.Fec_ContrDateTimePicker.Location = New System.Drawing.Point(105, 304)
        Me.Fec_ContrDateTimePicker.Name = "Fec_ContrDateTimePicker"
        Me.Fec_ContrDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fec_ContrDateTimePicker.TabIndex = 21
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(105, 330)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CargoTextBox.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Modificaciones por Empleado"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(828, 372)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(117, 55)
        Me.BtnVolver.TabIndex = 36
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(154, 372)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(117, 55)
        Me.BtnModificar.TabIndex = 35
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(6, 372)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(117, 55)
        Me.BtnBuscar.TabIndex = 34
        Me.BtnBuscar.Text = "Buscar por DNI"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ModEmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 439)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ID_EmpLabel)
        Me.Controls.Add(Me.ID_EmpTextBox)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Fec_NacimientoLabel)
        Me.Controls.Add(Me.Fec_NacimientoDateTimePicker)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NroLabel)
        Me.Controls.Add(Me.NroTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Fec_ContrLabel)
        Me.Controls.Add(Me.Fec_ContrDateTimePicker)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoTextBox)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.KeyPreview = True
        Me.Name = "ModEmpl"
        Me.Text = "ModEmpl"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_EmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fec_NacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fec_ContrDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
End Class
