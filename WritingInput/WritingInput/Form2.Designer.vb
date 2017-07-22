<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BeginWritingButton = New System.Windows.Forms.Button()
        Me.InstructionsLabel = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.WritingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FinishedWritingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BeginWritingButton
        '
        Me.BeginWritingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginWritingButton.ForeColor = System.Drawing.Color.Black
        Me.BeginWritingButton.Location = New System.Drawing.Point(409, 546)
        Me.BeginWritingButton.Name = "BeginWritingButton"
        Me.BeginWritingButton.Size = New System.Drawing.Size(178, 40)
        Me.BeginWritingButton.TabIndex = 0
        Me.BeginWritingButton.Text = "Begin Writing"
        Me.BeginWritingButton.UseVisualStyleBackColor = True
        '
        'InstructionsLabel
        '
        Me.InstructionsLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InstructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsLabel.ForeColor = System.Drawing.Color.Black
        Me.InstructionsLabel.Location = New System.Drawing.Point(13, 13)
        Me.InstructionsLabel.Name = "InstructionsLabel"
        Me.InstructionsLabel.Size = New System.Drawing.Size(208, 38)
        Me.InstructionsLabel.TabIndex = 0
        Me.InstructionsLabel.Text = "Instructions Text"
        Me.InstructionsLabel.UseCompatibleTextRendering = True
        '
        'InputTextBox
        '
        Me.InputTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTextBox.ForeColor = System.Drawing.Color.Black
        Me.InputTextBox.Location = New System.Drawing.Point(13, 73)
        Me.InputTextBox.Multiline = True
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InputTextBox.Size = New System.Drawing.Size(366, 78)
        Me.InputTextBox.TabIndex = 1
        Me.InputTextBox.Text = "text goes here"
        '
        'WritingTimer
        '
        Me.WritingTimer.Interval = 1000
        '
        'FinishedWritingTimer
        '
        Me.FinishedWritingTimer.Interval = 1000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(972, 639)
        Me.ControlBox = False
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.InstructionsLabel)
        Me.Controls.Add(Me.BeginWritingButton)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "vb"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BeginWritingButton As System.Windows.Forms.Button
    Friend WithEvents InstructionsLabel As System.Windows.Forms.Label
    Friend WithEvents InputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WritingTimer As System.Windows.Forms.Timer
    Friend WithEvents FinishedWritingTimer As System.Windows.Forms.Timer
End Class
