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
    Dim audioNames As String() = {"corzobe", "why", "yajo", "yhas", "jet"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        random = New Random(seed)
        qCount = 10
        For x = 1 To seed
            If x Mod 5 = 0 Then ' Mod is stupid ):<
                qCount += 1
            End If
        Next
        words.Add("wyhere", "welcome")
        words.Add("y", "to")
        words.Add("henlo", "hello")
        Question()
    End Sub
    Sub Question()
        Dim questionText As String = ""
        Dim questionNumber = random2.Next(0, words.Count)
        Dim questionType = random2.Next(0, 1)
        Dim theWord As String = ""
        If questionType = 0 Then
            Dim questionCorrect As Integer = random2.Next(0, 2)
            If questionCorrect = 1 Then
                theWord = words.ElementAt(questionNumber).Value
                answer = "yes"
            Else
                theWord = words.ElementAt(random2.Next(0, words.Count)).Value
                While theWord = words.ElementAt(questionNumber).Value
                    theWord = words.ElementAt(random2.Next(0, words.Count)).Value
                End While
                answer = "no"
            End If
            questionText = """" & words.ElementAt(questionNumber).Key & """" & " is """ & theWord &
                """ in English, correct? (Yes/No)"

        End If
        Label4.Text = qDone.ToString + "/" + qCount.ToString
        Label2.Text = questionText
    End Sub
    Sub playSound(index As Integer)

        Select Case index

            Case 0
                My.Computer.Audio.Play(My.Resources.corzobe, AudioPlayMode.WaitToComplete)


            Case 1
                My.Computer.Audio.Play(My.Resources.why, AudioPlayMode.WaitToComplete)


            Case 2
                My.Computer.Audio.Play(My.Resources.yajo, AudioPlayMode.WaitToComplete)


            Case 3
                My.Computer.Audio.Play(My.Resources.yhas, AudioPlayMode.WaitToComplete)

            Case Else
                My.Computer.Audio.Play(My.Resources.jet, AudioPlayMode.WaitToComplete)


        End Select
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
End Class
