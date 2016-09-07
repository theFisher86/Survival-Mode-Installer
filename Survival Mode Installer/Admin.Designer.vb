<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.btnLocateMBINCompiler = New System.Windows.Forms.Button()
        Me.lblMBINCompilerPath = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(12, 12)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFile.TabIndex = 0
        Me.btnAddFile.Text = "Add File"
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'btnLocateMBINCompiler
        '
        Me.btnLocateMBINCompiler.Location = New System.Drawing.Point(12, 41)
        Me.btnLocateMBINCompiler.Name = "btnLocateMBINCompiler"
        Me.btnLocateMBINCompiler.Size = New System.Drawing.Size(120, 23)
        Me.btnLocateMBINCompiler.TabIndex = 1
        Me.btnLocateMBINCompiler.Text = "Locate MBINCompiler"
        Me.btnLocateMBINCompiler.UseVisualStyleBackColor = True
        '
        'lblMBINCompilerPath
        '
        Me.lblMBINCompilerPath.AutoSize = True
        Me.lblMBINCompilerPath.Location = New System.Drawing.Point(138, 46)
        Me.lblMBINCompilerPath.Name = "lblMBINCompilerPath"
        Me.lblMBINCompilerPath.Size = New System.Drawing.Size(41, 13)
        Me.lblMBINCompilerPath.TabIndex = 2
        Me.lblMBINCompilerPath.Text = "Not set"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 262)
        Me.Controls.Add(Me.lblMBINCompilerPath)
        Me.Controls.Add(Me.btnLocateMBINCompiler)
        Me.Controls.Add(Me.btnAddFile)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddFile As Button
    Friend WithEvents btnLocateMBINCompiler As Button
    Friend WithEvents lblMBINCompilerPath As Label
End Class
