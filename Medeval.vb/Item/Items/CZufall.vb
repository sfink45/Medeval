Option Strict On

'The Zufall Item:
'Increases the player's luck
Public Class CZufall : Inherits CItem

    Public Sub New()
        MyBase.New("Zufall", 2, "IT03")
        Dim r As New Random
        Dim delta As Integer = r.Next(0, 2)
        Me.addToUses(delta)
    End Sub

    Public Sub New(i As Integer, id As String, gid As String)
        MyBase.New("Zufall", id, i, "IT03", gid)
    End Sub

    Public Overrides Function use(mob As CMob) As Boolean
        If (TypeOf (mob) Is CPlayer) Then
            Dim r As New Random
            Dim delta As Integer = r.Next(CInt(Math.Ceiling(mob.getSpeed / 2)), CInt(Math.Ceiling(mob.getSpeed * 1.5)))
            mob.increaseLuck(delta)
            Me.decrementUses()
            Return True
        Else
            Return False
        End If
    End Function
End Class

