Public Class Advance_settings
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox_listofphidgetDAQ.Text = Form1.phidget_list
        NumericUpDown_threadingBEFORE.Value = Form1.threadingtime_BEFORE_ms
        NumericUpDown_threadingAFTER.Value = Form1.threadingtime_AFTER_ms
        Label_default_folder.Text = Form1.default_folder
        TextBox1.Text = My.Settings.zero_res

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.phidget_list = TextBox_listofphidgetDAQ.Text

        Form1.SAVE_MY_SETTINGS()

        Form1.POPULATE_DAQ_combobox()
        Form1.LOAD_MY_SETTINGS()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Form1.boolean_Start = True Then
            MsgBox("NOT NOW... ACQUISITION IS RUNNING - PLEASE STORE YOUR DATA AND STOP ACQUISITION", MsgBoxStyle.Exclamation)
        Else


            Select Case MsgBox("ARE YOU SURE? This will erase all the data that are not saved yet", MsgBoxStyle.OkCancel, "change settings")
                Case MsgBoxResult.Ok

                    Form1.isINIT_datagridview_rawdata = False

                    For i As Integer = Form1.DataGridView_rawdata.Columns.Count - 1 To 1 Step -1
                        Form1.DataGridView_rawdata.Columns.RemoveAt(i)
                    Next i



            '    Form1.RAWDATAGRID_setup()

                Case MsgBoxResult.Cancel


            End Select
        End If


    End Sub

    Private Sub NumericUpDown_threadingBEFORE_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_threadingBEFORE.ValueChanged

        Form1.threadingtime_BEFORE_ms = NumericUpDown_threadingBEFORE.Value


    End Sub
    Private Sub NumericUpDown_threadingAFTER_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_threadingAFTER.ValueChanged

        Form1.threadingtime_AFTER_ms = NumericUpDown_threadingAFTER.Value
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_default_folder.LinkClicked
        FolderBrowserDialog1.ShowDialog()
        Form1.default_folder = FolderBrowserDialog1.SelectedPath
        Label_default_folder.Text = Form1.default_folder
    End Sub

    Private Sub Button_restore_ZERO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_restore_ZERO.Click
        Dim read_new_zero_string() As String = TextBox1.Text.Split(",")
        '  Form1.zero_string() = My.Settings.zero_res.Split(",")
        For i = 0 To 3
            Form1.zero_string(i) = read_new_zero_string(i)
        Next

        For i = 11 To 59
            Form1.zero_string(i - 7) = read_new_zero_string(i)
        Next


    End Sub
End Class