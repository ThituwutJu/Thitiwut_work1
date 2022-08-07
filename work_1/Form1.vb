Public Class Form1
    Private Sub btcal_Click(sender As Object, e As EventArgs) Handles btcal.Click
        Dim base, height, area As Double
        If tbbase.Text = "" Then
            MsgBox("ใส่ข้อมูลความกว้างของฐาน", MsgBoxStyle.Exclamation, "ข้อผิดพลาด")
            tbbase.Focus()
        Else
            If IsNumeric(tbbase.Text) Then
                base = Val(tbbase.Text)
                If tbheight.Text = "" Then
                    MsgBox("ใส่ข้อมูลความสูง", MsgBoxStyle.Exclamation, "ข้อผิดพลาด")
                    tbheight.Focus()
                Else
                    If IsNumeric(tbheight.Text) Then
                        height = Val(tbheight.Text)
                        area = 0.5 * base * height
                        lboutput.Text = area.ToString
                    Else
                        MsgBox("ใส่ข้อมูลความสูงเป็นตัวเลขเท่านั้น", MsgBoxStyle.Exclamation, "ข้อผิดพลาด")
                        tbbase.Focus()
                    End If 'check numeric height
                End If 'check blank height
            Else
                MsgBox("ใส่ข้อมูลความกว้างของฐานเป็นตัวเลขเท่านั้น", MsgBoxStyle.Exclamation, "ข้อผิดพลาด")
                tbbase.Focus()
            End If 'check numeric base
        End If 'check blank base
    End Sub
End Class
