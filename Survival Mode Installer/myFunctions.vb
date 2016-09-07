Module myFunctions
    Public Function RemoveExtension(filename As String)
        Dim JustFilename As String
        JustFilename = filename.Remove(filename.Length - (filename.Length - filename.LastIndexOf(".")))
        Return JustFilename
    End Function

    Public Function JustExtension(filename As String)
        Dim Extension As String
        Extension = filename.Remove(filename.LastIndexOf("."))
        Return Extension
    End Function

    Public Function BuildTree(TreeView As TreeView, doc As XDocument)
        Dim treeNode As TreeNode = New TreeNode(doc.Root.Name.LocalName)
        TreeView.Nodes.Add(treeNode)
        BuildNodes(treeNode, doc.Root)
    End Function

    Public Function BuildNodes(treenode As TreeNode, element As XElement)
        ' Trying to convert from  https://social.msdn.microsoft.com/Forums/en-US/01501a8e-898a-465e-92f9-ad6a16aae065/fill-treeview-control-with-data-from-xml-file-using-linq?forum=xmlandnetfx
        Dim childNode As XNode
        For Each (childNode In element.Nodes())
            If childNode.NodeType Is XElement Then
                child
            End If

        Next

    End Function

End Module

