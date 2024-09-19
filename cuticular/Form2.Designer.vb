<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advance_settings
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
        Me.TextBox_listofphidgetDAQ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown_threadingBEFORE = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_threadingAFTER = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel_default_folder = New System.Windows.Forms.LinkLabel()
        Me.Label_default_folder = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button_restore_ZERO = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown_threadingBEFORE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_threadingAFTER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_listofphidgetDAQ
        '
        Me.TextBox_listofphidgetDAQ.Location = New System.Drawing.Point(162, 51)
        Me.TextBox_listofphidgetDAQ.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_listofphidgetDAQ.Name = "TextBox_listofphidgetDAQ"
        Me.TextBox_listofphidgetDAQ.Size = New System.Drawing.Size(1309, 26)
        Me.TextBox_listofphidgetDAQ.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "list of phidget DAQ in this environment"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1275, 224)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 108)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Update My.Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(1329, 87)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 108)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "REINITIATE DATA GRID VIEW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumericUpDown_threadingBEFORE
        '
        Me.NumericUpDown_threadingBEFORE.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumericUpDown_threadingBEFORE.Location = New System.Drawing.Point(402, 163)
        Me.NumericUpDown_threadingBEFORE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericUpDown_threadingBEFORE.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_threadingBEFORE.Name = "NumericUpDown_threadingBEFORE"
        Me.NumericUpDown_threadingBEFORE.Size = New System.Drawing.Size(90, 26)
        Me.NumericUpDown_threadingBEFORE.TabIndex = 4
        '
        'NumericUpDown_threadingAFTER
        '
        Me.NumericUpDown_threadingAFTER.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumericUpDown_threadingAFTER.Location = New System.Drawing.Point(402, 211)
        Me.NumericUpDown_threadingAFTER.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericUpDown_threadingAFTER.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_threadingAFTER.Name = "NumericUpDown_threadingAFTER"
        Me.NumericUpDown_threadingAFTER.Size = New System.Drawing.Size(90, 26)
        Me.NumericUpDown_threadingAFTER.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Threading time ms (BEFORE)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 214)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Threading time ms (AFTER )"
        '
        'LinkLabel_default_folder
        '
        Me.LinkLabel_default_folder.AutoSize = True
        Me.LinkLabel_default_folder.Location = New System.Drawing.Point(162, 112)
        Me.LinkLabel_default_folder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel_default_folder.Name = "LinkLabel_default_folder"
        Me.LinkLabel_default_folder.Size = New System.Drawing.Size(227, 20)
        Me.LinkLabel_default_folder.TabIndex = 8
        Me.LinkLabel_default_folder.TabStop = True
        Me.LinkLabel_default_folder.Text = "Set default directory pathname"
        '
        'Label_default_folder
        '
        Me.Label_default_folder.AutoSize = True
        Me.Label_default_folder.Location = New System.Drawing.Point(398, 112)
        Me.Label_default_folder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_default_folder.Name = "Label_default_folder"
        Me.Label_default_folder.Size = New System.Drawing.Size(28, 20)
        Me.Label_default_folder.TabIndex = 9
        Me.Label_default_folder.Text = "C:\"
        '
        'Button_restore_ZERO
        '
        Me.Button_restore_ZERO.ForeColor = System.Drawing.Color.DarkRed
        Me.Button_restore_ZERO.Location = New System.Drawing.Point(1107, 224)
        Me.Button_restore_ZERO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_restore_ZERO.Name = "Button_restore_ZERO"
        Me.Button_restore_ZERO.Size = New System.Drawing.Size(142, 108)
        Me.Button_restore_ZERO.TabIndex = 10
        Me.Button_restore_ZERO.Text = "USE PREVIOUS ZERO VALUES"
        Me.Button_restore_ZERO.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(162, 352)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1309, 80)
        Me.TextBox1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 327)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "values used for zero"
        '
        'Advance_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1668, 446)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_restore_ZERO)
        Me.Controls.Add(Me.Label_default_folder)
        Me.Controls.Add(Me.LinkLabel_default_folder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown_threadingAFTER)
        Me.Controls.Add(Me.NumericUpDown_threadingBEFORE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_listofphidgetDAQ)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Advance_settings"
        Me.Text = "Advanced Settings"
        CType(Me.NumericUpDown_threadingBEFORE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_threadingAFTER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_listofphidgetDAQ As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown_threadingBEFORE As NumericUpDown
    Friend WithEvents NumericUpDown_threadingAFTER As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel_default_folder As LinkLabel
    Friend WithEvents Label_default_folder As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button_restore_ZERO As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
