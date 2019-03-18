Public Class StringStack

    Private items(3) As String
    Private top As Integer = -1

    Public Sub Push(newItem As String)

        If IsFull() = False Then
            top += 1
            items(top) = newItem
        Else
            Console.WriteLine("ERROR: stack is full")
        End If

    End Sub

    Public Function Pop() As String

        Dim returnItem As String = ""

        If IsEmpty() = False Then
            returnItem = items(top)
            top -= 1
        Else
            Console.WriteLine("ERROR: Stack is empty")
        End If

        Return returnItem

    End Function

    Public Function Peek() As String

        Dim returnItem As String = ""

        If IsEmpty() = False Then
            returnItem = items(top)
        Else
            Console.WriteLine("ERROR: Stack is empty")
        End If

        Return returnItem

    End Function

    Public Function IsFull() As Boolean

        If top >= items.Length - 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function IsEmpty() As Boolean

        If top < 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub ShowStack()

        If IsEmpty() Then
            Console.WriteLine(vbCrLf & "The stack is EMPTY")
        Else
            Console.WriteLine(vbCrLf & "The stack contains")
            For i = top To 0 Step -1
                Console.WriteLine("{0}: {1}", i, items(i))
            Next
        End If
        Console.WriteLine()

    End Sub

End Class
