Public Class cReportCard
    Private Subjects As New List(Of cSubject)

    Public Sub AddSubject(name As String, mark As Integer)
        Subjects.Add(New cSubject With {.SubjectName = name, .Mark = mark})
    End Sub

    Public Function CalculateAverage() As Double
        If Subjects.Count = 0 Then Return 0
        Return Subjects.Average(Function(s) s.Mark)
    End Function

    Public Function BestSubject() As cSubject
        Return Subjects.OrderByDescending(Function(s) s.Mark).First()
    End Function

    Public Function LowestSubject() As cSubject
        Return Subjects.OrderBy(Function(s) s.Mark).First()
    End Function

    Public Function GenerateSummary() As String
        Dim avg = CalculateAverage()
        Dim best = BestSubject()
        Dim low = LowestSubject()
        Return $"Average: {avg}, Best: {best.SubjectName} ({best.Mark}), Lowest: {low.SubjectName} ({low.Mark})"
    End Function
End Class
