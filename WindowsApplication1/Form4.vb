Public Class FormActivity

    'Activity is the price of activities 
    Dim activity As Double = 2.0
    'Service not discount 
    Dim SportMassage As Double = 20.0
    Dim PersonalTrainer As Double = 20.0
    Dim Answer As Double
    Dim Bronze As Double = 0.4
    Dim Silver As Double = 0.6
    Dim Gold As Double



    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackForm4.Click

        'Its Hide this form and show Main Menu form

        Me.Hide()

        FormMainMenu.Show()

    End Sub



    Private Sub btnBonze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBonze.Click


        '

        lstBox.Items.Clear()

        'It shows Jacuzzi price for bronze member

        If chbJacuzzi.Checked = True Then

            Answer = activity - (activity * Bronze)
            lstBox.Items.Add("Jacuzzi is £" & Answer)

        End If

        'It shows Sauna price for bronze member 

        If chbSauna.Checked = True Then
            Answer = activity - (activity * Bronze)
            lstBox.Items.Add("Sauna is £" & Answer)

        End If
        'It shows Swimming Pool price for bronze member 

        If chbSwPool.Checked = True Then
            Answer = activity - (activity * Bronze)
            lstBox.Items.Add("Swimming Pool is £" & Answer)

        End If

        'It shows Fitness Suite price for bronze member 

        If chbFtSuit.Checked = True Then

            lstBox.Items.Add("Free activity")

        End If

        'It shows Personal Trainer price for bronze member 

        If chbTrainer.Checked Then

            lstBox.Items.Add("P T Seassion is £20 not discount")

        End If

        'It shows Sport Massage price for bronze member 

        If chbMassage.Checked Then

            lstBox.Items.Add("Sp Massage is £20 not discount")

        End If

       





    End Sub
   

    Private Sub btnSilver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSilver.Click

        lstBox.Items.Clear()

        'It shows Jacuzzi price for Silver member

        If chbJacuzzi.Checked = True Then

            Answer = activity - (activity * Silver)
            lstBox.Items.Add("Jacuzzi is £" & Answer)

        End If

        'It shows Sauna price for Silver member

        If chbSauna.Checked = True Then

            Answer = activity - (activity * Silver)
            lstBox.Items.Add("Sauna is £" & Answer)

        End If

        'It shows Swimming Pool  price for Silver member

        If chbSwPool.Checked = True Then

            Answer = activity - (activity * Silver)
            lstBox.Items.Add("Swimming Pool is £" & Answer)

        End If

        'It shows Fitness Suite price for bronze member

        If chbFtSuit.Checked = True Then

            lstBox.Items.Add("Free activity")
        End If

        'It shows Personal Trainer price for Silver member

        If chbTrainer.Checked Then

            lstBox.Items.Add("P T Seassion is £20 not discount")

        End If

        'It shows Sport Massege price for Silver member

        If chbMassage.Checked Then

            lstBox.Items.Add("Sp Massage is £20 not discount")

        End If

    End Sub

    Private Sub btnGold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGold.Click

        lstBox.Items.Clear()

        'it shows Jacuzzi, Sauna and Swimming pool prices for Gold member.

        If chbJacuzzi.Checked Or chbSauna.Checked Or chbSwPool.Checked = True Then

            lstBox.Items.Add("All activities are free")

        End If

        'It shows Personal Trainer price for Gold member

        If chbTrainer.Checked Or chbMassage.Checked Then

            lstBox.Items.Add("P T Seassion is £20 not discount")

        End If

        'It shows Sport Massage price for Gold member

        If chbMassage.Checked Then

            lstBox.Items.Add("Sp Massage is £20 not discount")

        End If

    End Sub

  

    Private Sub chbTrainer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbTrainer.CheckedChanged



    End Sub

    Private Sub chbMassage_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbMassage.CheckedChanged

       

    End Sub

    Private Sub btnRetun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetun.Click

        'Its Hide this form and show Help and more information form

        Me.Hide()

        FormHelp.Show()

    End Sub

    Private Sub FormActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class