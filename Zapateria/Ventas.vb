Public Class Ventas
    Sub dgv_styleRow()
        For i As Integer = 0 To ProductosDataGridView.RowCount - 1
            If i Mod 2 = 0 Then
                ProductosDataGridView.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.White
            Else
                ProductosDataGridView.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.LightGray
            End If
        Next
    End Sub
    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Ventas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        dgv_styleRow()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Zap,'System.String') like '%" & Val(TextBox1.Text) & "%'"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Marca,'System.String') like '%" & Val(TextBox2.Text) & "%'"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Color like '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Estilo like '%" & TextBox4.Text & "%'"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fila, fila2, CodConsulta, aux, importe As Integer
        fila2 = ProductosDataGridView.CurrentCellAddress.Y
        fila = Me.ProductosBindingSource.Find("ID_Zap", ProductosDataGridView.Item(0, fila2).Value()) 'me dice la posicion arranca de 0
        CodConsulta = ProductosDataGridView.Item(0, fila2).Value()
        If fila = -1 Then
            'no se encontro ultimo registro es -1
            MsgBox("El registro no se encontro")
        Else
            'Se encontro
            ProductosBindingSource.Position = fila ' Mover el cursor a la fila obtenida con esto muestro
            aux = MsgBox("Quiere realizar esta venta Cod_Zap: " & CodConsulta, 32 + 1, "Vender")
            If aux = 1 Then
                If ProductosBindingSource.Current("Stock") >= Val(TextBox2.Text) Then 'si true puedo vender
                    'guardo la transaccion en la tabla venta-----------------------------------------------

                    Me.VentasBindingSource.AddNew()
                    Me.VentasBindingSource.Current("ID_Zap") = ProductosBindingSource.Current("ID_Zap")
                    Me.VentasBindingSource.Current("Stock") = Val(TextBox2.Text)
                    Me.VentasBindingSource.Current("Tot_Fac") = Val(TextBox2.Text) * Me.ProductosBindingSource.Current("Precio")
                    Me.VentasBindingSource.EndEdit()
                    Me.VentasTableAdapter.Update(Me.ZapateriaDataSet.Ventas)
                    'Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet) 'grabo en disco las dos tablas
                    'esta sentencia no va sino corro el puntero de lugar
                    '------------------------------------------

                    'aca trabajo sobre la tabla stock descuento la cantidad vendida
                    Me.ProductosBindingSource.Current("Stock") = ProductosBindingSource.Current("Stock") - Val(TextBox2.Text)
                    importe = Val(TextBox2.Text) * Me.ProductosBindingSource.Current("Precio")
                    MsgBox("La venta a sido realizada con exito el importe es:" & importe & " Pesos")

                    'ahora si cierro y guardo
                    Me.ProductosBindingSource.EndEdit() 'cierro bd
                    Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'grabo en disco las dos tablas
                    Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) 'Para actualizar en el otro formulario la grilla
                    Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) 'Actualizo la grilla stock
                    Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas) 'actualizo la grilla ventas


                Else
                    MsgBox("El stock es insuficiente, el stock actual es de: " & ProductosBindingSource.Current("Cantidad") & " unidades")
                    'funcion limpiar textbox
                    'TextBox1.Text = ""
                    'TextBox2.Text = ""
                    TextBox1.Focus()

                End If
            End If
        End If
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosDataGridView_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles ProductosDataGridView.RowStateChanged
        dgv_styleRow()

    End Sub
End Class