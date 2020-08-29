Public Class frmDataBase

    Private Sub DiceTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DiceTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DiceTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiceDataBase1DataSet)

    End Sub

    Private Sub frmDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiceDataBase1DataSet.DiceTable' table. You can move, or remove it, as needed.
        Me.DiceTableTableAdapter.Fill(Me.DiceDataBase1DataSet.DiceTable)

    End Sub

    Private Sub tsbtnLoadStats_Click(sender As Object, e As EventArgs) Handles tsbtnLoadStats.Click
        If Not IsDBNull(_DiceTableDataGridView.CurrentRow.Cells(1).Value) Then
            frmMain.txtPlayerName.Text = DiceTableDataGridView.CurrentRow.Cells(1).Value
        End If
        If Not IsDBNull(_DiceTableDataGridView.CurrentRow.Cells(2).Value) Then
            frmMain.txtCharacterName.Text = DiceTableDataGridView.CurrentRow.Cells(2).Value
        End If

        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(3).Value) Then
            frmMain.txtD20.Text = _DiceTableDataGridView.CurrentRow.Cells(3).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(4).Value) Then
            frmMain.txtD20Mod.Text = DiceTableDataGridView.CurrentRow.Cells(4).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(5).Value) Then
            frmMain.txtD20Crit.Text = DiceTableDataGridView.CurrentRow.Cells(5).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(6).Value) Then
            frmMain.txtD20CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(6).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(7).Value) Then
            frmMain.txtD12.Text = DiceTableDataGridView.CurrentRow.Cells(7).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(8).Value) Then
            frmMain.txtD12Mod.Text = DiceTableDataGridView.CurrentRow.Cells(8).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(9).Value) Then
            frmMain.txtD12Crit.Text = DiceTableDataGridView.CurrentRow.Cells(9).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(10).Value) Then
            frmMain.txtD12CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(10).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(11).Value) Then
            frmMain.txtD10.Text = DiceTableDataGridView.CurrentRow.Cells(11).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(12).Value) Then
            frmMain.txtD10Mod.Text = DiceTableDataGridView.CurrentRow.Cells(12).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(13).Value) Then
            frmMain.txtD10Crit.Text = DiceTableDataGridView.CurrentRow.Cells(13).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(14).Value) Then
            frmMain.txtD10CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(14).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(15).Value) Then
            frmMain.txtD8.Text = _DiceTableDataGridView.CurrentRow.Cells(15).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(16).Value) Then
            frmMain.txtD8Mod.Text = DiceTableDataGridView.CurrentRow.Cells(16).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(17).Value) Then
            frmMain.txtD8Crit.Text = DiceTableDataGridView.CurrentRow.Cells(17).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(18).Value) Then
            frmMain.txtD8CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(18).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(19).Value) Then
            frmMain.txtD6.Text = DiceTableDataGridView.CurrentRow.Cells(19).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(20).Value) Then
            frmMain.txtD6Mod.Text = DiceTableDataGridView.CurrentRow.Cells(20).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(21).Value) Then
            frmMain.txtD6Crit.Text = DiceTableDataGridView.CurrentRow.Cells(21).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(22).Value) Then
            frmMain.txtD6CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(22).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(23).Value) Then
            frmMain.txtD4.Text = DiceTableDataGridView.CurrentRow.Cells(23).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(24).Value) Then
            frmMain.txtD4Mod.Text = DiceTableDataGridView.CurrentRow.Cells(24).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(25).Value) Then
            frmMain.txtD4Crit.Text = DiceTableDataGridView.CurrentRow.Cells(25).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(26).Value) Then
            frmMain.txtD4CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(26).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(27).Value) Then
            frmMain.txtD3.Text = DiceTableDataGridView.CurrentRow.Cells(27).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(28).Value) Then
            frmMain.txtD3Mod.Text = DiceTableDataGridView.CurrentRow.Cells(28).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(29).Value) Then
            frmMain.txtD3Crit.Text = DiceTableDataGridView.CurrentRow.Cells(29).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(30).Value) Then
            frmMain.txtD3CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(30).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(31).Value) Then
            frmMain.txtD2.Text = DiceTableDataGridView.CurrentRow.Cells(31).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(32).Value) Then
            frmMain.txtD2Mod.Text = DiceTableDataGridView.CurrentRow.Cells(32).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(33).Value) Then
            frmMain.txtD2Crit.Text = DiceTableDataGridView.CurrentRow.Cells(33).Value
        End If
        If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(34).Value) Then
            frmMain.txtD2CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(34).Value
        End If
        ' If IsNumeric(_DiceTableDataGridView.CurrentRow.Cells(35).Value) Then
        'frmMain.txtD2CritFail.Text = DiceTableDataGridView.CurrentRow.Cells(35).Value
        ' End If

        frmMain.LoadAll()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        DiceDataBase1DataSet.DiceTable.AddDiceTableRow(String.Empty, String.Empty, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        DiceTableDataGridView.CurrentRow.Cells(0).Value = DiceDataBase1DataSet.DiceTable.Count()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class