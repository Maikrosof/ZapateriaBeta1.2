Public Class Client

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes)

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaCli.Show()

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()

    End Sub

    Private Sub BtnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrimero.Click
        ClientesBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtras.Click
        ClientesBindingSource.MovePrevious()

    End Sub

    Private Sub BtnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdelante.Click
        ClientesBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUltimo.Click
        ClientesBindingSource.MoveLast()

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Dim fila, CodConsulta, aux As Integer
        CodConsulta = Val(InputBox("Ingrese el DNI del Cliente"))
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else
            fila = Me.ClientesBindingSource.Find("DNI", CodConsulta)
            If fila = -1 Then
                'no lo encontró
                MsgBox("No se encontró el DNI del cliente")
            Else
                'lo encontró
                Me.ClientesBindingSource.Position = fila ' muevo el puntero a la pocision encontrada
                aux = MsgBox("Quiere eliminar al cliente? " & CodConsulta)
                If aux = 1 Then
                    'apreto si
                    Me.ClientesBindingSource.RemoveCurrent()
                    Me.ClientesBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en el disco
                    Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes) 'para actualizar en el otro formulario
                End If
            End If
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarCli.Show()

    End Sub

    Private Sub Client_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            AltaCli.Show()
        End If
        If e.KeyCode = Keys.F2 Then
            Call BtnEliminar_Click(sender, e)
        End If
        If e.KeyCode = Keys.F3 Then
            ModClient.Show()
        End If
        If e.KeyCode = Keys.F4 Then
            Call BuscarCli.Show()
        End If
        If e.KeyCode = Keys.F5 Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub BtnModificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificaciones.Click
        ModClient.Show()

    End Sub

    Private Sub BtnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        BuscarCli.Show()

    End Sub

    Private Sub BtnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AltaCli.Show()

    End Sub

    Private Sub BtnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = Val(InputBox("Ingrese el DNI")) 'genera una ventana donde se ingresa el cod consulta 
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else
            fila = Me.ClientesBindingSource.Find("DNI", CodConsulta)
            If fila = -1 Then
                'no lo encontró
                MsgBox("No se encontró el DNI del cliente")
            Else
                'lo encontró
                Me.ClientesBindingSource.Position = fila ' muevo el puntero a la pocision encontrada
                aux = MsgBox("Quiere eliminar al cliente? " & CodConsulta)
                If aux = 1 Then
                    'apreto si
                    Me.ClientesBindingSource.RemoveCurrent()
                    Me.ClientesBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en el disco
                    Me.ClientesTableAdapter.Fill(Me.ZapateriaDataSet.Clientes) 'para actualizar en el otro formulario
                End If
            End If
        End If
    End Sub
End Class