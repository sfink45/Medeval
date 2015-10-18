Option Strict On

Public Class CGame
    Private Shared gamecol As Collection
    Private lvlArr(1) As CLevel
    Private gs As CGameState
    Private data As New CData
    Private Shared count As Integer = 0
    Private inventories As New Collection

    Private Shared player As CPlayer

    Public Sub New()
        gamecol = New Collection
        lvlArr(0) = New CLevelIntro()
        lvlArr(1) = New CFinalLevel()
    End Sub

    Public Function getSavedGames(ByRef msg As String) As Boolean
        data.readInventory(inventories, msg)
        Return data.readTable(gamecol, msg)
    End Function

    Public Sub createPlayer(cp As CPlayer)
        gs = New CGameState(cp, count)
        lvlArr(0) = New CLevelIntro()
        lvlArr(1) = New CFinalLevel()
        gamecol.Add(gs, gs.getID())
        data.saveNewGame(gs)
    End Sub
    Public Function getGameCol() As Collection
        Return gamecol
    End Function

    Public Function getGameState() As CGameState
        Return gs
    End Function

    Public Function getCurrentLvl() As CLevel
        Return Me.lvlArr(gs.getLvlNum())
    End Function

    Public Sub open(gs As CGameState)
        Me.gs = gs
        Dim c As New Collection
        For Each item As CItem In inventories
            If (item.getGID() = gs.getID) Then
                c.Add(item, item.getID)
            End If
        Next
        gs.getPlayer.setInventory(c)
    End Sub

    Public Sub saveGame()
        data.saveGame(gs)
    End Sub

    Public Sub remove(gamesel As CGameState)
        gamecol.Remove(gamesel.getID)
        open(gamesel)
        data.remove(gamesel)
    End Sub

    Public Shared Sub setCount(i As Integer)
        count = i
    End Sub

    Shared Function getcount() As Integer
        Return count
    End Function

    Public Sub updateInventory(myItem As CItem)
        data.updateInventory(myItem, gs)
    End Sub

    Public Sub deleteItem(myItem As CItem)
        data.deleteItem(myItem, gs)
    End Sub

    Public Sub addItem(item As CItem)
        data.addItem(item, gs)
    End Sub


End Class
