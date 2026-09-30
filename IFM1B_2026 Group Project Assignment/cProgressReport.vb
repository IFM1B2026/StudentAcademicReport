' **************************************************************************************************
' Team Name: IFM1B 2026
' Team Member 1 Details: Papadi, RO (226008960)
' Team Member 2 Details: Mdlalose, CM (225164740)
' Practical: Group Project
' Class name: (cProgressReport)
' **************************************************************************************************

Public Class cProgressReport
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
        Dim compliment As String
        If avg >= 75 Then
            compliment = "Excellent Performance."
            MsgBox("Keep it up!")
        ElseIf avg >= 50 Then
            compliment = "Satisfactory Performance."
            MsgBox("Aim higher with consistent study.")
        Else
            compliment = "Needs Improvement"
            MsgBox("Focus on your weakest subject and seek extra help. Please Consider attending consultation sessions, asking teachers for guidance, 
                 and reviewing study materials regularly.")
        End If
        Return $" Average: {avg:F2}, Best: {best.SubjectName} ({best.Mark}), Lowest: {low.SubjectName} ({low.Mark}), Performance: {compliment}"

    End Function
End Class
