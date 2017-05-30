<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilterLaporanPerHari
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtFilterTglSewa = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Filter Laporan"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(52, 101)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(121, 23)
        Me.btnFilter.TabIndex = 6
        Me.btnFilter.Text = "Go"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dtFilterTglSewa
        '
        Me.dtFilterTglSewa.Location = New System.Drawing.Point(15, 63)
        Me.dtFilterTglSewa.Name = "dtFilterTglSewa"
        Me.dtFilterTglSewa.Size = New System.Drawing.Size(200, 20)
        Me.dtFilterTglSewa.TabIndex = 8
        '
        'FormFilterLaporanPerHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(236, 143)
        Me.Controls.Add(Me.dtFilterTglSewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFilter)
        Me.Name = "FormFilterLaporanPerHari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFilterLaporanPerHari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents dtFilterTglSewa As DateTimePicker
End Class
