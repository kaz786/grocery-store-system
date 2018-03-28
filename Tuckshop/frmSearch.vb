Imports System.String

Public Class frmSearch
    Public lst As Windows.Forms.ListViewItem
    Public intSubItem As Integer
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click, cmdCancel.Click
        Try
            If (sender.Equals(cmdok)) Then
                BlnSuccess = True
                If lvwSearch.SelectedItems.Count = 0 Then
                    lst = lvwSearch.Items.Item(0)
                Else
                    lst = lvwSearch.FocusedItem
                End If
            ElseIf (sender.Equals(cmdCancel)) Then
                BlnSuccess = False
            End If
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub frmSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '    Try
    '        'If (Asc(e.KeyChar) = enKeyAsci.vbEnter) Then
    '        '    cmdOk.Enabled = True
    '        '    Call cmdOk_Click(cmdOk, e)
    '        'End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Sub SetActiveObject(ByVal obj As Object)
        If (obj.enabled And obj.visible) Then obj.focus()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSrch.KeyDown
        Try
            If (e.KeyCode = Keys.Down) Then
                Call SetActiveObject(lvwSearch)
                Call My.Computer.Keyboard.SendKeys("{Right}")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SearchItem()
        Try
            Dim i As Integer
            For i = 0 To lvwSearch.Items.Count - 1
                If (Len(txtSrch.Text) <> 0) Then
                    If (intSubItem = 0) Then
                        If (UCase(txtSrch.Text) = LeftStr(lvwSearch.Items(i).Text, Len(txtSrch.Text))) Then
                            lvwSearch.FocusedItem = lvwSearch.Items(i)
                            lvwSearch.FocusedItem.ForeColor = Color.Red
                            lvwSearch.FocusedItem.Focused = True
                            lvwSearch.FocusedItem.EnsureVisible()
                            Exit For
                        Else
                            lvwSearch.Items(i).ForeColor = Color.Black
                        End If
                    Else
                        If (UCase(txtSrch.Text) = LeftStr(lvwSearch.Items(i).SubItems(intSubItem).Text, Len(txtSrch.Text))) Then
                            lvwSearch.FocusedItem = lvwSearch.Items(i)
                            lvwSearch.FocusedItem.ForeColor = Color.Red
                            lvwSearch.FocusedItem.Focused = True
                            lvwSearch.FocusedItem.EnsureVisible()
                            Exit For
                        Else
                            lvwSearch.Items(i).ForeColor = Color.Black
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtSrch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSrch.TextChanged
        Try
            Call SearchItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (lvwSearch.Items.Count = 0) Then
                MsgBox("No record found.", MsgBoxStyle.Exclamation, "Not Found")
                Me.Close()
            Else
                txtSrch.Clear()
                txtSrch.Focus()
                cmdok.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lvwSearch_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwSearch.ColumnClick
        Try
            intSubItem = e.Column
            If (lvwSearch.Sorting = SortOrder.Ascending) Then
                lvwSearch.Sorting = SortOrder.Descending
            Else
                lvwSearch.Sorting = SortOrder.Ascending
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lvwSearch_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwSearch.MouseDoubleClick
        Try
            BlnSuccess = True
            lst = lvwSearch.FocusedItem
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lvwSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwSearch.SelectedIndexChanged
        Try
            cmdok.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSearch_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class