Public Class Login


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.name = TextBox1.Name Then
                TextBox2.Focus()
            ElseIf sender.name = TextBox2.Name Then
                Button3.Focus()
            End If
        End If

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus, Button3.GotFocus
        sender.BackColor = Color.Green


    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox2.LostFocus, Button3.LostFocus
        sender.BackColor = Color.White

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                Dim ds As New Data.DataSet
                Dim da As New DAOCLASS

                ds = da.load_dataset("Select * from login where u_name='" & TextBox1.Text & "' and u_pass='" & TextBox2.Text & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(0).Item(3) = "admin" Then
                        'load admin page
                        Dim d As New Form1
                        Me.Hide()
                        d.Show()

                    Else
                        'load User Home Page
                        Dim d As New UserHome
                        Me.Hide()
                        d.Show()
                    End If
                Else
                    MessageBox.Show("Enter Valid User Name And Password")
                    TextBox1.Focus()
                End If
            Else
                MessageBox.Show("Enter Valid Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            End If
        Else
            MessageBox.Show("Enter Valid User Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Login_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub
End Class