Public Class cFileManager
    Public Shared Sub SaveReports(reports As List(Of String), filePath As String)
        Using writer As New IO.StreamWriter(filePath, False)
            For Each r In reports
                writer.WriteLine(r)
            Next
        End Using
    End Sub
End Class
