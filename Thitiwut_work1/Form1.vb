Public Class form1
    Private Sub delete(sender As Object, e As EventArgs) Handles btdelete.Click
 If ListBox1.SelectedIndex() = -1 Then
            MsgBox("กรุณาเลือกรายชื่อ", MsgBoxStyle.Exclamation, "ข้อผิดพลาด") 
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
            MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน") 
        End If
End Sub

    Private Sub save(sender As Object, e As EventArgs) Handles btsave.Click
If ListBox1.SelectedIndex() = -1 Then
            MsgBox("กรุณาเลือกรายชื่อ", MsgBoxStyle.Exclamation, "ข้อผิดพลาด") 
        Else
            If tbname.Text = "" Then
                MsgBox("โปรดใส่ข้อมูล", MsgBoxStyle.Exclamation, "ข้อผิดพลาด") 
                tbname.Focus()
            Else
                Dim index As Integer = ListBox1.SelectedIndex 
                ListBox1.Items.RemoveAt(index)
                ListBox1.Items.Insert(index, tbname.Text)
                tbname.Text = ""
                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        End If
End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
If ListBox1.SelectedIndex() = -1 Then
            MsgBox("กรุณาเพิ่มรายชื่อก่อน", MsgBoxStyle.Exclamation, "ข้อผิดพลาด") 
        Else
            tbname.Text = ListBox1.SelectedItem.ToString() 
        End If
    End Sub

    Private Sub clearall(sender As Object, e As EventArgs) Handles btallclr.Click
Dim bt_exit As MsgBoxResult
        bt_exit = MsgBox("ลบทั้งหมด ?", MsgBoxStyle.YesNo, "แจ้งเตือน")
        If bt_exit = MsgBoxResult.Yes Then
            ListBox1.Items.Clear() 
            MsgBox("ลบทั้งหมดสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            bt_exit = MsgBoxResult.No
            tbname.Focus()
        End If
    End Sub

    Private Sub add(sender As Object, e As EventArgs) Handles btadd.Click
If tbname.Text = "" Then
            MsgBox("โปรดใส่ข้อมูล", MsgBoxStyle.Exclamation, "ข้อผิดพลาด") 
            tbname.Focus()
        Else
            ListBox1.Items.Add(tbname.Text) 
            tbname.Text = ""
            MsgBox("เพิ่มสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
        End If
 End Sub

    Private Sub clear(sender As Object, e As EventArgs) Handles btclr.Click
 tbname.Text = ""
    End Sub

    Private Sub bt_exit(sender As Object, e As EventArgs) Handles btexit.Click
Dim bt_exit As MsgBoxResult
        bt_exit = MsgBox("ปิดโปรแกรม ?", MsgBoxStyle.YesNo, "แจ้งเตือน")
        If bt_exit = MsgBoxResult.Yes Then
            Application.Exit() 
        Else
            bt_exit = MsgBoxResult.No
            tbname.Focus()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
