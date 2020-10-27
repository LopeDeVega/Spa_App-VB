Public Class FormMainMenu



    Private Sub btnEditDetails_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEditDetails.Click

        

        'it shows the next form and hide this one.
        FormActivity.Show()

        Me.Hide()




    End Sub

    Private Sub btnMembers_Click(sender As System.Object, e As System.EventArgs) Handles btnMembers.Click

        'it shows the next form and hide this one.
        'FormEditDatails.Show()
        FormMem.Show()
        Me.Hide()
       


        

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click


        'it shows the next form and hide this one.
        FormHelp.Show()

        Me.Hide()

    End Sub

    
    Private Sub FormMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class