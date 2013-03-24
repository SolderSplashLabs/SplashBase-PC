<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wheelPictureBox2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.wheelPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.wheelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wheelPictureBox
        '
        Me.wheelPictureBox.Location = New System.Drawing.Point(3, 0)
        Me.wheelPictureBox.Name = "wheelPictureBox"
        Me.wheelPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.wheelPictureBox.TabIndex = 0
        Me.wheelPictureBox.TabStop = False
        '
        'wheelPictureBox2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.wheelPictureBox)
        Me.Name = "wheelPictureBox2"
        Me.Size = New System.Drawing.Size(164, 150)
        CType(Me.wheelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wheelPictureBox As System.Windows.Forms.PictureBox

End Class
