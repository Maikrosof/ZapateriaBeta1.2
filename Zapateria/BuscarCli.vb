Public Class BuscarCli

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub BuscarCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim i As Integer
        Dim CodigoConsulta As String
        ClientesBindingSource.MoveFirst() 'Mover arriba
        CodigoConsulta = InputBox("ingrese el DNI del cliente") 'abre pantalla
        i = 0
        If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
            Do
                If ClientesBindingSource.Current("DNI") = CodigoConsulta Then

                    TextBox1.Text = ClientesBindingSource.Current("ID_Cliente")
                    TextBox2.Text = ClientesBindingSource.Current("ID_Localidad")
                    TextBox3.Text = ClientesBindingSource.Current("Nombre")
                    TextBox4.Text = ClientesBindingSource.Current("Apellido")
                    TextBox5.Text = ClientesBindingSource.Current("Fec_Nacimiento")
                    TextBox6.Text = ClientesBindingSource.Current("Direccion")
                    TextBox7.Text = ClientesBindingSource.Current("Nro")
                    TextBox8.Text = ClientesBindingSource.Current("Telefono")
                    TextBox9.Text = ClientesBindingSource.Current("DNI")

                    Exit Sub
                End If
                i = i + 1
                ClientesBindingSource.MoveNext()
            Loop Until i = ClientesBindingSource.Count 'cantidad de registros, 'funciona como do while, '(pregunta si es el codigo que busca)
            MsgBox("no se encontro el DNI")
        Else
            MsgBox("El Número de DNI esta vacío o mal ingresado")
        End If
    End Sub
End Class