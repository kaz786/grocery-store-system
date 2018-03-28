
Imports System.Data.OleDb


Module Module1
    Dim con As OleDbConnection
    Dim constring As String
    Dim cmd As OleDbCommand
    Public BlnSuccess As Boolean

    Public Function LeftStr(ByVal str As String, ByVal IntLen As Int16) As String
        LeftStr = Microsoft.VisualBasic.Left(str, IntLen)
    End Function
    Public Function OpenRecordSet(ByVal strSQL As String, ByVal TblName As String) As Data.DataSet
        Try

            Dim Ds As New Data.DataSet
            Dim Adp As New OleDbDataAdapter(strSQL, con)
            Adp.Fill(Ds)
            OpenRecordSet = Ds
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub fillupListView(ByVal lst As ListView, ByVal Sql As String, ByVal Heading As String, ByVal ColWidth As String, ByVal Align As String, Optional ByVal CLS As Boolean = True)
        Try
            'Sql = getQueryBackend(Sql)
            'Dim da As New OleDb.OleDbDataAdapter(Sql, cnn)
            Dim ds As New Data.DataSet
            Dim List As ListViewItem
            Dim ColHed() As String, strColWidth() As String, strAlign() As String
            Dim StrKey As String

            Dim I As Integer
            Dim J As Integer
            Dim IntAlign As HorizontalAlignment, IntColWidth As Int16
            With ds
                'da.Fill(ds)
                ds = OpenRecordSet(Sql, "")
                ColHed = Split(Heading, ",")
                strColWidth = Split(ColWidth, ",")
                strAlign = Split(Align, ",")
                If (CLS) Then
                    lst.Items.Clear()
                    lst.Columns.Clear()
                End If

                If (UBound(ColHed) <> ds.Tables(0).Columns.Count - 1) Then
                    MsgBox("Invalid No of Heading", MsgBoxStyle.Exclamation, "Invalid")
                    Exit Sub
                ElseIf (UBound(ColHed) <> UBound(strColWidth)) Then
                    MsgBox("Invalid No of Width", MsgBoxStyle.Exclamation, "Invalid")
                    Exit Sub
                ElseIf (UBound(ColHed) <> UBound(strColWidth)) Then
                    MsgBox("Invalid No of Alingment.", MsgBoxStyle.Exclamation, "Invalid")
                    Exit Sub
                End If

                For I = 0 To ds.Tables(0).Columns.Count - 1
                    Select Case strAlign(I)
                        Case "0"
                            IntAlign = HorizontalAlignment.Center
                        Case "1"
                            IntAlign = HorizontalAlignment.Left
                        Case "2"
                            IntAlign = HorizontalAlignment.Right
                    End Select
                    IntColWidth = Val(strColWidth(I))
                    StrKey = ds.Tables(0).Columns(I).ToString
                    lst.Columns.Add(StrKey, ColHed(I), IntColWidth, IntAlign, "0")
                Next
                'MsgBox(.Tables(0).Rows.Count - 1)
                For I = 0 To ds.Tables(0).Rows.Count - 1
                    List = lst.Items.Add(ds.Tables(0).Rows(I).Item(0).ToString)
                    For J = 1 To lst.Columns.Count - 1
                        If (ds.Tables(0).Rows(I).IsNull(J)) Then
                            List.SubItems.Add("")
                        Else
                            lst.Items(I).SubItems.Add(ds.Tables(0).Rows(I).Item(J))
                        End If
                    Next
                    If (I Mod 2 = 0) Then
                        lst.Items(I).BackColor = Color.Beige
                    End If
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Public Sub connect()

        constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\Tuckshop.accdb;Persist Security Info=False"
        con = New OleDbConnection(constring)



        Try
            con.Open()



        Catch ex As Exception
            MsgBox("File Could Not Be Found. Please contact the Administrator")
        End Try
    End Sub
    Public Sub sqlquery(ByVal str)
        cmd = New OleDbCommand(str, con)
        cmd.ExecuteNonQuery()
    End Sub
End Module

