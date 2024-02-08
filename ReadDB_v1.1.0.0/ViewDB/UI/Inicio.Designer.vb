<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PanCStri = New System.Windows.Forms.Panel()
        Me.ButConnC = New System.Windows.Forms.Button()
        Me.ButConnO = New System.Windows.Forms.Button()
        Me.TxBCStri = New System.Windows.Forms.TextBox()
        Me.LabCStri = New System.Windows.Forms.Label()
        Me.CBxProvi = New System.Windows.Forms.ComboBox()
        Me.LabProvi = New System.Windows.Forms.Label()
        Me.PanTabla = New System.Windows.Forms.Panel()
        Me.ButCData = New System.Windows.Forms.Button()
        Me.ButLData = New System.Windows.Forms.Button()
        Me.CBxTabla = New System.Windows.Forms.ComboBox()
        Me.ButCleaT = New System.Windows.Forms.Button()
        Me.LabTabla = New System.Windows.Forms.Label()
        Me.ButLoadT = New System.Windows.Forms.Button()
        Me.TaCDatos = New System.Windows.Forms.TabControl()
        Me.TaPDatos = New System.Windows.Forms.TabPage()
        Me.DGVDatos = New System.Windows.Forms.DataGridView()
        Me.PanConsu = New System.Windows.Forms.Panel()
        Me.CBxConsu = New System.Windows.Forms.ComboBox()
        Me.TxBConsu = New System.Windows.Forms.TextBox()
        Me.ButConsu = New System.Windows.Forms.Button()
        Me.ButExpor = New System.Windows.Forms.Button()
        Me.PanCStri.SuspendLayout()
        Me.PanTabla.SuspendLayout()
        Me.TaCDatos.SuspendLayout()
        Me.TaPDatos.SuspendLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanConsu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanCStri
        '
        Me.PanCStri.Controls.Add(Me.ButConnC)
        Me.PanCStri.Controls.Add(Me.ButConnO)
        Me.PanCStri.Controls.Add(Me.TxBCStri)
        Me.PanCStri.Controls.Add(Me.LabCStri)
        Me.PanCStri.Controls.Add(Me.CBxProvi)
        Me.PanCStri.Controls.Add(Me.LabProvi)
        Me.PanCStri.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanCStri.Location = New System.Drawing.Point(0, 0)
        Me.PanCStri.Name = "PanCStri"
        Me.PanCStri.Size = New System.Drawing.Size(884, 105)
        Me.PanCStri.TabIndex = 0
        '
        'ButConnC
        '
        Me.ButConnC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButConnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButConnC.Location = New System.Drawing.Point(752, 66)
        Me.ButConnC.Name = "ButConnC"
        Me.ButConnC.Size = New System.Drawing.Size(120, 30)
        Me.ButConnC.TabIndex = 5
        Me.ButConnC.Text = "Desconectar"
        Me.ButConnC.UseVisualStyleBackColor = True
        '
        'ButConnO
        '
        Me.ButConnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButConnO.Location = New System.Drawing.Point(249, 66)
        Me.ButConnO.Name = "ButConnO"
        Me.ButConnO.Size = New System.Drawing.Size(120, 30)
        Me.ButConnO.TabIndex = 4
        Me.ButConnO.Text = "Conectar"
        Me.ButConnO.UseVisualStyleBackColor = True
        '
        'TxBCStri
        '
        Me.TxBCStri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxBCStri.Location = New System.Drawing.Point(249, 34)
        Me.TxBCStri.Name = "TxBCStri"
        Me.TxBCStri.Size = New System.Drawing.Size(624, 26)
        Me.TxBCStri.TabIndex = 3
        '
        'LabCStri
        '
        Me.LabCStri.AutoSize = True
        Me.LabCStri.Location = New System.Drawing.Point(245, 8)
        Me.LabCStri.Name = "LabCStri"
        Me.LabCStri.Size = New System.Drawing.Size(131, 20)
        Me.LabCStri.TabIndex = 2
        Me.LabCStri.Text = "ConecctionString"
        '
        'CBxProvi
        '
        Me.CBxProvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBxProvi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBxProvi.FormattingEnabled = True
        Me.CBxProvi.Items.AddRange(New Object() {"", "SQL Server", "MySQL", "SQLite"})
        Me.CBxProvi.Location = New System.Drawing.Point(16, 32)
        Me.CBxProvi.Name = "CBxProvi"
        Me.CBxProvi.Size = New System.Drawing.Size(227, 28)
        Me.CBxProvi.TabIndex = 1
        '
        'LabProvi
        '
        Me.LabProvi.AutoSize = True
        Me.LabProvi.Location = New System.Drawing.Point(12, 8)
        Me.LabProvi.Name = "LabProvi"
        Me.LabProvi.Size = New System.Drawing.Size(81, 20)
        Me.LabProvi.TabIndex = 0
        Me.LabProvi.Text = "Proveedor"
        '
        'PanTabla
        '
        Me.PanTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanTabla.Controls.Add(Me.ButCData)
        Me.PanTabla.Controls.Add(Me.ButLData)
        Me.PanTabla.Controls.Add(Me.CBxTabla)
        Me.PanTabla.Controls.Add(Me.ButCleaT)
        Me.PanTabla.Controls.Add(Me.LabTabla)
        Me.PanTabla.Controls.Add(Me.ButLoadT)
        Me.PanTabla.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanTabla.Location = New System.Drawing.Point(0, 105)
        Me.PanTabla.Name = "PanTabla"
        Me.PanTabla.Size = New System.Drawing.Size(250, 576)
        Me.PanTabla.TabIndex = 1
        '
        'ButCData
        '
        Me.ButCData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButCData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButCData.Location = New System.Drawing.Point(143, 533)
        Me.ButCData.Name = "ButCData"
        Me.ButCData.Size = New System.Drawing.Size(100, 30)
        Me.ButCData.TabIndex = 5
        Me.ButCData.Text = "Limpiar"
        Me.ButCData.UseVisualStyleBackColor = True
        '
        'ButLData
        '
        Me.ButLData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButLData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButLData.Location = New System.Drawing.Point(11, 533)
        Me.ButLData.Name = "ButLData"
        Me.ButLData.Size = New System.Drawing.Size(100, 30)
        Me.ButLData.TabIndex = 4
        Me.ButLData.Text = "Ver datos"
        Me.ButLData.UseVisualStyleBackColor = True
        '
        'CBxTabla
        '
        Me.CBxTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBxTabla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBxTabla.FormattingEnabled = True
        Me.CBxTabla.Location = New System.Drawing.Point(11, 69)
        Me.CBxTabla.Name = "CBxTabla"
        Me.CBxTabla.Size = New System.Drawing.Size(232, 28)
        Me.CBxTabla.TabIndex = 3
        '
        'ButCleaT
        '
        Me.ButCleaT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButCleaT.Location = New System.Drawing.Point(143, 33)
        Me.ButCleaT.Name = "ButCleaT"
        Me.ButCleaT.Size = New System.Drawing.Size(100, 30)
        Me.ButCleaT.TabIndex = 2
        Me.ButCleaT.Text = "Vaciar"
        Me.ButCleaT.UseVisualStyleBackColor = True
        '
        'LabTabla
        '
        Me.LabTabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTabla.Location = New System.Drawing.Point(0, 0)
        Me.LabTabla.Name = "LabTabla"
        Me.LabTabla.Size = New System.Drawing.Size(248, 30)
        Me.LabTabla.TabIndex = 0
        Me.LabTabla.Text = "Tablas"
        Me.LabTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButLoadT
        '
        Me.ButLoadT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButLoadT.Location = New System.Drawing.Point(11, 33)
        Me.ButLoadT.Name = "ButLoadT"
        Me.ButLoadT.Size = New System.Drawing.Size(100, 30)
        Me.ButLoadT.TabIndex = 1
        Me.ButLoadT.Text = "Cargar"
        Me.ButLoadT.UseVisualStyleBackColor = True
        '
        'TaCDatos
        '
        Me.TaCDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaCDatos.Controls.Add(Me.TaPDatos)
        Me.TaCDatos.Location = New System.Drawing.Point(256, 111)
        Me.TaCDatos.Name = "TaCDatos"
        Me.TaCDatos.SelectedIndex = 0
        Me.TaCDatos.Size = New System.Drawing.Size(616, 480)
        Me.TaCDatos.TabIndex = 2
        '
        'TaPDatos
        '
        Me.TaPDatos.Controls.Add(Me.DGVDatos)
        Me.TaPDatos.Location = New System.Drawing.Point(4, 29)
        Me.TaPDatos.Name = "TaPDatos"
        Me.TaPDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TaPDatos.Size = New System.Drawing.Size(608, 447)
        Me.TaPDatos.TabIndex = 0
        Me.TaPDatos.Text = "Datos"
        Me.TaPDatos.UseVisualStyleBackColor = True
        '
        'DGVDatos
        '
        Me.DGVDatos.AllowUserToAddRows = False
        Me.DGVDatos.AllowUserToDeleteRows = False
        Me.DGVDatos.AllowUserToOrderColumns = True
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDatos.Location = New System.Drawing.Point(3, 3)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.ReadOnly = True
        Me.DGVDatos.Size = New System.Drawing.Size(602, 441)
        Me.DGVDatos.TabIndex = 0
        '
        'PanConsu
        '
        Me.PanConsu.Controls.Add(Me.ButExpor)
        Me.PanConsu.Controls.Add(Me.ButConsu)
        Me.PanConsu.Controls.Add(Me.TxBConsu)
        Me.PanConsu.Controls.Add(Me.CBxConsu)
        Me.PanConsu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanConsu.Location = New System.Drawing.Point(250, 597)
        Me.PanConsu.Name = "PanConsu"
        Me.PanConsu.Size = New System.Drawing.Size(634, 84)
        Me.PanConsu.TabIndex = 3
        '
        'CBxConsu
        '
        Me.CBxConsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBxConsu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBxConsu.FormattingEnabled = True
        Me.CBxConsu.Items.AddRange(New Object() {"", "Consulta SELECT", "Consulta que no retorna"})
        Me.CBxConsu.Location = New System.Drawing.Point(5, 7)
        Me.CBxConsu.Name = "CBxConsu"
        Me.CBxConsu.Size = New System.Drawing.Size(200, 28)
        Me.CBxConsu.TabIndex = 0
        '
        'TxBConsu
        '
        Me.TxBConsu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxBConsu.Location = New System.Drawing.Point(211, 9)
        Me.TxBConsu.Name = "TxBConsu"
        Me.TxBConsu.Size = New System.Drawing.Size(412, 26)
        Me.TxBConsu.TabIndex = 1
        '
        'ButConsu
        '
        Me.ButConsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButConsu.Location = New System.Drawing.Point(211, 41)
        Me.ButConsu.Name = "ButConsu"
        Me.ButConsu.Size = New System.Drawing.Size(100, 30)
        Me.ButConsu.TabIndex = 2
        Me.ButConsu.Text = "Ejecutar"
        Me.ButConsu.UseVisualStyleBackColor = True
        '
        'ButExpor
        '
        Me.ButExpor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButExpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButExpor.Location = New System.Drawing.Point(473, 41)
        Me.ButExpor.Name = "ButExpor"
        Me.ButExpor.Size = New System.Drawing.Size(150, 30)
        Me.ButExpor.TabIndex = 3
        Me.ButExpor.Text = "Exportar a Excel"
        Me.ButExpor.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 681)
        Me.Controls.Add(Me.PanConsu)
        Me.Controls.Add(Me.TaCDatos)
        Me.Controls.Add(Me.PanTabla)
        Me.Controls.Add(Me.PanCStri)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.PanCStri.ResumeLayout(False)
        Me.PanCStri.PerformLayout()
        Me.PanTabla.ResumeLayout(False)
        Me.TaCDatos.ResumeLayout(False)
        Me.TaPDatos.ResumeLayout(False)
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanConsu.ResumeLayout(False)
        Me.PanConsu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanCStri As Panel
    Friend WithEvents ButConnC As Button
    Friend WithEvents ButConnO As Button
    Friend WithEvents TxBCStri As TextBox
    Friend WithEvents LabCStri As Label
    Friend WithEvents CBxProvi As ComboBox
    Friend WithEvents LabProvi As Label
    Friend WithEvents PanTabla As Panel
    Friend WithEvents CBxTabla As ComboBox
    Friend WithEvents ButCleaT As Button
    Friend WithEvents LabTabla As Label
    Friend WithEvents ButLoadT As Button
    Friend WithEvents ButCData As Button
    Friend WithEvents ButLData As Button
    Friend WithEvents TaCDatos As TabControl
    Friend WithEvents TaPDatos As TabPage
    Friend WithEvents DGVDatos As DataGridView
    Friend WithEvents PanConsu As Panel
    Friend WithEvents CBxConsu As ComboBox
    Friend WithEvents TxBConsu As TextBox
    Friend WithEvents ButExpor As Button
    Friend WithEvents ButConsu As Button
End Class
