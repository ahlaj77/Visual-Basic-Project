<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(summaryForm))
        Me.backButton = New System.Windows.Forms.Button()
        Me.numberofshirtorderLabel = New System.Windows.Forms.Label()
        Me.numberoforderLabel = New System.Windows.Forms.Label()
        Me.numberoftotaldollarLabel = New System.Windows.Forms.Label()
        Me.numberofshirtorderTextBox = New System.Windows.Forms.TextBox()
        Me.numberoforderTextBox = New System.Windows.Forms.TextBox()
        Me.numberoftotaldollarTextBox = New System.Windows.Forms.TextBox()
        Me.alpinesummarytitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backButton.Location = New System.Drawing.Point(127, 184)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(83, 28)
        Me.backButton.TabIndex = 0
        Me.backButton.Text = "&Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'numberofshirtorderLabel
        '
        Me.numberofshirtorderLabel.AutoSize = True
        Me.numberofshirtorderLabel.Location = New System.Drawing.Point(62, 64)
        Me.numberofshirtorderLabel.Name = "numberofshirtorderLabel"
        Me.numberofshirtorderLabel.Size = New System.Drawing.Size(117, 13)
        Me.numberofshirtorderLabel.TabIndex = 1
        Me.numberofshirtorderLabel.Text = "Number of Shirt Orders:"
        '
        'numberoforderLabel
        '
        Me.numberoforderLabel.AutoSize = True
        Me.numberoforderLabel.Location = New System.Drawing.Point(86, 97)
        Me.numberoforderLabel.Name = "numberoforderLabel"
        Me.numberoforderLabel.Size = New System.Drawing.Size(93, 13)
        Me.numberoforderLabel.TabIndex = 2
        Me.numberoforderLabel.Text = "Number of Orders:"
        '
        'numberoftotaldollarLabel
        '
        Me.numberoftotaldollarLabel.AutoSize = True
        Me.numberoftotaldollarLabel.Location = New System.Drawing.Point(58, 130)
        Me.numberoftotaldollarLabel.Name = "numberoftotaldollarLabel"
        Me.numberoftotaldollarLabel.Size = New System.Drawing.Size(121, 13)
        Me.numberoftotaldollarLabel.TabIndex = 3
        Me.numberoftotaldollarLabel.Text = "Number of Total Dollars:"
        '
        'numberofshirtorderTextBox
        '
        Me.numberofshirtorderTextBox.Location = New System.Drawing.Point(185, 61)
        Me.numberofshirtorderTextBox.Name = "numberofshirtorderTextBox"
        Me.numberofshirtorderTextBox.ReadOnly = True
        Me.numberofshirtorderTextBox.Size = New System.Drawing.Size(64, 20)
        Me.numberofshirtorderTextBox.TabIndex = 4
        '
        'numberoforderTextBox
        '
        Me.numberoforderTextBox.Location = New System.Drawing.Point(185, 94)
        Me.numberoforderTextBox.Name = "numberoforderTextBox"
        Me.numberoforderTextBox.ReadOnly = True
        Me.numberoforderTextBox.Size = New System.Drawing.Size(64, 20)
        Me.numberoforderTextBox.TabIndex = 5
        '
        'numberoftotaldollarTextBox
        '
        Me.numberoftotaldollarTextBox.Location = New System.Drawing.Point(185, 128)
        Me.numberoftotaldollarTextBox.Name = "numberoftotaldollarTextBox"
        Me.numberoftotaldollarTextBox.ReadOnly = True
        Me.numberoftotaldollarTextBox.Size = New System.Drawing.Size(64, 20)
        Me.numberoftotaldollarTextBox.TabIndex = 6
        '
        'alpinesummarytitleLabel
        '
        Me.alpinesummarytitleLabel.AutoSize = True
        Me.alpinesummarytitleLabel.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alpinesummarytitleLabel.Location = New System.Drawing.Point(17, 9)
        Me.alpinesummarytitleLabel.Name = "alpinesummarytitleLabel"
        Me.alpinesummarytitleLabel.Size = New System.Drawing.Size(293, 28)
        Me.alpinesummarytitleLabel.TabIndex = 7
        Me.alpinesummarytitleLabel.Text = "Alpine Snowboard Inc. Summary"
        '
        'summaryForm
        '
        Me.AcceptButton = Me.backButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.backButton
        Me.ClientSize = New System.Drawing.Size(323, 246)
        Me.Controls.Add(Me.alpinesummarytitleLabel)
        Me.Controls.Add(Me.numberoftotaldollarTextBox)
        Me.Controls.Add(Me.numberoforderTextBox)
        Me.Controls.Add(Me.numberofshirtorderTextBox)
        Me.Controls.Add(Me.numberoftotaldollarLabel)
        Me.Controls.Add(Me.numberoforderLabel)
        Me.Controls.Add(Me.numberofshirtorderLabel)
        Me.Controls.Add(Me.backButton)
        Me.Name = "summaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "summaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents numberofshirtorderLabel As System.Windows.Forms.Label
    Friend WithEvents numberoforderLabel As System.Windows.Forms.Label
    Friend WithEvents numberoftotaldollarLabel As System.Windows.Forms.Label
    Friend WithEvents numberofshirtorderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents numberoforderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents numberoftotaldollarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents alpinesummarytitleLabel As System.Windows.Forms.Label
End Class
