Option Strict On

'Abstract Level class
Public MustInherit Class CLevel

    '----------------------------------
    Private rooms() As CRoom
    Private des() As String
    Private pnt As Integer = 0
    Private Shared currentRoom As Integer = 0
    Private isCleared As Boolean = False
    '----------------------------------

    Public Sub New(num As Integer)
        ReDim rooms(num - 1)
        ReDim des(num - 1)
    End Sub

    Public Sub addRoom(hasEvent As Boolean, hasEnemy As Boolean, hasTreasure As Boolean, str As String, desAudio As IO.UnmanagedMemoryStream)
        Dim room As New CRoom(hasEvent, hasEnemy, hasTreasure, str, desAudio)
        rooms(pnt) = room
        pnt += 1
    End Sub

    Public Sub addRoom(room As CRoom)
        rooms(pnt) = room
        pnt += 1
    End Sub

    Public Function getRoomNum() As Integer
        Return Me.pnt
    End Function

    Public Function getCurrentRoomNum() As Integer
            Return currentRoom
    End Function

    Public Function move() As Boolean
        If (currentRoom >= rooms.Length - 1) Then
            isCleared = True
            Return True
        Else
            If (rooms(currentRoom + 1).enabled) Then
                currentRoom += 1
                Return True
            ElseIf (rooms(currentRoom).isEventDone) Then
                currentRoom += 1
                rooms(currentRoom).enable()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function getCurrentRoom() As CRoom
        If (Not rooms(currentRoom).enabled) Then rooms(currentRoom).enable()
        Return rooms(currentRoom)
    End Function
    Public Function isLvlCleared() As Boolean
        Return Me.isCleared
    End Function

    Public Shared Sub setCurrentRoom(i As Integer)
        currentRoom = i
    End Sub
End Class
