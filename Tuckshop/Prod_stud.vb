
Public Class Prod_stud
    Dim qry As String
    Dim tdt As Date

    Private Sub Prod_stud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            txtdt.Text = Format(Today, "dd/MM/yyyy")
            tdt = Format(Today, "MM/dd/yyyy")
            Call connect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Private Sub txtadm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadm.LostFocus



        Try
            If Not IsNumeric(txtadm.Text) Then
                MsgBox("Please Enter Number value only..!!!")
                txtadm.Text = ""
            Else
                Try
                    Dim ds1 As New DataSet
                    Dim na1 As String
                    ds1 = OpenRecordSet("select Stu_Name from Student where Adm_no=" & txtadm.Text, "Student")
                    na1 = ds1.Tables(0).Rows(0).Item(0).ToString
                    txtSN.Text = na1
                    ds1.Clear()


                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub txtPid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPid.KeyPress

        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                Dim ds2 As New DataSet
                Dim na2 As String
                Call fillupListView(frmSearch.lvwSearch, "select Prod_Id,Prod_Name,Price from Product", "Product Id,Product Name,Price", "100,200,100", "0,2,1")
                frmSearch.intSubItem = 0
                frmSearch.ShowDialog()
                If (BlnSuccess) Then
                    BlnSuccess = False
                    txtPid.Text = frmSearch.lst.Text
                    ds2 = OpenRecordSet("select Price from Product where Prod_Id=" & txtPid.Text, "Product")
                    na2 = ds2.Tables(0).Rows(0).Item(0).ToString
                    txtPri.Text = na2
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    
    End Sub
    Private Sub txtPid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPid.LostFocus
        If Not IsNumeric(txtPid.Text) Then
            MsgBox("Please Enter Number value only..!!!", MsgBoxStyle.Information)
            txtPid.Text = ""
            txtadm.Text = ""
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If txtadm.Text = "" Or txtPri.Text = "" Then
                MsgBox("Enter the details", MsgBoxStyle.Question)
            Else
                Dim ds3 As DataSet
                Dim na3 As Integer
                ds3 = OpenRecordSet("Select Buy_Limit from Student where Adm_No= " & txtadm.Text, "Student")
                na3 = ds3.Tables(0).Rows(0).Item(0).ToString
                If txtPri.Text <= na3 Then
                    qry = "insert into Stud_Prod(Stud_id,Prod_id,Pur_dt,Price) values(" & txtadm.Text & "," & txtPid.Text & ",#" & FormatDateTime(tdt, DateFormat.ShortDate) & "#," & txtPri.Text & ")"
                    Call sqlquery(qry)
                    qry = "update student set Buy_limit=" & na3 - txtPri.Text & "  where Adm_no=" & txtadm.Text
                    Call sqlquery(qry)
                Else
                    MsgBox("Limit is Over")
                End If


                Call fillupListView(lvwSearch1, "SELECT Stud_Prod.Prod_Id, Product.Prod_Name, Product.Price" _
                                    & " FROM Student INNER JOIN (Product INNER JOIN Stud_Prod ON Product.Prod_Id = Stud_Prod.Prod_Id) ON Student.Adm_No = Stud_Prod.Stud_id where Stud_Prod.Stud_id =" & txtadm.Text, "ProductID,ProductName,Price", "100,100,50", "0,0,0")
                buylimit.Text = "Current Available Balance for today is :-    " & na3 - txtPri.Text & " rs."
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    

  

    End Class