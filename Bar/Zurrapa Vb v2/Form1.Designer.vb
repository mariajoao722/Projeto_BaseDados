<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miFzrPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.miConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFecho = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFzrPedido, Me.miConsultar, Me.StockToolStripMenuItem, Me.miFecho})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'miFzrPedido
        '
        Me.miFzrPedido.Name = "miFzrPedido"
        Me.miFzrPedido.Size = New System.Drawing.Size(86, 20)
        Me.miFzrPedido.Text = "Fazer Pedido"
        '
        'miConsultar
        '
        Me.miConsultar.Name = "miConsultar"
        Me.miConsultar.Size = New System.Drawing.Size(110, 20)
        Me.miConsultar.Text = "Consultar Pedido"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'miFecho
        '
        Me.miFecho.Name = "miFecho"
        Me.miFecho.Size = New System.Drawing.Size(99, 20)
        Me.miFecho.Text = "Fecho de Caixa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bar/Balcao"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents miFzrPedido As ToolStripMenuItem
    Friend WithEvents miConsultar As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miFecho As ToolStripMenuItem
End Class
