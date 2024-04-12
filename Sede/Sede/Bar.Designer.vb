<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bar
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtBar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(267, 47)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(641, 408)
        Me.dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Bar"
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(32, 120)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 22)
        Me.txtDia.TabIndex = 3
        '
        'txtBar
        '
        Me.txtBar.Location = New System.Drawing.Point(32, 260)
        Me.txtBar.Name = "txtBar"
        Me.txtBar.Size = New System.Drawing.Size(100, 22)
        Me.txtBar.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(32, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 72)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 550)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBar)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Bar"
        Me.Text = "Bar"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtBar As TextBox
    Friend WithEvents Button1 As Button
End Class
