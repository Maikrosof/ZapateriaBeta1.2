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

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ID_ZapTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TextBox1.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Zap,'System.String') like '%" & Val(TextBox1.Text) & "%'"
        End If

    End Sub

    Private Sub ID_MarcaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox2.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Marca,'System.String') like '%" & TextBox2.Text & "%'"
        End If
    End Sub

    Private Sub ID_ProveedorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox3.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Proveedor,'System.String') like '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub TallaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox5.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (Talla,'System.String') like '%" & TextBox5.Text & "%'"
        End If
    End Sub

    Private Sub PrecioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TextBox6.Text = "" Then
        'Me.ProductosBindingSource.Filter = Nothing
        'Else
        'Me.ProductosBindingSource.Filter = "Convert (Precio'System.String') like '%" & TextBox6.Text & "%'"
        'End If
    End Sub

    Private Sub ColorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox7.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Color like '%" & TextBox7.Text & "%'"
        End If
    End Sub

    Private Sub EstiloTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox8.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Estilo like '" & TextBox8.Text & "'"
        End If
    End Sub

    Private Sub StockTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox9.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (Stock,'System.String') like '%" & TextBox9.Text & "%'"
        End If
    End Sub

    Private Sub ModeloTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox4.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Modelo like '" & TextBox4.Text & "'"
        End If
    End Sub
End Class