Option Strict On

'Celeritas Item:
'Increases the users speed
Public Class CCeleritas : Inherits CItem

    Public Sub New()
        MyBase.New("Celertias", 1, "IT02")
    End Sub

    Public Sub New(i As Integer, id As String, gid As String)
        MyBase.New("Celertias", id, i, "IT02", gid)
    End Sub

    Public Overrides Function use(mob As CMob) As Boolean
        If (TypeOf (mob) Is CPlayer) Then
            Dim r As New Random
            Dim delta As Integer = r.Next(CInt(Math.Ceiling(mob.getSpeed / 4)), CInt(Math.Ceiling(mob.getSpeed / 2)))
            mob.increaseSpeed(delta)
            Me.decrementUses()
            Return True
        Else
            Return False
        End If
    End Function
End Class
