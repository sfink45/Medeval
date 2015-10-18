Option Strict On

'The New Game Form
Public Class frmNewGame

    '-------------ATTRIBUTES-----------------
    Private setStrength As Integer = 1
    Private setSpeed As Integer = 1
    Private setStamina As Integer = 1
    Private setCarry As Integer = 1
    Private setAtk As Integer = 1
    Private setLuck As Integer = 1
    Private setDef As Integer = 1
    Private pointsRemaining As Integer = 16
    Private game As CGame = frmMain.game
    '------------END OF ATTRIBUTES--------------


    '=================================NUD_VALUECHANGED METHODS===========================================================
    'each one takes the value and checks if it was incremented or decremented and adjusts
    'the pointsRemaining attribute accordingly
    'value does not change if the new value would make pointsRemaining negative
    '=====================================================================================================================
    Private Sub nudStrength_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudStrength.ValueChanged
        If (nudStrength.Value > setStrength And pointsRemaining > 0) Then
            pointsRemaining -= 1
            setStrength += 1
            updatePoints()
        ElseIf (nudStrength.Value < setStrength) Then
            pointsRemaining += 1
            setStrength -= 1
            updatePoints()
        Else
            nudStrength.Value = setStrength
            Return
        End If
    End Sub


    Private Sub nudSpeed_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudSpeed.ValueChanged
        If (nudSpeed.Value > setSpeed And pointsRemaining > 0) Then
            pointsRemaining -= 1
            setSpeed += 1
            updatePoints()
        ElseIf (nudSpeed.Value < setSpeed) Then
            pointsRemaining += 1
            setSpeed -= 1
            updatePoints()
        Else
            nudSpeed.Value = setSpeed
            Return
        End If
    End Sub

    Private Sub nudStamina_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudStamina.ValueChanged
        If (nudStamina.Value > setStamina And pointsRemaining > 0) Then
            pointsRemaining -= 1
            setStamina += 1
            updatePoints()
        ElseIf (nudStamina.Value < setStamina) Then
            pointsRemaining += 1
            setStamina -= 1
            updatePoints()
        Else
            nudStamina.Value = setStamina
            Return
        End If
    End Sub

    Private Sub nudAtk_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudAtk.ValueChanged
        If (nudAtk.Value > setAtk And pointsRemaining > 0) Then
            pointsRemaining -= 1
            setAtk += 1
            updatePoints()
        ElseIf (nudAtk.Value < setAtk) Then
            pointsRemaining += 1
            setAtk -= 1
            updatePoints()
        Else
            nudAtk.Value = setAtk
            Return
        End If
    End Sub

    Private Sub nudDef_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudDef.ValueChanged
        If (nudDef.Value > setDef And pointsRemaining > 0) Then
            pointsRemaining -= 1
            setDef += 1
            updatePoints()
        ElseIf (nudDef.Value < setStrength) Then
            pointsRemaining += 1
            setDef -= 1
            updatePoints()
        Else
            nudDef.Value = setDef
            Return
        End If
    End Sub

    Private Sub nudLuck_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudLuck.ValueChanged
        If (nudLuck.Value > setLuck And pointsRemaining > 0) Then
            pointsRemaining -= 1
            setLuck += 1
            updatePoints()
        ElseIf (nudLuck.Value < setStrength) Then
            pointsRemaining += 1
            setLuck -= 1
            updatePoints()
        Else
            nudLuck.Value = setLuck
            Return
        End If
    End Sub
    '======================================END OF NUD_VALUECHANGED METHODS=================================================

    'updates lblPoints to display how many stat points
    'are available for allocation
    Private Sub updatePoints()
        lblPoints.Text = "Points Remaining: " & pointsRemaining.ToString
    End Sub

    'Check if hero name is nothing
    'if not, create a new player and
    'launch the game window
    Private Sub btnAccept_Click(sender As System.Object, e As System.EventArgs) Handles btnAccept.Click
        If (Not tbName.Text = Nothing) Then
            My.Computer.Audio.Stop()
            Dim frm As New frmGameWindow
            Dim player As CPlayer
            player = New CPlayer(setSpeed, setAtk, setDef, setStamina, setStrength, setLuck, tbName.Text)
            CLevel.setCurrentRoom(0)
            game.createPlayer(player)
            game.getGameState.setLvl(0)
            frm.Show()

            Me.Close()
        Else
            MessageBox.Show("Your hero's name cannot be nothing!", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
    End Sub

    'On Load:
    'Set the tool tips of
    'the attributes to help the
    'user to decide the kind of player they want
    Private Sub frmNewGame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ttstr As New ToolTip(), ttspd As New ToolTip, ttsta As New ToolTip(), ttatk As New ToolTip, ttdef As New ToolTip, ttlck As New ToolTip()
        ttstr.SetToolTip(lblstr, "This determines how many items you can carry" & vbNewLine & "More Strength = More Items")
        ttatk.SetToolTip(lblatk, "This determines the strength of your attacks" & vbNewLine & "More Attack = More Damage")
        ttdef.SetToolTip(lbldef, "This determines the  your resilency" & vbNewLine & "More Defense = Less Damage from Enemies")
        ttsta.SetToolTip(lblsta, "This determines your health" & vbNewLine & "More Stamina = More Health")
        ttspd.SetToolTip(lblspd, "This determines the likelihood of enemy hits" & vbNewLine & "More Speed = Lesser Chance of Enemy Hit")
        ttlck.SetToolTip(lbllck, "This determines the likelihood of land critical hits" & vbNewLine & "More Luck = More Critical Hits")
    End Sub
End Class

