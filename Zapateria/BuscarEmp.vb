Public Class BuscarEmp

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub BuscarEmp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub BuscarEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ZapateriaDataSet.Empleados)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = Val(InputBox("ingrese el DNI del Empleado")) 'lo paso a val numerico
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else
            fila = Me.EmpleadosBindingSource.Find("DNI", CodConsulta)
            If fila = -1 Then
                MsgBox("No se encontro el CUIT")
            Else
                EmpleadosBindingSource.Position = fila
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vista As New DataView 'instancio el objeto
        vista.Table = Me.ZapateriaDataSet.Proveedores 'cargo objeto
        vista.RowFilter = "DNI LIKE '" & Me.TextBox1.Text & "%'" 'esta para texto
        'vista.RowFilter = "Id_articulo = " & Val(Me.TextBox1.Text)    'esta para numeros
        Me.EmpleadosDataGridView.DataSource = vista
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub
End Class