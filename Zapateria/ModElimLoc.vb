Public Class ModElimLoc

    Private Sub LocalidadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LocalidadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub ModElimLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Ingrese la ID de la Localidad")

        'podria ir lo de vacio
        fila = Me.LocalidadBindingSource.Find("ID_Localidad", CodConsulta)
        If fila = -1 Then
            'no lo encontró
            MsgBox("No se encontró la ID de localidad")
        Else
            'lo encontró
            Me.LocalidadBindingSource.Position = fila ' muevo el puntero a la pocision encontrada
            aux = MsgBox("Quiere eliminar? " & CodConsulta)
            If aux = 1 Then
                'apreto si
                Me.LocalidadBindingSource.RemoveCurrent()
                Me.LocalidadBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en el disco
                Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad) 'para actualizar en el otro formulario
            End If
        End If

    End Sub

    Private Sub BtnPrincipio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrincipio.Click
        LocalidadBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtras.Click
        LocalidadBindingSource.MovePrevious()

    End Sub

    Private Sub BtnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdelante.Click
        LocalidadBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUltimo.Click
        LocalidadBindingSource.MoveFirst()

    End Sub
End Class