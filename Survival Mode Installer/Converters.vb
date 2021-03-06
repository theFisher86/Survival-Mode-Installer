﻿Module Converters
    Public Function ParseExmlString(RawExmlString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(RawExmlString)
        For Each element As XElement In xdoc.Descendants
            Debug.Print("First Attr :" & element.FirstAttribute.ToString)
            Debug.Print("Elem Name :" & element.Name.ToString)
            If (element.Attribute("template") IsNot Nothing) Then
                If (element.Attribute("name") Is Nothing) Then
                    element.Name = element.Name.ToString & "_root"
                Else
                    element.Name = element.Name.ToString & "_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                End If
            Else
                If element.Attribute("name") IsNot Nothing Then
                    element.Name = element.Name.ToString & "_" & element.Attribute("name").Value
                    element.Attribute("name").Remove()
                    If (element.Attribute("value") IsNot Nothing) Then
                        element.Value = element.Attribute("value").Value
                        element.Attribute("value").Remove()
                    End If
                End If
            End If
        Next
        Return xdoc
    End Function

    Public Function RevertXmltoExml(XMLString As String)
        Dim xdoc As New XDocument()
        xdoc = XDocument.Parse(XMLString)
        For Each element As XElement In xdoc.Descendants
            If (element.Value IsNot Nothing) Then
                If (element.Name Is "Data_root") Then
                    element.Name = element.Name.ToString.TrimEnd("_root")
                    Debug.Print(element.Name.ToString)
                ElseIf (element.Name.ToString Like "*_*") Then
                    Dim elementArr As Array
                    elementArr = element.Name.ToString.Split("_")
                    element.Name = elementArr.GetValue(0).ToString
                    element.SetAttributeValue("name", elementArr.GetValue(1).ToString)
                    Debug.Print(element.Attributes.ToString)
                End If
            Else
                element.Name = element.Name.ToString.TrimEnd("_*")
                Debug.Print("Valueless :" & element.Name.ToString)
            End If
        Next
        Return xdoc
    End Function

End Module
