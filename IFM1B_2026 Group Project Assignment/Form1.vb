Public Class frmStudentAcademicReport
    'variable decleration
    Private reports As New List(Of String)
    Private teachers As New List(Of cTeacher)
    Private studentSummaries As New List(Of Tuple(Of String, Double))

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles btnStarts.Click

        Dim nTeachers As Integer = CInt(InputBox("Enter number of teachers:"))

        For t As Integer = 1 To nTeachers
            Dim teacherID As Integer = CInt(InputBox("Enter ID for teacher " & t))
            Dim teacherName As String = InputBox("Enter name for teacher " & t)

            Dim teacher As New cTeacher With {.ID = teacherID, .Name = teacherName}

            Dim nSubjects As Integer = CInt(InputBox("How many courses does " & teacherName & " teach?"))
            For i As Integer = 1 To nSubjects
                Dim courseName As String = InputBox("Enter name of course " & i & " for " & teacherName)
                teacher.AddCourse(courseName)
            Next

            teachers.Add(teacher)

            'Call polymorphic GenerateReport 
            teacher.GenerateReport()

            'Add a summary line to listbox
            Dim summary As String = $"Teacher: {teacher.Name} (ID: {teacher.ID}) teaches {nSubjects } subjects."
            lstInputTeacher.Items.Add(summary)
            reports.Add(summary)
        Next

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        'Input all the necessary data of students

        lstReports.Items.Clear()
        reports.Clear()

        Dim nStudents As Integer = CInt(InputBox("Enter number of students:"))

        For s As Integer = 1 To nStudents
            Dim studentID As String = InputBox("Enter ID for student " & s)
            Dim studentName As String = InputBox("Enter name for student " & s)

            Dim student As New cStudent With {.ID = studentID, .Name = studentName}

            Dim nSubjects As Integer = CInt(InputBox("How many subjects does " & studentName & " have?"))

            For i As Integer = 1 To nSubjects
                Dim subjectName As String = InputBox("Enter name of subject " & i & " for " & studentName)
                Dim mark As Integer = CInt(InputBox("Enter mark for " & subjectName))
                student.ReportCard.AddSubject(subjectName, mark)
            Next

            'call function 
            Dim summary As String = $"Student {s}: {student.Name} (ID: {student.ID})" & vbCrLf &
                                    student.EvaluatePerformance() & vbCrLf &
                                    ""
            lstReports.Items.Add(summary)
            reports.Add(summary)
            Dim avg As Double = student.ReportCard.CalculateAverage()
            studentSummaries.Add(New Tuple(Of String, Double)(student.Name, avg))

        Next

    End Sub


    Private Sub btnPerformance_Click(sender As Object, e As EventArgs) Handles btnPerformance.Click
        'track overall peformance of students

        If studentSummaries.Count = 0 Then
            MessageBox.Show("Please enter student data first.")
            Return
        End If

        Dim nStudents As Integer = studentSummaries.Count
        Dim excellentCount As Integer = 0
        Dim averageCount As Integer = 0
        Dim poorCount As Integer = 0

        For Each student In studentSummaries
            Dim avg As Double = student.Item2
            If avg >= 75 Then
                excellentCount += 1
            ElseIf avg >= 50 Then
                averageCount += 1
            Else
                poorCount += 1
            End If
        Next

        'Calculate percentages
        Dim excellentPct As Double = (excellentCount / nStudents) * 100
        Dim averagePct As Double = (averageCount / nStudents) * 100
        Dim poorPct As Double = (poorCount / nStudents) * 100

        Dim overallSummary As String = "Class Performance Summary:" & vbCrLf &
                                       $"   Excellent: {excellentPct:F2}% ({excellentCount} students)" & vbCrLf &
                                       $"   Average: {averagePct:F2}% ({averageCount} students)" & vbCrLf &
                                       $"   Poor: {poorPct:F2}% ({poorCount} students)" & vbCrLf &
                                       ""

        lstPerformance.Items.Add(overallSummary)
        reports.Add(overallSummary)

        chartPerformance.Series.Clear()
        chartPerformance.ChartAreas.Clear()
        chartPerformance.ChartAreas.Add("Default")

        Dim series As New DataVisualization.Charting.Series("Performance")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Bar

        series.Points.AddXY("Excellent", excellentCount)
        series.Points.AddXY("Average", averageCount)
        series.Points.AddXY("Poor", poorCount)

        chartPerformance.Series.Add(series)
    End Sub

    Private Sub btnSaveReport_Click(sender As Object, e As EventArgs) Handles btnSaveReport.Click
        cFileManager.SaveReports(reports, "StudentReports.txt")
        MessageBox.Show("Reports saved to StudentReports.txt")

    End Sub

End Class
