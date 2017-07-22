Imports System.IO
Imports System.IO.Path

Public Class Form2
    Dim WritingCounter As Integer = 0
    Dim TimeToWrite As Double = Val(FormStartupInfo.WritingDurationTextbox.Text) * 60
    Dim GoodbyeTextCount As Integer = 0

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        InputTextBox.Text = ""
        InputTextBox.ReadOnly = True
        InputTextBox.Visible = False


        Me.Text = ""
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.WindowState = FormWindowState.Maximized
        Me.Top = True
        'sets the size / position of the instructions label, begin button, and the writing box
        BeginWritingButton.Location = New Point((Me.Width - BeginWritingButton.Width) * 0.5, (Me.Height - BeginWritingButton.Height) * 0.9)
        InstructionsLabel.Size = New Point((Me.Width) * 0.8, Me.Height * 0.6)
        InstructionsLabel.Location = New Point((Me.Width - InstructionsLabel.Width) * 0.1, (Me.Height - InstructionsLabel.Height) * 0.1)
        InputTextBox.Size = New Point(Me.Width * 0.8, (Me.Height - InstructionsLabel.Height) * 0.9)
        InputTextBox.Location = New Point(Me.Width * 0.1, (Me.Height - InputTextBox.Height - InputTextBox.Height))


        'loads up the instructions
        Try
            Dim InstructionsText As StreamReader = New StreamReader("Instructions-" + FormStartupInfo.ConditionTextBox.Text.ToString + ".txt")
            InstructionsLabel.Text = InstructionsText.ReadToEnd
        Catch
            BeginWritingButton.Visible = False
            BeginWritingButton.Enabled = False
            InstructionsLabel.Text = "YOU ARE MISSING INSTRUCTIONS.TXT!!!"
            FinishedWritingTimer.Start()
        End Try




    End Sub

    Private Sub BeginWritingButton_Click(sender As System.Object, e As System.EventArgs) Handles BeginWritingButton.Click
        InputTextBox.ReadOnly = False
        InputTextBox.Visible = True
        InputTextBox.Select()
        BeginWritingButton.Enabled = False
        If Int(((TimeToWrite / 60) - (WritingCounter / 60))) > 0 Then
            BeginWritingButton.Text = "Time Left: " + Int(((TimeToWrite / 60) - (WritingCounter / 60))).ToString + " Minutes"
        Else
            BeginWritingButton.Text = "Time Left: " + Int(((TimeToWrite / 60) - (WritingCounter / 60))).ToString + " Minute"
        End If
        WritingTimer.Start()
        Cursor.Hide()

    End Sub

    Private Sub WritingTimer_Tick(sender As System.Object, e As System.EventArgs) Handles WritingTimer.Tick
        WritingCounter += 1

        If Int(((TimeToWrite / 60) - (WritingCounter / 60))) > 0 Then
            BeginWritingButton.Text = "Time Left: " + (Int(((TimeToWrite / 60) - (WritingCounter / 60))) + 1).ToString + " Minutes"
        Else
            BeginWritingButton.Text = "Time Left: " + (Int(((TimeToWrite / 60) - (WritingCounter / 60))) + 1).ToString + " Minute"
        End If



        'what to do when writing time is up
        If WritingCounter >= TimeToWrite Then
            WritingTimer.Stop()
            WritingTimer.Dispose()
            InputTextBox.ReadOnly = True
            InputTextBox.Visible = False
            InstructionsLabel.Location = New Point((Me.Width - InstructionsLabel.Width) * 0.1, Me.Height * 0.5)
            InstructionsLabel.Text = "Please inform the experimenter that you have completed this portion of the study..."
            InstructionsLabel.Visible = True
            Dim OutputFileName As String = "Writing Output\" + FormStartupInfo.ParticipantNumberTextBox.Text.ToString + "-"
            Dim SampleNumber As Integer = 0
            Do While File.Exists(OutputFileName + SampleNumber.ToString + ".txt")
                SampleNumber += 1
            Loop

            If (Not System.IO.Directory.Exists("Writing Output\")) Then
                System.IO.Directory.CreateDirectory("Writing Output\")
            End If

            Dim fileoutput As System.IO.StreamWriter
            fileoutput = My.Computer.FileSystem.OpenTextFileWriter(OutputFileName + SampleNumber.ToString + ".txt", False)
            fileoutput.Write(InputTextBox.Text.ToString)
            fileoutput.Close()

            fileoutput = My.Computer.FileSystem.OpenTextFileWriter(OutputFileName + SampleNumber.ToString + ".csv", False)
            fileoutput.WriteLine("Subject,Date,Time,Computer,Condition,Writing_Time")
            fileoutput.WriteLine(FormStartupInfo.ParticipantNumberTextBox.Text.ToString + "," + DateTime.Now.ToString("yyyy-MM-dd") + "," + DateTime.Now.ToString("HH:mm:ss") + "," + FormStartupInfo.ComputerNumberTextbox.Text.ToString + "," + FormStartupInfo.ConditionTextBox.Text.ToString + "," + (WritingCounter / 60).ToString)
            fileoutput.Close()

            FinishedWritingTimer.Start()
        End If


    End Sub

    Private Sub FinishedWritingTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FinishedWritingTimer.Tick
        GoodbyeTextCount += 1
        If GoodbyeTextCount > 15 Then
            FinishedWritingTimer.Stop()
            FinishedWritingTimer.Dispose()
            FormStartupInfo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        FormStartupInfo.Show()
        Cursor.Show()
    End Sub

End Class