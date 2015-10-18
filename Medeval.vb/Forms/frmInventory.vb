Option Strict On

'The Inventory Form
Public Class frmInventory

    Private game As CGame = frmMain.game
    Private inBattle As Boolean

    Public Sub New(b As Boolean)
        InitializeComponent()
        inBattle = True
    End Sub

    Public Sub New()
        InitializeComponent()
        inBattle = False
    End Sub

    Private Sub frmInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = game.getGameState.getPlayer.getName & "'s Inventory"
        Dim c As Collection = game.getGameState.getPlayer.getInventory
        For Each ci As CItem In c
            lbInventory.Items.Add(ci)
        Next
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnToss_Click(sender As System.Object, e As System.EventArgs) Handles btnToss.Click
        Dim itemsel As CItem
        itemsel = TryCast(lbInventory.SelectedItem, CItem)
        If (Not itemsel Is Nothing) Then
            game.getGameState.getPlayer.tossItem(itemsel)
            game.deleteItem(itemsel)
            updatebox()
        Else
            MessageBox.Show("You must select an item to toss")
        End If
    End Sub


    Private Sub btnUse_Click(sender As System.Object, e As System.EventArgs) Handles btnUse.Click
        Dim itemsel As CItem
        itemsel = TryCast(lbInventory.SelectedItem, CItem)
        If (Not itemsel Is Nothing) Then
            If (Not game.getGameState.getPlayer.useItem(itemsel, game)) Then
                MessageBox.Show("That item cannot be used now")
            Else
                If (inBattle) Then
                    Me.Close()
                Else
                    game.saveGame()
                    updatebox()
                End If
            End If
        Else
            MessageBox.Show("You must select an item to use")
        End If
    End Sub

    Private Sub updatebox()
        lbInventory.Items.Clear()
        Dim c As Collection = game.getGameState.getPlayer.getInventory
        For Each ci As CItem In c
            lbInventory.Items.Add(ci)
        Next
    End Sub
End Class