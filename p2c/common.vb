Module common
    Enum RowType As Integer
        ResNum = 0
        Image = 1
        ImageAdopt = 2
        Comment = 3
        Res = 4
        ResAdopt = 5
        ImageName = 6
        Timestamp = 7
        Name = 8
        Mail = 9
        DateId = 10
        ResRaw = 11

        HavenCode

    End Enum

    'DataGridView1.Columns.Add("ga1", "画像選択")
    '    DataGridView1.Columns.Add("ga2", "画像採用")
    '    DataGridView1.Columns.Add("Comment", "コメント")
    '    DataGridView1.Columns.Add("Res", "レス")
    '    DataGridView1.Columns.Add("res2", "レス採用")

    ''hidden
    '    DataGridView1.Columns.Add("h1", "画像ファイル名")
    '    DataGridView1.Columns.Add("h2", "timestamp")
    '    DataGridView1.Columns.Add("h3", "name")
    '    DataGridView1.Columns.Add("h4", "mail")
    '    DataGridView1.Columns.Add("h5", "dateid")
    '    DataGridView1.Columns.Add("h6", "予備１")
    '    DataGridView1.Columns.Add("h7", "予備２")
    '    DataGridView1.Columns.Add("h8", "予備３")

    Public Function GetExeAppPath() As String
        Dim asm As System.Reflection.Assembly = _
            System.Reflection.Assembly.GetEntryAssembly()
        If asm Is Nothing Then
            Return ""
        Else
            Return System.IO.Path.GetDirectoryName(asm.Location)
        End If
    End Function
End Module
