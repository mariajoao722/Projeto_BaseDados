<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.miInventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizarStockArmazemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferirStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MsMain
        '
        Me.MsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miInventario, Me.AtualizarStockArmazemToolStripMenuItem, Me.TransferirStockToolStripMenuItem})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(1311, 28)
        Me.MsMain.TabIndex = 1
        Me.MsMain.Text = "MenuStrip1"
        '
        'miInventario
        '
        Me.miInventario.Name = "miInventario"
        Me.miInventario.Size = New System.Drawing.Size(89, 24)
        Me.miInventario.Text = "Inventário"
        '
        'AtualizarStockArmazemToolStripMenuItem
        '
        Me.AtualizarStockArmazemToolStripMenuItem.Name = "AtualizarStockArmazemToolStripMenuItem"
        Me.AtualizarStockArmazemToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.AtualizarStockArmazemToolStripMenuItem.Text = "Atualizar Stock Armazem"
        '
        'TransferirStockToolStripMenuItem
        '
        Me.TransferirStockToolStripMenuItem.Name = "TransferirStockToolStripMenuItem"
        Me.TransferirStockToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.TransferirStockToolStripMenuItem.Text = "Transferir Stock"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 612)
        Me.Controls.Add(Me.MsMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MsMain
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MsMain.ResumeLayout(False)
        Me.MsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents miInventario As ToolStripMenuItem
    Friend WithEvents AtualizarStockArmazemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferirStockToolStripMenuItem As ToolStripMenuItem
End Class
