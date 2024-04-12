<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransferirStock
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBar = New System.Windows.Forms.TextBox()
        Me.txtArm = New System.Windows.Forms.TextBox()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Bar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codigo Armazem"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 206)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantidade a mover"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(39, 57)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(76, 20)
        Me.txtID.TabIndex = 4
        '
        'txtBar
        '
        Me.txtBar.Location = New System.Drawing.Point(39, 115)
        Me.txtBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBar.Name = "txtBar"
        Me.txtBar.Size = New System.Drawing.Size(76, 20)
        Me.txtBar.TabIndex = 5
        '
        'txtArm
        '
        Me.txtArm.Location = New System.Drawing.Point(39, 172)
        Me.txtArm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtArm.Name = "txtArm"
        Me.txtArm.Size = New System.Drawing.Size(76, 20)
        Me.txtArm.TabIndex = 6
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(39, 233)
        Me.txtQtd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(76, 20)
        Me.txtQtd.TabIndex = 7
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(202, 23)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(640, 283)
        Me.dgv.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(202, 324)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 68)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Transferir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(419, 324)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 68)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Verificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TransferirStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.txtArm)
        Me.Controls.Add(Me.txtBar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TransferirStock"
        Me.Text = "TransferirStock"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBar As TextBox
    Friend WithEvents txtArm As TextBox
    Friend WithEvents txtQtd As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
