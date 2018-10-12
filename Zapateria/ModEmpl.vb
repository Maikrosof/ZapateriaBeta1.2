Public Class ModEmpl

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub ModEmpl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = Val(InputBox("ingrese el DNI del Empleado")) 'lo paso a val numerico
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("Vacío")
        Else
            fila = Me.EmpleadosBindingSource.Find("DNI", CodConsulta)
            If fila = -1 Then
                MsgBox("No se encontro el DNI")
            Else
                EmpleadosBindingSource.Position = fila
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
        Empl.EmpleadosTableAdapter.Fill(Empl.ZapateriaDataSet.Empleados) 'actualizo en principal para que muestre el cod del art
        Me.EmpleadosBindingSource.MoveLast() 'muestra el ultimo agregado
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub

    Private Sub ModEmpl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Close()
        End If
    End Sub
End Class