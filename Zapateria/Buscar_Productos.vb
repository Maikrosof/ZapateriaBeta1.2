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
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "ID_Zap=" & Val(Me.TextBox1.Text)
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "ID_Marca=" & Val(Me.ComboBox1.SelectedValue)
        Me.ProductosDataGridView.DataSource = vista

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "ID_Proveedor=" & Val(Me.TextBox3.Text)
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "Convert (Modelo,'System.String') LIKE'" & Me.TextBox4.Text & "%'"
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "Talla=" & Val(Me.TextBox5.Text)
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "ID_Precio=" & Val(Me.TextBox6.Text)
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "Convert (Color,'System.String') LIKE'" & Me.TextBox7.Text & "%'"
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "Convert (Estilo,'System.String') LIKE'" & Me.TextBox8.Text & "%'"
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Dim vista As New DataView
        vista.Table = Me.ZapateriaDataSet.Productos
        vista.RowFilter = "Stock=" & Val(Me.TextBox9.Text)
        Me.ProductosDataGridView.DataSource = vista
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Principal_Producto.ProductosTableAdapter.Fill(Principal_Producto.ZapateriaDataSet.Productos)
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
    End Sub
End Class