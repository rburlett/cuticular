
Imports Phidget22
Imports Phidget22.Events
Imports System.Linq
Imports System
Imports System.IO.Ports


Public Class Form1
    ' set up delegate to display data received from serial port
    Private Delegate Sub SerialDelegate(ByVal Buffer As String)
    Private adre As New SerialDelegate(AddressOf ArduinoData)
    ' key pressed on terminal textbox
    Dim WithEvents device1 As New Phidget22.VoltageRatioInput
    Dim WithEvents device2 As New Phidget22.VoltageRatioInput
    Dim WithEvents device3 As New Phidget22.VoltageRatioInput
    Dim datadevice As Double(,)
    '    Dim datadevice2 As Double()
    Dim i As Integer
    Dim nb_device_connected As Integer = 2
    Dim comPORT As String
    Dim receivedData As String = ""
    Public boolean_Start = False
    Public boolean_Stop = True

    Dim total_nb_of_device_in_env As Integer = 12
    Public phidget_list As String ' = "582611,582686,583206,583433,583447,583457,588686,588850,589036,589048,589129,589162,589184"
    Public isINIT_datagridview_rawdata As Boolean = False

    Public threadingtime_BEFORE_ms As Integer
    Public threadingtime_AFTER_ms As Integer

    Dim MEASURE_ONAIR As Boolean = False
    Dim arduino_stream As String = ""

    Dim write_header As Boolean

    ' Dim x As Integer = 0
    '  Dim y As Integer = 0
    Dim phidget_number As Integer = 0

    Public default_folder As String
    Public default_cal_file As String
    Dim save_data_filename As String
    Dim data_to_save As String
    Dim header As String

    Dim slope As Double
    Dim zero As Double
    Public zero_string(52) As String
    'Dim zero_res As String = ""
    Public zero_res As String = ""
    Dim slope_string(52) As String
    'Dim slope_res As String = ""

    Dim time_of_next_meas As DateTime

    Public daq_comboboxlist() As ComboBox = {ComboBox_daq01, ComboBox_daq02, ComboBox_daq03, ComboBox_daq04, ComboBox_daq05, ComboBox_daq06, ComboBox_daq07, ComboBox_daq08, ComboBox_daq09, ComboBox_daq10, ComboBox_daq11, ComboBox_daq12}


   

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        init()
        Label_calib.Text = "This calibration file will be used : " & default_cal_file

    End Sub
    Private Sub init()

        LOAD_MY_SETTINGS()
        POPULATE_DAQ_combobox()
        save_data_filename = "none"
        device1.IsLocal = True
        i = 0
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
            comPort_ComboBox.SelectedIndex = 0
        Next

        NumericUpDown_meas_interval_min.Value = Timer_START_DAQ.Interval / 1000 / 60
        AFFECTATION_MGMT()

        RAWDATAGRID_setup()
        'POPULATE_DAQ_combobox()
        write_header = True

        DataGridView_rawdata.Rows.Add()
        CONNECT_SERIAL()
        Form3.populate_cal_datagrid()
        TextBox_time.Text = Format(Now(), "dd/MM/yyyy HH:mm:ss")

    End Sub


    '''  CALIBRATION, ZERO AND SETUP ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_zero.Click
        Dim r As MsgBoxResult

        r = MsgBox("MAKE SURE THAT NO SAMPLE ARE ATTACHED TO THE SENSORS !", MsgBoxStyle.OkCancel, "Close")
        If r = MsgBoxResult.Cancel Then

        End If

        If r = MsgBoxResult.Ok Then
            ZERO_SENSOR()
            Button_zero.BackColor = Color.LightGreen
            '   Button_zero.BackColor = Color.Gray
        End If
    End Sub

    Public Sub ZERO_SENSOR()
        'Dim zero_string(52) As String

        '  Dim slope_string(52) As String
        Dim slope_res As String = ""

        '   zero_res = ""
        '(slope_res = "")

        Dim comment As String
        Label_status.Text = "ZERO is underway"
        Label_status.BackColor = Color.PaleGreen
        Label_status.Refresh()
        Threading.Thread.Sleep(150)




        ' Label_message.Text = "Measurement is underway"
        For i = 0 To total_nb_of_device_in_env - 1

            device1.DeviceSerialNumber = CInt(Form3.DataGridView_calibration(0, phidget_number).Value)


            comment = "ZERO"
            zero_string(0) = Now()
            zero_string(1) = TextBox_experimentname.Text & "_" & TextBox_campaign.Text
            zero_string(2) = comment
            If arduino_stream = "" Then
                zero_string(3) = ",,,,,,,"
            Else
                zero_string(3) = arduino_stream
            End If


            comment = "SLOPE"
            slope_string(0) = Now()
            slope_string(1) = TextBox_experimentname.Text & "_" & TextBox_campaign.Text
            slope_string(2) = comment
            If arduino_stream = "" Then
                slope_string(3) = ",,,,,,,"
            Else
                slope_string(3) = arduino_stream
            End If

            '582611,582686,583206,583433,583447,583457,588686,588850,589036,589048,589129,589162,589184

            For j = 0 To 3 '' SCAN EACH CHANNEL OF THE ACTIVE LOGGER


                device1.Channel = j
                ' Threading.Thread.Sleep(50)
                device1.Open()
                Threading.Thread.Sleep(threadingtime_BEFORE_ms)


                If device1.Attached = True Then

                    device1.BridgeGain = BridgeGain.Gain_128x
                    Try
                        zero_string(4 + (4 * phidget_number + j)) = device1.VoltageRatio
                        slope_string(4 + (4 * phidget_number + j)) = Form3.DataGridView_calibration(j + 1, i).Value
                    Catch ex As Exception
                        'Label_message.Text = ex.ToString

                    End Try
                    Threading.Thread.Sleep(threadingtime_AFTER_ms)
                    device1.Close()
                    Threading.Thread.Sleep(threadingtime_BEFORE_ms)

                Else
                    zero_string(4 + (4 * phidget_number + j)) = -9999
                    slope_string(4 + (4 * phidget_number + j)) = Form3.DataGridView_calibration(j + 1, i).Value
                End If

            Next

            '' REPEAT FOR EACH LOGGERS IN THE ENVIRONMENT
            If phidget_number < total_nb_of_device_in_env - 1 Then
                phidget_number = phidget_number + 1
            Else

                phidget_number = 0


            End If

        Next


        For k = 0 To 51
            zero_res = zero_res & zero_string(k) & ","
            slope_res = slope_res & slope_string(k) & ","
        Next
        ' Label_message.Text = zero_res
        Label_status.Text = " ALL SENSORS HAS BEEN ZEROED"
        Label_status.BackColor = Color.Transparent

        My.Computer.FileSystem.WriteAllText(default_folder & "\zero.csv", zero_res & Environment.NewLine, True)

        My.Computer.FileSystem.WriteAllText(default_folder & "\zero.csv", slope_res & Environment.NewLine, True)

        My.Settings.zero_res = zero_res
        My.Settings.Save()
        phidget_number = 0



    End Sub

    Private Sub Button2_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button_calibration.Click
        '  MsgBox("NOT IMPLEMENTED YET...", MsgBoxStyle.Exclamation)
        Form3.ShowDialog()
    End Sub
    Public Sub RAWDATAGRID_setup()


        If isINIT_datagridview_rawdata = False Then



            For j = 0 To DataGridView_samplenames.Rows.Count - 2
                For i = 1 To DataGridView_samplenames.Columns.Count - 1


                    DataGridView_rawdata.Columns.Add(DataGridView_samplenames(i, j).Value, DataGridView_samplenames(i, j).Value)
                    '
                Next
            Next
            isINIT_datagridview_rawdata = True

        Else
            Select Case MsgBox("ARE YOU SURE? This will erase all the sample names table", MsgBoxStyle.YesNoCancel, "change settings")
                Case MsgBoxResult.Yes
                    isINIT_datagridview_rawdata = False
                    For i As Integer = DataGridView_rawdata.Columns.Count - 1 To 4 Step -1
                        DataGridView_rawdata.Columns.RemoveAt(i)
                    Next i
                    RAWDATAGRID_setup()
                Case MsgBoxResult.No
                    isINIT_datagridview_rawdata = True
                Case MsgBoxResult.Cancel

            End Select

        End If

    End Sub


    Public Sub LOAD_MY_SETTINGS()
        'nb_device_connected = My.Settings.NumUpDown_nbofdev
        phidget_list = My.Settings.phidget_list

        Timer_START_DAQ.Interval = My.Settings.Timer_START_DAQ_Interval

        Dim affectation_comboboxlist() As ComboBox = {ComboBox_affectation01, ComboBox_affectation02, ComboBox_affectation03, ComboBox_affectation04, ComboBox_affectation05, ComboBox_affectation06, ComboBox_affectation07, ComboBox_affectation08, ComboBox_affectation09, ComboBox_affectation10, ComboBox_affectation11, ComboBox_affectation12}
        Dim daq_comboboxlist() As ComboBox = {ComboBox_daq01, ComboBox_daq02, ComboBox_daq03, ComboBox_daq04, ComboBox_daq05, ComboBox_daq06, ComboBox_daq07, ComboBox_daq08, ComboBox_daq09, ComboBox_daq10, ComboBox_daq11, ComboBox_daq12}

        For i = 0 To total_nb_of_device_in_env - 1
            daq_comboboxlist(i).SelectedIndex = i

        Next




        threadingtime_BEFORE_ms = My.Settings.threadingtime_BEFORE
        threadingtime_AFTER_ms = My.Settings.threadingtime_AFTER

        default_folder = My.Settings.default_folder

        'ComboBox_daq01.SelectedIndex = My.Settings.ComboBox_daq01
        'ComboBox_daq02.SelectedIndex = My.Settings.ComboBox_daq02
        'ComboBox_daq03.SelectedIndex = My.Settings.ComboBox_daq03
        'ComboBox_daq04.SelectedIndex = My.Settings.ComboBox_daq04
        'ComboBox_daq05.SelectedIndex = My.Settings.ComboBox_daq05
        'ComboBox_daq06.SelectedIndex = My.Settings.ComboBox_daq06
        'ComboBox_daq07.SelectedIndex = My.Settings.ComboBox_daq07
        'ComboBox_daq08.SelectedIndex = My.Settings.ComboBox_daq08
        'ComboBox_daq09.SelectedIndex = My.Settings.ComboBox_daq09
        'ComboBox_daq10.SelectedIndex = My.Settings.ComboBox_daq10
        'ComboBox_daq11.SelectedIndex = My.Settings.ComboBox_daq11
        'ComboBox_daq12.SelectedIndex = My.Settings.ComboBox_daq12

        ComboBox_affectation01.SelectedIndex = My.Settings.ComboBox_affectation01
        ComboBox_affectation02.SelectedIndex = My.Settings.ComboBox_affectation02
        ComboBox_affectation03.SelectedIndex = My.Settings.ComboBox_affectation03
        ComboBox_affectation04.SelectedIndex = My.Settings.ComboBox_affectation04
        ComboBox_affectation05.SelectedIndex = My.Settings.ComboBox_affectation05
        ComboBox_affectation06.SelectedIndex = My.Settings.ComboBox_affectation06
        ComboBox_affectation07.SelectedIndex = My.Settings.ComboBox_affectation07
        ComboBox_affectation08.SelectedIndex = My.Settings.ComboBox_affectation08
        ComboBox_affectation09.SelectedIndex = My.Settings.ComboBox_affectation09
        ComboBox_affectation10.SelectedIndex = My.Settings.ComboBox_affectation10
        ComboBox_affectation11.SelectedIndex = My.Settings.ComboBox_affectation11
        ComboBox_affectation12.SelectedIndex = My.Settings.ComboBox_affectation12

        default_cal_file = My.Settings.default_cal_file


    End Sub

    Public Sub SAVE_MY_SETTINGS()
        ' My.Settings.NumUpDown_nbofdev = nb_device_connected
        My.Settings.phidget_list = phidget_list

        My.Settings.ComboBox_daq01 = ComboBox_daq01.SelectedIndex
        My.Settings.ComboBox_daq02 = ComboBox_daq02.SelectedIndex
        My.Settings.ComboBox_daq03 = ComboBox_daq03.SelectedIndex
        My.Settings.ComboBox_daq04 = ComboBox_daq04.SelectedIndex
        My.Settings.ComboBox_daq05 = ComboBox_daq05.SelectedIndex
        My.Settings.ComboBox_daq06 = ComboBox_daq06.SelectedIndex
        My.Settings.ComboBox_daq07 = ComboBox_daq07.SelectedIndex
        My.Settings.ComboBox_daq08 = ComboBox_daq08.SelectedIndex
        My.Settings.ComboBox_daq09 = ComboBox_daq09.SelectedIndex
        My.Settings.ComboBox_daq10 = ComboBox_daq10.SelectedIndex
        My.Settings.ComboBox_daq11 = ComboBox_daq11.SelectedIndex
        My.Settings.ComboBox_daq12 = ComboBox_daq12.SelectedIndex


        My.Settings.ComboBox_affectation01 = ComboBox_affectation01.SelectedIndex
        My.Settings.ComboBox_affectation02 = ComboBox_affectation02.SelectedIndex
        My.Settings.ComboBox_affectation03 = ComboBox_affectation03.SelectedIndex
        My.Settings.ComboBox_affectation04 = ComboBox_affectation04.SelectedIndex
        My.Settings.ComboBox_affectation05 = ComboBox_affectation05.SelectedIndex
        My.Settings.ComboBox_affectation06 = ComboBox_affectation06.SelectedIndex
        My.Settings.ComboBox_affectation07 = ComboBox_affectation07.SelectedIndex
        My.Settings.ComboBox_affectation08 = ComboBox_affectation08.SelectedIndex
        My.Settings.ComboBox_affectation09 = ComboBox_affectation09.SelectedIndex
        My.Settings.ComboBox_affectation10 = ComboBox_affectation10.SelectedIndex
        My.Settings.ComboBox_affectation11 = ComboBox_affectation11.SelectedIndex
        My.Settings.ComboBox_affectation12 = ComboBox_affectation12.SelectedIndex

        My.Settings.threadingtime_BEFORE = threadingtime_BEFORE_ms
        My.Settings.threadingtime_AFTER = threadingtime_AFTER_ms
        My.Settings.Timer_START_DAQ_Interval = Timer_START_DAQ.Interval


        My.Settings.default_folder = default_folder
        My.Settings.default_cal_file = default_cal_file

    End Sub

    Public Sub AFFECTATION_MGMT()
        ' this sub is 
        Dim nb_device_disconnected As Integer

        nb_device_connected = 0

        Dim affectation_comboboxlist() As ComboBox = {ComboBox_affectation01, ComboBox_affectation02, ComboBox_affectation03, ComboBox_affectation04, ComboBox_affectation05, ComboBox_affectation06, ComboBox_affectation07, ComboBox_affectation08, ComboBox_affectation09, ComboBox_affectation10, ComboBox_affectation11, ComboBox_affectation12}
        Dim daq_comboboxlist() As ComboBox = {ComboBox_daq01, ComboBox_daq02, ComboBox_daq03, ComboBox_daq04, ComboBox_daq05, ComboBox_daq06, ComboBox_daq07, ComboBox_daq08, ComboBox_daq09, ComboBox_daq10, ComboBox_daq11, ComboBox_daq12}


        '   Dim comboboxlist() As String = Convert.ToString("ComboBox_daq01" & "ComboBox_affectation02" & "")

        DataGridView_samplenames.Rows.Clear()

        For i = 0 To affectation_comboboxlist.Count - 1
            If affectation_comboboxlist(i).Text = "OFF" Then
                daq_comboboxlist(i).BackColor = Color.Red
                affectation_comboboxlist(i).BackColor = Color.Red
                nb_device_disconnected = (nb_device_disconnected + 1)
            Else

                daq_comboboxlist(i).BackColor = Color.White
                affectation_comboboxlist(i).BackColor = Color.White

                DataGridView_samplenames.Rows.Add(daq_comboboxlist(i).Text, affectation_comboboxlist(i).Text & "_" & Format((i * 4 + 1), "0#"), affectation_comboboxlist(i).Text & "_" & Format((i * 4 + 2), "0#"), affectation_comboboxlist(i).Text & "_" & Format((i * 4 + 3), "0#"), affectation_comboboxlist(i).Text & "_" & Format((i * 4) + 4, "0#"))


            End If
        Next
        nb_device_connected = total_nb_of_device_in_env - nb_device_disconnected

    End Sub

    Public Sub POPULATE_DAQ_combobox()
        ' this sub is used to set the serial number of each phidget unit in the combobox, from the My.setting list 
        daq_comboboxlist = {ComboBox_daq01, ComboBox_daq02, ComboBox_daq03, ComboBox_daq04, ComboBox_daq05, ComboBox_daq06, ComboBox_daq07, ComboBox_daq08, ComboBox_daq09, ComboBox_daq10, ComboBox_daq11, ComboBox_daq12}

        Dim phidgetlist() As String = Split(phidget_list, ",")
        ' Dim phidgetlist() As String = Split(My.Settings.phidget_list, ",")
        '  TextBox1.Text = My.Settings.phidget_list
        For Each combox As ComboBox In daq_comboboxlist
            combox.Items.Clear()
            combox.Items.AddRange(phidgetlist)

        Next
        ComboBox_affectation01.SelectedIndex = My.Settings.ComboBox_affectation01
        ComboBox_affectation02.SelectedIndex = My.Settings.ComboBox_affectation02
        ComboBox_affectation03.SelectedIndex = My.Settings.ComboBox_affectation03
        ComboBox_affectation04.SelectedIndex = My.Settings.ComboBox_affectation04
        ComboBox_affectation05.SelectedIndex = My.Settings.ComboBox_affectation05
        ComboBox_affectation06.SelectedIndex = My.Settings.ComboBox_affectation06
        ComboBox_affectation07.SelectedIndex = My.Settings.ComboBox_affectation07
        ComboBox_affectation08.SelectedIndex = My.Settings.ComboBox_affectation08
        ComboBox_affectation09.SelectedIndex = My.Settings.ComboBox_affectation09
        ComboBox_affectation10.SelectedIndex = My.Settings.ComboBox_affectation10
        ComboBox_affectation11.SelectedIndex = My.Settings.ComboBox_affectation11
        ComboBox_affectation12.SelectedIndex = My.Settings.ComboBox_affectation12


        'Dim phidgetlist() As String = Split(My.Settings.phidget_list, ",")
        ComboBox_daq01.SelectedIndex = 0
        ComboBox_daq02.SelectedIndex = 1
        ComboBox_daq03.SelectedIndex = 2
        ComboBox_daq04.SelectedIndex = 3
        ComboBox_daq05.SelectedIndex = 4
        ComboBox_daq06.SelectedIndex = 5
        ComboBox_daq07.SelectedIndex = 6
        ComboBox_daq08.SelectedIndex = 7
        ComboBox_daq09.SelectedIndex = 8
        ComboBox_daq10.SelectedIndex = 9
        ComboBox_daq11.SelectedIndex = 10
        ComboBox_daq12.SelectedIndex = 11

    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_updateMySettings.Click
        If boolean_Start = True Then

            MsgBox("NOT NOW... ACQUISITION IS RUNNING - PLEASE STORE YOUR DATA AND STOP ACQUISITION", MsgBoxStyle.Exclamation)
        Else

            AFFECTATION_MGMT()
            RAWDATAGRID_setup()
        End If
    End Sub
    ''' 
    ''' DATA ACQUISITION  ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' 
    Public Sub Start_Stop_mgmt()

        If save_data_filename = "none" Then
            MsgBox("Enter a filename to save your data")
            select_filename_save_data()

        Else

            If boolean_Start = False Then
                '''''''''''CONDITION IF RECORDING RUN
                boolean_Start = True
                boolean_Stop = False
                Bt_START_STOP.Text = "STOP"
                Bt_START_STOP.BackColor = Color.DarkRed
                MEASURE_ONAIR = True
                Timer_START_DAQ.Enabled = True


                'RAWDATAGRID_setup()
            Else
                '''''''''''CONDITION IF RECORDING STOP
                boolean_Start = False
                boolean_Stop = True
                Timer_START_DAQ.Stop()
                Bt_START_STOP.Text = "START"
                Bt_START_STOP.BackColor = Color.Silver
                MEASURE_ONAIR = False
                Timer_START_DAQ.Enabled = False
                write_header = True
                Label_status.Text = " Acquisition is stopped"
                Label_status.Refresh()

            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_START_STOP.Click

        '    Timer_START_DAQ.Interval =

        Start_Stop_mgmt()
        Timer_START_DAQ.Start()
        time_of_next_meas = Date.Now().AddMinutes(CDbl(NumericUpDown_meas_interval_min.Value))
        MEASURE_ALL_LOADCELLS()


        'ComboBox_daq01.SelectedIndex = 0
        'ComboBox_daq02.SelectedIndex = 1
        'ComboBox_daq03.SelectedIndex = 2
        'ComboBox_daq04.SelectedIndex = 3
        'ComboBox_daq05.SelectedIndex = 4
        'ComboBox_daq06.SelectedIndex = 5
        'ComboBox_daq07.SelectedItem = 6
        'ComboBox_daq08.SelectedItem = 7
        'ComboBox_daq09.SelectedItem = 8
        'ComboBox_daq10.SelectedItem = 9
        'ComboBox_daq11.SelectedItem = 10
        'ComboBox_daq12.SelectedItem = 11

    End Sub
    Private Sub TimerSTART_DAQ_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer_START_DAQ.Tick
        Label_status.Text = "Measurement  underway"
        Label_status.BackColor = Color.PaleGreen
        Label_status.Refresh()
        MEASURE_ONAIR = True
        'time_of_next_meas =

        time_of_next_meas = Date.Now().AddMinutes(CDbl(NumericUpDown_meas_interval_min.Value))
        MEASURE_ALL_LOADCELLS()


    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button_read_once.Click

        Label_status.Text = " Single measurement underway"
        Label_status.BackColor = Color.PaleGreen
        Label_status.Refresh()
        MEASURE_ONAIR = True


        MEASURE_ALL_LOADCELLS()
        MEASURE_ONAIR = False
        Label_status.BackColor = Color.Transparent
        Label_status.Text = " System is ready"

    End Sub


    Public Sub MEASURE_ALL_LOADCELLS()

        '    Dim RAW_datatable(1, 2) As DataTable
        '  Label_status.Text = "Measurement is underway"
        Threading.Thread.Sleep(150)

        If MEASURE_ONAIR = True Then


            ' Label_message.Text = "Measurement is underway"


            device1.DeviceSerialNumber = CInt(DataGridView_samplenames(0, phidget_number).Value)

            '    RAW_datatable(0, 1) = Now().ToString

            DataGridView_rawdata(0, DataGridView_rawdata.Rows.Count - 2).Value = Now()
            DataGridView_rawdata(1, DataGridView_rawdata.Rows.Count - 2).Value = TextBox_experimentname.Text & "_" & TextBox_campaign.Text
            DataGridView_rawdata(2, DataGridView_rawdata.Rows.Count - 2).Value = TextBox_comment.Text

            If arduino_stream = "" Then
                DataGridView_rawdata(3, DataGridView_rawdata.Rows.Count - 2).Value = ",,,,,,,"
            Else
                DataGridView_rawdata(3, DataGridView_rawdata.Rows.Count - 2).Value = arduino_stream
            End If
            '        DataGridView_rawdata(3, DataGridView_rawdata.Rows.Count - 2).Value = arduino_stream

            '582611,582686,583206,583433,583447,583457,588686,588850,589036,589048,589129,589162,589184

            For j = 0 To 3 '' SCAN EACH CHANNEL OF THE ACTIVE LOGGER
                Try

               
                'affect_calibration
                Select Case device1.DeviceSerialNumber
                    Case daq_comboboxlist(0).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 0).Value)
                        zero = CDbl(zero_string(4 + (4 * 0) + j))
                    Case daq_comboboxlist(1).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 1).Value)
                        zero = CDbl(zero_string(4 + (4 * 1) + j))
                    Case daq_comboboxlist(2).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 2).Value)
                        zero = CDbl(zero_string(4 + (4 * 2) + j))
                    Case daq_comboboxlist(3).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 3).Value)
                        zero = CDbl(zero_string(4 + (4 * 3) + j))
                    Case daq_comboboxlist(4).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 4).Value)
                        zero = CDbl(zero_string(4 + (4 * 4) + j))
                    Case daq_comboboxlist(5).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 5).Value)
                        zero = CDbl(zero_string(4 + (4 * 5) + j))
                    Case daq_comboboxlist(6).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 6).Value)
                        zero = CDbl(zero_string(4 + (4 * 6) + j))
                    Case daq_comboboxlist(7).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 7).Value)
                        zero = CDbl(zero_string(4 + (4 * 7) + j))
                    Case daq_comboboxlist(8).Text
                        slope = CDbl(Form3.DataGridView_calibration(j + 1, 8).Value)
                        zero = CDbl(zero_string(4 + (4 * 8) + j))
                    Case daq_comboboxlist(9).Text
                        slope = CInt(Form3.DataGridView_calibration(j + 1, 9).Value)
                        zero = CDbl(zero_string(4 + (4 * 9) + j))
                    Case daq_comboboxlist(10).Text
                        slope = CInt(Form3.DataGridView_calibration(j + 1, 10).Value)
                        zero = CDbl(zero_string(4 + (4 * 10) + j))
                    Case daq_comboboxlist(11).Text
                        slope = CInt(Form3.DataGridView_calibration(j + 1, 11).Value)
                        zero = CDbl(zero_string(4 + (4 * 11) + j))

                End Select
                Catch ex As Exception

                End Try

                device1.Channel = j
                ' Threading.Thread.Sleep(50)
                device1.Open()
                Threading.Thread.Sleep(threadingtime_BEFORE_ms)


                If device1.Attached = True Then

                    device1.BridgeGain = BridgeGain.Gain_128x

                    DataGridView_samplenames(j + 1, phidget_number).Style.BackColor = Color.Green
                    Try
                        DataGridView_rawdata(4 + (4 * phidget_number + j), DataGridView_rawdata.Rows.Count - 2).Value = CDbl(device1.VoltageRatio) * slope - (zero * slope)
                        Label_status.Text = "Now reading logger S/N# " & device1.DeviceSerialNumber & " - channel " & j + 1
                        Label_status.Refresh()
                    Catch ex As Exception
                        'Label_message.Text = ex.ToString
                        DataGridView_samplenames(j + 1, phidget_number).Style.BackColor = Color.Red
                    End Try
                    Threading.Thread.Sleep(threadingtime_AFTER_ms)
                    device1.Close()
                    Threading.Thread.Sleep(threadingtime_BEFORE_ms)

                Else
                    DataGridView_rawdata(4 + (4 * phidget_number + j), DataGridView_rawdata.Rows.Count - 2).Value = -9999

                    DataGridView_samplenames(j + 1, phidget_number).Style.BackColor = Color.Red


                End If

            Next

            '' REPEAT FOR EACH LOGGERS THAT ARE CONNECTED
            If phidget_number < nb_device_connected - 1 Then

                phidget_number = phidget_number + 1
                MEASURE_ALL_LOADCELLS()
            Else
                Label_status.Text = " Next measurement will start at " & time_of_next_meas.Hour & ":" & time_of_next_meas.Minute & ":" & time_of_next_meas.Second
                Label_status.BackColor = Color.Transparent
                Label_status.Refresh()
                MEASURE_ONAIR = False

                phidget_number = 0

                DataGridView_rawdata.Rows.Add()
                save_data_to_file()
                '  MEASURE_ALL_LOADCELLS()
                'MsgBox("meas is over")

            End If


        Else

            phidget_number = 0

            DataGridView_rawdata.Rows.Add()
            '  MsgBox("meas ON air")
            '  MEASURE_ONAIR = True

        End If




    End Sub

    '' SAVE DATA ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        select_filename_save_data()

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click

        select_filename_save_data()


    End Sub
    Private Sub save_data_to_file()

        'chr(13) = ASCII codfe for line feed
        'chr(9) = ASCII code for tabulation
        Dim row As DataGridViewRow = Me.DataGridView_rawdata.Rows(0)



        '     header = DataGridView_MAINDATA.Columns[Index].HeaderText;

        If save_data_filename = "none" Then
            select_filename_save_data()
        Else

            If write_header = True Then
                '' Define header (from datagridview name)
                header = ""

                For Each col As DataGridViewColumn In row.DataGridView.Columns
                    header = header & col.HeaderText & ","
                Next
                header = header & Environment.NewLine

                '  RichTextBox4.Text = header
                ''  "measurement_date" & "," & "campaign_name" & "," & "sample_ref1" & "," & "sample_ref2" & "," & "sample_ref3" & "," & "meas_cavispeed_rpm" & "," & "max_Cavispeed_rpm" & "," & "pressure" & "," & "raw_conductance_mmMPas_corrT" & "," & "conductivity_SI_corrT" & "," & "std_dev_conductivity" & "," & "PLC_percent" & "," & "note" & "," & "speed_class" & "," & "plate_temp" & "," & "cavi_Temp1" & "," & "cavi_Temp2" & "," & "temperature_used_for_correction" & "," & "operator" & "," & "plate_number" & "," & "branch_diam_bigreservoir_mm" & "," & "branch_diam_smallreservoir_mm" & "," & "species" & "," & "sampling_location" & "," & "sample_type" & "," & "tree_age" & "," & "delta_P_MPa" & "," & "calib_optic_mm_per50grad" & "," & "meas_MODE" & "," & "Rotor_diameter" & "," & "conductance unit" & "," & "Equation_slope" & "," & "Equation_intercept" & "," & "RAW DATA time" & "," & "RAW DATA distance pixel" & "," & "RAW DATA distance mm" & "," & "number of stems" & "," & "rawdata branch diameter UPSTREAM (mm)" & "," & "rawdata branch diameter DOWNSTREAM (mm)" & Chr(13)

                My.Computer.FileSystem.WriteAllText(save_data_filename, header, True)
                write_header = False
            End If

            Try

            
            data_to_save = ""

            Dim r As Integer
            Dim c As Integer

            r = DataGridView_rawdata.Rows.Count - 3
            For c = 0 To DataGridView_rawdata.ColumnCount - 1
                data_to_save = data_to_save & DataGridView_rawdata(c, r).Value & ","
            Next

            data_to_save = data_to_save & Environment.NewLine



            My.Computer.FileSystem.WriteAllText(save_data_filename, data_to_save, True)
                data_to_save = ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If




        '& "," & receivedData & "," & TextBox_comment.Text

        '  My.Computer.FileSystem.WriteAllText(data_filename, save_text, True)


    End Sub
    Sub select_filename_save_data()
        If TextBox_experimentname.Text <> "" Then
            SaveFileDialog_rawdata.InitialDirectory = default_folder
            SaveFileDialog_rawdata.FileName = Date.Today.ToString("yyyy_MM_dd") & "_" & TextBox_experimentname.Text
            SaveFileDialog_rawdata.DefaultExt = ".csv"
            SaveFileDialog_rawdata.ShowDialog()
            save_data_filename = SaveFileDialog_rawdata.FileName
            Label_message.Text = "Your file will be saved here :  " & save_data_filename
        Else
            MsgBox("You need to input a name for the experiment", MsgBoxStyle.Exclamation)
            TextBox_experimentname.Select()
        End If

    End Sub



    ''' ARDUINO ''''''''''''''''''''
    Private Sub comPort_ComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub
    Private Sub connect_BTN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles connect_BTN.Click
        CONNECT_SERIAL()
    End Sub
    Public Sub CONNECT_SERIAL()

        Try
            If (connect_BTN.Text = "Connect") Then
                If (comPORT <> "") Then
                    SerialPort1.Close()
                    SerialPort1.PortName = comPORT
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = System.IO.Ports.Parity.None
                    SerialPort1.StopBits = System.IO.Ports.StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default
                    SerialPort1.ReadTimeout = 5000

                    SerialPort1.Open()
                    connect_BTN.Text = "Dis-connect"

                    serial_LBL.Text = "connected"
                    serial_LBL.ForeColor = Color.Green
                Else
                    MsgBox("Select a COM port first")
                End If
            Else
                SerialPort1.Close()
                connect_BTN.Text = "Connect"

                serial_LBL.Text = "not connected"
                serial_LBL.ForeColor = Color.Red
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim ReceivedData As String = SerialPort1.ReadLine()
        Me.Invoke(adre, ReceivedData)
    End Sub
    Private Sub ArduinoData(ByVal sdata As String)
        TextBox1.AppendText(sdata)
        arduino_stream = TextBox1.Text
        TextBox1.Text = ""
    End Sub

    '' GENERAL GUI MGM
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()

    End Sub

    Private Sub Timer1sec_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1sec.Tick

        TextBox_time.Text = Format(Now(), "dd/MM/yyyy HH:mm:ss")
    End Sub


    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click

        Dim r As MsgBoxResult

        r = MsgBox("Are your data  saved?! Are you sure you want to exit this program?", MsgBoxStyle.YesNo, "Close")
        If r = MsgBoxResult.Yes Then
            Close()
        End If

        If r = MsgBoxResult.No Then
            save_data_to_file()
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.DoEvents()
        If device1.Attached Then
            device1.Close()

        End If
    End Sub


    Private Sub Button3_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button_addrow.Click
        DataGridView_samplenames.Rows.Add("", "", "", "", "")
        '  Label_message.Text = zero_string(38)

    End Sub

    Private Sub Button_removerow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_removerow.Click
        If DataGridView_samplenames.Rows.Count > 2 Then
            DataGridView_samplenames.Rows.RemoveAt(DataGridView_samplenames.Rows.Count - 2)
        End If
    End Sub

    Private Sub NumericUpDown_meas_interval_sec_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NumericUpDown_meas_interval_min.ValueChanged

        Timer_START_DAQ.Interval = 60 * NumericUpDown_meas_interval_min.Value * 1000


    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_advacnedsetting.Click
        Advance_settings.Show()
    End Sub

    Private Sub TextBox_lightintensity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_lightintensity.DoubleClick
        Dim index_value As Integer
        If Integer.TryParse(TextBox_campaign.Text, index_value) = True Then
            TextBox_comment.Text = zero_string(0) & " - " & zero_string(index_value)
        End If
    End Sub
End Class
