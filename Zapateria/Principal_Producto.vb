Public Class Principal_Producto

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Principal_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Ingrese la ID del Producto")

        'podria ir lo de vacio
        fila = Me.ProductosBindingSource.Find("ID_Zap", CodConsulta)
        If fila = -1 Then
            'no lo encontró
            MsgBox("No se encontró la ID del Producto")
        Else
            'lo encontró
            Me.ProductosBindingSource.Position = fila ' muevo el puntero a la pocision encontrada
            aux = MsgBox("Quiere eliminar? " & CodConsulta)
            If aux = 1 Then
                'apreto si
                Me.ProductosBindingSource.RemoveCurrent()
                Me.ProductosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en el disco
                Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) 'para actualizar en el otro formulario
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Alta_Producto.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = InputBox("Ingrese la ID del Producto") ' 
        'If CodConsulta <> "" Then

        'MsgBox("vacio")
        'Else
        fila = Me.ProductosBindingSource.Find("ID_Zap", CodConsulta) '
        If fila = -1 Then
            'no lo encontró
            MsgBox("No se encontró el la ID del Producto")
        Else
            'lo encontró
            Me.ProductosBindingSource.Position = fila ' muevo el puntero a la pocision encontrada

        End If
        'End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()

    End Sub
End Class