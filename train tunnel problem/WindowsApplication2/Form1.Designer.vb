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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.right = New System.Windows.Forms.RadioButton()
        Me.left = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unlock1 = New System.Windows.Forms.PictureBox()
        Me.tunnel = New System.Windows.Forms.PictureBox()
        Me.r1 = New System.Windows.Forms.PictureBox()
        Me.l1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tr1 = New System.Windows.Forms.TextBox()
        Me.tl1 = New System.Windows.Forms.TextBox()
        Me.train_tunnel = New System.Windows.Forms.PictureBox()
        Me.lock1 = New System.Windows.Forms.PictureBox()
        CType(Me.unlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tunnel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.r1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.l1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.train_tunnel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'right
        '
        Me.right.AutoSize = True
        Me.right.Location = New System.Drawing.Point(24, 91)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(76, 17)
        Me.right.TabIndex = 5
        Me.right.TabStop = True
        Me.right.Text = "From Right"
        Me.right.UseVisualStyleBackColor = True
        '
        'left
        '
        Me.left.AutoSize = True
        Me.left.Location = New System.Drawing.Point(24, 59)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(69, 17)
        Me.left.TabIndex = 6
        Me.left.TabStop = True
        Me.left.Text = "From Left"
        Me.left.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TURN"
        '
        'unlock1
        '
        Me.unlock1.Image = Global.WindowsApplication2.My.Resources.Resources.unlock_small1
        Me.unlock1.Location = New System.Drawing.Point(230, 222)
        Me.unlock1.Name = "unlock1"
        Me.unlock1.Size = New System.Drawing.Size(64, 63)
        Me.unlock1.TabIndex = 8
        Me.unlock1.TabStop = False
        '
        'tunnel
        '
        Me.tunnel.Image = Global.WindowsApplication2.My.Resources.Resources.tunnel_small
        Me.tunnel.Location = New System.Drawing.Point(166, 7)
        Me.tunnel.Name = "tunnel"
        Me.tunnel.Size = New System.Drawing.Size(200, 204)
        Me.tunnel.TabIndex = 4
        Me.tunnel.TabStop = False
        '
        'r1
        '
        Me.r1.Image = Global.WindowsApplication2.My.Resources.Resources.small_trainflip
        Me.r1.Location = New System.Drawing.Point(408, 181)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(98, 102)
        Me.r1.TabIndex = 2
        Me.r1.TabStop = False
        '
        'l1
        '
        Me.l1.Image = Global.WindowsApplication2.My.Resources.Resources.small_train
        Me.l1.Location = New System.Drawing.Point(24, 181)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(99, 103)
        Me.l1.TabIndex = 1
        Me.l1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Enter Tunnel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 26)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exit Tunnel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tr1
        '
        Me.tr1.Location = New System.Drawing.Point(408, 144)
        Me.tr1.Name = "tr1"
        Me.tr1.Size = New System.Drawing.Size(98, 20)
        Me.tr1.TabIndex = 15
        Me.tr1.Text = "Ready"
        Me.tr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tl1
        '
        Me.tl1.Location = New System.Drawing.Point(24, 151)
        Me.tl1.Name = "tl1"
        Me.tl1.Size = New System.Drawing.Size(99, 20)
        Me.tl1.TabIndex = 16
        Me.tl1.Text = "Ready"
        Me.tl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'train_tunnel
        '
        Me.train_tunnel.Image = CType(resources.GetObject("train_tunnel.Image"), System.Drawing.Image)
        Me.train_tunnel.Location = New System.Drawing.Point(166, 7)
        Me.train_tunnel.Name = "train_tunnel"
        Me.train_tunnel.Size = New System.Drawing.Size(200, 204)
        Me.train_tunnel.TabIndex = 19
        Me.train_tunnel.TabStop = False
        '
        'lock1
        '
        Me.lock1.Image = CType(resources.GetObject("lock1.Image"), System.Drawing.Image)
        Me.lock1.Location = New System.Drawing.Point(230, 222)
        Me.lock1.Name = "lock1"
        Me.lock1.Size = New System.Drawing.Size(64, 63)
        Me.lock1.TabIndex = 20
        Me.lock1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 296)
        Me.Controls.Add(Me.tl1)
        Me.Controls.Add(Me.tr1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.unlock1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.left)
        Me.Controls.Add(Me.right)
        Me.Controls.Add(Me.tunnel)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.train_tunnel)
        Me.Controls.Add(Me.lock1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.unlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tunnel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.r1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.l1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.train_tunnel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l1 As System.Windows.Forms.PictureBox
    Friend WithEvents r1 As System.Windows.Forms.PictureBox
    Friend WithEvents tunnel As System.Windows.Forms.PictureBox
    Friend WithEvents right As System.Windows.Forms.RadioButton
    Friend WithEvents left As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents unlock1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tr1 As System.Windows.Forms.TextBox
    Friend WithEvents tl1 As System.Windows.Forms.TextBox
    Friend WithEvents train_tunnel As System.Windows.Forms.PictureBox
    Friend WithEvents lock1 As System.Windows.Forms.PictureBox

End Class
