Option Strict On

'The Final level class
Public Class CFinalLevel : Inherits CLevel

    Public Sub New()
        MyBase.New(1)
        Dim des As String = "I push open the doors made of hand-carved mahogany and my eyes are blinded by a brilliantly white glare. " & _
            "As my eyes adjust to this light, I begin to see a long chamber whose ivory walls are lined with pillars of flawless alabaster. " & _
            "At the end of the hall, an imposing figure adorned in purple and blue sits atop a throne of pure gold.  Echoing across the " & _
            "distance between us I hear him say: I have been expecting you."
        Dim room As New CRoom(True, True, False, des, My.Resources.final_scene_des)
        room.addEnemy(New CKing(), 100)
        addRoom(room)
    End Sub

End Class
