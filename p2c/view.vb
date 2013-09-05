Public Class view

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)
        '"Button"��Ȃ�΁A�{�^�����N���b�N���ꂽ
        If dgv.Columns(e.ColumnIndex).Name = "Button" Then
            '��s��Ɉړ�
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
            '    "�s�̃{�^�����N���b�N����܂����B"))
        End If

        If dgv.Columns(e.ColumnIndex).Name = "Button2" Then
            '��s���Ɉړ�
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
        DataGridView1.Columns(RowType.ResNum).HeaderText = "���X��"
        'DataGridView1.Columns.Add("ID", "ID")
        'DataGridViewImageColumn�̍쐬
        Dim column As New DataGridViewImageColumn()
        '��̖��O��ݒ�
        column.Name = "�摜"
        'Icon�^�ł͂Ȃ��AImage�^�̃f�[�^��\������
        '�f�t�H���g��False�Ȃ̂ŁA�ύX����K�v�͂Ȃ�
        column.ValuesAreIcons = False
        '�l�̐ݒ肳��Ă��Ȃ��Z���ɕ\������C���[�W��ݒ肷��
        'column.Image = New Bitmap("C:\null.gif")
        '�C���[�W���c���̔䗦���ێ����Ċg��A�k���\������
        column.ImageLayout = DataGridViewImageCellLayout.Zoom
        '�C���[�W�̐���
        '�Z�����N���b�v�{�[�h�ɃR�s�[�������Ɏg�p�����
        column.Description = "�摜"
        '�f�t�H���g�摜��\������
        column.DefaultCellStyle.NullValue = Nothing

        'DataGridView�ɒǉ�����
        DataGridView1.Columns.Add(column)

        'DataGridView1.Columns.Add("ga1", "�摜�I��")
        Dim imageAdoptColumn As New DataGridViewCheckBoxColumn
        imageAdoptColumn.Name = "�摜�̗p"
        DataGridView1.Columns.Add(imageAdoptColumn)
        'DataGridView1.Columns.Add("ga2", "�摜�̗p")
        DataGridView1.Columns.Add("Comment", "�R�����g")
        DataGridView1.Columns.Add("Res", "���X")
        Dim resAdoptColumn As New DataGridViewCheckBoxColumn
        resAdoptColumn.Name = "���X�̗p"
        DataGridView1.Columns.Add(resAdoptColumn)
        'DataGridView1.Columns.Add("res2", "���X�̗p")

        'hidden
        DataGridView1.Columns.Add("h1", "�摜�t�@�C����")
        DataGridView1.Columns.Add("h2", "timestamp")
        DataGridView1.Columns.Add("h3", "name")
        DataGridView1.Columns.Add("h4", "mail")
        DataGridView1.Columns.Add("h5", "dateid")
        DataGridView1.Columns.Add("h6", "���X")
        DataGridView1.Columns.Add("h7", "�\���Q")
        DataGridView1.Columns.Add("h8", "�\���R")

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

        'DataGridViewButtonColumn�̍쐬
        'Dim column As New DataGridViewButtonColumn()
        ''��̖��O��ݒ�
        'column.Name = "Button"
        ''�S�Ẵ{�^����"�ڍ׉{��"�ƕ\������
        'column.UseColumnTextForButtonValue = True
        'column.Text = "��"
        ''DataGridView�ɒǉ�����
        'DataGridView1.Columns.Add(column)

        'DataGridView1.Columns(6).Width = 30


        ''DataGridViewButtonColumn�̍쐬
        'Dim column2 As New DataGridViewButtonColumn()
        ''��̖��O��ݒ�
        'column2.Name = "Button2"
        ''�S�Ẵ{�^����"�ڍ׉{��"�ƕ\������
        'column2.UseColumnTextForButtonValue = True
        'column2.Text = "��"
        ''DataGridView�ɒǉ�����
        'DataGridView1.Columns.Add(column2)

        'DataGridView1.Columns(7).Width = 30

        '�S�Ă̗�̔w�i�F�𐅐F�ɂ���
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightCyan
        '��s�����F�ɂ���
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White


        ' �Z�����ŕ������܂�Ԃ�
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' ������S�̂��\�������悤�ɍs�̍������������߂���
        DataGridView1.AutoResizeRows()

        'DataGridView1�Ƀ��[�U�[���V�����s��ǉ��ł��Ȃ��悤�ɂ���
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.HeaderCell = New myDataGridViewRowHeaderCell

    End Sub



    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        ''��w�b�_�[���ǂ������ׂ�
        'If e.ColumnIndex < 0 And e.RowIndex >= 0 Then
        '    '�Z����`�悷��
        '    e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

        '    '�s�ԍ���`�悷��͈͂����肷��
        '    'e.AdvancedBorderStyle��e.CellStyle.Padding�͖������Ă��܂�
        '    Dim indexRect As Rectangle = e.CellBounds
        '    indexRect.Inflate(-2, -2)
        '    '�s�ԍ���`�悷��
        '    TextRenderer.DrawText(e.Graphics, _
        '        (e.RowIndex + 1).ToString(), _
        '        e.CellStyle.Font, _
        '        indexRect, _
        '        e.CellStyle.ForeColor, _
        '        TextFormatFlags.Right Or TextFormatFlags.VerticalCenter)
        '    '�`�悪�����������Ƃ�m�点��
        '    e.Handled = True
        'End If

        ''�w�b�_�[�ȊO�̃Z���ŁA�w�i��`�悷�鎞
        'If e.ColumnIndex = 0 AndAlso e.RowIndex = 0 AndAlso _
        '    (e.PaintParts And DataGridViewPaintParts.Background) = _
        '        DataGridViewPaintParts.Background Then
        '    '�w�i������`�悷��
        '    Dim backParts As DataGridViewPaintParts = _
        '        e.PaintParts And (DataGridViewPaintParts.Background Or _
        '            DataGridViewPaintParts.SelectionBackground)
        '    e.Paint(e.ClipBounds, backParts)

        '    '�摜���Z���͈̔͂����ς��ɕ\������
        '    'e.Graphics.DrawImage(cellBackImage, e.CellBounds)
        '    e.Graphics.DrawImage(cellBackImage, e.CellBounds.Left, e.CellBounds.Top, cellBackImage.Width, cellBackImage.Height)

        '    DataGridView1.Columns(0).MinimumWidth = cellBackImage.Width
        '    DataGridView1.Rows(e.RowIndex).MinimumHeight = cellBackImage.Height



        '    '�w�i�ȊO���`�悳���悤�ɂ���
        '    Dim paintParts As DataGridViewPaintParts = _
        '        e.PaintParts And Not backParts
        '    '�Z����`�悷��
        '    e.Paint(e.ClipBounds, paintParts)

        '    '�`�悪�����������Ƃ�m�点��
        '    e.Handled = True
        'End If


    End Sub


    ''' <summary>
    ''' �I�����Ă���Z�����ЂƂ�ɂ�����
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub UpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpButton.Click

        Dim dgv As DataGridView = DataGridView1
        Dim cel As DataGridViewCell = dgv.CurrentCell

        '��s��Ɉړ�
        If cel Is Nothing Then
            MessageBox.Show("�Z�����I������Ă��܂���B")
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
    ''' �I�����Ă���Z�����ЂƂ��ɂ�����
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownButton.Click

        Dim dgv As DataGridView = DataGridView1
        Dim cel As DataGridViewCell = dgv.CurrentCell

        '��s���Ɉړ�
        If cel Is Nothing Then
            MessageBox.Show("�Z�����I������Ă��܂���B")
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
        '�s�ǉ�
        '�J�����g�s�擾
        Dim dgv As DataGridView = DataGridView1
        Try
            Dim dgvc As DataGridViewCell = dgv.SelectedCells.Item(0)
            dgv.Rows.Insert(dgvc.RowIndex, 1)
        Catch ex As SystemException
            MessageBox.Show("�s��ǉ��ł��܂���B" & vbCrLf & ex.Message)
        End Try



    End Sub

    Private Sub RightButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles RightButton.Paint

        '�\�����镶����
        Dim s As String = "��"

        '���[���h�ϊ��s���45�x��]����
        e.Graphics.RotateTransform(90.0F)
        e.Graphics.TranslateTransform(4, -20)

        '�������`��
        e.Graphics.DrawString(s, Me.Font, Brushes.Black, 0, 0)

    End Sub

    Private Sub LeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftButton.Click
        '�s�폜
        Dim dgv As DataGridView = DataGridView1
        Try
            Dim dgvc As DataGridViewCell = dgv.SelectedCells.Item(0)
            dgv.Rows.RemoveAt(dgvc.RowIndex)
        Catch ex As SystemException
            MessageBox.Show("�s���폜�ł��܂���B" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub LeftButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles LeftButton.Paint
        '�\�����镶����
        Dim s As String = "��"

        '���[���h�ϊ��s���45�x��]����
        e.Graphics.RotateTransform(90.0F)
        e.Graphics.TranslateTransform(4, -20)

        '�������`��
        e.Graphics.DrawString(s, Me.Font, Brushes.Black, 0, 0)

    End Sub

    Private Sub PreviousImage_Click(sender As System.Object, e As System.EventArgs) Handles PreviousImage.Click
        '�J�����g�s�擾
        Dim dgv As DataGridView = DataGridView1
        Dim dgvc As DataGridViewCell
        Try
            dgvc = dgv.SelectedCells.Item(0)
        Catch ex As SystemException
            MessageBox.Show("�s������܂���B" & vbCrLf & ex.Message)
            Return
        End Try
        Dim currentStr As String = dgv(RowType.ImageName, dgvc.RowIndex).Value

        Dim singleton As Singleton = singleton.GetInstance()
        Dim pi As String = singleton.GetPreviousImage(GetExeAppPath() & "\tmp\" & currentStr)

        If pi Is Nothing Then Exit Sub

        '�摜�ύX
        dgv(RowType.Image, dgvc.RowIndex).Value = New Bitmap(pi)
        '�t�@�C�����ύX
        dgv(RowType.ImageName, dgvc.RowIndex).Value = pi.Replace(GetExeAppPath() & "\tmp\", "")

    End Sub

    Private Sub NextImage_Click(sender As System.Object, e As System.EventArgs) Handles NextImage.Click
        '�J�����g�s�擾
        Dim dgv As DataGridView = DataGridView1
        Dim dgvc As DataGridViewCell
        Try
            dgvc = dgv.SelectedCells.Item(0)
        Catch ex As SystemException
            MessageBox.Show("�s������܂���B" & vbCrLf & ex.Message)
            Return
        End Try
        Dim currentStr As String = dgv(RowType.ImageName, dgvc.RowIndex).Value

        Dim singleton As Singleton = singleton.GetInstance()
        Dim pi As String = singleton.GetNextImage(GetExeAppPath() & "\tmp\" & currentStr)

        If pi Is Nothing Then Exit Sub

        '�摜�ύX
        dgv(RowType.Image, dgvc.RowIndex).Value = New Bitmap(pi)
        '�t�@�C�����ύX
        dgv(RowType.ImageName, dgvc.RowIndex).Value = pi.Replace(GetExeAppPath() & "\tmp\", "")
    End Sub


    Private Sub htmloutput_Click(sender As System.Object, e As System.EventArgs) Handles htmloutput.Click
        '�e�L�X�g�\�z
        Dim sb As New System.Text.StringBuilder()
        Dim imageDir As String = TextBox_ImageDir.Text
        '/���Ƃ�
        imageDir = System.Text.RegularExpressions.Regex.Replace(imageDir, "/$", "")
        '�摜�N���A
        For Each tempFile As String In _
            System.IO.Directory.GetFiles(GetExeAppPath() & _
                                         "\htmlimg")
            System.IO.File.Delete(tempFile)
        Next
        For Each dgvr As DataGridViewRow In DataGridView1.Rows
            Dim comClass As String = "<DIV class='_comment_no_image"
            If dgvr.Cells.Item(RowType.ImageAdopt).Value = True Then
                '�t�@�C���R�s�[
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
                sb.Append("<DIV class='_reshead'><span class='_resnum " & dgvr.Cells.Item(RowType.ResNum).Tag & "'>").Append(IIf(RowType.HavenCode = 1, "<span class='_havenmark'>��</span>", "")).Append(dgvr.Cells.Item(RowType.ResNum).Value).Append("</span>") _
                    .Append("<span class='_name " & dgvr.Cells.Item(RowType.Name).Tag & "'>").Append(dgvr.Cells.Item(RowType.Name).Value).Append("</span>") _
                    .Append("<span class='_dateid " & dgvr.Cells.Item(RowType.DateId).Tag & "'>").Append(dgvr.Cells.Item(RowType.DateId).Value).Append("</span>") _
                    .Append("</DIV>").Append(vbCrLf)
                Dim t As String = dgvr.Cells.Item(RowType.ResRaw).Value
                sb.Append("<DIV class='_res " & dgvr.Cells.Item(RowType.ResRaw).Tag & "'>").Append(t.Replace(vbCrLf, "<br />")).Append("</DIV>").Append(vbCrLf)
            End If

        Next

        '�e�L�X�g�o��
        Dim sw As New System.IO.StreamWriter(GetExeAppPath() & "\hoge.html", _
            False, _
            System.Text.Encoding.GetEncoding("utf-8"))
        sw.Write(sb.ToString)
        '����
        sw.Close()

        'html���J��
        System.Diagnostics.Process.Start(GetExeAppPath() & "\hoge.html")

    End Sub

    Private Sub PreviousImageAll_Click(sender As System.Object, e As System.EventArgs) Handles PreviousImageAll.Click
        Dim dgv As DataGridView = DataGridView1
        For Each dgvr As DataGridViewRow In dgv.Rows
            Dim currentStr As String = dgv(RowType.ImageName, dgvr.Index).Value

            Dim singleton As Singleton = singleton.GetInstance()
            Dim pi As String = singleton.GetPreviousImage(GetExeAppPath() & "\tmp\" & currentStr)

            If Not (pi Is Nothing) Then
                '�摜�ύX
                dgv(RowType.Image, dgvr.Index).Value = New Bitmap(pi)
                '�t�@�C�����ύX
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
                '�摜�ύX
                dgv(RowType.Image, dgvr.Index).Value = New Bitmap(pi)
                '�t�@�C�����ύX
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

    ' �R���X�g���N�^�ł��B(�O������̃A�N�Z�X�s��)
    Private Sub New()
        Console.WriteLine("�C���X�^���X�𐶐����܂����B")
        '�t�@�C���z��擾
        files = System.IO.Directory.GetFiles( _
            GetExeAppPath() & "\tmp", "*")
        '�\�[�g
        Array.Sort(files)
    End Sub

    ' �B��̃C���X�^���X���擾���܂��B
    Public Shared Function GetInstance() As Singleton
        ' Console.WriteLine("return singleton.")
        Return _singleton
    End Function

    '�z���ԋp
    Public Function GetArray() As String()
        Return files
    End Function

    '�O�摜
    Public Function GetPreviousImage(currentStr As String) As String
        '�C���f�b�N�X��T��
        Dim index = Array.IndexOf(files, currentStr)

        If index > 0 Then
            '�O�摜�ԋp
            Return files(index - 1)
        Else
            Return Nothing
        End If

    End Function

    '��摜
    Public Function GetNextImage(currentStr As String) As String
        '�C���f�b�N�X��T��
        Dim index = Array.IndexOf(files, currentStr)

        If index <> -1 And index < files.Length - 1 Then
            '�O�摜�ԋp
            Return files(index + 1)
        Else
            Return Nothing
        End If
    End Function

    '�Ď擾
    Public Shared Function ReGetInstance() As Singleton
        _singleton = New Singleton
        Console.WriteLine("�C���X�^���X�𐶐����܂����B")
        '�t�@�C���z��擾
        _singleton.files = System.IO.Directory.GetFiles( _
            GetExeAppPath() & "\tmp", "*")
        '�\�[�g
        Array.Sort(_singleton.files)
        Return _singleton
    End Function

End Class

'memo
'IMG�s��TXT�s���ŏ㉺�ړ��̏�����ς���B
'�s�R�s�[�@�\���K�v�H
'�\�[�X���C���[�h���ق���

'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
















