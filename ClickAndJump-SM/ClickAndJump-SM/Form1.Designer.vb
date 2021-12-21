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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRibbit = New System.Windows.Forms.Label()
        Me.tmrRibbet = New System.Windows.Forms.Timer(Me.components)
        Me.picFrog = New System.Windows.Forms.PictureBox()
        Me.picRoad = New System.Windows.Forms.PictureBox()
        Me.tmrArc = New System.Windows.Forms.Timer(Me.components)
        Me.ilsFrog = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.ilsFrogleft = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(71, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(659, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(477, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(275, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(839, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 5
        '
        'lblRibbit
        '
        Me.lblRibbit.AutoSize = True
        Me.lblRibbit.BackColor = System.Drawing.Color.White
        Me.lblRibbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRibbit.Location = New System.Drawing.Point(142, 209)
        Me.lblRibbit.Name = "lblRibbit"
        Me.lblRibbit.Size = New System.Drawing.Size(50, 20)
        Me.lblRibbit.TabIndex = 7
        Me.lblRibbit.Text = "Ribbit"
        Me.lblRibbit.Visible = False
        '
        'tmrRibbet
        '
        Me.tmrRibbet.Interval = 1500
        '
        'picFrog
        '
        Me.picFrog.BackColor = System.Drawing.Color.Transparent
        Me.picFrog.Image = Global.ClickAndJump_SM.My.Resources.Resources.frog0
        Me.picFrog.Location = New System.Drawing.Point(90, 241)
        Me.picFrog.Name = "picFrog"
        Me.picFrog.Size = New System.Drawing.Size(145, 108)
        Me.picFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFrog.TabIndex = 6
        Me.picFrog.TabStop = False
        '
        'picRoad
        '
        Me.picRoad.BackColor = System.Drawing.Color.Black
        Me.picRoad.Location = New System.Drawing.Point(-20, 199)
        Me.picRoad.Name = "picRoad"
        Me.picRoad.Size = New System.Drawing.Size(1012, 163)
        Me.picRoad.TabIndex = 0
        Me.picRoad.TabStop = False
        '
        'tmrArc
        '
        Me.tmrArc.Interval = 50
        '
        'ilsFrog
        '
        Me.ilsFrog.ImageStream = CType(resources.GetObject("ilsFrog.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsFrog.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsFrog.Images.SetKeyName(0, "frog0.gif")
        Me.ilsFrog.Images.SetKeyName(1, "frog1.gif")
        Me.ilsFrog.Images.SetKeyName(2, "frog1.gif")
        Me.ilsFrog.Images.SetKeyName(3, "frog1.gif")
        Me.ilsFrog.Images.SetKeyName(4, "frog2.gif")
        Me.ilsFrog.Images.SetKeyName(5, "frog2.gif")
        Me.ilsFrog.Images.SetKeyName(6, "frog2.gif")
        Me.ilsFrog.Images.SetKeyName(7, "frog3.gif")
        Me.ilsFrog.Images.SetKeyName(8, "frog3.gif")
        Me.ilsFrog.Images.SetKeyName(9, "frog3.gif")
        Me.ilsFrog.Images.SetKeyName(10, "frog4.gif")
        Me.ilsFrog.Images.SetKeyName(11, "frog4.gif")
        Me.ilsFrog.Images.SetKeyName(12, "frog4.gif")
        Me.ilsFrog.Images.SetKeyName(13, "frog5.gif")
        Me.ilsFrog.Images.SetKeyName(14, "frog5.gif")
        Me.ilsFrog.Images.SetKeyName(15, "frog5.gif")
        Me.ilsFrog.Images.SetKeyName(16, "frog0.gif")
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Interval = 25
        '
        'ilsFrogleft
        '
        Me.ilsFrogleft.ImageStream = CType(resources.GetObject("ilsFrogleft.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsFrogleft.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsFrogleft.Images.SetKeyName(0, "frog00.gif")
        Me.ilsFrogleft.Images.SetKeyName(1, "frog01.gif")
        Me.ilsFrogleft.Images.SetKeyName(2, "frog01.gif")
        Me.ilsFrogleft.Images.SetKeyName(3, "frog01.gif")
        Me.ilsFrogleft.Images.SetKeyName(4, "frog02.gif")
        Me.ilsFrogleft.Images.SetKeyName(5, "frog02.gif")
        Me.ilsFrogleft.Images.SetKeyName(6, "frog02.gif")
        Me.ilsFrogleft.Images.SetKeyName(7, "frog03.gif")
        Me.ilsFrogleft.Images.SetKeyName(8, "frog03.gif")
        Me.ilsFrogleft.Images.SetKeyName(9, "frog03.gif")
        Me.ilsFrogleft.Images.SetKeyName(10, "frog04.gif")
        Me.ilsFrogleft.Images.SetKeyName(11, "frog04.gif")
        Me.ilsFrogleft.Images.SetKeyName(12, "frog04.gif")
        Me.ilsFrogleft.Images.SetKeyName(13, "frog05.gif")
        Me.ilsFrogleft.Images.SetKeyName(14, "frog05.gif")
        Me.ilsFrogleft.Images.SetKeyName(15, "frog05.gif")
        Me.ilsFrogleft.Images.SetKeyName(16, "frog00.gif")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(984, 361)
        Me.Controls.Add(Me.lblRibbit)
        Me.Controls.Add(Me.picFrog)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picRoad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFrog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picRoad As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picFrog As PictureBox
    Friend WithEvents lblRibbit As Label
    Friend WithEvents tmrRibbet As Timer
    Friend WithEvents tmrArc As Timer
    Friend WithEvents ilsFrog As ImageList
    Friend WithEvents tmrAnimate As Timer
    Friend WithEvents ilsFrogleft As ImageList
End Class
