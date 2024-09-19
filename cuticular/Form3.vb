Imports System.Text

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' populate_cal_datagrid()


        'For i = 0 To 11

        '    DataGridView_calibration.Rows.Add(Form1.daq_comboboxlist(i).Text, "", "", "", "")

        'Next

    End Sub




    Private Sub Button_calib_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_calib_file.Click

        OpenFileDialog_calibration.InitialDirectory = Form1.default_folder
        OpenFileDialog_calibration.DefaultExt = ".csv"
        OpenFileDialog_calibration.ShowDialog()

        Form1.default_cal_file = OpenFileDialog_calibration.FileName
        My.Settings.default_cal_file = Form1.default_cal_file

        populate_cal_datagrid()

    End Sub

    Public Sub populate_cal_datagrid()
        DataGridView_calibration.Rows.Clear()
        Dim fName As String = Form1.default_cal_file
        Dim TextLine As String = ""
        Dim SplitLine() As String

        If System.IO.File.Exists(fName) = True Then
            Using objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
                Do While objReader.Peek() <> -1
                    TextLine = objReader.ReadLine()
                    SplitLine = Split(TextLine, ",")
                    Me.DataGridView_calibration.Rows.Add(SplitLine)
                Loop
            End Using
            Label_cal_filename.Text = "Now using this calibration file : " & Form1.default_cal_file
            Form1.Label_calib.Text = "Now using this calibration file : " & Form1.default_cal_file

        Else
            MsgBox("File Does Not Exist")
        End If

    End Sub


End Class