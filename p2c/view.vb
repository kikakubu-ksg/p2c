Public Class view

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)
        '"Button"列ならば、ボタンがクリックされた
        If dgv.Columns(e.ColumnIndex).Name = "Button" Then
            '一行上に移動
            If e.RowIndex = 0 Then
                Exit Sub
            End If


            Dim item1 As New DataGridViewRow
            item1.CreateCells(DataGridView1)
            With item1
                For i As Integer = 0 To .Cells.Count - 1
                    .Cells(i).Value = dgv.Rows(e.RowIndex).Cells(i).Value
                Next


            End With

            dgv.Rows.Insert(e.RowIndex - 1, item1)
            dgv.Rows.Remove(dgv.Rows(e.RowIndex + 1))


            'MessageBox.Show((e.RowIndex.ToString() + _
            '    "行のボタンがクリックされました。"))
        End If

        If dgv.Columns(e.ColumnIndex).Name = "Button2" Then
            '一行下に移動
            If e.RowIndex >= dgv.Rows.Count - 2 Then
                Exit Sub
            End If

            Dim item1 As New DataGridViewRow
            item1.CreateCells(DataGridView1)
            With item1
                For i As Integer = 0 To .Cells.Count - 1
                    .Cells(i).Value = dgv.Rows(e.RowIndex).Cells(i).Value
                Next

            End With

            dgv.Rows.Insert(e.RowIndex + 2, item1)
            dgv.Rows.Remove(dgv.Rows(e.RowIndex))

        End If

    End Sub


    Private Sub view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '     Dim students() As CStudent = _
        '{New CStudent("123-456-789", "John"), _
        ' New CStudent("456-123-789", "Mary")}
        '     DataGridView1.DataSource = students

        '---add columns to the DataGridView control---
        DataGridView1.Columns(RowType.ResNum).HeaderText = "レス番"
        'DataGridView1.Columns.Add("ID", "ID")
        'DataGridViewImageColumnの作成
        Dim column As New DataGridViewImageColumn()
        '列の名前を設定
        column.Name = "画像"
        'Icon型ではなく、Image型のデータを表示する
        'デフォルトでFalseなので、変更する必要はない
        column.ValuesAreIcons = False
        '値の設定されていないセルに表示するイメージを設定する
        'column.Image = New Bitmap("C:\null.gif")
        'イメージを縦横の比率を維持して拡大、縮小表示する
        column.ImageLayout = DataGridViewImageCellLayout.Zoom
        'イメージの説明
        'セルをクリップボードにコピーした時に使用される
        column.Description = "画像"
        'デフォルト画像を表示せず
        column.DefaultCellStyle.NullValue = Nothing

        'DataGridViewに追加する
        DataGridView1.Columns.Add(column)

        'DataGridView1.Columns.Add("ga1", "画像選択")
        Dim imageAdoptColumn As New DataGridViewCheckBoxColumn
        imageAdoptColumn.Name = "画像採用"
        DataGridView1.Columns.Add(imageAdoptColumn)
        'DataGridView1.Columns.Add("ga2", "画像採用")
        DataGridView1.Columns.Add("Comment", "コメント")
        DataGridView1.Columns.Add("Res", "レス")
        Dim resAdoptColumn As New DataGridViewCheckBoxColumn
        resAdoptColumn.Name = "レス採用"
        DataGridView1.Columns.Add(resAdoptColumn)
        'DataGridView1.Columns.Add("res2", "レス採用")

        'hidden
        DataGridView1.Columns.Add("h1", "画像ファイル名")
        DataGridView1.Columns.Add("h2", "timestamp")
        DataGridView1.Columns.Add("h3", "name")
        DataGridView1.Columns.Add("h4", "mail")
        DataGridView1.Columns.Add("h5", "dateid")
        DataGridView1.Columns.Add("h6", "レス")
        DataGridView1.Columns.Add("h7", "予備２")
        DataGridView1.Columns.Add("h8", "予備３")

        DataGridView1.Columns(RowType.ResNum).Width = 20
        DataGridView1.Columns(RowType.Image).Width = 200
        DataGridView1.Columns(RowType.ImageAdopt).Width = 20
        DataGridView1.Columns(RowType.Comment).Width = 200
        DataGridView1.Columns(RowType.Res).Width = 200
        DataGridView1.Columns(RowType.ResAdopt).Width = 20



        ''---create a new bindingsource control---
        'Dim bindingsource As New BindingSource

        ''---add the items into the control---
        'bindingsource.Add("Type A")
        'bindingsource.Add("Type B")
        'bindingsource.Add("Type C")


        ''---create a combobox column---
        'Dim comboBoxCol As New DataGridViewComboBoxColumn

        ''---set the header---
        'comboBoxCol.HeaderText = "Types"

        ''---data bind it---

        'comboBoxCol.DataSource = bindingsource

        ''---add a combobox column to the DataGridView control---
        'DataGridView1.Columns.Add(comboBoxCol)


        'For i As Integer = 0 To 30
        '    '---create a row---

        '    Dim item As New DataGridViewRow
        '    item.CreateCells(DataGridView1)
        '    With item
        '        .Cells(0).Value = i
        '        .Cells(1).Value = "Product " & i
        '        .Cells(2).Value = "Description of " & vbCrLf & vbCrLf & "Product " & i
        '        '.Cells(3).Value = "99.99"

        '    End With
        '    '---add the row---
        '    DataGridView1.Rows.Add(item)
        'Next

        'DataGridViewButtonColumnの作成
        'Dim column As New DataGridViewButtonColumn()
        ''列の名前を設定
        'column.Name = "Button"
        ''全てのボタンに"詳細閲覧"と表示する
        'column.UseColumnTextForButtonValue = True
        'column.Text = "△"
        ''DataGridViewに追加する
        'DataGridView1.Columns.Add(column)

        'DataGridView1.Columns(6).Width = 30


        ''DataGridViewButtonColumnの作成
        'Dim column2 As New DataGridViewButtonColumn()
        ''列の名前を設定
        'column2.Name = "Button2"
        ''全てのボタンに"詳細閲覧"と表示する
        'column2.UseColumnTextForButtonValue = True
        'column2.Text = "▽"
        ''DataGridViewに追加する
        'DataGridView1.Columns.Add(column2)

        'DataGridView1.Columns(7).Width = 30

        '全ての列の背景色を水色にする
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightCyan
        '奇数行を黄色にする
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White


        ' セル内で文字列を折り返す
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' 文字列全体が表示されるように行の高さを自動調節する
        DataGridView1.AutoResizeRows()

        'DataGridView1にユーザーが新しい行を追加できないようにする
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.HeaderCell = New myDataGridViewRowHeaderCell

    End Sub



    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        ''列ヘッダーかどうか調べる
        'If e.ColumnIndex < 0 And e.RowIndex >= 0 Then
        '    'セルを描画する
        '    e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

        '    '行番号を描画する範囲を決定する
        '    'e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
        '    Dim indexRect As Rectangle = e.CellBounds
        '    indexRect.Inflate(-2, -2)
        '    '行番号を描画する
        '    TextRenderer.DrawText(e.Graphics, _
        '        (e.RowIndex + 1).ToString(), _
        '        e.CellStyle.Font, _
        '        indexRect, _
        '        e.CellStyle.ForeColor, _
        '        TextFormatFlags.Right Or TextFormatFlags.VerticalCenter)
        '    '描画が完了したことを知らせる
        '    e.Handled = True
        'End If

        ''ヘッダー以外のセルで、背景を描画する時
        'If e.ColumnIndex = 0 AndAlso e.RowIndex = 0 AndAlso _
        '    (e.PaintParts And DataGridViewPaintParts.Background) = _
        '        DataGridViewPaintParts.Background Then
        '    '背景だけを描画する
        '    Dim backParts As DataGridViewPaintParts = _
        '        e.PaintParts And (DataGridViewPaintParts.Background Or _
        '            DataGridViewPaintParts.SelectionBackground)
        '    e.Paint(e.ClipBounds, backParts)

        '    '画像をセルの範囲いっぱいに表示する
        '    'e.Graphics.DrawImage(cellBackImage, e.CellBounds)
        '    e.Graphics.DrawImage(cellBackImage, e.CellBounds.Left, e.CellBounds.Top, cellBackImage.Width, cellBackImage.Height)

        '    DataGridView1.Columns(0).MinimumWidth = cellBackImage.Width
        '    DataGridView1.Rows(e.RowIndex).MinimumHeight = cellBackImage.Height



        '    '背景以外が描画されるようにする
        '    Dim paintParts As DataGridViewPaintParts = _
        '        e.PaintParts And Not backParts
        '    'セルを描画する
        '    e.Paint(e.ClipBounds, paintParts)

        '    '描画が完了したことを知らせる
        '    e.Handled = True
        'End If


    End Sub


    ''' <summary>
    ''' 選択しているセルをひとつ上にあげる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub UpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpButton.Click

        Dim dgv As DataGridView = DataGridView1
        Dim cel As DataGridViewCell = dgv.CurrentCell

        '一行上に移動
        If cel Is Nothing Then
            MessageBox.Show("セルが選択されていません。")
            Return
        End If
        If cel.RowIndex = 0 And dgv.SelectedCells.Count > 0 Then
            Exit Sub
        End If

        Dim item1 As New DataGridViewRow
        item1.CreateCells(DataGridView1)
        With item1
            For i As Integer = 0 To .Cells.Count - 1
                .Cells(i).Value = dgv.Rows(cel.RowIndex).Cells(i).Value
            Next
        End With

        dgv.Rows.Insert(cel.RowIndex - 1, item1)
        dgv.Rows.Remove(dgv.Rows(cel.RowIndex))

        dgv.ClearSelection()
        dgv.CurrentCell = DataGridView1(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex - 2)

    End Sub

    ''' <summary>
    ''' 選択しているセルをひとつ下にさげる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownButton.Click

        Dim dgv As DataGridView = DataGridView1
        Dim cel As DataGridViewCell = dgv.CurrentCell

        '一行下に移動
        If cel Is Nothing Then
            MessageBox.Show("セルが選択されていません。")
            Return
        End If
        If cel.RowIndex >= dgv.Rows.Count - 1 And dgv.SelectedCells.Count > 0 Then
            Exit Sub
        End If

        Dim item1 As New DataGridViewRow
        item1.CreateCells(DataGridView1)
        With item1
            For i As Integer = 0 To .Cells.Count - 1
                .Cells(i).Value = dgv.Rows(cel.RowIndex).Cells(i).Value
            Next
        End With

        dgv.Rows.Insert(cel.RowIndex + 2, item1)
        dgv.Rows.Remove(dgv.Rows(cel.RowIndex))

        dgv.ClearSelection()
        dgv.CurrentCell = DataGridView1(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex + 1)
    End Sub


    Private Sub RightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightButton.Click
        '行追加
        'カレント行取得
        Dim dgv As DataGridView = DataGridView1
        Try
            Dim dgvc As DataGridViewCell = dgv.SelectedCells.Item(0)
            dgv.Rows.Insert(dgvc.RowIndex, 1)
        Catch ex As SystemException
            MessageBox.Show("行を追加できません。" & vbCrLf & ex.Message)
        End Try



    End Sub

    Private Sub RightButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles RightButton.Paint

        '表示する文字列
        Dim s As String = "▲"

        'ワールド変換行列を45度回転する
        e.Graphics.RotateTransform(90.0F)
        e.Graphics.TranslateTransform(4, -20)

        '文字列を描画
        e.Graphics.DrawString(s, Me.Font, Brushes.Black, 0, 0)

    End Sub

    Private Sub LeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftButton.Click
        '行削除
        Dim dgv As DataGridView = DataGridView1
        Try
            Dim dgvc As DataGridViewCell = dgv.SelectedCells.Item(0)
            dgv.Rows.RemoveAt(dgvc.RowIndex)
        Catch ex As SystemException
            MessageBox.Show("行を削除できません。" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub LeftButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles LeftButton.Paint
        '表示する文字列
        Dim s As String = "▼"

        'ワールド変換行列を45度回転する
        e.Graphics.RotateTransform(90.0F)
        e.Graphics.TranslateTransform(4, -20)

        '文字列を描画
        e.Graphics.DrawString(s, Me.Font, Brushes.Black, 0, 0)

    End Sub

    Private Sub PreviousImage_Click(sender As System.Object, e As System.EventArgs) Handles PreviousImage.Click
        'カレント行取得
        Dim dgv As DataGridView = DataGridView1
        Dim dgvc As DataGridViewCell
        Try
            dgvc = dgv.SelectedCells.Item(0)
        Catch ex As SystemException
            MessageBox.Show("行がありません。" & vbCrLf & ex.Message)
            Return
        End Try
        Dim currentStr As String = dgv(RowType.ImageName, dgvc.RowIndex).Value

        Dim singleton As Singleton = singleton.GetInstance()
        Dim pi As String = singleton.GetPreviousImage(GetExeAppPath() & "\tmp\" & currentStr)

        If pi Is Nothing Then Exit Sub

        '画像変更
        dgv(RowType.Image, dgvc.RowIndex).Value = New Bitmap(pi)
        'ファイル名変更
        dgv(RowType.ImageName, dgvc.RowIndex).Value = pi.Replace(GetExeAppPath() & "\tmp\", "")

    End Sub

    Private Sub NextImage_Click(sender As System.Object, e As System.EventArgs) Handles NextImage.Click
        'カレント行取得
        Dim dgv As DataGridView = DataGridView1
        Dim dgvc As DataGridViewCell
        Try
            dgvc = dgv.SelectedCells.Item(0)
        Catch ex As SystemException
            MessageBox.Show("行がありません。" & vbCrLf & ex.Message)
            Return
        End Try
        Dim currentStr As String = dgv(RowType.ImageName, dgvc.RowIndex).Value

        Dim singleton As Singleton = singleton.GetInstance()
        Dim pi As String = singleton.GetNextImage(GetExeAppPath() & "\tmp\" & currentStr)

        If pi Is Nothing Then Exit Sub

        '画像変更
        dgv(RowType.Image, dgvc.RowIndex).Value = New Bitmap(pi)
        'ファイル名変更
        dgv(RowType.ImageName, dgvc.RowIndex).Value = pi.Replace(GetExeAppPath() & "\tmp\", "")
    End Sub


    Private Sub htmloutput_Click(sender As System.Object, e As System.EventArgs) Handles htmloutput.Click
        'テキスト構築
        Dim sb As New System.Text.StringBuilder()
        Dim imageDir As String = TextBox_ImageDir.Text
        '/をとる
        imageDir = System.Text.RegularExpressions.Regex.Replace(imageDir, "/$", "")
        '画像クリア
        For Each tempFile As String In _
            System.IO.Directory.GetFiles(GetExeAppPath() & _
                                         "\htmlimg")
            System.IO.File.Delete(tempFile)
        Next
        For Each dgvr As DataGridViewRow In DataGridView1.Rows
            Dim comClass As String = "<DIV class='_comment_no_image"
            If dgvr.Cells.Item(RowType.ImageAdopt).Value = True Then
                'ファイルコピー
                System.IO.File.Copy(GetExeAppPath() & "\tmp\" & dgvr.Cells.Item(RowType.ImageName).Value, _
                                    GetExeAppPath() & "\htmlimg\" & dgvr.Cells.Item(RowType.ImageName).Value, _
                                    True)
                'image
                sb.Append("<DIV class='_image'><IMG SRC='").Append(imageDir).Append("/").Append(dgvr.Cells.Item(RowType.ImageName).Value).Append("' /></DIV>").Append(vbCrLf)
                comClass = "<DIV class='_comment_with_image"
            End If
            'comment
            If dgvr.Cells.Item(RowType.Comment).Value <> "" Then
                sb.Append(comClass).Append(" " & dgvr.Cells.Item(RowType.Comment).Tag & "'>").Append(dgvr.Cells.Item(RowType.Comment).Value).Append("</DIV>").Append(vbCrLf)
            End If
            If dgvr.Cells.Item(RowType.ResAdopt).Value = True Then
                'ress
                sb.Append("<DIV class='_reshead'><span class='_resnum " & dgvr.Cells.Item(RowType.ResNum).Tag & "'>").Append(IIf(RowType.HavenCode = 1, "<span class='_havenmark'>避</span>", "")).Append(dgvr.Cells.Item(RowType.ResNum).Value).Append("</span>") _
                    .Append("<span class='_name " & dgvr.Cells.Item(RowType.Name).Tag & "'>").Append(dgvr.Cells.Item(RowType.Name).Value).Append("</span>") _
                    .Append("<span class='_dateid " & dgvr.Cells.Item(RowType.DateId).Tag & "'>").Append(dgvr.Cells.Item(RowType.DateId).Value).Append("</span>") _
                    .Append("</DIV>").Append(vbCrLf)
                Dim t As String = dgvr.Cells.Item(RowType.ResRaw).Value
                sb.Append("<DIV class='_res " & dgvr.Cells.Item(RowType.ResRaw).Tag & "'>").Append(t.Replace(vbCrLf, "<br />")).Append("</DIV>").Append(vbCrLf)
            End If

        Next

        'テキスト出力
        Dim sw As New System.IO.StreamWriter(GetExeAppPath() & "\hoge.html", _
            False, _
            System.Text.Encoding.GetEncoding("utf-8"))
        sw.Write(sb.ToString)
        '閉じる
        sw.Close()

        'htmlを開く
        System.Diagnostics.Process.Start(GetExeAppPath() & "\hoge.html")

    End Sub

    Private Sub PreviousImageAll_Click(sender As System.Object, e As System.EventArgs) Handles PreviousImageAll.Click
        Dim dgv As DataGridView = DataGridView1
        For Each dgvr As DataGridViewRow In dgv.Rows
            Dim currentStr As String = dgv(RowType.ImageName, dgvr.Index).Value

            Dim singleton As Singleton = singleton.GetInstance()
            Dim pi As String = singleton.GetPreviousImage(GetExeAppPath() & "\tmp\" & currentStr)

            If Not (pi Is Nothing) Then
                '画像変更
                dgv(RowType.Image, dgvr.Index).Value = New Bitmap(pi)
                'ファイル名変更
                dgv(RowType.ImageName, dgvr.Index).Value = pi.Replace(GetExeAppPath() & "\tmp\", "")
            End If
        Next
    End Sub

    Private Sub NextImageAll_Click(sender As System.Object, e As System.EventArgs) Handles NextImageAll.Click
        Dim dgv As DataGridView = DataGridView1
        For Each dgvr As DataGridViewRow In dgv.Rows
            Dim currentStr As String = dgv(RowType.ImageName, dgvr.Index).Value

            Dim singleton As Singleton = singleton.GetInstance()
            Dim pi As String = singleton.GetNextImage(GetExeAppPath() & "\tmp\" & currentStr)

            If Not (pi Is Nothing) Then
                '画像変更
                dgv(RowType.Image, dgvr.Index).Value = New Bitmap(pi)
                'ファイル名変更
                dgv(RowType.ImageName, dgvr.Index).Value = pi.Replace(GetExeAppPath() & "\tmp\", "")
            End If
        Next
    End Sub

    Private Sub Button_Normal_Click(sender As System.Object, e As System.EventArgs) Handles Button_Normal.Click
        For Each c As DataGridViewCell In DataGridView1.SelectedCells
            c.Tag = ""
            c.Style.BackColor = SystemColors.Control
        Next c

    End Sub

    Private Sub Button_EX1_Click(sender As System.Object, e As System.EventArgs) Handles Button_EX1.Click
        For Each c As DataGridViewCell In DataGridView1.SelectedCells
            c.Tag = "ex1"
            c.Style.BackColor = Color.FromArgb(255, 128, 128)
        Next c
    End Sub

    Private Sub Button_EX2_Click(sender As System.Object, e As System.EventArgs) Handles Button_EX2.Click
        For Each c As DataGridViewCell In DataGridView1.SelectedCells
            c.Tag = "ex2"
            c.Style.BackColor = Color.FromArgb(128, 128, 255)
        Next c
    End Sub

    Private Sub Button_EX3_Click(sender As System.Object, e As System.EventArgs) Handles Button_EX3.Click
        For Each c As DataGridViewCell In DataGridView1.SelectedCells
            c.Tag = "ex3"
            c.Style.BackColor = Color.Yellow
        Next c
    End Sub

End Class

'Public Class CStudent
'    Private _name As String
'    Private _ID As String

'    Public Sub New(ByVal id As String, ByVal name As String)
'        _ID = id
'        _name = name
'    End Sub

'    Public Property Name() As String
'        Get
'            Return _name
'        End Get

'        Set(ByVal value As String)
'            _name = value
'        End Set
'    End Property

'    Public Property ID() As String
'        Get
'            Return _ID
'        End Get

'        Set(ByVal value As String)
'            _ID = value
'        End Set
'    End Property

'End Class


'Public Class CStringItem
'    Private _str As String
'    Public Sub New(ByVal str As String)
'        _str = str
'    End Sub

'    Public Property Name() As String
'        Get
'            Return _str
'        End Get

'        Set(ByVal value As String)
'            _str = value
'        End Set
'    End Property

'End Class



Public Class myDataGridViewRowHeaderCell
    Inherits DataGridViewRowHeaderCell

    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts And Not DataGridViewPaintParts.ContentBackground)
    End Sub

End Class

Public Class Singleton

    Private Shared _singleton As Singleton = New Singleton()
    Private files As String()

    ' コンストラクタです。(外部からのアクセス不可)
    Private Sub New()
        Console.WriteLine("インスタンスを生成しました。")
        'ファイル配列取得
        files = System.IO.Directory.GetFiles( _
            GetExeAppPath() & "\tmp", "*")
        'ソート
        Array.Sort(files)
    End Sub

    ' 唯一のインスタンスを取得します。
    Public Shared Function GetInstance() As Singleton
        ' Console.WriteLine("return singleton.")
        Return _singleton
    End Function

    '配列を返却
    Public Function GetArray() As String()
        Return files
    End Function

    '前画像
    Public Function GetPreviousImage(currentStr As String) As String
        'インデックスを探す
        Dim index = Array.IndexOf(files, currentStr)

        If index > 0 Then
            '前画像返却
            Return files(index - 1)
        Else
            Return Nothing
        End If

    End Function

    '後画像
    Public Function GetNextImage(currentStr As String) As String
        'インデックスを探す
        Dim index = Array.IndexOf(files, currentStr)

        If index <> -1 And index < files.Length - 1 Then
            '前画像返却
            Return files(index + 1)
        Else
            Return Nothing
        End If
    End Function

    '再取得
    Public Shared Function ReGetInstance() As Singleton
        _singleton = New Singleton
        Console.WriteLine("インスタンスを生成しました。")
        'ファイル配列取得
        _singleton.files = System.IO.Directory.GetFiles( _
            GetExeAppPath() & "\tmp", "*")
        'ソート
        Array.Sort(_singleton.files)
        Return _singleton
    End Function

End Class

'memo
'IMG行かTXT行かで上下移動の処理を変える。
'行コピー機能が必要？
'ソース直修モードもほしい

'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
















