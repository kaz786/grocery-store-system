Public Class Student
    Dim qry As String
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        Try
            Call gen_max()
            GroupBox1.Enabled = True
            Add.Enabled = False
            Delete.Enabled = False
            Update1.Enabled = False
            cmdSave.Enabled = True
            cmdSearch.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       


    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click

        Try
            qry = "delete from student where Adm_No=" & txtno.Text
            Call sqlquery(qry)
            MsgBox("Your Data Has Been Deleted", MsgBoxStyle.Information)
            Delete.Enabled = False
            Call grpdis()
            Update1.Enabled = False
            Add.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub gen_max()
        Try
            Dim strSQL As String
            Dim ds As DataSet
            strSQL = "SELECT max(Adm_No) as mstud FROM Student"
            ds = OpenRecordSet(strSQL, "Student")
            txtno.Text = ds.Tables(0).Rows(0).Item("mstud").ToString + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        Try
            If txtadd.Text = "" Or txtbl.Text = "" Or txtname.Text = "" Or txtno.Text = "" Or txtph.Text = "" Then
                MsgBox("Please fill all the details ", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                qry = "update student set Stu_Name='" & txtname.Text & "',Stu_add='" & txtadd.Text & "',Stu_ph=" & txtph.Text & ",Buy_Limit=" & txtbl.Text & " where Adm_No=" & txtno.Text
                Call sqlquery(qry)
                MsgBox("Your Data Has Been Updated", MsgBoxStyle.Information)
                Update1.Enabled = False
                Call grpdis()
                Delete.Enabled = False
                Add.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            GroupBox1.Enabled = True
            Update1.Enabled = True
            Add.Enabled = False
            Delete.Enabled = True
            txtno.Enabled = False
            Try
                Call fillupListView(frmSearch.lvwSearch, "SELECT Adm_no,Stu_Name FROM Student", "StudentNo, StudentName", "90,450", "1,1")
                frmSearch.intSubItem = 0
                frmSearch.ShowDialog()
                If (BlnSuccess) Then
                    BlnSuccess = False
                    Call ShowData()
                    'Call EnableDisableAdd(True)
                    'Call EnableDisableEdit(True)
                    ' Call SetActiveObject(cmdEdit)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ShowData()
        Try
            txtno.Text = frmSearch.lst.Text
            txtname.Text = frmSearch.lst.SubItems(1).Text
            Dim DtSet As New Data.DataSet
            Dim strSQL As String
            strSQL = "SELECT * FROM Student where Adm_no = " & txtno.Text
            DtSet = OpenRecordSet(strSQL, "Student")
            txtadd.Text = DtSet.Tables(0).Rows(0).Item("Stu_add").ToString
            txtph.Text = DtSet.Tables(0).Rows(0).Item("Stu_ph").ToString
            txtbl.Text = DtSet.Tables(0).Rows(0).Item("Buy_Limit").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub grpdis()
        Try
            txtadd.Text = ""
            txtbl.Text = ""
            txtname.Text = ""
            txtno.Text = ""
            txtph.Text = ""
            GroupBox1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Call grpdis()
            Add.Enabled = True
            cmdSearch.Enabled = True
            cmdSave.Enabled = False
            Update1.Enabled = False
            Delete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtadd.Text = "" Or txtbl.Text = "" Or txtname.Text = "" Or txtno.Text = "" Or txtph.Text = "" Then
                MsgBox("Please fill all the details ", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                qry = "insert into student values(" & txtno.Text & ",'" & txtname.Text & "','" & txtadd.Text & "'," & txtph.Text & "," & txtbl.Text & ")"

                Call sqlquery(qry)
                Call grpdis()
                cmdSave.Enabled = False
                Add.Enabled = True
                cmdSearch.Enabled = True
                MsgBox("Your Data Has Been Saved", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call connect()
            GroupBox1.Enabled = False
            Delete.Enabled = False
            Update1.Enabled = False
            cmdSave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtph_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtph.LostFocus
        Try
            If Not IsNumeric(txtph.Text) Then
                MsgBox("Please Enter Number value only..!!!")
                txtph.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbl_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbl.LostFocus
        Try
            If Not IsNumeric(txtbl.Text) Then
                MsgBox("Please Enter Number value only..!!!")
                txtbl.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class