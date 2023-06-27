<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Panel1.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 477)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1070, 41)
        Panel1.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Left
        Button6.Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(870, 0)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(194, 41)
        Button6.TabIndex = 5
        Button6.Text = "Bing"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Dock = DockStyle.Left
        Button5.Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(676, 0)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(194, 41)
        Button5.TabIndex = 4
        Button5.Text = "Picasa"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Left
        Button4.Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(482, 0)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(194, 41)
        Button4.TabIndex = 3
        Button4.Text = "Yahoo"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Left
        Button3.Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(288, 0)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(194, 41)
        Button3.TabIndex = 2
        Button3.Text = "Youtube"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Left
        Button2.Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(94, 0)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(194, 41)
        Button2.TabIndex = 1
        Button2.Text = "Google"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Left
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 41)
        Button1.TabIndex = 2
        Button1.Text = "Exit all"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.BackgroundImage = My.Resources.Resources.OLEO1
        WebView21.BackgroundImageLayout = ImageLayout.Stretch
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Dock = DockStyle.Fill
        WebView21.Location = New Point(0, 0)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(1070, 477)
        WebView21.TabIndex = 1
        WebView21.ZoomFactor = 1R
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.OLEO1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1070, 518)
        Controls.Add(WebView21)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Button1 As Button
End Class
