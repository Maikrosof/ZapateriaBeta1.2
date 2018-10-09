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

    Private Sub ID_ZapTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_ZapTextBox.TextChanged
        Dim vista As New DataView 'creo e instancio el objeto 

        vista.Table = Me.ZapateriaDataSet.Productos 'cargo objeto con la tabla stock
        'aux = "Id_articulo = " + Val(Me.TextBox2.Text) con el simbolo + tira error no concatena

        vista.RowFilter = "ID_Zap = " & Val(Me.ID_ZapTextBox.Text)    'esta para numeros

        Me.ProductosBindingSource.DataSource = vista 'cargo la vista

    End Sub
End Class