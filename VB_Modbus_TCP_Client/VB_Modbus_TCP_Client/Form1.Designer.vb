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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_disconnect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.l_status = New System.Windows.Forms.Label()
        Me.grp_read = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_startreg = New System.Windows.Forms.TextBox()
        Me.txt_lengthreg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListregValues = New System.Windows.Forms.ListBox()
        Me.grp_write = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_writeReg = New System.Windows.Forms.TextBox()
        Me.txt_valueReg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.grp_read.SuspendLayout()
        Me.grp_write.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(65, 15)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(100, 20)
        Me.txtIp.TabIndex = 1
        Me.txtIp.Text = "127.0.0.1"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(65, 47)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "502"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PORT"
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(171, 26)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(84, 41)
        Me.btn_connect.TabIndex = 4
        Me.btn_connect.Text = "CONNECT"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_disconnect
        '
        Me.btn_disconnect.Enabled = False
        Me.btn_disconnect.Location = New System.Drawing.Point(261, 26)
        Me.btn_disconnect.Name = "btn_disconnect"
        Me.btn_disconnect.Size = New System.Drawing.Size(87, 41)
        Me.btn_disconnect.TabIndex = 5
        Me.btn_disconnect.Text = "DISCONNECT"
        Me.btn_disconnect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "STATUS : "
        '
        'l_status
        '
        Me.l_status.AutoSize = True
        Me.l_status.Location = New System.Drawing.Point(233, 84)
        Me.l_status.Name = "l_status"
        Me.l_status.Size = New System.Drawing.Size(10, 13)
        Me.l_status.TabIndex = 7
        Me.l_status.Text = "-"
        '
        'grp_read
        '
        Me.grp_read.Controls.Add(Me.ListregValues)
        Me.grp_read.Controls.Add(Me.Label6)
        Me.grp_read.Controls.Add(Me.btn_read)
        Me.grp_read.Controls.Add(Me.txt_lengthreg)
        Me.grp_read.Controls.Add(Me.Label5)
        Me.grp_read.Controls.Add(Me.txt_startreg)
        Me.grp_read.Controls.Add(Me.Label4)
        Me.grp_read.Enabled = False
        Me.grp_read.Location = New System.Drawing.Point(27, 109)
        Me.grp_read.Name = "grp_read"
        Me.grp_read.Size = New System.Drawing.Size(200, 338)
        Me.grp_read.TabIndex = 8
        Me.grp_read.TabStop = False
        Me.grp_read.Text = "Read Register Holding"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Start"
        '
        'txt_startreg
        '
        Me.txt_startreg.Location = New System.Drawing.Point(81, 24)
        Me.txt_startreg.Name = "txt_startreg"
        Me.txt_startreg.Size = New System.Drawing.Size(100, 20)
        Me.txt_startreg.TabIndex = 9
        Me.txt_startreg.Text = "0"
        '
        'txt_lengthreg
        '
        Me.txt_lengthreg.Location = New System.Drawing.Point(81, 50)
        Me.txt_lengthreg.Name = "txt_lengthreg"
        Me.txt_lengthreg.Size = New System.Drawing.Size(100, 20)
        Me.txt_lengthreg.TabIndex = 10
        Me.txt_lengthreg.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Length"
        '
        'btn_read
        '
        Me.btn_read.Location = New System.Drawing.Point(51, 76)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(87, 41)
        Me.btn_read.TabIndex = 9
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Values"
        '
        'ListregValues
        '
        Me.ListregValues.FormattingEnabled = True
        Me.ListregValues.Location = New System.Drawing.Point(74, 134)
        Me.ListregValues.Name = "ListregValues"
        Me.ListregValues.Size = New System.Drawing.Size(82, 186)
        Me.ListregValues.TabIndex = 13
        '
        'grp_write
        '
        Me.grp_write.Controls.Add(Me.btn_write)
        Me.grp_write.Controls.Add(Me.txt_valueReg)
        Me.grp_write.Controls.Add(Me.Label8)
        Me.grp_write.Controls.Add(Me.txt_writeReg)
        Me.grp_write.Controls.Add(Me.Label7)
        Me.grp_write.Enabled = False
        Me.grp_write.Location = New System.Drawing.Point(236, 109)
        Me.grp_write.Name = "grp_write"
        Me.grp_write.Size = New System.Drawing.Size(200, 338)
        Me.grp_write.TabIndex = 9
        Me.grp_write.TabStop = False
        Me.grp_write.Text = "Write single Register"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Reg Address"
        '
        'txt_writeReg
        '
        Me.txt_writeReg.Location = New System.Drawing.Point(77, 16)
        Me.txt_writeReg.Name = "txt_writeReg"
        Me.txt_writeReg.Size = New System.Drawing.Size(100, 20)
        Me.txt_writeReg.TabIndex = 1
        '
        'txt_valueReg
        '
        Me.txt_valueReg.Location = New System.Drawing.Point(77, 42)
        Me.txt_valueReg.Name = "txt_valueReg"
        Me.txt_valueReg.Size = New System.Drawing.Size(100, 20)
        Me.txt_valueReg.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Value to Write"
        '
        'btn_write
        '
        Me.btn_write.Location = New System.Drawing.Point(53, 76)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(87, 41)
        Me.btn_write.TabIndex = 14
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grp_write)
        Me.Controls.Add(Me.grp_read)
        Me.Controls.Add(Me.l_status)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_disconnect)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MODBUS TCP CLIENT"
        Me.grp_read.ResumeLayout(False)
        Me.grp_read.PerformLayout()
        Me.grp_write.ResumeLayout(False)
        Me.grp_write.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIp As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_disconnect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents l_status As Label
    Friend WithEvents grp_read As GroupBox
    Friend WithEvents ListregValues As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_read As Button
    Friend WithEvents txt_lengthreg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_startreg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grp_write As GroupBox
    Friend WithEvents btn_write As Button
    Friend WithEvents txt_valueReg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_writeReg As TextBox
    Friend WithEvents Label7 As Label
End Class
