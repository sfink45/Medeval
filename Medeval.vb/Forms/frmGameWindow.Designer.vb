<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameWindow))
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.tbInfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbstat = New System.Windows.Forms.TextBox()
        Me.btnInspect = New System.Windows.Forms.Button()
        Me.btnAdvance = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInventory
        '
        Me.btnInventory.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(12, 257)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(112, 63)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "&View Your Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'tbInfo
        '
        Me.tbInfo.BackColor = System.Drawing.SystemColors.ControlText
        Me.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInfo.Font = New System.Drawing.Font("BankGothic Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInfo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.tbInfo.Location = New System.Drawing.Point(18, 42)
        Me.tbInfo.Multiline = True
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.ReadOnly = True
        Me.tbInfo.Size = New System.Drawing.Size(452, 209)
        Me.tbInfo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Matura MT Script Capitals", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Room Description"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(482, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToWindowsToolStripMenuItem, Me.ToMainMenuToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ToWindowsToolStripMenuItem
        '
        Me.ToWindowsToolStripMenuItem.Name = "ToWindowsToolStripMenuItem"
        Me.ToWindowsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ToWindowsToolStripMenuItem.Text = "...&To Windows"
        '
        'ToMainMenuToolStripMenuItem
        '
        Me.ToMainMenuToolStripMenuItem.Name = "ToMainMenuToolStripMenuItem"
        Me.ToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ToMainMenuToolStripMenuItem.Text = "...To &Main Menu"
        '
        'tbstat
        '
        Me.tbstat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbstat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbstat.Font = New System.Drawing.Font("Matura MT Script Capitals", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbstat.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.tbstat.Location = New System.Drawing.Point(130, 274)
        Me.tbstat.Multiline = True
        Me.tbstat.Name = "tbstat"
        Me.tbstat.ReadOnly = True
        Me.tbstat.Size = New System.Drawing.Size(200, 103)
        Me.tbstat.TabIndex = 9
        Me.tbstat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnInspect
        '
        Me.btnInspect.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInspect.Location = New System.Drawing.Point(12, 339)
        Me.btnInspect.Name = "btnInspect"
        Me.btnInspect.Size = New System.Drawing.Size(112, 36)
        Me.btnInspect.TabIndex = 10
        Me.btnInspect.Text = "&Inspect"
        Me.btnInspect.UseVisualStyleBackColor = True
        '
        'btnAdvance
        '
        Me.btnAdvance.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvance.Location = New System.Drawing.Point(363, 293)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(107, 58)
        Me.btnAdvance.TabIndex = 11
        Me.btnAdvance.Text = "&Advance"
        Me.btnAdvance.UseVisualStyleBackColor = True
        '
        'frmGameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(482, 393)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.btnInspect)
        Me.Controls.Add(Me.tbstat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbInfo)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGameWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SS Fink's Medeval!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents tbInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbstat As System.Windows.Forms.TextBox
    Friend WithEvents btnInspect As System.Windows.Forms.Button
    Friend WithEvents btnAdvance As System.Windows.Forms.Button
    Friend WithEvents ToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
