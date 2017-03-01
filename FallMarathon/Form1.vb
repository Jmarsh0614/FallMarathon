Public Class frmFallMarathon
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click


    End Sub

    Private Sub picMarathon_Click(sender As Object, e As EventArgs) Handles picMarathon.Click

    End Sub

    Private Sub lblMthnDetails_Click(sender As Object, e As EventArgs) Handles lblMthnDetails.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This closes the program when the user selects the Exit Window button using Close Procedure
        Close()

    End Sub

    Private Sub btnViewMthnDtls_Click(sender As Object, e As EventArgs) Handles btnViewMthnDtls.Click
        'This button will display the fall marathon details when the user clicks the button
        'and then will disable the button and leave the details on the screen
        lblMthnDetails.Visible = True
        btnViewMthnDtls.Enabled = False
        btnExit.Visible = True


    End Sub
End Class
