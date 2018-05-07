Imports MySql.Data.MySqlClient
Public Class koneksi_db
    Dim comdString As String = "server=localhost;userid=root;password=;database=db_pegawai;SslMode=none"
    Dim MySqlconn As MySqlConnection
    Dim MysqlAdapter As MySqlDataAdapter
    Dim xDataset As DataSet

    Public Function cekkoneksi()
        Dim konek As Boolean = True
        Try
            MySqlconn = New MySqlConnection(comdString)
            If MySqlconn.State = ConnectionState.Closed Then
                MySqlconn.Open()
                konek = True
            End If
        Catch ex As Exception
            konek = False
            MessageBox.Show("Aplikasi Tidak Dapat Terhubung ke Server Database")
        End Try
        Return konek

    End Function

    Public Function xFungsiQuery(Qry As String) As DataTable
        Dim xTable As DataTable
        Try
            If cekkoneksi() = True Then
                MysqlAdapter = New MySqlDataAdapter(Qry, MySqlconn)
                xDataset = New DataSet
                xDataset.Clear()
                MysqlAdapter.Fill(xDataset, "tb_master_pegawai")
                xTable = xDataset.Tables("tb_master_pegawai")
            End If

        Catch ex As Exception
            MessageBox.Show("Querry tidak DIjalankan oleh DBMS")

        End Try
        Return xTable
    End Function

End Class
