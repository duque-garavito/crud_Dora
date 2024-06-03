<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.controles = New System.Windows.Forms.TabControl()
        Me.Pasajero = New System.Windows.Forms.TabPage()
        Me.btnElimnar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Tabla = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dataTable = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Salir = New System.Windows.Forms.Button()
        Me.btnEliminarViaje = New System.Windows.Forms.Button()
        Me.btnEditarViaje = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActulViaje = New System.Windows.Forms.Button()
        Me.btnAgregarViaje = New System.Windows.Forms.Button()
        Me.dataTable2 = New System.Windows.Forms.DataGridView()
        Me.controles.SuspendLayout()
        Me.Pasajero.SuspendLayout()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'controles
        '
        Me.controles.Controls.Add(Me.Pasajero)
        Me.controles.Controls.Add(Me.TabPage2)
        Me.controles.Location = New System.Drawing.Point(0, 1)
        Me.controles.Name = "controles"
        Me.controles.SelectedIndex = 0
        Me.controles.Size = New System.Drawing.Size(801, 452)
        Me.controles.TabIndex = 0
        '
        'Pasajero
        '
        Me.Pasajero.BackgroundImage = Global.Dora.My.Resources.Resources.AdobeStock_77874009
        Me.Pasajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pasajero.Controls.Add(Me.btnElimnar)
        Me.Pasajero.Controls.Add(Me.btnEditar)
        Me.Pasajero.Controls.Add(Me.btnSalir)
        Me.Pasajero.Controls.Add(Me.Tabla)
        Me.Pasajero.Controls.Add(Me.btnActualizar)
        Me.Pasajero.Controls.Add(Me.btnAgregar)
        Me.Pasajero.Controls.Add(Me.dataTable)
        Me.Pasajero.Location = New System.Drawing.Point(4, 22)
        Me.Pasajero.Name = "Pasajero"
        Me.Pasajero.Padding = New System.Windows.Forms.Padding(3)
        Me.Pasajero.Size = New System.Drawing.Size(793, 426)
        Me.Pasajero.TabIndex = 0
        Me.Pasajero.Text = "Pasajeros"
        Me.Pasajero.UseVisualStyleBackColor = True
        '
        'btnElimnar
        '
        Me.btnElimnar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnElimnar.Font = New System.Drawing.Font("PanRoman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnElimnar.Location = New System.Drawing.Point(647, 257)
        Me.btnElimnar.Name = "btnElimnar"
        Me.btnElimnar.Size = New System.Drawing.Size(75, 23)
        Me.btnElimnar.TabIndex = 13
        Me.btnElimnar.Text = "Eliminar"
        Me.btnElimnar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditar.Font = New System.Drawing.Font("PanRoman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(647, 174)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("PanRoman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(647, 299)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Tabla
        '
        Me.Tabla.AutoSize = True
        Me.Tabla.BackColor = System.Drawing.Color.Transparent
        Me.Tabla.Font = New System.Drawing.Font("High Tower Text", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabla.ForeColor = System.Drawing.Color.White
        Me.Tabla.Location = New System.Drawing.Point(97, 46)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(117, 32)
        Me.Tabla.TabIndex = 10
        Me.Tabla.Text = "Pasajeros"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("PanRoman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(647, 214)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("PanRoman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(647, 136)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar "
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dataTable
        '
        Me.dataTable.BackgroundColor = System.Drawing.Color.White
        Me.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTable.Location = New System.Drawing.Point(70, 81)
        Me.dataTable.MultiSelect = False
        Me.dataTable.Name = "dataTable"
        Me.dataTable.ReadOnly = True
        Me.dataTable.Size = New System.Drawing.Size(525, 300)
        Me.dataTable.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Dora.My.Resources.Resources.AdobeStock_77874009
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Salir)
        Me.TabPage2.Controls.Add(Me.btnEliminarViaje)
        Me.TabPage2.Controls.Add(Me.btnEditarViaje)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnActulViaje)
        Me.TabPage2.Controls.Add(Me.btnAgregarViaje)
        Me.TabPage2.Controls.Add(Me.dataTable2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(793, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Viajes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(665, 281)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 14
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'btnEliminarViaje
        '
        Me.btnEliminarViaje.Location = New System.Drawing.Point(665, 237)
        Me.btnEliminarViaje.Name = "btnEliminarViaje"
        Me.btnEliminarViaje.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarViaje.TabIndex = 13
        Me.btnEliminarViaje.Text = "Eliminar"
        Me.btnEliminarViaje.UseVisualStyleBackColor = True
        '
        'btnEditarViaje
        '
        Me.btnEditarViaje.Location = New System.Drawing.Point(665, 158)
        Me.btnEditarViaje.Name = "btnEditarViaje"
        Me.btnEditarViaje.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarViaje.TabIndex = 12
        Me.btnEditarViaje.Text = "Editar"
        Me.btnEditarViaje.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 20.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(43, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Viajes"
        '
        'btnActulViaje
        '
        Me.btnActulViaje.Location = New System.Drawing.Point(665, 197)
        Me.btnActulViaje.Name = "btnActulViaje"
        Me.btnActulViaje.Size = New System.Drawing.Size(75, 23)
        Me.btnActulViaje.TabIndex = 10
        Me.btnActulViaje.Text = "Actualizar"
        Me.btnActulViaje.UseVisualStyleBackColor = True
        '
        'btnAgregarViaje
        '
        Me.btnAgregarViaje.Location = New System.Drawing.Point(665, 117)
        Me.btnAgregarViaje.Name = "btnAgregarViaje"
        Me.btnAgregarViaje.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarViaje.TabIndex = 9
        Me.btnAgregarViaje.Text = "Agregar"
        Me.btnAgregarViaje.UseVisualStyleBackColor = True
        '
        'dataTable2
        '
        Me.dataTable2.BackgroundColor = System.Drawing.Color.White
        Me.dataTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTable2.Location = New System.Drawing.Point(49, 65)
        Me.dataTable2.MultiSelect = False
        Me.dataTable2.Name = "dataTable2"
        Me.dataTable2.ReadOnly = True
        Me.dataTable2.Size = New System.Drawing.Size(525, 300)
        Me.dataTable2.TabIndex = 8
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.controles)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.controles.ResumeLayout(False)
        Me.Pasajero.ResumeLayout(False)
        Me.Pasajero.PerformLayout()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents controles As TabControl
    Friend WithEvents Pasajero As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnElimnar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Tabla As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dataTable As DataGridView
    Friend WithEvents dataTable2 As DataGridView
    Friend WithEvents btnAgregarViaje As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnActulViaje As Button
    Friend WithEvents Salir As Button
    Friend WithEvents btnEliminarViaje As Button
    Friend WithEvents btnEditarViaje As Button
End Class
