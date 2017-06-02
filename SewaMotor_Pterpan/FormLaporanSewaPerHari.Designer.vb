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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ViewNotaPeminjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceSewaDataSet = New SewaMotor_Pterpan.InvoiceSewaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ViewNotaPeminjamanTableAdapter = New SewaMotor_Pterpan.InvoiceSewaDataSetTableAdapters.ViewNotaPeminjamanTableAdapter()
        Me.ViewLaporanDendaDataSource = New SewaMotor_Pterpan.ViewLaporanDendaDataSource()
        Me.ViewLaporanDendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewLaporanDendaTableAdapter = New SewaMotor_Pterpan.ViewLaporanDendaDataSourceTableAdapters.ViewLaporanDendaTableAdapter()
        CType(Me.ViewNotaPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceSewaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewLaporanDendaDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewLaporanDendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewNotaPeminjamanBindingSource
        '
        Me.ViewNotaPeminjamanBindingSource.DataMember = "ViewNotaPeminjaman"
        Me.ViewNotaPeminjamanBindingSource.DataSource = Me.InvoiceSewaDataSet
        '
        'InvoiceSewaDataSet
        '
        Me.InvoiceSewaDataSet.DataSetName = "InvoiceSewaDataSet"
        Me.InvoiceSewaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "LaporanHarianDataSet"
        ReportDataSource1.Value = Me.ViewNotaPeminjamanBindingSource
        ReportDataSource2.Name = "LaporanDendaDataSet"
        ReportDataSource2.Value = Me.ViewLaporanDendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
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
        Me.ReportViewer1.Size = New System.Drawing.Size(583, 503)
        Me.ReportViewer1.TabIndex = 39
        '
        'ViewNotaPeminjamanTableAdapter
        '
        Me.ViewNotaPeminjamanTableAdapter.ClearBeforeFill = True
        '
        'ViewLaporanDendaDataSource
        '
        Me.ViewLaporanDendaDataSource.DataSetName = "ViewLaporanDendaDataSource"
        Me.ViewLaporanDendaDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewLaporanDendaBindingSource
        '
        Me.ViewLaporanDendaBindingSource.DataMember = "ViewLaporanDenda"
        Me.ViewLaporanDendaBindingSource.DataSource = Me.ViewLaporanDendaDataSource
        '
        'ViewLaporanDendaTableAdapter
        '
        Me.ViewLaporanDendaTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanSewaPerHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 503)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanSewaPerHari"
        Me.Text = "FormLaporanSewaPerHari"
        CType(Me.ViewNotaPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceSewaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewLaporanDendaDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewLaporanDendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ViewNotaPeminjamanBindingSource As BindingSource
    Friend WithEvents InvoiceSewaDataSet As InvoiceSewaDataSet
    Friend WithEvents ViewNotaPeminjamanTableAdapter As InvoiceSewaDataSetTableAdapters.ViewNotaPeminjamanTableAdapter
    Friend WithEvents ViewLaporanDendaBindingSource As BindingSource
    Friend WithEvents ViewLaporanDendaDataSource As ViewLaporanDendaDataSource
    Friend WithEvents ViewLaporanDendaTableAdapter As ViewLaporanDendaDataSourceTableAdapters.ViewLaporanDendaTableAdapter
End Class
