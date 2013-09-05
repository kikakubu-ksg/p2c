Public Class main

    Public ExecPath As String = System.IO.Path.GetDirectoryName( _
        System.Reflection.Assembly.GetExecutingAssembly().Location)

    '編集フォーム
    Public Form As view = New view

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '初期化
        Button_Exec.Enabled = False
        CheckBox_Dat.Checked = My.Settings.DAT_Check
        If CheckBox_Dat.Checked = False Then
            GroupBox_DAT.Enabled = False
            Button_Exec.Enabled = True
        End If
        CheckBox_Asf.Checked = My.Settings.ASF_Check
        If CheckBox_Asf.Checked = False Then
            GroupBox_Asf.Enabled = False
            Button_Exec.Enabled = True
        End If
        If My.Settings.ASF_StartTimeRadio = 1 Then
            RadioButton_StartTimeNum.Checked = True
            TextBox_StartTimeSet.Enabled = False
        Else
            RadioButton_StartTimeSet.Checked = True
        End If
        If My.Settings.ASF_EndTimeRadio = 1 Then
            RadioButton_EndTimeSaveTime.Select()
            TextBox_EndTimeSet.Enabled = False
        Else
            RadioButton_EndTimeSet.Select()
        End If
        If My.Settings.ASF_ImageRadio = 1 Then
            RadioButton_ImageNormal.Select()
            TextBox_ImageSetHeight.Enabled = False
            TextBox_ImageSetWidth.Enabled = False
        Else
            RadioButton_ImageSet.Select()
        End If
        TextBox_ImageSetHeight.Text = My.Settings.ASF_ImageHeight
        TextBox_ImageSetWidth.Text = My.Settings.ASF_ImageWidth

        TextBox_CoverSetSec.Text = My.Settings.ASF_CoverSec

        TextBox_DatUseNumStart.Text = 1
        TextBox_DatUseNumEnd.Text = 50

        DataGridView_Log.RowHeadersVisible = False

        '編集フォーム
        Form.Visible = True


    End Sub

    Private Sub TextBox_ImageSetWidth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_ImageSetWidth.Validating
        If Not IsNumeric(TextBox_ImageSetWidth.Text) And Not TextBox_ImageSetWidth.Text = "" Then
            MsgBox("数値のみ入力可能です。", MsgBoxStyle.Information)
            e.Cancel = True
        Else
            My.Settings.ASF_ImageWidth = TextBox_ImageSetWidth.Text
        End If

    End Sub

    Private Sub TextBox_ImageSetHeight_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_ImageSetHeight.Validating
        If Not IsNumeric(TextBox_ImageSetHeight.Text) And Not TextBox_ImageSetHeight.Text = "" Then
            MsgBox("数値のみ入力可能です。", MsgBoxStyle.Information)
            e.Cancel = True
        Else
            My.Settings.ASF_ImageHeight = TextBox_ImageSetHeight.Text
        End If
    End Sub

    Private Sub TextBox_CoverSetSec_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_CoverSetSec.Validating
        If Not IsNumeric(TextBox_CoverSetSec.Text) And Not TextBox_CoverSetSec.Text = "" Then
            MsgBox("数値のみ入力可能です。", MsgBoxStyle.Information)
            e.Cancel = True
        Else
            My.Settings.ASF_CoverSec = TextBox_CoverSetSec.Text
        End If
    End Sub

    Private Sub TextBox_DatUseNumStart_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_DatUseNumStart.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch( _
        TextBox_DatUseNumStart.Text, "^[0123456789]*$") _
        Then
            MsgBox("数値のみ入力可能です。", MsgBoxStyle.Information)
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub RadioButton_StartTimeNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_StartTimeNum.CheckedChanged
        If RadioButton_StartTimeNum.Checked Then
            My.Settings.ASF_StartTimeRadio = 1
            TextBox_StartTimeSet.Enabled = False
        End If
    End Sub

    Private Sub RadioButton_StartTimeSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_StartTimeSet.CheckedChanged
        If RadioButton_StartTimeSet.Checked Then
            My.Settings.ASF_StartTimeRadio = 2
            TextBox_StartTimeSet.Enabled = True
        End If
    End Sub

    Private Sub RadioButton_EndTimeSaveTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_EndTimeSaveTime.CheckedChanged
        If RadioButton_EndTimeSaveTime.Checked Then
            My.Settings.ASF_EndTimeRadio = 1
            TextBox_EndTimeSet.Enabled = False
        End If
    End Sub

    Private Sub RadioButton_EndTimeSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_EndTimeSet.CheckedChanged
        If RadioButton_EndTimeSet.Checked Then
            My.Settings.ASF_EndTimeRadio = 2
            TextBox_EndTimeSet.Enabled = True
        End If
    End Sub

    Private Sub RadioButton_ImageNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_ImageNormal.CheckedChanged
        If RadioButton_ImageNormal.Checked Then
            My.Settings.ASF_ImageRadio = 1
            TextBox_ImageSetHeight.Enabled = False
            TextBox_ImageSetWidth.Enabled = False
        End If
    End Sub

    Private Sub RadioButton_ImageSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_ImageSet.CheckedChanged
        If RadioButton_ImageSet.Checked Then
            My.Settings.ASF_ImageRadio = 2
            TextBox_ImageSetHeight.Enabled = True
            TextBox_ImageSetWidth.Enabled = True
        End If
    End Sub

    Private Sub CheckBox_Dat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Dat.CheckedChanged
        If CheckBox_Dat.Checked Then
            My.Settings.DAT_Check = True
            GroupBox_DAT.Enabled = True
            Button_Exec.Enabled = True
        Else
            My.Settings.DAT_Check = False
            GroupBox_DAT.Enabled = False
            If CheckBox_Asf.Checked = False Then
                Button_Exec.Enabled = False
            End If

        End If
    End Sub

    Private Sub CheckBox_Asf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Asf.CheckedChanged
        If CheckBox_Asf.Checked Then
            My.Settings.ASF_Check = True
            GroupBox_Asf.Enabled = True
            Button_Exec.Enabled = True
        Else
            My.Settings.ASF_Check = False
            GroupBox_Asf.Enabled = False
            If CheckBox_Dat.Checked = False Then
                Button_Exec.Enabled = False
            End If
        End If
    End Sub


    'Private Sub TextBox_StartTimeSet_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_StartTimeSet.Validating
    '    If Not TimeValidation(TextBox_StartTimeSet.Text) Then
    '        e.Cancel = True
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub TextBox_EndTimeSet_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_EndTimeSet.Validating
    '    If Not TimeValidation(TextBox_EndTimeSet.Text) Then
    '        e.Cancel = True
    '        Exit Sub
    '    End If
    'End Sub

    Public Function TimeValidation(ByRef TimeString As String) As Boolean
        Dim formattedText As String
        If TimeString = "" Then
            Return True
        End If

        formattedText = System.Text.RegularExpressions.Regex.Replace( _
                 TimeString, "^.*?(\d{4})[-/]?(\d{2})[-/]?(\d{2}) ?(\d{2})[:-]?(\d{2})[:-]?(\d{2}).*$", _
                 "$1-$2-$3 $4:$5:$6")

        If Not System.Text.RegularExpressions.Regex.IsMatch( _
         formattedText, "^\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}$") _
         Then
            MsgBox("yyyy-mm-dd hh:mm:ss形式で入力してください。", MsgBoxStyle.Information)
            Return False
        End If

        TimeString = formattedText

        If Not IsDate(formattedText) Then
            MsgBox("日付が不正です。", MsgBoxStyle.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub Button_DatPathRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DatPathRef.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき
            '選択されたファイル名を表示する
            TextBox_DatPath.Text = OpenFileDialog1.FileName
        End If

    End Sub
    Private Sub Button_AsfPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AsfPath.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき
            '選択されたファイル名を表示する
            TextBox_AsfPath.Text = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub TextBox_DatPath_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_DatPath.DragDrop
        FileDragDrop(sender, e)
    End Sub

    Private Sub TextBox_DatPath_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_DatPath.DragEnter
        FileDragEnter(e)
    End Sub

    Private Sub TextBox_AsfPath_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_AsfPath.DragDrop
        FileDragDrop(sender, e)
    End Sub

    Private Sub TextBox_AsfPath_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox_AsfPath.DragEnter
        FileDragEnter(e)
    End Sub
    Private Sub TextBox_OutputTempPath_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        FileDragDrop(sender, e)
    End Sub

    Private Sub TextBox_OutputTempPath_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        FileDragEnter(e)
    End Sub

    Public Sub FileDragDrop(ByVal sender As Object, ByRef e As System.EventArgs)
        Dim ev As System.Windows.Forms.DragEventArgs = CType(e, DragEventArgs)
        Dim fileName As String() = CType( _
                       ev.Data.GetData(DataFormats.FileDrop, False), _
                       String())
        Dim tb As TextBox = CType(sender, TextBox)
        tb.Text = fileName(0)
    End Sub

    Public Sub FileDragEnter(ByRef e As System.EventArgs)
        Dim ev As System.Windows.Forms.DragEventArgs = CType(e, DragEventArgs)
        If ev.Data.GetDataPresent(DataFormats.FileDrop) Then
            'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            ev.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受け付けない
            ev.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Button_Exec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Exec.Click
        'Debug.Print("\ffmpeg\ffmpeg.exe", " -i """ & TextBox_AsfPath.Text & _
        '""" -an -ss 00:00:00 -r " & TextBox_CoverSetSec.Text & " """ & _
        'System.Windows.Forms.Application.StartupPath & "\tmp\image%08d.jpg""")

        Dim i As Double
        Try
            i = Double.Parse(TextBox_CoverSetSec.Text)
        Catch
            i = 1
        End Try
        '画像クリア
        For Each tempFile As String In _
            System.IO.Directory.GetFiles(GetExeAppPath() & _
                                         "\tmp")
            System.IO.File.Delete(tempFile)
        Next
        i = 1 / i

        Process.Start(System.Windows.Forms.Application.StartupPath & "\ffmpeg\ffmpeg.exe", " -i """ & TextBox_AsfPath.Text & _
        """ -an -ss 00:00:00 -r " & i & " -threads " & Environment.ProcessorCount.ToString() & " """ & _
        System.Windows.Forms.Application.StartupPath & "\tmp\image%08d.jpg""")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ファイル読み込み
        ' StreamReader の新しいインスタンスを生成する
        Dim cReader
        Dim cReaderH = Nothing

        Try
            cReader = New System.IO.StreamReader(TextBox_DatPath.Text, System.Text.Encoding.Default)
            If TextBox_DatPath_Haven.Text <> "" Then
                cReaderH = New System.IO.StreamReader(TextBox_DatPath_Haven.Text, System.Text.Encoding.Default)
            End If
        Catch
            MessageBox.Show("datファイルが読み込めませんでした。", _
                "エラー", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Exit Sub
        Finally

        End Try


        ' 読み込んだ結果をすべて格納するための変数を宣言する
        Dim stResult As String = String.Empty

        ' オブジェクト配列
        Dim list As New List(Of Response)
        Dim i As Integer = 0

        ''本スレ
        ' 読み込みできる文字がなくなるまで繰り返す
        Try
            While (cReader.Peek() >= 0)
                i = i + 1
                ' ファイルを 1 行ずつ読み込む
                Dim stBuffer As String = cReader.ReadLine()
                If i < Integer.Parse(IIf(TextBox_DatUseNumStart.Text, TextBox_DatUseNumStart.Text, 0)) Then
                    Continue While
                End If
                If i > Integer.Parse(IIf(TextBox_DatUseNumEnd.Text, TextBox_DatUseNumEnd.Text, 0)) Then
                    Exit While
                End If

                Dim stArrayData As String() = Split(stBuffer, "<>", -1, CompareMethod.Binary)
                Dim res As New Response
                res.name = stArrayData(0)
                res.mail = stArrayData(1)
                res.res = System.Text.RegularExpressions.Regex.Replace( _
                            stArrayData(3), "<br>", vbCrLf)
                res.dateid = stArrayData(2)
                res.resnum = i
                res.havencode = 0

                res.datetime = DateTime.Parse(System.Text.RegularExpressions.Regex.Replace( _
                    res.dateid, "^(\d{4}/\d{2}/\d{2})\(.\) (\d{2}:\d{2}:\d{2}).*$", "$1 $2"))

                'Debug.Print(res.dateid)

                '格納
                list.Add(res)
            End While
        Catch
            MessageBox.Show("本スレdat読み込みでエラーが発生しました。", _
                "エラー", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Exit Sub

        Finally
            ' cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
            cReader.Close()
        End Try

        ''避難所
        Dim h As Integer = 0
        Try
            If TextBox_DatPath_Haven.Text <> "" Then
                While (cReaderH.Peek() >= 0)
                    h = h + 1
                    ' ファイルを 1 行ずつ読み込む
                    Dim stBuffer As String = cReaderH.ReadLine()
                    If h < Integer.Parse(IIf(TextBox_DatUseNumStart_Haven.Text, TextBox_DatUseNumStart_Haven.Text, 0)) Then
                        Continue While
                    End If
                    If h > Integer.Parse(IIf(TextBox_DatUseNumEnd_Haven.Text, TextBox_DatUseNumEnd_Haven.Text, 0)) Then
                        Exit While
                    End If

                    Dim stArrayData As String() = Split(stBuffer, "<>", -1, CompareMethod.Binary)
                    Dim res As New Response
                    res.name = stArrayData(1)
                    res.mail = stArrayData(2)
                    res.res = System.Text.RegularExpressions.Regex.Replace( _
                                stArrayData(4), "<br>", vbCrLf)
                    res.dateid = stArrayData(3) & " ID:" & stArrayData(6)
                    res.resnum = Integer.Parse(stArrayData(0))
                    res.havencode = 1

                    res.datetime = DateTime.Parse(System.Text.RegularExpressions.Regex.Replace( _
                        res.dateid, "^(\d{4}/\d{2}/\d{2})\(.\) (\d{2}:\d{2}:\d{2}).*$", "$1 $2"))

                    'Debug.Print(res.dateid)

                    '格納
                    list.Add(res)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("避難所dat読み込みでエラーが発生しました。", _
                "エラー", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Exit Sub

        Finally

            ' cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
            cReaderH.Close()
        End Try
        'ソートby dateid
        Dim comp As New ResponseComparer()
        list.Sort(comp)
        'Debug.Print(list.ToString)

        'tmpフォルダを参照して配列取得
        Dim singleton As Singleton = singleton.GetInstance()
        Dim files As String() = singleton.GetArray
        Dim firstFlag As Boolean = False
        Dim baseTick As Long = 0L

        '画面表示
        Dim DataGridView1 As DataGridView = Form.DataGridView1
        For j As Integer = 0 To list.Count - 1
            '---create a row---

            Dim item As New DataGridViewRow
            item.CreateCells(DataGridView1)

            'レス時刻を秒に直す
            Dim tick As Long = DateTime.Parse(list(j).datetime).ToLocalTime.Ticks

            If TextBox_LiveStartTime.Text <> "" Then
                Try
                    baseTick = DateTime.Parse(list(j).datetime).ToLocalTime.Ticks
                Catch
                    baseTick = 0L
                End Try

            End If

            If baseTick = 0 And firstFlag = False Then
                baseTick = tick
                firstFlag = True
            End If

            '基準時刻との差分を出す
            Dim coversec = 1
            If TextBox_CoverSetSec.Text <> "" Then
                Try
                    coversec = Integer.Parse(TextBox_CoverSetSec.Text)
                Catch
                    coversec = 1
                End Try
            End If
            Dim sec As Long = (tick - baseTick) / (10000000 * coversec)

            '配列内の秒に収まれば割り付け、ない場合は最初か最後
            Dim imgname As String = String.Empty
            If sec < files.Length Then
                imgname = String.Format("image{0:00000000}.jpg", sec + 1)
            Else
                imgname = String.Format("image{0:00000000}.jpg", files.Length)
            End If


            With item
                .Cells(RowType.ResNum).Value = list(j).resnum
                .Cells(RowType.Image).Value = New Bitmap(GetExeAppPath() & "\tmp\" & imgname)
                .Cells(RowType.ImageAdopt).Value = True
                .Cells(RowType.Res).Value = list(j).name & " " & list(j).dateid & vbCrLf & list(j).res
                .Cells(RowType.ResAdopt).Value = True
                .Cells(RowType.ImageName).Value = imgname
                .Cells(RowType.Timestamp).Value = list(j).datetime
                .Cells(RowType.Name).Value = list(j).name
                .Cells(RowType.Mail).Value = list(j).mail
                .Cells(RowType.DateId).Value = list(j).dateid
                .Cells(RowType.ResRaw).Value = list(j).res
                .Cells(RowType.HavenCode).Value = list(j).havencode

            End With
            '---add the row---
            DataGridView1.Rows.Add(item)
        Next


        Form.Focus()

    End Sub

    Private Sub TabPage_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage_Config.Click

    End Sub

    Private Sub TextBox_LiveStartTime_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox_LiveStartTime.Validating
        If Not TimeValidation(TextBox_LiveStartTime.Text) Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub Button_DatPathRef_Haven_Click(sender As System.Object, e As System.EventArgs) Handles Button_DatPathRef_Haven.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき
            '選択されたファイル名を表示する
            TextBox_DatPath_Haven.Text = OpenFileDialog1.FileName
        End If
    End Sub

    '並び替える方法を定義するクラス
    'IComparerインターフェイスを実装する
    Public Class ResponseComparer
        Implements System.Collections.IComparer

        'xがyより小さいときはマイナスの数、大きいときはプラスの数、同じときは0を返す
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements System.Collections.IComparer.Compare

            'Nothingが最も小さいとする
            If x Is Nothing AndAlso y Is Nothing Then
                Return 0
            End If
            If x Is Nothing Then
                Return -1
            End If
            If y Is Nothing Then
                Return 1
            End If

            'String型以外の比較はエラー
            If Not (TypeOf x Is Response) Then
                Throw New ArgumentException("Response型でなければなりません。", "x")
            ElseIf Not (TypeOf y Is Response) Then
                Throw New ArgumentException("Response型でなければなりません。", "y")
            End If

            '文字列の長さを比較する
            Return DirectCast(x, Response).datetime.CompareTo(DirectCast(y, Response).datetime)
            'または、次のようにもできる
            'Return DirectCast(x, String).Length - DirectCast(y, String).Length
        End Function
    End Class

End Class


'Base Design
'機能設計
'Form初期化


'○XML読み込み／設定処理→My.settingsを使う 済
'・XMLファイルから保存してある設定値を読み込む
'・値をmainに適用
'

'○main初期化 済
'・Const値設定
'・ログテーブル初期化 済
'
'
'画面機能
'○DATチェックボックス選択時処理 済
'DATボックス選択時（オフ）デフォルトはオン
'・DATパネル要素をすべて非アクティブにする
'・PEGチェックがオフの場合、実行ボタンを非アクティブにする
'
'DATボックス選択時（オン） 済
'・DATパネル要素をすべてアクティブにする
'・実行ボタンをアクティブにする
'
'○DATパス入力処理 済
'・参照ボタン押下時、OpenFileDialogを開いて選択
'・バリデーションはなし。
'
'○DATナンバー入力時処理 済
'・バリデーション。数値、-,以外は不許可
'
'

'○PEGチェックボックス選択時処理 済
'PEGボックス選択時（オフ）デフォルトはオン
'・PEGパネル要素をすべて非アクティブにする
'・DATチェックがオフの場合、実行ボタンを非アクティブにする
'
'PEGボックス選択時（オン） 済
'・PEGパネル要素をすべてアクティブにする
'・実行ボタンをアクティブにする
'
'○ASFパス入力処理 済
'・参照ボタン押下時、OpenFileDialogを開いて選択
'・バリデーションはなし。

'○StartTimeラジオボタン処理　デフォルトは上 済
'・選択時、対応項目をアクティブ化。もう一方を非アクティブ化
'
'○StartTime入力時処理 済
'・レス番号入力時バリデーション。数値のみ 済
'・時刻入力時バリデーション。yyyy-mm-dd hh:mm:ss の形式にフォーマッティング。 済
'

'
'○EndTimeラジオボタン処理　デフォルトは上 済
'・選択時、対応項目をアクティブ化。もう一方を非アクティブ化 済

'○EndTime入力時処理 済
'・時刻入力時バリデーション。yyyy-mm-dd hh:mm:ss の形式にフォーマッティング。 済
'

'○Imageラジオボタン処理　デフォルトは上 済
'・選択時、対応項目をアクティブ化。もう一方を非アクティブ化 済

'○Image入力時処理 済
'・入力時バリデーション。数値のみ 済
'

'○Coverラジオボタン処理　デフォルトは上 済
'・選択時、対応項目をアクティブ化。もう一方を非アクティブ化 済
'
'○Cover入力時処理 済 済
'・入力時バリデーション。数値のみ 済

'
'○テンプレパス入力処理 済
'・参照ボタン押下時、OpenFileDialogを開いて選択
'・バリデーションはなし。

'
'○実行ボタン押下時処理

'・view初期化処理
'・DataGridViewとdialog呼び出し
'・実行時エラーチェック
'-ffmpeg存在チェック
'-dat存在チェック
'-テンプレ存在チェック（worning）

'・プログレスダイアログ表示
'
'・DATチェック時
'※DAT読み出し処理
'
'・PEGチェック時
'※PEG抽出処理
'
'※リスト作成処理
'
'
'・処理結果表示（view呼び出し）
'-結果リストを入力
'
'○終了時処理 済
'・XML出力→My.settingsを使う
'

'○Error
'
'個別処理
'
'■DAT読み出し処理
'○read
'
'
'○Parse
'・抽出対象番号解釈
'・リスト作成
'
'
'
'○Error
'
'
'■PEG抽出処理
'○コマンド作成
'
'
'
'○コマンド実行（呼び出し）
'・フォルダなければ作成（result）
'
'
'○リスト作成
'
'○Error
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

