Public Class frmSurvivalModeInstaller
    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        Dim dlgNewFile As New OpenFileDialog()
        dlgNewFile.RestoreDirectory = True
        dlgNewFile.Filter = "exml Files |*.exml|xml files|*.xml|MBIN files|*.mbin|All files|*.*"

        If dlgNewFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim ParsedXml As New XDocument

            ' Run conversions on input file and spit out ParsedXml
            If dlgNewFile.FileName.EndsWith(".exml", StringComparison.OrdinalIgnoreCase) Then
                Dim RawExmlString As String                                                 ' EXML Loader
                Debug.Print("Reading File")
                RawExmlString = My.Computer.FileSystem.ReadAllText(dlgNewFile.FileName)
                Debug.Print("Converting to XML")
                ParsedXml = Converters.ParseExmlString(RawExmlString)
                Debug.Print("exml file now available as ParsedXml")
            ElseIf dlgNewFile.FileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) Then
                Dim RawXmlString As String                                                  ' XML Loader
                Debug.Print("Reading XML File")
                RawXmlString = My.Computer.FileSystem.ReadAllText(dlgNewFile.FileName)
                ParsedXml = XDocument.Parse(RawXmlString)
                Debug.Print("Xml file loaded as ParsedXml")
            ElseIf dlgNewFile.FileName.EndsWith(".MBIN", StringComparison.OrdinalIgnoreCase) Then
                Dim FilePath As String = dlgNewFile.FileName.ToString                       ' MBIN Loader
                Dim MBINCompiler As New Process
                Dim StartInfo As New ProcessStartInfo(My.Settings.MBINCompilerPath, FilePath)
                StartInfo.UseShellExecute = False
                StartInfo.RedirectStandardOutput = True
                Debug.Print("Extracting Exml from MBIN")
                MBINCompiler.StartInfo = StartInfo
                MBINCompiler.Start()

                Dim MBINCompilerOutput As String
                Using streamreader As System.IO.StreamReader = MBINCompiler.StandardOutput
                    MBINCompilerOutput = streamreader.ReadToEnd()
                End Using
                If MBINCompilerOutput.StartsWith("XML data written to") = False Then
                    MsgBox("Error in Decompiling MBIN.  Please see MBINCompiler Output below: " & MBINCompilerOutput, MsgBoxStyle.Exclamation, "MBINCompiler Error!")
                Else
                    Debug.Print("MBIN Decompiled Successfully")
                End If
                Debug.Print("MBINCompiler Output :" & MBINCompilerOutput)

                Debug.Print("Reading newly created exml file")
                Dim RawExmlString As String
                Dim BaseFileName As String
                BaseFileName = myFunctions.RemoveExtension(dlgNewFile.FileName.ToString)
                RawExmlString = My.Computer.FileSystem.ReadAllText(BaseFileName.ToString & ".exml")
                Debug.Print("RawExmlString : " & RawExmlString.ToString)
                Debug.Print("Converting to XML")
                ParsedXml = Converters.ParseExmlString(RawExmlString)
                Debug.Print("exml file now available as ParsedXml")
                Debug.Print(ParsedXml.ToString)
                Debug.Print("MBIN file decompiled to exml, converted and loaded as ParsedXml")
            ElseIf dlgNewFile.FileName.EndsWith(".pak", StringComparison.OrdinalIgnoreCase) Then
                Debug.Print("follow pak path")                                              ' PAK Loader
            Else
                Debug.Print("Not sure how to handle this.")                                 ' Loader Error
                MsgBox("I'm not sure what happened")
                Exit Sub
            End If

            ' Create New Tab for file
            Dim newTab As New TabPage()
            Dim newTreeView As New TreeView()
            newTab.Text = myFunctions.RemoveExtension(dlgNewFile.SafeFileName.ToString)
            newTab.Controls.Add(newTreeView)
            tabMainInterface.TabPages.Add(newTab)

            ' Populate TreeView with XMLdata
            newTreeView.Nodes.Clear()


        End If
    End Sub

    Private Sub btnLocateMBINCompiler_Click(sender As Object, e As EventArgs) Handles btnLocateMBINCompiler.Click
        Dim dlgLocateMBINCompiler As New OpenFileDialog()
        dlgLocateMBINCompiler.RestoreDirectory = True
        dlgLocateMBINCompiler.Filter = "MBINCompiler.exe|MBINCompiler.exe"

        If dlgLocateMBINCompiler.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Debug.Print("Setting MBINCompiler Path to " & dlgLocateMBINCompiler.FileName.ToString)
            My.Settings.MBINCompilerPath = dlgLocateMBINCompiler.FileName.ToString
            My.Settings.Save()
            lblMBINCompilerPath.Text = My.Settings.MBINCompilerPath
        End If
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.MBINCompilerPath Is Nothing Then
            lblMBINCompilerPath.Text = "Not Set"
            lblMBINCompilerPath.ForeColor = Color.Red
        Else
            lblMBINCompilerPath.Text = My.Settings.MBINCompilerPath
            lblMBINCompilerPath.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
