<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanSewaPerHari
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InvoiceSewaDataSet = New SewaMotor_Pterpan.InvoiceSewaDataSet()
        Me.ViewNotaPeminjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewNotaPeminjamanTableAdapter = New SewaMotor_Pterpan.InvoiceSewaDataSetTableAdapters.ViewNotaPeminjamanTableAdapter()
        CType(Me.InvoiceSewaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewNotaPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "LaporanHarianDataSet"
        ReportDataSource1.Value = Me.ViewNotaPeminjamanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SewaMotor_Pterpan.ReportTransaksiPerHari.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(746, 396)
        Me.ReportViewer1.TabIndex = 39
        '
        'InvoiceSewaDataSet
        '
        Me.InvoiceSewaDataSet.DataSetName = "InvoiceSewaDataSet"
        Me.InvoiceSewaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewNotaPeminjamanBindingSource
        '
        Me.ViewNotaPeminjamanBindingSource.DataMember = "ViewNotaPeminjaman"
        Me.ViewNotaPeminjamanBindingSource.DataSource = Me.InvoiceSewaDataSet
        '
        'ViewNotaPeminjamanTableAdapter
        '
        Me.ViewNotaPeminjamanTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanSewaPerHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 396)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanSewaPerHari"
        Me.Text = "FormLaporanSewaPerHari"
        CType(Me.InvoiceSewaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewNotaPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ViewNotaPeminjamanBindingSource As BindingSource
    Friend WithEvents InvoiceSewaDataSet As InvoiceSewaDataSet
    Friend WithEvents ViewNotaPeminjamanTableAdapter As InvoiceSewaDataSetTableAdapters.ViewNotaPeminjamanTableAdapter
End Class
