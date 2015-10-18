<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.lbInventory = New System.Windows.Forms.ListBox()
        Me.btnUse = New System.Windows.Forms.Button()
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbInventory
        '
        Me.lbInventory.BackColor = System.Drawing.SystemColors.MenuText
        Me.lbInventory.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbInventory.FormattingEnabled = True
        Me.lbInventory.ItemHeight = 14
        Me.lbInventory.Location = New System.Drawing.Point(18, 13)
        Me.lbInventory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lbInventory.Name = "lbInventory"
        Me.lbInventory.Size = New System.Drawing.Size(306, 256)
        Me.lbInventory.TabIndex = 0
        '
        'btnUse
        '
        Me.btnUse.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUse.Location = New System.Drawing.Point(334, 38)
        Me.btnUse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(164, 45)
        Me.btnUse.TabIndex = 1
        Me.btnUse.Text = "&Use Selected Item"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'btnToss
        '
        Me.btnToss.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToss.Location = New System.Drawing.Point(334, 112)
        Me.btnToss.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(164, 45)
        Me.btnToss.TabIndex = 2
        Me.btnToss.Text = "&Toss Selected Item"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(334, 183)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 45)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Back"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(516, 282)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnToss)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.lbInventory)
        Me.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Inventory"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbInventory As System.Windows.Forms.ListBox
    Friend WithEvents btnUse As System.Windows.Forms.Button
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
