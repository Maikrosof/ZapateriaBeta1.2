<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaLoc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ZonaLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ZonaTextBox = New System.Windows.Forms.TextBox()
        Me.CPTextBox = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ZonaLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(58, 101)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadLabel.TabIndex = 3
        LocalidadLabel.Text = "Localidad:"
        '
        'ZonaLabel
        '
        ZonaLabel.AutoSize = True
        ZonaLabel.Location = New System.Drawing.Point(58, 127)
        ZonaLabel.Name = "ZonaLabel"
        ZonaLabel.Size = New System.Drawing.Size(35, 13)
        ZonaLabel.TabIndex = 5
        ZonaLabel.Text = "Zona:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.Location = New System.Drawing.Point(58, 153)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(24, 13)
        CPLabel.TabIndex = 7
        CPLabel.Text = "CP:"
        '
        'ZapateriaDataSet
        '
        Me.ZapateriaDataSet.DataSetName = "ZapateriaDataSet"
        Me.ZapateriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.ZapateriaDataSet
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(134, 98)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocalidadTextBox.TabIndex = 4
        '
        'ZonaTextBox
        '
        Me.ZonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Zona", True))
        Me.ZonaTextBox.Location = New System.Drawing.Point(134, 124)
        Me.ZonaTextBox.Name = "ZonaTextBox"
        Me.ZonaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZonaTextBox.TabIndex = 6
        '
        'CPTextBox
        '
        Me.CPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "CP", True))
        Me.CPTextBox.Location = New System.Drawing.Point(134, 150)
        Me.CPTextBox.Name = "CPTextBox"
        Me.CPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPTextBox.TabIndex = 8
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(39, 217)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(155, 217)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 10
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ingrese los datos de las Localidades:"
        '
        'AltaLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 274)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(LocalidadLabel)
        Me.Controls.Add(Me.LocalidadTextBox)
        Me.Controls.Add(ZonaLabel)
        Me.Controls.Add(Me.ZonaTextBox)
        Me.Controls.Add(CPLabel)
        Me.Controls.Add(Me.CPTextBox)
        Me.Name = "AltaLoc"
        Me.Text = "AltaLoc"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZonaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
