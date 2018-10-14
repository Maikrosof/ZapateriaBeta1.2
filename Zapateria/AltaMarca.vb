Public Class AltaMarca

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub AltaMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub AltaMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        Me.MarcasBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
            Me.MarcasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
            Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
            Alta_Producto.MarcasTableAdapter.Fill(Alta_Producto.ZapateriaDataSet.Marcas)
            Me.MarcasBindingSource.MoveLast()
            MsgBox("Marca agregada a la lista")
            Me.MarcasBindingSource.AddNew()
        Else
            MsgBox("Faltan datos")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class