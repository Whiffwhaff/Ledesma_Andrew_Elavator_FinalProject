Imports System.Threading
Imports System.Threading.Tasks

Public Class Form1

    ' ==========================================
    ' VARIABLES
    ' ==========================================
    Dim currentFloor As Integer = 1
    Dim targetFloor As Integer = 1

    Dim moving As Boolean = False
    Dim doorOpen As Boolean = True
    Dim emergencyStop As Boolean = False

    Dim direction As String = "IDLE"

    Dim requests As New List(Of Integer)

    Dim floorPositions As New Dictionary(Of Integer, Integer)

    ' ==========================================
    ' FORM LOAD
    ' ==========================================
    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' FLOOR POSITIONS
        floorPositions.Add(1, 420)
        floorPositions.Add(2, 270)
        floorPositions.Add(3, 140)
        floorPositions.Add(4, 10)

        ' Elevator start position
        pnlElevator.Top = floorPositions(1)

        ' Door positions
        pnlDoorLeft.Left = 0
        pnlDoorRight.Left = pnlElevator.Width \ 2

        TimerMove.Interval = 15

        AddHandler TimerMove.Tick, AddressOf TimerMove_Tick

        UpdateStatus()

    End Sub

    ' ==========================================
    ' UPDATE STATUS
    ' ==========================================
    Private Sub UpdateStatus()

        lblFloor.Text = "Current Floor: " &
            currentFloor.ToString()

        lblDirection.Text = "Direction: " &
            direction

        lblDoor.Text = "Door: " &
            If(doorOpen, "OPEN", "CLOSED")

        lblQueue.Text = "Queue: " &
            String.Join(",", requests)

        lblEmergency.Text = "Emergency: " &
            If(emergencyStop, "ON", "OFF")

    End Sub

    ' ==========================================
    ' ADD REQUEST
    ' ==========================================
    Private Sub AddRequest(floor As Integer)

        If floor = currentFloor Then
            Exit Sub
        End If

        If Not requests.Contains(floor) Then

            requests.Add(floor)

            ' SMART SORTING
            If direction = "UP" Then

                requests.Sort()

            ElseIf direction = "DOWN" Then

                requests.Sort()
                requests.Reverse()

            End If

        End If

        UpdateStatus()

        If Not moving Then
            ProcessRequests()
        End If

    End Sub

    ' ==========================================
    ' PROCESS REQUESTS
    ' ==========================================
    Private Async Sub ProcessRequests()

        If requests.Count = 0 Then

            moving = False
            direction = "IDLE"

            UpdateStatus()

            Exit Sub

        End If

        moving = True

        targetFloor = requests(0)

        If targetFloor > currentFloor Then
            direction = "UP"
        Else
            direction = "DOWN"
        End If

        Await CloseDoors()

        TimerMove.Start()

        UpdateStatus()

    End Sub

    ' ==========================================
    ' TIMER MOVE
    ' ==========================================
    Private Async Sub TimerMove_Tick(
        sender As Object,
        e As EventArgs
    )

        If emergencyStop Then

            direction = "STOPPED"

            UpdateStatus()

            Exit Sub

        End If

        Dim targetY As Integer =
            floorPositions(targetFloor)

        ' MOVE UP
        If pnlElevator.Top > targetY Then

            pnlElevator.Top -= 2

        End If

        ' MOVE DOWN
        If pnlElevator.Top < targetY Then

            pnlElevator.Top += 2

        End If

        ' ARRIVED
        If Math.Abs(
            pnlElevator.Top - targetY
        ) <= 2 Then

            pnlElevator.Top = targetY

            currentFloor = targetFloor

            TimerMove.Stop()

            If requests.Contains(currentFloor) Then
                requests.Remove(currentFloor)
            End If

            UpdateStatus()

            Await OpenDoors()

            Await Task.Delay(1200)

            If Me Is Nothing OrElse Me.IsDisposed OrElse Me.Disposing OrElse Not Me.IsHandleCreated Then
                Return
            End If

            Await CloseDoors()

            ProcessRequests()

        End If

    End Sub

    ' ==========================================
    ' OPEN DOORS
    ' ==========================================
    Private Async Function OpenDoors() As Task

        If doorOpen Then Return

        ' Target positions when doors are open (moved out of the elevator)
        Dim leftTarget As Integer = -pnlDoorLeft.Width
        Dim rightTarget As Integer = pnlElevator.Width

        Dim stepSize As Integer = 2

        While pnlDoorLeft.Left > leftTarget OrElse pnlDoorRight.Left < rightTarget

            If Me Is Nothing OrElse Me.IsDisposed OrElse Me.Disposing OrElse Not Me.IsHandleCreated Then
                Return
            End If

            ' Move left door leftwards but don't overshoot
            pnlDoorLeft.Left = Math.Max(pnlDoorLeft.Left - stepSize, leftTarget)
            ' Move right door rightwards but don't overshoot
            pnlDoorRight.Left = Math.Min(pnlDoorRight.Left + stepSize, rightTarget)

            Await Task.Delay(10)

        End While

        doorOpen = True

        UpdateStatus()

    End Function

    ' ==========================================
    ' CLOSE DOORS
    ' ==========================================
    Private Async Function CloseDoors() As Task

        If Not doorOpen Then Return

        ' Target positions when doors are closed (meet at center)
        Dim leftTarget As Integer = 0
        Dim rightTarget As Integer = pnlElevator.Width \ 2

        Dim stepSize As Integer = 2

        While pnlDoorLeft.Left < leftTarget OrElse pnlDoorRight.Left > rightTarget

            If Me Is Nothing OrElse Me.IsDisposed OrElse Me.Disposing OrElse Not Me.IsHandleCreated Then
                Return
            End If

            pnlDoorLeft.Left = Math.Min(pnlDoorLeft.Left + stepSize, leftTarget)
            pnlDoorRight.Left = Math.Max(pnlDoorRight.Left - stepSize, rightTarget)

            Await Task.Delay(10)

        End While

        doorOpen = False

        UpdateStatus()

    End Function

    ' ==========================================
    ' EMERGENCY STOP
    ' ==========================================
    Private Sub btnEmergency_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEmergency.Click

        emergencyStop = Not emergencyStop

        If emergencyStop Then

            direction = "STOPPED"

        Else

            If currentFloor < targetFloor Then
                direction = "UP"
            ElseIf currentFloor > targetFloor Then
                direction = "DOWN"
            Else
                direction = "IDLE"
            End If

        End If

        UpdateStatus()

    End Sub

    ' ==========================================
    ' FLOOR BUTTONS
    ' ==========================================
    Private Sub btn1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn1.Click

        AddRequest(1)

    End Sub

    Private Sub btn2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn2.Click

        AddRequest(2)

    End Sub

    Private Sub btn3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn3.Click

        AddRequest(3)

    End Sub

    Private Sub btn4_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn4.Click

        AddRequest(4)

    End Sub

    ' ==========================================
    ' FLOOR CALL BUTTONS
    ' ==========================================
    Private Sub btnUp1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUp1.Click

        AddRequest(1)

    End Sub

    Private Sub btnUp2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUp2.Click

        AddRequest(2)

    End Sub

    Private Sub btnUp3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUp3.Click

        AddRequest(3)

    End Sub

    Private Sub btnDown2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDown2.Click

        AddRequest(2)

    End Sub

    Private Sub btnDown3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDown3.Click

        AddRequest(3)

    End Sub

    Private Sub btnDown4_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDown4.Click

        AddRequest(4)

    End Sub

    ' ==========================================
    ' DOOR BUTTONS
    ' ==========================================
    Private Async Sub btnOpen_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnOpen.Click

        Await OpenDoors()

    End Sub

    Private Async Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClose.Click

        Await CloseDoors()

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub lblQueue_Click(sender As Object, e As EventArgs) Handles lblQueue.Click

    End Sub

    Private Sub lblFloor_Click(sender As Object, e As EventArgs) Handles lblFloor.Click

    End Sub
End Class
