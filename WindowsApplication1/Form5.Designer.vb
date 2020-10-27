<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHelp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHelp))
        Me.btnRetun = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnTimeTable = New System.Windows.Forms.Button()
        Me.btnSportMassage = New System.Windows.Forms.Button()
        Me.btnTrainer = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRetun
        '
        Me.btnRetun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRetun.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetun.Location = New System.Drawing.Point(1006, 30)
        Me.btnRetun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRetun.Name = "btnRetun"
        Me.btnRetun.Size = New System.Drawing.Size(151, 75)
        Me.btnRetun.TabIndex = 2
        Me.btnRetun.Text = "Bact to Main Menu"
        Me.btnRetun.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.Black
        Me.MonthCalendar1.Location = New System.Drawing.Point(52, 62)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(14)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        Me.MonthCalendar1.TitleBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.Red
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEvent.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.Location = New System.Drawing.Point(13, 18)
        Me.lblEvent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(377, 21)
        Me.lblEvent.TabIndex = 4
        Me.lblEvent.Text = "Calender´s events and Important date."
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.White
        Me.btnOpen.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Location = New System.Drawing.Point(518, 89)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(107, 37)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "Open time"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnTimeTable
        '
        Me.btnTimeTable.BackColor = System.Drawing.Color.White
        Me.btnTimeTable.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeTable.Location = New System.Drawing.Point(518, 132)
        Me.btnTimeTable.Name = "btnTimeTable"
        Me.btnTimeTable.Size = New System.Drawing.Size(107, 69)
        Me.btnTimeTable.TabIndex = 7
        Me.btnTimeTable.Text = " Activities " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Timetable"
        Me.btnTimeTable.UseVisualStyleBackColor = False
        '
        'btnSportMassage
        '
        Me.btnSportMassage.BackColor = System.Drawing.Color.White
        Me.btnSportMassage.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSportMassage.Location = New System.Drawing.Point(518, 207)
        Me.btnSportMassage.Name = "btnSportMassage"
        Me.btnSportMassage.Size = New System.Drawing.Size(107, 56)
        Me.btnSportMassage.TabIndex = 8
        Me.btnSportMassage.Text = "Sport Massage"
        Me.btnSportMassage.UseVisualStyleBackColor = False
        '
        'btnTrainer
        '
        Me.btnTrainer.BackColor = System.Drawing.Color.White
        Me.btnTrainer.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainer.Location = New System.Drawing.Point(492, 269)
        Me.btnTrainer.Name = "btnTrainer"
        Me.btnTrainer.Size = New System.Drawing.Size(158, 77)
        Me.btnTrainer.TabIndex = 9
        Me.btnTrainer.Text = "Personal Trainer Session"
        Me.btnTrainer.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(452, 44)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(224, 42)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.Text = "   Press the buttons " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to get the information " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPhone.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.Location = New System.Drawing.Point(974, 238)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(183, 42)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "  Contact Number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     074 19056480"
        '
        'FormHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1194, 526)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnTrainer)
        Me.Controls.Add(Me.btnSportMassage)
        Me.Controls.Add(Me.btnTimeTable)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnRetun)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormHelp"
        Me.Text = "Help and more information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRetun As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnTimeTable As System.Windows.Forms.Button
    Friend WithEvents btnSportMassage As System.Windows.Forms.Button
    Friend WithEvents btnTrainer As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
End Class
