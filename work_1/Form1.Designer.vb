<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbbase = New System.Windows.Forms.TextBox()
        Me.lboutput = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btcal = New System.Windows.Forms.Button()
        Me.btclr = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "การหาพื้นที่สามเหลี่ยม"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "กว้าง"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "สูง"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbbase
        '
        Me.tbbase.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbbase.Location = New System.Drawing.Point(158, 61)
        Me.tbbase.Multiline = True
        Me.tbbase.Name = "tbbase"
        Me.tbbase.Size = New System.Drawing.Size(217, 36)
        Me.tbbase.TabIndex = 3
        Me.tbbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lboutput
        '
        Me.lboutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lboutput.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lboutput.Location = New System.Drawing.Point(55, 162)
        Me.lboutput.Name = "lboutput"
        Me.lboutput.Size = New System.Drawing.Size(278, 51)
        Me.lboutput.TabIndex = 4
        Me.lboutput.Text = "พื้นที่สามเหลี่ยม"
        Me.lboutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(158, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 36)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btcal
        '
        Me.btcal.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btcal.Location = New System.Drawing.Point(55, 245)
        Me.btcal.Name = "btcal"
        Me.btcal.Size = New System.Drawing.Size(101, 50)
        Me.btcal.TabIndex = 6
        Me.btcal.Text = "คำนวณ"
        Me.btcal.UseVisualStyleBackColor = True
        '
        'btclr
        '
        Me.btclr.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btclr.Location = New System.Drawing.Point(232, 245)
        Me.btclr.Name = "btclr"
        Me.btclr.Size = New System.Drawing.Size(101, 50)
        Me.btclr.TabIndex = 7
        Me.btclr.Text = "ล้างค่า"
        Me.btclr.UseVisualStyleBackColor = True
        '
        'btexit
        '
        Me.btexit.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btexit.Location = New System.Drawing.Point(144, 322)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(101, 50)
        Me.btexit.TabIndex = 8
        Me.btexit.Text = "ออก"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btclr)
        Me.Controls.Add(Me.btcal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lboutput)
        Me.Controls.Add(Me.tbbase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculate Area of Tringle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbbase As TextBox
    Friend WithEvents lboutput As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btcal As Button
    Friend WithEvents btclr As Button
    Friend WithEvents btexit As Button
End Class
