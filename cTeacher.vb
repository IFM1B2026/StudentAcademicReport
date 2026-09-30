' **************************************************************************************************
' Team Number: IFM1B 2026
' Team Member 1 Details: Papadi, RO (226008960)
' Team Member 2 Details: Mdlalose, CM (225164740)
' Practical: Group Project
' Class name: (cTeacher)
' **************************************************************************************************

Public Class cTeacher
    Inherits cUser
    Public Property Courses As New List(Of String)

    Public Sub AddCourse(course As String)
        Courses.Add(course)
    End Sub

    Public Overrides Sub GenerateReport()
        MessageBox.Show($"Teacher {Name} teaches {Courses.Count} subjects.")
    End Sub

End Class
