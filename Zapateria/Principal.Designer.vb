﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
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
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorproductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorLocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CómoFuncionaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnVenta
        '
        Me.BtnVenta.Location = New System.Drawing.Point(30, 107)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(134, 67)
        Me.BtnVenta.TabIndex = 0
        Me.BtnVenta.Text = "Ventas[F1]"
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'BtnCompras
        '
        Me.BtnCompras.Location = New System.Drawing.Point(187, 107)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(134, 67)
        Me.BtnCompras.TabIndex = 1
        Me.BtnCompras.Text = "Compras[F2]"
        Me.BtnCompras.UseVisualStyleBackColor = True
        '
        'BtnProducto
        '
        Me.BtnProducto.Location = New System.Drawing.Point(30, 192)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(134, 67)
        Me.BtnProducto.TabIndex = 2
        Me.BtnProducto.Text = "Productos[F3]"
        Me.BtnProducto.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.Location = New System.Drawing.Point(187, 192)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(134, 67)
        Me.BtnProveedor.TabIndex = 3
        Me.BtnProveedor.Text = "Proveedores[F4]"
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.Location = New System.Drawing.Point(30, 276)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(134, 67)
        Me.BtnCliente.TabIndex = 4
        Me.BtnCliente.Text = "Clientes[F5]"
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Location = New System.Drawing.Point(187, 276)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(134, 67)
        Me.BtnEmpleados.TabIndex = 5
        Me.BtnEmpleados.Text = "Empleados[F6]"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(30, 381)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(134, 47)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir[F10]"
        Me.BtnSalir.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem2, Me.ProveedoresToolStripMenuItem2, Me.ClientesToolStripMenuItem2, Me.EmpleadosToolStripMenuItem2, Me.LocalidadesToolStripMenuItem3, Me.MarcasToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ProductosToolStripMenuItem2
        '
        Me.ProductosToolStripMenuItem2.Name = "ProductosToolStripMenuItem2"
        Me.ProductosToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem2.Text = "Productos"
        '
        'ProveedoresToolStripMenuItem2
        '
        Me.ProveedoresToolStripMenuItem2.Name = "ProveedoresToolStripMenuItem2"
        Me.ProveedoresToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem2.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem2
        '
        Me.ClientesToolStripMenuItem2.Name = "ClientesToolStripMenuItem2"
        Me.ClientesToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem2.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem2
        '
        Me.EmpleadosToolStripMenuItem2.Name = "EmpleadosToolStripMenuItem2"
        Me.EmpleadosToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem2.Text = "Empleados"
        '
        'LocalidadesToolStripMenuItem3
        '
        Me.LocalidadesToolStripMenuItem3.Name = "LocalidadesToolStripMenuItem3"
        Me.LocalidadesToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.LocalidadesToolStripMenuItem3.Text = "Localidades"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorproductoToolStripMenuItem, Me.PorProveedoresToolStripMenuItem, Me.PorClientesToolStripMenuItem, Me.PorEmpleadosToolStripMenuItem, Me.PorLocalidadesToolStripMenuItem})
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'PorproductoToolStripMenuItem
        '
        Me.PorproductoToolStripMenuItem.Name = "PorproductoToolStripMenuItem"
        Me.PorproductoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PorproductoToolStripMenuItem.Text = "Por Producto"
        '
        'PorProveedoresToolStripMenuItem
        '
        Me.PorProveedoresToolStripMenuItem.Name = "PorProveedoresToolStripMenuItem"
        Me.PorProveedoresToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PorProveedoresToolStripMenuItem.Text = "Por Proveedores"
        '
        'PorClientesToolStripMenuItem
        '
        Me.PorClientesToolStripMenuItem.Name = "PorClientesToolStripMenuItem"
        Me.PorClientesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PorClientesToolStripMenuItem.Text = "Por Clientes"
        '
        'PorEmpleadosToolStripMenuItem
        '
        Me.PorEmpleadosToolStripMenuItem.Name = "PorEmpleadosToolStripMenuItem"
        Me.PorEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PorEmpleadosToolStripMenuItem.Text = "Por Empleados"
        '
        'PorLocalidadesToolStripMenuItem
        '
        Me.PorLocalidadesToolStripMenuItem.Name = "PorLocalidadesToolStripMenuItem"
        Me.PorLocalidadesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PorLocalidadesToolStripMenuItem.Text = "Por Localidades"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.ClientesToolStripMenuItem1, Me.EmpleadosToolStripMenuItem1, Me.LocalidadesToolStripMenuItem2})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'LocalidadesToolStripMenuItem2
        '
        Me.LocalidadesToolStripMenuItem2.Name = "LocalidadesToolStripMenuItem2"
        Me.LocalidadesToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.LocalidadesToolStripMenuItem2.Text = "Localidades"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalidadesToolStripMenuItem})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CómoFuncionaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'CómoFuncionaToolStripMenuItem
        '
        Me.CómoFuncionaToolStripMenuItem.Name = "CómoFuncionaToolStripMenuItem"
        Me.CómoFuncionaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CómoFuncionaToolStripMenuItem.Text = "¿Cómo funciona?"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 454)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEmpleados)
        Me.Controls.Add(Me.BtnCliente)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.BtnProducto)
        Me.Controls.Add(Me.BtnCompras)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVenta As System.Windows.Forms.Button
    Friend WithEvents BtnCompras As System.Windows.Forms.Button
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
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorproductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorLocalidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CómoFuncionaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
