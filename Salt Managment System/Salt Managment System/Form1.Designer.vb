﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MastersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductmasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabourmasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents LedgermasterToolStripMenuItem As ToolStripMenuItem
End Class
