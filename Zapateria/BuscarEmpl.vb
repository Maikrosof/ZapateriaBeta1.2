Public Class BuscarEmpl

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub BuscarEmpl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim i As Integer
        Dim CodigoConsulta As String
        EmpleadosBindingSource.MoveFirst() 'Mover arriba
        CodigoConsulta = InputBox("ingrese el DNI del empleado") 'abre pantalla
        i = 0
        If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
            Do
                If EmpleadosBindingSource.Current("DNI") = CodigoConsulta Then

                    TextBox1.Text = EmpleadosBindingSource.Current("ID_Emp")
                    TextBox2.Text = EmpleadosBindingSource.Current("ID_Localidad")
                    TextBox3.Text = EmpleadosBindingSource.Current("DNI")
                    TextBox4.Text = EmpleadosBindingSource.Current("Nombre")
                    TextBox5.Text = EmpleadosBindingSource.Current("Apellido")
                    TextBox6.Text = EmpleadosBindingSource.Current("Fec_Nacimiento")
                    TextBox7.Text = EmpleadosBindingSource.Current("Direccion")
                    TextBox8.Text = EmpleadosBindingSource.Current("Nro")
                    TextBox9.Text = EmpleadosBindingSource.Current("Telefono")
                    TextBox10.Text = EmpleadosBindingSource.Current("Fec_Contr")
                    TextBox11.Text = EmpleadosBindingSource.Current("Cargo")

                    Exit Sub
                End If
                i = i + 1
                EmpleadosBindingSource.MoveNext()
            Loop Until i = EmpleadosBindingSource.Count 'cantidad de registros, 'funciona como do while, '(pregunta si es el codigo que busca)
            MsgBox("no se encontro el DNI")
        Else
            MsgBox("El Número de DNI esta vacío o mal ingresado")
        End If
    End Sub
End Class