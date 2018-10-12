Public Class Prov

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Prov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)

    End Sub

    Private Sub BtnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrimero.Click
        Me.ProveedoresBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtras.Click
        Me.ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub BtnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdelante.Click
        Me.ProveedoresBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUltimo.Click
        Me.ProveedoresBindingSource.MoveLast()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AltasProv.Show()

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Dim fila, CodConsulta, aux As Integer
        CodConsulta = Val(InputBox("Ingrese el cuit")) 'genera una ventana donde se ingresa el cod consulta 
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else

            fila = Me.ProveedoresBindingSource.Find("CUIT", CodConsulta) 'busca dentra de la BD

                If fila = -1 Then
                MsgBox("No se encotro el codigo de proveedor")
                    Razon_SocialTextBox.Focus()
                Else
                    'lo encotro 
                    Me.ProveedoresBindingSource.Position = fila 'paro el puntero en la  fila buscada
                    aux = MsgBox("Quiere eliminar al proveedor?" & CodConsulta) 'Pregunto
                    If aux = 1 Then
                        'apreto si
                        Me.ProveedoresBindingSource.RemoveCurrent() 'borro el regiostro donde estoy parado
                        Me.ProveedoresBindingSource.EndEdit() 'cierro bd
                        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en disco
                        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores) ' para actualizar en el otro formulario la grilla
                    End If
                End If
            End If
    
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        BuscarProv.Show()
    End Sub

    Private Sub Prov_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            AltasProv.Show()
        End If
        If e.KeyCode = Keys.F2 Then
            Call BtnEliminar_Click(sender, e)
        End If
        If e.KeyCode = Keys.F3 Then
            ModProv.Show()
        End If
        If e.KeyCode = Keys.F4 Then
            BuscarProv.Show()
        End If
        If e.KeyCode = Keys.F5 Then
            Close()
        End If

    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificaciones.Click
        ModProv.Show()

    End Sub
End Class