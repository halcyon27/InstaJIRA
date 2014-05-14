Imports System.Xml
Imports System.IO
Imports System.Text

Module mod_getDeviceInfo

    Public Sub getDeviceInfo()
        Call setActiveTab()

        Dim model As String = ""
        Dim series As String = ""
        Dim os As String = ""

        Dim ds_deviceList As New System.Data.DataSet
        ds_deviceList.ReadXml(xmlFilePath & "inventoryList.xml")

        Dim findDevice As String = ""
        If getActiveTabIndex() = 0 Then findDevice = frm_main.cbx_diNumber0.Text
        If getActiveTabIndex() = 1 Then findDevice = frm_main.cbx_diNumber1.Text
        If getActiveTabIndex() = 2 Then findDevice = frm_main.cbx_diNumber2.Text
        If findDevice = "" Then Exit Sub

        For Each dr As DataRow In ds_deviceList.Tables(0).Rows
            If dr.Item(0).ToString = findDevice Then
                model = dr.Item(1).ToString
                series = dr.Item(2).ToString
                os = dr.Item(3).ToString
            End If

            If getActiveTabIndex() = 0 Then frm_main.tbx_deviceInfo0.Text = "model=" & model & " | series=" & series & " | os=" & os
            If getActiveTabIndex() = 1 Then frm_main.tbx_deviceInfo1.Text = "model=" & model & " | series=" & series & " | os=" & os
            If getActiveTabIndex() = 2 Then frm_main.tbx_deviceInfo2.Text = "model=" & model & " | series=" & series & " | os=" & os

        Next

    End Sub

End Module
