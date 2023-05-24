
Imports EasyModbus
''' Modbus TCP/IP Client Visual Basic
''' Author by : Nyoman Krisna Prebawa
Public Class Form1
    ''' DEKLARASI OBJECT DARI CLASS MODBUS 
    Dim ModClient As New ModbusClient

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        ''DEKLARASI VARIABLE IP & PORT
        ModClient.IPAddress = txtIp.Text
        ModClient.Port = txtPort.Text
        Try
            ModClient.Connect()
            If ModClient.Connected Then
                l_status.Text = "Connected"
                btn_connect.Enabled = False
                btn_disconnect.Enabled = True
                grp_read.Enabled = True
                grp_write.Enabled = True

            End If
        Catch ex As Exception
            l_status.Text = "Error Connection!"
        End Try
    End Sub

    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        ModClient.Disconnect()
        l_status.Text = "Disconnected."
        btn_connect.Enabled = True
        btn_disconnect.Enabled = False
        grp_read.Enabled = False
        grp_write.Enabled = False
    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        Try
            Dim RegVals As Integer()
            ''READ DATA DARI APP SIMULASI EASYMODBUS 
            RegVals = ModClient.ReadHoldingRegisters(txt_startreg.Text, txt_lengthreg.Text)
            ''MEMBACA PANJANG DATA HOLDING REGISTER 
            If RegVals.Length > 0 Then
                ListregValues.Items.Clear()
                For Each value As Integer In RegVals
                    ListregValues.Items.Add(value)
                Next
            End If
        Catch ex As Exception
            ''NONE 
        End Try
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        Try
            ModClient.WriteSingleRegister(txt_writeReg.Text, txt_valueReg.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class
