<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncounter
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
        Me.pbEncounter = New System.Windows.Forms.PictureBox()
        Me.lblEncountered = New System.Windows.Forms.Label()
        Me.btnAction1 = New System.Windows.Forms.Button()
        Me.btnAction2 = New System.Windows.Forms.Button()
        Me.tbSays = New System.Windows.Forms.TextBox()
        Me.lblSays = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.pbEncounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEncounter
        '
        Me.pbEncounter.Location = New System.Drawing.Point(119, 37)
        Me.pbEncounter.Name = "pbEncounter"
        Me.pbEncounter.Size = New System.Drawing.Size(202, 146)
        Me.pbEncounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEncounter.TabIndex = 0
        Me.pbEncounter.TabStop = False
        '
        'lblEncountered
        '
        Me.lblEncountered.AutoSize = True
        Me.lblEncountered.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncountered.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblEncountered.Location = New System.Drawing.Point(164, 9)
        Me.lblEncountered.Name = "lblEncountered"
        Me.lblEncountered.Size = New System.Drawing.Size(121, 25)
        Me.lblEncountered.TabIndex = 1
        Me.lblEncountered.Text = "Encountered :"
        '
        'btnAction1
        '
        Me.btnAction1.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAction1.Location = New System.Drawing.Point(300, 500)
        Me.btnAction1.Name = "btnAction1"
        Me.btnAction1.Size = New System.Drawing.Size(130, 61)
        Me.btnAction1.TabIndex = 2
        Me.btnAction1.Text = "Action1"
        Me.btnAction1.UseVisualStyleBackColor = True
        '
        'btnAction2
        '
        Me.btnAction2.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAction2.Location = New System.Drawing.Point(12, 500)
        Me.btnAction2.Name = "btnAction2"
        Me.btnAction2.Size = New System.Drawing.Size(130, 61)
        Me.btnAction2.TabIndex = 3
        Me.btnAction2.Text = "Action 2"
        Me.btnAction2.UseVisualStyleBackColor = True
        '
        'tbSays
        '
        Me.tbSays.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbSays.Font = New System.Drawing.Font("BankGothic Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSays.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.tbSays.Location = New System.Drawing.Point(12, 240)
        Me.tbSays.Multiline = True
        Me.tbSays.Name = "tbSays"
        Me.tbSays.ReadOnly = True
        Me.tbSays.Size = New System.Drawing.Size(418, 254)
        Me.tbSays.TabIndex = 4
        Me.tbSays.TabStop = False
        '
        'lblSays
        '
        Me.lblSays.AutoSize = True
        Me.lblSays.Font = New System.Drawing.Font("Matura MT Script Capitals", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSays.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblSays.Location = New System.Drawing.Point(9, 223)
        Me.lblSays.Name = "lblSays"
        Me.lblSays.Size = New System.Drawing.Size(40, 14)
        Me.lblSays.TabIndex = 5
        Me.lblSays.Text = "Says :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("BankGothic Md BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblName.Location = New System.Drawing.Point(183, 186)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 17)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Label1"
        '
        'frmEncounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(442, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblSays)
        Me.Controls.Add(Me.tbSays)
        Me.Controls.Add(Me.btnAction2)
        Me.Controls.Add(Me.btnAction1)
        Me.Controls.Add(Me.lblEncountered)
        Me.Controls.Add(Me.pbEncounter)
        Me.Name = "frmEncounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NPC Encounter"
        CType(Me.pbEncounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbEncounter As System.Windows.Forms.PictureBox
    Friend WithEvents lblEncountered As System.Windows.Forms.Label
    Friend WithEvents btnAction1 As System.Windows.Forms.Button
    Friend WithEvents btnAction2 As System.Windows.Forms.Button
    Friend WithEvents tbSays As System.Windows.Forms.TextBox
    Friend WithEvents lblSays As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
