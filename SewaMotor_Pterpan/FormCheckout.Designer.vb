<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckout
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MotorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSewaMotor2 = New SewaMotor_Pterpan.DataSetSewaMotor2()
        Me.PesanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Oder_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.homeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.katalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotorTableAdapter = New SewaMotor_Pterpan.DataSetSewaMotor2TableAdapters.MotorTableAdapter()
        Me.PesanTableAdapter = New SewaMotor_Pterpan.DataSetSewaMotor2TableAdapters.PesanTableAdapter()
        Me.Oder_DetailTableAdapter = New SewaMotor_Pterpan.DataSetSewaMotor2TableAdapters.Oder_DetailTableAdapter()
        CType(Me.MotorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSewaMotor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PesanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Oder_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "MotorDataSet"
        ReportDataSource1.Value = Me.MotorBindingSource
        ReportDataSource2.Name = "PesanDataSet"
        ReportDataSource2.Value = Me.PesanBindingSource
        ReportDataSource3.Name = "Order_DetailDataSet"
        ReportDataSource3.Value = Me.Oder_DetailBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SewaMotor_Pterpan.ReportSewaMotor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(10, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowPrintButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(518, 468)
        Me.ReportViewer1.TabIndex = 38
        '
        'MotorBindingSource
        '
        Me.MotorBindingSource.DataMember = "Motor"
        Me.MotorBindingSource.DataSource = Me.DataSetSewaMotor2
        '
        'DataSetSewaMotor2
        '
        Me.DataSetSewaMotor2.DataSetName = "DataSetSewaMotor2"
        Me.DataSetSewaMotor2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PesanBindingSource
        '
        Me.PesanBindingSource.DataMember = "Pesan"
        Me.PesanBindingSource.DataSource = Me.DataSetSewaMotor2
        '
        'Oder_DetailBindingSource
        '
        Me.Oder_DetailBindingSource.DataMember = "Oder_Detail"
        Me.Oder_DetailBindingSource.DataSource = Me.DataSetSewaMotor2
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.homeToolStripMenuItem, Me.katalogToolStripMenuItem, Me.loginToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(540, 24)
        Me.menuStrip1.TabIndex = 39
        Me.menuStrip1.Text = "menuStrip1"
        '
        'homeToolStripMenuItem
        '
        Me.homeToolStripMenuItem.Name = "homeToolStripMenuItem"
        Me.homeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.homeToolStripMenuItem.Text = "Home"
        '
        'katalogToolStripMenuItem
        '
        Me.katalogToolStripMenuItem.Name = "katalogToolStripMenuItem"
        Me.katalogToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.katalogToolStripMenuItem.Text = "Katalog"
        '
        'loginToolStripMenuItem
        '
        Me.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.loginToolStripMenuItem.Text = "Logout"
        '
        'MotorTableAdapter
        '
        Me.MotorTableAdapter.ClearBeforeFill = True
        '
        'PesanTableAdapter
        '
        Me.PesanTableAdapter.ClearBeforeFill = True
        '
        'Oder_DetailTableAdapter
        '
        Me.Oder_DetailTableAdapter.ClearBeforeFill = True
        '
        'FormCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 507)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "FormCheckout"
        Me.Text = "FormCheckout"
        CType(Me.MotorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSewaMotor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PesanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Oder_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MotorBindingSource As BindingSource
    Friend WithEvents DataSetSewaMotor2 As DataSetSewaMotor2
    Friend WithEvents PesanBindingSource As BindingSource
    Friend WithEvents Oder_DetailBindingSource As BindingSource
    Friend WithEvents menuStrip1 As MenuStrip
    Private WithEvents homeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents katalogToolStripMenuItem As ToolStripMenuItem
    Private WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotorTableAdapter As DataSetSewaMotor2TableAdapters.MotorTableAdapter
    Friend WithEvents PesanTableAdapter As DataSetSewaMotor2TableAdapters.PesanTableAdapter
    Friend WithEvents Oder_DetailTableAdapter As DataSetSewaMotor2TableAdapters.Oder_DetailTableAdapter
End Class
