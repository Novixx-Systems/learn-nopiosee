Imports System.Reflection.Emit
Imports System.Speech


Public Class QuestionForm
    Dim words As New Dictionary(Of String, String)
    Dim chats As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, Integer))) ' Idk any better way to do this
    Dim answer As String
    Dim random2 As New Random
    Dim inChat As Boolean = False
    Dim chatAnswer As Integer = 1
    Public seed As Integer = 69420
    Public qCount = 0
    Public training As Boolean = False
    Dim wron As Integer = 0
    Dim qDone = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not training Then    ' IF NOT IN TRAINING MODE THEN
            qCount = 10
            For x = 1 To seed
                If x Mod 5 = 0 Then ' Mod is stupid ):<
                    qCount += 1
                End If
            Next
            If seed Mod 10 = 0 Then
                inChat = True
                qCount = 0
            End If
        Else
            seed = 50000
        End If
        '
        '   The chats
        '
        chats.Add("�mei am milan, dimi yar favoritto food?", New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"ya favoritto food equ an appel!", New Dictionary(Of String, Integer) From {{"mei do nouhva ic a nym.", 1}}}
        })
        chats.Add("�mei ic a lot qae cards, do un je tu?", New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"ja, mei would nouhva loo dage.", New Dictionary(Of String, Integer) From {{"ja ta mei play!", 2}}}
        })
        chats.Add("�do un loo dage?", New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"mei only loo kate.", New Dictionary(Of String, Integer) From {{"�dimi a dag?", 1}}}
        })
        chats.Add("�do un play spele?", New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"ja mei do nouhva play spele!", New Dictionary(Of String, Integer) From {{"ja mei always play spele!", 2}}}
        })
        chats.Add("ya nym equ mark, mei loo appele en qeve.", New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"�un loo appele?", New Dictionary(Of String, Integer) From {{"�why do un loo toilette?", 1}}}
        })
        '
        '   The words
        '
        words.Add("wyhere", "welcome")
        words.Add("y", "to")
        words.Add("henlo", "hello")
        words.Add("da unis", "remove")
        words.Add("equ", "is")
        words.Add("imusing", "with")
        words.Add("dag", "dog")
        words.Add("nym", "name")
        words.Add("kat", "cat")
        words.Add("nouhva", "not")
        words.Add("nieuw", "new")
        words.Add("verwij", "all")
        words.Add("yhas", "cool")
        words.Add("q", "are")
        words.Add("makli", "easy")
        words.Add("favoritto", "favorite")
        words.Add("zao", "one")
        words.Add("un", "you")
        words.Add("qu", "we")
        words.Add("appel", "apple")
        words.Add("brood", "bread")
        words.Add("zelde", "same")
        words.Add("corzobe", "love")
        If seed > 4 Then
            words.Add("additic�on", "additional")
            words.Add("yian", "anyone")
            words.Add("spel", "game")
            words.Add("greis", "gray")
            words.Add("bor", "fun")
        End If
        If seed > 5 Then
            words.Add("dimi", "what is")
            words.Add("topbord", "keyboard")
            words.Add("loo", "like")
            words.Add("corzo", "heart")
        End If
        If seed > 9 Then
            words.Add("rofin", "eight")
            words.Add("yos", "sure")
            words.Add("groel", "green")
            words.Add("ta mei play", "please")
            words.Add("spele", "games")
            words.Add("qi", "are you")
        End If
        If seed > 11 Then
            words.Add("�qi yos?", "are you sure?")
            words.Add("mira", "look")
            words.Add("boric�on", "boring")
            words.Add("un q yhas", "you are cool")
            words.Add("diru", "up")
        End If
        If seed > 15 Then
            words.Add("geel", "yellow")
            words.Add("n�", "know")
        End If
        If seed > 17 Then
            words.Add("amaz", "crazy")
            words.Add("spela", "gaming")
        End If
        If seed > 21 Then
            words.Add("komander", "command")
            words.Add("komandere", "commands")
            words.Add("komandera", "commanding")
            words.Add("computadoll", "computer")
            words.Add("computadolle", "computers")
            words.Add("computadolla", "computing")
        End If
        If seed > 23 Then
            words.Add("porpel", "purple")
            words.Add("hox", "cute")
            words.Add("tako", "task")
            words.Add("takoe", "tasks")
        End If
        If seed > 24 Then
            words.Add("hanya", "amazing")
            words.Add("qavo", "joke")
            words.Add("bro", "brother")
            words.Add("broe", "brothers")
        End If
        If seed > 27 Then
            words.Add("bot", "tree")
            words.Add("qave", "jokes")
            words.Add("qava", "joking")
            words.Add("logag", "log")
        End If
        If seed > 30 Then
            words.Add("moord", "murder")
            words.Add("moorde", "murders")
            words.Add("comit�", "commit")
        End If
        Question()
    End Sub
    Sub Question()
        Dim questionText As String = ""
        Dim questionNumber = random2.Next(0, words.Count) ' Random question
        Dim questionType
        If inChat = True Then
            Dim chatNumber = random2.Next(0, chats.Count) ' Random chat
            chatAnswer1.Text = chats.ElementAt(chatNumber).Value.Keys(0)            ' Display answer 1
            chatAnswer2.Text = chats.ElementAt(chatNumber).Value.Values(0).Keys(0)  ' Display answer 2
            chatAnswer = chats.ElementAt(chatNumber).Value.Values(0).Values(0)
            Label4.Text = qDone.ToString + "/" + qCount.ToString
            Label2.Text = chats.ElementAt(chatNumber).Key
            chatAnswer1.Show()
            chatAnswer2.Show()
            Return
        End If
        If seed < 2 Then
            questionType = random2.Next(0, 1)
        ElseIf seed < 3 Then
            questionType = random2.Next(0, 2)
        ElseIf seed < 12 Then
            questionType = random2.Next(0, 3)
        Else
            questionType = random2.Next(0, 4)
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
            questionText = """" & words.ElementAt(questionNumber).Key & """" & " in Nopiosee is """ & theWord &
                """ in English, correct? (Yes/No)"
        ElseIf questionType = 1 Then
            answer = words.ElementAt(questionNumber).Value
            questionText = "Translate """ & words.ElementAt(questionNumber).Key & """" & " to English"
        ElseIf questionType = 2 Then
            answer = words.ElementAt(questionNumber).Key
            questionText = "Translate """ & words.ElementAt(questionNumber).Value & """" & " to Nopiosee"
        ElseIf questionType = 3 Then
            questionText = "What do you hear?"
            answer = words.ElementAt(questionNumber).Key
            NopioseePronuncioaton(answer, -2)
        End If
        Label4.Text = qDone.ToString + "/" + qCount.ToString
        Label2.Text = questionText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If inChat Then
            Return
        End If
        If TextBox1.Text.ToLower() = answer Then
            TextBox1.Text = Nothing
            If qDone >= qCount Then
                Dim men As New Form1
                If Not seed < IO.File.ReadAllText("level.dat") And Not training Then
                    men.IncrementDone(seed + 1, qDone, wron)
                End If
                men.Show()
                Me.Close()
                Return
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
        TextBox1.Text += "�"
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text += "�"
        TextBox1.Select()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text += "�"
        TextBox1.Select()
    End Sub

    Private Sub chatAnswer1_Click(sender As Object, e As EventArgs) Handles chatAnswer1.Click
        If chatAnswer = 1 Then
            TextBox1.Text = Nothing
            If qDone >= qCount Then
                Dim men As New Form1
                If Not seed < IO.File.ReadAllText("level.dat") And Not training Then
                    men.IncrementDone(seed + 1, qDone, wron)
                End If
                inChat = False
                men.Show()
                Me.Close()
                Return
            End If
            qDone += 1
            Question()
        Else
            wron += 1
            TextBox1.Text = Nothing
            MsgBox("Incorrect answer!", , "Learn Nopiosee")
            Question()
        End If
    End Sub

    Private Sub chatAnswer2_Click(sender As Object, e As EventArgs) Handles chatAnswer2.Click
        If chatAnswer = 2 Then
            TextBox1.Text = Nothing
            If qDone >= qCount Then
                Dim men As New Form1
                If Not seed < IO.File.ReadAllText("level.dat") And Not training Then
                    men.IncrementDone(seed + 1, qDone, wron)
                End If
                inChat = False
                men.Show()
                Me.Close()
                Return
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

    Sub NopioseePronuncioaton(ByVal word As String, speed As Integer)
        Dim voice As New Speech.Synthesis.SpeechSynthesizer
        voice.Rate = speed
        voice.Volume = 100
        voice.SpeakSsml("<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='en-US'>" & word.Replace("ym", "aim").Replace("0", "null").Replace("oss", "oz").Replace("qe", "k").Replace("le", "lah").Replace(" bal", " bel").Replace("dahg ", " do ").Replace("t", "j").Replace("jj", "j").Replace("ja", "ya").Replace("assoc", "assok") & "</speak>") ' replace english accent with nopiosee accent
    End Sub

    Private Sub BtnPronounce_Click(sender As Object, e As EventArgs) Handles BtnPronounce.Click
        If Label2.Text.Split("""").Length < 2 Or Label2.Text.EndsWith("to Nopiosee") Then
            MsgBox("Nothing to pronounce", , "Learn Nopiosee")
            Return
        End If
        NopioseePronuncioaton(Label2.Text.Split("""")(1), 1)
    End Sub
End Class
