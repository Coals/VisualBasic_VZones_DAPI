

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VZonesDAPI.DapiStart("VBDapiExample")
    End Sub

    Private Sub Form1_FormClosed(eventSender As Object, eventArgs As FormClosedEventArgs) Handles Me.FormClosed
        VZonesDAPI.DapiStop()
    End Sub

    Private Sub btnClearText_Click(sender As Object, e As EventArgs) Handles btnClearText.Click
        VZText.Text = ""
    End Sub

    Private Sub btnGetText_Click(sender As Object, e As EventArgs) Handles btnGetText.Click
        Dim txt As String
        If VZonesDAPI.DapiIsVZThere = False Then
            MsgBox("VZones is not running")
        Else
            txt = New String(Chr(0), 32678)
            VZText.Text = VZonesDAPI.DapiGetText(txt, Len(txt), 1000)
            VZText.SelectionStart = Len(VZText.Text)
        End If
    End Sub

    Private Sub tmrCheckStatus_Tick(sender As Object, e As EventArgs) Handles tmrCheckStatus.Tick
        btnLeft.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_LEFT)
        btnUp.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_UP)
        btnRight.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_RIGHT)
        btnDown.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_DOWN)
        btnGhost.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_GHOST)
        btnNormal.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_NORMAL)
        btnHappy.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_HAPPY)
        btnSad.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_SAD)
        btnMad.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_MAD)
        btnTurnAround.Enabled = VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_TAROUND)
        If VZonesDAPI.DapiIsButtonActive(VZonesDAPI.VZ_BUTTON_TAROUND) Then
            btnTurnAround.Enabled = True
            btnGhost.Text = "Ghost"
        Else
            btnTurnAround.Enabled = False
            btnGhost.Text = "Unghost"
        End If
    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        VZonesDAPI.DapiPressButton(VZonesDAPI.VZ_BUTTON_NORMAL)
    End Sub

    Private Sub btnHappy_Click(sender As Object, e As EventArgs) Handles btnHappy.Click
        VZonesDAPI.DapiPressButton(VZonesDAPI.VZ_BUTTON_HAPPY)
    End Sub

    Private Sub btnSad_Click(sender As Object, e As EventArgs) Handles btnSad.Click
        VZonesDAPI.DapiPressButton(VZonesDAPI.VZ_BUTTON_SAD)
    End Sub

    Private Sub btnMad_Click(sender As Object, e As EventArgs) Handles btnMad.Click
        VZonesDAPI.DapiPressButton(VZonesDAPI.VZ_BUTTON_MAD)
    End Sub

    Private Sub btnTurnAround_Click(sender As Object, e As EventArgs) Handles btnTurnAround.Click
        VZonesDAPI.DapiPressButton(VZonesDAPI.VZ_BUTTON_TAROUND)
    End Sub

    Private Sub btnSendESP_Click(sender As Object, e As EventArgs) Handles btnSendESP.Click
        If VZonesDAPI.DapiIsVZThere() = False Then
            MsgBox("VZones is not running")
        Else
            VZonesDAPI.DapiESP(txtESPTo.Text, txtSendText.Text, 5000)
        End If
    End Sub

    Private Sub btnGhost_Click(sender As Object, e As EventArgs) Handles btnGhost.Click
        VZonesDAPI.DapiPressButton(VZonesDAPI.VZ_BUTTON_GHOST)
    End Sub

    Private Sub btnSayOutloud_Click(sender As Object, e As EventArgs) Handles btnSayOutloud.Click
        If VZonesDAPI.DapiIsVZThere = False Then
            MsgBox("VZones is not running")
        Else
            VZonesDAPI.DapiSpeak(txtSendText.Text, 5000)
        End If
    End Sub

    Private Sub btnThinkText_Click(sender As Object, e As EventArgs) Handles btnThinkText.Click
        If VZonesDAPI.DapiIsVZThere = False Then
            MsgBox("VZones is not running")
        Else
            VZonesDAPI.DapiThink(txtSendText.Text, 5000)
        End If
    End Sub
End Class
