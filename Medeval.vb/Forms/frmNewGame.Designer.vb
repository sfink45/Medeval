<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewGame))
        Me.Label = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.lblstr = New System.Windows.Forms.Label()
        Me.nudStrength = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.nudStamina = New System.Windows.Forms.NumericUpDown()
        Me.nudAtk = New System.Windows.Forms.NumericUpDown()
        Me.nudDef = New System.Windows.Forms.NumericUpDown()
        Me.lblspd = New System.Windows.Forms.Label()
        Me.lblsta = New System.Windows.Forms.Label()
        Me.lblatk = New System.Windows.Forms.Label()
        Me.lbldef = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.nudLuck = New System.Windows.Forms.NumericUpDown()
        Me.lbllck = New System.Windows.Forms.Label()
        CType(Me.nudStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStamina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAtk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLuck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Matura MT Script Capitals", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label.Location = New System.Drawing.Point(70, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(190, 25)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Your Hero's Name:"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(75, 37)
        Me.tbName.MaxLength = 15
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(185, 21)
        Me.tbName.TabIndex = 1
        '
        'lblstr
        '
        Me.lblstr.AutoSize = True
        Me.lblstr.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstr.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblstr.Location = New System.Drawing.Point(11, 124)
        Me.lblstr.Name = "lblstr"
        Me.lblstr.Size = New System.Drawing.Size(86, 14)
        Me.lblstr.TabIndex = 2
        Me.lblstr.Text = "Strength :"
        '
        'nudStrength
        '
        Me.nudStrength.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudStrength.Location = New System.Drawing.Point(113, 121)
        Me.nudStrength.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudStrength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStrength.Name = "nudStrength"
        Me.nudStrength.ReadOnly = True
        Me.nudStrength.Size = New System.Drawing.Size(28, 19)
        Me.nudStrength.TabIndex = 3
        Me.nudStrength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSpeed
        '
        Me.nudSpeed.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSpeed.Location = New System.Drawing.Point(113, 165)
        Me.nudSpeed.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSpeed.Name = "nudSpeed"
        Me.nudSpeed.ReadOnly = True
        Me.nudSpeed.Size = New System.Drawing.Size(28, 19)
        Me.nudSpeed.TabIndex = 4
        Me.nudSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStamina
        '
        Me.nudStamina.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudStamina.Location = New System.Drawing.Point(113, 211)
        Me.nudStamina.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudStamina.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStamina.Name = "nudStamina"
        Me.nudStamina.ReadOnly = True
        Me.nudStamina.Size = New System.Drawing.Size(28, 19)
        Me.nudStamina.TabIndex = 5
        Me.nudStamina.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudAtk
        '
        Me.nudAtk.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAtk.Location = New System.Drawing.Point(283, 126)
        Me.nudAtk.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudAtk.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAtk.Name = "nudAtk"
        Me.nudAtk.ReadOnly = True
        Me.nudAtk.Size = New System.Drawing.Size(28, 19)
        Me.nudAtk.TabIndex = 7
        Me.nudAtk.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDef
        '
        Me.nudDef.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDef.Location = New System.Drawing.Point(283, 163)
        Me.nudDef.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudDef.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDef.Name = "nudDef"
        Me.nudDef.ReadOnly = True
        Me.nudDef.Size = New System.Drawing.Size(28, 19)
        Me.nudDef.TabIndex = 8
        Me.nudDef.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblspd
        '
        Me.lblspd.AutoSize = True
        Me.lblspd.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspd.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblspd.Location = New System.Drawing.Point(37, 165)
        Me.lblspd.Name = "lblspd"
        Me.lblspd.Size = New System.Drawing.Size(60, 14)
        Me.lblspd.TabIndex = 9
        Me.lblspd.Text = "Speed :"
        '
        'lblsta
        '
        Me.lblsta.AutoSize = True
        Me.lblsta.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsta.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblsta.Location = New System.Drawing.Point(23, 211)
        Me.lblsta.Name = "lblsta"
        Me.lblsta.Size = New System.Drawing.Size(74, 14)
        Me.lblsta.TabIndex = 10
        Me.lblsta.Text = "Stamina :"
        '
        'lblatk
        '
        Me.lblatk.AutoSize = True
        Me.lblatk.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblatk.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblatk.Location = New System.Drawing.Point(160, 126)
        Me.lblatk.Name = "lblatk"
        Me.lblatk.Size = New System.Drawing.Size(116, 14)
        Me.lblatk.TabIndex = 12
        Me.lblatk.Text = "Attack Power :"
        '
        'lbldef
        '
        Me.lbldef.AutoSize = True
        Me.lbldef.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldef.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbldef.Location = New System.Drawing.Point(151, 165)
        Me.lbldef.Name = "lbldef"
        Me.lbldef.Size = New System.Drawing.Size(126, 14)
        Me.lbldef.TabIndex = 13
        Me.lbldef.Text = "Defense Power :"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPoints.Location = New System.Drawing.Point(83, 83)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(161, 14)
        Me.lblPoints.TabIndex = 14
        Me.lblPoints.Text = "Points Remaining: 20"
        '
        'btnAccept
        '
        Me.btnAccept.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(98, 249)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(140, 40)
        Me.btnAccept.TabIndex = 15
        Me.btnAccept.Text = "Accept Your Hero!"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'nudLuck
        '
        Me.nudLuck.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLuck.Location = New System.Drawing.Point(283, 205)
        Me.nudLuck.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudLuck.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLuck.Name = "nudLuck"
        Me.nudLuck.ReadOnly = True
        Me.nudLuck.Size = New System.Drawing.Size(28, 19)
        Me.nudLuck.TabIndex = 16
        Me.nudLuck.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbllck
        '
        Me.lbllck.AutoSize = True
        Me.lbllck.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllck.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbllck.Location = New System.Drawing.Point(221, 211)
        Me.lbllck.Name = "lbllck"
        Me.lbllck.Size = New System.Drawing.Size(55, 14)
        Me.lbllck.TabIndex = 17
        Me.lbllck.Text = "Luck : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmNewGame
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(323, 301)
        Me.Controls.Add(Me.lbllck)
        Me.Controls.Add(Me.nudLuck)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lbldef)
        Me.Controls.Add(Me.lblatk)
        Me.Controls.Add(Me.lblsta)
        Me.Controls.Add(Me.lblspd)
        Me.Controls.Add(Me.nudDef)
        Me.Controls.Add(Me.nudAtk)
        Me.Controls.Add(Me.nudStamina)
        Me.Controls.Add(Me.nudSpeed)
        Me.Controls.Add(Me.nudStrength)
        Me.Controls.Add(Me.lblstr)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Your Hero!"
        CType(Me.nudStrength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStamina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAtk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLuck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents lblstr As System.Windows.Forms.Label
    Friend WithEvents nudStrength As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudStamina As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAtk As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDef As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblspd As System.Windows.Forms.Label
    Friend WithEvents lblsta As System.Windows.Forms.Label
    Friend WithEvents lblatk As System.Windows.Forms.Label
    Friend WithEvents lbldef As System.Windows.Forms.Label
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents nudLuck As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbllck As System.Windows.Forms.Label
End Class
