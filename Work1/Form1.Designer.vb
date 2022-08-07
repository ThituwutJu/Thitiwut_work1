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
        Me.lbans = New System.Windows.Forms.Label()
        Me.tbbase = New System.Windows.Forms.TextBox()
        Me.tbhight = New System.Windows.Forms.TextBox()
        Me.btcal = New System.Windows.Forms.Button()
        Me.btclr = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(55, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "คำนวณหาพื้นที่สามเหลี่ยม"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ฐาน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "สูง"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbans
        '
        Me.lbans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbans.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbans.Location = New System.Drawing.Point(55, 159)
        Me.lbans.Name = "lbans"
        Me.lbans.Size = New System.Drawing.Size(182, 33)
        Me.lbans.TabIndex = 4
        Me.lbans.Text = "ขนาดของพื้นที่สามเหลี่ยม"
        Me.lbans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbbase
        '
        Me.tbbase.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbbase.Location = New System.Drawing.Point(83, 60)
        Me.tbbase.Name = "tbbase"
        Me.tbbase.Size = New System.Drawing.Size(154, 39)
        Me.tbbase.TabIndex = 5
        Me.tbbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbhight
        '
        Me.tbhight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbhight.Location = New System.Drawing.Point(83, 110)
        Me.tbhight.Name = "tbhight"
        Me.tbhight.Size = New System.Drawing.Size(154, 39)
        Me.tbhight.TabIndex = 6
        Me.tbhight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btcal
        '
        Me.btcal.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btcal.Location = New System.Drawing.Point(55, 211)
        Me.btcal.Name = "btcal"
        Me.btcal.Size = New System.Drawing.Size(84, 43)
        Me.btcal.TabIndex = 7
        Me.btcal.Text = "คำนวณ"
        Me.btcal.UseVisualStyleBackColor = True
        '
        'btclr
        '
        Me.btclr.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btclr.Location = New System.Drawing.Point(153, 211)
        Me.btclr.Name = "btclr"
        Me.btclr.Size = New System.Drawing.Size(84, 43)
        Me.btclr.TabIndex = 8
        Me.btclr.Text = "ล้าง"
        Me.btclr.UseVisualStyleBackColor = True
        '
        'btexit
        '
        Me.btexit.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btexit.Location = New System.Drawing.Point(105, 272)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(84, 43)
        Me.btexit.TabIndex = 9
        Me.btexit.Text = "ออก"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 344)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btclr)
        Me.Controls.Add(Me.btcal)
        Me.Controls.Add(Me.tbhight)
        Me.Controls.Add(Me.tbbase)
        Me.Controls.Add(Me.lbans)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculate Area of Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbans As Label
    Friend WithEvents tbbase As TextBox
    Friend WithEvents tbhight As TextBox
    Friend WithEvents btcal As Button
    Friend WithEvents btclr As Button
    Friend WithEvents btexit As Button
End Class
