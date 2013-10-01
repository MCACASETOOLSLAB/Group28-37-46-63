Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        right.Checked = False
        left.Checked = True

        tr1.Visible = True
        tl1.Visible = True
        r1.Visible = True
        l1.Visible = True
    End Sub
    Private Sub left_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles left.CheckedChanged, left.CheckedChanged
        l1.Visible = True
        r1.Visible = False
        tr1.Visible = False
        tl1.Visible = True
    End Sub

    Private Sub right_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right.CheckedChanged, right.CheckedChanged
        l1.Visible = False
        r1.Visible = True
        tl1.Visible = False
        tr1.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (left.Checked) Then

            right.Enabled = False

            tunnel.Visible = False
            train_tunnel.Visible = True
            lock1.Visible = True
            unlock1.Visible = False
            l1.Visible = False
            tl1.Visible = False
            r1.Visible = True
            tr1.Visible = True
            tr1.Text = "Busy Waiting"

        ElseIf (right.Checked) Then
            left.Enabled = False
            r1.Visible = False
            tr1.Visible = False
            l1.Visible = True
            tl1.Visible = True
            tl1.Text = "Busy Waiting"
            train_tunnel.Visible = True
            tunnel.Visible = False

            lock1.Visible = True
            unlock1.Visible = False
        End If
    End Sub

    Private Sub tunnel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tunnel.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        train_tunnel.Visible = False
        tunnel.Visible = True
        lock1.Visible = False
        unlock1.Visible = True
        tl1.Visible = True
        tl1.Text = "ready"
        l1.Visible = True
        tr1.Visible = True
        tr1.Text = "ready"
        r1.Visible = True
        If (left.Checked) Then
           
            right.Enabled = True

        ElseIf (right.Checked) Then
            
            left.Enabled = True
        End If
    End Sub

   
End Class
