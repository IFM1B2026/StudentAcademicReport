<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentAcademicReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnStarts = New System.Windows.Forms.Button()
        Me.btnSaveReport = New System.Windows.Forms.Button()
        Me.lstReports = New System.Windows.Forms.ListBox()
        Me.lblPerformance = New System.Windows.Forms.Label()
        Me.btnPerformance = New System.Windows.Forms.Button()
        Me.lstPerformance = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lstInputTeacher = New System.Windows.Forms.ListBox()
        Me.chartPerformance = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartPerformance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStarts
        '
        Me.btnStarts.Location = New System.Drawing.Point(306, 3)
        Me.btnStarts.Name = "btnStarts"
        Me.btnStarts.Size = New System.Drawing.Size(150, 39)
        Me.btnStarts.TabIndex = 0
        Me.btnStarts.Text = "Start"
        Me.btnStarts.UseVisualStyleBackColor = True
        '
        'btnSaveReport
        '
        Me.btnSaveReport.Location = New System.Drawing.Point(306, 138)
        Me.btnSaveReport.Name = "btnSaveReport"
        Me.btnSaveReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSaveReport.Size = New System.Drawing.Size(150, 39)
        Me.btnSaveReport.TabIndex = 2
        Me.btnSaveReport.Text = "Save Report"
        Me.btnSaveReport.UseVisualStyleBackColor = True
        '
        'lstReports
        '
        Me.lstReports.FormattingEnabled = True
        Me.lstReports.ItemHeight = 16
        Me.lstReports.Location = New System.Drawing.Point(3, 272)
        Me.lstReports.Name = "lstReports"
        Me.lstReports.Size = New System.Drawing.Size(776, 84)
        Me.lstReports.TabIndex = 4
        '
        'lblPerformance
        '
        Me.lblPerformance.AutoSize = True
        Me.lblPerformance.Location = New System.Drawing.Point(303, 272)
        Me.lblPerformance.Name = "lblPerformance"
        Me.lblPerformance.Size = New System.Drawing.Size(0, 17)
        Me.lblPerformance.TabIndex = 5
        '
        'btnPerformance
        '
        Me.btnPerformance.Location = New System.Drawing.Point(306, 92)
        Me.btnPerformance.Name = "btnPerformance"
        Me.btnPerformance.Size = New System.Drawing.Size(150, 40)
        Me.btnPerformance.TabIndex = 6
        Me.btnPerformance.Text = "Performance"
        Me.btnPerformance.UseVisualStyleBackColor = True
        '
        'lstPerformance
        '
        Me.lstPerformance.FormattingEnabled = True
        Me.lstPerformance.ItemHeight = 16
        Me.lstPerformance.Location = New System.Drawing.Point(3, 371)
        Me.lstPerformance.Name = "lstPerformance"
        Me.lstPerformance.Size = New System.Drawing.Size(776, 84)
        Me.lstPerformance.TabIndex = 7
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(306, 48)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(150, 38)
        Me.btnInput.TabIndex = 9
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lstInputTeacher
        '
        Me.lstInputTeacher.FormattingEnabled = True
        Me.lstInputTeacher.ItemHeight = 16
        Me.lstInputTeacher.Location = New System.Drawing.Point(3, 182)
        Me.lstInputTeacher.Name = "lstInputTeacher"
        Me.lstInputTeacher.Size = New System.Drawing.Size(776, 84)
        Me.lstInputTeacher.TabIndex = 10
        '
        'chartPerformance
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartPerformance.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartPerformance.Legends.Add(Legend1)
        Me.chartPerformance.Location = New System.Drawing.Point(3, 461)
        Me.chartPerformance.Name = "chartPerformance"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPerformance.Series.Add(Series1)
        Me.chartPerformance.Size = New System.Drawing.Size(776, 300)
        Me.chartPerformance.TabIndex = 11
        Me.chartPerformance.Text = "Chart Performance"
        '
        'frmStudentAcademicReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 850)
        Me.Controls.Add(Me.chartPerformance)
        Me.Controls.Add(Me.lstInputTeacher)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lstPerformance)
        Me.Controls.Add(Me.btnPerformance)
        Me.Controls.Add(Me.lblPerformance)
        Me.Controls.Add(Me.lstReports)
        Me.Controls.Add(Me.btnSaveReport)
        Me.Controls.Add(Me.btnStarts)
        Me.Name = "frmStudentAcademicReport"
        Me.Text = "Student Academic Report"
        CType(Me.chartPerformance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStarts As Button
    Friend WithEvents btnSaveReport As Button
    Friend WithEvents lblPerformance As Label
    Friend WithEvents lstReports As ListBox
    Friend WithEvents btnPerformance As Button
    Friend WithEvents lstPerformance As ListBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstInputTeacher As ListBox
    Friend WithEvents chartPerformance As DataVisualization.Charting.Chart
End Class
