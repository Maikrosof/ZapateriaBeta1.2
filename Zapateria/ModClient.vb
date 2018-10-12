Public Class ModClient

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub ModClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = Val(InputBox("ingrese el DNI del Cliente")) 'lo paso a val numerico
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("Vacío")
        Else
            fila = Me.ClientesBindingSource.Find("DNI", CodConsulta)
            If fila = -1 Then
                MsgBox("No se encontro el DNI")
            Else
                ClientesBindingSource.Position = fila
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
        Client.ClientesTableAdapter.Fill(Client.ZapateriaDataSet.Clientes) 'actualizo en principal para que muestre el cod del art
        Me.ClientesBindingSource.MoveLast() 'muestra el ultimo agregado
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub ModClient_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Close()
        End If
    End Sub
End Class