Public Class Empl

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Empl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)

    End Sub


    Private Sub BtnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrimero.Click
        EmpleadosBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtras.Click
        EmpleadosBindingSource.MovePrevious()

    End Sub

    Private Sub BtnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdelante.Click
        EmpleadosBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUltimo.Click
        EmpleadosBindingSource.MoveLast()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        AltaEmpl.Show()

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Ingrese el DNI del empleado")
        'podria ir lo de vacio
        fila = Me.EmpleadosBindingSource.Find("DNI", CodConsulta)
        If fila = -1 Then
            'no lo encontró
            MsgBox("No se encontró el DNI del empleado")
        Else
            'lo encontró
            Me.EmpleadosBindingSource.Position = fila ' muevo el puntero a la pocision encontrada
            aux = MsgBox("Quiere eliminar al empleado? " & CodConsulta)
            If aux = 1 Then
                'apreto si
                Me.EmpleadosBindingSource.RemoveCurrent()
                Me.EmpleadosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en el disco
                Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados) 'para actualizar en el otro formulario
            End If
        End If

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        BuscarEmpl.Show()

    End Sub
End Class