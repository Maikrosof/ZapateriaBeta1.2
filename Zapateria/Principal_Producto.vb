Public Class Principal_Producto

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Principal_Producto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.F2 Then
            Call Button2_Click(sender, e)
        End If
        If e.KeyCode = Keys.F3 Then
            Call Button3_Click(sender, e)
        End If
        If e.KeyCode = Keys.F4 Then
            Call Button4_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call Button5_Click(sender, e)
        End If

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
        CodConsulta = Val(InputBox("Ingrese la ID del Zap")) 'genera una ventana donde se ingresa el cod consulta 
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else

            fila = ProductosBindingSource.Find("ID_Zap", CodConsulta)
            If fila = -1 Then
                'no lo encontró
                MsgBox("No se encontró el ID del Zap")
            Else
                'lo encontró
                Me.ProductosBindingSource.Position = fila ' muevo el puntero a la pocision encontrada
                aux = MsgBox("Quiere eliminar el producto? " & CodConsulta)
                If aux = 1 Then
                    'apreto si
                    Me.ProductosBindingSource.RemoveCurrent()
                    Me.ProductosBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en el disco
                    Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) 'para actualizar en el otro formulario
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Alta_Producto.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Buscar_Productos.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Me.ProductosBindingSource.Filter = Nothing
        Else
            Me.ProductosBindingSource.Filter = "Convert (ID_Zap,'System.String') like '%" & Val(TextBox1.Text) & "%'"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
    End Sub
End Class