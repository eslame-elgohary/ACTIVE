<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REG
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REG))
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBoxAct = New System.Windows.Forms.TextBox()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ACT1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SERIAL_NUMBER_G = New DevExpress.XtraEditors.SimpleButton()
        Me.NOTSTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CONTXT = New System.Windows.Forms.TextBox()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.BTNEW = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(141, 87)
        Me.TextBoxId.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxId.Multiline = True
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(507, 37)
        Me.TextBoxId.TabIndex = 0
        Me.TextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(476, 424)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 55)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "ACTIVE"
        '
        'TextBoxAct
        '
        Me.TextBoxAct.Location = New System.Drawing.Point(141, 139)
        Me.TextBoxAct.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxAct.Multiline = True
        Me.TextBoxAct.Name = "TextBoxAct"
        Me.TextBoxAct.Size = New System.Drawing.Size(507, 53)
        Me.TextBoxAct.TabIndex = 2
        Me.TextBoxAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(141, 202)
        Me.TextBoxUser.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxUser.Multiline = True
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(507, 53)
        Me.TextBoxUser.TabIndex = 3
        Me.TextBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(651, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Serial Key User :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(656, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Active User :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(656, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name User :"
        '
        'ACT1
        '
        Me.ACT1.AutoSize = True
        Me.ACT1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACT1.Location = New System.Drawing.Point(240, 9)
        Me.ACT1.Name = "ACT1"
        Me.ACT1.Size = New System.Drawing.Size(355, 30)
        Me.ACT1.TabIndex = 7
        Me.ACT1.Text = "ACTIVE DOCTOR CLINIC PROUDCT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(174, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(443, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Record customer data and activate the program for them"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(699, 424)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(103, 55)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "CLOSE"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(31, 87)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(5)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(100, 37)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "PAST"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SERIAL_NUMBER_G
        '
        Me.SERIAL_NUMBER_G.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SERIAL_NUMBER_G.Appearance.Options.UseFont = True
        Me.SERIAL_NUMBER_G.ImageOptions.Image = CType(resources.GetObject("SERIAL_NUMBER_G.ImageOptions.Image"), System.Drawing.Image)
        Me.SERIAL_NUMBER_G.Location = New System.Drawing.Point(11, 424)
        Me.SERIAL_NUMBER_G.Margin = New System.Windows.Forms.Padding(5)
        Me.SERIAL_NUMBER_G.Name = "SERIAL_NUMBER_G"
        Me.SERIAL_NUMBER_G.Size = New System.Drawing.Size(245, 55)
        Me.SERIAL_NUMBER_G.TabIndex = 11
        Me.SERIAL_NUMBER_G.Text = "Serial Number Generation"
        '
        'NOTSTXT
        '
        Me.NOTSTXT.Location = New System.Drawing.Point(141, 268)
        Me.NOTSTXT.Multiline = True
        Me.NOTSTXT.Name = "NOTSTXT"
        Me.NOTSTXT.Size = New System.Drawing.Size(507, 97)
        Me.NOTSTXT.TabIndex = 12
        Me.NOTSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(655, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nots For User :"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(31, 139)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(5)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(100, 40)
        Me.SimpleButton5.TabIndex = 14
        Me.SimpleButton5.Text = "COPY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label6.Location = New System.Drawing.Point(656, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Contract Number :"
        '
        'CONTXT
        '
        Me.CONTXT.Location = New System.Drawing.Point(141, 380)
        Me.CONTXT.Margin = New System.Windows.Forms.Padding(5)
        Me.CONTXT.Name = "CONTXT"
        Me.CONTXT.Size = New System.Drawing.Size(507, 29)
        Me.CONTXT.TabIndex = 16
        Me.CONTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(587, 424)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(102, 55)
        Me.SimpleButton4.TabIndex = 17
        Me.SimpleButton4.Text = "Search"
        '
        'BTNEW
        '
        Me.BTNEW.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNEW.Appearance.Options.UseFont = True
        Me.BTNEW.ImageOptions.Image = CType(resources.GetObject("BTNEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTNEW.Location = New System.Drawing.Point(266, 424)
        Me.BTNEW.Margin = New System.Windows.Forms.Padding(5)
        Me.BTNEW.Name = "BTNEW"
        Me.BTNEW.Size = New System.Drawing.Size(87, 55)
        Me.BTNEW.TabIndex = 18
        Me.BTNEW.Text = "NEW"
        '
        'EDITBTN
        '
        Me.EDITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EDITBTN.Appearance.Options.UseFont = True
        Me.EDITBTN.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.EDITBTN.Location = New System.Drawing.Point(371, 424)
        Me.EDITBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.EDITBTN.Name = "EDITBTN"
        Me.EDITBTN.Size = New System.Drawing.Size(91, 55)
        Me.EDITBTN.TabIndex = 19
        Me.EDITBTN.Text = "EDIT"
        '
        'REG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(814, 490)
        Me.Controls.Add(Me.EDITBTN)
        Me.Controls.Add(Me.BTNEW)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.CONTXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NOTSTXT)
        Me.Controls.Add(Me.SERIAL_NUMBER_G)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ACT1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.TextBoxAct)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TextBoxId)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "REG"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة تسجيل البرنامج"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBoxAct As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ACT1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SERIAL_NUMBER_G As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NOTSTXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents CONTXT As TextBox
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTNEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
End Class
