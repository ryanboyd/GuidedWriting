Imports System.IO
Imports System.IO.Path

Public Class FormStartupInfo


    'limits the splitter's input array to 0-9 and backspace (ChrW(8))
    Private Sub WritingDurationTextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WritingDurationTextbox.KeyPress

        Dim allowedChars As String = "0123456789"

        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub


    'MAKES SURE THAT SPLITTER BOX ISN'T LEFT BLANK
    Private Sub WritingDurationTextbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WritingDurationTextbox.Leave
        If WritingDurationTextbox.Text = "" Or WritingDurationTextbox.Text = "0" Then
            WritingDurationTextbox.Text = "1"
        End If
    End Sub



    'limits the splitter's input array to 0-9 and backspace (ChrW(8))
    'Private Sub ParticipantNumberTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ParticipantNumberTextBox.KeyPress
    '
    '    Dim allowedChars As String = "0123456789"
    '
    '    If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso Not e.KeyChar = ChrW(8) Then
    '            ' Invalid Character
    '            e.Handled = True
    '    End If
    '    End Sub


    'MAKES SURE THAT SPLITTER BOX ISN'T LEFT BLANK
    Private Sub ParticipantNumberTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParticipantNumberTextBox.Leave
        If ParticipantNumberTextBox.Text = "" Then
            ParticipantNumberTextBox.Text = "1"
        End If
    End Sub


    Private Sub Form1_Keydown(ByVal sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, ParticipantNumberTextBox.KeyDown, WritingDurationTextbox.KeyDown, ComputerNumberTextbox.KeyDown, ConditionTextBox.KeyDown
        If e.KeyCode = Keys.F10 Then
            Me.Hide()
            Me.Visible = False
            Form2.Show()
        End If
    End Sub
End Class
