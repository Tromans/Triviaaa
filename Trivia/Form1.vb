Public Class Form1
    Dim correct As Integer
    Dim Score As Integer = 0
    Dim Questions As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SelectPanel.Visible = False
        Question.Text = ("Welcome to the Quiz Game.")
        Submit.Enabled = False
        WindowsLogo.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        correct = 2

        SelectPanel.Visible = True
        Question.Text = ("What is the date of the 2017 solar eclipse?")
        Submit.Enabled = True

        RadioButton1.Text = ("August 27th")
        RadioButton2.Text = ("August 21st")
        RadioButton3.Text = ("April 4th")
        RadioButton4.Text = ("Semtember 1st")

        Button2.Enabled = False

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        Submit.Enabled = False

        If RadioButton2.Checked And correct = 2 Then
            MsgBox("Correct!")
            Score = Score + 1
            Questions = Questions + 1
        ElseIf RadioButton1.Checked And correct = 1 Then
            MsgBox("Correct!")
            Score = Score + 1
            Questions = Questions + 1
        ElseIf RadioButton3.Checked And correct = 3 Then
            MsgBox("Correct!")
            Score = Score + 1
            Questions = Questions + 1
        ElseIf RadioButton4.Checked And correct = 4 Then
            MsgBox("Correct!")
            Score = Score + 1
            Questions = Questions + 1
        Else
            MsgBox("Incorrect.")
            Questions = Questions + 1
        End If

        TheScore.Text = Score
        QuestionsAns.Text = Questions



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        correct = 1


        Question.Text = ("What is the spell in Harry Potter to make thing levitate")
        Submit.Enabled = True

        RadioButton1.Text = ("Wingardium Leviosa")
        RadioButton2.Text = ("Abrakadabra")
        RadioButton3.Text = ("Oculus Reparo")
        RadioButton4.Text = ("Bombarda")

        Button3.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        correct = 2

        Question.Text = ("What one of these are not a shop in Hogsmeade Village")
        Submit.Enabled = True

        RadioButton1.Text = ("Zonkos")
        RadioButton2.Text = ("Gringotts")
        RadioButton3.Text = ("Honeydukes")
        RadioButton4.Text = ("The Three Broomsticks")

        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        correct = 4

        Question.Text = ("What is the killing curse?")
        Submit.Enabled = True

        RadioButton1.Text = ("Imperio")
        RadioButton2.Text = ("Crucio")
        RadioButton3.Text = ("Expecto Patronum")
        RadioButton4.Text = ("Avada Kedavra")

        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        correct = 3

        Question.Text = ("What one of these is not a Hogwarts house?")
        Submit.Enabled = True

        RadioButton1.Text = ("Ravenclaw")
        RadioButton2.Text = ("Slytherin")
        RadioButton3.Text = ("Thunderbird")
        RadioButton4.Text = ("Gryffindor")

        Button6.Enabled = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TheScore.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        correct = 2

        Question.Text = ("Who is the head of the Ravenclaw House")
        Submit.Enabled = True

        RadioButton1.Text = ("Professor McGonogall")
        RadioButton2.Text = ("Professor Flitwick")
        RadioButton3.Text = ("Professor Sprout")
        RadioButton4.Text = ("Professor Snape")

        Button7.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        correct = 1

        Question.Text = ("What is Harry Potter's patronus")
        Submit.Enabled = True

        RadioButton1.Text = ("A stag")
        RadioButton2.Text = ("A doe")
        RadioButton3.Text = ("An otter")
        RadioButton4.Text = ("A dog")

        Button9.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        correct = 3

        Question.Text = ("Who was the Defence Against the Dark arts teacher in year 6")
        Submit.Enabled = True

        RadioButton1.Text = ("Professor Quirrel")
        RadioButton2.Text = ("Professor Carrow")
        RadioButton3.Text = ("Professor Snape")
        RadioButton4.Text = ("Professor Lupin")

        Button10.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        correct = 4

        Question.Text = ("What one of these people are in the Fellowship of the Ring")
        Submit.Enabled = True

        RadioButton1.Text = ("Thorin Oakinshield")
        RadioButton2.Text = ("Elrond")
        RadioButton3.Text = ("Bilbo Baggins")
        RadioButton4.Text = ("Frodo Baggins")

        Button8.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        correct = 1

        Question.Text = ("Who is the evil lord in the Lord of the Rings?")
        Submit.Enabled = True

        RadioButton1.Text = ("Sauron")
        RadioButton2.Text = ("Voldemort")
        RadioButton3.Text = ("Darth Vader")
        RadioButton4.Text = ("Elijah Wood")

        Button1.Enabled = False
    End Sub

    Private Sub Question_Click(sender As Object, e As EventArgs) Handles Question.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
