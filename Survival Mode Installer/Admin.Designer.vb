<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSurvivalModeInstaller
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
        Me.tabMainInterface = New System.Windows.Forms.TabControl()
        Me.tabSetup = New System.Windows.Forms.TabPage()
        Me.tabMainInterface.SuspendLayout()
        Me.tabSetup.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(6, 6)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFile.TabIndex = 0
        Me.btnAddFile.Text = "Add File"
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'btnLocateMBINCompiler
        '
        Me.btnLocateMBINCompiler.Location = New System.Drawing.Point(3, 35)
        Me.btnLocateMBINCompiler.Name = "btnLocateMBINCompiler"
        Me.btnLocateMBINCompiler.Size = New System.Drawing.Size(120, 23)
        Me.btnLocateMBINCompiler.TabIndex = 1
        Me.btnLocateMBINCompiler.Text = "Locate MBINCompiler"
        Me.btnLocateMBINCompiler.UseVisualStyleBackColor = True
        '
        'lblMBINCompilerPath
        '
        Me.lblMBINCompilerPath.AutoSize = True
        Me.lblMBINCompilerPath.Location = New System.Drawing.Point(129, 45)
        Me.lblMBINCompilerPath.Name = "lblMBINCompilerPath"
        Me.lblMBINCompilerPath.Size = New System.Drawing.Size(41, 13)
        Me.lblMBINCompilerPath.TabIndex = 2
        Me.lblMBINCompilerPath.Text = "Not set"
        '
        'tabMainInterface
        '
        Me.tabMainInterface.Controls.Add(Me.tabSetup)
        Me.tabMainInterface.Location = New System.Drawing.Point(12, 12)
        Me.tabMainInterface.Name = "tabMainInterface"
        Me.tabMainInterface.SelectedIndex = 0
        Me.tabMainInterface.Size = New System.Drawing.Size(763, 381)
        Me.tabMainInterface.TabIndex = 3
        '
        'tabSetup
        '
        Me.tabSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tabSetup.Controls.Add(Me.btnLocateMBINCompiler)
        Me.tabSetup.Controls.Add(Me.lblMBINCompilerPath)
        Me.tabSetup.Controls.Add(Me.btnAddFile)
        Me.tabSetup.Location = New System.Drawing.Point(4, 22)
        Me.tabSetup.Name = "tabSetup"
        Me.tabSetup.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSetup.Size = New System.Drawing.Size(755, 355)
        Me.tabSetup.TabIndex = 0
        Me.tabSetup.Text = "Setup"
        Me.tabSetup.UseVisualStyleBackColor = True
        '
        'frmSurvivalModeInstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 405)
        Me.Controls.Add(Me.tabMainInterface)
        Me.Name = "frmSurvivalModeInstaller"
        Me.Text = "Survival Mode Installer"
        Me.tabMainInterface.ResumeLayout(False)
        Me.tabSetup.ResumeLayout(False)
        Me.tabSetup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddFile As Button
    Friend WithEvents btnLocateMBINCompiler As Button
    Friend WithEvents lblMBINCompilerPath As Label
    Friend WithEvents tabMainInterface As TabControl
    Friend WithEvents tabSetup As TabPage
End Class
