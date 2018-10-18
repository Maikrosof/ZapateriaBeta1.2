Public Class Ventas
    Sub low_stock()
        For i As Integer = 0 To ProductosDataGridView.RowCount - 1
            Dim stockfun As Integer
            stockfun = ProductosDataGridView.Item(7, i).Value()

            If stockfun > 5 Then
                ProductosDataGridView.Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.Black
            ElseIf stockfun <= 5 And stockfun >= 3 Then
                ProductosDataGridView.Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.Green
            Else
                ProductosDataGridView.Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.Red
            End If

        Next
    End Sub
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
            Call Button1_Click(sender, e)

        End If
    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        dgv_styleRow()
        low_stock()


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
        Dim fila, fila2, CodConsulta, aux As Integer
        Dim importe, montoabonado As Double
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
                    If IsNumeric(TextBox5.Text) And Val(TextBox5.Text) > 0 Then
                        importe = TextBox5.Text * Me.ProductosBindingSource.Current("Precio")


                        If ProductosBindingSource.Current("Stock") >= TextBox5.Text Then 'si true puedo vender
                            montoabonado = Val(InputBox("INGRESE EL MONTO ABONADO"))
                            If montoabonado >= importe Then
                                Me.VentasBindingSource.AddNew()
                                Me.VentasBindingSource.Current("ID_Zap") = ProductosBindingSource.Current("ID_Zap")
                                Me.VentasBindingSource.Current("CantidadVend") = TextBox5.Text
                                Me.VentasBindingSource.Current("Tot_Fac") = TextBox5.Text * Me.ProductosBindingSource.Current("Precio")
                                Me.VentasBindingSource.Current("Fecha") = DateTimePicker1.Value
                                Me.VentasBindingSource.EndEdit()
                                Me.VentasTableAdapter.Update(Me.ZapateriaDataSet.Ventas)
                                'Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet) 'grabo en disco las dos tablas
                                'esta sentencia no va sino corro el puntero de lugar
                                '------------------------------------------

                                'aca trabajo sobre la tabla stock descuento la cantidad vendida
                                Me.ProductosBindingSource.Current("Stock") = ProductosBindingSource.Current("Stock") - TextBox5.Text


                                MsgBox("LA VENTA HA SIDO REALIZADA CON EXITO, EL IMPORTE ES DE :" & importe & " PESOS" & vbNewLine & "EL IMPORTE ABONADO ES DE: " & montoabonado & "PESOS" & vbNewLine & "EL VUELTO ES DE: " & montoabonado - importe & " PESOS")
                                Me.ProductosBindingSource.EndEdit() 'cierro bd
                                Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'grabo en disco las dos tablas
                                Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) 'Para actualizar en el otro formulario la grilla
                                Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) 'Actualizo la grilla stock
                                Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas) 'actualizo la grilla ventas
                            Else
                                MsgBox("ERROR: EL MONTO ABONADO ES MENOR AL IMPORTE DE LA COMPRA")
                            End If
                        Else
                            MsgBox("STOCK INSUFICIENTE, STOCK ACTUAL: " & ProductosBindingSource.Current("Stock") & " UNIDADES")
                            'funcion limpiar textbox
                            TextBox1.Clear()
                            TextBox2.Clear()
                            TextBox3.Clear()
                            TextBox4.Clear()
                            TextBox5.Clear()
                            TextBox1.Focus()

                        End If



                    Else
                        MsgBox("ERROR: INGRESE LA CANTIDAD DEL PRODUCTO DESEADA")
                    End If
                End If
            End If
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ProductosDataGridView_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)
        dgv_styleRow()

    End Sub

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim fila2 As Integer
        Dim label As Double
        fila2 = ProductosDataGridView.CurrentCellAddress.Y
        label = ProductosDataGridView.Item(4, fila2).Value()
        If TextBox5.Text <> Nothing And IsNumeric(TextBox5.Text) Then
            Precio.Text = label * Val(TextBox5.Text)
        Else
            Precio.Text = label
        End If

    End Sub

    Private Sub ProductosDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        Dim fila2 As Integer
        Dim label As Double
        fila2 = ProductosDataGridView.CurrentCellAddress.Y
        label = If(ProductosDataGridView.Item(4, fila2).Value() Is DBNull.Value, Nothing, Convert.ToDouble(ProductosDataGridView.Item(4, fila2).Value()))
        If label <> Nothing Then
            If TextBox5.Text <> Nothing And IsNumeric(TextBox5.Text) Then
                Precio.Text = label * Val(TextBox5.Text)
            Else
                Precio.Text = label
            End If
        End If
    End Sub

    Private Sub ProductosDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub ProductosDataGridView_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles ProductosDataGridView.CellStateChanged
        low_stock()
        dgv_styleRow()

    End Sub
End Class