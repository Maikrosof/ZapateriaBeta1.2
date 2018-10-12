<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModProv
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
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Razon_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.CUITTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Razon_SocialLabel = New System.Windows.Forms.Label()
        CUITLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(31, 101)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 3
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Location = New System.Drawing.Point(31, 127)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(73, 13)
        Razon_SocialLabel.TabIndex = 5
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'CUITLabel
        '
        CUITLabel.AutoSize = True
        CUITLabel.Location = New System.Drawing.Point(31, 153)
        CUITLabel.Name = "CUITLabel"
        CUITLabel.Size = New System.Drawing.Size(35, 13)
        CUITLabel.TabIndex = 7
        CUITLabel.Text = "CUIT:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(31, 179)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "Direccion:"
        '
        'NroLabel
        '
        NroLabel.AutoSize = True
        NroLabel.Location = New System.Drawing.Point(31, 205)
        NroLabel.Name = "NroLabel"
        NroLabel.Size = New System.Drawing.Size(27, 13)
        NroLabel.TabIndex = 11
        NroLabel.Text = "Nro:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(31, 231)
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
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(110, 98)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 4
        '
        'Razon_SocialTextBox
        '
        Me.Razon_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Razon_Social", True))
        Me.Razon_SocialTextBox.Location = New System.Drawing.Point(110, 124)
        Me.Razon_SocialTextBox.Name = "Razon_SocialTextBox"
        Me.Razon_SocialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Razon_SocialTextBox.TabIndex = 6
        '
        'CUITTextBox
        '
        Me.CUITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CUIT", True))
        Me.CUITTextBox.Location = New System.Drawing.Point(110, 150)
        Me.CUITTextBox.Name = "CUITTextBox"
        Me.CUITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUITTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(110, 176)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'NroTextBox
        '
        Me.NroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Nro", True))
        Me.NroTextBox.Location = New System.Drawing.Point(110, 202)
        Me.NroTextBox.Name = "NroTextBox"
        Me.NroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NroTextBox.TabIndex = 12
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(110, 228)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 14
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(235, 45)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(638, 220)
        Me.ProveedoresDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Proveedor"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Razon_Social"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razon_Social"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CUIT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CUIT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Modificaciones por Proveedor:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(16, 292)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(117, 55)
        Me.BtnBuscar.TabIndex = 26
        Me.BtnBuscar.Text = "Buscar por CUIT"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(164, 292)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(117, 55)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(756, 292)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(117, 55)
        Me.BtnVolver.TabIndex = 28
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'ModProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 359)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
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
        Me.KeyPreview = True
        Me.Name = "ModProv"
        Me.Text = "ModProv"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Razon_SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
End Class
