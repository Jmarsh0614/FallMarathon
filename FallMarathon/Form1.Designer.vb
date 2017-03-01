<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFallMarathon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFallMarathon))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picMarathon = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeMsg = New System.Windows.Forms.Label()
        Me.btnViewMthnDtls = New System.Windows.Forms.Button()
        Me.lblMthnDetails = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(250, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(201, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Fall Marathon"
        '
        'picMarathon
        '
        Me.picMarathon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMarathon.Image = CType(resources.GetObject("picMarathon.Image"), System.Drawing.Image)
        Me.picMarathon.InitialImage = CType(resources.GetObject("picMarathon.InitialImage"), System.Drawing.Image)
        Me.picMarathon.Location = New System.Drawing.Point(78, 49)
        Me.picMarathon.Name = "picMarathon"
        Me.picMarathon.Size = New System.Drawing.Size(546, 364)
        Me.picMarathon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMarathon.TabIndex = 1
        Me.picMarathon.TabStop = False
        '
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.AutoSize = True
        Me.lblWelcomeMsg.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeMsg.Location = New System.Drawing.Point(150, 414)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New System.Drawing.Size(430, 23)
        Me.lblWelcomeMsg.TabIndex = 2
        Me.lblWelcomeMsg.Text = "Both half and full marathon runners are welcome!"
        '
        'btnViewMthnDtls
        '
        Me.btnViewMthnDtls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMthnDtls.Location = New System.Drawing.Point(208, 455)
        Me.btnViewMthnDtls.Name = "btnViewMthnDtls"
        Me.btnViewMthnDtls.Size = New System.Drawing.Size(284, 23)
        Me.btnViewMthnDtls.TabIndex = 3
        Me.btnViewMthnDtls.Text = "View marathon date, start location, and details"
        Me.btnViewMthnDtls.UseVisualStyleBackColor = True
        '
        'lblMthnDetails
        '
        Me.lblMthnDetails.AutoSize = True
        Me.lblMthnDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMthnDetails.Location = New System.Drawing.Point(205, 481)
        Me.lblMthnDetails.Name = "lblMthnDetails"
        Me.lblMthnDetails.Size = New System.Drawing.Size(418, 80)
        Me.lblMthnDetails.TabIndex = 4
        Me.lblMthnDetails.Text = " May 30, 2017" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Ryan Park" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Start Time: 8:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more information, view the" &
    " Facebook Marathon Facebook page 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMthnDetails.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 593)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'frmFallMarathon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(701, 640)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMthnDetails)
        Me.Controls.Add(Me.btnViewMthnDtls)
        Me.Controls.Add(Me.lblWelcomeMsg)
        Me.Controls.Add(Me.picMarathon)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmFallMarathon"
        Me.Text = "Fall Marathon"
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picMarathon As PictureBox
    Friend WithEvents lblWelcomeMsg As Label
    Friend WithEvents btnViewMthnDtls As Button
    Friend WithEvents lblMthnDetails As Label
    Friend WithEvents btnExit As Button
End Class
