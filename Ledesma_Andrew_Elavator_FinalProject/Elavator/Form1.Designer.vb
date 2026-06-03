<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        pnlShaft = New Panel()
        pnlElevator = New Panel()
        pnlDoorRight = New Panel()
        pnlDoorLeft = New Panel()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btnOpen = New Button()
        btnClose = New Button()
        btnEmergency = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Panel6 = New Panel()
        Label1 = New Label()
        lblFloor = New Label()
        lblEmergency = New Label()
        lblDirection = New Label()
        lblQueue = New Label()
        lblDoor = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        btnUp1 = New Button()
        btnUp2 = New Button()
        btnUp3 = New Button()
        btnDown2 = New Button()
        btnDown3 = New Button()
        btnDown4 = New Button()
        TimerMove = New Timer(components)
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        pnlShaft.SuspendLayout()
        pnlElevator.SuspendLayout()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlShaft
        ' 
        pnlShaft.BackColor = Color.Black
        pnlShaft.Controls.Add(pnlElevator)
        pnlShaft.Location = New Point(240, 1)
        pnlShaft.Name = "pnlShaft"
        pnlShaft.Size = New Size(220, 620)
        pnlShaft.TabIndex = 0
        ' 
        ' pnlElevator
        ' 
        pnlElevator.BackColor = Color.Gray
        pnlElevator.Controls.Add(pnlDoorRight)
        pnlElevator.Controls.Add(pnlDoorLeft)
        pnlElevator.Location = New Point(50, 426)
        pnlElevator.Name = "pnlElevator"
        pnlElevator.Size = New Size(120, 120)
        pnlElevator.TabIndex = 0
        ' 
        ' pnlDoorRight
        ' 
        pnlDoorRight.BackColor = Color.Silver
        pnlDoorRight.Location = New Point(60, 0)
        pnlDoorRight.Name = "pnlDoorRight"
        pnlDoorRight.Size = New Size(60, 120)
        pnlDoorRight.TabIndex = 2
        ' 
        ' pnlDoorLeft
        ' 
        pnlDoorLeft.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlDoorLeft.BackColor = Color.DarkGray
        pnlDoorLeft.Location = New Point(0, 0)
        pnlDoorLeft.Name = "pnlDoorLeft"
        pnlDoorLeft.Size = New Size(62, 120)
        pnlDoorLeft.TabIndex = 1
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(21, 276)
        btn1.Name = "btn1"
        btn1.Size = New Size(87, 49)
        btn1.TabIndex = 1
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(114, 276)
        btn2.Name = "btn2"
        btn2.Size = New Size(87, 49)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(21, 331)
        btn3.Name = "btn3"
        btn3.Size = New Size(87, 49)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(114, 331)
        btn4.Name = "btn4"
        btn4.Size = New Size(87, 49)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btnOpen
        ' 
        btnOpen.BackColor = Color.LimeGreen
        btnOpen.Location = New Point(30, 442)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(82, 49)
        btnOpen.TabIndex = 5
        btnOpen.Text = "OPEN"
        btnOpen.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.DarkRed
        btnClose.Location = New Point(118, 442)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(83, 49)
        btnClose.TabIndex = 6
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnEmergency
        ' 
        btnEmergency.BackColor = Color.Red
        btnEmergency.ForeColor = Color.White
        btnEmergency.Location = New Point(13, 497)
        btnEmergency.Name = "btnEmergency"
        btnEmergency.Size = New Size(204, 49)
        btnEmergency.TabIndex = 7
        btnEmergency.Text = "EMERGENCY STOP"
        btnEmergency.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(btn1)
        Panel1.Controls.Add(btnEmergency)
        Panel1.Controls.Add(btn2)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btn3)
        Panel1.Controls.Add(btnOpen)
        Panel1.Controls.Add(btn4)
        Panel1.Location = New Point(658, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(220, 589)
        Panel1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(47, 410)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 15
        Label3.Text = "DOOR CONTROLS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(47, 236)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 20)
        Label2.TabIndex = 14
        Label2.Text = "FLOOR SELECTION"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Black
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(lblFloor)
        Panel6.Controls.Add(lblEmergency)
        Panel6.Controls.Add(lblDirection)
        Panel6.Controls.Add(lblQueue)
        Panel6.Controls.Add(lblDoor)
        Panel6.Location = New Point(13, 11)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 189)
        Panel6.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(34, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 20)
        Label1.TabIndex = 13
        Label1.Text = "ELAVATOR STATUS"
        ' 
        ' lblFloor
        ' 
        lblFloor.AutoSize = True
        lblFloor.Font = New Font("Segoe UI", 12.0F)
        lblFloor.ForeColor = Color.Lime
        lblFloor.Location = New Point(43, 43)
        lblFloor.Name = "lblFloor"
        lblFloor.Size = New Size(56, 21)
        lblFloor.TabIndex = 8
        lblFloor.Text = "Label1"
        lblFloor.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblEmergency
        ' 
        lblEmergency.AutoSize = True
        lblEmergency.BackColor = Color.Transparent
        lblEmergency.Font = New Font("Segoe UI", 10.0F)
        lblEmergency.ForeColor = Color.Red
        lblEmergency.Location = New Point(46, 170)
        lblEmergency.Name = "lblEmergency"
        lblEmergency.Size = New Size(49, 19)
        lblEmergency.TabIndex = 12
        lblEmergency.Text = "Label1"
        ' 
        ' lblDirection
        ' 
        lblDirection.AutoSize = True
        lblDirection.Font = New Font("Segoe UI", 10.0F)
        lblDirection.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblDirection.Location = New Point(46, 75)
        lblDirection.Name = "lblDirection"
        lblDirection.Size = New Size(49, 19)
        lblDirection.TabIndex = 9
        lblDirection.Text = "Label1"
        ' 
        ' lblQueue
        ' 
        lblQueue.AutoSize = True
        lblQueue.Font = New Font("Segoe UI", 10.0F)
        lblQueue.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        lblQueue.Location = New Point(46, 137)
        lblQueue.Name = "lblQueue"
        lblQueue.Size = New Size(49, 19)
        lblQueue.TabIndex = 11
        lblQueue.Text = "Label1"
        ' 
        ' lblDoor
        ' 
        lblDoor.AutoSize = True
        lblDoor.Font = New Font("Segoe UI", 10.0F)
        lblDoor.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblDoor.Location = New Point(46, 103)
        lblDoor.Name = "lblDoor"
        lblDoor.Size = New Size(49, 19)
        lblDoor.TabIndex = 10
        lblDoor.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DimGray
        Panel2.Location = New Point(2, 542)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(658, 20)
        Panel2.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DimGray
        Panel3.Location = New Point(2, 390)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(658, 20)
        Panel3.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DimGray
        Panel4.Location = New Point(2, 253)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(658, 20)
        Panel4.TabIndex = 11
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DimGray
        Panel5.Location = New Point(2, 124)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(658, 20)
        Panel5.TabIndex = 12
        ' 
        ' btnUp1
        ' 
        btnUp1.Location = New Point(478, 428)
        btnUp1.Name = "btnUp1"
        btnUp1.Size = New Size(38, 36)
        btnUp1.TabIndex = 13
        btnUp1.Text = "▲ "
        btnUp1.UseVisualStyleBackColor = True
        ' 
        ' btnUp2
        ' 
        btnUp2.Location = New Point(478, 290)
        btnUp2.Name = "btnUp2"
        btnUp2.Size = New Size(38, 36)
        btnUp2.TabIndex = 14
        btnUp2.Text = "▲ "
        btnUp2.UseVisualStyleBackColor = True
        ' 
        ' btnUp3
        ' 
        btnUp3.Location = New Point(478, 165)
        btnUp3.Name = "btnUp3"
        btnUp3.Size = New Size(38, 36)
        btnUp3.TabIndex = 15
        btnUp3.Text = "▲ "
        btnUp3.UseVisualStyleBackColor = True
        ' 
        ' btnDown2
        ' 
        btnDown2.Location = New Point(478, 332)
        btnDown2.Name = "btnDown2"
        btnDown2.Size = New Size(38, 36)
        btnDown2.TabIndex = 16
        btnDown2.Text = "▼"
        btnDown2.UseVisualStyleBackColor = True
        ' 
        ' btnDown3
        ' 
        btnDown3.Location = New Point(478, 207)
        btnDown3.Name = "btnDown3"
        btnDown3.Size = New Size(38, 36)
        btnDown3.TabIndex = 17
        btnDown3.Text = "▼"
        btnDown3.UseVisualStyleBackColor = True
        ' 
        ' btnDown4
        ' 
        btnDown4.Location = New Point(478, 55)
        btnDown4.Name = "btnDown4"
        btnDown4.Size = New Size(38, 36)
        btnDown4.TabIndex = 18
        btnDown4.Text = "▼"
        btnDown4.UseVisualStyleBackColor = True
        ' 
        ' TimerMove
        ' 
        TimerMove.Interval = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(46, 428)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 28)
        Label4.TabIndex = 19
        Label4.Text = "1ST FLOOR"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(46, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 28)
        Label5.TabIndex = 20
        Label5.Text = "2ND FLOOR"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(46, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 28)
        Label6.TabIndex = 21
        Label6.Text = "3RD FLOOR"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(46, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 28)
        Label7.TabIndex = 22
        Label7.Text = "4TH FLOOR"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 559)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnDown4)
        Controls.Add(btnDown3)
        Controls.Add(btnDown2)
        Controls.Add(btnUp3)
        Controls.Add(btnUp2)
        Controls.Add(btnUp1)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(pnlShaft)
        Name = "Form1"
        Text = "Form1"
        pnlShaft.ResumeLayout(False)
        pnlElevator.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlShaft As Panel
    Friend WithEvents pnlElevator As Panel
    Friend WithEvents pnlDoorLeft As Panel
    Friend WithEvents pnlDoorRight As Panel
    Friend WithEvents btn1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEmergency As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFloor As Label
    Friend WithEvents lblEmergency As Label
    Friend WithEvents lblQueue As Label
    Friend WithEvents lblDoor As Label
    Friend WithEvents lblDirection As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnUp1 As Button
    Friend WithEvents btnUp2 As Button
    Friend WithEvents btnUp3 As Button
    Friend WithEvents btnDown2 As Button
    Friend WithEvents btnDown3 As Button
    Friend WithEvents btnDown4 As Button
    Friend WithEvents TimerMove As Timer
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

End Class
