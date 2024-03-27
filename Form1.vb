Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Employee = New Person

        Employee.FirstName = TextBox1.Text  'First name
        Employee.SecondName = TextBox2.Text  'Last name


        Dim DOB = DateTimePicker1.Value
        Dim Age = Employee.Age(DOB)

        MessageBox.Show($"Имя: {Employee.FirstName}{vbCrLf}Фамилия: {Employee.SecondName}{vbCrLf}Дата рождения: {DOB}{vbCrLf}{vbCrLf}Возраст: {Age}")
    End Sub
End Class
