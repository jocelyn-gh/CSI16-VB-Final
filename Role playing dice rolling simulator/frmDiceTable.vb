Public Class frmDiceTable
    Dim diceArrayTempTable As New List(Of Dice)

    Public Sub New(ByVal diceArrayTemp As List(Of Dice), ByRef strPlayerName As String, ByRef strCharacterName As String)



        For i As Integer = 0 To diceArrayTemp.Count - 1
            diceArrayTempTable.Add(diceArrayTemp(i))
        Next

        InitializeComponent()
        lblPlayerName.Text = strPlayerName
        lblCharacterName.Text = strCharacterName
        ' This call is required by the designer.
        RollDice()
        'Show()
    End Sub

    Private Sub RollDice()

        Dim intDiceMatrix(8, 2) As Integer


        listviewMain.Clear()
        imglstDiceTemp.Images.Clear()
        lstMainList.Items.Clear()


        For i As Integer = 0 To diceArrayTempTable.Count - 1

            diceArrayTempTable(i).RollDice()
            System.Threading.Thread.Sleep(16)
            imglstDiceTemp.Images.Add(My.Resources.ResourceManager.GetObject(diceArrayTempTable(i).GetImageName))

            '//////////////////Dices acomlator//////////////////



            Select Case diceArrayTempTable(i).GetDiceType()
                Case 20

                    intDiceMatrix(0, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(0, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(0, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 12
                    intDiceMatrix(1, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(1, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(1, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 10
                    intDiceMatrix(2, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(2, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(2, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 8
                    intDiceMatrix(3, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(3, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(3, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 6
                    intDiceMatrix(4, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(4, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(4, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 4
                    intDiceMatrix(5, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(5, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(5, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 3
                    intDiceMatrix(6, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(6, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(6, 2) += diceArrayTempTable(i).IsGetCirtFail()
                Case 2
                    intDiceMatrix(7, 0) += diceArrayTempTable(i).GetTotalRoll
                    intDiceMatrix(7, 1) += diceArrayTempTable(i).IsGetCirt()
                    intDiceMatrix(7, 2) += diceArrayTempTable(i).IsGetCirtFail()
            End Select

            '////////////////////////////////////Out put////////////////////////////////////



            listviewMain.Items.Add("{" & i.ToString & "} " & diceArrayTempTable(i).GetRolled.ToString & " + (" & diceArrayTempTable(i).GetMod.ToString & ") = " & diceArrayTempTable(i).GetTotalRoll.ToString, i)
            lstMainList.Items.Add("{" & i.ToString & "} " & diceArrayTempTable(i).GetRolled.ToString & " + (" & diceArrayTempTable(i).GetMod.ToString & ") = " & diceArrayTempTable(i).GetTotalRoll.ToString)
        Next

        '//////////////////dices totals//////////////////
        lblTotalD20.Text = intDiceMatrix(0, 0)
        lblTotalCritD20.Text = intDiceMatrix(0, 1)
        lblTotalCritFailD20.Text = intDiceMatrix(0, 2)

        lblTotalD12.Text = intDiceMatrix(1, 0)
        lblTotalCritD12.Text = intDiceMatrix(1, 1)
        lblTotalCritFailD12.Text = intDiceMatrix(1, 2)

        lblTotalD10.Text = intDiceMatrix(2, 0)
        lblTotalCritD10.Text = intDiceMatrix(2, 1)
        lblTotalCritFailD10.Text = intDiceMatrix(2, 2)

        lblTotalD8.Text = intDiceMatrix(3, 0)
        lblTotalCritD8.Text = intDiceMatrix(3, 1)
        lblTotalCritFailD8.Text = intDiceMatrix(3, 2)

        lblTotalD6.Text = intDiceMatrix(4, 0)
        lblTotalCritD6.Text = intDiceMatrix(4, 1)
        lblTotalCritFailD6.Text = intDiceMatrix(4, 2)

        lblTotalD4.Text = intDiceMatrix(5, 0)
        lblTotalCritD4.Text = intDiceMatrix(5, 1)
        lblTotalCritFailD4.Text = intDiceMatrix(5, 2)

        lblTotalD3.Text = intDiceMatrix(6, 0)
        lblTotalCritD3.Text = intDiceMatrix(6, 1)
        lblTotalCritFailD3.Text = intDiceMatrix(6, 2)

        lblTotalD2.Text = intDiceMatrix(7, 0)
        lblTotalCritD2.Text = intDiceMatrix(7, 1)
        lblTotalCritFailD2.Text = intDiceMatrix(7, 2)

        Dim j As Integer = 0
        For i As Integer = 0 To 7

            For j = 0 To 2
                intDiceMatrix(8, j) += intDiceMatrix(i, j)
            Next j
        Next i

        lblTotalD.Text = intDiceMatrix(8, 0)
        lblTotalCritD.Text = intDiceMatrix(8, 1)
        lblTotalCritFailD.Text = intDiceMatrix(8, 2)
        '//////////////////Total dices list//////////////////
    End Sub

    Friend Sub CopyDiceArrayFromFrom(ByVal diceArray As List(Of Dice))
        diceArrayTempTable = diceArray
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        RollDice()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class