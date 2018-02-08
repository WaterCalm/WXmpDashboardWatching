Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class Form1

    Dim IsCreatCol As Boolean = False
    Dim excelFileName As String

    Function GetWXData(URL As String, Cookies As String) As String
        Dim Req As HttpWebRequest
        Req = CType(Net.WebRequest.Create(URL), HttpWebRequest)
        Req.Method = "GET"
        'Req.Headers.Add("Accept", "text/html, application/xhtml+xml, image/jxr, */*")
        'Req.Headers.Add("Accept-Encoding", "gzip, deflate, br")
        'Req.Headers.Add("Host", "mp.weixin.qq.com")
        'Req.Headers.Add("Connection", "Keep-Alive")
        Req.KeepAlive = True
        Req.Headers.Add("Cookie", Cookies)

        Dim Rep As HttpWebResponse
        Try
            Rep = CType(Req.GetResponse(), HttpWebResponse)
            Dim LoginPOSTReqReader As New StreamReader(Rep.GetResponseStream())
            Dim TheRep As String = LoginPOSTReqReader.ReadToEnd
            Return TheRep
        Catch ex As Exception
            GetWXData = ""
            MsgBox("连接失败！", , "错误")
        End Try

    End Function

    Sub daojishi()
        If RadioButton_15s.Checked = True Then
            Label_TimeCount.Text = 15
            Timer_jiange.Interval = 15000
        ElseIf RadioButton_30s.Checked = True Then
            Label_TimeCount.Text = 30
            Timer_jiange.Interval = 30000
        ElseIf RadioButton_45s.Checked = True Then
            Label_TimeCount.Text = 45
            Timer_jiange.Interval = 45000
        ElseIf RadioButton_1m.Checked = True Then
            Label_TimeCount.Text = 60
            Timer_jiange.Interval = 60000
        ElseIf RadioButton_10m.Checked = True Then
            Label_TimeCount.Text = 600
            Timer_jiange.Interval = 600000
        ElseIf RadioButton_30m.Checked = True Then
            Label_TimeCount.Text = 1800
            Timer_jiange.Interval = 1800000
        ElseIf RadioButton_1h.Checked = True Then
            Label_TimeCount.Text = 3600
            Timer_jiange.Interval = 3600000
        ElseIf RadioButton_2h.Checked = True Then
            Label_TimeCount.Text = 7200
            Timer_jiange.Interval = 7200000
        End If
    End Sub

    Public Structure appmsg_info
        Dim appmsgid As String
        Dim comment_id As String
        Dim comment_num As String
        Dim like_num As String
        Dim read_num As String
    End Structure

    Sub DoJsonWX_CreatCol(Data As String)

        Dim p As JObject = CType(JsonConvert.DeserializeObject(Data), JObject)
        Dim msgInfo As List(Of appmsg_info)
        msgInfo = JsonConvert.DeserializeObject(Of List(Of appmsg_info))(p("sent_list")(0)("appmsg_info").ToString)
        'TextBox4.Text = msgInfo(0).appmsgid & " " & msgInfo(0).comment_id & " " & msgInfo(0).comment_num & " " & msgInfo(0).like_num & " " & msgInfo(0).read_num

        If IsCreatCol = False Then
            For i = 0 To msgInfo.Count - 1
                DataGridView_wxData.Columns.Add("1", "No." & i + 1 & "  阅读 ID:" & msgInfo(i).comment_id)
                DataGridView_wxData.Columns.Add("1", "No." & i + 1 & "  点赞 ID:" & msgInfo(i).comment_id)
                DataGridView_wxData.Columns.Add("1", "No." & i + 1 & "  评论 ID:" & msgInfo(i).comment_id)
            Next
            IsCreatCol = True
        End If

    End Sub

    Sub DoJsonWX_WriteData(Data As String)

        Dim p As JObject = CType(JsonConvert.DeserializeObject(Data), JObject)
        Dim msgInfo As List(Of appmsg_info)
        msgInfo = JsonConvert.DeserializeObject(Of List(Of appmsg_info))(p("sent_list")(0)("appmsg_info").ToString)

        'DataGridView_wxData.Rows(0).Cells(0).Value() = DataGridView_wxData.RowCount
        'DataGridView_wxData.Rows(0).Cells(1).Value() = Format(DateTime.Now, "HH:mm:ss")
        Dim indexx As Integer = DataGridView_wxData.Rows.Add()
        DataGridView_wxData.Rows(indexx).Cells(0).Value = DataGridView_wxData.RowCount - 1
        DataGridView_wxData.Rows(indexx).Cells(1).Value = Format(DateTime.Now, "HH:mm:ss")

        For i = 0 To msgInfo.Count - 1
            DataGridView_wxData.Rows(indexx).Cells(i * 3 + 2).Value = msgInfo(i).read_num
            DataGridView_wxData.Rows(indexx).Cells(i * 3 + 3).Value = msgInfo(i).like_num
            DataGridView_wxData.Rows(indexx).Cells(i * 3 + 4).Value = msgInfo(i).comment_num
            'Dim RowCount As Integer = DataGridView_wxData.RowCount
            'DataGridView_wxData.Rows(0).Cells(i * 3 + 2).Value() = msgInfo(i).read_num
            'DataGridView_wxData.Rows(0).Cells(i * 3 + 3).Value() = msgInfo(i).like_num
            'DataGridView_wxData.Rows(0).Cells(i * 3 + 4).Value() = msgInfo(i).comment_num
            'DataGridView_wxData.Item(1, DataGridView1.NewRowIndex).Value = TBOld.Text
            'DataGridView_wxData.Item(1, 0).Value = msgInfo(i).read_num
        Next

        'DataGridView_wxData.Rows.Add()

        'DataGridView1.Rows.Add(DataGridView1.NewRowIndex, msgInfo(0).appmsgid, msgInfo(0).comment_id, msgInfo(0).read_num, msgInfo(0).like_num, msgInfo(0).comment_num)

    End Sub

    Function TestLink(URL As String, Cookies As String) As Boolean
        Dim TestData As String = GetWXData(URL, Cookies)
        TestLink = InStr(TestData, "appmsg_info")
    End Function

    Sub daochu()
        'Try
        Dim xlApp, xlBook, xlSheet As Object
        xlApp = CreateObject("Excel.Application")
        xlBook = xlApp.Workbooks.Add
        xlSheet = xlBook.Worksheets()
        '使工作表不可见
        xlApp.Visible = False

        '导出DataGridView中的标题  
        Dim Cols As Integer
        For Cols = 1 To DataGridView_wxData.Columns.Count
            xlApp.Cells(1, Cols) = DataGridView_wxData.Columns(Cols - 1).HeaderText
        Next

        '逐行导出DataGridView中的数据  
        Dim i As Integer

        For i = 0 To DataGridView_wxData.RowCount - 1
            Dim j As Integer
            For j = 0 To DataGridView_wxData.ColumnCount - 1
                '判断DataGridview中的数据是否导出完毕  
                If Me.DataGridView_wxData(j, i).Value Is System.DBNull.Value Then
                    xlApp.Cells(i = 2, j = 1) = ""
                Else
                    xlApp.Cells(i + 2, j + 1) = DataGridView_wxData(j, i).Value.ToString
                End If
            Next
        Next
        '定义文件名-取系统时间作为excel文件名
        Dim fileName As String = excelFileName
        'excelPath是文件路径，通过配置文件配置
        Dim flg As Boolean = xlBook.SaveAs(Directory.GetCurrentDirectory() & "\" & fileName & ".xlsx")
        If flg = True Then
            MessageBox.Show("操作成功", "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        '关闭Excel线程
        xlApp.Quit()
        xlApp = Nothing
        xlBook = Nothing
        xlSheet = Nothing
        'Catch ex As Exception
        '异常捕捉
        'LogUtil.err(ex.ToString)
        'MessageBox.Show("系统异常", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Public Function Export_Excel(ByVal dgv As DataGridView, ByVal ExFileName As String) As Boolean
        Try
            If dgv.Rows.Count <= 0 Then '如果没有记录就退出
                MessageBox.Show("没有记录可以导出", "没有可以导出的项目", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Dim ExcelAppliaction As Object
            Dim Workbook As Object
            ExcelAppliaction = CreateObject("Excel.Application")
            Workbook = ExcelAppliaction.workbooks.add()
            'For tt = 1 To 30 '30列都是文本格式------这里根据需要是否启用
            '    Workbook.worksheets(1).Columns(tt).NumberFormatLocal = "@"
            'Next
            Dim i As Integer = 0, row As Integer = 0, col As Integer = 0
            For i = 1 To dgv.Columns.Count '在第三行开始显示表头
                Workbook.worksheets(1).cells(3, i) = dgv.Columns(i - 1).HeaderCell.Value '这里的3表示从第3行开始
            Next
            Dim str(dgv.Rows.Count - 1, dgv.Columns.Count - 1) '定义一个二维数组---目的的快速导入(对于10万行以上效率惊人)
            For row = 1 To dgv.Rows.Count '循环行
                For col = 1 To dgv.Columns.Count '循环列
                    str(row - 1, col - 1) = dgv.Item(col - 1, row - 1).Value
                Next
            Next
            Workbook.worksheets(1).range("A4").Resize(dgv.Rows.Count, dgv.Columns.Count).Value = str
            Workbook.worksheets(1).Cells.EntireColumn.AutoFit() '自动列宽
            '定义文件名-取系统时间作为excel文件名
            Dim fileName As String = ExFileName
            'excelPath是文件路径，通过配置文件配置
            ExcelAppliaction.DisplayAlerts = False
            Dim flg As Boolean = Workbook.SaveAs(Directory.GetCurrentDirectory() & "\" & fileName & ".xlsx")
            ExcelAppliaction.DisplayAlerts = True
            ExcelAppliaction.visible = False '显示Excel
            ExcelAppliaction.Quit()
            Workbook = Nothing
            ExcelAppliaction = Nothing
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        excelFileName = Format(Now, "yyyyMMdd") + Format(Now, "HH:mm:ss").Replace(":", "")
        Button_Start.Enabled = False
        GroupBox1.Enabled = False
        TextBox_JsonData.Text = GetWXData(TextBox_wxURL.Text, TextBox_Cookies.Text)
        DoJsonWX_CreatCol(TextBox_JsonData.Text)
        DoJsonWX_WriteData(TextBox_JsonData.Text)
        Label_FileState.Text = "文件正在保存……"
        Export_Excel(DataGridView_wxData, excelFileName)
        Label_FilePath.Text = "路径：" & Directory.GetCurrentDirectory() & "\" & excelFileName & ".xlsx"
        Label_FileState.Text = "文件已保存"
        Label_TimeCount.ForeColor = Color.Red
        Timer_jiange.Enabled = True
        Timer_daojishi.Enabled = True
        Button_Stop.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_SysTime.Text = Format(DateTime.Now, "HH:mm")
        Timer_xitongshijian.Interval = 50
        Timer_xitongshijian.Enabled = True
        daojishi()

    End Sub

    Private Sub Timer_xitongshijian_Tick(sender As Object, e As EventArgs) Handles Timer_xitongshijian.Tick
        Label_SysTime.Text = Format(DateTime.Now, "HH:mm")

    End Sub

    Private Sub Timer_daojishi_Tick(sender As Object, e As EventArgs) Handles Timer_daojishi.Tick
        Label_TimeCount.Text -= 1
    End Sub

    Private Sub Button_Test_Click(sender As Object, e As EventArgs) Handles Button_Test.Click
        Button_Test.Enabled = False
        If TestLink(TextBox_wxURL.Text, TextBox_Cookies.Text) = True Then
            Button_Start.Enabled = True
            GroupBox1.Enabled = True
            MsgBox("测试成功！")
        Else
            Button_Start.Enabled = False
            GroupBox1.Enabled = False
            MsgBox("测试失败！")
        End If
        Button_Test.Enabled = True

    End Sub

    Private Sub RadioButton_15s_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_15s.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_30s_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_30s.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_45s_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_45s.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_1h_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_1h.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_1m_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_1m.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_10m_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_10m.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_30m_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_30m.CheckedChanged
        daojishi()
    End Sub

    Private Sub RadioButton_2h_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_2h.CheckedChanged
        daojishi()
    End Sub

    Private Sub Button_OpenFile_Click(sender As Object, e As EventArgs) Handles Button_OpenFile.Click
        Dim AppPath As String = Directory.GetCurrentDirectory() '获取应用程序的当前工作目录 
        'TextBox_JsonData.Text = AppPath
        Process.Start(AppPath) '打开当前目录 
    End Sub

    Private Sub Timer_jiange_Tick(sender As Object, e As EventArgs) Handles Timer_jiange.Tick
        Timer_daojishi.Enabled = False
        Timer_daojishi.Interval = 1000
        daojishi()
        TextBox_JsonData.Text = GetWXData(TextBox_wxURL.Text, TextBox_Cookies.Text)
        DoJsonWX_WriteData(TextBox_JsonData.Text)
        Label_FileState.Text = "文件正在保存……"
        Export_Excel(DataGridView_wxData, excelFileName)
        Label_FilePath.Text = "路径：" & Directory.GetCurrentDirectory() & "\" & excelFileName & ".xlsx"
        Label_FileState.Text = "文件已保存"
        Timer_daojishi.Enabled = True
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        Timer_daojishi.Enabled = False
        Timer_jiange.Enabled = False
        Button_Start.Enabled = True
        GroupBox1.Enabled = True
        Label_TimeCount.ForeColor = Color.Green
        daojishi()
        Button_Stop.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        excelFileName = Format(Now, "yyyyMMdd") + Format(Now, "HH:mm:ss").Replace(":", "")
        TextBox_JsonData.Text = GetWXData(TextBox_wxURL.Text, TextBox_Cookies.Text)
        DoJsonWX_CreatCol(TextBox_JsonData.Text)
        DoJsonWX_WriteData(TextBox_JsonData.Text)
        Export_Excel(DataGridView_wxData, excelFileName)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox_JsonData.Text = GetWXData(TextBox_wxURL.Text, TextBox_Cookies.Text)
        DoJsonWX_WriteData(TextBox_JsonData.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_SaveAs.Click
        Dim filename As String = excelFileName & "_另存"
        Label_FileState.Text = "文件正在保存……"
        Export_Excel(DataGridView_wxData, filename)
        Label_FilePath.Text = "路径：" & Directory.GetCurrentDirectory() & "\" & filename & ".xlsx"
        Label_FileState.Text = "文件已保存"
    End Sub
End Class
