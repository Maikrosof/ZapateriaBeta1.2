Public Class Buscar_Productos

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Buscar_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim i As Integer
        Dim CodigoConsulta As String
        ProductosBindingSource.MoveFirst() 'Mover arriba
        CodigoConsulta = InputBox("ingrese el DNI del cliente") 'abre pantalla
        i = 0
        If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
            Do
                If ProductosBindingSource.Current("ID_Marca") = CodigoConsulta Then

                    TextBox1 = ProductosBindingSource.Current("ID_Marca")


                    Exit Sub
                End If
                i = i + 1
                ProductosBindingSource.MoveNext()
            Loop Until i = ProductosBindingSource.Count 'cantidad de registros, 'funciona como do while, '(pregunta si es el codigo que busca)
            MsgBox("no se encontro el DNI")
        Else
            MsgBox("El Número de DNI esta vacío o mal ingresado")
        End If
    End Sub
End Class