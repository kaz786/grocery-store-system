Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim Username As String = Textbox1.Text
            Dim Password As String = Textbox2.Text
            If Username = "admin" Then
                If Password = "admin" Then
                    ' MsgBox("Login Successfull")
                    main.Show()
                    Textbox1.Text = ""
                    Textbox2.Text = ""
                Else
                    MsgBox("Your Password is incorrect.. Try Agian ")
                    Textbox1.Text = ""
                    Textbox2.Text = ""
                End If
            Else
                MsgBox("Your Username is incorrect")
                Textbox1.Text = ""
                Textbox2.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'PictureBox.ImageLocation = My.Application.Info.DirectoryPath & "\Image\Login.png"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class


