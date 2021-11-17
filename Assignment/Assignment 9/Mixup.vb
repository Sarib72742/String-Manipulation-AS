Module Module1

    Sub Main()
        Dim str1, str2, LC, FC, newstr1, newstr2 As String

        str1 = ""
        str2 = ""
        LC = ""
        FC = ""
        newstr1 = ""
        newstr2 = ""

        Console.Write("Enter string 1 for the replacing: ")
        str1 = Console.ReadLine
        Console.Write("Enter string 2 for the replacing: ")
        str2 = Console.ReadLine

        LC = Left(str1, 2)
        FC = Left(str2, 2)
        newstr1 = Mid(str1, 3, Len(str1) - 2)
        newstr2 = Mid(str2, 3, Len(str2) - 2)

        Console.Write((FC & newstr1) & " " & (LC & newstr2))
        Console.ReadLine()
    End Sub

End Module
