Public Class Principal_Producto

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

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

        CodConsulta = InputBox("Ingrese la ID del Producto") 'genera una ventana donde se ingresa el cod consulta 

        fila = Me.ProductosBindingSource.Find("ID_Zap", CodConsulta) 'busca dentra de la BD
        If CodConsulta.ToString = "" Then 'hay que pasarlo a cadena para que lo tome
            MsgBox("El Campo esta vacio")
        Else
            If fila = -1 Then
                MsgBox("No se encotro la ID")
                'TextBox1.Focus()
            Else
                'lo encotro 
                Me.ProductosBindingSource.Position = fila 'paro el puntero en la  fila buscada
                aux = MsgBox("Quiere eliminar?" & CodConsulta) 'Pregunto
                If aux = 1 Then
                    'apreto si
                    Me.ProductosBindingSource.RemoveCurrent() 'borro el regiostro donde estoy parado
                    Me.ProductosBindingSource.EndEdit() 'cierro bd
                    Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet) 'guardo en disco
                    Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos) ' para actualizar en el otro formulario la grilla
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Alta_Producto.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim CodigoConsulta As String
        ProductosBindingSource.MoveFirst() 'Mover arriba
        CodigoConsulta = InputBox("ingrese el DNI del cliente") 'abre pantalla
        i = 0
        If CodigoConsulta <> "" And IsNumeric(CodigoConsulta) Then
            Do
                If ProductosBindingSource.Current("DNI") = CodigoConsulta Then

                    TextBox1.Text = ProductName.Current("ID_Cliente")
                    TextBox2.Text = ClientesBindingSource.Current("ID_Localidad")
                    TextBox3.Text = ClientesBindingSource.Current("Nombre")
                    TextBox4.Text = ClientesBindingSource.Current("Apellido")
                    TextBox5.Text = ClientesBindingSource.Current("Fec_Nacimiento")
                    TextBox6.Text = ClientesBindingSource.Current("Direccion")
                    TextBox7.Text = ClientesBindingSource.Current("Nro")
                    TextBox8.Text = ClientesBindingSource.Current("Telefono")
                    TextBox9.Text = ClientesBindingSource.Current("DNI")

                    Exit Sub
                End If
                i = i + 1
                ClientesBindingSource.MoveNext()
            Loop Until i = ClientesBindingSource.Count 'cantidad de registros, 'funciona como do while, '(pregunta si es el codigo que busca)
            MsgBox("no se encontro el DNI")
        Else
            MsgBox("El Número de DNI esta vacío o mal ingresado")
        End If
    End Sub
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()

    End Sub
End Class