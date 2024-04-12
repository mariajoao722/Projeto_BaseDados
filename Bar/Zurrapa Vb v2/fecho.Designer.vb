<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fecho
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.diatxt = New System.Windows.Forms.TextBox()
        Me.idbartxt = New System.Windows.Forms.TextBox()
        Me.fecharcaixa = New System.Windows.Forms.Button()
        Me.dgvConsultar1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvConsultar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id Bar"
        '
        'diatxt
        '
        Me.diatxt.Location = New System.Drawing.Point(82, 33)
        Me.diatxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.diatxt.Name = "diatxt"
        Me.diatxt.Size = New System.Drawing.Size(141, 26)
        Me.diatxt.TabIndex = 2
        '
        'idbartxt
        '
        Me.idbartxt.Location = New System.Drawing.Point(82, 88)
        Me.idbartxt.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.idbartxt.Name = "idbartxt"
        Me.idbartxt.Size = New System.Drawing.Size(141, 26)
        Me.idbartxt.TabIndex = 3
        '
        'fecharcaixa
        '
        Me.fecharcaixa.Location = New System.Drawing.Point(30, 464)
        Me.fecharcaixa.Name = "fecharcaixa"
        Me.fecharcaixa.Size = New System.Drawing.Size(168, 50)
        Me.fecharcaixa.TabIndex = 4
        Me.fecharcaixa.Text = "Fechar Caixa"
        Me.fecharcaixa.UseVisualStyleBackColor = True
        '
        'dgvConsultar1
        '
        Me.dgvConsultar1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultar1.Location = New System.Drawing.Point(311, 33)
        Me.dgvConsultar1.Name = "dgvConsultar1"
        Me.dgvConsultar1.Size = New System.Drawing.Size(564, 495)
        Me.dgvConsultar1.TabIndex = 5
        '
        'fecho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 540)
        Me.Controls.Add(Me.dgvConsultar1)
        Me.Controls.Add(Me.fecharcaixa)
        Me.Controls.Add(Me.idbartxt)
        Me.Controls.Add(Me.diatxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "fecho"
        Me.Text = "fecho"
        CType(Me.dgvConsultar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents diatxt As TextBox
    Friend WithEvents idbartxt As TextBox
    Friend WithEvents fecharcaixa As Button
    Friend WithEvents dgvConsultar1 As DataGridView
End Class
