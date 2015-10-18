Option Strict On

'The Battle Form
Public Class frmBattle

    'Attributes
    Private enemy As CMob
    Private player As CPlayer
    Private game As CGame = frmMain.game

    'Holds the data for the cmob
    'with the initiative
    '0 = enemy
    '1 = player
    Private first As Integer
    Private firstAttack As Integer = 1

    Public Sub New(ByRef enemy As CMob)
        InitializeComponent()
        Me.player = game.getGameState.getPlayer()
        Me.enemy = enemy
        If (enemy.getSpeed > player.getSpeed) Then
            first = 0
            firstAttack = 0
        Else
            first = 1
        End If
    End Sub

    Private Sub frmBattle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblEHealth.Text = enemy.getLife & "/" & enemy.getMaxLife
        lblPlayerHealth.Text = player.getLife & "/" & player.getMaxLife
        lblPlayer.Text = player.getName & "'s Health:"
        pbEnemy.Image = enemy.getImg("Battle")
        If (first = 0) Then
            tbInfo.Text = enemy.getName & " has the intitiative"
        Else
            tbInfo.Text = "You have the intiative"
        End If
    End Sub

    Private Sub updatelabels()
        lblEHealth.Text = enemy.getLife & "/" & enemy.getMaxLife
        If (enemy.getLife <= enemy.getMaxLife / 2) Then
            If (enemy.getLife <= enemy.getMaxLife / 4) Then
                If (enemy.getLife <= 0) Then
                    lblEHealth.Text = "0/" & enemy.getMaxLife
                End If
                lblEHealth.ForeColor = Color.Red
            Else
                lblEHealth.ForeColor = Color.Yellow
            End If
        Else
            lblEHealth.ForeColor = Color.Green
        End If
        lblPlayerHealth.Text = player.getLife & "/" & player.getMaxLife
        If (player.getLife <= player.getMaxLife / 2) Then
            If (player.getLife <= player.getMaxLife / 4) Then
                If (player.getLife <= 0) Then
                    lblPlayerHealth.Text = "0/" & player.getMaxLife
                End If
                lblPlayerHealth.ForeColor = Color.Red
            Else
                lblPlayerHealth.ForeColor = Color.Yellow
            End If
        Else
            lblPlayerHealth.ForeColor = Color.Green
        End If
    End Sub

    Private Sub frmBattle_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter
        If (firstAttack = 0) Then
            tmrEnemy.Start()
            firstAttack += 1
        End If
    End Sub


    Private Sub btnItem_Click(sender As System.Object, e As System.EventArgs) Handles btnItem.Click
        Dim frm As New frmInventory(True)
        frm.btnToss.Visible = False
        frm.Show()
    End Sub

    Private Sub btnDefend_Click(sender As System.Object, e As System.EventArgs) Handles btnDefend.Click
        Dim dmg As Integer = 0
        tbInfo.Text = "You brace yourself for the next attack!"
        player.guard()
        tmrEnemy.Start()
    End Sub

    Private Sub frmBattle_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        updatelabels()
    End Sub

    Private Sub btnAttack_Click(sender As System.Object, e As System.EventArgs) Handles btnAttack.Click
        Dim dmg As Integer = 0
        player.attack(enemy, dmg)
        tbInfo.Text = "You do " & dmg.ToString & " points of damage to " & enemy.getName()
        updatelabels()
        If (enemy.getLife <= 0) Then
            victory()
        Else
            tmrEnemy.Start()
        End If

    End Sub

    Private Sub victory()
        tbInfo.Text = "You have killed the " & enemy.getName() & "!" & ControlChars.NewLine & "You feel your powers increase as you absorb his soul!"
        player.soulUp()
        tmrClose.Start()
    End Sub

    Private Sub checkForPDeath()
        If (player.getLife <= 0) Then
            tbInfo.Text = "You died!" & ControlChars.NewLine & "You will be started where you died with full health"
            enemy.heal(1000)
            player.heal(1000)
            tmrClose.Start()
        End If
    End Sub

    Private Sub tmrClose_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClose.Tick
        Me.Close()
    End Sub

    Private Sub tmrEnemy_Tick(sender As System.Object, e As System.EventArgs) Handles tmrEnemy.Tick
        Dim dmg As Integer = 0
        If (enemy.attack(player, dmg)) Then
            tbInfo.Text = enemy.getName & " does " & dmg & "points of damage to you!"
            updatelabels()
            checkForPDeath()
        Else
            tbInfo.Text = enemy.getName & "'s attack missed!"
        End If
        tmrEnemy.Stop()
    End Sub
End Class