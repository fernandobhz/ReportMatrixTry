<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rel_estatistico_anomaliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New ReportMatrixTry.DataSet1
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Rel_estatistico_anomaliaTableAdapter1 = New ReportMatrixTry.DataSet1TableAdapters.rel_estatistico_anomaliaTableAdapter
        CType(Me.rel_estatistico_anomaliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rel_estatistico_anomaliaBindingSource
        '
        Me.rel_estatistico_anomaliaBindingSource.DataMember = "rel_estatistico_anomalia"
        Me.rel_estatistico_anomaliaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1_rel_estatistico_anomalia"
        ReportDataSource1.Value = Me.rel_estatistico_anomaliaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer1.ServerReport.ReportPath = "/Report Project1/Report1"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://localhost/ReportServer", System.UriKind.Absolute)
        Me.ReportViewer1.Size = New System.Drawing.Size(486, 446)
        Me.ReportViewer1.TabIndex = 0
        '
        'Rel_estatistico_anomaliaTableAdapter1
        '
        Me.Rel_estatistico_anomaliaTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 446)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.rel_estatistico_anomaliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rel_estatistico_anomaliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As ReportMatrixTry.DataSet1
    Friend WithEvents Rel_estatistico_anomaliaTableAdapter1 As ReportMatrixTry.DataSet1TableAdapters.rel_estatistico_anomaliaTableAdapter

End Class
