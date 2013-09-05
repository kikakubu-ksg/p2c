<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.htmloutput = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.PreviousImage = New System.Windows.Forms.Button()
        Me.NextImage = New System.Windows.Forms.Button()
        Me.MessageSpace = New System.Windows.Forms.Label()
        Me.PreviousImageAll = New System.Windows.Forms.Button()
        Me.NextImageAll = New System.Windows.Forms.Button()
        Me.Label_ImageDir = New System.Windows.Forms.Label()
        Me.TextBox_ImageDir = New System.Windows.Forms.TextBox()
        Me.Label_Decorate = New System.Windows.Forms.Label()
        Me.Button_Normal = New System.Windows.Forms.Button()
        Me.Button_EX1 = New System.Windows.Forms.Button()
        Me.Button_EX2 = New System.Windows.Forms.Button()
        Me.Button_EX3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(1036, 575)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'UpButton
        '
        Me.UpButton.Location = New System.Drawing.Point(2, 182)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(27, 23)
        Me.UpButton.TabIndex = 1
        Me.UpButton.Text = "▲"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Location = New System.Drawing.Point(2, 211)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(27, 23)
        Me.DownButton.TabIndex = 2
        Me.DownButton.Text = "▼"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'htmloutput
        '
        Me.htmloutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.htmloutput.Location = New System.Drawing.Point(992, 650)
        Me.htmloutput.Name = "htmloutput"
        Me.htmloutput.Size = New System.Drawing.Size(75, 23)
        Me.htmloutput.TabIndex = 4
        Me.htmloutput.Text = "HTML出力"
        Me.htmloutput.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.Location = New System.Drawing.Point(2, 240)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(27, 24)
        Me.RightButton.TabIndex = 5
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.Location = New System.Drawing.Point(2, 270)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(27, 23)
        Me.LeftButton.TabIndex = 6
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'PreviousImage
        '
        Me.PreviousImage.Location = New System.Drawing.Point(31, 12)
        Me.PreviousImage.Name = "PreviousImage"
        Me.PreviousImage.Size = New System.Drawing.Size(100, 23)
        Me.PreviousImage.TabIndex = 7
        Me.PreviousImage.Text = "前の画像"
        Me.PreviousImage.UseVisualStyleBackColor = True
        '
        'NextImage
        '
        Me.NextImage.Location = New System.Drawing.Point(137, 12)
        Me.NextImage.Name = "NextImage"
        Me.NextImage.Size = New System.Drawing.Size(99, 23)
        Me.NextImage.TabIndex = 8
        Me.NextImage.Text = "次の画像"
        Me.NextImage.UseVisualStyleBackColor = True
        '
        'MessageSpace
        '
        Me.MessageSpace.AutoSize = True
        Me.MessageSpace.Location = New System.Drawing.Point(242, 17)
        Me.MessageSpace.Name = "MessageSpace"
        Me.MessageSpace.Size = New System.Drawing.Size(50, 12)
        Me.MessageSpace.TabIndex = 9
        Me.MessageSpace.Text = "message"
        '
        'PreviousImageAll
        '
        Me.PreviousImageAll.Location = New System.Drawing.Point(31, 41)
        Me.PreviousImageAll.Name = "PreviousImageAll"
        Me.PreviousImageAll.Size = New System.Drawing.Size(100, 23)
        Me.PreviousImageAll.TabIndex = 10
        Me.PreviousImageAll.Text = "全部前の画像"
        Me.PreviousImageAll.UseVisualStyleBackColor = True
        '
        'NextImageAll
        '
        Me.NextImageAll.Location = New System.Drawing.Point(137, 41)
        Me.NextImageAll.Name = "NextImageAll"
        Me.NextImageAll.Size = New System.Drawing.Size(100, 23)
        Me.NextImageAll.TabIndex = 11
        Me.NextImageAll.Text = "全部次の画像"
        Me.NextImageAll.UseVisualStyleBackColor = True
        '
        'Label_ImageDir
        '
        Me.Label_ImageDir.AutoSize = True
        Me.Label_ImageDir.Location = New System.Drawing.Point(438, 17)
        Me.Label_ImageDir.Name = "Label_ImageDir"
        Me.Label_ImageDir.Size = New System.Drawing.Size(83, 12)
        Me.Label_ImageDir.TabIndex = 12
        Me.Label_ImageDir.Text = "画像フォルダパス"
        '
        'TextBox_ImageDir
        '
        Me.TextBox_ImageDir.Location = New System.Drawing.Point(550, 12)
        Me.TextBox_ImageDir.Name = "TextBox_ImageDir"
        Me.TextBox_ImageDir.Size = New System.Drawing.Size(417, 19)
        Me.TextBox_ImageDir.TabIndex = 13
        '
        'Label_Decorate
        '
        Me.Label_Decorate.AutoSize = True
        Me.Label_Decorate.Location = New System.Drawing.Point(438, 46)
        Me.Label_Decorate.Name = "Label_Decorate"
        Me.Label_Decorate.Size = New System.Drawing.Size(58, 12)
        Me.Label_Decorate.TabIndex = 14
        Me.Label_Decorate.Text = "セルを修飾"
        '
        'Button_Normal
        '
        Me.Button_Normal.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Normal.Location = New System.Drawing.Point(502, 41)
        Me.Button_Normal.Name = "Button_Normal"
        Me.Button_Normal.Size = New System.Drawing.Size(51, 23)
        Me.Button_Normal.TabIndex = 15
        Me.Button_Normal.Text = "Normal"
        Me.Button_Normal.UseVisualStyleBackColor = False
        '
        'Button_EX1
        '
        Me.Button_EX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_EX1.Location = New System.Drawing.Point(559, 41)
        Me.Button_EX1.Name = "Button_EX1"
        Me.Button_EX1.Size = New System.Drawing.Size(51, 23)
        Me.Button_EX1.TabIndex = 16
        Me.Button_EX1.Text = "Ex1"
        Me.Button_EX1.UseVisualStyleBackColor = False
        '
        'Button_EX2
        '
        Me.Button_EX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_EX2.Location = New System.Drawing.Point(616, 41)
        Me.Button_EX2.Name = "Button_EX2"
        Me.Button_EX2.Size = New System.Drawing.Size(51, 23)
        Me.Button_EX2.TabIndex = 17
        Me.Button_EX2.Text = "Ex2"
        Me.Button_EX2.UseVisualStyleBackColor = False
        '
        'Button_EX3
        '
        Me.Button_EX3.BackColor = System.Drawing.Color.Yellow
        Me.Button_EX3.Location = New System.Drawing.Point(673, 41)
        Me.Button_EX3.Name = "Button_EX3"
        Me.Button_EX3.Size = New System.Drawing.Size(51, 23)
        Me.Button_EX3.TabIndex = 18
        Me.Button_EX3.Text = "Ex3"
        Me.Button_EX3.UseVisualStyleBackColor = False
        '
        'view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 681)
        Me.Controls.Add(Me.Button_EX3)
        Me.Controls.Add(Me.Button_EX2)
        Me.Controls.Add(Me.Button_EX1)
        Me.Controls.Add(Me.Button_Normal)
        Me.Controls.Add(Me.Label_Decorate)
        Me.Controls.Add(Me.TextBox_ImageDir)
        Me.Controls.Add(Me.Label_ImageDir)
        Me.Controls.Add(Me.NextImageAll)
        Me.Controls.Add(Me.PreviousImageAll)
        Me.Controls.Add(Me.MessageSpace)
        Me.Controls.Add(Me.NextImage)
        Me.Controls.Add(Me.PreviousImage)
        Me.Controls.Add(Me.LeftButton)
        Me.Controls.Add(Me.RightButton)
        Me.Controls.Add(Me.htmloutput)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "view"
        Me.Text = "編集フォーム"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents UpButton As System.Windows.Forms.Button
    Friend WithEvents DownButton As System.Windows.Forms.Button
    Friend WithEvents htmloutput As System.Windows.Forms.Button
    Friend WithEvents RightButton As System.Windows.Forms.Button
    Friend WithEvents LeftButton As System.Windows.Forms.Button
    Friend WithEvents PreviousImage As System.Windows.Forms.Button
    Friend WithEvents NextImage As System.Windows.Forms.Button
    Friend WithEvents MessageSpace As System.Windows.Forms.Label
    Friend WithEvents PreviousImageAll As System.Windows.Forms.Button
    Friend WithEvents NextImageAll As System.Windows.Forms.Button
    Friend WithEvents Label_ImageDir As System.Windows.Forms.Label
    Friend WithEvents TextBox_ImageDir As System.Windows.Forms.TextBox
    Friend WithEvents Label_Decorate As System.Windows.Forms.Label
    Friend WithEvents Button_Normal As System.Windows.Forms.Button
    Friend WithEvents Button_EX1 As System.Windows.Forms.Button
    Friend WithEvents Button_EX2 As System.Windows.Forms.Button
    Friend WithEvents Button_EX3 As System.Windows.Forms.Button

End Class
