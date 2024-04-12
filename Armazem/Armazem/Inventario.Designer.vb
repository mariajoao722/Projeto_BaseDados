<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Procurar = New System.Windows.Forms.Button()
        Me.txtProcura = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Procurar
        '
        Me.Procurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Procurar.Location = New System.Drawing.Point(131, 36)
        Me.Procurar.Margin = New System.Windows.Forms.Padding(2)
        Me.Procurar.Name = "Procurar"
        Me.Procurar.Size = New System.Drawing.Size(74, 20)
        Me.Procurar.TabIndex = 0
        Me.Procurar.Text = "Procurar"
        Me.Procurar.UseVisualStyleBackColor = True
        '
        'txtProcura
        '
        Me.txtProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcura.Location = New System.Drawing.Point(20, 37)
        Me.txtProcura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProcura.Name = "txtProcura"
        Me.txtProcura.Size = New System.Drawing.Size(108, 20)
        Me.txtProcura.TabIndex = 1
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(20, 72)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(464, 284)
        Me.dgv.TabIndex = 2
        '
        'cbxItems
        '
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(259, 36)
        Me.cbxItems.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(225, 21)
        Me.cbxItems.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 289)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor do Inventátio:"
        '
        'txtSoma
        '
        Me.txtSoma.Location = New System.Drawing.Point(642, 289)
        Me.txtSoma.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSoma.Name = "txtSoma"
        Me.txtSoma.Size = New System.Drawing.Size(76, 20)
        Me.txtSoma.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nome Produto"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 366)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSoma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtProcura)
        Me.Controls.Add(Me.Procurar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Inventario"
        Me.Text = "Inventário"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Procurar As Button
    Friend WithEvents txtProcura As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoma As TextBox
    Friend WithEvents Label2 As Label
End Class
