<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModLoc
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
        Me.ZapateriaDataSet = New Zapateria.ZapateriaDataSet()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter()
        Me.TableAdapterManager = New Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'LocalidadDataGridView
        '
        Me.LocalidadDataGridView.AutoGenerateColumns = False
        Me.LocalidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocalidadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LocalidadDataGridView.DataSource = Me.LocalidadBindingSource
        Me.LocalidadDataGridView.Location = New System.Drawing.Point(12, 27)
        Me.LocalidadDataGridView.Name = "LocalidadDataGridView"
        Me.LocalidadDataGridView.Size = New System.Drawing.Size(430, 220)
        Me.LocalidadDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Localidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Localidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Zona"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(483, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(112, 47)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(483, 200)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(112, 47)
        Me.BtnVolver.TabIndex = 3
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(483, 108)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(112, 47)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'ModLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 300)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LocalidadDataGridView)
        Me.KeyPreview = True
        Me.Name = "ModLoc"
        Me.Text = "ModLoc"
        CType(Me.ZapateriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ZapateriaDataSet As Zapateria.ZapateriaDataSet
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As Zapateria.ZapateriaDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents TableAdapterManager As Zapateria.ZapateriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalidadDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
End Class
