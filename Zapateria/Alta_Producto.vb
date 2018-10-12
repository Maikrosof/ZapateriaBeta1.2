﻿Public Class Alta_Producto

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Alta_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        ' Me.MarcasBindingSource.AddNew()
        Me.ProductosBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ID_ProveedorTextBox.Text <> "" Or ComboBox1.SelectedValue <> "" Or ModeloTextBox.Text <> "" Or TallaTextBox.Text <> "" Or PrecioTextBox.Text <> "" Or PrecioTextBox.Text <> "" Or ColorTextBox.Text <> "" Or EstiloTextBox.Text <> "" Or StockTextBox.Text <> "" Then
            Me.ProductosBindingSource.Current("ID_Proveedor") = Val(ID_ProveedorTextBox.Text)
            Me.ProductosBindingSource.Current("ID_Marca") = ComboBox1.SelectedValue
            Me.ProductosBindingSource.Current("Modelo") = ModeloTextBox.Text
            Me.ProductosBindingSource.Current("Talla") = Val(TallaTextBox.Text)
            Me.ProductosBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
            Me.ProductosBindingSource.Current("Color") = ColorTextBox.Text
            Me.ProductosBindingSource.Current("Estilo") = EstiloTextBox.Text
            Me.ProductosBindingSource.Current("Stock") = Val(StockTextBox.Text)

            Me.ProductosBindingSource.EndEdit()
            ' Me.MarcasBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
            Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
            ' Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)

            Principal_Producto.ProductosTableAdapter.Fill(Principal_Producto.ZapateriaDataSet.Productos)
            Buscar_Productos.ProductosTableAdapter.Fill(Buscar_Productos.ZapateriaDataSet.Productos)

            ' Principal_Producto.MarcasTableAdapter.Fill(Principal_Producto.ZapateriaDataSet.Marcas)

            Me.ProductosBindingSource.AddNew()
            'Me.MarcasBindingSource.AddNew()
        Else
            MsgBox("Vacio")
        End If
    End Sub

    Private Sub Alta_Producto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.F5 Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AltaMarca.Show()

    End Sub
End Class