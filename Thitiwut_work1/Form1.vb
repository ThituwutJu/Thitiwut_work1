Public Class form1
    Private Sub delete(sender As Object, e As EventArgs) Handles btdelete.Click
ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
            MsgBox("ลบสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน") 
    End Sub

    Private Sub save(sender As Object, e As EventArgs) Handles btsave.Click
Dim index As Integer = ListBox1.SelectedIndex 
                ListBox1.Items.RemoveAt(index)
                ListBox1.Items.Insert(index, tbname.Text)
                tbname.Text = ""
                MsgBox("บันทึกสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
tbname.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub clearall(sender As Object, e As EventArgs) Handles btallclr.Click
ListBox1.Items.Clear() 
            MsgBox("ลบทั้งหมดสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
    End Sub

    Private Sub add(sender As Object, e As EventArgs) Handles btadd.Click
ListBox1.Items.Add(tbname.Text)
            tbname.Text = ""
            MsgBox("เพิ่มสำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
    End Sub

    Private Sub clear(sender As Object, e As EventArgs) Handles btclr.Click
 tbname.Text = ""
    End Sub

    Private Sub bt_exit(sender As Object, e As EventArgs) Handles btexit.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
