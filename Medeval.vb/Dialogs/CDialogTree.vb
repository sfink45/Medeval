Option Strict On

'The Dialog Tree Class
Public Class CDialogTree
    Private root As CDialogNode

    Public Sub New(node As CDialogNode)
        root = node
    End Sub

    Public Sub addtoTree(node As CDialogNode)
        Dim currentNode As CDialogNode = root
        Dim nextNode As CDialogNode = root

        While (currentNode.getVal() <> node.getVal() And Not nextNode Is Nothing)
            currentNode = nextNode
            If (nextNode.getVal() < node.getVal()) Then
                nextNode = nextNode.getRNode
            Else
                nextNode = nextNode.getLNode
            End If
        End While

        If (currentNode.getVal = node.getVal) Then
            Return
        ElseIf (currentNode.getVal < node.getVal) Then
            currentNode.setRightNode(node)
        Else
            currentNode.setLeftNode(node)
        End If
    End Sub

    Public Function getCurrentNode() As CDialogNode
        Return Me.root
    End Function

    Public Sub goRight()
        root = root.getRNode
    End Sub

    Public Sub goLeft()
        root = root.getLNode
    End Sub
End Class
