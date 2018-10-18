<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prov
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
        Dim ID_ProveedorLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Razon_SocialLabel As System.Windows.Forms.Label
        Dim CUITLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prov))
        Me.ID_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Razon_SocialTextBox = New System.Windows.Forms.TextBox()
        Me.CUITTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAdelante = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificaciones = New System.Windows.Forms.Button()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.IDProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDLocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        ID_ProveedorLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Razon_SocialLabel = New System.Windows.Forms.Label()
        CUITLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ProveedorLabel
        '
        ID_ProveedorLabel.AutoSize = True
        ID_ProveedorLabel.BackColor = System.Drawing.Color.Transparent
        ID_ProveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ProveedorLabel.Location = New System.Drawing.Point(6, 146)
        ID_ProveedorLabel.Name = "ID_ProveedorLabel"
        ID_ProveedorLabel.Size = New System.Drawing.Size(86, 13)
        ID_ProveedorLabel.TabIndex = 1
        ID_ProveedorLabel.Text = "ID Proveedor:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.BackColor = System.Drawing.Color.Transparent
        ID_LocalidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_LocalidadLabel.Location = New System.Drawing.Point(6, 172)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(83, 13)
        ID_LocalidadLabel.TabIndex = 3
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.BackColor = System.Drawing.Color.Transparent
        Razon_SocialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Razon_SocialLabel.Location = New System.Drawing.Point(6, 198)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(86, 13)
        Razon_SocialLabel.TabIndex = 5
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'CUITLabel
        '
        CUITLabel.AutoSize = True
        CUITLabel.BackColor = System.Drawing.Color.Transparent
        CUITLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CUITLabel.Location = New System.Drawing.Point(6, 224)
        CUITLabel.Name = "CUITLabel"
        CUITLabel.Size = New System.Drawing.Size(40, 13)
        CUITLabel.TabIndex = 7
        CUITLabel.Text = "CUIT:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.BackColor = System.Drawing.Color.Transparent
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(6, 250)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(65, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "Direccion:"
        '
        'NroLabel
        '
        NroLabel.AutoSize = True
        NroLabel.BackColor = System.Drawing.Color.Transparent
        NroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroLabel.Location = New System.Drawing.Point(9, 276)
        NroLabel.Name = "NroLabel"
        NroLabel.Size = New System.Drawing.Size(31, 13)
        NroLabel.TabIndex = 11
        NroLabel.Text = "Nro:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.Transparent
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(6, 302)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(61, 13)
        TelefonoLabel.TabIndex = 13
        TelefonoLabel.Text = "Telefono:"
        '
        'ID_ProveedorTextBox
        '
        Me.ID_ProveedorTextBox.Location = New System.Drawing.Point(99, 143)
        Me.ID_ProveedorTextBox.Name = "ID_ProveedorTextBox"
        Me.ID_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_ProveedorTextBox.TabIndex = 2
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(99, 169)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 4
        '
        'Razon_SocialTextBox
        '
        Me.Razon_SocialTextBox.Location = New System.Drawing.Point(99, 195)
        Me.Razon_SocialTextBox.Name = "Razon_SocialTextBox"
        Me.Razon_SocialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Razon_SocialTextBox.TabIndex = 6
        '
        'CUITTextBox
        '
        Me.CUITTextBox.Location = New System.Drawing.Point(99, 221)
        Me.CUITTextBox.Name = "CUITTextBox"
        Me.CUITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUITTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(99, 247)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'NroTextBox
        '
        Me.NroTextBox.Location = New System.Drawing.Point(99, 273)
        Me.NroTextBox.Name = "NroTextBox"
        Me.NroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NroTextBox.TabIndex = 12
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(99, 299)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 62)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Agregar[F1]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnPrimero
        '
        Me.BtnPrimero.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrimero.BackgroundImage = CType(resources.GetObject("BtnPrimero.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPrimero.Location = New System.Drawing.Point(16, 331)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(39, 38)
        Me.BtnPrimero.TabIndex = 16
        Me.BtnPrimero.UseVisualStyleBackColor = False
        '
        'BtnAtras
        '
        Me.BtnAtras.BackColor = System.Drawing.Color.Transparent
        Me.BtnAtras.BackgroundImage = CType(resources.GetObject("BtnAtras.BackgroundImage"), System.Drawing.Image)
        Me.BtnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAtras.Location = New System.Drawing.Point(61, 331)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(39, 38)
        Me.BtnAtras.TabIndex = 17
        Me.BtnAtras.UseVisualStyleBackColor = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.BackColor = System.Drawing.Color.Transparent
        Me.BtnUltimo.BackgroundImage = CType(resources.GetObject("BtnUltimo.BackgroundImage"), System.Drawing.Image)
        Me.BtnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUltimo.Location = New System.Drawing.Point(151, 331)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(39, 38)
        Me.BtnUltimo.TabIndex = 19
        Me.BtnUltimo.UseVisualStyleBackColor = False
        '
        'BtnAdelante
        '
        Me.BtnAdelante.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdelante.BackgroundImage = CType(resources.GetObject("BtnAdelante.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdelante.Location = New System.Drawing.Point(106, 331)
        Me.BtnAdelante.Name = "BtnAdelante"
        Me.BtnAdelante.Size = New System.Drawing.Size(39, 38)
        Me.BtnAdelante.TabIndex = 18
        Me.BtnAdelante.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVolver.Location = New System.Drawing.Point(784, 42)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(176, 62)
        Me.BtnVolver.TabIndex = 20
        Me.BtnVolver.Text = "Volver[Esc]"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBuscar.Location = New System.Drawing.Point(592, 42)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(176, 62)
        Me.BtnBuscar.TabIndex = 21
        Me.BtnBuscar.Text = "Busquedas[F4]"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEliminar.Location = New System.Drawing.Point(207, 42)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(176, 62)
        Me.BtnEliminar.TabIndex = 22
        Me.BtnEliminar.Text = "Eliminar[F2]"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificaciones
        '
        Me.BtnModificaciones.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnModificaciones.BackgroundImage = CType(resources.GetObject("BtnModificaciones.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnModificaciones.Location = New System.Drawing.Point(398, 42)
        Me.BtnModificaciones.Name = "BtnModificaciones"
        Me.BtnModificaciones.Size = New System.Drawing.Size(178, 62)
        Me.BtnModificaciones.TabIndex = 23
        Me.BtnModificaciones.Text = "Modificaciones[F3]"
        Me.BtnModificaciones.UseVisualStyleBackColor = False
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProveedorDataGridViewTextBoxColumn, Me.IDLocalidadDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.NroDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(231, 143)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(727, 220)
        Me.ProveedoresDataGridView.TabIndex = 23
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
        'IDProveedorDataGridViewTextBoxColumn
        '
        Me.IDProveedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Proveedor"
        Me.IDProveedorDataGridViewTextBoxColumn.HeaderText = "ID_Proveedor"
        Me.IDProveedorDataGridViewTextBoxColumn.Name = "IDProveedorDataGridViewTextBoxColumn"
        Me.IDProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDLocalidadDataGridViewTextBoxColumn
        '
        Me.IDLocalidadDataGridViewTextBoxColumn.DataPropertyName = "ID_Localidad"
        Me.IDLocalidadDataGridViewTextBoxColumn.HeaderText = "ID_Localidad"
        Me.IDLocalidadDataGridViewTextBoxColumn.Name = "IDLocalidadDataGridViewTextBoxColumn"
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "Razon_Social"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razon_Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'NroDataGridViewTextBoxColumn
        '
        Me.NroDataGridViewTextBoxColumn.DataPropertyName = "Nro"
        Me.NroDataGridViewTextBoxColumn.HeaderText = "Nro"
        Me.NroDataGridViewTextBoxColumn.Name = "NroDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
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
        'Prov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(970, 380)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(Me.BtnModificaciones)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnUltimo)
        Me.Controls.Add(Me.BtnAdelante)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnPrimero)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID_ProveedorLabel)
        Me.Controls.Add(Me.ID_ProveedorTextBox)
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
        Me.Name = "Prov"
        Me.Text = "Prov"
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Razon_SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAdelante As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnModificaciones As System.Windows.Forms.Button
    Friend WithEvents ProveedoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDLocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
End Class
