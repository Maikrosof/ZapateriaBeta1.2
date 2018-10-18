Public Class Principal

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Salir.Show()


    End Sub

    Private Sub BtnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedor.Click
        Prov.Show()

    End Sub

    Private Sub AgregarModificarLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ModificarLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AgregarLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaLoc.Show()

    End Sub

    Private Sub MostrarLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarLoc.Show()

    End Sub

    Private Sub ModificarLocalidadesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ElimLoc.Show()

    End Sub

    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCliente.Click
        Client.Show()

    End Sub

    Private Sub BtnProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProducto.Click
        Principal_Producto.Show()

    End Sub

    Private Sub BtnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleados.Click
        Empl.Show()
    End Sub

    Private Sub BtnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Principal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ventas.Show()
        End If
        If e.KeyCode = Keys.F2 Then
            Principal_Producto.Show()
        End If
        If e.KeyCode = Keys.F3 Then
            Prov.Show()
        End If
        If e.KeyCode = Keys.F4 Then
            Client.Show()
        End If
        If e.KeyCode = Keys.F5 Then
            Empl.Show()
        End If
        If e.KeyCode = Keys.Escape Then
            Salir.Show()
        End If
    End Sub





    Private Sub PorproductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar_Productos.Show()

    End Sub

    Private Sub ProductosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Alta_Producto.Show()

    End Sub

    Private Sub ProveedoresToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltasProv.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaCli.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaEmpl.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaLoc.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BusquedasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PorProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarProv.Show()

    End Sub

    Private Sub PorClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarCli.Show()

    End Sub

    Private Sub PorEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarEmp.Show()

    End Sub

    Private Sub PorLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarLoc.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ElimLoc.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaMarca.Show()

    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModProv.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModClient.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModEmpl.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModLoc.Show()

    End Sub

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click
        Ventas.Show()

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Alta_Producto.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        AltasProv.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        AltaCli.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        AltaEmpl.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesToolStripMenuItem1.Click
        AltaLoc.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem1.Click
        AltaMarca.Show()
    End Sub

    Private Sub PorProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProductoToolStripMenuItem1.Click
        Buscar_Productos.Show()
    End Sub

    Private Sub PorProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProveedoresToolStripMenuItem1.Click
        BuscarProv.Show()
    End Sub

    Private Sub PorClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorClientesToolStripMenuItem1.Click
        BuscarCli.Show()
    End Sub

    Private Sub PorEmpleadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorEmpleadosToolStripMenuItem1.Click
        BuscarEmp.Show()
    End Sub

    Private Sub PorLocalidadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorLocalidadesToolStripMenuItem1.Click
        MostrarLoc.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem3.Click
        ModProv.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem3.Click
        ModClient.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem3.Click
        ModEmpl.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesToolStripMenuItem4.Click
        ModLoc.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesToolStripMenuItem5.Click
        ElimLoc.Show()
    End Sub
End Class
