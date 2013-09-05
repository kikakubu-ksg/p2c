Public Class main

    Public ExecPath As String = System.IO.Path.GetDirectoryName( _
        System.Reflection.Assembly.GetExecutingAssembly().Location)

    '�ҏW�t�H�[��
    Public Form As view = New view

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '������
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

        '�ҏW�t�H�[��
        Form.Visible = True


    End Sub

    Private Sub TextBox_ImageSetWidth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_ImageSetWidth.Validating
        If Not IsNumeric(TextBox_ImageSetWidth.Text) And Not TextBox_ImageSetWidth.Text = "" Then
            MsgBox("���l�̂ݓ��͉\�ł��B", MsgBoxStyle.Information)
            e.Cancel = True
        Else
            My.Settings.ASF_ImageWidth = TextBox_ImageSetWidth.Text
        End If

    End Sub

    Private Sub TextBox_ImageSetHeight_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_ImageSetHeight.Validating
        If Not IsNumeric(TextBox_ImageSetHeight.Text) And Not TextBox_ImageSetHeight.Text = "" Then
            MsgBox("���l�̂ݓ��͉\�ł��B", MsgBoxStyle.Information)
            e.Cancel = True
        Else
            My.Settings.ASF_ImageHeight = TextBox_ImageSetHeight.Text
        End If
    End Sub

    Private Sub TextBox_CoverSetSec_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_CoverSetSec.Validating
        If Not IsNumeric(TextBox_CoverSetSec.Text) And Not TextBox_CoverSetSec.Text = "" Then
            MsgBox("���l�̂ݓ��͉\�ł��B", MsgBoxStyle.Information)
            e.Cancel = True
        Else
            My.Settings.ASF_CoverSec = TextBox_CoverSetSec.Text
        End If
    End Sub

    Private Sub TextBox_DatUseNumStart_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_DatUseNumStart.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch( _
        TextBox_DatUseNumStart.Text, "^[0123456789]*$") _
        Then
            MsgBox("���l�̂ݓ��͉\�ł��B", MsgBoxStyle.Information)
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
            MsgBox("yyyy-mm-dd hh:mm:ss�`���œ��͂��Ă��������B", MsgBoxStyle.Information)
            Return False
        End If

        TimeString = formattedText

        If Not IsDate(formattedText) Then
            MsgBox("���t���s���ł��B", MsgBoxStyle.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub Button_DatPathRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DatPathRef.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'OK�{�^�����N���b�N���ꂽ�Ƃ�
            '�I�����ꂽ�t�@�C������\������
            TextBox_DatPath.Text = OpenFileDialog1.FileName
        End If

    End Sub
    Private Sub Button_AsfPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AsfPath.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            'OK�{�^�����N���b�N���ꂽ�Ƃ�
            '�I�����ꂽ�t�@�C������\������
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
            '�h���b�O���ꂽ�f�[�^�`���𒲂ׁA�t�@�C���̂Ƃ��̓R�s�[�Ƃ���
            ev.Effect = DragDropEffects.Copy
        Else
            '�t�@�C���ȊO�͎󂯕t���Ȃ�
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
        '�摜�N���A
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
        '�t�@�C���ǂݍ���
        ' StreamReader �̐V�����C���X�^���X�𐶐�����
        Dim cReader
        Dim cReaderH = Nothing

        Try
            cReader = New System.IO.StreamReader(TextBox_DatPath.Text, System.Text.Encoding.Default)
            If TextBox_DatPath_Haven.Text <> "" Then
                cReaderH = New System.IO.StreamReader(TextBox_DatPath_Haven.Text, System.Text.Encoding.Default)
            End If
        Catch
            MessageBox.Show("dat�t�@�C�����ǂݍ��߂܂���ł����B", _
                "�G���[", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Exit Sub
        Finally

        End Try


        ' �ǂݍ��񂾌��ʂ����ׂĊi�[���邽�߂̕ϐ���錾����
        Dim stResult As String = String.Empty

        ' �I�u�W�F�N�g�z��
        Dim list As New List(Of Response)
        Dim i As Integer = 0

        ''�{�X��
        ' �ǂݍ��݂ł��镶�����Ȃ��Ȃ�܂ŌJ��Ԃ�
        Try
            While (cReader.Peek() >= 0)
                i = i + 1
                ' �t�@�C���� 1 �s���ǂݍ���
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

                '�i�[
                list.Add(res)
            End While
        Catch
            MessageBox.Show("�{�X��dat�ǂݍ��݂ŃG���[���������܂����B", _
                "�G���[", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Exit Sub

        Finally
            ' cReader ����� (�������� �I�u�W�F�N�g�̔j����ۏ؂��� ���Q��)
            cReader.Close()
        End Try

        ''��
        Dim h As Integer = 0
        Try
            If TextBox_DatPath_Haven.Text <> "" Then
                While (cReaderH.Peek() >= 0)
                    h = h + 1
                    ' �t�@�C���� 1 �s���ǂݍ���
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

                    '�i�[
                    list.Add(res)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("��dat�ǂݍ��݂ŃG���[���������܂����B", _
                "�G���[", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Exit Sub

        Finally

            ' cReader ����� (�������� �I�u�W�F�N�g�̔j����ۏ؂��� ���Q��)
            cReaderH.Close()
        End Try
        '�\�[�gby dateid
        Dim comp As New ResponseComparer()
        list.Sort(comp)
        'Debug.Print(list.ToString)

        'tmp�t�H���_���Q�Ƃ��Ĕz��擾
        Dim singleton As Singleton = singleton.GetInstance()
        Dim files As String() = singleton.GetArray
        Dim firstFlag As Boolean = False
        Dim baseTick As Long = 0L

        '��ʕ\��
        Dim DataGridView1 As DataGridView = Form.DataGridView1
        For j As Integer = 0 To list.Count - 1
            '---create a row---

            Dim item As New DataGridViewRow
            item.CreateCells(DataGridView1)

            '���X������b�ɒ���
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

            '������Ƃ̍������o��
            Dim coversec = 1
            If TextBox_CoverSetSec.Text <> "" Then
                Try
                    coversec = Integer.Parse(TextBox_CoverSetSec.Text)
                Catch
                    coversec = 1
                End Try
            End If
            Dim sec As Long = (tick - baseTick) / (10000000 * coversec)

            '�z����̕b�Ɏ��܂�Ί���t���A�Ȃ��ꍇ�͍ŏ����Ō�
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
            'OK�{�^�����N���b�N���ꂽ�Ƃ�
            '�I�����ꂽ�t�@�C������\������
            TextBox_DatPath_Haven.Text = OpenFileDialog1.FileName
        End If
    End Sub

    '���ёւ�����@���`����N���X
    'IComparer�C���^�[�t�F�C�X����������
    Public Class ResponseComparer
        Implements System.Collections.IComparer

        'x��y��菬�����Ƃ��̓}�C�i�X�̐��A�傫���Ƃ��̓v���X�̐��A�����Ƃ���0��Ԃ�
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements System.Collections.IComparer.Compare

            'Nothing���ł��������Ƃ���
            If x Is Nothing AndAlso y Is Nothing Then
                Return 0
            End If
            If x Is Nothing Then
                Return -1
            End If
            If y Is Nothing Then
                Return 1
            End If

            'String�^�ȊO�̔�r�̓G���[
            If Not (TypeOf x Is Response) Then
                Throw New ArgumentException("Response�^�łȂ���΂Ȃ�܂���B", "x")
            ElseIf Not (TypeOf y Is Response) Then
                Throw New ArgumentException("Response�^�łȂ���΂Ȃ�܂���B", "y")
            End If

            '������̒������r����
            Return DirectCast(x, Response).datetime.CompareTo(DirectCast(y, Response).datetime)
            '�܂��́A���̂悤�ɂ��ł���
            'Return DirectCast(x, String).Length - DirectCast(y, String).Length
        End Function
    End Class

End Class


'Base Design
'�@�\�݌v
'Form������


'��XML�ǂݍ��݁^�ݒ菈����My.settings���g�� ��
'�EXML�t�@�C������ۑ����Ă���ݒ�l��ǂݍ���
'�E�l��main�ɓK�p
'

'��main������ ��
'�EConst�l�ݒ�
'�E���O�e�[�u�������� ��
'
'
'��ʋ@�\
'��DAT�`�F�b�N�{�b�N�X�I�������� ��
'DAT�{�b�N�X�I�����i�I�t�j�f�t�H���g�̓I��
'�EDAT�p�l���v�f�����ׂĔ�A�N�e�B�u�ɂ���
'�EPEG�`�F�b�N���I�t�̏ꍇ�A���s�{�^�����A�N�e�B�u�ɂ���
'
'DAT�{�b�N�X�I�����i�I���j ��
'�EDAT�p�l���v�f�����ׂăA�N�e�B�u�ɂ���
'�E���s�{�^�����A�N�e�B�u�ɂ���
'
'��DAT�p�X���͏��� ��
'�E�Q�ƃ{�^���������AOpenFileDialog���J���đI��
'�E�o���f�[�V�����͂Ȃ��B
'
'��DAT�i���o�[���͎����� ��
'�E�o���f�[�V�����B���l�A-,�ȊO�͕s����
'
'

'��PEG�`�F�b�N�{�b�N�X�I�������� ��
'PEG�{�b�N�X�I�����i�I�t�j�f�t�H���g�̓I��
'�EPEG�p�l���v�f�����ׂĔ�A�N�e�B�u�ɂ���
'�EDAT�`�F�b�N���I�t�̏ꍇ�A���s�{�^�����A�N�e�B�u�ɂ���
'
'PEG�{�b�N�X�I�����i�I���j ��
'�EPEG�p�l���v�f�����ׂăA�N�e�B�u�ɂ���
'�E���s�{�^�����A�N�e�B�u�ɂ���
'
'��ASF�p�X���͏��� ��
'�E�Q�ƃ{�^���������AOpenFileDialog���J���đI��
'�E�o���f�[�V�����͂Ȃ��B

'��StartTime���W�I�{�^�������@�f�t�H���g�͏� ��
'�E�I�����A�Ή����ڂ��A�N�e�B�u���B����������A�N�e�B�u��
'
'��StartTime���͎����� ��
'�E���X�ԍ����͎��o���f�[�V�����B���l�̂� ��
'�E�������͎��o���f�[�V�����Byyyy-mm-dd hh:mm:ss �̌`���Ƀt�H�[�}�b�e�B���O�B ��
'

'
'��EndTime���W�I�{�^�������@�f�t�H���g�͏� ��
'�E�I�����A�Ή����ڂ��A�N�e�B�u���B����������A�N�e�B�u�� ��

'��EndTime���͎����� ��
'�E�������͎��o���f�[�V�����Byyyy-mm-dd hh:mm:ss �̌`���Ƀt�H�[�}�b�e�B���O�B ��
'

'��Image���W�I�{�^�������@�f�t�H���g�͏� ��
'�E�I�����A�Ή����ڂ��A�N�e�B�u���B����������A�N�e�B�u�� ��

'��Image���͎����� ��
'�E���͎��o���f�[�V�����B���l�̂� ��
'

'��Cover���W�I�{�^�������@�f�t�H���g�͏� ��
'�E�I�����A�Ή����ڂ��A�N�e�B�u���B����������A�N�e�B�u�� ��
'
'��Cover���͎����� �� ��
'�E���͎��o���f�[�V�����B���l�̂� ��

'
'���e���v���p�X���͏��� ��
'�E�Q�ƃ{�^���������AOpenFileDialog���J���đI��
'�E�o���f�[�V�����͂Ȃ��B

'
'�����s�{�^������������

'�Eview����������
'�EDataGridView��dialog�Ăяo��
'�E���s���G���[�`�F�b�N
'-ffmpeg���݃`�F�b�N
'-dat���݃`�F�b�N
'-�e���v�����݃`�F�b�N�iworning�j

'�E�v���O���X�_�C�A���O�\��
'
'�EDAT�`�F�b�N��
'��DAT�ǂݏo������
'
'�EPEG�`�F�b�N��
'��PEG���o����
'
'�����X�g�쐬����
'
'
'�E�������ʕ\���iview�Ăяo���j
'-���ʃ��X�g�����
'
'���I�������� ��
'�EXML�o�́�My.settings���g��
'

'��Error
'
'�ʏ���
'
'��DAT�ǂݏo������
'��read
'
'
'��Parse
'�E���o�Ώ۔ԍ�����
'�E���X�g�쐬
'
'
'
'��Error
'
'
'��PEG���o����
'���R�}���h�쐬
'
'
'
'���R�}���h���s�i�Ăяo���j
'�E�t�H���_�Ȃ���΍쐬�iresult�j
'
'
'�����X�g�쐬
'
'��Error
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

