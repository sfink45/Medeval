Option Strict On

'Room Class
Public Class CRoom
    Private hasEvent As Boolean
    Private hasEnemy As Boolean
    Private hasMorality As Boolean
    Private entered As Boolean = False
    Private doneEvent As Boolean = False
    Private isEnabled As Boolean = False
    Private desAudio As IO.UnmanagedMemoryStream
    Private foe As CMob
    Private prob As Integer
    Private description As String

    Public Sub New(hasEvent As Boolean, hasEnemy As Boolean, hasMorality As Boolean, description As String, desAudio As IO.UnmanagedMemoryStream)
        Me.hasEvent = hasEvent
        Me.hasEnemy = hasEnemy
        Me.desAudio = desAudio
        Me.hasMorality = hasMorality
        Me.description = description
    End Sub

    Public Function getDescription() As String
        Return Me.description
    End Function

    Private Sub playDes()
        My.Computer.Audio.Play(desAudio, AudioPlayMode.Background)
    End Sub
    Public Function isEvent() As Boolean
        Return Me.hasEvent
    End Function

    Public Function enter() As Boolean
        If (Not entered) Then
            playDes()
            entered = True
        End If
        Return entered
    End Function

    Public Function getEvent() As CMob
        Return Me.foe
    End Function

    Public Function enabled() As Boolean
        Return Me.isEnabled
    End Function
    Public Function isEventDone() As Boolean
        Return Me.doneEvent
    End Function

    Public Sub doEvent()
        doneEvent = True
    End Sub

    Public Function isEnemy() As Boolean
        If (Not foe Is Nothing) Then
            Return (Not Me.foe.hasDied)
        Else
            Return False
        End If
    End Function

    Public Function isMorality() As Boolean
        Return Me.hasMorality
    End Function

    Public Function encouterEnemy() As CMob
        Dim r As New Random
        Dim rand As Integer = r.Next(1, 100)
        If (rand <= prob) Then
            Return Me.foe
        Else
            Return Nothing
        End If
    End Function

    Public Sub enable()
        Me.isEnabled = True
    End Sub


    Public Sub addEnemy(mob As CMob, prob As Integer)
        foe = mob
        Me.prob = prob
        ' hasEnemy = True
    End Sub

End Class
