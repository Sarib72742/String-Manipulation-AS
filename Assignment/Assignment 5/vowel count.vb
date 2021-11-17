Module Module1

    Sub Main()
        Dim Str, thischar As String
        Dim Counter, vCount As Integer

        Str = ""
        thischar = ""
        vCount = 0
        Counter = 0
        Const vowels = "aAeEiIoOuU"

        Console.Write("Enter string to look for vowels: ")
        Str = Console.ReadLine

        For Counter = 1 To Len(Str)
            thischar = Mid(Str, Counter, 1)
            If InStr(vowels, thischar) > 0 Then
                vCount = vCount + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vCount)
        Console.ReadKey()

    End Sub

End Module
