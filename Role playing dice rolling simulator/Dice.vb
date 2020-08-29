

Public Class Dice


    Protected DMAX As Integer

    Protected intMod As Integer
    Protected intCrit As Integer
    Protected intCritFail As Integer

    Protected boolIsCrit As Boolean
    Protected boolIsCritFail As Boolean

    Protected strDiceName As String

    Protected intRolledNumber As Integer

    '////////////////////////////////////////////Constrctor////////////////////////////////////////////'

    Public Sub New()
        'constructor
        DMAX = 20
        intMod = 0
        intCrit = 1
        intCritFail = 1
        intRolledNumber = 1
        boolIsCrit = False
        boolIsCritFail = False
        strDiceName = String.Empty
        'imgDice = My.Resources.ResourceManager.GetObject("D20_1")
    End Sub

    Public Sub New(ByVal DMAX As Integer, ByVal intMod As Integer, ByVal intCrit As Integer, ByVal intCritFail As Integer)
        'constructor
        Me.DMAX = DMAX
        Me.intMod = intMod
        Me.intCrit = intCrit
        Me.intCritFail = intCritFail
        intRolledNumber = 1
        boolIsCrit = False
        boolIsCritFail = False
        strDiceName = String.Empty
        'imgDice = My.Resources.ResourceManager.GetObject("D20_1")

    End Sub




    '////////////////////////////////////////////Destructor////////////////////////////////////////////'

    Protected Overrides Sub Finalize()  ' destructor
        Console.WriteLine("Object is being deleted")
    End Sub
    '////////////////////////////////////////////Methods////////////////////////////////////////////'
    Public Sub Reset(ByVal intMod As Integer, ByVal intCrit As Integer, ByVal intCritFail As Integer)
        'constructor
        Me.intMod = intMod
        Me.intCrit = intCrit
        Me.intCritFail = intCritFail
        Me.intRolledNumber = 0
        Me.boolIsCrit = False
        Me.boolIsCritFail = False
        Me.strDiceName = String.Empty
        'imgDice = My.Resources.ResourceManager.GetObject("D20_1")

    End Sub

    Public Sub RollDice()
        Dim ranDice As New Random
        intRolledNumber = ranDice.Next(1, DMAX + 1)
        Crit()
        ImageName()
    End Sub

    Private Sub ImageName()
        'imgDice = My.Resources.ResourceManager.GetObject("cD20_" & intRolledNumber)
        If (boolIsCrit) Then
            strDiceName = ("cD" & DMAX & "_" & intRolledNumber.ToString) '"cD20_1"

        ElseIf (boolIsCritFail) Then
            strDiceName = ("cfD" & DMAX & "_" & intRolledNumber.ToString)

        Else
            strDiceName = ("D" & DMAX & "_" & intRolledNumber.ToString)
        End If
    End Sub

    Private Sub Crit()
        boolIsCrit = False
        boolIsCritFail = False

        Select Case intRolledNumber
            Case 0 To intCritFail
                boolIsCritFail = True
            Case (DMAX + 1) - intCrit To DMAX
                boolIsCrit = True
        End Select
    End Sub



    '////////////////////////////////////////////Fuctions////////////////////////////////////////////'
    '//////////////////Get Fuctions'//////////////////

    Public Function GetMod() As Integer
        Return intMod
    End Function

    Public Function GetRolled() As Integer
        Return intRolledNumber
    End Function

    Public Function GetTotalRoll() As Integer
        Return intRolledNumber + intMod
    End Function

    Public Function GetDiceType() As Integer
        Return DMAX
    End Function

    Public Function GetCirt() As Integer
        Return intCrit
    End Function

    Public Function IsGetCirt() As Integer
        Return Convert.ToInt32(boolIsCrit)
    End Function

    Public Function IsGetCirtFail() As Integer
        Return Convert.ToInt32(boolIsCritFail)
    End Function

    Public Function GetCirtFail() As Integer
        Return intCritFail
    End Function

    Public Function GetImageName() As String
        Return strDiceName
    End Function




End Class
