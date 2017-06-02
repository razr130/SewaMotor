<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporanSewaMotor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanSewaMotor))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetSewaMotor2 = New SewaMotor_Pterpan.DataSetSewaMotor2()
        Me.Oder_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Oder_DetailTableAdapter = New SewaMotor_Pterpan.DataSetSewaMotor2TableAdapters.Oder_DetailTableAdapter()
        CType(Me.DataSetSewaMotor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Oder_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "OrderDetailDataSet2"
        ReportDataSource1.Value = Me.Oder_DetailBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SewaMotor_Pterpan.ReportSewaMotor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(886, 332)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetSewaMotor2
        '
        Me.DataSetSewaMotor2.DataSetName = "DataSetSewaMotor2"
        Me.DataSetSewaMotor2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Oder_DetailBindingSource
        '
        Me.Oder_DetailBindingSource.DataMember = "Oder_Detail"
        Me.Oder_DetailBindingSource.DataSource = Me.DataSetSewaMotor2
        '
        'Oder_DetailTableAdapter
        '
        Me.Oder_DetailTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanSewaMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(886, 332)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLaporanSewaMotor"
        Me.Text = "FormLaporan"
        CType(Me.DataSetSewaMotor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Oder_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Oder_DetailBindingSource As BindingSource
    Friend WithEvents DataSetSewaMotor2 As DataSetSewaMotor2
    Friend WithEvents Oder_DetailTableAdapter As DataSetSewaMotor2TableAdapters.Oder_DetailTableAdapter
End Class
