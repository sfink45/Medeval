Option Strict On

'GameState Class
Public Class CGameState
    Private player As CPlayer
    Private intLvl As Integer
    Private intRoom As Integer
    Private id As String ' = "G"

    '--------------------------------------------------------------
    Public Sub New(cp As CPlayer, ByRef i As Integer)
        player = cp
        intLvl = 0
        intRoom = 0
        id = "G" & i.ToString("D2")
        i += 1
    End Sub

    Public Sub New(cp As CPlayer, id As String)
        player = cp
        Dim i As Integer = Integer.Parse(id.Substring(1))
        If (i >= CGame.getcount) Then
            CGame.setCount(i + 1)
        End If
        Me.id = "G" & i.ToString("D2")
    End Sub
    '---------------------------------------------------------------

    Public Function getPlayer() As CPlayer
        Return Me.player
    End Function

    Public Function getID() As String
        Return Me.id
    End Function

    Public Function getLvlNum() As Integer
        Return Me.intLvl
    End Function

    Public Function getRoomNum() As Integer
        Return Me.intRoom
    End Function

    Public Sub setRoom(i As Integer)
        intRoom = i
    End Sub
    Public Sub setCurrentRoom(i As Integer)
        intRoom = i
        CLevel.setCurrentRoom(intRoom)
    End Sub
    Public Sub setLvl(i As Integer)
        intLvl = i
    End Sub
    Public Sub setPlayer(cp As CPlayer)
        player = cp
    End Sub

    Public Sub increaselvl()
        intLvl += 1
    End Sub

    Public Overrides Function ToString() As String
        Return player.getName() & ": " & player.getLevel() & " Souls"
    End Function

End Class
