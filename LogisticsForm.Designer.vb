<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogisticsForm
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
        Me.MarioLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PickUp = New System.Windows.Forms.Button()
        Me.Delivery = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderPizza = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.MarioLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarioLogo
        '
        Me.MarioLogo.BackColor = System.Drawing.SystemColors.Control
        Me.MarioLogo.Image = Global.Pizza_App_User.My.Resources.Resources.Mario
        Me.MarioLogo.Location = New System.Drawing.Point(12, 12)
        Me.MarioLogo.Name = "MarioLogo"
        Me.MarioLogo.Size = New System.Drawing.Size(227, 193)
        Me.MarioLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MarioLogo.TabIndex = 2
        Me.MarioLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(350, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome To Mario's Pizza"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please Select"
        '
        'PickUp
        '
        Me.PickUp.Location = New System.Drawing.Point(382, 318)
        Me.PickUp.Name = "PickUp"
        Me.PickUp.Size = New System.Drawing.Size(109, 40)
        Me.PickUp.TabIndex = 7
        Me.PickUp.Text = "Pick-Up"
        Me.PickUp.UseVisualStyleBackColor = True
        '
        'Delivery
        '
        Me.Delivery.Location = New System.Drawing.Point(615, 318)
        Me.Delivery.Name = "Delivery"
        Me.Delivery.Size = New System.Drawing.Size(109, 40)
        Me.Delivery.TabIndex = 8
        Me.Delivery.Text = "Delivery"
        Me.Delivery.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(534, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "or"
        '
        'OrderPizza
        '
        Me.OrderPizza.Location = New System.Drawing.Point(503, 420)
        Me.OrderPizza.Name = "OrderPizza"
        Me.OrderPizza.Size = New System.Drawing.Size(109, 40)
        Me.OrderPizza.TabIndex = 10
        Me.OrderPizza.Text = "Order Pizza"
        Me.OrderPizza.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(499, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = ".."
        '
        'LogisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Pizza_App_User.My.Resources.Resources.gtgtgtgtg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(968, 481)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OrderPizza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Delivery)
        Me.Controls.Add(Me.PickUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MarioLogo)
        Me.Name = "LogisticsForm"
        Me.Text = "LogisticsForm"
        CType(Me.MarioLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarioLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PickUp As Button
    Friend WithEvents Delivery As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderPizza As Button
    Friend WithEvents Label4 As Label
End Class
