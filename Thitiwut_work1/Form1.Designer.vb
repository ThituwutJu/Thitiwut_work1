<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.btadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.btclr = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.btallclr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายชื่อนักเรียน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"1", "2"})
        Me.ListBox1.Location = New System.Drawing.Point(14, 48)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 184)
        Me.ListBox1.TabIndex = 1
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(187, 49)
        Me.tbname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbname.Name = "tbname"
        Me.tbname.PlaceholderText = "ชื่อนักเรียน"
        Me.tbname.Size = New System.Drawing.Size(202, 27)
        Me.tbname.TabIndex = 2
        '
        'btadd
        '
        Me.btadd.BackColor = System.Drawing.Color.Lime
        Me.btadd.Location = New System.Drawing.Point(135, 88)
        Me.btadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(119, 47)
        Me.btadd.TabIndex = 3
        Me.btadd.Text = "เพิ่ม"
        Me.btadd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(135, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "แก้ไขรายชื่อนักเรียน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(135, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btdelete
        '
        Me.btdelete.BackColor = System.Drawing.Color.RosyBrown
        Me.btdelete.Location = New System.Drawing.Point(271, 88)
        Me.btdelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(119, 47)
        Me.btdelete.TabIndex = 6
        Me.btdelete.Text = "ลบ"
        Me.btdelete.UseVisualStyleBackColor = False
        '
        'btsave
        '
        Me.btsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btsave.Location = New System.Drawing.Point(135, 143)
        Me.btsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(119, 47)
        Me.btsave.TabIndex = 7
        Me.btsave.Text = "บันทึก"
        Me.btsave.UseVisualStyleBackColor = False
        '
        'btclr
        '
        Me.btclr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btclr.Location = New System.Drawing.Point(271, 143)
        Me.btclr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btclr.Name = "btclr"
        Me.btclr.Size = New System.Drawing.Size(119, 47)
        Me.btclr.TabIndex = 8
        Me.btclr.Text = "ล้าง"
        Me.btclr.UseVisualStyleBackColor = False
        '
        'btexit
        '
        Me.btexit.BackColor = System.Drawing.Color.LightCoral
        Me.btexit.Location = New System.Drawing.Point(271, 197)
        Me.btexit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(119, 47)
        Me.btexit.TabIndex = 9
        Me.btexit.Text = "ออก"
        Me.btexit.UseVisualStyleBackColor = False
        '
        'btallclr
        '
        Me.btallclr.BackColor = System.Drawing.Color.Red
        Me.btallclr.Location = New System.Drawing.Point(135, 197)
        Me.btallclr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btallclr.Name = "btallclr"
        Me.btallclr.Size = New System.Drawing.Size(119, 47)
        Me.btallclr.TabIndex = 10
        Me.btallclr.Text = "ลบทั้งหมด"
        Me.btallclr.UseVisualStyleBackColor = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(403, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.btallclr)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btclr)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btadd)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "form1"
        Me.Text = "รายชื่อนักเรียน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents tbname As TextBox
    Friend WithEvents btadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btdelete As Button
    Friend WithEvents btsave As Button
    Friend WithEvents btclr As Button
    Friend WithEvents btexit As Button
    Friend WithEvents btallclr As Button
End Class
