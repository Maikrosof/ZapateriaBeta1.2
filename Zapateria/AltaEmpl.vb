Public Class AltaEmpl

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltaEmpl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)
        Me.EmpleadosBindingSource.AddNew()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.EmpleadosBindingSource.Current("ID_Localidad") = CmbLocalidad.SelectedValue
        Me.EmpleadosBindingSource.Current("DNI") = Val(DNITextBox.Text)
        Me.EmpleadosBindingSource.Current("Nombre") = NombreTextBox.Text
        Me.EmpleadosBindingSource.Current("Apellido") = ApellidoTextBox.Text
        Me.EmpleadosBindingSource.Current("Fec_Nacimiento") = Fec_NacimientoDateTimePicker.Value
        Me.EmpleadosBindingSource.Current("Direccion") = DireccionTextBox.Text
        Me.EmpleadosBindingSource.Current("Nro") = Val(NroTextBox.Text)
        Me.EmpleadosBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
        Me.EmpleadosBindingSource.Current("Fec_Contr") = Fec_ContrDateTimePicker.Value
        Me.EmpleadosBindingSource.Current("Cargo") = CargoTextBox.Text
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardar disco
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados) 'actualizo en altas
        Empl.EmpleadosTableAdapter.Fill(Empl.ZapateriaDataSet.Empleados) 'actualizo en principal para que muestre el cod del art
        Me.EmpleadosBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El codigo de empleado es:" + Me.EmpleadosBindingSource.Current("ID_Emp").ToString)
        Me.EmpleadosBindingSource.AddNew()
    End Sub
End Class