<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltasProv
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
        Dim Razon_SocialLabel As System.Windows.Forms.Label
        Dim CUITLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.Razon_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.CUITTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Razon_SocialLabel = New System.Windows.Forms.Label()
        CUITLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(26, 82)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 3
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Location = New System.Drawing.Point(26, 108)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(73, 13)
        Razon_SocialLabel.TabIndex = 5
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'CUITLabel
        '
        CUITLabel.AutoSize = True
        CUITLabel.Location = New System.Drawing.Point(26, 134)
        CUITLabel.Name = "CUITLabel"
        CUITLabel.Size = New System.Drawing.Size(35, 13)
        CUITLabel.TabIndex = 7
        CUITLabel.Text = "CUIT:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(26, 160)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "Direccion:"
        '
        'NroLabel
        '
        NroLabel.AutoSize = True
        NroLabel.Location = New System.Drawing.Point(26, 186)
        NroLabel.Name = "NroLabel"
        NroLabel.Size = New System.Drawing.Size(27, 13)
        NroLabel.TabIndex = 11
        NroLabel.Text = "Nro:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(26, 212)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 13
        TelefonoLabel.Text = "Telefono:"
        '
        'ZapateriaDataSet
        '
        Me.ZapateriaDataSet.DataSetName = "ZapateriaDataSet"
        Me.ZapateriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'Razon_SocialTextBox
        '
        Me.Razon_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Razon_Social", True))
        Me.Razon_SocialTextBox.Location = New System.Drawing.Point(105, 105)
        Me.Razon_SocialTextBox.Name = "Razon_SocialTextBox"
        Me.Razon_SocialTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Razon_SocialTextBox.TabIndex = 6
        '
        'CUITTextBox
        '
        Me.CUITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CUIT", True))
        Me.CUITTextBox.Location = New System.Drawing.Point(105, 131)
        Me.CUITTextBox.Name = "CUITTextBox"
        Me.CUITTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CUITTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(105, 157)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'NroTextBox
        '
        Me.NroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Nro", True))
        Me.NroTextBox.Location = New System.Drawing.Point(105, 183)
        Me.NroTextBox.Name = "NroTextBox"
        Me.NroTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NroTextBox.TabIndex = 12
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(105, 209)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TelefonoTextBox.TabIndex = 14
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(29, 268)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 15
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(143, 268)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 16
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.DataSource = Me.LocalidadBindingSource
        Me.CmbLocalidad.DisplayMember = "Localidad"
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Location = New System.Drawing.Point(105, 79)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(121, 21)
        Me.CmbLocalidad.TabIndex = 17
        Me.CmbLocalidad.ValueMember = "ID_Localidad"
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ingrese los datos del Proveedor:"
        '
        'AltasProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 325)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbLocalidad)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Razon_SocialLabel)
        Me.Controls.Add(Me.Razon_SocialTextBox)
        Me.Controls.Add(CUITLabel)
        Me.Controls.Add(Me.CUITTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NroLabel)
        Me.Controls.Add(Me.NroTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Name = "AltasProv"
        Me.Text = " "
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Razon_SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents CmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
