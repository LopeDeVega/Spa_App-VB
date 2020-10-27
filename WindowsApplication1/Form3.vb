Public Class FormMem


    Dim arraySize As Integer
    'used to keep employee number
    Dim i As Integer




    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' call let me call the module arrays.
        Call initialise()

        txtMembershipN.Text = mems(0).memMemebershipNo
        txtName.Text = mems(0).memName
        txtAddress.Text = mems(0).memAddress
        txtPostcode.Text = mems(0).memPostcode
        txtMobileN.Text = mems(0).memMobile
        txtStartDate.Text = mems(0).memStartDate
        txtEndDate.Text = mems(0).memEndDate
        txtMembershipT.Text = mems(0).memMembershipType
        txtEmailAddress.Text = mems(0).memEmailAddress
        

        'get the number of employees in the array
        arraySize = mems.GetUpperBound(0)

        'initialise employee number
        i = 0

        txtMembershipN.Text = i

    End Sub



    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click



        'Its Hide this form and show Main Menu form

        Me.Hide()

        FormMainMenu.Show()


    End Sub


  

   

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        'this condition let me get the previous membership
        If i > 14 Then
            i = 15
        Else
            i = i - 1

        End If

        'all requierements to be a membership 
        txtMembershipN.Text = i
        txtName.Text = mems(i).memName
        txtAddress.Text = mems(i).memAddress
        txtPostcode.Text = mems(i).memPostcode
        txtMobileN.Text = mems(i).memMobile
        txtStartDate.Text = mems(i).memStartDate
        txtEndDate.Text = mems(i).memEndDate
        txtMembershipT.Text = mems(i).memMembershipType
        txtEmailAddress.Text = mems(i).memEmailAddress


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        'this condition let me get the next membership
        If i > 14 Then
            i = 15
        Else
            i = i + 1

        End If

        'all requierements to be a membership 
        txtMembershipN.Text = i
        txtName.Text = mems(i).memName
        txtAddress.Text = mems(i).memAddress
        txtPostcode.Text = mems(i).memPostcode
        txtMobileN.Text = mems(i).memMobile
        txtStartDate.Text = mems(i).memStartDate
        txtEndDate.Text = mems(i).memEndDate
        txtMembershipT.Text = mems(i).memMembershipType
        txtEmailAddress.Text = mems(i).memEmailAddress


    End Sub


    Private Sub txtMembershipN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembershipN.TextChanged

        mems(i).memMemebershipNo = txtMembershipN.Text

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

        mems(i).memName = txtName.Text


    End Sub



    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged

        mems(i).memAddress = txtAddress.Text

    End Sub


    Private Sub txtPostcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostcode.TextChanged

        mems(i).memPostcode = txtPostcode.Text

    End Sub

    Private Sub txtMobileN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileN.TextChanged

        mems(i).memMobile = txtMobileN.Text

    End Sub

    Private Sub txtStartDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartDate.TextChanged

        mems(i).memStartDate = txtStartDate.Text

    End Sub

    Private Sub txtEndDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndDate.TextChanged

        mems(i).memEndDate = txtEndDate.Text

    End Sub


    Private Sub txtMembershipT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMembershipT.TextChanged

        mems(i).memMembershipType = txtMembershipT.Text

    End Sub
 


    Private Sub txtEmailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmailAddress.TextChanged

        mems(i).memEmailAddress = txtEmailAddress.Text

    End Sub

    
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Dim save As Integer

        'Open the file
        MyFileName = "file.txt"

        'Second parameter gives the append Mode - is true = append, false =overwrite
        MyCSVWriter = My.Computer.FileSystem.OpenTextFileWriter(MyFileName, False)

        For save = 0 To arraySize
            MyNewLine = mems(save).memMemebershipNo & "," & mems(save).memName & "," & mems(save).memAddress & "," & mems(save).memPostcode & "," & mems(save).memMobile & "," & mems(save).memStartDate & "," & mems(save).memEndDate & "," & mems(save).memMembershipType & "," & mems(save).memEmailAddress
            'it writes the line of data (Write CSV DATA)
            MyCSVWriter.WriteLine(MyNewLine)
        Next
        'it close the file
        MyCSVWriter.Close()

    End Sub

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click

        'Local variable
        Dim myfileName As String

        'Difane a StreamReader that we can use to read the CSV file.
        myfileName = "file.txt"
        MyCSVReader = My.Computer.FileSystem.OpenTextFileReader(myfileName)
        Line_Save = -1
        'Start the count at -1 so the first record is 0

        Do While Not MyCSVReader.EndOfStream ' Reapeat until no more data
            Line_Save = Line_Save + 1 'increment the record couter
            ' MyfileInput a locar variable
            Dim MyfileInput() As String = Split(MyCSVReader.ReadLine, ",")
            'Define an array created from the CSVReader data, splitting up the line at each comma

            mems(Line_Save).memMemebershipNo = MyfileInput(0)
            mems(Line_Save).memName = MyfileInput(1)
            mems(Line_Save).memAddress = MyfileInput(2)
            mems(Line_Save).memPostcode = MyfileInput(3)
            mems(Line_Save).memMobile = MyfileInput(4)
            mems(Line_Save).memStartDate = MyfileInput(5)
            mems(Line_Save).memEndDate = MyfileInput(6)
            mems(Line_Save).memMembershipType = MyfileInput(7)
            mems(Line_Save).memEmailAddress = MyfileInput(8)

        Loop

        MyCSVReader.Close()
        'Close the streamReader

        txtMembershipN.Text = mems(0).memMemebershipNo
        txtName.Text = mems(0).memName
        txtAddress.Text = mems(0).memAddress
        txtPostcode.Text = mems(0).memPostcode
        txtMobileN.Text = mems(0).memMobile
        txtStartDate.Text = mems(0).memStartDate
        txtEndDate.Text = mems(0).memEndDate
        txtMembershipT.Text = mems(0).memMembershipType
        txtEmailAddress.Text = mems(0).memEmailAddress


    End Sub

   
   
  

 
    Private Sub btnRetun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click


        'Its Hide this form and show Help and more information form

        Me.Hide()

        FormHelp.Show()

    End Sub
End Class