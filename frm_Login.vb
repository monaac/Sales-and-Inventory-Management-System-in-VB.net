Public Class frm_Login

    
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        login(UsernameTextBox.Text, PasswordTextBox.Text)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main.Show()
        main.Focus()

        main.Enabled = False
        Timer1.Start()
    End Sub 

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click

    End Sub
End Class
