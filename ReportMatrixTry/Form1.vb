Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataSet1.Merge(Me.Rel_estatistico_anomaliaTableAdapter1.GetData(2, "44791999", New Date(2012, 3, 1)))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
