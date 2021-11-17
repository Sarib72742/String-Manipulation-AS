Module Module1

    Sub Main()
        Dim str1, thischar As String
        Dim isallalpha As Boolean
        Dim count, alphapos As Integer

        str1 = ""
        thischar = ""
        isallalpha = True
        count = 0
        alphapos = 0
        Const alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Console.Write("enter string ")
        str1 = Console.ReadLine()
        str1 = UCase(str1)
        For count = 1 To Len(alpha)
            thischar = Mid(alpha, count, 1)
            alphapos = InStr(str1, thischar)
            If alphapos = 0 Then
                isallalpha = False
            End If
            Exit For

        Next

        If isallalpha = True Then
            Console.WriteLine("entered string have all alphabet")
        End If

        If isallalpha = False Then
            Console.WriteLine("entered string have not all alphabet")
        End If
        Console.ReadKey()

    End Sub

End Module
