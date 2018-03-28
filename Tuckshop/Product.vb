Public Class Product
    Dim qry As String

  

    Private Sub Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            GroupBox1.Enabled = True
            Update1.Enabled = True
            Add.Enabled = False
            Delete.Enabled = True
            Pro_Id.Enabled = False

            Try
                Call fillupListView(frmSearch.lvwSearch, "SELECT Prod_Id,Prod_Name FROM Product", "Product Id, Product Name", "90,450", "1,1")
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
    Sub grpdis()
        Pro_Id.Text = ""
        Pro_Nam.Text = ""
        Pro_Pric.Text = ""
        Pro_Cur.Text = ""
        Pro_Lim.Text = ""
        GroupBox1.Enabled = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update1.Click
        Try

            If Pro_Cur.Text = "" Or Pro_Id.Text = "" Or Pro_Lim.Text = "" Or Pro_Nam.Text = "" Or Pro_Pric.Text = "" Then
                MsgBox("Please fill all the details ")
                Exit Sub
            Else
                qry = "update Product set Prod_Name='" & Pro_Nam.Text & "',Price=" & Pro_Pric.Text & ",Limit=" & Pro_Lim.Text & ",Cur_ava=" & Pro_Cur.Text & "  where Prod_Id=" & Pro_Id.Text
                Call sqlquery(qry)
                MsgBox("Your Data Has Been Updated")
                Update1.Enabled = False
                Call grpdis()
                Delete.Enabled = False
                Add.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Pro_Cur.Text = "" Or Pro_Id.Text = "" Or Pro_Lim.Text = "" Or Pro_Nam.Text = "" Or Pro_Pric.Text = "" Then
                MsgBox("Please fill all the details ")
                Exit Sub
            Else
                qry = "insert into Product values(" & Pro_Id.Text & ",'" & Pro_Nam.Text & "'," & Pro_Pric.Text & "," & Pro_Lim.Text & "," & Pro_Cur.Text & ")"
                Call sqlquery(qry)
                Call grpdis()
                cmdSave.Enabled = False
                Add.Enabled = True
                cmdSearch.Enabled = True
                MsgBox(" Your Data Has Been Saved...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click

        Try
            qry = "delete from Product where Prod_Id=" & Pro_Id.Text
            Call sqlquery(qry)
            MsgBox("Your Data Has Been Deleted")
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
            strSQL = "SELECT max(Prod_Id) as mpro FROM Product"
            ds = OpenRecordSet(strSQL, "Product")
            Pro_Id.Text = ds.Tables(0).Rows(0).Item("mpro").ToString + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
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

    Private Sub ShowData()
        Try
            Pro_Id.Text = frmSearch.lst.Text
            Pro_Nam.Text = frmSearch.lst.SubItems(1).Text
            Dim DtSet As New Data.DataSet
            Dim strSQL As String
            strSQL = "SELECT * FROM Product where Prod_Id = " & Pro_Id.Text
            DtSet = OpenRecordSet(strSQL, "Product")
            Pro_Pric.Text = DtSet.Tables(0).Rows(0).Item("Price").ToString
            Pro_Lim.Text = DtSet.Tables(0).Rows(0).Item("Limit").ToString
            Pro_Cur.Text = DtSet.Tables(0).Rows(0).Item("Cur_ava").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub valtxt()
        Try
            If Pro_Cur.Text = "" Or Pro_Id.Text = "" Or Pro_Lim.Text = "" Or Pro_Nam.Text = "" Or Pro_Pric.Text = "" Then
                MsgBox("Please fill all the details ")
            End If
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

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

  
    Private Sub Pro_Pric_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pro_Pric.LostFocus
        Try
            If Not IsNumeric(Pro_Pric.Text) Then
                MsgBox("Please Enter Number value only..!!!")
                Pro_Pric.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
    End Sub

    Private Sub Pro_Lim_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pro_Lim.LostFocus
        Try
            If Not IsNumeric(Pro_Lim.Text) Then
                MsgBox("Please Enter Number value only..!!!")
                Pro_Lim.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Pro_Cur_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pro_Cur.LostFocus
        Try
            If Not IsNumeric(Pro_Cur.Text) Then
                MsgBox("Please Enter Number value only..!!!")
                Pro_Cur.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

