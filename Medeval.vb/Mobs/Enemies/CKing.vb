Option Strict On

'The King mob
Public Class CKing : Inherits CMob

    Private Shared img As Image = My.Resources.king

    Public Sub New()
        MyBase.New(5, 10, 3, 3, 3, 6, "The King", True, img, New CDialogNode("So you are the one who has been murdering my subjects?", "I AM the one that will free Iman from your iron first!", _
                                         "And your blood is next to be spilt!", 0, My.Resources.youaretheone, My.Resources.ironfistfreedom, My.Resources.urbintbs))

        filldialog()
    End Sub

    Private Sub filldialog()
        'Start Right
        '======================================================================================================================================
        dialog.addtoTree(New CDialogNode("Oh? Why do you believe that my kingdom should fall?", _
                         "Because you are a tyrant!", "Because the Old Man said it was my destiny!", 5, My.Resources.whyshouldkinfall, My.Resources.youratyrant, My.Resources.oldmansaiddes))

        'Because you are a tyrant path
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("I am not a tyrant, but rather the harbinger of order.  Those peasants want nothing short of chaos.  And entropy will be the bane of humanity’s existence.  Order is the only thing that can save humanity from itself.  Does it make me evil if I wish to protect ourselves from extinction.", _
                         "Righteous leaders do not imprison innocent men!", "Leave", 6, My.Resources.notatyrant, My.Resources.rldniim, Nothing))
        dialog.addtoTree(New CDialogNode("That man was not innocent! He was a murderer!  In cold blood, he slit the throat of my police chief in his village!  He had to pay for his sin and be thrown into my dungeon", _
                                         "You lie! You are evil!", "Leave", 7, My.Resources.notinnocent, My.Resources.ulure, Nothing))
        dialog.addtoTree(New CDialogNode("A man is much like a book.  A book has many pages, and a man has many sides.  None of the pages in my book contain any villany.  But if you are so convinced, come closer. I will show you how innocent I can be!", _
                                         "Battle", "Leave", 8, My.Resources.muchlikeabook, Nothing, Nothing))
        '---------------------------------------END ...TYRANT PATH--------------------------------------------------------------------------------------------------------------------

        'Because the old Man said... path
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("That old man puts more effort into believing what the seers have said than he does into logic and reasoning.  All of the words that he spouts are nothing more than mere nonsense, yet many still trust his words.  You do know that you are not the first one to have these Savior delusions? I am also certain that you will not be the last.", _
                        "But the Old Man had given me his soul for power!", "Leave", 1, My.Resources.moreeffortintoseers, My.Resources.oldmansoulpower, Nothing))
        dialog.addtoTree(New CDialogNode("That man was as old as the dust of the earth! It is a wonder how death had not taken his life a half century ago!", _
                        "You lie! I am the Savior!", "Leave", 2, My.Resources.oldasdust, My.Resources.ulimsavior, Nothing))
        dialog.addtoTree(New CDialogNode("If you are so convinced of your delusions, I will entertain them. I warn you, I will not be held responsible if you are cured of them… and your life!", _
                        "Battle", "Leave", 3, My.Resources.curedofdel, Nothing, Nothing))
        '-----------------------------------------END ..OLD MAN.. PATH---------------------------------------------------------------------------------------------------------------
        '============================END RIGHT PATH============================================================================================

        'Start Left
        '======================================================================================================================================
        dialog.addtoTree(New CDialogNode("Oh? And why is that?", "Because you are a tyrant!", _
                                         "Because the Old Man said it was my destiny!", -4, My.Resources.ohWhyisthat, My.Resources.youratyrant, My.Resources.oldmansaiddes))

        'YOu are a tyrant path
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("I am not a tyrant, but rather the harbinger of order.  Those peasants want nothing short of chaos.  And entropy will be the bane of humanity’s existence.  Order is the only thing that can save humanity from itself.  Does it make me evil if I wish to protect ourselves from extinction", _
                         "Righteous leaders do not imprison innocent men!", "Leave", -3, My.Resources.notatyrant, My.Resources.rldniim, Nothing))
        dialog.addtoTree(New CDialogNode("That man was not innocent! He was a murderer!  In cold blood, he slit the throat of my police chief in his village!  He had to pay for his sin and be thrown into my dungeon", _
                        "You lie! You are evil!", "Leave", -2, My.Resources.notinnocent, My.Resources.ulure, Nothing))
        dialog.addtoTree(New CDialogNode("A man is much like a book.  A book has many pages, and a man has many sides.  None of the pages in my book contain any villany.  But if you are so convinced, come closer. I will show you how innocent I can be!", _
                        "Battle", "Leave", -1, My.Resources.muchlikeabook, Nothing, Nothing))
        '-----------------------------END ...TYRANT PATH------------------------------------------------------------------------------------------------------------------------------


        'Because the old Man said... path
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        dialog.addtoTree(New CDialogNode("That old man puts more effort into believing what the seers have said than he does into logic and reasoning.  All of the words that he spouts are nothing more than mere nonsense, yet many still trust his words.  You do know that you are not the first one to have these Savior delusions? I am also certain that you will not be the last.", _
                        "But the Old Man had given me his soul for power!", "Leave", -7, My.Resources.moreeffortintoseers, My.Resources.oldmansoulpower, Nothing))
        dialog.addtoTree(New CDialogNode("That man was as old as the dust of the earth! It is a wonder how death had not taken his life a half century ago!", _
                        "You lie! I am the Savior!", "Leave", -6, My.Resources.oldasdust, My.Resources.ulimsavior, Nothing))
        dialog.addtoTree(New CDialogNode("If you are so convinced of your delusions, I will entertain them. I warn you, I will not be held responsible if you are cured of them… and your life!", _
                        "Battle", "Leave", -5, My.Resources.curedofdel, Nothing, Nothing))
        '-----------------------------------END BECASE OLD MAN... PATH---------------------------------------------------------------------------------------------------------------
        '==========================END LEFT PATH===============================================================================================
    End Sub

End Class
