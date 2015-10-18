<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadGame))
        Me.lbGames = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbGames
        '
        Me.lbGames.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGames.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGames.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbGames.FormattingEnabled = True
        Me.lbGames.ItemHeight = 14
        Me.lbGames.Location = New System.Drawing.Point(12, 18)
        Me.lbGames.Name = "lbGames"
        Me.lbGames.Size = New System.Drawing.Size(140, 240)
        Me.lbGames.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(158, 18)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(114, 81)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "&Load Selected Game"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(158, 202)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(114, 70)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "&Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(158, 114)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(114, 70)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "&Remove Selected Game"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmLoadGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(284, 284)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lbGames)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoadGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Previous Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbGames As System.Windows.Forms.ListBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
