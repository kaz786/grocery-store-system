<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.Pro_Cur = New System.Windows.Forms.TextBox()
        Me.Pro_Lim = New System.Windows.Forms.TextBox()
        Me.Pro_Pric = New System.Windows.Forms.TextBox()
        Me.Pro_Nam = New System.Windows.Forms.TextBox()
        Me.Pro_Id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Update1 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Pro_Cur)
        Me.GroupBox1.Controls.Add(Me.Pro_Lim)
        Me.GroupBox1.Controls.Add(Me.Pro_Pric)
        Me.GroupBox1.Controls.Add(Me.Pro_Nam)
        Me.GroupBox1.Controls.Add(Me.Pro_Id)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Pro_Cur
        '
        Me.Pro_Cur.Location = New System.Drawing.Point(439, 52)
        Me.Pro_Cur.Name = "Pro_Cur"
        Me.Pro_Cur.Size = New System.Drawing.Size(89, 20)
        Me.Pro_Cur.TabIndex = 9
        '
        'Pro_Lim
        '
        Me.Pro_Lim.Location = New System.Drawing.Point(294, 52)
        Me.Pro_Lim.Name = "Pro_Lim"
        Me.Pro_Lim.Size = New System.Drawing.Size(72, 20)
        Me.Pro_Lim.TabIndex = 8
        '
        'Pro_Pric
        '
        Me.Pro_Pric.Location = New System.Drawing.Point(85, 52)
        Me.Pro_Pric.Name = "Pro_Pric"
        Me.Pro_Pric.Size = New System.Drawing.Size(108, 20)
        Me.Pro_Pric.TabIndex = 7
        '
        'Pro_Nam
        '
        Me.Pro_Nam.Location = New System.Drawing.Point(274, 16)
        Me.Pro_Nam.Name = "Pro_Nam"
        Me.Pro_Nam.Size = New System.Drawing.Size(258, 20)
        Me.Pro_Nam.TabIndex = 6
        '
        'Pro_Id
        '
        Me.Pro_Id.Enabled = False
        Me.Pro_Id.Location = New System.Drawing.Point(85, 16)
        Me.Pro_Id.Name = "Pro_Id"
        Me.Pro_Id.Size = New System.Drawing.Size(108, 20)
        Me.Pro_Id.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Limit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prod Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Controls.Add(Me.Add)
        Me.GroupBox2.Controls.Add(Me.Update1)
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.cmdSearch)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 51)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.ImageIndex = 6
        Me.cmdExit.Location = New System.Drawing.Point(462, 21)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(70, 22)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdCancel.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.ImageIndex = 4
        Me.cmdCancel.Location = New System.Drawing.Point(386, 21)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(70, 22)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Add.Location = New System.Drawing.Point(9, 19)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(70, 22)
        Me.Add.TabIndex = 12
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Update1
        '
        Me.Update1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Update1.Location = New System.Drawing.Point(85, 18)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(70, 24)
        Me.Update1.TabIndex = 14
        Me.Update1.Text = "Update"
        Me.Update1.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Delete.Location = New System.Drawing.Point(161, 21)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(70, 22)
        Me.Delete.TabIndex = 13
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.ImageIndex = 5
        Me.cmdSearch.Location = New System.Drawing.Point(311, 21)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(70, 22)
        Me.cmdSearch.TabIndex = 5
        Me.cmdSearch.Text = "&Find"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.ImageIndex = 3
        Me.cmdSave.Location = New System.Drawing.Point(236, 21)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(70, 22)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Product
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(575, 171)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "--:Product:--"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Pro_Cur As System.Windows.Forms.TextBox
    Friend WithEvents Pro_Lim As System.Windows.Forms.TextBox
    Friend WithEvents Pro_Pric As System.Windows.Forms.TextBox
    Friend WithEvents Pro_Nam As System.Windows.Forms.TextBox
    Friend WithEvents Pro_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Update1 As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
End Class
