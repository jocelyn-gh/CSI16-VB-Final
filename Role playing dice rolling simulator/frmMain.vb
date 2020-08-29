'Made by the Jocelyn Dye
Public Class frmMain
    Dim diceArrayTemp As New List(Of Dice)
    Const intMAXDICE As Integer = 200
    'Dim frmArrayDiceTable As New List(Of frmDiceTable)

    'Dim diceArrayTemp2 As New List(Of List(Of Dice))

    Public Sub New()
        'This call Is required by the designer.
        InitializeComponent()
    End Sub

    Friend Function GetDiceArray() As List(Of Dice)
        Return diceArrayTemp
    End Function

    Private Sub RefeshList()
        lstDiceArrayLoaded.Items.Clear()
        If (diceArrayTemp.Count > 0) Then

            For i As Integer = 0 To diceArrayTemp.Count - 1
                lstDiceArrayLoaded.Items.Add("{" & i.ToString & "} D" & diceArrayTemp(i).GetDiceType.ToString & " Mod::" & diceArrayTemp(i).GetMod.ToString & " C::" & diceArrayTemp(i).GetCirt.ToString & " CF::" & diceArrayTemp(i).GetCirtFail.ToString)
            Next
        End If
    End Sub

    Private Sub DiceDev_Click(sender As Object, e As EventArgs) Handles btnCharacterLoad.Click

        If (diceArrayTemp.Count > 0) Then
            Dim frmDiceTable As New frmDiceTable(diceArrayTemp, txtPlayerName.Text, txtCharacterName.Text)
            frmDiceTable.Show()
            diceArrayTemp.Clear()
            RefeshList()
        End If
    End Sub

    Private Sub LoadDice(strDn As String, strDnMod As String, strDnCrit As String, strDnCritFail As String, intDn As Integer)
        Dim intDiceAmout As Integer = 0
        Dim intDiceMod As Integer = 0
        Dim intDiceCrit As Integer = 0
        Dim intDiceCirtFail As Integer = 0

        Integer.TryParse(strDn, intDiceAmout)
        If (intDiceAmout + diceArrayTemp.Count > intMAXDICE) Then
            MessageBox.Show("Can't have more then " & intMAXDICE & " loaded at once.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (intDiceAmout > 0) Then
            Integer.TryParse(strDnMod, intDiceMod)
            Integer.TryParse(strDnCrit, intDiceCrit)
            Integer.TryParse(strDnCritFail, intDiceCirtFail)

            If (intDiceCrit > intDn Or intDiceCirtFail > intDn) Then
                MessageBox.Show("Crit values can't exceed then the dice number of " & intDn & ".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (intDiceCrit + intDiceCirtFail > intDn) Then
                MessageBox.Show("Crit value of [" & intDiceCrit & "] Can't over lap CritFail value [" & intDiceCirtFail & "].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For i As Integer = 0 To intDiceAmout - 1
                    Dim diceTemp As New Dice(intDn, intDiceMod, intDiceCrit, intDiceCirtFail)
                    lstDiceArrayLoaded.Items.Add("{" & i.ToString & "}D[" & intDn.ToString & "] :: Mod[" & intDiceMod.ToString & "] :: C[" & intDiceCrit.ToString & "] :: CF[" & intDiceCirtFail.ToString & "]")
                    diceArrayTemp.Add(diceTemp)
                Next
            End If
        End If

    End Sub

    Private Sub txtLetter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtD20.KeyPress, txtD20Mod.KeyPress, txtD20Crit.KeyPress, txtD20CritFail.KeyPress,
        txtD12.KeyPress, txtD12Mod.KeyPress, txtD12Crit.KeyPress, txtD12CritFail.KeyPress,
        txtD10.KeyPress, txtD10Mod.KeyPress, txtD10Crit.KeyPress, txtD10CritFail.KeyPress,
        txtD8.KeyPress, txtD8Mod.KeyPress, txtD8Crit.KeyPress, txtD8CritFail.KeyPress,
        txtD6.KeyPress, txtD6Mod.KeyPress, txtD6Crit.KeyPress, txtD6CritFail.KeyPress,
        txtD4.KeyPress, txtD4Mod.KeyPress, txtD4Crit.KeyPress, txtD4CritFail.KeyPress,
        txtD3.KeyPress, txtD3Mod.KeyPress, txtD3Crit.KeyPress, txtD3CritFail.KeyPress,
        txtD2.KeyPress, txtD2Mod.KeyPress, txtD2Crit.KeyPress, txtD2CritFail.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub








    Private Sub btnAddD20_Click(sender As Object, e As EventArgs) Handles btnAddD20.Click
        LoadDice(txtD20.Text, txtD20Mod.Text, txtD20Crit.Text, txtD20CritFail.Text, 20)
    End Sub

    Private Sub btnAddD12_Click(sender As Object, e As EventArgs) Handles btnAddD12.Click
        LoadDice(txtD12.Text, txtD12Mod.Text, txtD12Crit.Text, txtD12CritFail.Text, 12)
    End Sub

    Private Sub btnAddD10_Click(sender As Object, e As EventArgs) Handles btnAddD10.Click
        LoadDice(txtD10.Text, txtD10Mod.Text, txtD10Crit.Text, txtD10CritFail.Text, 10)
    End Sub

    Private Sub btnAddD8_Click(sender As Object, e As EventArgs) Handles btnAddD8.Click
        LoadDice(txtD8.Text, txtD8Mod.Text, txtD8Crit.Text, txtD8CritFail.Text, 8)
    End Sub

    Private Sub btnAddD6_Click(sender As Object, e As EventArgs) Handles btnAddD6.Click
        LoadDice(txtD6.Text, txtD6Mod.Text, txtD6Crit.Text, txtD6CritFail.Text, 6)
    End Sub

    Private Sub btnAddD4_Click(sender As Object, e As EventArgs) Handles btnAddD4.Click
        LoadDice(txtD4.Text, txtD4Mod.Text, txtD4Crit.Text, txtD4CritFail.Text, 4)
    End Sub

    Private Sub btnAddD3_Click(sender As Object, e As EventArgs) Handles btnAddD3.Click
        LoadDice(txtD3.Text, txtD3Mod.Text, txtD3Crit.Text, txtD3CritFail.Text, 3)
    End Sub

    Private Sub btnAddD2_Click(sender As Object, e As EventArgs) Handles btnAddD2.Click
        LoadDice(txtD2.Text, txtD2Mod.Text, txtD2Crit.Text, txtD2CritFail.Text, 2)
    End Sub








    Private Sub btnClearD20_Click(sender As Object, e As EventArgs) Handles btnClearD20.Click
        ClearD20()
    End Sub

    Private Sub btnClearD12_Click(sender As Object, e As EventArgs) Handles btnClearD12.Click
        ClearD12()
    End Sub

    Private Sub btnClearD10_Click(sender As Object, e As EventArgs) Handles btnClearD10.Click
        ClearD10()
    End Sub
    Private Sub btnClearD8_Click(sender As Object, e As EventArgs) Handles btnClearD8.Click
        ClearD8()
    End Sub
    Private Sub btnClearD6_Click(sender As Object, e As EventArgs) Handles btnClearD6.Click
        ClearD6()
    End Sub
    Private Sub btnClearD4_Click(sender As Object, e As EventArgs) Handles btnClearD4.Click
        ClearD4()
    End Sub
    Private Sub btnClearD3_Click(sender As Object, e As EventArgs) Handles btnClearD3.Click
        ClearD3()
    End Sub
    Private Sub btnClearD2_Click(sender As Object, e As EventArgs) Handles btnClearD2.Click
        ClearD2()
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////

    Private Sub ClearD20()
        txtD20.Text = String.Empty
        txtD20Mod.Text = String.Empty
        txtD20Crit.Text = String.Empty
        txtD20CritFail.Text = String.Empty
    End Sub
    Private Sub ClearD12()
        txtD12.Text = String.Empty
        txtD12Mod.Text = String.Empty
        txtD12Crit.Text = String.Empty
        txtD12CritFail.Text = String.Empty
    End Sub
    Private Sub ClearD10()
        txtD10.Text = String.Empty
        txtD10Mod.Text = String.Empty
        txtD10Crit.Text = String.Empty
        txtD10CritFail.Text = String.Empty
    End Sub
    Private Sub ClearD8()
        txtD8.Text = String.Empty
        txtD8Mod.Text = String.Empty
        txtD8Crit.Text = String.Empty
        txtD8CritFail.Text = String.Empty
    End Sub

    Private Sub ClearD6()
        txtD6.Text = String.Empty
        txtD6Mod.Text = String.Empty
        txtD6Crit.Text = String.Empty
        txtD6CritFail.Text = String.Empty
    End Sub
    Private Sub ClearD4()
        txtD4.Text = String.Empty
        txtD4Mod.Text = String.Empty
        txtD4Crit.Text = String.Empty
        txtD4CritFail.Text = String.Empty
    End Sub
    Private Sub ClearD3()
        txtD3.Text = String.Empty
        txtD3Mod.Text = String.Empty
        txtD3Crit.Text = String.Empty
        txtD3CritFail.Text = String.Empty
    End Sub
    Private Sub ClearD2()
        txtD2.Text = String.Empty
        txtD2Mod.Text = String.Empty
        txtD2Crit.Text = String.Empty
        txtD2CritFail.Text = String.Empty
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        ClearD20()
        ClearD12()
        ClearD10()
        ClearD8()
        ClearD6()
        ClearD4()
        ClearD3()
        ClearD2()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnClearArray_Click(sender As Object, e As EventArgs) Handles btnClearArray.Click
        diceArrayTemp.Clear()
        lstDiceArrayLoaded.Items.Clear()

    End Sub

    Private Sub ImportFieldsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFieldsToolStripMenuItem.Click
        Dim frmDataBase As New frmDataBase()
        frmDataBase.Show()


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiceDataBase1DataSet.DiceTable' table. You can move, or remove it, as needed.

        'txtPlayerName.Text = String.Empty
        'txtCharacterName.Text = String.Empty
        'ClearD20()
        'ClearD12()
        'ClearD10()
        'ClearD8()
        'ClearD6()
        'ClearD4()
        'ClearD3()
        'ClearD2()

    End Sub

    Friend Sub LoadAll()
        LoadDice(txtD20.Text, txtD20Mod.Text, txtD20Crit.Text, txtD20CritFail.Text, 20)
        LoadDice(txtD12.Text, txtD12Mod.Text, txtD12Crit.Text, txtD12CritFail.Text, 12)
        LoadDice(txtD10.Text, txtD10Mod.Text, txtD10Crit.Text, txtD10CritFail.Text, 10)
        LoadDice(txtD10.Text, txtD10Mod.Text, txtD10Crit.Text, txtD10CritFail.Text, 8)
        LoadDice(txtD6.Text, txtD6Mod.Text, txtD6Crit.Text, txtD6CritFail.Text, 6)
        LoadDice(txtD4.Text, txtD4Mod.Text, txtD4Crit.Text, txtD4CritFail.Text, 4)
        LoadDice(txtD3.Text, txtD3Mod.Text, txtD3Crit.Text, txtD3CritFail.Text, 3)
        LoadDice(txtD2.Text, txtD2Mod.Text, txtD2Crit.Text, txtD2CritFail.Text, 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoadAll.Click
        LoadAll()
    End Sub
End Class