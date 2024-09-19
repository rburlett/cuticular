<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_START_DAQ = New System.Windows.Forms.Timer(Me.components)
        Me.Bt_START_STOP = New System.Windows.Forms.Button()
        Me.Timer1sec = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox_time = New System.Windows.Forms.TextBox()
        Me.Button_read_once = New System.Windows.Forms.Button()
        Me.DataGridView_samplenames = New System.Windows.Forms.DataGridView()
        Me.Column_serialnb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button_updateMySettings = New System.Windows.Forms.Button()
        Me.Label_n01 = New System.Windows.Forms.Label()
        Me.ComboBox_daq02 = New System.Windows.Forms.ComboBox()
        Me.Label_n02 = New System.Windows.Forms.Label()
        Me.ComboBox_daq03 = New System.Windows.Forms.ComboBox()
        Me.Label_n03 = New System.Windows.Forms.Label()
        Me.ComboBox_daq04 = New System.Windows.Forms.ComboBox()
        Me.Label_n04 = New System.Windows.Forms.Label()
        Me.ComboBox_daq05 = New System.Windows.Forms.ComboBox()
        Me.Label_n05 = New System.Windows.Forms.Label()
        Me.ComboBox_daq07 = New System.Windows.Forms.ComboBox()
        Me.Label_n07 = New System.Windows.Forms.Label()
        Me.ComboBox_daq08 = New System.Windows.Forms.ComboBox()
        Me.Label_n08 = New System.Windows.Forms.Label()
        Me.ComboBox_daq09 = New System.Windows.Forms.ComboBox()
        Me.Label_n09 = New System.Windows.Forms.Label()
        Me.ComboBox_daq10 = New System.Windows.Forms.ComboBox()
        Me.Label_n10 = New System.Windows.Forms.Label()
        Me.ComboBox_daq11 = New System.Windows.Forms.ComboBox()
        Me.Label_n11 = New System.Windows.Forms.Label()
        Me.ComboBox_daq06 = New System.Windows.Forms.ComboBox()
        Me.Label_n06 = New System.Windows.Forms.Label()
        Me.ComboBox_daq12 = New System.Windows.Forms.ComboBox()
        Me.Label_n12 = New System.Windows.Forms.Label()
        Me.ComboBox_daq01 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation01 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_addrow = New System.Windows.Forms.Button()
        Me.Button_removerow = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_affectation12 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation11 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation10 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation09 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation08 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation07 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation06 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation05 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation04 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation03 = New System.Windows.Forms.ComboBox()
        Me.ComboBox_affectation02 = New System.Windows.Forms.ComboBox()
        Me.Button_advacnedsetting = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.serial_LBL = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView_rawdata = New System.Windows.Forms.DataGridView()
        Me.Column_date_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_campaign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_met = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumericUpDown_meas_interval_min = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_lightintensity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_experimentname = New System.Windows.Forms.TextBox()
        Me.TextBox_comment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_campaign = New System.Windows.Forms.TextBox()
        Me.Button_calibration = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button_zero = New System.Windows.Forms.Button()
        Me.Label_message = New System.Windows.Forms.Label()
        Me.SaveFileDialog_rawdata = New System.Windows.Forms.SaveFileDialog()
        Me.Label_status = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label_calib = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView_samplenames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_rawdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_meas_interval_min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1400, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.OpenToolStripMenuItem.Text = "Save"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AboutToolStripMenuItem.Text = "about"
        '
        'Timer_START_DAQ
        '
        Me.Timer_START_DAQ.Interval = 60000
        '
        'Bt_START_STOP
        '
        Me.Bt_START_STOP.Location = New System.Drawing.Point(187, 37)
        Me.Bt_START_STOP.Name = "Bt_START_STOP"
        Me.Bt_START_STOP.Size = New System.Drawing.Size(102, 106)
        Me.Bt_START_STOP.TabIndex = 7
        Me.Bt_START_STOP.Text = "START ACQUISITION"
        Me.Bt_START_STOP.UseVisualStyleBackColor = True
        '
        'Timer1sec
        '
        Me.Timer1sec.Enabled = True
        Me.Timer1sec.Interval = 1000
        '
        'SerialPort1
        '
        '
        'TextBox_time
        '
        Me.TextBox_time.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TextBox_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox_time.Location = New System.Drawing.Point(1069, 27)
        Me.TextBox_time.Multiline = True
        Me.TextBox_time.Name = "TextBox_time"
        Me.TextBox_time.ReadOnly = True
        Me.TextBox_time.Size = New System.Drawing.Size(289, 48)
        Me.TextBox_time.TabIndex = 31
        Me.TextBox_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_read_once
        '
        Me.Button_read_once.Location = New System.Drawing.Point(110, 37)
        Me.Button_read_once.Name = "Button_read_once"
        Me.Button_read_once.Size = New System.Drawing.Size(71, 106)
        Me.Button_read_once.TabIndex = 32
        Me.Button_read_once.Text = "Read once"
        Me.Button_read_once.UseVisualStyleBackColor = True
        '
        'DataGridView_samplenames
        '
        Me.DataGridView_samplenames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_samplenames.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_serialnb, Me.Column_channel1, Me.Column_channel2, Me.Column_channel3, Me.Column_channel4})
        Me.DataGridView_samplenames.Location = New System.Drawing.Point(155, 31)
        Me.DataGridView_samplenames.Name = "DataGridView_samplenames"
        Me.DataGridView_samplenames.Size = New System.Drawing.Size(544, 329)
        Me.DataGridView_samplenames.TabIndex = 33
        '
        'Column_serialnb
        '
        Me.Column_serialnb.HeaderText = "SERIAL NUMBER"
        Me.Column_serialnb.Name = "Column_serialnb"
        '
        'Column_channel1
        '
        Me.Column_channel1.HeaderText = "Channel_01"
        Me.Column_channel1.Name = "Column_channel1"
        '
        'Column_channel2
        '
        Me.Column_channel2.HeaderText = "Channel_02"
        Me.Column_channel2.Name = "Column_channel2"
        '
        'Column_channel3
        '
        Me.Column_channel3.HeaderText = "Channel_03"
        Me.Column_channel3.Name = "Column_channel3"
        '
        'Column_channel4
        '
        Me.Column_channel4.HeaderText = "Channel_04"
        Me.Column_channel4.Name = "Column_channel4"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Tahoma", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(292, 48)
        Me.RichTextBox1.TabIndex = 122
        Me.RichTextBox1.Text = "CutiCular 2.0"
        '
        'Button_updateMySettings
        '
        Me.Button_updateMySettings.Location = New System.Drawing.Point(163, 41)
        Me.Button_updateMySettings.Name = "Button_updateMySettings"
        Me.Button_updateMySettings.Size = New System.Drawing.Size(69, 106)
        Me.Button_updateMySettings.TabIndex = 18
        Me.Button_updateMySettings.Text = "Update layout"
        Me.Button_updateMySettings.UseVisualStyleBackColor = True
        '
        'Label_n01
        '
        Me.Label_n01.AutoSize = True
        Me.Label_n01.Location = New System.Drawing.Point(6, 34)
        Me.Label_n01.Name = "Label_n01"
        Me.Label_n01.Size = New System.Drawing.Size(20, 13)
        Me.Label_n01.TabIndex = 19
        Me.Label_n01.Text = "#1"
        '
        'ComboBox_daq02
        '
        Me.ComboBox_daq02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq02.FormattingEnabled = True
        Me.ComboBox_daq02.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq02.Location = New System.Drawing.Point(33, 59)
        Me.ComboBox_daq02.Name = "ComboBox_daq02"
        Me.ComboBox_daq02.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq02.TabIndex = 20
        '
        'Label_n02
        '
        Me.Label_n02.AutoSize = True
        Me.Label_n02.Location = New System.Drawing.Point(7, 62)
        Me.Label_n02.Name = "Label_n02"
        Me.Label_n02.Size = New System.Drawing.Size(20, 13)
        Me.Label_n02.TabIndex = 21
        Me.Label_n02.Text = "#2"
        '
        'ComboBox_daq03
        '
        Me.ComboBox_daq03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq03.FormattingEnabled = True
        Me.ComboBox_daq03.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq03.Location = New System.Drawing.Point(33, 86)
        Me.ComboBox_daq03.Name = "ComboBox_daq03"
        Me.ComboBox_daq03.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq03.TabIndex = 22
        '
        'Label_n03
        '
        Me.Label_n03.AutoSize = True
        Me.Label_n03.Location = New System.Drawing.Point(6, 89)
        Me.Label_n03.Name = "Label_n03"
        Me.Label_n03.Size = New System.Drawing.Size(20, 13)
        Me.Label_n03.TabIndex = 23
        Me.Label_n03.Text = "#3"
        '
        'ComboBox_daq04
        '
        Me.ComboBox_daq04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq04.FormattingEnabled = True
        Me.ComboBox_daq04.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq04.Location = New System.Drawing.Point(33, 113)
        Me.ComboBox_daq04.Name = "ComboBox_daq04"
        Me.ComboBox_daq04.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq04.TabIndex = 24
        '
        'Label_n04
        '
        Me.Label_n04.AutoSize = True
        Me.Label_n04.Location = New System.Drawing.Point(6, 116)
        Me.Label_n04.Name = "Label_n04"
        Me.Label_n04.Size = New System.Drawing.Size(20, 13)
        Me.Label_n04.TabIndex = 25
        Me.Label_n04.Text = "#4"
        '
        'ComboBox_daq05
        '
        Me.ComboBox_daq05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq05.FormattingEnabled = True
        Me.ComboBox_daq05.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq05.Location = New System.Drawing.Point(33, 140)
        Me.ComboBox_daq05.Name = "ComboBox_daq05"
        Me.ComboBox_daq05.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq05.TabIndex = 26
        '
        'Label_n05
        '
        Me.Label_n05.AutoSize = True
        Me.Label_n05.Location = New System.Drawing.Point(6, 143)
        Me.Label_n05.Name = "Label_n05"
        Me.Label_n05.Size = New System.Drawing.Size(20, 13)
        Me.Label_n05.TabIndex = 27
        Me.Label_n05.Text = "#5"
        '
        'ComboBox_daq07
        '
        Me.ComboBox_daq07.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq07.FormattingEnabled = True
        Me.ComboBox_daq07.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq07.Location = New System.Drawing.Point(33, 196)
        Me.ComboBox_daq07.Name = "ComboBox_daq07"
        Me.ComboBox_daq07.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq07.TabIndex = 34
        '
        'Label_n07
        '
        Me.Label_n07.AutoSize = True
        Me.Label_n07.Location = New System.Drawing.Point(6, 199)
        Me.Label_n07.Name = "Label_n07"
        Me.Label_n07.Size = New System.Drawing.Size(20, 13)
        Me.Label_n07.TabIndex = 35
        Me.Label_n07.Text = "#7"
        '
        'ComboBox_daq08
        '
        Me.ComboBox_daq08.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq08.FormattingEnabled = True
        Me.ComboBox_daq08.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq08.Location = New System.Drawing.Point(33, 224)
        Me.ComboBox_daq08.Name = "ComboBox_daq08"
        Me.ComboBox_daq08.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq08.TabIndex = 36
        '
        'Label_n08
        '
        Me.Label_n08.AutoSize = True
        Me.Label_n08.Location = New System.Drawing.Point(6, 227)
        Me.Label_n08.Name = "Label_n08"
        Me.Label_n08.Size = New System.Drawing.Size(20, 13)
        Me.Label_n08.TabIndex = 37
        Me.Label_n08.Text = "#8"
        '
        'ComboBox_daq09
        '
        Me.ComboBox_daq09.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq09.FormattingEnabled = True
        Me.ComboBox_daq09.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq09.Location = New System.Drawing.Point(33, 251)
        Me.ComboBox_daq09.Name = "ComboBox_daq09"
        Me.ComboBox_daq09.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq09.TabIndex = 38
        '
        'Label_n09
        '
        Me.Label_n09.AutoSize = True
        Me.Label_n09.Location = New System.Drawing.Point(6, 254)
        Me.Label_n09.Name = "Label_n09"
        Me.Label_n09.Size = New System.Drawing.Size(20, 13)
        Me.Label_n09.TabIndex = 39
        Me.Label_n09.Text = "#9"
        '
        'ComboBox_daq10
        '
        Me.ComboBox_daq10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq10.FormattingEnabled = True
        Me.ComboBox_daq10.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq10.Location = New System.Drawing.Point(33, 278)
        Me.ComboBox_daq10.Name = "ComboBox_daq10"
        Me.ComboBox_daq10.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq10.TabIndex = 40
        '
        'Label_n10
        '
        Me.Label_n10.AutoSize = True
        Me.Label_n10.Location = New System.Drawing.Point(6, 281)
        Me.Label_n10.Name = "Label_n10"
        Me.Label_n10.Size = New System.Drawing.Size(26, 13)
        Me.Label_n10.TabIndex = 41
        Me.Label_n10.Text = "#10"
        '
        'ComboBox_daq11
        '
        Me.ComboBox_daq11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq11.FormattingEnabled = True
        Me.ComboBox_daq11.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq11.Location = New System.Drawing.Point(33, 305)
        Me.ComboBox_daq11.Name = "ComboBox_daq11"
        Me.ComboBox_daq11.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq11.TabIndex = 42
        '
        'Label_n11
        '
        Me.Label_n11.AutoSize = True
        Me.Label_n11.Location = New System.Drawing.Point(6, 308)
        Me.Label_n11.Name = "Label_n11"
        Me.Label_n11.Size = New System.Drawing.Size(26, 13)
        Me.Label_n11.TabIndex = 43
        Me.Label_n11.Text = "#11"
        '
        'ComboBox_daq06
        '
        Me.ComboBox_daq06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq06.FormattingEnabled = True
        Me.ComboBox_daq06.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq06.Location = New System.Drawing.Point(32, 167)
        Me.ComboBox_daq06.Name = "ComboBox_daq06"
        Me.ComboBox_daq06.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq06.TabIndex = 28
        '
        'Label_n06
        '
        Me.Label_n06.AutoSize = True
        Me.Label_n06.Location = New System.Drawing.Point(7, 170)
        Me.Label_n06.Name = "Label_n06"
        Me.Label_n06.Size = New System.Drawing.Size(20, 13)
        Me.Label_n06.TabIndex = 29
        Me.Label_n06.Text = "#6"
        '
        'ComboBox_daq12
        '
        Me.ComboBox_daq12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq12.FormattingEnabled = True
        Me.ComboBox_daq12.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq12.Location = New System.Drawing.Point(33, 332)
        Me.ComboBox_daq12.Name = "ComboBox_daq12"
        Me.ComboBox_daq12.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq12.TabIndex = 44
        '
        'Label_n12
        '
        Me.Label_n12.AutoSize = True
        Me.Label_n12.Location = New System.Drawing.Point(7, 335)
        Me.Label_n12.Name = "Label_n12"
        Me.Label_n12.Size = New System.Drawing.Size(26, 13)
        Me.Label_n12.TabIndex = 47
        Me.Label_n12.Text = "#12"
        '
        'ComboBox_daq01
        '
        Me.ComboBox_daq01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox_daq01.FormattingEnabled = True
        Me.ComboBox_daq01.Items.AddRange(New Object() {"582611", "583433", "588686", "589036", "589048", "589162", "582611", "583433", "588686", "589036", "589048", "589162", "582611"})
        Me.ComboBox_daq01.Location = New System.Drawing.Point(32, 31)
        Me.ComboBox_daq01.Name = "ComboBox_daq01"
        Me.ComboBox_daq01.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_daq01.TabIndex = 52
        '
        'ComboBox_affectation01
        '
        Me.ComboBox_affectation01.FormattingEnabled = True
        Me.ComboBox_affectation01.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation01.Location = New System.Drawing.Point(103, 31)
        Me.ComboBox_affectation01.Name = "ComboBox_affectation01"
        Me.ComboBox_affectation01.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation01.TabIndex = 53
        Me.ComboBox_affectation01.Text = "A"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button_addrow)
        Me.GroupBox1.Controls.Add(Me.Button_removerow)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation12)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation11)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation10)
        Me.GroupBox1.Controls.Add(Me.DataGridView_samplenames)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation09)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation08)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation07)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation06)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation05)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation04)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation03)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation02)
        Me.GroupBox1.Controls.Add(Me.ComboBox_affectation01)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq01)
        Me.GroupBox1.Controls.Add(Me.Label_n12)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq12)
        Me.GroupBox1.Controls.Add(Me.Label_n06)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq06)
        Me.GroupBox1.Controls.Add(Me.Label_n11)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq11)
        Me.GroupBox1.Controls.Add(Me.Label_n10)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq10)
        Me.GroupBox1.Controls.Add(Me.Label_n09)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq09)
        Me.GroupBox1.Controls.Add(Me.Label_n08)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq08)
        Me.GroupBox1.Controls.Add(Me.Label_n07)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq07)
        Me.GroupBox1.Controls.Add(Me.Label_n05)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq05)
        Me.GroupBox1.Controls.Add(Me.Label_n04)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq04)
        Me.GroupBox1.Controls.Add(Me.Label_n03)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq03)
        Me.GroupBox1.Controls.Add(Me.Label_n02)
        Me.GroupBox1.Controls.Add(Me.ComboBox_daq02)
        Me.GroupBox1.Controls.Add(Me.Label_n01)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 394)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EXPERIMENT LAYOUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "SAMPLES NAMES"
        '
        'Button_addrow
        '
        Me.Button_addrow.AutoEllipsis = True
        Me.Button_addrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_addrow.Location = New System.Drawing.Point(701, 288)
        Me.Button_addrow.Name = "Button_addrow"
        Me.Button_addrow.Size = New System.Drawing.Size(33, 33)
        Me.Button_addrow.TabIndex = 126
        Me.Button_addrow.Text = "+"
        Me.Button_addrow.UseVisualStyleBackColor = True
        '
        'Button_removerow
        '
        Me.Button_removerow.AutoEllipsis = True
        Me.Button_removerow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_removerow.Location = New System.Drawing.Point(701, 320)
        Me.Button_removerow.Name = "Button_removerow"
        Me.Button_removerow.Size = New System.Drawing.Size(33, 33)
        Me.Button_removerow.TabIndex = 127
        Me.Button_removerow.Text = "-"
        Me.Button_removerow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Zone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Serial number"
        '
        'ComboBox_affectation12
        '
        Me.ComboBox_affectation12.FormattingEnabled = True
        Me.ComboBox_affectation12.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation12.Location = New System.Drawing.Point(103, 332)
        Me.ComboBox_affectation12.Name = "ComboBox_affectation12"
        Me.ComboBox_affectation12.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation12.TabIndex = 64
        Me.ComboBox_affectation12.Text = "A"
        '
        'ComboBox_affectation11
        '
        Me.ComboBox_affectation11.FormattingEnabled = True
        Me.ComboBox_affectation11.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation11.Location = New System.Drawing.Point(103, 305)
        Me.ComboBox_affectation11.Name = "ComboBox_affectation11"
        Me.ComboBox_affectation11.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation11.TabIndex = 63
        Me.ComboBox_affectation11.Text = "A"
        '
        'ComboBox_affectation10
        '
        Me.ComboBox_affectation10.FormattingEnabled = True
        Me.ComboBox_affectation10.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation10.Location = New System.Drawing.Point(103, 278)
        Me.ComboBox_affectation10.Name = "ComboBox_affectation10"
        Me.ComboBox_affectation10.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation10.TabIndex = 62
        Me.ComboBox_affectation10.Text = "A"
        '
        'ComboBox_affectation09
        '
        Me.ComboBox_affectation09.FormattingEnabled = True
        Me.ComboBox_affectation09.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation09.Location = New System.Drawing.Point(103, 251)
        Me.ComboBox_affectation09.Name = "ComboBox_affectation09"
        Me.ComboBox_affectation09.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation09.TabIndex = 61
        Me.ComboBox_affectation09.Text = "A"
        '
        'ComboBox_affectation08
        '
        Me.ComboBox_affectation08.FormattingEnabled = True
        Me.ComboBox_affectation08.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation08.Location = New System.Drawing.Point(103, 223)
        Me.ComboBox_affectation08.Name = "ComboBox_affectation08"
        Me.ComboBox_affectation08.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation08.TabIndex = 60
        Me.ComboBox_affectation08.Text = "A"
        '
        'ComboBox_affectation07
        '
        Me.ComboBox_affectation07.FormattingEnabled = True
        Me.ComboBox_affectation07.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation07.Location = New System.Drawing.Point(103, 196)
        Me.ComboBox_affectation07.Name = "ComboBox_affectation07"
        Me.ComboBox_affectation07.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation07.TabIndex = 59
        Me.ComboBox_affectation07.Text = "A"
        '
        'ComboBox_affectation06
        '
        Me.ComboBox_affectation06.FormattingEnabled = True
        Me.ComboBox_affectation06.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation06.Location = New System.Drawing.Point(103, 167)
        Me.ComboBox_affectation06.Name = "ComboBox_affectation06"
        Me.ComboBox_affectation06.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation06.TabIndex = 58
        Me.ComboBox_affectation06.Text = "A"
        '
        'ComboBox_affectation05
        '
        Me.ComboBox_affectation05.FormattingEnabled = True
        Me.ComboBox_affectation05.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation05.Location = New System.Drawing.Point(103, 140)
        Me.ComboBox_affectation05.Name = "ComboBox_affectation05"
        Me.ComboBox_affectation05.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation05.TabIndex = 57
        Me.ComboBox_affectation05.Text = "A"
        '
        'ComboBox_affectation04
        '
        Me.ComboBox_affectation04.FormattingEnabled = True
        Me.ComboBox_affectation04.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation04.Location = New System.Drawing.Point(103, 116)
        Me.ComboBox_affectation04.Name = "ComboBox_affectation04"
        Me.ComboBox_affectation04.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation04.TabIndex = 56
        Me.ComboBox_affectation04.Text = "A"
        '
        'ComboBox_affectation03
        '
        Me.ComboBox_affectation03.FormattingEnabled = True
        Me.ComboBox_affectation03.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation03.Location = New System.Drawing.Point(103, 86)
        Me.ComboBox_affectation03.Name = "ComboBox_affectation03"
        Me.ComboBox_affectation03.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation03.TabIndex = 55
        Me.ComboBox_affectation03.Text = "A"
        '
        'ComboBox_affectation02
        '
        Me.ComboBox_affectation02.FormattingEnabled = True
        Me.ComboBox_affectation02.Items.AddRange(New Object() {"OFF", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ComboBox_affectation02.Location = New System.Drawing.Point(103, 59)
        Me.ComboBox_affectation02.Name = "ComboBox_affectation02"
        Me.ComboBox_affectation02.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox_affectation02.TabIndex = 54
        Me.ComboBox_affectation02.Text = "A"
        '
        'Button_advacnedsetting
        '
        Me.Button_advacnedsetting.Location = New System.Drawing.Point(421, 19)
        Me.Button_advacnedsetting.Name = "Button_advacnedsetting"
        Me.Button_advacnedsetting.Size = New System.Drawing.Size(138, 47)
        Me.Button_advacnedsetting.TabIndex = 65
        Me.Button_advacnedsetting.Text = "Advanced Settings"
        Me.Button_advacnedsetting.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(25, 93)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(121, 52)
        Me.connect_BTN.TabIndex = 19
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(21, 36)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(78, 20)
        Me.COMport_LBL.TabIndex = 17
        Me.COMport_LBL.Text = "COM Port"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(25, 59)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.comPort_ComboBox.TabIndex = 18
        '
        'serial_LBL
        '
        Me.serial_LBL.AutoSize = True
        Me.serial_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serial_LBL.ForeColor = System.Drawing.Color.Red
        Me.serial_LBL.Location = New System.Drawing.Point(23, 148)
        Me.serial_LBL.Name = "serial_LBL"
        Me.serial_LBL.Size = New System.Drawing.Size(76, 13)
        Me.serial_LBL.TabIndex = 24
        Me.serial_LBL.Text = "not connected"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.serial_LBL)
        Me.GroupBox2.Controls.Add(Me.comPort_ComboBox)
        Me.GroupBox2.Controls.Add(Me.COMport_LBL)
        Me.GroupBox2.Controls.Add(Me.connect_BTN)
        Me.GroupBox2.Controls.Add(Me.Button_updateMySettings)
        Me.GroupBox2.Location = New System.Drawing.Point(799, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 170)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SETUP"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(799, 759)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 20)
        Me.TextBox1.TabIndex = 125
        '
        'DataGridView_rawdata
        '
        Me.DataGridView_rawdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_rawdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_date_time, Me.Column_campaign, Me.Column_comment, Me.Column_met})
        Me.DataGridView_rawdata.Location = New System.Drawing.Point(17, 491)
        Me.DataGridView_rawdata.Name = "DataGridView_rawdata"
        Me.DataGridView_rawdata.Size = New System.Drawing.Size(1355, 258)
        Me.DataGridView_rawdata.TabIndex = 126
        '
        'Column_date_time
        '
        Me.Column_date_time.HeaderText = "date_time"
        Me.Column_date_time.Name = "Column_date_time"
        Me.Column_date_time.Width = 130
        '
        'Column_campaign
        '
        Me.Column_campaign.HeaderText = "Campaign"
        Me.Column_campaign.Name = "Column_campaign"
        '
        'Column_comment
        '
        Me.Column_comment.HeaderText = "Comment"
        Me.Column_comment.Name = "Column_comment"
        '
        'Column_met
        '
        Me.Column_met.HeaderText = "Temp_A,RH_A,Temp_B,RH_B,Temp_C,RH_C,Temp_D,RH_D"
        Me.Column_met.Name = "Column_met"
        '
        'NumericUpDown_meas_interval_min
        '
        Me.NumericUpDown_meas_interval_min.Location = New System.Drawing.Point(163, 117)
        Me.NumericUpDown_meas_interval_min.Name = "NumericUpDown_meas_interval_min"
        Me.NumericUpDown_meas_interval_min.Size = New System.Drawing.Size(69, 20)
        Me.NumericUpDown_meas_interval_min.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Measurement interval_min"
        '
        'TextBox_lightintensity
        '
        Me.TextBox_lightintensity.Location = New System.Drawing.Point(99, 90)
        Me.TextBox_lightintensity.Name = "TextBox_lightintensity"
        Me.TextBox_lightintensity.Size = New System.Drawing.Size(133, 20)
        Me.TextBox_lightintensity.TabIndex = 129
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Light intensity"
        '
        'TextBox_experimentname
        '
        Me.TextBox_experimentname.Location = New System.Drawing.Point(99, 17)
        Me.TextBox_experimentname.Name = "TextBox_experimentname"
        Me.TextBox_experimentname.Size = New System.Drawing.Size(298, 20)
        Me.TextBox_experimentname.TabIndex = 131
        '
        'TextBox_comment
        '
        Me.TextBox_comment.Location = New System.Drawing.Point(99, 63)
        Me.TextBox_comment.Name = "TextBox_comment"
        Me.TextBox_comment.Size = New System.Drawing.Size(298, 20)
        Me.TextBox_comment.TabIndex = 132
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Comments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Experiment name"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextBox_campaign)
        Me.GroupBox5.Controls.Add(Me.Button_calibration)
        Me.GroupBox5.Controls.Add(Me.CheckBox2)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.NumericUpDown_meas_interval_min)
        Me.GroupBox5.Controls.Add(Me.TextBox_comment)
        Me.GroupBox5.Controls.Add(Me.TextBox_experimentname)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TextBox_lightintensity)
        Me.GroupBox5.Controls.Add(Me.Button_advacnedsetting)
        Me.GroupBox5.Location = New System.Drawing.Point(799, 91)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(573, 178)
        Me.GroupBox5.TabIndex = 135
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PARAMETERS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cuticular.My.Resources.Resources.save
        Me.PictureBox1.Location = New System.Drawing.Point(343, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 137
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Campaign"
        '
        'TextBox_campaign
        '
        Me.TextBox_campaign.Location = New System.Drawing.Point(99, 40)
        Me.TextBox_campaign.Name = "TextBox_campaign"
        Me.TextBox_campaign.Size = New System.Drawing.Size(298, 20)
        Me.TextBox_campaign.TabIndex = 140
        '
        'Button_calibration
        '
        Me.Button_calibration.Location = New System.Drawing.Point(421, 74)
        Me.Button_calibration.Name = "Button_calibration"
        Me.Button_calibration.Size = New System.Drawing.Size(138, 50)
        Me.Button_calibration.TabIndex = 136
        Me.Button_calibration.Text = "CALIBRATION FACTORS"
        Me.Button_calibration.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(423, 141)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox2.TabIndex = 139
        Me.CheckBox2.Text = "use calibrated values"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button_zero
        '
        Me.Button_zero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_zero.ForeColor = System.Drawing.Color.Black
        Me.Button_zero.Location = New System.Drawing.Point(21, 37)
        Me.Button_zero.Name = "Button_zero"
        Me.Button_zero.Size = New System.Drawing.Size(83, 106)
        Me.Button_zero.TabIndex = 138
        Me.Button_zero.Text = "ZERO SENSORS"
        Me.Button_zero.UseVisualStyleBackColor = False
        '
        'Label_message
        '
        Me.Label_message.AutoSize = True
        Me.Label_message.Location = New System.Drawing.Point(36, 759)
        Me.Label_message.Name = "Label_message"
        Me.Label_message.Size = New System.Drawing.Size(114, 13)
        Me.Label_message.TabIndex = 136
        Me.Label_message.Text = "SELECT A FILENAME"
        '
        'Label_status
        '
        Me.Label_status.AutoSize = True
        Me.Label_status.Location = New System.Drawing.Point(821, 461)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(250, 13)
        Me.Label_status.TabIndex = 139
        Me.Label_status.Text = "ZERO THE SENSORS BEFORE MEASUREMENT"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.cuticular.My.Resources.Resources.Cuticle_overlying_upper_epidermis_in_mesophyte_leaf__35103215772_
        Me.PictureBox2.Location = New System.Drawing.Point(267, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(92, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Label_calib
        '
        Me.Label_calib.AutoSize = True
        Me.Label_calib.Location = New System.Drawing.Point(36, 778)
        Me.Label_calib.Name = "Label_calib"
        Me.Label_calib.Size = New System.Drawing.Size(53, 13)
        Me.Label_calib.TabIndex = 140
        Me.Label_calib.Text = "Label_cal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_read_once)
        Me.GroupBox3.Controls.Add(Me.Bt_START_STOP)
        Me.GroupBox3.Controls.Add(Me.Button_zero)
        Me.GroupBox3.Location = New System.Drawing.Point(1069, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 163)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACQUISITION"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1400, 796)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label_calib)
        Me.Controls.Add(Me.Label_status)
        Me.Controls.Add(Me.Label_message)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridView_rawdata)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox_time)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView_samplenames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView_rawdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_meas_interval_min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer_START_DAQ As Timer
    Friend WithEvents Bt_START_STOP As Button
    Friend WithEvents Timer1sec As Timer
    Public WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TextBox_time As TextBox
    Friend WithEvents Button_read_once As Button
    Friend WithEvents DataGridView_samplenames As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button_updateMySettings As Button
    Friend WithEvents Label_n01 As Label
    Friend WithEvents ComboBox_daq02 As ComboBox
    Friend WithEvents Label_n02 As Label
    Friend WithEvents ComboBox_daq03 As ComboBox
    Friend WithEvents Label_n03 As Label
    Friend WithEvents ComboBox_daq04 As ComboBox
    Friend WithEvents Label_n04 As Label
    Friend WithEvents ComboBox_daq05 As ComboBox
    Friend WithEvents Label_n05 As Label
    Friend WithEvents ComboBox_daq07 As ComboBox
    Friend WithEvents Label_n07 As Label
    Friend WithEvents ComboBox_daq08 As ComboBox
    Friend WithEvents Label_n08 As Label
    Friend WithEvents ComboBox_daq09 As ComboBox
    Friend WithEvents Label_n09 As Label
    Friend WithEvents ComboBox_daq10 As ComboBox
    Friend WithEvents Label_n10 As Label
    Friend WithEvents ComboBox_daq11 As ComboBox
    Friend WithEvents Label_n11 As Label
    Friend WithEvents ComboBox_daq06 As ComboBox
    Friend WithEvents Label_n06 As Label
    Friend WithEvents ComboBox_daq12 As ComboBox
    Friend WithEvents Label_n12 As Label
    Friend WithEvents ComboBox_daq01 As ComboBox
    Friend WithEvents ComboBox_affectation01 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_affectation12 As ComboBox
    Friend WithEvents ComboBox_affectation11 As ComboBox
    Friend WithEvents ComboBox_affectation10 As ComboBox
    Friend WithEvents ComboBox_affectation09 As ComboBox
    Friend WithEvents ComboBox_affectation08 As ComboBox
    Friend WithEvents ComboBox_affectation07 As ComboBox
    Friend WithEvents ComboBox_affectation06 As ComboBox
    Friend WithEvents ComboBox_affectation05 As ComboBox
    Friend WithEvents ComboBox_affectation04 As ComboBox
    Friend WithEvents ComboBox_affectation03 As ComboBox
    Friend WithEvents ComboBox_affectation02 As ComboBox
    Friend WithEvents Button_advacnedsetting As Button
    Friend WithEvents connect_BTN As Button
    Friend WithEvents COMport_LBL As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents serial_LBL As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Column_serialnb As DataGridViewTextBoxColumn
    Friend WithEvents Column_channel1 As DataGridViewTextBoxColumn
    Friend WithEvents Column_channel2 As DataGridViewTextBoxColumn
    Friend WithEvents Column_channel3 As DataGridViewTextBoxColumn
    Friend WithEvents Column_channel4 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button_addrow As Button
    Friend WithEvents Button_removerow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView_rawdata As DataGridView
    Friend WithEvents NumericUpDown_meas_interval_min As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_lightintensity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_experimentname As TextBox
    Friend WithEvents TextBox_comment As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button_calibration As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_campaign As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button_zero As Button
    Friend WithEvents Label_message As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SaveFileDialog_rawdata As SaveFileDialog
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_status As System.Windows.Forms.Label
    Friend WithEvents Label_calib As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Column_date_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_campaign As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_met As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
