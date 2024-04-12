<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.txtValorInv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnprocurar = New System.Windows.Forms.Button()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(25, 84)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.Size = New System.Drawing.Size(533, 335)
        Me.dgvProdutos.TabIndex = 0
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(25, 36)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(158, 20)
        Me.txtProduto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome do Produto"
        '
        'cbxItems
        '
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(495, 35)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(204, 21)
        Me.cbxItems.TabIndex = 3
        '
        'txtValorInv
        '
        Me.txtValorInv.Location = New System.Drawing.Point(698, 382)
        Me.txtValorInv.Name = "txtValorInv"
        Me.txtValorInv.Size = New System.Drawing.Size(90, 20)
        Me.txtValorInv.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(559, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor de Inventario"
        '
        'btnprocurar
        '
        Me.btnprocurar.Location = New System.Drawing.Point(203, 34)
        Me.btnprocurar.Name = "btnprocurar"
        Me.btnprocurar.Size = New System.Drawing.Size(75, 23)
        Me.btnprocurar.TabIndex = 6
        Me.btnprocurar.Text = "Procurar"
        Me.btnprocurar.UseVisualStyleBackColor = True
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnprocurar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValorInv)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Name = "stock"
        Me.Text = "stock"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents txtValorInv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnprocurar As Button
End Class
