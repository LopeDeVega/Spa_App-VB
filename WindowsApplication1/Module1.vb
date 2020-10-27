Module Module1
    'StreamWriter permite leer y escribir caracteres en secuencias o archivos... 
    'mediante una codificacion especifica para covertir carateres bytes y viceversa
    'Public me hace la variable global haciendolo en Module.
    Public MyCSVWriter As System.IO.StreamWriter
    Public MyFileName As String
    Public MyNewLine As String

    Public MyCSVReader As System.IO.StreamReader
    Public Line_Save As Integer



    ' defining a structure to enter the list's list.
    Structure Members
        'Declare the variables
        Dim memMemebershipNo As Integer
        Dim memName As String
        Dim memAddress As String
        Dim memPostcode As String
        Dim memMobile As String
        Dim memStartDate As String
        Dim memEndDate As String
        Dim memMembershipType As String
        Dim memEmailAddress As String




    End Structure
    'List set up of 15 members
    Public mems(15) As Members

    Sub initialise()
        'all members declared .
        mems(0).memMemebershipNo = 0
        mems(0).memName = "Modric"
        mems(0).memAddress = "La Barriada"
        mems(0).memPostcode = "M1 8GH"
        mems(0).memMobile = "075 00190368"
        mems(0).memStartDate = "7 / 7 / 2015"
        mems(0).memEndDate = "4 / 6 / 2017"
        mems(0).memMembershipType = "Silver"
        mems(0).memEmailAddress = "Modric.Real@gmail.com"

        mems(1).memName = "Kroos"
        mems(1).memAddress = "La Barriada"
        mems(1).memPostcode = "M1 8LH"
        mems(1).memMobile = "075 00190464"
        mems(1).memStartDate = "12 / 12 / 2015"
        mems(1).memEndDate = "21 / 11 / 2017"
        mems(1).memMemebershipNo = 2
        mems(1).memMembershipType = "Gold"
        mems(1).memEmailAddress = "Kroos.Real@gmail.com"

        mems(2).memName = "Cristiano"
        mems(2).memAddress = "La Barriada"
        mems(2).memPostcode = "M1 8GM"
        mems(2).memMobile = "074 20193464"
        mems(2).memStartDate = "1 / 1 / 2016"
        mems(2).memEndDate = "22 / 10 / 2018"
        mems(2).memMemebershipNo = 3
        mems(2).memMembershipType = "Gold"
        mems(2).memEmailAddress = "Cristiano.Real@gmail.com"

        mems(3).memName = "Carvajal"
        mems(3).memAddress = "La Barriada"
        mems(3).memPostcode = "M1 7GH"
        mems(3).memMobile = "075 00130463"
        mems(3).memStartDate = "1 / 2 / 2015"
        mems(3).memEndDate = "1 / 6 / 2017"
        mems(3).memMemebershipNo = 4
        mems(3).memMembershipType = "Bronze"
        mems(3).memEmailAddress = "Carvajal.Real@gmail.com"

        mems(4).memName = "Isco"
        mems(4).memAddress = "La Barriada"
        mems(4).memPostcode = "M1 8AH"
        mems(4).memMobile = "074 60100414"
        mems(4).memStartDate = "12 / 3 / 2016"
        mems(4).memEndDate = "12 / 3 / 2017"
        mems(4).memMemebershipNo = 5
        mems(4).memMembershipType = "Silver"
        mems(4).memEmailAddress = "Isco.Real@gmail.com"

        mems(5).memName = "Ramos"
        mems(5).memAddress = "La Barriada"
        mems(5).memPostcode = "M1 8AC"
        mems(5).memMobile = "075 90190964"
        mems(5).memStartDate = "2 / 4 / 2016"
        mems(5).memEndDate = "17 / 12 / 2017"
        mems(5).memMemebershipNo = 6
        mems(5).memMembershipType = "Bronze"
        mems(5).memEmailAddress = "Ramos.Real@gmail.com"


    End Sub

End Module