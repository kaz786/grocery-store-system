Public Class Studrprt

    Private Sub Studrprt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TuckshopDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.TuckshopDataSet.Student)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class