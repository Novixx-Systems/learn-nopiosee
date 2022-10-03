Imports System.Reflection

Public Class QuestionForm
    ''' <summary>
    ''' Key = Question, Value = Answer
    ''' </summary>
    Dim qs As New Dictionary(Of String, String)
    Dim words As New Dictionary(Of String, String)
    Dim answer As String
    Dim prev As Integer = -1
    Dim random As Random
    Dim random2 As New Random
    Public seed As Integer = 69420
    Dim qCount = 0
    Dim wron As Integer = 0
    Dim qDone = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        random = New Random(seed)
        qCount = 10
        For x = 1 To seed
            If x Mod 5 = 0 Then ' Mod is stupid ):<
                qCount += 1
            End If
        Next
        '
        '   The words
        '
        words.Add("wyhere", "welcome")
        words.Add("y", "to")
        words.Add("henlo", "hello")
        words.Add("da unis", "remove")
        words.Add("equ", "is")
        words.Add("imusing", "with")
        words.Add("nouhva", "not")
        words.Add("nieuw", "new")
        words.Add("verwij", "all")
        words.Add("yhas", "cool")
        words.Add("makli", "easy")
        words.Add("favoritto", "favorite")
        words.Add("un", "you")
        words.Add("corzobe", "love")
        If seed > 4 Then
            words.Add("additicíon", "additional")
            words.Add("yian", "anyone")
        End If
        If seed > 5 Then
            words.Add("topbord", "keyboard")
            words.Add("corzo", "heart")
        End If
        If seed > 9 Then
            words.Add("rofin", "eight")
            words.Add("yos", "sure")
            words.Add("qi", "are you")
        End If
        If seed > 11 Then
            words.Add("¿qi yos?", "are you sure?")
            words.Add("mira", "look")
            words.Add("un q yhas", "you are cool")
            words.Add("diru", "up")
        End If
        If seed > 15 Then
            words.Add("nó", "know")
        End If
        Question()
    End Sub
    Sub Question()
        Dim questionText As String = ""
        Dim questionNumber = random2.Next(0, words.Count)
        Dim questionType
        If seed < 2 Then
            questionType = random2.Next(0, 1)
        ElseIf seed < 3 Then
            questionType = random2.Next(0, 2)
        Else
            questionType = random2.Next(0, 3)
        End If
        Dim theWord As String = ""
        If questionType = 0 Then
            Dim questionCorrect As Integer = random2.Next(0, 2)
            If questionCorrect = 1 Then
                theWord = words.ElementAt(questionNumber).Value
                answer = "yes"
            Else
                theWord = words.ElementAt(random2.Next(0, words.Count)).Value
                '
                '   We need to do a while loop because we don't want the correct
                '   answer to be incorrect
                '
                While theWord = words.ElementAt(questionNumber).Value
                    theWord = words.ElementAt(random2.Next(0, words.Count)).Value
                End While
                answer = "no"
            End If
            questionText = """" & words.ElementAt(questionNumber).Key & """" & " is """ & theWord &
                """ in English, correct? (Yes/No)"
        ElseIf questionType = 1 Then
            answer = words.ElementAt(questionNumber).Value
            questionText = "Translate """ & words.ElementAt(questionNumber).Key & """" & "  to English"
        ElseIf questionType = 2 Then
            answer = words.ElementAt(questionNumber).Key
            questionText = "Translate """ & words.ElementAt(questionNumber).Value & """" & "  to Nopiosee"
        End If
        Label4.Text = qDone.ToString + "/" + qCount.ToString
        Label2.Text = questionText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.ToLower() = answer Then
            TextBox1.Text = Nothing
            If qDone >= qCount Then
                Dim men As New Form1
                If Not seed < IO.File.ReadAllText("level.dat") Then
                    men.IncrementDone(seed + 1, qDone, wron)
                End If
                men.Show()
                Me.Close()
            End If
            qDone += 1
            Question()
        Else
            wron += 1
            TextBox1.Text = Nothing
            MsgBox("Incorrect answer!")
            Question()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = vbCr Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text += "¿"
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text += "í"
        TextBox1.Select()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text += "ó"
        TextBox1.Select()
    End Sub
End Class
