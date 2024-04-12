<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dia
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(48, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dia"
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(68, 138)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 22)
        Me.txtDia.TabIndex = 2
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(286, 47)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(574, 416)
        Me.dgv.TabIndex = 3
        '
        'Dia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 547)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Dia"
        Me.Text = "Dia"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDia As TextBox
    Friend WithEvents dgv As DataGridView
End Class
