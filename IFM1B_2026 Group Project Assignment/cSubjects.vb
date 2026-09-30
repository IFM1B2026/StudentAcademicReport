' **************************************************************************************************
' Team Name: IFM1B 2026
' Team Member 1 Details: Papadi, RO (226008960)
' Team Member 2 Details: Mdlalose, CM (225164740)
' Practical: Group Project
' Class name: (cCourse)
' **************************************************************************************************

Public Class cSubjects
    Implements IEvaluable

    Public Property Title As String
    Public Property Lessons As New List(Of String)

    Public Sub AddLesson(lesson As String)
        Lessons.Add(lesson)
    End Sub

    Public Function EvaluatePerformance() As String Implements IEvaluable.EvaluatePerformance

        Return $"Course '{Title}' has {Lessons.Count} lessons."
    End Function
End Class
