Module mod_jiraDescriptions

    Public Sub descriptions()

        Call setActiveTab()
        Call nLanguages()

        ''add additional project-specific lines
        'If project = "Kproject" Then
        '    additionalInfo = "%0D%0Dx-vlsoftware:Name+=+%0Dx-vlsr:AppID+=+"
        'Else
        '    additionalInfo = ""
        'End If

        ''server issues
        vlServer = "" _
         & "TEST+ENVIRONMENT" _
        & "%0Ddevice:+" & diNumber & "+(+" & deviceInfo & "+)" _
        & "%0Dbuild+version:+" & buildVersion _
        & "%0Dbuild+path:+" & buildPath _
        & "%0Dserver:+" & serverEnv & " (+" & software & ")" & additionalInfo _
        & "%0D%0DPRECONDITIONS%0Dalarms,+contacts,+fieldID..." _
        & "%0D%0DDESCRIPTION" _
        & "%0D%0D*REPRODUCE*%0D{quote}%0Dadd%0Dsteps%0D{quote}" _
        & "%0D%0D*EXPECTED*%0D{color:blue}{color}" _
        & "%0D%0D*ACTUAL*%0D{color:red}{color}" _
        & "%0D%0DASR%0D{code}{code}" _
        & "%0D%0DVVS%0D{code}{code}" _
        & "%0D%0DTest+source:+" & testSource

        ''client issues
        vlClient = "" _
       & "TEST+ENVIRONMENT" _
        & "%0Ddevice:+" & diNumber & "+(+" & deviceInfo & "+)" _
       & "%0Dbuild+version:+" & buildVersion _
       & "%0Dbuild+path:+" & buildPath _
       & "%0Dserver:+" & serverEnv & " (+" & software & ")" & additionalInfo _
       & "%0D%0DPRECONDITIONS%0Dalarms,+contacts,+fieldID..." _
       & "%0D%0DDESCRIPTION" _
       & "%0D%0D*REPRODUCE*%0D{quote}%0Dadd%0Dsteps%0D{quote}" _
        & "%0D%0D*EXPECTED*%0D{color:blue}{color}" _
        & "%0D%0D*ACTUAL*%0D{color:red}{color}" _
       & "%0D%0DCLIENT+LOG%0D{code}{code}" _
       & "%0D%0DTest+source:+" & testSource

        ''external issues
        vlExternal = "" _
        & "TEST+ENVIRONMENT" _
        & "%0Dbuild+path:+" & buildPath _
        & "%0D%0DPRECONDITIONS%0Dalarms,+contacts,+fieldID..." _
        & "%0D%0DDESCRIPTION" _
        & "%0D%0D*REPRODUCE*%0D{quote}%0Dadd%0Dsteps%0D{quote}" _
        & "%0D%0D*EXPECTED*%0D{color:blue}{color}" _
        & "%0D%0D*ACTUAL*%0D{color:red}{color}" _
        & "%0D%0DASR%0D{code}{code}" _
        & "%0D%0DVVS%0D{code}{code}" _
        & "%0D%0DTest+source:+" & testSource

        nServer = "" _
        & "&summary=[" & project & "]" & automationTest & "[" & langCode & "]+summary" _
        & "&environment=device:+" & diNumber & "+(+" & deviceInfo & "+)" _
        & "%0Dbuild+path:+" & buildPath & "" _
        & "%0Dbuild+version:+" & buildVersion & "" _
        & "%0Dserver:+" & serverEnv & "+|+host:+" & host & " (+" & software & "+)" _
        & "&description=" _
        & "Test+source:+" & testSource _
        & "%0D%0DPRECONDITIONS%0Dalarms,+contacts,+fieldID..." _
        & "%0D%0DDESCRIPTION%0Ddetails+not+captured+elsewhere" _
        & "%0D%0D*REPRODUCE*%0D{quote}%0Dadd%0Dsteps%0D{quote}" _
        & "%0D%0D*EXPECTED*%0D{color:blue}{color}" _
        & "%0D%0D*ACTUAL*%0D{color:red}{color}" _
        & "%0D%0DCAS%0D{code}{code}"

        nClient = "" _
        & "&summary=[" & project & "]" & automationTest & "[" & langCode & "]+summary" _
        & "&environment=device:+" & diNumber & "+(+" & deviceInfo & "+)" _
        & "%0Dbuild+path:+" & buildPath & "" _
        & "%0Dbuild+version:+" & buildVersion & "" _
        & "%0Dserver:+" & serverEnv & "+|+host:+" & host & " (+" & software & "+)" _
        & "&description=" _
        & "Test+source:+" & testSource _
        & "%0D%0DPRECONDITIONS%0Dalarms,+contacts,+fieldID..." _
        & "%0D%0DDESCRIPTION%0Ddetails+not+captured+elsewhere" _
        & "%0D%0D*REPRODUCE*%0D{quote}%0Dadd%0Dsteps%0D{quote}" _
        & "%0D%0D*EXPECTED*%0D{color:blue}{color}" _
        & "%0D%0D*ACTUAL*%0D{color:red}{color}" _
        & "%0D%0DCLIENT+LOG%0D{code}{code}"

    End Sub

End Module
