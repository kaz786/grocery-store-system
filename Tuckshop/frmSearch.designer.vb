<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtSrch = New System.Windows.Forms.TextBox()
        Me.lvwSearch = New System.Windows.Forms.ListView()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(510, 540)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 32)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtSrch
        '
        Me.txtSrch.BackColor = System.Drawing.Color.White
        Me.txtSrch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrch.Location = New System.Drawing.Point(9, 5)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(384, 21)
        Me.txtSrch.TabIndex = 1
        '
        'lvwSearch
        '
        Me.lvwSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwSearch.FullRowSelect = True
        Me.lvwSearch.GridLines = True
        Me.lvwSearch.Location = New System.Drawing.Point(9, 32)
        Me.lvwSearch.Name = "lvwSearch"
        Me.lvwSearch.Size = New System.Drawing.Size(384, 435)
        Me.lvwSearch.TabIndex = 1
        Me.lvwSearch.UseCompatibleStateImageBehavior = False
        Me.lvwSearch.View = System.Windows.Forms.View.Details
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(318, 473)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 23)
        Me.cmdok.TabIndex = 4
        Me.cmdok.Text = "OK"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtSrch)
        Me.Controls.Add(Me.lvwSearch)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-::: Search :::-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtSrch As System.Windows.Forms.TextBox
    Friend WithEvents lvwSearch As System.Windows.Forms.ListView
    Friend WithEvents cmdok As System.Windows.Forms.Button
End Class
