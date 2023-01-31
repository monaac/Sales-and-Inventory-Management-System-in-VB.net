Public Class main
    Dim LL, II, PP As Integer
    Dim TXT As String

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_stockmaster.Show()
        frm_stockmaster.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ftrans.Show()
        ftrans.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_stockreturn.Show()
        frm_stockreturn.Focus()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_customer.Show()
        frm_customer.Focus()
    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserToolStripMenuItem.Click
        add_user.Show()
        add_user.Focus()
    End Sub

    

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_reports.Show()
        frm_reports.Focus()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_Login.Show()
        With frm_Login
            .PasswordTextBox.Clear()
            .UsernameTextBox.Clear()
            .UsernameTextBox.Focus()
        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
       


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ftrans.Show()
        ftrans.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_stockreturn.Show()
        frm_stockreturn.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       
        frm_customer.Focus()

        frm_customer.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_suplier.Show()
        frm_suplier.Focus()
    End Sub

    Private Sub AutonumerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutonumerToolStripMenuItem.Click
        frmautonumber.Show()
        frmautonumber.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = My.Computer.Clock.LocalTime.Date.ToLongDateString
        Label3.Text = TimeOfDay
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        frm_Login.Show()


    End Sub

    Private Sub CatigoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatigoryToolStripMenuItem.Click
        frm_settings.Show()
        frm_settings.Focus()
    End Sub

    Private Sub MODELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODELToolStripMenuItem.Click
        model.Show()
        model.Focus()
    End Sub

    Private Sub StockReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReturnToolStripMenuItem.Click
        frm_stockreturn.Show()
        frm_stockreturn.Focus()
    End Sub

    Private Sub TransctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransctionToolStripMenuItem.Click
        frm_transaction.Show()
        frm_transaction.Focus()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        frm_reports.Show()
        frm_reports.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        order.Show()
        order.Focus()

    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        frm_stockmaster.Show()
        frm_stockmaster.Focus()
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesToolStripMenuItem.Click
        services.Show()
        services.Focus()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frm_cridet.Show()
        frm_cridet.Focus()

    End Sub

    Private Sub RequestItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestItemToolStripMenuItem.Click
        frm_request.Show()
        frm_request.Focus()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frm_Login.Show()
        frm_Login.Focus()



    End Sub

    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem.Click

    End Sub

    Private Sub DeleteTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteTableToolStripMenuItem.Click
        sql = " TRUNCATE `tbltransaction`"
    End Sub
End Class
