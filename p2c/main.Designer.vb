<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.TabControl_Config = New System.Windows.Forms.TabControl()
        Me.TabPage_Config = New System.Windows.Forms.TabPage()
        Me.GroupBox_Asf = New System.Windows.Forms.GroupBox()
        Me.Button_GetLiveStartTime = New System.Windows.Forms.Button()
        Me.TextBox_LiveStartTime = New System.Windows.Forms.TextBox()
        Me.Label_LiveStartTime = New System.Windows.Forms.Label()
        Me.Label_AsfPath = New System.Windows.Forms.Label()
        Me.Button_Exec = New System.Windows.Forms.Button()
        Me.TextBox_AsfPath = New System.Windows.Forms.TextBox()
        Me.Button_AsfPath = New System.Windows.Forms.Button()
        Me.GroupBox_EndTime = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_EndTimeSet = New System.Windows.Forms.TextBox()
        Me.RadioButton_EndTimeSet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_EndTimeSaveTime = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Image = New System.Windows.Forms.GroupBox()
        Me.Label_x = New System.Windows.Forms.Label()
        Me.TextBox_ImageSetHeight = New System.Windows.Forms.TextBox()
        Me.TextBox_ImageSetWidth = New System.Windows.Forms.TextBox()
        Me.RadioButton_ImageSet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_ImageNormal = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Cover = New System.Windows.Forms.GroupBox()
        Me.Label_sec = New System.Windows.Forms.Label()
        Me.TextBox_CoverSetSec = New System.Windows.Forms.TextBox()
        Me.GroupBox_StartTime = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_StartTimeSet = New System.Windows.Forms.TextBox()
        Me.RadioButton_StartTimeSet = New System.Windows.Forms.RadioButton()
        Me.RadioButton_StartTimeNum = New System.Windows.Forms.RadioButton()
        Me.GroupBox_DAT = New System.Windows.Forms.GroupBox()
        Me.CheckBox_SetTime = New System.Windows.Forms.CheckBox()
        Me.TextBox_DatUseNumEnd = New System.Windows.Forms.TextBox()
        Me.TextBox_DatPath = New System.Windows.Forms.TextBox()
        Me.TextBox_DatUseNumStart = New System.Windows.Forms.TextBox()
        Me.Label_DatUseNumExp = New System.Windows.Forms.Label()
        Me.Label_DatUseNum = New System.Windows.Forms.Label()
        Me.Label_DatPath = New System.Windows.Forms.Label()
        Me.Button_DatPathRef = New System.Windows.Forms.Button()
        Me.CheckBox_Asf = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Dat = New System.Windows.Forms.CheckBox()
        Me.TabPage_Log = New System.Windows.Forms.TabPage()
        Me.DataGridView_Log = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tabpage_Haven = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_DatUseNumEnd_Haven = New System.Windows.Forms.TextBox()
        Me.TextBox_DatPath_Haven = New System.Windows.Forms.TextBox()
        Me.TextBox_DatUseNumStart_Haven = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_DatPathRef_Haven = New System.Windows.Forms.Button()
        Me.TabControl_Config.SuspendLayout()
        Me.TabPage_Config.SuspendLayout()
        Me.GroupBox_Asf.SuspendLayout()
        Me.GroupBox_EndTime.SuspendLayout()
        Me.GroupBox_Image.SuspendLayout()
        Me.GroupBox_Cover.SuspendLayout()
        Me.GroupBox_StartTime.SuspendLayout()
        Me.GroupBox_DAT.SuspendLayout()
        Me.TabPage_Log.SuspendLayout()
        CType(Me.DataGridView_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabpage_Haven.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_Config
        '
        Me.TabControl_Config.Controls.Add(Me.TabPage_Config)
        Me.TabControl_Config.Controls.Add(Me.Tabpage_Haven)
        Me.TabControl_Config.Controls.Add(Me.TabPage_Log)
        Me.TabControl_Config.Location = New System.Drawing.Point(12, 12)
        Me.TabControl_Config.Name = "TabControl_Config"
        Me.TabControl_Config.SelectedIndex = 0
        Me.TabControl_Config.Size = New System.Drawing.Size(491, 427)
        Me.TabControl_Config.TabIndex = 2
        '
        'TabPage_Config
        '
        Me.TabPage_Config.Controls.Add(Me.GroupBox_Asf)
        Me.TabPage_Config.Controls.Add(Me.GroupBox_DAT)
        Me.TabPage_Config.Controls.Add(Me.CheckBox_Asf)
        Me.TabPage_Config.Controls.Add(Me.CheckBox_Dat)
        Me.TabPage_Config.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Config.Name = "TabPage_Config"
        Me.TabPage_Config.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Config.Size = New System.Drawing.Size(483, 401)
        Me.TabPage_Config.TabIndex = 0
        Me.TabPage_Config.Text = "設定"
        Me.TabPage_Config.UseVisualStyleBackColor = True
        '
        'GroupBox_Asf
        '
        Me.GroupBox_Asf.Controls.Add(Me.Button_GetLiveStartTime)
        Me.GroupBox_Asf.Controls.Add(Me.TextBox_LiveStartTime)
        Me.GroupBox_Asf.Controls.Add(Me.Label_LiveStartTime)
        Me.GroupBox_Asf.Controls.Add(Me.Label_AsfPath)
        Me.GroupBox_Asf.Controls.Add(Me.Button_Exec)
        Me.GroupBox_Asf.Controls.Add(Me.TextBox_AsfPath)
        Me.GroupBox_Asf.Controls.Add(Me.Button_AsfPath)
        Me.GroupBox_Asf.Controls.Add(Me.GroupBox_EndTime)
        Me.GroupBox_Asf.Controls.Add(Me.GroupBox_Image)
        Me.GroupBox_Asf.Controls.Add(Me.GroupBox_Cover)
        Me.GroupBox_Asf.Controls.Add(Me.GroupBox_StartTime)
        Me.GroupBox_Asf.Location = New System.Drawing.Point(9, 137)
        Me.GroupBox_Asf.Name = "GroupBox_Asf"
        Me.GroupBox_Asf.Size = New System.Drawing.Size(465, 258)
        Me.GroupBox_Asf.TabIndex = 5
        Me.GroupBox_Asf.TabStop = False
        Me.GroupBox_Asf.Text = "動画ファイル"
        '
        'Button_GetLiveStartTime
        '
        Me.Button_GetLiveStartTime.Location = New System.Drawing.Point(344, 192)
        Me.Button_GetLiveStartTime.Name = "Button_GetLiveStartTime"
        Me.Button_GetLiveStartTime.Size = New System.Drawing.Size(111, 23)
        Me.Button_GetLiveStartTime.TabIndex = 27
        Me.Button_GetLiveStartTime.Text = "ファイル名から取得"
        Me.Button_GetLiveStartTime.UseVisualStyleBackColor = True
        '
        'TextBox_LiveStartTime
        '
        Me.TextBox_LiveStartTime.Location = New System.Drawing.Point(92, 193)
        Me.TextBox_LiveStartTime.Name = "TextBox_LiveStartTime"
        Me.TextBox_LiveStartTime.Size = New System.Drawing.Size(244, 19)
        Me.TextBox_LiveStartTime.TabIndex = 26
        '
        'Label_LiveStartTime
        '
        Me.Label_LiveStartTime.AutoSize = True
        Me.Label_LiveStartTime.Location = New System.Drawing.Point(9, 197)
        Me.Label_LiveStartTime.Name = "Label_LiveStartTime"
        Me.Label_LiveStartTime.Size = New System.Drawing.Size(77, 12)
        Me.Label_LiveStartTime.TabIndex = 25
        Me.Label_LiveStartTime.Text = "配信開始時刻"
        '
        'Label_AsfPath
        '
        Me.Label_AsfPath.AutoSize = True
        Me.Label_AsfPath.Location = New System.Drawing.Point(15, 21)
        Me.Label_AsfPath.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_AsfPath.Name = "Label_AsfPath"
        Me.Label_AsfPath.Size = New System.Drawing.Size(39, 12)
        Me.Label_AsfPath.TabIndex = 10
        Me.Label_AsfPath.Text = "ファイル"
        '
        'Button_Exec
        '
        Me.Button_Exec.Location = New System.Drawing.Point(366, 229)
        Me.Button_Exec.Name = "Button_Exec"
        Me.Button_Exec.Size = New System.Drawing.Size(89, 23)
        Me.Button_Exec.TabIndex = 24
        Me.Button_Exec.Text = "画像抽出実行"
        Me.Button_Exec.UseVisualStyleBackColor = True
        '
        'TextBox_AsfPath
        '
        Me.TextBox_AsfPath.AllowDrop = True
        Me.TextBox_AsfPath.Location = New System.Drawing.Point(79, 18)
        Me.TextBox_AsfPath.Name = "TextBox_AsfPath"
        Me.TextBox_AsfPath.Size = New System.Drawing.Size(327, 19)
        Me.TextBox_AsfPath.TabIndex = 6
        '
        'Button_AsfPath
        '
        Me.Button_AsfPath.Location = New System.Drawing.Point(413, 17)
        Me.Button_AsfPath.Name = "Button_AsfPath"
        Me.Button_AsfPath.Size = New System.Drawing.Size(37, 23)
        Me.Button_AsfPath.TabIndex = 7
        Me.Button_AsfPath.Text = "参照"
        Me.Button_AsfPath.UseVisualStyleBackColor = True
        '
        'GroupBox_EndTime
        '
        Me.GroupBox_EndTime.Controls.Add(Me.Label2)
        Me.GroupBox_EndTime.Controls.Add(Me.TextBox_EndTimeSet)
        Me.GroupBox_EndTime.Controls.Add(Me.RadioButton_EndTimeSet)
        Me.GroupBox_EndTime.Controls.Add(Me.RadioButton_EndTimeSaveTime)
        Me.GroupBox_EndTime.Location = New System.Drawing.Point(235, 46)
        Me.GroupBox_EndTime.Name = "GroupBox_EndTime"
        Me.GroupBox_EndTime.Size = New System.Drawing.Size(220, 68)
        Me.GroupBox_EndTime.TabIndex = 1
        Me.GroupBox_EndTime.TabStop = False
        Me.GroupBox_EndTime.Text = "終了日時"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "秒後まで"
        '
        'TextBox_EndTimeSet
        '
        Me.TextBox_EndTimeSet.Location = New System.Drawing.Point(78, 40)
        Me.TextBox_EndTimeSet.Name = "TextBox_EndTimeSet"
        Me.TextBox_EndTimeSet.Size = New System.Drawing.Size(23, 19)
        Me.TextBox_EndTimeSet.TabIndex = 14
        '
        'RadioButton_EndTimeSet
        '
        Me.RadioButton_EndTimeSet.AutoSize = True
        Me.RadioButton_EndTimeSet.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton_EndTimeSet.Name = "RadioButton_EndTimeSet"
        Me.RadioButton_EndTimeSet.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_EndTimeSet.TabIndex = 13
        Me.RadioButton_EndTimeSet.Text = "指定"
        Me.RadioButton_EndTimeSet.UseVisualStyleBackColor = True
        '
        'RadioButton_EndTimeSaveTime
        '
        Me.RadioButton_EndTimeSaveTime.AutoSize = True
        Me.RadioButton_EndTimeSaveTime.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton_EndTimeSaveTime.Name = "RadioButton_EndTimeSaveTime"
        Me.RadioButton_EndTimeSaveTime.Size = New System.Drawing.Size(66, 16)
        Me.RadioButton_EndTimeSaveTime.TabIndex = 12
        Me.RadioButton_EndTimeSaveTime.Text = "最後まで"
        Me.RadioButton_EndTimeSaveTime.UseVisualStyleBackColor = True
        '
        'GroupBox_Image
        '
        Me.GroupBox_Image.Controls.Add(Me.Label_x)
        Me.GroupBox_Image.Controls.Add(Me.TextBox_ImageSetHeight)
        Me.GroupBox_Image.Controls.Add(Me.TextBox_ImageSetWidth)
        Me.GroupBox_Image.Controls.Add(Me.RadioButton_ImageSet)
        Me.GroupBox_Image.Controls.Add(Me.RadioButton_ImageNormal)
        Me.GroupBox_Image.Location = New System.Drawing.Point(9, 117)
        Me.GroupBox_Image.Name = "GroupBox_Image"
        Me.GroupBox_Image.Size = New System.Drawing.Size(220, 68)
        Me.GroupBox_Image.TabIndex = 1
        Me.GroupBox_Image.TabStop = False
        Me.GroupBox_Image.Text = "画像抽出"
        '
        'Label_x
        '
        Me.Label_x.AutoSize = True
        Me.Label_x.Location = New System.Drawing.Point(127, 45)
        Me.Label_x.Name = "Label_x"
        Me.Label_x.Size = New System.Drawing.Size(11, 12)
        Me.Label_x.TabIndex = 8
        Me.Label_x.Text = "x"
        '
        'TextBox_ImageSetHeight
        '
        Me.TextBox_ImageSetHeight.Location = New System.Drawing.Point(144, 39)
        Me.TextBox_ImageSetHeight.Name = "TextBox_ImageSetHeight"
        Me.TextBox_ImageSetHeight.Size = New System.Drawing.Size(40, 19)
        Me.TextBox_ImageSetHeight.TabIndex = 18
        '
        'TextBox_ImageSetWidth
        '
        Me.TextBox_ImageSetWidth.Location = New System.Drawing.Point(82, 39)
        Me.TextBox_ImageSetWidth.Name = "TextBox_ImageSetWidth"
        Me.TextBox_ImageSetWidth.Size = New System.Drawing.Size(40, 19)
        Me.TextBox_ImageSetWidth.TabIndex = 17
        '
        'RadioButton_ImageSet
        '
        Me.RadioButton_ImageSet.AutoSize = True
        Me.RadioButton_ImageSet.Location = New System.Drawing.Point(10, 39)
        Me.RadioButton_ImageSet.Name = "RadioButton_ImageSet"
        Me.RadioButton_ImageSet.Size = New System.Drawing.Size(76, 16)
        Me.RadioButton_ImageSet.TabIndex = 16
        Me.RadioButton_ImageSet.Text = "サイズ指定"
        Me.RadioButton_ImageSet.UseVisualStyleBackColor = True
        '
        'RadioButton_ImageNormal
        '
        Me.RadioButton_ImageNormal.AutoSize = True
        Me.RadioButton_ImageNormal.Location = New System.Drawing.Point(10, 17)
        Me.RadioButton_ImageNormal.Name = "RadioButton_ImageNormal"
        Me.RadioButton_ImageNormal.Size = New System.Drawing.Size(70, 16)
        Me.RadioButton_ImageNormal.TabIndex = 15
        Me.RadioButton_ImageNormal.Text = "フルサイズ"
        Me.RadioButton_ImageNormal.UseVisualStyleBackColor = True
        '
        'GroupBox_Cover
        '
        Me.GroupBox_Cover.Controls.Add(Me.Label_sec)
        Me.GroupBox_Cover.Controls.Add(Me.TextBox_CoverSetSec)
        Me.GroupBox_Cover.Location = New System.Drawing.Point(238, 117)
        Me.GroupBox_Cover.Name = "GroupBox_Cover"
        Me.GroupBox_Cover.Size = New System.Drawing.Size(220, 68)
        Me.GroupBox_Cover.TabIndex = 2
        Me.GroupBox_Cover.TabStop = False
        Me.GroupBox_Cover.Text = "抽出間隔"
        '
        'Label_sec
        '
        Me.Label_sec.AutoSize = True
        Me.Label_sec.Location = New System.Drawing.Point(56, 20)
        Me.Label_sec.Name = "Label_sec"
        Me.Label_sec.Size = New System.Drawing.Size(17, 12)
        Me.Label_sec.TabIndex = 8
        Me.Label_sec.Text = "秒"
        '
        'TextBox_CoverSetSec
        '
        Me.TextBox_CoverSetSec.Location = New System.Drawing.Point(10, 15)
        Me.TextBox_CoverSetSec.Name = "TextBox_CoverSetSec"
        Me.TextBox_CoverSetSec.Size = New System.Drawing.Size(40, 19)
        Me.TextBox_CoverSetSec.TabIndex = 21
        '
        'GroupBox_StartTime
        '
        Me.GroupBox_StartTime.Controls.Add(Me.Label1)
        Me.GroupBox_StartTime.Controls.Add(Me.TextBox_StartTimeSet)
        Me.GroupBox_StartTime.Controls.Add(Me.RadioButton_StartTimeSet)
        Me.GroupBox_StartTime.Controls.Add(Me.RadioButton_StartTimeNum)
        Me.GroupBox_StartTime.Location = New System.Drawing.Point(9, 46)
        Me.GroupBox_StartTime.Name = "GroupBox_StartTime"
        Me.GroupBox_StartTime.Size = New System.Drawing.Size(220, 68)
        Me.GroupBox_StartTime.TabIndex = 0
        Me.GroupBox_StartTime.TabStop = False
        Me.GroupBox_StartTime.Text = "開始日時"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "秒後から"
        '
        'TextBox_StartTimeSet
        '
        Me.TextBox_StartTimeSet.Location = New System.Drawing.Point(78, 40)
        Me.TextBox_StartTimeSet.Name = "TextBox_StartTimeSet"
        Me.TextBox_StartTimeSet.Size = New System.Drawing.Size(23, 19)
        Me.TextBox_StartTimeSet.TabIndex = 11
        '
        'RadioButton_StartTimeSet
        '
        Me.RadioButton_StartTimeSet.AutoSize = True
        Me.RadioButton_StartTimeSet.Location = New System.Drawing.Point(6, 40)
        Me.RadioButton_StartTimeSet.Name = "RadioButton_StartTimeSet"
        Me.RadioButton_StartTimeSet.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_StartTimeSet.TabIndex = 9
        Me.RadioButton_StartTimeSet.Text = "指定"
        Me.RadioButton_StartTimeSet.UseVisualStyleBackColor = True
        '
        'RadioButton_StartTimeNum
        '
        Me.RadioButton_StartTimeNum.AutoSize = True
        Me.RadioButton_StartTimeNum.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton_StartTimeNum.Name = "RadioButton_StartTimeNum"
        Me.RadioButton_StartTimeNum.Size = New System.Drawing.Size(65, 16)
        Me.RadioButton_StartTimeNum.TabIndex = 8
        Me.RadioButton_StartTimeNum.Text = "最初から"
        Me.RadioButton_StartTimeNum.UseVisualStyleBackColor = True
        '
        'GroupBox_DAT
        '
        Me.GroupBox_DAT.Controls.Add(Me.CheckBox_SetTime)
        Me.GroupBox_DAT.Controls.Add(Me.TextBox_DatUseNumEnd)
        Me.GroupBox_DAT.Controls.Add(Me.TextBox_DatPath)
        Me.GroupBox_DAT.Controls.Add(Me.TextBox_DatUseNumStart)
        Me.GroupBox_DAT.Controls.Add(Me.Label_DatUseNumExp)
        Me.GroupBox_DAT.Controls.Add(Me.Label_DatUseNum)
        Me.GroupBox_DAT.Controls.Add(Me.Label_DatPath)
        Me.GroupBox_DAT.Controls.Add(Me.Button_DatPathRef)
        Me.GroupBox_DAT.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox_DAT.Name = "GroupBox_DAT"
        Me.GroupBox_DAT.Size = New System.Drawing.Size(462, 71)
        Me.GroupBox_DAT.TabIndex = 0
        Me.GroupBox_DAT.TabStop = False
        Me.GroupBox_DAT.Text = "datファイル"
        '
        'CheckBox_SetTime
        '
        Me.CheckBox_SetTime.AutoSize = True
        Me.CheckBox_SetTime.Location = New System.Drawing.Point(251, 46)
        Me.CheckBox_SetTime.Name = "CheckBox_SetTime"
        Me.CheckBox_SetTime.Size = New System.Drawing.Size(152, 16)
        Me.CheckBox_SetTime.TabIndex = 9
        Me.CheckBox_SetTime.Text = "レス時刻付近の画像を使う"
        Me.CheckBox_SetTime.UseVisualStyleBackColor = True
        Me.CheckBox_SetTime.Visible = False
        '
        'TextBox_DatUseNumEnd
        '
        Me.TextBox_DatUseNumEnd.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_DatUseNumEnd.Location = New System.Drawing.Point(143, 44)
        Me.TextBox_DatUseNumEnd.Name = "TextBox_DatUseNumEnd"
        Me.TextBox_DatUseNumEnd.Size = New System.Drawing.Size(31, 19)
        Me.TextBox_DatUseNumEnd.TabIndex = 8
        '
        'TextBox_DatPath
        '
        Me.TextBox_DatPath.AllowDrop = True
        Me.TextBox_DatPath.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_DatPath.Location = New System.Drawing.Point(76, 18)
        Me.TextBox_DatPath.Name = "TextBox_DatPath"
        Me.TextBox_DatPath.Size = New System.Drawing.Size(327, 19)
        Me.TextBox_DatPath.TabIndex = 1
        '
        'TextBox_DatUseNumStart
        '
        Me.TextBox_DatUseNumStart.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_DatUseNumStart.Location = New System.Drawing.Point(76, 44)
        Me.TextBox_DatUseNumStart.Name = "TextBox_DatUseNumStart"
        Me.TextBox_DatUseNumStart.Size = New System.Drawing.Size(31, 19)
        Me.TextBox_DatUseNumStart.TabIndex = 4
        '
        'Label_DatUseNumExp
        '
        Me.Label_DatUseNumExp.AutoSize = True
        Me.Label_DatUseNumExp.Location = New System.Drawing.Point(113, 48)
        Me.Label_DatUseNumExp.Name = "Label_DatUseNumExp"
        Me.Label_DatUseNumExp.Size = New System.Drawing.Size(23, 12)
        Me.Label_DatUseNumExp.TabIndex = 7
        Me.Label_DatUseNumExp.Text = "から"
        '
        'Label_DatUseNum
        '
        Me.Label_DatUseNum.AutoSize = True
        Me.Label_DatUseNum.Location = New System.Drawing.Point(12, 46)
        Me.Label_DatUseNum.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_DatUseNum.Name = "Label_DatUseNum"
        Me.Label_DatUseNum.Size = New System.Drawing.Size(47, 12)
        Me.Label_DatUseNum.TabIndex = 6
        Me.Label_DatUseNum.Text = "レス番号"
        '
        'Label_DatPath
        '
        Me.Label_DatPath.AutoSize = True
        Me.Label_DatPath.Location = New System.Drawing.Point(12, 18)
        Me.Label_DatPath.Margin = New System.Windows.Forms.Padding(3)
        Me.Label_DatPath.Name = "Label_DatPath"
        Me.Label_DatPath.Size = New System.Drawing.Size(39, 12)
        Me.Label_DatPath.TabIndex = 4
        Me.Label_DatPath.Text = "ファイル"
        '
        'Button_DatPathRef
        '
        Me.Button_DatPathRef.Location = New System.Drawing.Point(410, 16)
        Me.Button_DatPathRef.Name = "Button_DatPathRef"
        Me.Button_DatPathRef.Size = New System.Drawing.Size(37, 23)
        Me.Button_DatPathRef.TabIndex = 3
        Me.Button_DatPathRef.Text = "参照"
        Me.Button_DatPathRef.UseVisualStyleBackColor = True
        '
        'CheckBox_Asf
        '
        Me.CheckBox_Asf.AutoSize = True
        Me.CheckBox_Asf.Location = New System.Drawing.Point(10, 115)
        Me.CheckBox_Asf.Name = "CheckBox_Asf"
        Me.CheckBox_Asf.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox_Asf.TabIndex = 5
        Me.CheckBox_Asf.Text = "動画"
        Me.CheckBox_Asf.UseVisualStyleBackColor = True
        '
        'CheckBox_Dat
        '
        Me.CheckBox_Dat.AutoSize = True
        Me.CheckBox_Dat.Location = New System.Drawing.Point(10, 12)
        Me.CheckBox_Dat.Name = "CheckBox_Dat"
        Me.CheckBox_Dat.Size = New System.Drawing.Size(47, 16)
        Me.CheckBox_Dat.TabIndex = 0
        Me.CheckBox_Dat.Text = "DAT"
        Me.CheckBox_Dat.UseVisualStyleBackColor = True
        '
        'TabPage_Log
        '
        Me.TabPage_Log.Controls.Add(Me.DataGridView_Log)
        Me.TabPage_Log.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Log.Name = "TabPage_Log"
        Me.TabPage_Log.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Log.Size = New System.Drawing.Size(483, 401)
        Me.TabPage_Log.TabIndex = 1
        Me.TabPage_Log.Text = "ログ"
        Me.TabPage_Log.UseVisualStyleBackColor = True
        '
        'DataGridView_Log
        '
        Me.DataGridView_Log.AllowUserToAddRows = False
        Me.DataGridView_Log.AllowUserToDeleteRows = False
        Me.DataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Log.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Log.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_Log.Name = "DataGridView_Log"
        Me.DataGridView_Log.ReadOnly = True
        Me.DataGridView_Log.RowTemplate.Height = 21
        Me.DataGridView_Log.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView_Log.Size = New System.Drawing.Size(477, 395)
        Me.DataGridView_Log.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "body"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 360
        '
        'Column2
        '
        Me.Column2.HeaderText = "time"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "datファイル(*.dat)|*.dat|すべてのファイル(*.*)|*.*"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "メディアファイル(*.asf;*wmv;*.mpg;*.flv)|*.asf;*wmv;*.mpg;*.flv|すべてのファイル(*.*)|*.*"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.Filter = "テンプレートファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "dat解析実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabpage_Haven
        '
        Me.Tabpage_Haven.Controls.Add(Me.GroupBox1)
        Me.Tabpage_Haven.Location = New System.Drawing.Point(4, 22)
        Me.Tabpage_Haven.Name = "Tabpage_Haven"
        Me.Tabpage_Haven.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabpage_Haven.Size = New System.Drawing.Size(483, 401)
        Me.Tabpage_Haven.TabIndex = 2
        Me.Tabpage_Haven.Text = "避難所"
        Me.Tabpage_Haven.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_DatUseNumEnd_Haven)
        Me.GroupBox1.Controls.Add(Me.TextBox_DatPath_Haven)
        Me.GroupBox1.Controls.Add(Me.TextBox_DatUseNumStart_Haven)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button_DatPathRef_Haven)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "datファイル"
        '
        'TextBox_DatUseNumEnd_Haven
        '
        Me.TextBox_DatUseNumEnd_Haven.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_DatUseNumEnd_Haven.Location = New System.Drawing.Point(143, 44)
        Me.TextBox_DatUseNumEnd_Haven.Name = "TextBox_DatUseNumEnd_Haven"
        Me.TextBox_DatUseNumEnd_Haven.Size = New System.Drawing.Size(31, 19)
        Me.TextBox_DatUseNumEnd_Haven.TabIndex = 8
        '
        'TextBox_DatPath_Haven
        '
        Me.TextBox_DatPath_Haven.AllowDrop = True
        Me.TextBox_DatPath_Haven.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_DatPath_Haven.Location = New System.Drawing.Point(76, 18)
        Me.TextBox_DatPath_Haven.Name = "TextBox_DatPath_Haven"
        Me.TextBox_DatPath_Haven.Size = New System.Drawing.Size(327, 19)
        Me.TextBox_DatPath_Haven.TabIndex = 1
        '
        'TextBox_DatUseNumStart_Haven
        '
        Me.TextBox_DatUseNumStart_Haven.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_DatUseNumStart_Haven.Location = New System.Drawing.Point(76, 44)
        Me.TextBox_DatUseNumStart_Haven.Name = "TextBox_DatUseNumStart_Haven"
        Me.TextBox_DatUseNumStart_Haven.Size = New System.Drawing.Size(31, 19)
        Me.TextBox_DatUseNumStart_Haven.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "から"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "レス番号"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ファイル"
        '
        'Button_DatPathRef_Haven
        '
        Me.Button_DatPathRef_Haven.Location = New System.Drawing.Point(410, 16)
        Me.Button_DatPathRef_Haven.Name = "Button_DatPathRef_Haven"
        Me.Button_DatPathRef_Haven.Size = New System.Drawing.Size(37, 23)
        Me.Button_DatPathRef_Haven.TabIndex = 3
        Me.Button_DatPathRef_Haven.Text = "参照"
        Me.Button_DatPathRef_Haven.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 480)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl_Config)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "p2c"
        Me.TabControl_Config.ResumeLayout(False)
        Me.TabPage_Config.ResumeLayout(False)
        Me.TabPage_Config.PerformLayout()
        Me.GroupBox_Asf.ResumeLayout(False)
        Me.GroupBox_Asf.PerformLayout()
        Me.GroupBox_EndTime.ResumeLayout(False)
        Me.GroupBox_EndTime.PerformLayout()
        Me.GroupBox_Image.ResumeLayout(False)
        Me.GroupBox_Image.PerformLayout()
        Me.GroupBox_Cover.ResumeLayout(False)
        Me.GroupBox_Cover.PerformLayout()
        Me.GroupBox_StartTime.ResumeLayout(False)
        Me.GroupBox_StartTime.PerformLayout()
        Me.GroupBox_DAT.ResumeLayout(False)
        Me.GroupBox_DAT.PerformLayout()
        Me.TabPage_Log.ResumeLayout(False)
        CType(Me.DataGridView_Log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabpage_Haven.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_Config As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Config As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Log As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox_EndTime As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_StartTime As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_StartTimeNum As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_StartTimeSet As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_StartTimeSet As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_Asf As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Image As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Exec As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Log As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox_EndTimeSet As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_EndTimeSet As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_EndTimeSaveTime As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_ImageSetHeight As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ImageSetWidth As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_ImageSet As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_ImageNormal As System.Windows.Forms.RadioButton
    Friend WithEvents Label_x As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Dat As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox_Cover As System.Windows.Forms.GroupBox
    Friend WithEvents Label_sec As System.Windows.Forms.Label
    Friend WithEvents TextBox_CoverSetSec As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_DAT As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_DatPath As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_DatUseNumStart As System.Windows.Forms.TextBox
    Friend WithEvents Label_DatUseNumExp As System.Windows.Forms.Label
    Friend WithEvents Label_DatUseNum As System.Windows.Forms.Label
    Friend WithEvents Label_DatPath As System.Windows.Forms.Label
    Friend WithEvents Button_DatPathRef As System.Windows.Forms.Button
    Friend WithEvents Label_AsfPath As System.Windows.Forms.Label
    Friend WithEvents Button_AsfPath As System.Windows.Forms.Button
    Friend WithEvents TextBox_AsfPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_Asf As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox_DatUseNumEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox_SetTime As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_LiveStartTime As System.Windows.Forms.TextBox
    Friend WithEvents Label_LiveStartTime As System.Windows.Forms.Label
    Friend WithEvents Button_GetLiveStartTime As System.Windows.Forms.Button
    Friend WithEvents Tabpage_Haven As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_DatUseNumEnd_Haven As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_DatPath_Haven As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_DatUseNumStart_Haven As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_DatPathRef_Haven As System.Windows.Forms.Button
End Class
