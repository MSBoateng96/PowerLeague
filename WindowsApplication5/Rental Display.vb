' Import Data and SQL Client

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmRentalDisplay
    Dim SetTime As Integer

    Private Sub btnBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooking.Click
        'If all pitches are currently being used, booking is suspended
        If rchtxtPitch1.BackColor = Color.Red And rchtxtPitch2.BackColor = Color.Red And rchtxtPitch3.BackColor = Color.Red And rchtxtPitch4.BackColor = Color.Red And rchtxtPitch5.BackColor = Color.Red And rchtxtPitch6.BackColor = Color.Red And rchtxtPitch7.BackColor = Color.Red And rchtxtPitch8.BackColor = Color.Red And rchtxtPitch9.BackColor = Color.Red And rchtxtPitch10.BackColor = Color.Red And rchtxtPitch11.BackColor = Color.Red And rchtxtPitch12.BackColor = Color.Red Then
            MsgBox("No Pitches Available to book! Please wait till a rental is complete.", MsgBoxStyle.Exclamation, "Pitch Booking")

            'Removing possibility of double-booking a 5-A-Side Pitch
        ElseIf rchtxtPitch1.BackColor = Color.Red And rchtxtPitch2.BackColor = Color.Red And rchtxtPitch3.BackColor = Color.Red And rchtxtPitch4.BackColor = Color.Red And rchtxtPitch5.BackColor = Color.Red Then
            frmBooking.ComboSize.Items.Remove("5-A-Side")

            If frmBooking.ComboSize.Items.Count = 0 Then
                frmBooking.ComboSize.Items.Add("7-A-Side")
            End If

            frmBooking.Show()
            Me.Hide()

            'Removing possibility of double-booking a 7-A-Side Pitch
        ElseIf rchtxtPitch6.BackColor = Color.Red And rchtxtPitch7.BackColor = Color.Red And rchtxtPitch8.BackColor = Color.Red And rchtxtPitch9.BackColor = Color.Red And rchtxtPitch10.BackColor = Color.Red And rchtxtPitch11.BackColor = Color.Red And rchtxtPitch12.BackColor = Color.Red Then
            frmBooking.ComboSize.Items.Remove("7-A-Side")

            If frmBooking.ComboSize.Items.Count = 0 Then
                frmBooking.ComboSize.Items.Add("5-A-Side")
            End If

            frmBooking.Show()
            Me.Hide()
        Else
            'When both sizes of pitch are available
            frmBooking.Show()
            Me.Hide()
        End If

        'Removing possibility of double-booking any pitch
        If rchtxtPitch1.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("1")
        End If
        If rchtxtPitch2.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("2")
        End If
        If rchtxtPitch3.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("3")
            
        End If
        If rchtxtPitch4.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("4")
            
        End If
        If rchtxtPitch5.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("5")

        End If
        If rchtxtPitch6.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("6")
            
        End If
        If rchtxtPitch7.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("7")
            
        End If
        If rchtxtPitch8.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("8")
            
        End If
        If rchtxtPitch9.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("9")
            
        End If
        If rchtxtPitch10.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("10")
            
        End If
        If rchtxtPitch11.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("11")
            
        End If
        If rchtxtPitch12.BackColor = Color.Red Then
            frmBooking.comboboxPitch.Items.Remove("12")
            
        End If
    End Sub

    Private Sub btnMembership_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMembership.Click
        frmMembership.Show()

        Me.Hide()
    End Sub

    Private Sub btnUtilities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUtilities.Click
        frmUtilities.Show()

        Me.Hide()
    End Sub

    Private Sub btnUserPref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserPref.Click
        frmPreferences.Show()

        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        'Logging out of the system
        If MsgBox("Are you sure you want to Logout?", MsgBoxStyle.YesNo, "Confirm Logout") = MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Hide()
            frmLogin.txtUsername.Text = ""
            frmLogin.txtPassword.Text = ""
        Else
            Me.Show() 'Do Nothing
        End If
    End Sub

    Private Sub frmRentalDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set Date and Time
        lblDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
        lblTime.Text = System.DateTime.Now.ToString("HH:mm")
    End Sub

    Private TargetDT As DateTime

    Private Sub start_pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start_pause.Click
        Dim CountDownFrom As TimeSpan = TimeSpan.FromSeconds(3600)

        'Choosing which timer to start depending on which pitch has been rented
        If lblPitch1.Text = "Pitch1" Then
            tmrPitch1.Enabled = True

            tmrPitch1.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch1.Start()
        End If

        If lblPitch2.Text = "Pitch2" Then
            tmrPitch2.Enabled = True

            tmrPitch2.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch2.Start()
        End If

        If lblPitch3.Text = "Pitch3" Then
            tmrPitch3.Enabled = True

            tmrPitch3.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch3.Start()
        End If

        If lblPitch4.Text = "Pitch4" Then
            tmrPitch4.Enabled = True

            tmrPitch4.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch4.Start()
        End If

        If lblPitch5.Text = "Pitch5" Then
            tmrPitch5.Enabled = True

            tmrPitch5.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch5.Start()
        End If

        If lblPitch6.Text = "Pitch6" Then
            tmrPitch6.Enabled = True

            tmrPitch6.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch6.Start()
        End If

        If lblPitch7.Text = "Pitch7" Then
            tmrPitch7.Enabled = True

            tmrPitch7.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch7.Start()
        End If

        If lblPitch8.Text = "Pitch8" Then
            tmrPitch8.Enabled = True

            tmrPitch8.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch8.Start()
        End If

        If lblPitch9.Text = "Pitch9" Then
            tmrPitch9.Enabled = True

            tmrPitch9.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch9.Start()
        End If

        If lblPitch10.Text = "Pitch10" Then
            tmrPitch10.Enabled = True

            tmrPitch10.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch10.Start()
        End If

        If lblPitch11.Text = "Pitch11" Then
            tmrPitch11.Enabled = True

            tmrPitch11.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch11.Start()
        End If

        If lblPitch12.Text = "Pitch12" Then
            tmrPitch12.Enabled = True

            tmrPitch12.Interval = 500
            TargetDT = DateTime.Now.Add(CountDownFrom)
            tmrPitch12.Start()
        End If


    End Sub

    Private Sub Tmrpitch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch1.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch1.Text = "Pitch1" Then
            rchtxtPitch1.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch1.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch1.Text = "00:00"
                tmrPitch1.Stop()
                rchtxtPitch1.BackColor = Color.LimeGreen
                MsgBox("Pitch 1 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch1.Text = "60:00"

            End If
        End If
    End Sub

    Private Sub tmrPitch2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch2.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch2.Text = "Pitch2" Then
            rchtxtPitch2.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch2.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch2.Text = "00:00"
                tmrPitch2.Stop()
                rchtxtPitch2.BackColor = Color.LimeGreen
                MsgBox("Pitch 12 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch2.Text = "60:00"
                lblPitch2.Text = "Pitch 2"
            End If
        End If

    End Sub

    Private Sub tmrPitch3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch3.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch3.Text = "Pitch3" Then
            rchtxtPitch3.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch3.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch3.Text = "00:00"
                tmrPitch3.Stop()
                rchtxtPitch3.BackColor = Color.LimeGreen
                MsgBox("Pitch 3 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch3.Text = "60:00"
                lblPitch3.Text = "Pitch 3"
            End If
        End If
    End Sub

    Private Sub tmrPitch4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch4.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch4.Text = "Pitch4" Then
            rchtxtPitch4.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch4.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch4.Text = "00:00"
                tmrPitch4.Stop()
                rchtxtPitch4.BackColor = Color.LimeGreen
                MsgBox("Pitch 4 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch4.Text = "60:00"
                lblPitch4.Text = "Pitch 4"
            End If
        End If
    End Sub

    Private Sub tmrPitch5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch5.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch5.Text = "Pitch5" Then
            rchtxtPitch5.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch5.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch5.Text = "00:00"
                tmrPitch5.Stop()
                rchtxtPitch5.BackColor = Color.LimeGreen
                MsgBox("Pitch 5 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch5.Text = "60:00"
                lblPitch5.Text = "Pitch 5"
            End If
        End If
    End Sub

    Private Sub tmrPitch6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch6.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch6.Text = "Pitch6" Then
            rchtxtPitch6.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch6.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch6.Text = "00:00"
                tmrPitch6.Stop()
                rchtxtPitch6.BackColor = Color.LimeGreen
                MsgBox("Pitch 6 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch6.Text = "60:00"
                lblPitch6.Text = "Pitch 6"
            End If
        End If
    End Sub

    Private Sub tmrPitch7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch7.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch7.Text = "Pitch7" Then
            rchtxtPitch7.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch7.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch7.Text = "00:00"
                tmrPitch7.Stop()
                rchtxtPitch7.BackColor = Color.LimeGreen
                MsgBox("Pitch 7 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch7.Text = "60:00"
                lblPitch7.Text = "Pitch 7"
            End If
        End If
    End Sub

    Private Sub tmrPitch8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch8.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch8.Text = "Pitch8" Then
            rchtxtPitch8.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch8.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch8.Text = "00:00"
                tmrPitch8.Stop()
                rchtxtPitch8.BackColor = Color.LimeGreen
                MsgBox("Pitch 8 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch8.Text = "60:00"
                lblPitch8.Text = "Pitch 8"
            End If
        End If
    End Sub

    Private Sub tmrPitch9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch9.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch9.Text = "Pitch9" Then
            rchtxtPitch9.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch9.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch9.Text = "00:00"
                tmrPitch9.Stop()
                rchtxtPitch9.BackColor = Color.LimeGreen
                MsgBox("Pitch 9 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch9.Text = "60:00"
                lblPitch9.Text = "Pitch 9"
            End If
        End If
    End Sub

    Private Sub tmrPitch10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch10.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch10.Text = "Pitch10" Then
            rchtxtPitch10.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch10.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch10.Text = "00:00"
                tmrPitch10.Stop()
                rchtxtPitch10.BackColor = Color.LimeGreen
                MsgBox("Pitch 10 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch10.Text = "60:00"
                lblPitch10.Text = "Pitch 10"
            End If
        End If
    End Sub

    Private Sub tmrPitch11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch11.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch11.Text = "Pitch11" Then
            rchtxtPitch11.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch11.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch11.Text = "00:00"
                tmrPitch11.Stop()
                rchtxtPitch11.BackColor = Color.LimeGreen
                MsgBox("Pitch 11 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch11.Text = "60:00"
                lblPitch11.Text = "Pitch 11"
            End If
        End If
    End Sub

    Private Sub tmrPitch12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPitch12.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        'Starting the pitch timers

        If lblPitch12.Text = "Pitch12" Then
            rchtxtPitch12.BackColor = Color.Red
            If ts.TotalMilliseconds > 0 Then
                rchtxtPitch12.Text = ts.ToString("mm\:ss")
            Else
                rchtxtPitch12.Text = "00:00"
                tmrPitch12.Stop()
                rchtxtPitch12.BackColor = Color.LimeGreen
                MsgBox("Pitch 12 is Now Available!", MsgBoxStyle.Information, "Available Pitch")
                rchtxtPitch12.Text = "60:00"
                lblPitch12.Text = "Pitch 12"
            End If
        End If

    End Sub
End Class