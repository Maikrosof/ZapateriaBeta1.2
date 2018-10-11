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
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Zap,'System.String') LIKE '%" & Val(TextBox1.Text) & "%'"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Marca,'System.String') LIKE '%" & ComboBox1.SelectedValue & "%'"
        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Proveedor,'System.String') LIKE '%" & Val(TextBox3.Text) & "%'"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Modelo LIKE '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (Talla,'System.String') LIKE '%" & Val(TextBox5.Text) & "%'"
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (Precio,'System.String') LIKE '%" & Val(TextBox6.Text) & "%'"
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Color LIKE '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Estilo LIKE '%" & TextBox3.Text & "%'"
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (Stock,'System.String') LIKE '%" & Val(TextBox6.Text) & "%'"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub




    Private Sub ID_ProveedorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class