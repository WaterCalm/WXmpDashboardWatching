<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox_wxURL = New System.Windows.Forms.TextBox()
        Me.TextBox_Cookies = New System.Windows.Forms.TextBox()
        Me.TextBox_JsonData = New System.Windows.Forms.TextBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.DataGridView_wxData = New System.Windows.Forms.DataGridView()
        Me.序号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.时间 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer_jiange = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_2h = New System.Windows.Forms.RadioButton()
        Me.RadioButton_1h = New System.Windows.Forms.RadioButton()
        Me.RadioButton_30m = New System.Windows.Forms.RadioButton()
        Me.RadioButton_10m = New System.Windows.Forms.RadioButton()
        Me.RadioButton_1m = New System.Windows.Forms.RadioButton()
        Me.RadioButton_45s = New System.Windows.Forms.RadioButton()
        Me.RadioButton_30s = New System.Windows.Forms.RadioButton()
        Me.RadioButton_15s = New System.Windows.Forms.RadioButton()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_SysTime = New System.Windows.Forms.Label()
        Me.Label_TimeCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_OpenFile = New System.Windows.Forms.Button()
        Me.Timer_daojishi = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_xitongshijian = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Test = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button_SaveAs = New System.Windows.Forms.Button()
        Me.Label_FileState = New System.Windows.Forms.Label()
        Me.Label_FilePath = New System.Windows.Forms.Label()
        CType(Me.DataGridView_wxData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_wxURL
        '
        Me.TextBox_wxURL.Location = New System.Drawing.Point(198, 28)
        Me.TextBox_wxURL.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox_wxURL.Name = "TextBox_wxURL"
        Me.TextBox_wxURL.Size = New System.Drawing.Size(1392, 35)
        Me.TextBox_wxURL.TabIndex = 0
        Me.TextBox_wxURL.Text = "https://mp.weixin.qq.com/cgi-bin/appmsgotherinfo?appmsgidlist=2247484673&token=37" &
    "7186503&lang=zh_CN&f=json&ajax=1"
        '
        'TextBox_Cookies
        '
        Me.TextBox_Cookies.Location = New System.Drawing.Point(198, 82)
        Me.TextBox_Cookies.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox_Cookies.Multiline = True
        Me.TextBox_Cookies.Name = "TextBox_Cookies"
        Me.TextBox_Cookies.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Cookies.Size = New System.Drawing.Size(1392, 82)
        Me.TextBox_Cookies.TabIndex = 1
        Me.TextBox_Cookies.Text = resources.GetString("TextBox_Cookies.Text")
        '
        'TextBox_JsonData
        '
        Me.TextBox_JsonData.Location = New System.Drawing.Point(24, 929)
        Me.TextBox_JsonData.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox_JsonData.Multiline = True
        Me.TextBox_JsonData.Name = "TextBox_JsonData"
        Me.TextBox_JsonData.ReadOnly = True
        Me.TextBox_JsonData.Size = New System.Drawing.Size(1570, 162)
        Me.TextBox_JsonData.TabIndex = 2
        '
        'Button_Start
        '
        Me.Button_Start.Enabled = False
        Me.Button_Start.Location = New System.Drawing.Point(1466, 202)
        Me.Button_Start.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(128, 68)
        Me.Button_Start.TabIndex = 3
        Me.Button_Start.Text = "开始监测"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'DataGridView_wxData
        '
        Me.DataGridView_wxData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_wxData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.序号, Me.时间})
        Me.DataGridView_wxData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_wxData.Location = New System.Drawing.Point(24, 384)
        Me.DataGridView_wxData.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DataGridView_wxData.Name = "DataGridView_wxData"
        Me.DataGridView_wxData.RowTemplate.Height = 23
        Me.DataGridView_wxData.Size = New System.Drawing.Size(1570, 446)
        Me.DataGridView_wxData.TabIndex = 6
        '
        '序号
        '
        Me.序号.HeaderText = "序号"
        Me.序号.Name = "序号"
        Me.序号.Width = 70
        '
        '时间
        '
        Me.时间.HeaderText = "时间"
        Me.时间.Name = "时间"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "后台API链接："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "后台Cookies："
        '
        'Timer_jiange
        '
        Me.Timer_jiange.Interval = 60000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_2h)
        Me.GroupBox1.Controls.Add(Me.RadioButton_1h)
        Me.GroupBox1.Controls.Add(Me.RadioButton_30m)
        Me.GroupBox1.Controls.Add(Me.RadioButton_10m)
        Me.GroupBox1.Controls.Add(Me.RadioButton_1m)
        Me.GroupBox1.Controls.Add(Me.RadioButton_45s)
        Me.GroupBox1.Controls.Add(Me.RadioButton_30s)
        Me.GroupBox1.Controls.Add(Me.RadioButton_15s)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(60, 180)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(768, 178)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "监测间隔时长"
        '
        'RadioButton_2h
        '
        Me.RadioButton_2h.AutoSize = True
        Me.RadioButton_2h.Location = New System.Drawing.Point(612, 104)
        Me.RadioButton_2h.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_2h.Name = "RadioButton_2h"
        Me.RadioButton_2h.Size = New System.Drawing.Size(101, 28)
        Me.RadioButton_2h.TabIndex = 7
        Me.RadioButton_2h.Text = "2小时"
        Me.RadioButton_2h.UseVisualStyleBackColor = True
        '
        'RadioButton_1h
        '
        Me.RadioButton_1h.AutoSize = True
        Me.RadioButton_1h.Location = New System.Drawing.Point(612, 40)
        Me.RadioButton_1h.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_1h.Name = "RadioButton_1h"
        Me.RadioButton_1h.Size = New System.Drawing.Size(101, 28)
        Me.RadioButton_1h.TabIndex = 6
        Me.RadioButton_1h.Text = "1小时"
        Me.RadioButton_1h.UseVisualStyleBackColor = True
        '
        'RadioButton_30m
        '
        Me.RadioButton_30m.AutoSize = True
        Me.RadioButton_30m.Location = New System.Drawing.Point(420, 104)
        Me.RadioButton_30m.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_30m.Name = "RadioButton_30m"
        Me.RadioButton_30m.Size = New System.Drawing.Size(113, 28)
        Me.RadioButton_30m.TabIndex = 5
        Me.RadioButton_30m.Text = "30分钟"
        Me.RadioButton_30m.UseVisualStyleBackColor = True
        '
        'RadioButton_10m
        '
        Me.RadioButton_10m.AutoSize = True
        Me.RadioButton_10m.Location = New System.Drawing.Point(228, 104)
        Me.RadioButton_10m.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_10m.Name = "RadioButton_10m"
        Me.RadioButton_10m.Size = New System.Drawing.Size(113, 28)
        Me.RadioButton_10m.TabIndex = 4
        Me.RadioButton_10m.Text = "10分钟"
        Me.RadioButton_10m.UseVisualStyleBackColor = True
        '
        'RadioButton_1m
        '
        Me.RadioButton_1m.AutoSize = True
        Me.RadioButton_1m.Checked = True
        Me.RadioButton_1m.Location = New System.Drawing.Point(36, 104)
        Me.RadioButton_1m.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_1m.Name = "RadioButton_1m"
        Me.RadioButton_1m.Size = New System.Drawing.Size(101, 28)
        Me.RadioButton_1m.TabIndex = 3
        Me.RadioButton_1m.TabStop = True
        Me.RadioButton_1m.Text = "1分钟"
        Me.RadioButton_1m.UseVisualStyleBackColor = True
        '
        'RadioButton_45s
        '
        Me.RadioButton_45s.AutoSize = True
        Me.RadioButton_45s.Location = New System.Drawing.Point(420, 40)
        Me.RadioButton_45s.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_45s.Name = "RadioButton_45s"
        Me.RadioButton_45s.Size = New System.Drawing.Size(89, 28)
        Me.RadioButton_45s.TabIndex = 2
        Me.RadioButton_45s.Text = "45秒"
        Me.RadioButton_45s.UseVisualStyleBackColor = True
        '
        'RadioButton_30s
        '
        Me.RadioButton_30s.AutoSize = True
        Me.RadioButton_30s.Location = New System.Drawing.Point(228, 40)
        Me.RadioButton_30s.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_30s.Name = "RadioButton_30s"
        Me.RadioButton_30s.Size = New System.Drawing.Size(89, 28)
        Me.RadioButton_30s.TabIndex = 1
        Me.RadioButton_30s.Text = "30秒"
        Me.RadioButton_30s.UseVisualStyleBackColor = True
        '
        'RadioButton_15s
        '
        Me.RadioButton_15s.AutoSize = True
        Me.RadioButton_15s.Location = New System.Drawing.Point(36, 40)
        Me.RadioButton_15s.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.RadioButton_15s.Name = "RadioButton_15s"
        Me.RadioButton_15s.Size = New System.Drawing.Size(89, 28)
        Me.RadioButton_15s.TabIndex = 0
        Me.RadioButton_15s.Text = "15秒"
        Me.RadioButton_15s.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Enabled = False
        Me.Button_Stop.Location = New System.Drawing.Point(1466, 282)
        Me.Button_Stop.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(128, 68)
        Me.Button_Stop.TabIndex = 11
        Me.Button_Stop.Text = "停止监测"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label_SysTime)
        Me.GroupBox2.Controls.Add(Me.Label_TimeCount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(840, 180)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(514, 178)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label_SysTime
        '
        Me.Label_SysTime.AutoSize = True
        Me.Label_SysTime.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_SysTime.Location = New System.Drawing.Point(12, 76)
        Me.Label_SysTime.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_SysTime.Name = "Label_SysTime"
        Me.Label_SysTime.Size = New System.Drawing.Size(211, 86)
        Me.Label_SysTime.TabIndex = 3
        Me.Label_SysTime.Text = "23:59"
        '
        'Label_TimeCount
        '
        Me.Label_TimeCount.AutoSize = True
        Me.Label_TimeCount.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_TimeCount.ForeColor = System.Drawing.Color.Green
        Me.Label_TimeCount.Location = New System.Drawing.Point(280, 76)
        Me.Label_TimeCount.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_TimeCount.Name = "Label_TimeCount"
        Me.Label_TimeCount.Size = New System.Drawing.Size(115, 86)
        Me.Label_TimeCount.TabIndex = 2
        Me.Label_TimeCount.Text = "60"
        Me.Label_TimeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "系统时间"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "倒计时（秒）"
        '
        'Button_OpenFile
        '
        Me.Button_OpenFile.Location = New System.Drawing.Point(1366, 284)
        Me.Button_OpenFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button_OpenFile.Name = "Button_OpenFile"
        Me.Button_OpenFile.Size = New System.Drawing.Size(88, 66)
        Me.Button_OpenFile.TabIndex = 13
        Me.Button_OpenFile.Text = "打开文件"
        Me.Button_OpenFile.UseVisualStyleBackColor = True
        '
        'Timer_daojishi
        '
        Me.Timer_daojishi.Interval = 1000
        '
        'Timer_xitongshijian
        '
        Me.Timer_xitongshijian.Interval = 1000
        '
        'Button_Test
        '
        Me.Button_Test.Location = New System.Drawing.Point(1368, 202)
        Me.Button_Test.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button_Test.Name = "Button_Test"
        Me.Button_Test.Size = New System.Drawing.Size(86, 70)
        Me.Button_Test.TabIndex = 14
        Me.Button_Test.Text = "测试链接"
        Me.Button_Test.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 1007)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 46)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 1007)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 46)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button_SaveAs
        '
        Me.Button_SaveAs.Location = New System.Drawing.Point(1440, 847)
        Me.Button_SaveAs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button_SaveAs.Name = "Button_SaveAs"
        Me.Button_SaveAs.Size = New System.Drawing.Size(150, 46)
        Me.Button_SaveAs.TabIndex = 17
        Me.Button_SaveAs.Text = "文件另存"
        Me.Button_SaveAs.UseVisualStyleBackColor = True
        '
        'Label_FileState
        '
        Me.Label_FileState.AutoSize = True
        Me.Label_FileState.Location = New System.Drawing.Point(24, 858)
        Me.Label_FileState.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_FileState.Name = "Label_FileState"
        Me.Label_FileState.Size = New System.Drawing.Size(58, 24)
        Me.Label_FileState.TabIndex = 18
        Me.Label_FileState.Text = "空白"
        '
        'Label_FilePath
        '
        Me.Label_FilePath.AutoSize = True
        Me.Label_FilePath.Location = New System.Drawing.Point(204, 858)
        Me.Label_FilePath.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label_FilePath.Name = "Label_FilePath"
        Me.Label_FilePath.Size = New System.Drawing.Size(82, 24)
        Me.Label_FilePath.TabIndex = 19
        Me.Label_FilePath.Text = "路径："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1622, 1118)
        Me.Controls.Add(Me.Button_SaveAs)
        Me.Controls.Add(Me.Label_FilePath)
        Me.Controls.Add(Me.Label_FileState)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_Test)
        Me.Controls.Add(Me.Button_OpenFile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox_JsonData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.TextBox_Cookies)
        Me.Controls.Add(Me.TextBox_wxURL)
        Me.Controls.Add(Me.DataGridView_wxData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "微信公众号-图文数据-实时监测"
        CType(Me.DataGridView_wxData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_wxURL As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Cookies As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_JsonData As System.Windows.Forms.TextBox
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents DataGridView_wxData As System.Windows.Forms.DataGridView
    Friend WithEvents 序号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 时间 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer_jiange As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_2h As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_1h As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_30m As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_10m As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_1m As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_45s As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_30s As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_15s As System.Windows.Forms.RadioButton
    Friend WithEvents Button_Stop As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_OpenFile As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_SysTime As System.Windows.Forms.Label
    Friend WithEvents Label_TimeCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer_daojishi As System.Windows.Forms.Timer
    Friend WithEvents Timer_xitongshijian As System.Windows.Forms.Timer
    Friend WithEvents Button_Test As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button_SaveAs As System.Windows.Forms.Button
    Friend WithEvents Label_FileState As System.Windows.Forms.Label
    Friend WithEvents Label_FilePath As System.Windows.Forms.Label

End Class
