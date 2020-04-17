Imports System.Management

Public Class REG
    Sub SHOW_DETA(CODE_)
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ONLYONE WHERE USER_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الطبيب", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ADD2_ As Integer = DT.Rows.Count - 1
            CONTXT.Text = DT.Rows(ADD2_).Item("USER_CODE")
            TextBoxUser.Text = DT.Rows(ADD2_).Item("USER_NAME")
            NOTSTXT.Text = DT.Rows(ADD2_).Item("USER_NOTS")
            TextBoxId.Text = DT.Rows(ADD2_).Item("SERIALKEY")
            TextBoxAct.Text = DT.Rows(ADD2_).Item("ACTIVEKEY")

        End If
    End Sub
    Private Sub REG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        open_connection()
        BTNEW_Click(sender, e)
    End Sub
    Function Str2Int(ByVal InStrng As Object) As String
        Dim StrLn As Integer
        Dim Cntr As Integer
        Dim NewStr As String
        Str2Int = ""
        StrLn = Len(InStrng)
        If StrLn = 0 Then Exit Function
        NewStr = ""
        For Cntr = 1 To StrLn
            Select Case Mid(InStrng, Cntr, 1)
                Case "0" To "z"
                    NewStr = NewStr & Asc(Mid(InStrng, Cntr, 1))
            End Select
        Next Cntr
        Str2Int = NewStr
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ACT1.ForeColor = Color.Red Then
            ACT1.ForeColor = Color.Black
        Else
            ACT1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SERIAL_NUMBER_G.Click
        If TextBoxId.Text = Nothing Then MsgBox("Please Past the Serial Number From Client", MsgBoxStyle.Critical, "Error ") : Exit Sub
        TextBoxAct.Text = Str2Int(TextBoxId.Text & "ESLAMEELGOHARYLOVEREEM")
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If TextBoxAct.Text = Nothing Then MsgBox("Please click the Serial Number Generation button", MsgBoxStyle.Critical, "Error Copying") : Exit Sub
        Clipboard.SetText(TextBoxAct.Text)
        TextBoxAct.Focus()
        TextBoxAct.SelectAll()
        MsgBox("Active Code Is Copied", MsgBoxStyle.Information, "Done")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        TextBoxId.Text = Clipboard.GetText
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        '""""""""""""     قيود الادخال  """""""""""""""""""""
        If TextBoxId.Text = "" Then
            MessageBox.Show("Please enter Serial Key User", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxId.Select()
            Exit Sub
        End If
        If TextBoxAct.Text = "" Then
            MessageBox.Show("Please enter Active Key User", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxAct.Select()
            Exit Sub
        End If
        If TextBoxUser.Text = "" Then
            MessageBox.Show("Please enter Clint Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxUser.Select()
            Exit Sub
        End If
        If NOTSTXT.Text = "" Then
            MessageBox.Show("Please enter Clint Nots", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NOTSTXT.Select()
            Exit Sub
        End If


        '"""""""""""""""""""""""""""""""""""""""""" كود الحفظ """""""""""""""""""""""""""""""""""""""""
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ONLYONE  ", SqlConn)
        DA.Fill(DT)

        DT.Rows.Add()
        Dim ADD_ As Integer = DT.Rows.Count - 1
        DT.Rows(ADD_).Item("USER_CODE") = CONTXT.Text
        DT.Rows(ADD_).Item("USER_NAME") = TextBoxUser.Text
        DT.Rows(ADD_).Item("USER_NOTS") = NOTSTXT.Text
        DT.Rows(ADD_).Item("SERIALKEY") = TextBoxId.Text
        DT.Rows(ADD_).Item("ACTIVEKEY") = TextBoxAct.Text
        DT.Rows(ADD_).Item("DATEADD") = Date.Today
        DT.Rows(ADD_).Item("STAT") = True
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        DT.AcceptChanges()
        MessageBox.Show("تم أضافة العميل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTNEW_Click(sender, e)


    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SEARCHFRM.ShowDialog()
    End Sub

    Private Sub BTNEW_Click(sender As Object, e As EventArgs) Handles BTNEW.Click
        CONTXT.Text = CODE_GENE("ONLYONE", "ID") + 1
        NOTSTXT.Text = ""
        TextBoxUser.Text = ""
        TextBoxId.Text = ""
        TextBoxAct.Text = ""

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click

        '""""""""""""     قيود الادخال  """""""""""""""""""""
        If TextBoxId.Text = "" Then
            MessageBox.Show("Please enter Serial Key User", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxId.Select()
            Exit Sub
        End If
        If TextBoxAct.Text = "" Then
            MessageBox.Show("Please enter Active Key User", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxAct.Select()
            Exit Sub
        End If
        If TextBoxUser.Text = "" Then
            MessageBox.Show("Please enter Clint Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxUser.Select()
            Exit Sub
        End If
        If NOTSTXT.Text = "" Then
            MessageBox.Show("Please enter Clint Nots", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NOTSTXT.Select()
            Exit Sub
        End If


        '"""""""""""""""""""""""""""""""""""""""""" كود الحفظ """""""""""""""""""""""""""""""""""""""""
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ONLYONE WHERE USER_CODE='" & CONTXT.Text & "'  ", SqlConn)
        DA.Fill(DT)

        Dim UPDATE As Integer = BindingContext(DT).Position
        DT.Rows(UPDATE).Item("USER_CODE") = CONTXT.Text
        DT.Rows(UPDATE).Item("USER_NAME") = TextBoxUser.Text
        DT.Rows(UPDATE).Item("USER_NOTS") = NOTSTXT.Text
        DT.Rows(UPDATE).Item("SERIALKEY") = TextBoxId.Text
        DT.Rows(UPDATE).Item("ACTIVEKEY") = TextBoxAct.Text
        DT.Rows(UPDATE).Item("DATEADD") = Date.Today
        DT.Rows(UPDATE).Item("STAT") = True
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم تعديل بيانات العميل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTNEW_Click(sender, e)

    End Sub
End Class