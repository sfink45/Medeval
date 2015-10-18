Option Strict On

'The Intro level class:
'3 Rooms - 1 Morality choice
Public Class CLevelIntro : Inherits CLevel
    Public Sub New()
        MyBase.New(3)
        Dim des As String = "I awake in a dark, damp cell.  Shivering as I lay on the cold cobblestone floor, I attempt to " & _
    "gather my wits.  The putrid stench of rotting flesh burns my nostrils.  I glance around the room " & _
    "and find nothing but icy iron bars and flames feeblely dancing on a torch beyond them.  I stand up " & _
    "to try and feel their heat as the flicker.  As soon as I am on my feet, an old raspy voice behind " & _
    "me says: Oh? Are you finally awake?"

        Dim oldman As New COldMan()
        Dim room As New CRoom(True, False, False, des, My.Resources.scene1)
        room.addEnemy(oldman, 100)
        room.enable()
        addRoom(room)
        des = "With the power of the old man’s soul pulsating through my extremities, I walk through the iron bars as if they never existed." & _
            "As the torch on the wall chases away the shadows, I notice a dark hallway to my right. " & _
            "I tread cautiously down the passageway, each step echoing against the brick walls.  " & _
            "I continue this way until I reach a sharp turn in the hall, where I notice a gentle glow against the back wall." & _
            "The light grows and the faint scraping sound of iron boots on rocky floors becomes louder.  The path to save Iman will not be bloodless."
        room = New CRoom(True, True, False, des, My.Resources.scene2)
        room.addEnemy(New CStartGuard(), 100)
        addRoom(room)

        des = "The warm blood of the fallen guard warms my hands as I turn the corner of the hallway.  " & _
            "Down this passage I can see another cell on the left side and a shadowy alcove on the right. As I walk " & _
            "past the cell a voice yells: ‘Hero! You must save me from this agony!’ As I approach the bars of the cell, " & _
            "a dancing light down the hall catches my eye.  Another guard must be approaching! I ponder whether to save this " & _
            "unfortunate soul or hide in the alcove, for I have not time for both."
        room = New CRoom(True, False, True, des, My.Resources.moral_scene_des)
        room.addEnemy(New CPrisoner(), 100)
        addRoom(room)
    End Sub
End Class
