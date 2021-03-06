﻿Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Shared Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If Convert.ToBoolean(Program.GetSetting("Pastebin")) Then
                Helper.Log("Exception: " & e.ToString & "/ Message: " & e.Exception.Source)
                Helper.PasteBinUpload()
            End If
        End Sub

        Private Shared Sub MyApplication_Startup(ByVal sender As Object, ByVal e As StartupEventArgs) Handles Me.Startup
            Program.Main()
        End Sub
    End Class
End Namespace

