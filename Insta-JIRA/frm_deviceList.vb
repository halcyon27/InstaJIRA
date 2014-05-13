Public Class frm_deviceList

    Private Sub frm_deviceList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ds_deviceList.ReadXml(xmlFilePath & "inventoryList.xml")

        grid_deviceList.DataSource = ds_deviceList
        grid_deviceList.DataMember = "device"

    End Sub
End Class