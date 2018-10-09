<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Producto
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
        Dim ID_MarcaLabel As System.Windows.Forms.Label
        Dim ID_ProveedorLabel As System.Windows.Forms.Label
        Dim TallaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim EstiloLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.MarcasTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.MarcasTableAdapter()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.TallaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.EstiloTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        ID_MarcaLabel = New System.Windows.Forms.Label()
        ID_ProveedorLabel = New System.Windows.Forms.Label()
        TallaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        EstiloLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_MarcaLabel
        '
        ID_MarcaLabel.AutoSize = True
        ID_MarcaLabel.Location = New System.Drawing.Point(23, 31)
        ID_MarcaLabel.Name = "ID_MarcaLabel"
        ID_MarcaLabel.Size = New System.Drawing.Size(54, 13)
        ID_MarcaLabel.TabIndex = 3
        ID_MarcaLabel.Text = "ID Marca:"
        '
        'ID_ProveedorLabel
        '
        ID_ProveedorLabel.AutoSize = True
        ID_ProveedorLabel.Location = New System.Drawing.Point(23, 57)
        ID_ProveedorLabel.Name = "ID_ProveedorLabel"
        ID_ProveedorLabel.Size = New System.Drawing.Size(73, 13)
        ID_ProveedorLabel.TabIndex = 5
        ID_ProveedorLabel.Text = "ID Proveedor:"
        '
        'TallaLabel
        '
        TallaLabel.AutoSize = True
        TallaLabel.Location = New System.Drawing.Point(23, 108)
        TallaLabel.Name = "TallaLabel"
        TallaLabel.Size = New System.Drawing.Size(33, 13)
        TallaLabel.TabIndex = 7
        TallaLabel.Text = "Talla:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(23, 134)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 9
        PrecioLabel.Text = "Precio:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(23, 160)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 11
        ColorLabel.Text = "Color:"
        '
        'EstiloLabel
        '
        EstiloLabel.AutoSize = True
        EstiloLabel.Location = New System.Drawing.Point(23, 186)
        EstiloLabel.Name = "EstiloLabel"
        EstiloLabel.Size = New System.Drawing.Size(35, 13)
        EstiloLabel.TabIndex = 13
        EstiloLabel.Text = "Estilo:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(23, 212)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 15
        StockLabel.Text = "Stock:"
        '
        'ZapateriaDataSet
        '
        Me.ZapateriaDataSet.DataSetName = "ZapateriaDataSet"
        Me.ZapateriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ID_MarcaTextBox
        '
        Me.ID_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ID_Marca", True))
        Me.ID_MarcaTextBox.Location = New System.Drawing.Point(102, 28)
        Me.ID_MarcaTextBox.Name = "ID_MarcaTextBox"
        Me.ID_MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_MarcaTextBox.TabIndex = 4
        '
        'ID_ProveedorTextBox
        '
        Me.ID_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ID_Proveedor", True))
        Me.ID_ProveedorTextBox.Location = New System.Drawing.Point(102, 54)
        Me.ID_ProveedorTextBox.Name = "ID_ProveedorTextBox"
        Me.ID_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_ProveedorTextBox.TabIndex = 6
        '
        'TallaTextBox
        '
        Me.TallaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Talla", True))
        Me.TallaTextBox.Location = New System.Drawing.Point(102, 105)
        Me.TallaTextBox.Name = "TallaTextBox"
        Me.TallaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TallaTextBox.TabIndex = 8
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(102, 131)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 10
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(102, 157)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColorTextBox.TabIndex = 12
        '
        'EstiloTextBox
        '
        Me.EstiloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Estilo", True))
        Me.EstiloTextBox.Location = New System.Drawing.Point(102, 183)
        Me.EstiloTextBox.Name = "EstiloTextBox"
        Me.EstiloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstiloTextBox.TabIndex = 14
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(102, 209)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StockTextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 72)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 74)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(23, 83)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(45, 13)
        ModeloLabel.TabIndex = 18
        ModeloLabel.Text = "Modelo:"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(102, 80)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloTextBox.TabIndex = 19
        '
        'Alta_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 276)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID_MarcaLabel)
        Me.Controls.Add(Me.ID_MarcaTextBox)
        Me.Controls.Add(ID_ProveedorLabel)
        Me.Controls.Add(Me.ID_ProveedorTextBox)
        Me.Controls.Add(TallaLabel)
        Me.Controls.Add(Me.TallaTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(EstiloLabel)
        Me.Controls.Add(Me.EstiloTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.KeyPreview = True
        Me.Name = "Alta_Producto"
        Me.Text = "Alta_Producto"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MarcasTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TallaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstiloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
End Class
