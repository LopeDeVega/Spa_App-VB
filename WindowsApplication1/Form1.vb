Public Class Form1

    'Global Variables myPassword 
    Dim myPassword As String
   


    

    Private Sub btnLogIn_Click(sender As System.Object, e As System.EventArgs) Handles btnLogIn.Click

        'Name is admin
        'Password is admin

        Select Case txtName.Text

            Case "admin"
                myPassword = "admin"


        End Select

        If txtPassword.Text = myPassword Then

            MsgBox("Welcome to the  Granada Bank Health Spa")

            'open and show the next form
            formMainMenu.Show()


            'Me.Hide Hide the LogIn form when the Main Menu's 
            'form pop on the screen. 
            Me.Hide()

        Else
            MsgBox(" Name or Password is incorrect enter again or press Exit to finish", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub lblPassWord_Click(sender As System.Object, e As System.EventArgs) Handles lblPassWord.Click

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
