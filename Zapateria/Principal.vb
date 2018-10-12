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
        End

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

    Private Sub BtnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.Click

    End Sub


    Private Sub Principal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            Principal_Producto.Show()
        End If
        If e.KeyCode = Keys.F4 Then
            Prov.Show()
        End If
        If e.KeyCode = Keys.F5 Then
            Client.Show()
        End If
        If e.KeyCode = Keys.F6 Then
            Empl.Show()
        End If
        If e.KeyCode = Keys.F10 Then
        End If
    End Sub



    Private Sub MovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosToolStripMenuItem.Click

    End Sub

    Private Sub PorproductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorproductoToolStripMenuItem.Click

    End Sub

    Private Sub ProductosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem2.Click
        Alta_Producto.Show()

    End Sub

    Private Sub ProveedoresToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem2.Click
        AltasProv.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem2.Click
        AltaCli.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem2.Click
        AltaEmpl.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesToolStripMenuItem3.Click
        AltaLoc.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BusquedasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click

    End Sub

    Private Sub PorProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProveedoresToolStripMenuItem.Click
        BuscarProv.Show()

    End Sub

    Private Sub PorClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorClientesToolStripMenuItem.Click
        BuscarCli.Show()

    End Sub

    Private Sub PorEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorEmpleadosToolStripMenuItem.Click
        BuscarEmpl.Show()

    End Sub

    Private Sub PorLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorLocalidadesToolStripMenuItem.Click
        MostrarLoc.Show()

    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadesToolStripMenuItem.Click
        ElimLoc.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem.Click
        AltaMarca.Show()

    End Sub
End Class
