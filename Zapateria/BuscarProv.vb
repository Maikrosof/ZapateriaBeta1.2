Public Class BuscarProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub BuscarProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim i As Integer
        Dim CodigoConsulta As String
        ProveedoresBindingSource.MoveFirst() 'Mover arriba
        CodigoConsulta = InputBox("ingrese el CUIT del proveedor") 'abre pantalla
        i = 0
        If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
            Do
                If ProveedoresBindingSource.Current("CUIT") = CodigoConsulta Then

                    TextBox1.Text = ProveedoresBindingSource.Current("ID_Proveedor")
                    TextBox2.Text = ProveedoresBindingSource.Current("ID_Localidad")
                    TextBox3.Text = ProveedoresBindingSource.Current("Razon_Social")
                    TextBox4.Text = ProveedoresBindingSource.Current("CUIT")
                    TextBox5.Text = ProveedoresBindingSource.Current("Direccion")
                    TextBox6.Text = ProveedoresBindingSource.Current("Nro")
                    TextBox7.Text = ProveedoresBindingSource.Current("Telefono")

                    Exit Sub
                End If
                i = i + 1
                ProveedoresBindingSource.MoveNext()
            Loop Until i = ProveedoresBindingSource.Count 'cantidad de registros, 'funciona como do while, '(pregunta si es el codigo que busca)
            MsgBox("no se encontro el cuit")
        Else
            MsgBox("el codigo de art esta vacio")
        End If
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()
    End Sub
End Class