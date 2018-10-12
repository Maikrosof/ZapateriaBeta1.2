Public Class BuscarProv

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub BuscarProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.ZapateriaDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila, CodConsulta As Integer
        CodConsulta = Val(InputBox("ingrese el Cuit del proveedor")) 'lo paso a val numerico
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else
            fila = Me.ProveedoresBindingSource.Find("CUIT", CodConsulta)
            If fila = -1 Then
                MsgBox("No se encontro el cuit")
            Else
                ProveedoresBindingSource.Position = fila
            End If
        End If
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()
    End Sub

    Private Sub BuscarProv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BtnBuscar_Click(sender, e)
        End If
        If e.KeyCode = Keys.F5 Then
            Call BtnVolver_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim vista As New DataView 'instancio el objeto
        vista.Table = Me.ZapateriaDataSet.Proveedores 'cargo objeto
        vista.RowFilter = "Razon_Social LIKE '" & Me.TextBox2.Text & "%'" 'esta para texto
        'vista.RowFilter = "Id_articulo = " & Val(Me.TextBox1.Text)    'esta para numeros
        Me.ProveedoresDataGridView.DataSource = vista
    End Sub

    Private Sub BtnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = Val(InputBox("ingrese el CUIT del Proveedor")) 'lo paso a val numerico
        If CodConsulta = Nothing Then 'El magico Nothing
            MsgBox("No ingresó nada")
        Else
            fila = Me.ProveedoresBindingSource.Find("CUIT", CodConsulta)
            If fila = -1 Then
                MsgBox("No se encontro el CUIT")
            Else
                ProveedoresBindingSource.Position = fila
            End If
        End If
    End Sub
End Class