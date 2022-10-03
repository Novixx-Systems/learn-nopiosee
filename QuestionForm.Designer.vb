<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuestionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check && Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 182)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(444, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Question:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(616, 102)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Your Answer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(564, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "1 / qCount"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(71, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "í"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(9, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 44)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "¿"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(5, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 61)
        Me.Panel1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(133, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 44)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "ó"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 291)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "QuestionForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
End Class
