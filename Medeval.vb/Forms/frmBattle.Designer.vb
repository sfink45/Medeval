<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattle
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
        Me.components = New System.ComponentModel.Container()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnDefend = New System.Windows.Forms.Button()
        Me.pbEnemy = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblEHealth = New System.Windows.Forms.Label()
        Me.lblPlayerHealth = New System.Windows.Forms.Label()
        Me.tbInfo = New System.Windows.Forms.TextBox()
        Me.tmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttack
        '
        Me.btnAttack.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAttack.Location = New System.Drawing.Point(14, 307)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(134, 86)
        Me.btnAttack.TabIndex = 0
        Me.btnAttack.Text = "&Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnItem.Location = New System.Drawing.Point(182, 307)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(134, 86)
        Me.btnItem.TabIndex = 1
        Me.btnItem.Text = "&Item"
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnDefend
        '
        Me.btnDefend.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDefend.Location = New System.Drawing.Point(348, 307)
        Me.btnDefend.Name = "btnDefend"
        Me.btnDefend.Size = New System.Drawing.Size(134, 86)
        Me.btnDefend.TabIndex = 2
        Me.btnDefend.Text = "&Defend"
        Me.btnDefend.UseVisualStyleBackColor = True
        '
        'pbEnemy
        '
        Me.pbEnemy.Location = New System.Drawing.Point(12, 12)
        Me.pbEnemy.Name = "pbEnemy"
        Me.pbEnemy.Size = New System.Drawing.Size(252, 192)
        Me.pbEnemy.TabIndex = 3
        Me.pbEnemy.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(313, 21)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(145, 25)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Enemy's Health:"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(270, 117)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(212, 25)
        Me.lblPlayer.TabIndex = 5
        Me.lblPlayer.Text = "#{Playername}'s Health:"
        '
        'lblEHealth
        '
        Me.lblEHealth.AutoSize = True
        Me.lblEHealth.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEHealth.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEHealth.Location = New System.Drawing.Point(364, 56)
        Me.lblEHealth.Name = "lblEHealth"
        Me.lblEHealth.Size = New System.Drawing.Size(54, 36)
        Me.lblEHealth.TabIndex = 6
        Me.lblEHealth.Text = "0/0"
        '
        'lblPlayerHealth
        '
        Me.lblPlayerHealth.AutoSize = True
        Me.lblPlayerHealth.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerHealth.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPlayerHealth.Location = New System.Drawing.Point(364, 142)
        Me.lblPlayerHealth.Name = "lblPlayerHealth"
        Me.lblPlayerHealth.Size = New System.Drawing.Size(54, 36)
        Me.lblPlayerHealth.TabIndex = 7
        Me.lblPlayerHealth.Text = "0/0"
        '
        'tbInfo
        '
        Me.tbInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbInfo.Font = New System.Drawing.Font("BankGothic Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInfo.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.tbInfo.Location = New System.Drawing.Point(12, 210)
        Me.tbInfo.Multiline = True
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.ReadOnly = True
        Me.tbInfo.Size = New System.Drawing.Size(466, 91)
        Me.tbInfo.TabIndex = 8
        Me.tbInfo.TabStop = False
        '
        'tmrClose
        '
        Me.tmrClose.Interval = 1000
        '
        'tmrEnemy
        '
        Me.tmrEnemy.Interval = 500
        '
        'frmBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(490, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbInfo)
        Me.Controls.Add(Me.lblPlayerHealth)
        Me.Controls.Add(Me.lblEHealth)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.pbEnemy)
        Me.Controls.Add(Me.btnDefend)
        Me.Controls.Add(Me.btnItem)
        Me.Controls.Add(Me.btnAttack)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Name = "frmBattle"
        Me.Text = "Battle!"
        CType(Me.pbEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents btnDefend As System.Windows.Forms.Button
    Friend WithEvents pbEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblEHealth As System.Windows.Forms.Label
    Friend WithEvents lblPlayerHealth As System.Windows.Forms.Label
    Friend WithEvents tbInfo As System.Windows.Forms.TextBox
    Friend WithEvents tmrClose As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy As System.Windows.Forms.Timer
End Class
