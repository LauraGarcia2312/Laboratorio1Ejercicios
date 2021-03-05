Module Module1
    Sub Main(args As String())
        Dim L As Integer = 0
        Dim A As Integer = 0
        Dim U As Integer = 0
        Console.Write("CUANTOS ELEMENTOS: ")

        Dim VEC(0 To A + 1 - 1) As Integer

        For L = 1 To A
            Console.Write("POSICIÓN {0} ==>", L)
            U = Console.ReadLine()
            VEC(L) = Integer.Parse(U)
        Next

        For L = 1 To A - 1

        Next
        For S = L + 1 To A
            If (VEC(L) < VEC(S)) Then

                A = VEC(S)
                VEC(S) = VEC(L)
                VEC(L) = A

            End If

        Next
        Console.WriteLine("orden DESCENDENTE")

    End Sub

End Module


