<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView_calibration = New System.Windows.Forms.DataGridView()
        Me.Column_serialnb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_channel4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog_calibration = New System.Windows.Forms.OpenFileDialog()
        Me.Button_calib_file = New System.Windows.Forms.Button()
        Me.Label_cal_filename = New System.Windows.Forms.Label()
        CType(Me.DataGridView_calibration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_calibration
        '
        Me.DataGridView_calibration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_calibration.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_serialnb, Me.Column_channel1, Me.Column_channel2, Me.Column_channel3, Me.Column_channel4})
        Me.DataGridView_calibration.Location = New System.Drawing.Point(31, 59)
        Me.DataGridView_calibration.Name = "DataGridView_calibration"
        Me.DataGridView_calibration.Size = New System.Drawing.Size(544, 329)
        Me.DataGridView_calibration.TabIndex = 34
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
        'OpenFileDialog_calibration
        '
        Me.OpenFileDialog_calibration.FileName = "OpenFileDialog1"
        '
        'Button_calib_file
        '
        Me.Button_calib_file.Location = New System.Drawing.Point(431, 410)
        Me.Button_calib_file.Name = "Button_calib_file"
        Me.Button_calib_file.Size = New System.Drawing.Size(144, 49)
        Me.Button_calib_file.TabIndex = 35
        Me.Button_calib_file.Text = "OPEN A NEW CALIBRATION FILE"
        Me.Button_calib_file.UseVisualStyleBackColor = True
        '
        'Label_cal_filename
        '
        Me.Label_cal_filename.AutoSize = True
        Me.Label_cal_filename.Location = New System.Drawing.Point(28, 25)
        Me.Label_cal_filename.Name = "Label_cal_filename"
        Me.Label_cal_filename.Size = New System.Drawing.Size(57, 13)
        Me.Label_cal_filename.TabIndex = 36
        Me.Label_cal_filename.Text = "Now using"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 477)
        Me.Controls.Add(Me.Label_cal_filename)
        Me.Controls.Add(Me.Button_calib_file)
        Me.Controls.Add(Me.DataGridView_calibration)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView_calibration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_calibration As System.Windows.Forms.DataGridView
    Friend WithEvents Column_serialnb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_channel1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_channel2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_channel3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_channel4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog_calibration As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button_calib_file As System.Windows.Forms.Button
    Friend WithEvents Label_cal_filename As System.Windows.Forms.Label
End Class
