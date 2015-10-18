<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEpilouge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEpilouge))
        Me.btnKill = New System.Windows.Forms.Button()
        Me.btnSpare = New System.Windows.Forms.Button()
        Me.btnToMain = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tbEpilouge = New System.Windows.Forms.TextBox()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.tmrdelay = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnKill
        '
        Me.btnKill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnKill.Location = New System.Drawing.Point(12, 501)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(125, 72)
        Me.btnKill.TabIndex = 0
        Me.btnKill.Text = "&Kill the King"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnSpare
        '
        Me.btnSpare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSpare.Location = New System.Drawing.Point(422, 501)
        Me.btnSpare.Name = "btnSpare"
        Me.btnSpare.Size = New System.Drawing.Size(125, 72)
        Me.btnSpare.TabIndex = 1
        Me.btnSpare.Text = "&Spare the King"
        Me.btnSpare.UseVisualStyleBackColor = True
        '
        'btnToMain
        '
        Me.btnToMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnToMain.Location = New System.Drawing.Point(143, 501)
        Me.btnToMain.Name = "btnToMain"
        Me.btnToMain.Size = New System.Drawing.Size(125, 72)
        Me.btnToMain.TabIndex = 2
        Me.btnToMain.Text = "Back to &Main"
        Me.btnToMain.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQuit.Location = New System.Drawing.Point(291, 501)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(125, 72)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "&Quit to Windows"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'tbEpilouge
        '
        Me.tbEpilouge.BackColor = System.Drawing.SystemColors.InfoText
        Me.tbEpilouge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbEpilouge.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEpilouge.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.tbEpilouge.Location = New System.Drawing.Point(12, 64)
        Me.tbEpilouge.Multiline = True
        Me.tbEpilouge.Name = "tbEpilouge"
        Me.tbEpilouge.ReadOnly = True
        Me.tbEpilouge.Size = New System.Drawing.Size(535, 431)
        Me.tbEpilouge.TabIndex = 4
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Font = New System.Drawing.Font("Matura MT Script Capitals", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblThanks.Location = New System.Drawing.Point(100, 22)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(362, 39)
        Me.lblThanks.TabIndex = 5
        Me.lblThanks.Text = "Thank You For Playing!"
        '
        'tmrdelay
        '
        Me.tmrdelay.Interval = 10
        '
        'frmEpilouge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(559, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblThanks)
        Me.Controls.Add(Me.tbEpilouge)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnToMain)
        Me.Controls.Add(Me.btnSpare)
        Me.Controls.Add(Me.btnKill)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEpilouge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Epilouge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents btnSpare As System.Windows.Forms.Button
    Friend WithEvents btnToMain As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents tbEpilouge As System.Windows.Forms.TextBox
    Friend WithEvents lblThanks As System.Windows.Forms.Label
    Friend WithEvents tmrdelay As System.Windows.Forms.Timer
End Class
