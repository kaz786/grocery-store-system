<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prod_stud
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPri = New System.Windows.Forms.TextBox()
        Me.txtdt = New System.Windows.Forms.TextBox()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.txtadm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvwSearch1 = New System.Windows.Forms.ListView()
        Me.buylimit = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtSN)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPri)
        Me.GroupBox1.Controls.Add(Me.txtdt)
        Me.GroupBox1.Controls.Add(Me.txtPid)
        Me.GroupBox1.Controls.Add(Me.txtadm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSN
        '
        Me.txtSN.Enabled = False
        Me.txtSN.Location = New System.Drawing.Point(116, 92)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(299, 20)
        Me.txtSN.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Student Name"
        '
        'txtPri
        '
        Me.txtPri.Enabled = False
        Me.txtPri.Location = New System.Drawing.Point(116, 128)
        Me.txtPri.Name = "txtPri"
        Me.txtPri.Size = New System.Drawing.Size(134, 20)
        Me.txtPri.TabIndex = 16
        '
        'txtdt
        '
        Me.txtdt.Enabled = False
        Me.txtdt.Location = New System.Drawing.Point(318, 26)
        Me.txtdt.Name = "txtdt"
        Me.txtdt.Size = New System.Drawing.Size(97, 20)
        Me.txtdt.TabIndex = 15
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(116, 59)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(68, 20)
        Me.txtPid.TabIndex = 14
        '
        'txtadm
        '
        Me.txtadm.Location = New System.Drawing.Point(116, 19)
        Me.txtadm.Name = "txtadm"
        Me.txtadm.Size = New System.Drawing.Size(68, 20)
        Me.txtadm.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Product Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Admission Number"
        '
        'lvwSearch1
        '
        Me.lvwSearch1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwSearch1.FullRowSelect = True
        Me.lvwSearch1.GridLines = True
        Me.lvwSearch1.Location = New System.Drawing.Point(9, 198)
        Me.lvwSearch1.Name = "lvwSearch1"
        Me.lvwSearch1.Size = New System.Drawing.Size(434, 153)
        Me.lvwSearch1.TabIndex = 2
        Me.lvwSearch1.UseCompatibleStateImageBehavior = False
        Me.lvwSearch1.View = System.Windows.Forms.View.Details
        '
        'buylimit
        '
        Me.buylimit.AutoSize = True
        Me.buylimit.ForeColor = System.Drawing.Color.DarkRed
        Me.buylimit.Location = New System.Drawing.Point(55, 182)
        Me.buylimit.Name = "buylimit"
        Me.buylimit.Size = New System.Drawing.Size(10, 13)
        Me.buylimit.TabIndex = 3
        Me.buylimit.Text = "-"
        '
        'Prod_stud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 354)
        Me.Controls.Add(Me.buylimit)
        Me.Controls.Add(Me.lvwSearch1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Prod_stud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Prod_Stud"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPri As System.Windows.Forms.TextBox
    Friend WithEvents txtdt As System.Windows.Forms.TextBox
    Friend WithEvents txtPid As System.Windows.Forms.TextBox
    Friend WithEvents txtadm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lvwSearch1 As System.Windows.Forms.ListView
    Friend WithEvents buylimit As System.Windows.Forms.Label
End Class
