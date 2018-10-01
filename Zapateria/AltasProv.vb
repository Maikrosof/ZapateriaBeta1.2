Public Class AltasProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltasProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        Me.ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.ProveedoresBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.ProveedoresBindingSource.Current("Razon_Social") = Razon_SocialTextBox.Text
        Me.ProveedoresBindingSource.Current("CUIT") = Val(CUITTextBox.Text)
        Me.ProveedoresBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.ProveedoresBindingSource.Current("Nro") = Val(NroTextBox.Text)
        Me.ProveedoresBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores) 'actualizo en altas
        Prov.ProveedoresTableAdapter.Fill(Prov.ZapateriaDataSet.Proveedores) 'actualizo en principal para que muestre el cod del art
        Me.ProveedoresBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de proveedor es:" + Me.ProveedoresBindingSource.Current("ID_Proveedor").ToString)
        Me.ProveedoresBindingSource.AddNew()
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub
End Class