' **************************************************************************************************
' Team Name: IFM1B 2026
' Team Member 1 Details: Papadi, RO (226008960)
' Team Member 2 Details: Mdlalose, CM (225164740)
' Practical: Group Project
' Class name: (cUser)
' **************************************************************************************************
Public MustInherit Class cUser
    Public Property Name As String
    Public Property ID As Integer

    Public MustOverride Sub GenerateReport()
End Class
