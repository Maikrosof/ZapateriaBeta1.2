<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaEmpl
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
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Fec_NacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Fec_ContrDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
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
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(42, 102)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 3
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(42, 128)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 5
        DNILabel.Text = "DNI:"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(132, 125)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(200, 20)
        Me.DNITextBox.TabIndex = 6
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(42, 154)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(132, 151)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 8
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(42, 180)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 9
        ApellidoLabel.Text = "Apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(132, 177)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidoTextBox.TabIndex = 10
        '
        'Fec_NacimientoLabel
        '
        Fec_NacimientoLabel.AutoSize = True
        Fec_NacimientoLabel.Location = New System.Drawing.Point(42, 207)
        Fec_NacimientoLabel.Name = "Fec_NacimientoLabel"
        Fec_NacimientoLabel.Size = New System.Drawing.Size(84, 13)
        Fec_NacimientoLabel.TabIndex = 11
        Fec_NacimientoLabel.Text = "Fec Nacimiento:"
        '
        'Fec_NacimientoDateTimePicker
        '
        Me.Fec_NacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "Fec_Nacimiento", True))
        Me.Fec_NacimientoDateTimePicker.Location = New System.Drawing.Point(132, 203)
        Me.Fec_NacimientoDateTimePicker.Name = "Fec_NacimientoDateTimePicker"
        Me.Fec_NacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fec_NacimientoDateTimePicker.TabIndex = 12
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(42, 232)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 13
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(132, 229)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DireccionTextBox.TabIndex = 14
        '
        'NroLabel
        '
        NroLabel.AutoSize = True
        NroLabel.Location = New System.Drawing.Point(42, 258)
        NroLabel.Name = "NroLabel"
        NroLabel.Size = New System.Drawing.Size(27, 13)
        NroLabel.TabIndex = 15
        NroLabel.Text = "Nro:"
        '
        'NroTextBox
        '
        Me.NroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nro", True))
        Me.NroTextBox.Location = New System.Drawing.Point(132, 255)
        Me.NroTextBox.Name = "NroTextBox"
        Me.NroTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NroTextBox.TabIndex = 16
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(42, 284)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 17
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(132, 281)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoTextBox.TabIndex = 18
        '
        'Fec_ContrLabel
        '
        Fec_ContrLabel.AutoSize = True
        Fec_ContrLabel.Location = New System.Drawing.Point(42, 311)
        Fec_ContrLabel.Name = "Fec_ContrLabel"
        Fec_ContrLabel.Size = New System.Drawing.Size(56, 13)
        Fec_ContrLabel.TabIndex = 19
        Fec_ContrLabel.Text = "Fec Contr:"
        '
        'Fec_ContrDateTimePicker
        '
        Me.Fec_ContrDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "Fec_Contr", True))
        Me.Fec_ContrDateTimePicker.Location = New System.Drawing.Point(132, 307)
        Me.Fec_ContrDateTimePicker.Name = "Fec_ContrDateTimePicker"
        Me.Fec_ContrDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fec_ContrDateTimePicker.TabIndex = 20
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(42, 336)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(38, 13)
        CargoLabel.TabIndex = 21
        CargoLabel.Text = "Cargo:"
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(132, 333)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CargoTextBox.TabIndex = 22
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Ingrese los datos del Empleado:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(29, 407)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(132, 34)
        Me.BtnGuardar.TabIndex = 24
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(209, 407)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(132, 34)
        Me.BtnVolver.TabIndex = 25
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.DataSource = Me.LocalidadBindingSource
        Me.CmbLocalidad.DisplayMember = "Localidad"
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Location = New System.Drawing.Point(132, 99)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CmbLocalidad.TabIndex = 26
        Me.CmbLocalidad.ValueMember = "ID_Localidad"
        '
        'AltaEmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 477)
        Me.Controls.Add(Me.CmbLocalidad)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ID_LocalidadLabel)
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
        Me.Name = "AltaEmpl"
        Me.Text = "AltaEmpl"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fec_NacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fec_ContrDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents CmbLocalidad As System.Windows.Forms.ComboBox
End Class
