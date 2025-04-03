Public Class Ledger_master

    Dim saveflag As Integer = 0
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
        saveflag = 0
    End Sub
    Private Sub loaddata()
        Dim d As New DAOCLASS
        Dim ds As New DataSet
        ds = d.load_dataset("select Ledger_Name,Number,CoName,CoAddress,id from Ledger_master")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'save
        Dim d As Integer
        d = MessageBox.Show("Do you want to save?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If d = 6 Then
            If TextBox1.Text <> "" Then
                If TextBox2.Text <> " " Then
                    If TextBox3.Text <> " " Then
                        If TextBox4.Text <> " " Then
                            If saveflag = 0 Then
                                'insert 
                                Dim da As New DAOCLASS
                                da.adddata("insert into Ledger_master (Ledger_Name,Number,CoName,CoAddress) values ('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')")
                                MessageBox.Show("Record Inserted")
                                '                        loaddata()
                                ToolStripButton1_Click(sender, e)
                            Else
                                'update 
                                If TextBox4.Text <> " " AndAlso IsNumeric(TextBox4.Text) Then
                                    Dim da As New DAOCLASS
                                    da.adddata("update Ledger_master Set Ledger_Name='" & TextBox1.Text & "',Number='" & TextBox2.Text & "',CoName='" & TextBox3.Text & "',CoAddress='" & TextBox4.Text & "')'")
                                    MessageBox.Show("Record Updated")
                                Else
                                    MessageBox.Show("select valid Record")
                                    ToolStripButton1_Click(sender, e)
                                End If
                            End If
                        Else
                            MessageBox.Show("Enter Valid CoAddress")
                            TextBox4.Focus()
                        End If
                    Else
                        MessageBox.Show("Enter Valid CoName")
                        TextBox3.Focus()
                    End If

                Else
                    MessageBox.Show("Enter Valid Number")
                    TextBox2.Focus()
                End If
            Else
                MessageBox.Show("Enter Valid Ledger Name")
                TextBox1.Focus()
            End If
        End If
        loaddata()
    End Sub
    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        ToolStripButton1_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ToolStripButton2_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ToolStripButton3_Click(sender, e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.name = TextBox1.Name Then
                TextBox2.Focus()
            ElseIf sender.name = TextBox2.Name Then
                TextBox3.Focus()
            ElseIf sender.name = TextBox3.Name Then
                TextBox4.Focus()
            ElseIf sender.name = TextBox4.Name Then
                ToolStripButton2_Click(sender, e)
            End If
        End If

        If sender.name = TextBox4.Name Then
            Dim d As New DAOCLASS
            e.Handled = d.AlphaNumericValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = TextBox3.Name Then
            Dim d As New DAOCLASS
            e.Handled = d.AlphaNumericValidate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = TextBox2.Name Then
            Dim d As New DAOCLASS
            Dim f As Boolean = d.numberValidate(e.KeyChar, e.KeyChar.GetHashCode)
            e.Handled = f
            If f Then
                sender.Backcolor = Color.White
            Else
                sender.Backcolor = Color.Red
            End If
        End If

        If sender.name = TextBox3.Name Then
            Dim d As New DAOCLASS
            Dim f As Boolean = d.TextValidate(e.KeyChar, e.KeyChar.GetHashCode)
            e.Handled = f
            If f Then
                sender.Backcolor = Color.White
            Else
                sender.Backcolor = Color.Red
            End If
        End If

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus, TextBox3.GotFocus, TextBox4.GotFocus, TextBox5.GotFocus
        sender.BackColor = Color.Yellow
    End Sub
    Private Sub TextBox1_lostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox2.LostFocus, TextBox3.LostFocus, TextBox4.LostFocus, TextBox5.LostFocus
        sender.BackColor = Color.White
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            TextBox5.Text = DataGridView1.Item("id", DataGridView1.CurrentCell.RowIndex).Value
            TextBox1.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            TextBox2.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            TextBox3.Text = DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value
            TextBox4.Text = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            TextBox1.Focus()
            saveflag = 1

        End If
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            If DataGridView1.RowCount > 0 Then
                Dim d As Integer = MessageBox.Show("Do You Want to Delete " & DataGridView1.Item("Ledger_Name", DataGridView1.CurrentCell.RowIndex).Value & "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If d = 6 Then
                    Dim dA As New DAOCLASS
                    dA.adddata("delete from Ledger_master where id=" & DataGridView1.Item("id", DataGridView1.CurrentCell.RowIndex).Value)
                    loaddata()
                    MessageBox.Show("deleted")
                    ToolStripButton1_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Ledger_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

End Class