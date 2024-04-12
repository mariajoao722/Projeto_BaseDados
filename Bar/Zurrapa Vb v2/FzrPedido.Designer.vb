<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FzrPedido
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
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cdxlocal = New System.Windows.Forms.ComboBox()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.txtemp = New System.Windows.Forms.TextBox()
        Me.txt_local = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnaAdd = New System.Windows.Forms.Button()
        Me.txtquantidade = New System.Windows.Forms.TextBox()
        Me.txtproduto = New System.Windows.Forms.TextBox()
        Me.Procurar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIDPEDIDO = New System.Windows.Forms.TextBox()
        Me.btnatualizar = New System.Windows.Forms.Button()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPedido
        '
        Me.dgvPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(351, 48)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(437, 390)
        Me.dgvPedido.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID Empregado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ID Local"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Produto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Quantidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(486, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Local"
        '
        'cdxlocal
        '
        Me.cdxlocal.FormattingEnabled = True
        Me.cdxlocal.Location = New System.Drawing.Point(551, 17)
        Me.cdxlocal.Name = "cdxlocal"
        Me.cdxlocal.Size = New System.Drawing.Size(121, 21)
        Me.cdxlocal.TabIndex = 9
        '
        'txtdia
        '
        Me.txtdia.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.txtdia.Location = New System.Drawing.Point(84, 7)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(91, 21)
        Me.txtdia.TabIndex = 10
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(84, 47)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(91, 20)
        Me.txthora.TabIndex = 11
        '
        'txtemp
        '
        Me.txtemp.Location = New System.Drawing.Point(84, 95)
        Me.txtemp.Name = "txtemp"
        Me.txtemp.Size = New System.Drawing.Size(91, 20)
        Me.txtemp.TabIndex = 12
        '
        'txt_local
        '
        Me.txt_local.Location = New System.Drawing.Point(84, 138)
        Me.txt_local.Name = "txt_local"
        Me.txt_local.Size = New System.Drawing.Size(91, 20)
        Me.txt_local.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtIDPEDIDO)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnaAdd)
        Me.Panel1.Controls.Add(Me.txtquantidade)
        Me.Panel1.Controls.Add(Me.txtproduto)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(15, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 182)
        Me.Panel1.TabIndex = 14
        '
        'btnaAdd
        '
        Me.btnaAdd.Location = New System.Drawing.Point(201, 67)
        Me.btnaAdd.Name = "btnaAdd"
        Me.btnaAdd.Size = New System.Drawing.Size(81, 44)
        Me.btnaAdd.TabIndex = 18
        Me.btnaAdd.Text = "Adicionar"
        Me.btnaAdd.UseVisualStyleBackColor = True
        '
        'txtquantidade
        '
        Me.txtquantidade.Location = New System.Drawing.Point(85, 80)
        Me.txtquantidade.Name = "txtquantidade"
        Me.txtquantidade.Size = New System.Drawing.Size(91, 20)
        Me.txtquantidade.TabIndex = 17
        '
        'txtproduto
        '
        Me.txtproduto.Location = New System.Drawing.Point(85, 22)
        Me.txtproduto.Name = "txtproduto"
        Me.txtproduto.Size = New System.Drawing.Size(91, 20)
        Me.txtproduto.TabIndex = 16
        '
        'Procurar
        '
        Me.Procurar.Location = New System.Drawing.Point(695, 16)
        Me.Procurar.Name = "Procurar"
        Me.Procurar.Size = New System.Drawing.Size(75, 23)
        Me.Procurar.TabIndex = 18
        Me.Procurar.Text = "Procura"
        Me.Procurar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAdicionar)
        Me.Panel2.Controls.Add(Me.txtemp)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_local)
        Me.Panel2.Controls.Add(Me.txtdia)
        Me.Panel2.Controls.Add(Me.txthora)
        Me.Panel2.Location = New System.Drawing.Point(15, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 174)
        Me.Panel2.TabIndex = 19
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(201, 67)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(81, 44)
        Me.btnAdicionar.TabIndex = 14
        Me.btnAdicionar.Text = "Começar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Finalizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Id Pedido"
        '
        'txtIDPEDIDO
        '
        Me.txtIDPEDIDO.Location = New System.Drawing.Point(85, 138)
        Me.txtIDPEDIDO.Name = "txtIDPEDIDO"
        Me.txtIDPEDIDO.Size = New System.Drawing.Size(91, 20)
        Me.txtIDPEDIDO.TabIndex = 20
        '
        'btnatualizar
        '
        Me.btnatualizar.Location = New System.Drawing.Point(183, 395)
        Me.btnatualizar.Name = "btnatualizar"
        Me.btnatualizar.Size = New System.Drawing.Size(84, 43)
        Me.btnatualizar.TabIndex = 21
        Me.btnatualizar.Text = "Atualizar"
        Me.btnatualizar.UseVisualStyleBackColor = True
        '
        'FzrPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnatualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Procurar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cdxlocal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvPedido)
        Me.Name = "FzrPedido"
        Me.Text = "FzrPedido"
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPedido As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cdxlocal As ComboBox
    Friend WithEvents txtdia As TextBox
    Friend WithEvents txthora As TextBox
    Friend WithEvents txtemp As TextBox
    Friend WithEvents txt_local As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnaAdd As Button
    Friend WithEvents txtquantidade As TextBox
    Friend WithEvents txtproduto As TextBox
    Friend WithEvents Procurar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtIDPEDIDO As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnatualizar As Button
End Class
