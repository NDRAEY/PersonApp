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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 15)
        Label1.TabIndex = 0
        Label1.Text = "Введите имя, фамилию и дату рождения сотрудника. "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 23)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Имя"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(225, 46)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(191, 23)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Фамилия"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(12, 85)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(191, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 23)
        Button1.TabIndex = 4
        Button1.Text = "Отобразить запись"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 185)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Класс Person"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button

End Class
