<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckoutPengembalian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DendaDataSource = New SewaMotor_Pterpan.DendaDataSource()
        Me.ViewDendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewDendaTableAdapter = New SewaMotor_Pterpan.DendaDataSourceTableAdapters.ViewDendaTableAdapter()
        Me.InvoiceSewaDataSet = New SewaMotor_Pterpan.InvoiceSewaDataSet()
        Me.ViewNotaPeminjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewNotaPeminjamanTableAdapter = New SewaMotor_Pterpan.InvoiceSewaDataSetTableAdapters.ViewNotaPeminjamanTableAdapter()
        CType(Me.DendaDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceSewaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewNotaPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DendaDataSet"
        ReportDataSource1.Value = Me.ViewDendaBindingSource
        ReportDataSource2.Name = "InvoicePengembalianDataSet"
        ReportDataSource2.Value = Me.ViewNotaPeminjamanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SewaMotor_Pterpan.ReportInvoicePengembalian.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowPrintButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(993, 466)
        Me.ReportViewer1.TabIndex = 40
        '
        'DendaDataSource
        '
        Me.DendaDataSource.DataSetName = "DendaDataSource"
        Me.DendaDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewDendaBindingSource
        '
        Me.ViewDendaBindingSource.DataMember = "ViewDenda"
        Me.ViewDendaBindingSource.DataSource = Me.DendaDataSource
        '
        'ViewDendaTableAdapter
        '
        Me.ViewDendaTableAdapter.ClearBeforeFill = True
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
        'FormCheckoutPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 466)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormCheckoutPengembalian"
        Me.Text = "FormCheckoutPengembalian"
        CType(Me.DendaDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceSewaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewNotaPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ViewDendaBindingSource As BindingSource
    Friend WithEvents DendaDataSource As DendaDataSource
    Friend WithEvents ViewNotaPeminjamanBindingSource As BindingSource
    Friend WithEvents InvoiceSewaDataSet As InvoiceSewaDataSet
    Friend WithEvents ViewDendaTableAdapter As DendaDataSourceTableAdapters.ViewDendaTableAdapter
    Friend WithEvents ViewNotaPeminjamanTableAdapter As InvoiceSewaDataSetTableAdapters.ViewNotaPeminjamanTableAdapter
End Class
