<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.VZText = New System.Windows.Forms.TextBox()
        Me.btnGetText = New System.Windows.Forms.Button()
        Me.btnClearText = New System.Windows.Forms.Button()
        Me.lblTextToSend = New System.Windows.Forms.Label()
        Me.lblESPTo = New System.Windows.Forms.Label()
        Me.txtSendText = New System.Windows.Forms.TextBox()
        Me.txtESPTo = New System.Windows.Forms.TextBox()
        Me.btnSayOutloud = New System.Windows.Forms.Button()
        Me.btnThinkText = New System.Windows.Forms.Button()
        Me.btnSendESP = New System.Windows.Forms.Button()
        Me.btnGhost = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnTurnAround = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.btnMad = New System.Windows.Forms.Button()
        Me.tmrCheckStatus = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'VZText
        '
        Me.VZText.AcceptsReturn = true
        Me.VZText.BackColor = System.Drawing.SystemColors.Window
        Me.VZText.Location = New System.Drawing.Point(12, 12)
        Me.VZText.MaxLength = 0
        Me.VZText.Multiline = true
        Me.VZText.Name = "VZText"
        Me.VZText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.VZText.Size = New System.Drawing.Size(479, 253)
        Me.VZText.TabIndex = 15
        Me.VZText.WordWrap = false
        '
        'btnGetText
        '
        Me.btnGetText.Location = New System.Drawing.Point(12, 271)
        Me.btnGetText.Name = "btnGetText"
        Me.btnGetText.Size = New System.Drawing.Size(158, 36)
        Me.btnGetText.TabIndex = 1
        Me.btnGetText.Text = "Get VZ Text"
        Me.btnGetText.UseVisualStyleBackColor = true
        '
        'btnClearText
        '
        Me.btnClearText.Location = New System.Drawing.Point(333, 271)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(158, 36)
        Me.btnClearText.TabIndex = 2
        Me.btnClearText.Text = "Clear Text"
        Me.btnClearText.UseVisualStyleBackColor = true
        '
        'lblTextToSend
        '
        Me.lblTextToSend.AutoSize = true
        Me.lblTextToSend.Location = New System.Drawing.Point(18, 355)
        Me.lblTextToSend.Name = "lblTextToSend"
        Me.lblTextToSend.Size = New System.Drawing.Size(72, 13)
        Me.lblTextToSend.TabIndex = 3
        Me.lblTextToSend.Text = "Text To Send"
        '
        'lblESPTo
        '
        Me.lblESPTo.AutoSize = true
        Me.lblESPTo.Location = New System.Drawing.Point(21, 410)
        Me.lblESPTo.Name = "lblESPTo"
        Me.lblESPTo.Size = New System.Drawing.Size(47, 13)
        Me.lblESPTo.TabIndex = 4
        Me.lblESPTo.Text = "ESP To:"
        '
        'txtSendText
        '
        Me.txtSendText.Location = New System.Drawing.Point(136, 347)
        Me.txtSendText.Name = "txtSendText"
        Me.txtSendText.Size = New System.Drawing.Size(224, 20)
        Me.txtSendText.TabIndex = 5
        Me.txtSendText.Text = "VZones DAPI is good!"
        '
        'txtESPTo
        '
        Me.txtESPTo.Location = New System.Drawing.Point(136, 402)
        Me.txtESPTo.Name = "txtESPTo"
        Me.txtESPTo.Size = New System.Drawing.Size(224, 20)
        Me.txtESPTo.TabIndex = 6
        Me.txtESPTo.Text = "Coal"
        '
        'btnSayOutloud
        '
        Me.btnSayOutloud.Location = New System.Drawing.Point(378, 344)
        Me.btnSayOutloud.Name = "btnSayOutloud"
        Me.btnSayOutloud.Size = New System.Drawing.Size(75, 23)
        Me.btnSayOutloud.TabIndex = 7
        Me.btnSayOutloud.Text = "Say Outloud"
        Me.btnSayOutloud.UseVisualStyleBackColor = true
        '
        'btnThinkText
        '
        Me.btnThinkText.Location = New System.Drawing.Point(378, 373)
        Me.btnThinkText.Name = "btnThinkText"
        Me.btnThinkText.Size = New System.Drawing.Size(75, 23)
        Me.btnThinkText.TabIndex = 8
        Me.btnThinkText.Text = "Think Text"
        Me.btnThinkText.UseVisualStyleBackColor = true
        '
        'btnSendESP
        '
        Me.btnSendESP.Location = New System.Drawing.Point(378, 402)
        Me.btnSendESP.Name = "btnSendESP"
        Me.btnSendESP.Size = New System.Drawing.Size(75, 23)
        Me.btnSendESP.TabIndex = 9
        Me.btnSendESP.Text = "Send ESP"
        Me.btnSendESP.UseVisualStyleBackColor = true
        '
        'btnGhost
        '
        Me.btnGhost.Location = New System.Drawing.Point(24, 474)
        Me.btnGhost.Name = "btnGhost"
        Me.btnGhost.Size = New System.Drawing.Size(75, 23)
        Me.btnGhost.TabIndex = 10
        Me.btnGhost.Text = "Ghost"
        Me.btnGhost.UseVisualStyleBackColor = true
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(285, 444)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 11
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = true
        '
        'btnTurnAround
        '
        Me.btnTurnAround.Location = New System.Drawing.Point(285, 474)
        Me.btnTurnAround.Name = "btnTurnAround"
        Me.btnTurnAround.Size = New System.Drawing.Size(75, 23)
        Me.btnTurnAround.TabIndex = 12
        Me.btnTurnAround.Text = "Turn Around"
        Me.btnTurnAround.UseVisualStyleBackColor = true
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(285, 504)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = true
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(367, 473)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 14
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = true
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(204, 473)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 15
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = true
        '
        'btnNormal
        '
        Me.btnNormal.Location = New System.Drawing.Point(84, 553)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(75, 23)
        Me.btnNormal.TabIndex = 16
        Me.btnNormal.Text = "Normal"
        Me.btnNormal.UseVisualStyleBackColor = true
        '
        'btnHappy
        '
        Me.btnHappy.Location = New System.Drawing.Point(165, 553)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(75, 23)
        Me.btnHappy.TabIndex = 17
        Me.btnHappy.Text = "Happy"
        Me.btnHappy.UseVisualStyleBackColor = true
        '
        'btnSad
        '
        Me.btnSad.Location = New System.Drawing.Point(246, 553)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(75, 23)
        Me.btnSad.TabIndex = 18
        Me.btnSad.Text = "Sad"
        Me.btnSad.UseVisualStyleBackColor = true
        '
        'btnMad
        '
        Me.btnMad.Location = New System.Drawing.Point(327, 553)
        Me.btnMad.Name = "btnMad"
        Me.btnMad.Size = New System.Drawing.Size(75, 23)
        Me.btnMad.TabIndex = 19
        Me.btnMad.Text = "Mad"
        Me.btnMad.UseVisualStyleBackColor = true
        '
        'tmrCheckStatus
        '
        Me.tmrCheckStatus.Enabled = true
        Me.tmrCheckStatus.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 593)
        Me.Controls.Add(Me.btnMad)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnHappy)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnTurnAround)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnGhost)
        Me.Controls.Add(Me.btnSendESP)
        Me.Controls.Add(Me.btnThinkText)
        Me.Controls.Add(Me.btnSayOutloud)
        Me.Controls.Add(Me.txtESPTo)
        Me.Controls.Add(Me.txtSendText)
        Me.Controls.Add(Me.lblESPTo)
        Me.Controls.Add(Me.lblTextToSend)
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.btnGetText)
        Me.Controls.Add(Me.VZText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "VZonesDAPI VB Example"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnGetText As Button
    Friend WithEvents btnClearText As Button
    Friend WithEvents lblTextToSend As Label
    Friend WithEvents lblESPTo As Label
    Friend WithEvents txtSendText As TextBox
    Friend WithEvents txtESPTo As TextBox
    Friend WithEvents btnSayOutloud As Button
    Friend WithEvents btnThinkText As Button
    Friend WithEvents btnSendESP As Button
    Friend WithEvents btnGhost As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnTurnAround As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnHappy As Button
    Friend WithEvents btnSad As Button
    Friend WithEvents btnMad As Button
    Public WithEvents tmrCheckStatus As Timer
    Public WithEvents VZText As TextBox
End Class
