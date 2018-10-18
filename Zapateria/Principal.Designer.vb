<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.ClientesTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.EmpleadosTableAdapter()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.MarcasTableAdapter()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.ProductosTableAdapter()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.VentasTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorEmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorLocalidadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.White
        Me.BtnVenta.BackgroundImage = CType(resources.GetObject("BtnVenta.BackgroundImage"), System.Drawing.Image)
        Me.BtnVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVenta.Location = New System.Drawing.Point(14, 65)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(320, 82)
        Me.BtnVenta.TabIndex = 0
        Me.BtnVenta.Text = "Ventas[F1]"
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'BtnProducto
        '
        Me.BtnProducto.BackColor = System.Drawing.Color.White
        Me.BtnProducto.BackgroundImage = CType(resources.GetObject("BtnProducto.BackgroundImage"), System.Drawing.Image)
        Me.BtnProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnProducto.Location = New System.Drawing.Point(14, 177)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(157, 82)
        Me.BtnProducto.TabIndex = 2
        Me.BtnProducto.Text = "Productos[F2]"
        Me.BtnProducto.UseVisualStyleBackColor = False
        '
        'BtnProveedor
        '
        Me.BtnProveedor.BackColor = System.Drawing.Color.White
        Me.BtnProveedor.BackgroundImage = CType(resources.GetObject("BtnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.BtnProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnProveedor.Location = New System.Drawing.Point(179, 178)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(157, 82)
        Me.BtnProveedor.TabIndex = 3
        Me.BtnProveedor.Text = "Proveedores[F3]"
        Me.BtnProveedor.UseVisualStyleBackColor = False
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.White
        Me.BtnCliente.BackgroundImage = CType(resources.GetObject("BtnCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCliente.Location = New System.Drawing.Point(14, 265)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(157, 82)
        Me.BtnCliente.TabIndex = 4
        Me.BtnCliente.Text = "Clientes[F4]"
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackColor = System.Drawing.Color.White
        Me.BtnEmpleados.BackgroundImage = CType(resources.GetObject("BtnEmpleados.BackgroundImage"), System.Drawing.Image)
        Me.BtnEmpleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEmpleados.Location = New System.Drawing.Point(177, 265)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(157, 82)
        Me.BtnEmpleados.TabIndex = 5
        Me.BtnEmpleados.Text = "Empleados[F5]"
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSalir.Location = New System.Drawing.Point(12, 377)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(320, 60)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir[Esc]"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ZapateriaDataSet
        '
        Me.ZapateriaDataSet.DataSetName = "ZapateriaDataSet"
        Me.ZapateriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ZapateriaDataSet
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
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
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
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.BuscarToolStripMenuItem1, Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1, Me.ConfiguracionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(868, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.LocalidadesToolStripMenuItem1, Me.MarcasToolStripMenuItem1})
        Me.AgregarToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'LocalidadesToolStripMenuItem1
        '
        Me.LocalidadesToolStripMenuItem1.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.LocalidadesToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.LocalidadesToolStripMenuItem1.Name = "LocalidadesToolStripMenuItem1"
        Me.LocalidadesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LocalidadesToolStripMenuItem1.Text = "Localidades"
        '
        'MarcasToolStripMenuItem1
        '
        Me.MarcasToolStripMenuItem1.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.MarcasToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.MarcasToolStripMenuItem1.Name = "MarcasToolStripMenuItem1"
        Me.MarcasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.MarcasToolStripMenuItem1.Text = "Marcas"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorProductoToolStripMenuItem1, Me.PorProveedoresToolStripMenuItem1, Me.PorClientesToolStripMenuItem1, Me.PorEmpleadosToolStripMenuItem1, Me.PorLocalidadesToolStripMenuItem1})
        Me.BuscarToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.BuscarToolStripMenuItem1.Text = "Buscar"
        '
        'PorProductoToolStripMenuItem1
        '
        Me.PorProductoToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("PorProductoToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.PorProductoToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.PorProductoToolStripMenuItem1.Name = "PorProductoToolStripMenuItem1"
        Me.PorProductoToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PorProductoToolStripMenuItem1.Text = "Por Producto"
        '
        'PorProveedoresToolStripMenuItem1
        '
        Me.PorProveedoresToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("PorProveedoresToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.PorProveedoresToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.PorProveedoresToolStripMenuItem1.Name = "PorProveedoresToolStripMenuItem1"
        Me.PorProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PorProveedoresToolStripMenuItem1.Text = "Por Proveedores"
        '
        'PorClientesToolStripMenuItem1
        '
        Me.PorClientesToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("PorClientesToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.PorClientesToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.PorClientesToolStripMenuItem1.Name = "PorClientesToolStripMenuItem1"
        Me.PorClientesToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PorClientesToolStripMenuItem1.Text = "Por Clientes"
        '
        'PorEmpleadosToolStripMenuItem1
        '
        Me.PorEmpleadosToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("PorEmpleadosToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.PorEmpleadosToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.PorEmpleadosToolStripMenuItem1.Name = "PorEmpleadosToolStripMenuItem1"
        Me.PorEmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PorEmpleadosToolStripMenuItem1.Text = "Por Empleados"
        '
        'PorLocalidadesToolStripMenuItem1
        '
        Me.PorLocalidadesToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("PorLocalidadesToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.PorLocalidadesToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.PorLocalidadesToolStripMenuItem1.Name = "PorLocalidadesToolStripMenuItem1"
        Me.PorLocalidadesToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PorLocalidadesToolStripMenuItem1.Text = "Por Localidades"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem3, Me.ClientesToolStripMenuItem3, Me.EmpleadosToolStripMenuItem3, Me.LocalidadesToolStripMenuItem4})
        Me.ModificarToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'ProveedoresToolStripMenuItem3
        '
        Me.ProveedoresToolStripMenuItem3.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.ProveedoresToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem3.Name = "ProveedoresToolStripMenuItem3"
        Me.ProveedoresToolStripMenuItem3.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem3.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem3
        '
        Me.ClientesToolStripMenuItem3.BackgroundImage = CType(resources.GetObject("ClientesToolStripMenuItem3.BackgroundImage"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem3.Name = "ClientesToolStripMenuItem3"
        Me.ClientesToolStripMenuItem3.Size = New System.Drawing.Size(139, 22)
        Me.ClientesToolStripMenuItem3.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem3
        '
        Me.EmpleadosToolStripMenuItem3.BackgroundImage = CType(resources.GetObject("EmpleadosToolStripMenuItem3.BackgroundImage"), System.Drawing.Image)
        Me.EmpleadosToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.EmpleadosToolStripMenuItem3.Name = "EmpleadosToolStripMenuItem3"
        Me.EmpleadosToolStripMenuItem3.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadosToolStripMenuItem3.Text = "Empleados"
        '
        'LocalidadesToolStripMenuItem4
        '
        Me.LocalidadesToolStripMenuItem4.BackgroundImage = CType(resources.GetObject("LocalidadesToolStripMenuItem4.BackgroundImage"), System.Drawing.Image)
        Me.LocalidadesToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.LocalidadesToolStripMenuItem4.Name = "LocalidadesToolStripMenuItem4"
        Me.LocalidadesToolStripMenuItem4.Size = New System.Drawing.Size(139, 22)
        Me.LocalidadesToolStripMenuItem4.Text = "Localidades"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalidadesToolStripMenuItem5})
        Me.EliminarToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'LocalidadesToolStripMenuItem5
        '
        Me.LocalidadesToolStripMenuItem5.BackgroundImage = Global.Zapateria.My.Resources.Resources.images
        Me.LocalidadesToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.LocalidadesToolStripMenuItem5.Name = "LocalidadesToolStripMenuItem5"
        Me.LocalidadesToolStripMenuItem5.Size = New System.Drawing.Size(136, 22)
        Me.LocalidadesToolStripMenuItem5.Text = "Localidades"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(338, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(574, 446)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(868, 485)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEmpleados)
        Me.Controls.Add(Me.BtnCliente)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.BtnProducto)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Form1"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVenta As System.Windows.Forms.Button
    Friend WithEvents BtnProducto As System.Windows.Forms.Button
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents BtnCliente As System.Windows.Forms.Button
    Friend WithEvents BtnEmpleados As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AgregarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorProductoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorEmpleadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorLocalidadesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem

End Class
