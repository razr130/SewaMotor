<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporanStatusMotor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanStatusMotor))
        Me.MotorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewaMotorDataSource = New SewaMotor_Pterpan.SewaMotorDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MotorTableAdapter = New SewaMotor_Pterpan.SewaMotorDataSourceTableAdapters.MotorTableAdapter()
        CType(Me.MotorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewaMotorDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MotorBindingSource
        '
        Me.MotorBindingSource.DataMember = "Motor"
        Me.MotorBindingSource.DataSource = Me.SewaMotorDataSource
        '
        'SewaMotorDataSource
        '
        Me.SewaMotorDataSource.DataSetName = "SewaMotorDataSource"
        Me.SewaMotorDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MotorDataSet"
        ReportDataSource1.Value = Me.MotorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SewaMotor_Pterpan.ReportStatusMotor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(877, 332)
        Me.ReportViewer1.TabIndex = 38
        '
        'MotorTableAdapter
        '
        Me.MotorTableAdapter.ClearBeforeFill = True
        '
        'FormLaporanStatusMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(877, 332)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLaporanStatusMotor"
        Me.Text = "FormLaporanStatusMotor"
        CType(Me.MotorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewaMotorDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MotorBindingSource As BindingSource
    Friend WithEvents SewaMotorDataSource As SewaMotorDataSource
    Friend WithEvents MotorTableAdapter As SewaMotorDataSourceTableAdapters.MotorTableAdapter
End Class
