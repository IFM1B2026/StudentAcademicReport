' **************************************************************************************************
' Team Name: IFM1B 2026
' Team Member 1 Details: Papadi, RO (226008960)
' Team Member 2 Details: Mdlalose, CM (225164740)
' Practical: Group Project
' Class name: (cShared)
' **************************************************************************************************

Public Class cShared
    Public Shared Function CalculateAverage(scores As List(Of Integer)) As Double
        If scores.Count = 0 Then Return 0
        Return scores.Average()
    End Function
End Class
