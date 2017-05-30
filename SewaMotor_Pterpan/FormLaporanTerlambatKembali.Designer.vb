<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanTerlambatKembali
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanTerlambatKembali))
        Me.ViewTerlambatKembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotorTerlambatDataSet = New SewaMotor_Pterpan.MotorTerlambatDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ViewTerlambatKembaliTableAdapter = New SewaMotor_Pterpan.MotorTerlambatDataSetTableAdapters.ViewTerlambatKembaliTableAdapter()
        CType(Me.ViewTerlambatKembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorTerlambatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewTerlambatKembaliBindingSource
        '
        Me.ViewTerlambatKembaliBindingSource.DataMember = "ViewTerlambatKembali"
        Me.ViewTerlambatKembaliBindingSource.DataSource = Me.MotorTerlambatDataSet
        '
        'MotorTerlambatDataSet
        '
        Me.MotorTerlambatDataSet.DataSetName = "MotorTerlambatDataSet"
        Me.MotorTerlambatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MotorTerlambatDataSet"
        ReportDataSource1.Value = Me.ViewTerlambatKembaliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SewaMotor_Pterpan.ReportTerlambatKembali.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1142, 328)
        Me.ReportViewer1.TabIndex = 40
        '
        'ViewTerlambatKembaliTableAdapter
        '
        Me.ViewTerlambatKembaliTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanTerlambatKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1142, 328)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLaporanTerlambatKembali"
        Me.Text = "FormLaporanTerlambatKembali"
        CType(Me.ViewTerlambatKembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorTerlambatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ViewTerlambatKembaliBindingSource As BindingSource
    Friend WithEvents MotorTerlambatDataSet As MotorTerlambatDataSet
    Friend WithEvents ViewTerlambatKembaliTableAdapter As MotorTerlambatDataSetTableAdapters.ViewTerlambatKembaliTableAdapter
End Class
