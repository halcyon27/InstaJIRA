Public Class frm_deviceList

    Private Sub frm_deviceList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim xmlPath As String = "C:\Users\aden_williamson\Desktop\inventoryList.xml"

        ds_deviceList.ReadXml(xmlPath)

        grid_deviceList.DataSource = ds_deviceList
        grid_deviceList.DataMember = "device"

    End Sub
End Class