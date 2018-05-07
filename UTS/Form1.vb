Public Class Form1
    Dim con As New koneksi_db
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xTabel As DataTable = con.xFungsiQuery("SELECT * FROM tbl_master_pegawai")
        DataGridView1.DataSource = xTabel
        DataGridView1.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            TextBox1.Text = .Cells(0).Value
            TextBox3.Text = .Cells(1).Value
            TextBox2.Text = .Cells(2).Value
            TextBox4.Text = .Cells(3).Value
            TextBox5.Text = .Cells(4).Value
            If .Cells(5).Value = "1" Then
                RadioButton1.Checked = True
            ElseIf .Cells(5).Value = "0" Then
                RadioButton2.Checked = True
            End If
            ComboBox1.Text = .Cells(6).Value
            TextBox7.Text = .Cells(7).Value
            DateTimePicker1.Value = .Cells(8).Value
            TextBox6.Text = .Cells(9).Value
            If .Cells(10).Value = "1" Then
                CheckBox1.Checked = True
            ElseIf .Cells(10).Value = "0" Then
                CheckBox1.Checked = False
            End If
        End With
    End Sub
End Class
