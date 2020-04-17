Public Class SEARCHFRM
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM ONLYONE WHERE STAT = 'TRUE' AND  USER_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If RadioButton2.Checked = True Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM ONLYONE WHERE STAT = 'TRUE' AND  USER_CODE LIKE  '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub

    Private Sub SEARCHFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM ONLYONE WHERE STAT ='TRUE' ORDER BY ID")
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(8).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(8, DataGridView1.CurrentRow.Index).Selected = True Then
            REG.SHOW_DETA(DataGridView1.CurrentRow.Cells(3).Value)
            Me.Close()
        End If
    End Sub

    Private Sub PREVIWBTN_Click(sender As Object, e As EventArgs) Handles PREVIWBTN.Click

        Dim DT As New DataTable
            With DT
                .Columns.Add("USER_NAME")
                .Columns.Add("SERIALKEY")
                .Columns.Add("ACTIVEKEY")
                .Columns.Add("USER_CODE")
                .Columns.Add("USER_NOTS")
                .Columns.Add("DATEADD")
                .Columns.Add("STAT")
            End With
            For I As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                    DT.Rows.Add(DataGridView1.Rows(I).Cells(0).Value, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, DataGridView1.Rows(I).Cells(5).Value, DataGridView1.Rows(I).Cells(6).Value, DataGridView1.Rows(I).Cells(7).Value)
                End If
            Next
        Dim REP As New CrystalReport1
        For I0 As Integer = 0 To DataGridView1.Rows.Count - 1
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, DataGridView1.Rows(I0).Cells(3).Value)
        Next
        Dim FRM As New FRMCR
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()

    End Sub
End Class