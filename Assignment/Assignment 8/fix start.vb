Module Module1

    Sub Main()

        Dim str, nextStr, newStr, firstChar, thisChar, Char1 As String
        Dim lenstr As Integer

        str = ""
        nextStr = ""
        firstChar = ""
        thisChar = ""
        Char1 = ""
        newStr = ""
        lenstr = 0

        Console.Write("Enter string: ")
        str = Console.ReadLine
        Console.Write("Enter a character which want to replace: ")
        Char1 = Console.ReadLine

        firstChar = Left(str, 1)
        lenstr = Len(str)
        nextStr = Right(str, lenstr - 1)
        For count = 1 To Len(nextStr)
            thisChar = Mid(nextStr, count, 1)
            If thisChar = Char1 Then
                newStr = newStr & "*"
            Else
                newStr = newStr & thisChar
            End If
        Next
        Console.WriteLine("New string " & firstChar & newStr)
        Console.ReadKey()

    End Sub

End Module
