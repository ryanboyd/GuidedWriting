<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStartupInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStartupInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ParticipantNumberTextBox = New System.Windows.Forms.TextBox()
        Me.WritingDurationTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComputerNumberTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConditionTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Participant Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Writing Duration:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "minutes"
        '
        'ParticipantNumberTextBox
        '
        Me.ParticipantNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParticipantNumberTextBox.Location = New System.Drawing.Point(166, 15)
        Me.ParticipantNumberTextBox.MaxLength = 10
        Me.ParticipantNumberTextBox.Name = "ParticipantNumberTextBox"
        Me.ParticipantNumberTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ParticipantNumberTextBox.TabIndex = 1
        Me.ParticipantNumberTextBox.Text = "1"
        Me.ParticipantNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ParticipantNumberTextBox.WordWrap = False
        '
        'WritingDurationTextbox
        '
        Me.WritingDurationTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WritingDurationTextbox.Location = New System.Drawing.Point(166, 50)
        Me.WritingDurationTextbox.MaxLength = 3
        Me.WritingDurationTextbox.Name = "WritingDurationTextbox"
        Me.WritingDurationTextbox.Size = New System.Drawing.Size(50, 26)
        Me.WritingDurationTextbox.TabIndex = 2
        Me.WritingDurationTextbox.Text = "5"
        Me.WritingDurationTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WritingDurationTextbox.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Computer ID#:"
        '
        'ComputerNumberTextbox
        '
        Me.ComputerNumberTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerNumberTextbox.Location = New System.Drawing.Point(166, 86)
        Me.ComputerNumberTextbox.MaxLength = 3
        Me.ComputerNumberTextbox.Name = "ComputerNumberTextbox"
        Me.ComputerNumberTextbox.Size = New System.Drawing.Size(50, 26)
        Me.ComputerNumberTextbox.TabIndex = 3
        Me.ComputerNumberTextbox.Text = "1"
        Me.ComputerNumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ComputerNumberTextbox.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Condition:"
        '
        'ConditionTextBox
        '
        Me.ConditionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConditionTextBox.Location = New System.Drawing.Point(166, 123)
        Me.ConditionTextBox.MaxLength = 3
        Me.ConditionTextBox.Name = "ConditionTextBox"
        Me.ConditionTextBox.Size = New System.Drawing.Size(50, 26)
        Me.ConditionTextBox.TabIndex = 8
        Me.ConditionTextBox.Text = "1"
        Me.ConditionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ConditionTextBox.WordWrap = False
        '
        'FormStartupInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 172)
        Me.Controls.Add(Me.ConditionTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComputerNumberTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WritingDurationTextbox)
        Me.Controls.Add(Me.ParticipantNumberTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(343, 210)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(343, 210)
        Me.Name = "FormStartupInfo"
        Me.Text = "Startup Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ParticipantNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WritingDurationTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComputerNumberTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ConditionTextBox As System.Windows.Forms.TextBox

End Class
