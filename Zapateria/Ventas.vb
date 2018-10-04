Public Class Ventas

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)

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
            Me.ProductosBindingSource.Filter = "Convert (ID_Marca,'System.String') like '%" & TextBox2.Text & "%'"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Color like '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Estilo like '" & TextBox4.Text & "'"
        End If
    End Sub

    Private Sub BtnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVenta.Click
        If ProductosDataGridView.Rows(0).Cells(7).Value = 0 Then
            MsgBox("No hay stock")
        Else
            ListBox1.Items.Add("ID: " & ProductosDataGridView.Rows(0).Cells(0).Value & " Talla: " & ProductosDataGridView.Rows(0).Cells(3).Value)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class