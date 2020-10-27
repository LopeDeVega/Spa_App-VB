Public Class FormHelp




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetun.Click

        'Its Hide this form and show Main Menu form

        Me.Hide()

        FormMainMenu.Show()


    End Sub





    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        'Local variables
        Dim Granada As Integer = 1

        If 1 Then
            MsgBox("Granada Spa" & Chr(13) & _
                   "Open 9 am to 10 pm " & Chr(13) & _
                   "Open Seven Days a Week!")

        End If

    End Sub

    Private Sub btnTimeTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeTable.Click

        'Local variable
        Dim Activity As Integer = 2

        If 2 Then
            MsgBox(" Activities Time Table" & Chr(13) & _
                   "Jaccuzi 10 am to 9 pm " & Chr(13) & _
                   "Sauna 10 am to 9 pm " & Chr(13) & _
                   "Swimiming 9.30 am to 9.30 pm")

        End If

    End Sub

    Private Sub btnSportMassage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSportMassage.Click

        'Local variable
        Dim Massage As Integer = 3

        If 3 Then
            MsgBox(" Sports Massage" & Chr(13) & _
                   "10 am to 9.30 pm " & Chr(13) & _
                    "Not availabe Sundays")

        End If


    End Sub

    Private Sub btnTrainer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrainer.Click

        Dim Trainer As Integer = 4

        If 4 Then
            MsgBox(" Personal Trainer Session " & Chr(13) & _
                   "10 am to 9.30 pm " & Chr(13) & _
                    "Not availabe Sundays")

        End If

    End Sub

  
    Private Sub FormHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class