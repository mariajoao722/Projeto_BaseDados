<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtualizarArmazem
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtQTD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.QtdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdlocalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdprodutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdLocalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZurrapaFilialDataSet = New Armazem.ZurrapaFilialDataSet()
        Me.Prod_LocalTableAdapter = New Armazem.ZurrapaFilialDataSetTableAdapters.Prod_LocalTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtArm = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdLocalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZurrapaFilialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantidade"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdLocalBindingSource, "id_produto", True))
        Me.txtID.Location = New System.Drawing.Point(54, 132)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(109, 22)
        Me.txtID.TabIndex = 2
        '
        'txtQTD
        '
        Me.txtQTD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdLocalBindingSource, "Qtd", True))
        Me.txtQTD.Location = New System.Drawing.Point(54, 231)
        Me.txtQTD.Name = "txtQTD"
        Me.txtQTD.Size = New System.Drawing.Size(109, 22)
        Me.txtQTD.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Armazem"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(52, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 54)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QtdDataGridViewTextBoxColumn, Me.IdlocalDataGridViewTextBoxColumn, Me.IdprodutoDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.ProdLocalBindingSource
        Me.dgvData.Location = New System.Drawing.Point(367, 87)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(584, 354)
        Me.dgvData.TabIndex = 7
        '
        'QtdDataGridViewTextBoxColumn
        '
        Me.QtdDataGridViewTextBoxColumn.DataPropertyName = "Qtd"
        Me.QtdDataGridViewTextBoxColumn.HeaderText = "Qtd"
        Me.QtdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QtdDataGridViewTextBoxColumn.Name = "QtdDataGridViewTextBoxColumn"
        Me.QtdDataGridViewTextBoxColumn.Width = 125
        '
        'IdlocalDataGridViewTextBoxColumn
        '
        Me.IdlocalDataGridViewTextBoxColumn.DataPropertyName = "id_local"
        Me.IdlocalDataGridViewTextBoxColumn.HeaderText = "id_local"
        Me.IdlocalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdlocalDataGridViewTextBoxColumn.Name = "IdlocalDataGridViewTextBoxColumn"
        Me.IdlocalDataGridViewTextBoxColumn.Width = 125
        '
        'IdprodutoDataGridViewTextBoxColumn
        '
        Me.IdprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto"
        Me.IdprodutoDataGridViewTextBoxColumn.HeaderText = "id_produto"
        Me.IdprodutoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdprodutoDataGridViewTextBoxColumn.Name = "IdprodutoDataGridViewTextBoxColumn"
        Me.IdprodutoDataGridViewTextBoxColumn.Width = 125
        '
        'ProdLocalBindingSource
        '
        Me.ProdLocalBindingSource.DataMember = "Prod_Local"
        Me.ProdLocalBindingSource.DataSource = Me.ZurrapaFilialDataSet
        '
        'ZurrapaFilialDataSet
        '
        Me.ZurrapaFilialDataSet.DataSetName = "ZurrapaFilialDataSet"
        Me.ZurrapaFilialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Prod_LocalTableAdapter
        '
        Me.Prod_LocalTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 40)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "3 - Armazem Sineiro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 - Armazem Avenida"
        '
        'txtArm
        '
        Me.txtArm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdLocalBindingSource, "Qtd", True))
        Me.txtArm.Location = New System.Drawing.Point(54, 324)
        Me.txtArm.Name = "txtArm"
        Me.txtArm.Size = New System.Drawing.Size(109, 22)
        Me.txtArm.TabIndex = 10
        '
        'AtualizarArmazem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 517)
        Me.Controls.Add(Me.txtArm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQTD)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AtualizarArmazem"
        Me.Text = "AtualizarArmazem"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdLocalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZurrapaFilialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtQTD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents ZurrapaFilialDataSet As ZurrapaFilialDataSet
    Friend WithEvents ProdLocalBindingSource As BindingSource
    Friend WithEvents Prod_LocalTableAdapter As ZurrapaFilialDataSetTableAdapters.Prod_LocalTableAdapter
    Friend WithEvents QtdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdlocalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdprodutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtArm As TextBox
End Class
