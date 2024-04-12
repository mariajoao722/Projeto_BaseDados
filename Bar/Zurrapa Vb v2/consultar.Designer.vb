<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.Label()
        Me.dgvConsultar = New System.Windows.Forms.DataGridView()
        Me.cdxItems = New System.Windows.Forms.ComboBox()
        Me.cmdAtualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdpedido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(168, 26)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "Procurar"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(60, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 1
        '
        'txtDay
        '
        Me.txtDay.AutoSize = True
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Location = New System.Drawing.Point(17, 23)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(37, 24)
        Me.txtDay.TabIndex = 2
        Me.txtDay.Text = "Dia"
        '
        'dgvConsultar
        '
        Me.dgvConsultar.AllowUserToAddRows = False
        Me.dgvConsultar.AllowUserToDeleteRows = False
        Me.dgvConsultar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultar.Location = New System.Drawing.Point(12, 55)
        Me.dgvConsultar.Name = "dgvConsultar"
        Me.dgvConsultar.Size = New System.Drawing.Size(587, 236)
        Me.dgvConsultar.TabIndex = 3
        '
        'cdxItems
        '
        Me.cdxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdxItems.FormattingEnabled = True
        Me.cdxItems.Location = New System.Drawing.Point(387, 26)
        Me.cdxItems.Name = "cdxItems"
        Me.cdxItems.Size = New System.Drawing.Size(193, 21)
        Me.cdxItems.TabIndex = 4
        '
        'cmdAtualizar
        '
        Me.cmdAtualizar.Location = New System.Drawing.Point(310, 327)
        Me.cmdAtualizar.Name = "cmdAtualizar"
        Me.cmdAtualizar.Size = New System.Drawing.Size(114, 67)
        Me.cmdAtualizar.TabIndex = 5
        Me.cmdAtualizar.Text = "Atualizar"
        Me.cmdAtualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID Pedido"
        '
        'txtIdpedido
        '
        Me.txtIdpedido.Location = New System.Drawing.Point(110, 327)
        Me.txtIdpedido.Name = "txtIdpedido"
        Me.txtIdpedido.Size = New System.Drawing.Size(88, 20)
        Me.txtIdpedido.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(110, 374)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(88, 20)
        Me.txtEstado.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "1=aberto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(497, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "0=fechado"
        '
        'consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 416)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdpedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAtualizar)
        Me.Controls.Add(Me.cdxItems)
        Me.Controls.Add(Me.dgvConsultar)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Name = "consultar"
        Me.Text = "consultar"
        CType(Me.dgvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtDay As Label
    Friend WithEvents dgvConsultar As DataGridView
    Friend WithEvents cdxItems As ComboBox
    Friend WithEvents cmdAtualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdpedido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
