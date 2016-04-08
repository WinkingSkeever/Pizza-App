<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RadioButtonKong = New System.Windows.Forms.RadioButton()
        Me.RadioButtonToad = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPeach = New System.Windows.Forms.RadioButton()
        Me.RadioButtonYoshi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBowser = New System.Windows.Forms.RadioButton()
        Me.OrderPizza = New System.Windows.Forms.Button()
        Me.Specials = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MarioLogo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.MarioLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Controls.Add(Me.RadioButtonKong)
        Me.FlowLayoutPanel1.Controls.Add(Me.RadioButtonToad)
        Me.FlowLayoutPanel1.Controls.Add(Me.RadioButtonPeach)
        Me.FlowLayoutPanel1.Controls.Add(Me.RadioButtonYoshi)
        Me.FlowLayoutPanel1.Controls.Add(Me.RadioButtonBowser)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(439, 238)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(107, 121)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'RadioButtonKong
        '
        Me.RadioButtonKong.AutoSize = True
        Me.RadioButtonKong.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonKong.Name = "RadioButtonKong"
        Me.RadioButtonKong.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonKong.TabIndex = 1
        Me.RadioButtonKong.TabStop = True
        Me.RadioButtonKong.Text = "Donkey Kong"
        Me.RadioButtonKong.UseVisualStyleBackColor = True
        '
        'RadioButtonToad
        '
        Me.RadioButtonToad.AutoSize = True
        Me.RadioButtonToad.Location = New System.Drawing.Point(3, 26)
        Me.RadioButtonToad.Name = "RadioButtonToad"
        Me.RadioButtonToad.Size = New System.Drawing.Size(77, 17)
        Me.RadioButtonToad.TabIndex = 0
        Me.RadioButtonToad.TabStop = True
        Me.RadioButtonToad.Text = "Toad Stool"
        Me.RadioButtonToad.UseVisualStyleBackColor = True
        '
        'RadioButtonPeach
        '
        Me.RadioButtonPeach.AutoSize = True
        Me.RadioButtonPeach.Location = New System.Drawing.Point(3, 49)
        Me.RadioButtonPeach.Name = "RadioButtonPeach"
        Me.RadioButtonPeach.Size = New System.Drawing.Size(99, 17)
        Me.RadioButtonPeach.TabIndex = 2
        Me.RadioButtonPeach.TabStop = True
        Me.RadioButtonPeach.Text = "Princess Peach"
        Me.RadioButtonPeach.UseVisualStyleBackColor = True
        '
        'RadioButtonYoshi
        '
        Me.RadioButtonYoshi.AutoSize = True
        Me.RadioButtonYoshi.Location = New System.Drawing.Point(3, 72)
        Me.RadioButtonYoshi.Name = "RadioButtonYoshi"
        Me.RadioButtonYoshi.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonYoshi.TabIndex = 3
        Me.RadioButtonYoshi.TabStop = True
        Me.RadioButtonYoshi.Text = "Yoshi"
        Me.RadioButtonYoshi.UseVisualStyleBackColor = True
        '
        'RadioButtonBowser
        '
        Me.RadioButtonBowser.AutoSize = True
        Me.RadioButtonBowser.Location = New System.Drawing.Point(3, 95)
        Me.RadioButtonBowser.Name = "RadioButtonBowser"
        Me.RadioButtonBowser.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonBowser.TabIndex = 4
        Me.RadioButtonBowser.TabStop = True
        Me.RadioButtonBowser.Text = "Bowser"
        Me.RadioButtonBowser.UseVisualStyleBackColor = True
        '
        'OrderPizza
        '
        Me.OrderPizza.Location = New System.Drawing.Point(324, 440)
        Me.OrderPizza.Name = "OrderPizza"
        Me.OrderPizza.Size = New System.Drawing.Size(109, 40)
        Me.OrderPizza.TabIndex = 2
        Me.OrderPizza.Text = "Order Pizza"
        Me.OrderPizza.UseVisualStyleBackColor = True
        '
        'Specials
        '
        Me.Specials.BackColor = System.Drawing.SystemColors.Control
        Me.Specials.Location = New System.Drawing.Point(551, 440)
        Me.Specials.Name = "Specials"
        Me.Specials.Size = New System.Drawing.Size(109, 40)
        Me.Specials.TabIndex = 3
        Me.Specials.Text = "See Specials"
        Me.Specials.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(317, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome To Mario's Pizza"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(407, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please Select User Name"
        '
        'MarioLogo
        '
        Me.MarioLogo.BackColor = System.Drawing.SystemColors.Control
        Me.MarioLogo.Image = Global.Pizza_App_User.My.Resources.Resources.Mario
        Me.MarioLogo.Location = New System.Drawing.Point(12, 12)
        Me.MarioLogo.Name = "MarioLogo"
        Me.MarioLogo.Size = New System.Drawing.Size(227, 193)
        Me.MarioLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MarioLogo.TabIndex = 6
        Me.MarioLogo.TabStop = False
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pizza_App_User.My.Resources.Resources.pizza2_jpg
        Me.ClientSize = New System.Drawing.Size(982, 583)
        Me.Controls.Add(Me.MarioLogo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Specials)
        Me.Controls.Add(Me.OrderPizza)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "UserForm"
        Me.Text = "Mario's Pizza"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.MarioLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents RadioButtonToad As RadioButton
    Friend WithEvents RadioButtonKong As RadioButton
    Friend WithEvents RadioButtonPeach As RadioButton
    Friend WithEvents RadioButtonYoshi As RadioButton
    Friend WithEvents RadioButtonBowser As RadioButton
    Friend WithEvents OrderPizza As Button
    Friend WithEvents Specials As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MarioLogo As PictureBox
End Class
