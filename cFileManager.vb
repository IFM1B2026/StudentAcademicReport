
Imports System.IO
Public Class cFileManager

    Public Shared Sub SaveReports(reports As List(Of String), filePath As String)
        Try
            Using writer As New IO.StreamWriter(filePath, False)
                For Each r In reports
                    writer.WriteLine(r)
                Next
            End Using
            MsgBox("Reports saved successfully!")
        Catch ex As Exception
            MsgBox("Error saving: " & ex.Message)
        End Try
    End Sub

    Public Shared Function loadReports(filePath As String)
        Dim loadedReports As New List(Of String)
        Try
            If File.Exists(filePath) Then
                Using reader As New StreamReader(filePath)
                    While Not reader.EndOfStream
                        loadedReports.Add(reader.ReadLine())
                    End While
                End Using
            Else
                MsgBox("File not found!")
            End If
        Catch ex As Exception
            MsgBox("Error loading: ")
        End Try
        Return loadedReports
    End Function
End Class
