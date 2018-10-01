Public Class AltaCli

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltaCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)
        Me.ClientesBindingSource.AddNew()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Me.ClientesBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.ClientesBindingSource.Current("Nombre") = NombreTextBox.Text
        Me.ClientesBindingSource.Current("Apellido") = ApellidoTextBox.Text
        Me.ClientesBindingSource.Current("Fec_Nacimiento") = Fec_NacimientoDateTimePicker.Value
        Me.ClientesBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.ClientesBindingSource.Current("Nro") = Val(NroTextBox.Text)
        Me.ClientesBindingSource.Current("DNI") = Val(DNITextBox.Text)
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes) 'actualizo en altas
        Client.ClientesTableAdapter.Fill(Client.ZapateriaDataSet.Clientes) 'actualizo en principal para que muestre el cod del art
        Me.ClientesBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de Cliente es:" + Me.ClientesBindingSource.Current("ID_Cliente").ToString)
        Me.ClientesBindingSource.AddNew()
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub
End Class