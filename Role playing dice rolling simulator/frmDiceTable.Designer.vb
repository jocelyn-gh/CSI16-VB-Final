<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiceTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.listviewMain = New System.Windows.Forms.ListView()
        Me.imglstDiceTemp = New System.Windows.Forms.ImageList(Me.components)
        Me.lstMainList = New System.Windows.Forms.ListBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalD20 = New System.Windows.Forms.Label()
        Me.lblD20 = New System.Windows.Forms.Label()
        Me.lblTotalCritD20 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD12 = New System.Windows.Forms.Label()
        Me.lblTotalCritD12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalD12 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD10 = New System.Windows.Forms.Label()
        Me.lblTotalCritD10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotalD10 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD8 = New System.Windows.Forms.Label()
        Me.lblTotalCritD8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTotalD8 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD2 = New System.Windows.Forms.Label()
        Me.lblTotalCritD2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblTotalD2 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD3 = New System.Windows.Forms.Label()
        Me.lblTotalCritD3 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblTotalD3 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD4 = New System.Windows.Forms.Label()
        Me.lblTotalCritD4 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblTotalD4 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD6 = New System.Windows.Forms.Label()
        Me.lblTotalCritD6 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblTotalD6 = New System.Windows.Forms.Label()
        Me.lblTotalCritFailD = New System.Windows.Forms.Label()
        Me.lblTotalCritD = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblTotalD = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblCharacterName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listviewMain
        '
        Me.listviewMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.listviewMain.BackgroundImage = Global.Role_playing_dice_rolling_simulator.My.Resources.Resources.Aged_Stone_Tiles_2
        Me.listviewMain.BackgroundImageTiled = True
        Me.listviewMain.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listviewMain.LargeImageList = Me.imglstDiceTemp
        Me.listviewMain.Location = New System.Drawing.Point(35, 75)
        Me.listviewMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listviewMain.Name = "listviewMain"
        Me.listviewMain.Size = New System.Drawing.Size(599, 386)
        Me.listviewMain.TabIndex = 15
        Me.listviewMain.UseCompatibleStateImageBehavior = False
        '
        'imglstDiceTemp
        '
        Me.imglstDiceTemp.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imglstDiceTemp.ImageSize = New System.Drawing.Size(80, 80)
        Me.imglstDiceTemp.TransparentColor = System.Drawing.Color.Transparent
        '
        'lstMainList
        '
        Me.lstMainList.BackColor = System.Drawing.Color.Gainsboro
        Me.lstMainList.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lstMainList.ForeColor = System.Drawing.Color.DimGray
        Me.lstMainList.FormattingEnabled = True
        Me.lstMainList.ItemHeight = 23
        Me.lstMainList.Location = New System.Drawing.Point(749, 60)
        Me.lstMainList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstMainList.Name = "lstMainList"
        Me.lstMainList.Size = New System.Drawing.Size(139, 464)
        Me.lstMainList.TabIndex = 17
        '
        'btnRoll
        '
        Me.btnRoll.BackColor = System.Drawing.Color.Indigo
        Me.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoll.Font = New System.Drawing.Font("Cup and Talon", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnRoll.ForeColor = System.Drawing.Color.Gold
        Me.btnRoll.Location = New System.Drawing.Point(638, 75)
        Me.btnRoll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(106, 34)
        Me.btnRoll.TabIndex = 16
        Me.btnRoll.Text = "Re-Roll"
        Me.btnRoll.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Indigo
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.Location = New System.Drawing.Point(772, 532)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 34)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTotalD20
        '
        Me.lblTotalD20.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD20.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD20.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD20.Location = New System.Drawing.Point(147, 493)
        Me.lblTotalD20.Name = "lblTotalD20"
        Me.lblTotalD20.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD20.TabIndex = 19
        '
        'lblD20
        '
        Me.lblD20.AutoSize = True
        Me.lblD20.BackColor = System.Drawing.Color.Indigo
        Me.lblD20.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblD20.ForeColor = System.Drawing.Color.Gold
        Me.lblD20.Location = New System.Drawing.Point(152, 461)
        Me.lblD20.Name = "lblD20"
        Me.lblD20.Size = New System.Drawing.Size(58, 33)
        Me.lblD20.TabIndex = 20
        Me.lblD20.Text = "D20"
        '
        'lblTotalCritD20
        '
        Me.lblTotalCritD20.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD20.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD20.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD20.Location = New System.Drawing.Point(147, 523)
        Me.lblTotalCritD20.Name = "lblTotalCritD20"
        Me.lblTotalCritD20.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD20.TabIndex = 21
        '
        'lblTotalCritFailD20
        '
        Me.lblTotalCritFailD20.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD20.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD20.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD20.Location = New System.Drawing.Point(147, 554)
        Me.lblTotalCritFailD20.Name = "lblTotalCritFailD20"
        Me.lblTotalCritFailD20.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD20.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Indigo
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(80, 489)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 33)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Indigo
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(35, 521)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 33)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Total Crit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Indigo
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(3, 552)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total CritFail"
        '
        'lblTotalCritFailD12
        '
        Me.lblTotalCritFailD12.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD12.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD12.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD12.Location = New System.Drawing.Point(222, 555)
        Me.lblTotalCritFailD12.Name = "lblTotalCritFailD12"
        Me.lblTotalCritFailD12.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD12.TabIndex = 29
        '
        'lblTotalCritD12
        '
        Me.lblTotalCritD12.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD12.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD12.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD12.Location = New System.Drawing.Point(222, 525)
        Me.lblTotalCritD12.Name = "lblTotalCritD12"
        Me.lblTotalCritD12.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD12.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Indigo
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(229, 462)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 33)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "D12"
        '
        'lblTotalD12
        '
        Me.lblTotalD12.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD12.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD12.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD12.Location = New System.Drawing.Point(222, 494)
        Me.lblTotalD12.Name = "lblTotalD12"
        Me.lblTotalD12.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD12.TabIndex = 26
        '
        'lblTotalCritFailD10
        '
        Me.lblTotalCritFailD10.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD10.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD10.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD10.Location = New System.Drawing.Point(297, 555)
        Me.lblTotalCritFailD10.Name = "lblTotalCritFailD10"
        Me.lblTotalCritFailD10.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD10.TabIndex = 33
        '
        'lblTotalCritD10
        '
        Me.lblTotalCritD10.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD10.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD10.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD10.Location = New System.Drawing.Point(297, 525)
        Me.lblTotalCritD10.Name = "lblTotalCritD10"
        Me.lblTotalCritD10.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD10.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Indigo
        Me.Label13.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(304, 462)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 33)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "D10"
        '
        'lblTotalD10
        '
        Me.lblTotalD10.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD10.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD10.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD10.Location = New System.Drawing.Point(297, 494)
        Me.lblTotalD10.Name = "lblTotalD10"
        Me.lblTotalD10.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD10.TabIndex = 30
        '
        'lblTotalCritFailD8
        '
        Me.lblTotalCritFailD8.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD8.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD8.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD8.Location = New System.Drawing.Point(371, 555)
        Me.lblTotalCritFailD8.Name = "lblTotalCritFailD8"
        Me.lblTotalCritFailD8.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD8.TabIndex = 37
        '
        'lblTotalCritD8
        '
        Me.lblTotalCritD8.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD8.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD8.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD8.Location = New System.Drawing.Point(371, 525)
        Me.lblTotalCritD8.Name = "lblTotalCritD8"
        Me.lblTotalCritD8.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD8.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Indigo
        Me.Label17.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(383, 462)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 33)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "D8"
        '
        'lblTotalD8
        '
        Me.lblTotalD8.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD8.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD8.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD8.Location = New System.Drawing.Point(371, 494)
        Me.lblTotalD8.Name = "lblTotalD8"
        Me.lblTotalD8.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD8.TabIndex = 34
        '
        'lblTotalCritFailD2
        '
        Me.lblTotalCritFailD2.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD2.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD2.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD2.Location = New System.Drawing.Point(670, 557)
        Me.lblTotalCritFailD2.Name = "lblTotalCritFailD2"
        Me.lblTotalCritFailD2.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD2.TabIndex = 53
        '
        'lblTotalCritD2
        '
        Me.lblTotalCritD2.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD2.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD2.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD2.Location = New System.Drawing.Point(670, 526)
        Me.lblTotalCritD2.Name = "lblTotalCritD2"
        Me.lblTotalCritD2.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD2.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Indigo
        Me.Label21.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Gold
        Me.Label21.Location = New System.Drawing.Point(681, 463)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 33)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "D2"
        '
        'lblTotalD2
        '
        Me.lblTotalD2.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD2.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD2.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD2.Location = New System.Drawing.Point(670, 495)
        Me.lblTotalD2.Name = "lblTotalD2"
        Me.lblTotalD2.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD2.TabIndex = 50
        '
        'lblTotalCritFailD3
        '
        Me.lblTotalCritFailD3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD3.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD3.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD3.Location = New System.Drawing.Point(595, 557)
        Me.lblTotalCritFailD3.Name = "lblTotalCritFailD3"
        Me.lblTotalCritFailD3.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD3.TabIndex = 49
        '
        'lblTotalCritD3
        '
        Me.lblTotalCritD3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD3.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD3.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD3.Location = New System.Drawing.Point(595, 526)
        Me.lblTotalCritD3.Name = "lblTotalCritD3"
        Me.lblTotalCritD3.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD3.TabIndex = 48
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Indigo
        Me.Label25.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Gold
        Me.Label25.Location = New System.Drawing.Point(607, 463)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 33)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "D3"
        '
        'lblTotalD3
        '
        Me.lblTotalD3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD3.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD3.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD3.Location = New System.Drawing.Point(595, 495)
        Me.lblTotalD3.Name = "lblTotalD3"
        Me.lblTotalD3.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD3.TabIndex = 46
        '
        'lblTotalCritFailD4
        '
        Me.lblTotalCritFailD4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD4.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD4.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD4.Location = New System.Drawing.Point(521, 557)
        Me.lblTotalCritFailD4.Name = "lblTotalCritFailD4"
        Me.lblTotalCritFailD4.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD4.TabIndex = 45
        '
        'lblTotalCritD4
        '
        Me.lblTotalCritD4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD4.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD4.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD4.Location = New System.Drawing.Point(521, 526)
        Me.lblTotalCritD4.Name = "lblTotalCritD4"
        Me.lblTotalCritD4.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD4.TabIndex = 44
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Indigo
        Me.Label29.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.Gold
        Me.Label29.Location = New System.Drawing.Point(532, 463)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 33)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "D4"
        '
        'lblTotalD4
        '
        Me.lblTotalD4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD4.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD4.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD4.Location = New System.Drawing.Point(521, 495)
        Me.lblTotalD4.Name = "lblTotalD4"
        Me.lblTotalD4.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD4.TabIndex = 42
        '
        'lblTotalCritFailD6
        '
        Me.lblTotalCritFailD6.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritFailD6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD6.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD6.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD6.Location = New System.Drawing.Point(446, 555)
        Me.lblTotalCritFailD6.Name = "lblTotalCritFailD6"
        Me.lblTotalCritFailD6.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritFailD6.TabIndex = 41
        '
        'lblTotalCritD6
        '
        Me.lblTotalCritD6.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalCritD6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD6.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD6.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD6.Location = New System.Drawing.Point(446, 525)
        Me.lblTotalCritD6.Name = "lblTotalCritD6"
        Me.lblTotalCritD6.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalCritD6.TabIndex = 40
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Indigo
        Me.Label33.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.Gold
        Me.Label33.Location = New System.Drawing.Point(457, 462)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 33)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "D6"
        '
        'lblTotalD6
        '
        Me.lblTotalD6.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotalD6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD6.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD6.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD6.Location = New System.Drawing.Point(446, 494)
        Me.lblTotalD6.Name = "lblTotalD6"
        Me.lblTotalD6.Size = New System.Drawing.Size(67, 28)
        Me.lblTotalD6.TabIndex = 38
        '
        'lblTotalCritFailD
        '
        Me.lblTotalCritFailD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritFailD.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritFailD.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritFailD.Location = New System.Drawing.Point(648, 411)
        Me.lblTotalCritFailD.Name = "lblTotalCritFailD"
        Me.lblTotalCritFailD.Size = New System.Drawing.Size(75, 33)
        Me.lblTotalCritFailD.TabIndex = 57
        '
        'lblTotalCritD
        '
        Me.lblTotalCritD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCritD.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCritD.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalCritD.Location = New System.Drawing.Point(648, 375)
        Me.lblTotalCritD.Name = "lblTotalCritD"
        Me.lblTotalCritD.Size = New System.Drawing.Size(75, 33)
        Me.lblTotalCritD.TabIndex = 56
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Indigo
        Me.Label37.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.Gold
        Me.Label37.Location = New System.Drawing.Point(653, 304)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 33)
        Me.Label37.TabIndex = 55
        Me.Label37.Text = "Total"
        '
        'lblTotalD
        '
        Me.lblTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalD.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalD.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalD.Location = New System.Drawing.Point(648, 339)
        Me.lblTotalD.Name = "lblTotalD"
        Me.lblTotalD.Size = New System.Drawing.Size(75, 33)
        Me.lblTotalD.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Indigo
        Me.Label26.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.Gold
        Me.Label26.Location = New System.Drawing.Point(395, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(188, 33)
        Me.Label26.TabIndex = 96
        Me.Label26.Text = "Character Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Indigo
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(31, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 33)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Player Name :"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerName.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayerName.ForeColor = System.Drawing.Color.DimGray
        Me.lblPlayerName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblPlayerName.Location = New System.Drawing.Point(181, 21)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(212, 32)
        Me.lblPlayerName.TabIndex = 97
        '
        'lblCharacterName
        '
        Me.lblCharacterName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCharacterName.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCharacterName.ForeColor = System.Drawing.Color.DimGray
        Me.lblCharacterName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblCharacterName.Location = New System.Drawing.Point(580, 21)
        Me.lblCharacterName.Name = "lblCharacterName"
        Me.lblCharacterName.Size = New System.Drawing.Size(283, 32)
        Me.lblCharacterName.TabIndex = 98
        '
        'frmDiceTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.Role_playing_dice_rolling_simulator.My.Resources.Resources.Mji0eJV
        Me.ClientSize = New System.Drawing.Size(899, 592)
        Me.Controls.Add(Me.lblCharacterName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalCritFailD)
        Me.Controls.Add(Me.lblTotalCritD)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.lblTotalD)
        Me.Controls.Add(Me.lblTotalCritFailD2)
        Me.Controls.Add(Me.lblTotalCritD2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblTotalD2)
        Me.Controls.Add(Me.lblTotalCritFailD3)
        Me.Controls.Add(Me.lblTotalCritD3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblTotalD3)
        Me.Controls.Add(Me.lblTotalCritFailD4)
        Me.Controls.Add(Me.lblTotalCritD4)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lblTotalD4)
        Me.Controls.Add(Me.lblTotalCritFailD6)
        Me.Controls.Add(Me.lblTotalCritD6)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblTotalD6)
        Me.Controls.Add(Me.lblTotalCritFailD8)
        Me.Controls.Add(Me.lblTotalCritD8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblTotalD8)
        Me.Controls.Add(Me.lblTotalCritFailD10)
        Me.Controls.Add(Me.lblTotalCritD10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTotalD10)
        Me.Controls.Add(Me.lblTotalCritFailD12)
        Me.Controls.Add(Me.lblTotalCritD12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotalD12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalCritFailD20)
        Me.Controls.Add(Me.lblTotalCritD20)
        Me.Controls.Add(Me.lblD20)
        Me.Controls.Add(Me.lblTotalD20)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.listviewMain)
        Me.Controls.Add(Me.lstMainList)
        Me.Controls.Add(Me.btnRoll)
        Me.Font = New System.Drawing.Font("Nueva Std Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDiceTable"
        Me.Text = "DiceTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listviewMain As ListView
    Friend WithEvents lstMainList As ListBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents imglstDiceTemp As ImageList
    Friend WithEvents lblTotalD20 As Label
    Friend WithEvents lblD20 As Label
    Friend WithEvents lblTotalCritD20 As Label
    Friend WithEvents lblTotalCritFailD20 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalCritFailD12 As Label
    Friend WithEvents lblTotalCritD12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalD12 As Label
    Friend WithEvents lblTotalCritFailD10 As Label
    Friend WithEvents lblTotalCritD10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTotalD10 As Label
    Friend WithEvents lblTotalCritFailD8 As Label
    Friend WithEvents lblTotalCritD8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTotalD8 As Label
    Friend WithEvents lblTotalCritFailD2 As Label
    Friend WithEvents lblTotalCritD2 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblTotalD2 As Label
    Friend WithEvents lblTotalCritFailD3 As Label
    Friend WithEvents lblTotalCritD3 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblTotalD3 As Label
    Friend WithEvents lblTotalCritFailD4 As Label
    Friend WithEvents lblTotalCritD4 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblTotalD4 As Label
    Friend WithEvents lblTotalCritFailD6 As Label
    Friend WithEvents lblTotalCritD6 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblTotalD6 As Label
    Friend WithEvents lblTotalCritFailD As Label
    Friend WithEvents lblTotalCritD As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents lblTotalD As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents lblCharacterName As Label
End Class
