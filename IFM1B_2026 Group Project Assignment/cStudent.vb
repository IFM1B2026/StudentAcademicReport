' **************************************************************************************************
' Team Name: IFM1B 2026
' Team Member 1 Details: Papadi, RO (226008960)
' Team Member 2 Details: Mdlalose, CM (225164740)
' Practical: Group Project
' Class name: (cStudent)
' **************************************************************************************************

Public Class cStudent

    Inherits cUser
    Implements IEvaluable

    Public Property ReportCard As New cProgressReport()

    Public Overrides Sub GenerateReport()
        MessageBox.Show($"Report for {Name}" & vbCrLf & ReportCard.GenerateSummary())
    End Sub

    Public Function EvaluatePerformance() As String Implements IEvaluable.EvaluatePerformance
        Return ReportCard.GenerateSummary()
    End Function
End Class
