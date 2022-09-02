Imports System.Reflection

Public Class QuestionForm
    ''' <summary>
    ''' Key = Question, Value = Answer
    ''' </summary>
    Dim qs As New Dictionary(Of String, String)
    Dim answer As String
    Dim prev As Integer = -1
    Dim random As Random
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
        If seed < 2 Then
            qs.Add("""Hello"" in Nopiosee is ""henlo"", correct (Yes/No)?", "yes")
            qs.Add("""Welcome"" in Nopiosee is ""wyhere"", correct (Yes/No)?", "yes")
            qs.Add("""New"" in Nopiosee is ""nieuw"", correct (Yes/No)?", "yes")
            qs.Add("""Hi"" in Nopiosee is ""henlo"", correct (Yes/No)?", "yes")
            qs.Add("""Hello there"" in Nopiosee is ""henlo tyhre"", correct (Yes/No)?", "yes")
            qs.Add("""Cool"" in Nopiosee is ""yhas"", correct (Yes/No)?", "yes")

            qs.Add("""Hello"" in Nopiosee is ""hello"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""uw"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""uh"", correct (Yes/No)?", "no")
            qs.Add("""To"" in Nopiosee is ""y"", correct (Yes/No)?", "yes")
            qs.Add("""To"" in Nopiosee is ""ke"", correct (Yes/No)?", "no")
            qs.Add("""Later"" in Nopiosee is ""later"", correct (Yes/No)?", "yes")
        ElseIf seed < 5 Then
            qs.Add("What is hello in Nopiosee?", "henlo")
            qs.Add("Does Nopiosee use uppercase characters (Yes/No)", "no")
            qs.Add("""Remove"" in Nopiosee is ""da unis"", correct (Yes/No)?", "yes")
            qs.Add("""Remove"" in Nopiosee is ""yhas"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""u"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""y"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""un"", correct (Yes/No)?", "yes")
            qs.Add("""You"" in Nopiosee is not ""un"", correct (Yes/No)?", "no")
            qs.Add("""new"" in Nopiosee is the same as in english, correct (Yes/No)?", "no")
            qs.Add("""new"" in Nopiosee is the same as ""new"" in dutch, correct (Yes/No)?", "yes")
            qs.Add("""Cool"" in Nopiosee is ""kool"", correct (Yes/No)?", "no")
            qs.Add("""Cool"" in Nopiosee is ""kol"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""ameza"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amaz"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amazing"", correct (Yes/No)?", "yes")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amazab"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amaz"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzo"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzode"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzobe"", correct (Yes/No)?", "yes")
            qs.Add("""Cool"" in Nopiosee is ""yhas"", correct (Yes/No)?", "yes")
            qs.Add("Hate in Nopiosee is ""haates"", correct (Yes/No)?", "yes")
            qs.Add("""Hello there"" in Nopiosee is ""henlo tyhre"", correct (Yes/No)?", "yes")
            qs.Add("""ten"" (10) in Nopiosee is ""thijn"", correct (Yes/No)?", "yes")
            qs.Add("Yes in Nopiosee is ""ja"", correct (Yes/No)?", "yes")
            qs.Add("Yes in Nopiosee is ""ya"", correct (Yes/No)?", "no")
        ElseIf seed < 11 Then
            qs.Add("Translate ""you are cool"" to Nopiosee", "un yajo yhas")
            qs.Add("Translate ""cool"" to Nopiosee", "yhas")
            qs.Add("""Cool"" in Nopiosee is ""yhas"", correct (Yes/No)?", "yes")
            qs.Add("""Cool"" in Nopiosee is ""kool"", correct (Yes/No)?", "no")
            qs.Add("""Cool"" in Nopiosee is ""kol"", correct (Yes/No)?", "no")
            qs.Add("Translate ""remove"" to Nopiosee", "da unis")
            qs.Add("""Amazing"" in Nopiosee is ""ameza"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amaz"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amazing"", correct (Yes/No)?", "yes")
            qs.Add("What do you hear now?", "[AUDIO]")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yajo yhas", "yes")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yao yhass", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yaajo yhas", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "wh yajo un doon jet?", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "why yajo un done jet?", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "why yajo un doon jet?", "yes")
            qs.Add("""What"" in Nopiosee is ""asqel"", correct (Yes/No)?", "no")
            qs.Add("""What"" in Nopiosee is ""asqe"", correct (Yes/No)?", "yes")
            qs.Add("""One"" in Nopiosee is ""eun"", correct (Yes/No)?", "no")
            qs.Add("""One"" in Nopiosee is ""zao"", correct (Yes/No)?", "yes")
            qs.Add("""Two"" in Nopiosee is ""tho"", correct (Yes/No)?", "yes")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amazab"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amaz"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""qi amaz"", correct (Yes/No)?", "yes")
            qs.Add("""if"" in Nopiosee is ""whe"", correct (Yes/No)?", "no")
            qs.Add("""if"" in Nopiosee is ""wha"", correct (Yes/No)?", "yes")
            qs.Add("Translate ""love"" to Nopiosee", "corzobe")
            qs.Add("Translate ""hate"" to Nopiosee", "haates")
            qs.Add("Love in Nopiosee is ""corzo"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzode"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzobe"", correct (Yes/No)?", "yes")
            qs.Add("Hate in Nopiosee is ""haates"", correct (Yes/No)?", "yes")
            qs.Add("What do you hear?", "[AUDIO]")
            qs.Add("What did you hear?", "[AUDIO]")
            qs.Add("Translate the following sentence to Nopiosee:" + Environment.NewLine + """I love you""", "mei corzobe un")
            qs.Add("What is the english word ""I"" in Nopiosee?", "mei")
            qs.Add("""I"" in Nopiosee is ""mei"", correct (Yes/No)?", "yes")
        ElseIf seed < 20 Then
            qs.Add("Translate ""new"" to Nopiosee", "nieuw")
            ' All questions. some may be wrong, if so, change it (:
            qs.Add("What is hello in Nopiosee?", "henlo")
            qs.Add("Does Nopiosee use uppercase characters (Yes/No)", "no")
            qs.Add("Translate ""remove"" to Nopiosee", "da unis")
            qs.Add("""Remove"" in Nopiosee is ""da unis"", correct (Yes/No)?", "yes")
            qs.Add("""Remove"" in Nopiosee is ""yhas"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""u"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""y"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""un"", correct (Yes/No)?", "yes")
            qs.Add("""You"" in Nopiosee is not ""un"", correct (Yes/No)?", "no")
            qs.Add("""new"" in Nopiosee is the same as in english, correct (Yes/No)?", "no")
            qs.Add("""new"" in Nopiosee is the same as ""new"" in dutch, correct (Yes/No)?", "yes")
            qs.Add("Translate ""you are cool"" to Nopiosee", "un yajo yhas")
            qs.Add("Translate ""cool"" to Nopiosee", "yhas")
            qs.Add("""Cool"" in Nopiosee is ""yhas"", correct (Yes/No)?", "yes")
            qs.Add("""Cool"" in Nopiosee is ""kool"", correct (Yes/No)?", "no")
            qs.Add("""Cool"" in Nopiosee is ""kol"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""ameza"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amaz"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amazing"", correct (Yes/No)?", "yes")
            qs.Add("What do you hear now?", "[AUDIO]")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yajo yhas", "yes")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yao yhass", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yaajo yhas", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "wh yajo un doon jet?", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "why yajo un done jet?", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "why yajo un doon jet?", "yes")
            qs.Add("""What"" in Nopiosee is ""asqel"", correct (Yes/No)?", "no")
            qs.Add("""What"" in Nopiosee is ""asqe"", correct (Yes/No)?", "yes")
            qs.Add("""One"" in Nopiosee is ""eun"", correct (Yes/No)?", "no")
            qs.Add("""One"" in Nopiosee is ""zao"", correct (Yes/No)?", "yes")
            qs.Add("""Two"" in Nopiosee is ""tho"", correct (Yes/No)?", "yes")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amazab"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amaz"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""qi amaz"", correct (Yes/No)?", "yes")
            qs.Add("""if"" in Nopiosee is ""whe"", correct (Yes/No)?", "no")
            qs.Add("""if"" in Nopiosee is ""wha"", correct (Yes/No)?", "yes")
            qs.Add("Translate ""amazing"" to Nopiosee", "amazing")
            qs.Add("Translate ""love"" to Nopiosee", "corzobe")
            qs.Add("Translate ""hate"" to Nopiosee", "haates")
            qs.Add("Love in Nopiosee is ""corzo"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzode"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzobe"", correct (Yes/No)?", "yes")
            qs.Add("Hate in Nopiosee is ""haates"", correct (Yes/No)?", "yes")
            qs.Add("What do you hear?", "[AUDIO]")
            qs.Add("What did you hear?", "[AUDIO]")
            qs.Add("Translate the following sentence to Nopiosee:" + Environment.NewLine + """I love you""", "mei corzobe un")
            qs.Add("What is the english word ""I"" in Nopiosee?", "mei")
            qs.Add("""I"" in Nopiosee is ""mei"", correct (Yes/No)?", "yes")
            qs.Add("""I"" in Nopiosee is ""me"", correct (Yes/No)?", "no")
            qs.Add("""I"" in Nopiosee is ""may"", correct (Yes/No)?", "no")
            qs.Add("Translate the sentence" + Environment.NewLine + """mei looto haates un""" + Environment.NewLine + "to English", "i really hate you")
            qs.Add("Translate ""really"" to Nopiosee", "looto")
            qs.Add("""Really"" in Nopiosee is ""looto"", correct (Yes/No)?", "yes")
            qs.Add("""Really"" in Nopiosee is ""loo"", correct (Yes/No)?", "no")
            qs.Add("""Really"" in Nopiosee is ""ys"", correct (Yes/No)?", "no")
            qs.Add("""Apple"" in Nopiosee is ""appel"", correct (Yes/No)?", "yes")
            qs.Add("""Apple"" in Nopiosee is ""apple"", correct (Yes/No)?", "no")
            qs.Add("""To"" in Nopiosee is ""y"", correct (Yes/No)?", "yes")
            qs.Add("Translate ""How are you doing"" to Nopiosee", "toh qi doon")
            qs.Add("Yes in Nopiosee is ""ja"", correct (Yes/No)?", "yes")
            qs.Add("Yes in Nopiosee is ""ya"", correct (Yes/No)?", "no")
            qs.Add("Translate ""yes"" to Nopiosee", "ja")
            qs.Add("Does Nopiosee use the upside down question mark?", "yes")
            qs.Add("Translate ""mei am a man"" to English", "i am a man")
            qs.Add("wha un understand zae, tik la", "la")
            qs.Add("""type"" Nopiosee is ""tik"", correct (Yes/No)?", "yes")
            qs.Add("""are"" Nopiosee is ""q"", correct (Yes/No)?", "yes")
            qs.Add("""you"" Nopiosee is ""un"", correct (Yes/No)?", "yes")
            qs.Add("""are you"" Nopiosee is ""q un"", correct (Yes/No)?", "no")
            qs.Add("""are you"" Nopiosee is ""qi"", correct (Yes/No)?", "yes")
            qs.Add("""y"" is a word in Nopiosee, correct (Yes/No)?", "yes")
            qs.Add("""ye"" is a word in Nopiosee, correct (Yes/No)?", "no")
            qs.Add("""Are you sure"" in Nopiosee is ""qi yos"", correct (Yes/No)?", "yes")
            qs.Add("""lo"" is a word in Nopiosee, correct (Yes/No)?", "no")
            qs.Add("""ten"" (10) in Nopiosee is ""thijn"", correct (Yes/No)?", "yes")
        Else
            qs.Add("What is hello in Nopiosee?", "henlo")
            qs.Add("Translate ""Are you sure"" to Nopiosee (without questionmarks)", "qi yos")
            qs.Add("""Are you sure"" in Nopiosee is ""qi yas"", correct (Yes/No)?", "no")
            qs.Add("Does Nopiosee use uppercase characters (Yes/No)", "no")
            qs.Add("Translate ""remove"" to Nopiosee", "da unis")
            qs.Add("""Remove"" in Nopiosee is ""da unis"", correct (Yes/No)?", "yes")
            qs.Add("""Remove"" in Nopiosee is ""yhas"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""u"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""y"", correct (Yes/No)?", "no")
            qs.Add("""You"" in Nopiosee is ""un"", correct (Yes/No)?", "yes")
            qs.Add("""You"" in Nopiosee is not ""un"", correct (Yes/No)?", "no")
            qs.Add("""new"" in Nopiosee is the same as in english, correct (Yes/No)?", "no")
            qs.Add("""new"" in Nopiosee is the same as ""new"" in dutch, correct (Yes/No)?", "yes")
            qs.Add("Translate ""you are cool"" to Nopiosee", "un yajo yhas")
            qs.Add("Translate ""cool"" to Nopiosee", "yhas")
            qs.Add("""Cool"" in Nopiosee is ""yhas"", correct (Yes/No)?", "yes")
            qs.Add("""Cool"" in Nopiosee is ""kool"", correct (Yes/No)?", "no")
            qs.Add("""Cool"" in Nopiosee is ""kol"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""ameza"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amaz"", correct (Yes/No)?", "no")
            qs.Add("""Amazing"" in Nopiosee is ""amazing"", correct (Yes/No)?", "yes")
            qs.Add("What do you hear now?", "[AUDIO]")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yajo yhas", "yes")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yao yhass", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "un yaajo yhas", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "wh yajo un doon jet?", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "why yajo un done jet?", "no")
            qs.Add("Is the following sentence correctly spelled?" & Environment.NewLine & "why yajo un doon jet?", "yes")
            qs.Add("""What"" in Nopiosee is ""asqel"", correct (Yes/No)?", "no")
            qs.Add("""What"" in Nopiosee is ""asqe"", correct (Yes/No)?", "yes")
            qs.Add("""One"" in Nopiosee is ""eun"", correct (Yes/No)?", "no")
            qs.Add("""One"" in Nopiosee is ""zao"", correct (Yes/No)?", "yes")
            qs.Add("""Two"" in Nopiosee is ""tho"", correct (Yes/No)?", "yes")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amazab"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""yajo un amaz"", correct (Yes/No)?", "no")
            qs.Add("""Are you crazy"" in Nopiosee is ""qi amaz"", correct (Yes/No)?", "yes")
            qs.Add("""if"" in Nopiosee is ""whe"", correct (Yes/No)?", "no")
            qs.Add("""Are you sure"" in Nopiosee is ""qi yos"", correct (Yes/No)?", "yes")
            qs.Add("""if"" in Nopiosee is ""wha"", correct (Yes/No)?", "yes")
            qs.Add("Translate ""amazing"" to Nopiosee", "amazing")
            qs.Add("Translate ""love"" to Nopiosee", "corzobe")
            qs.Add("Translate ""hate"" to Nopiosee", "haates")
            qs.Add("Love in Nopiosee is ""corzo"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzode"", correct (Yes/No)?", "no")
            qs.Add("Love in Nopiosee is ""corzobe"", correct (Yes/No)?", "yes")
            qs.Add("Hate in Nopiosee is ""haates"", correct (Yes/No)?", "yes")
            qs.Add("What do you hear?", "[AUDIO]")
            qs.Add("What did you hear?", "[AUDIO]")
            qs.Add("Translate the following sentence to Nopiosee:" + Environment.NewLine + """I love you""", "mei corzobe un")
            qs.Add("What is the english word ""I"" in Nopiosee?", "mei")
            qs.Add("""I"" in Nopiosee is ""mei"", correct (Yes/No)?", "yes")
            qs.Add("""I"" in Nopiosee is ""me"", correct (Yes/No)?", "no")
            qs.Add("""I"" in Nopiosee is ""may"", correct (Yes/No)?", "no")
            qs.Add("Translate the sentence" + Environment.NewLine + """mei looto haates un""" + Environment.NewLine + "to English", "i really hate you")
            qs.Add("Translate ""really"" to Nopiosee", "looto")
            qs.Add("""Really"" in Nopiosee is ""looto"", correct (Yes/No)?", "yes")
            qs.Add("""Really"" in Nopiosee is ""loo"", correct (Yes/No)?", "no")
            qs.Add("""Really"" in Nopiosee is ""ys"", correct (Yes/No)?", "no")
            qs.Add("""Apple"" in Nopiosee is ""appel"", correct (Yes/No)?", "yes")
            qs.Add("""Apple"" in Nopiosee is ""apple"", correct (Yes/No)?", "no")
            qs.Add("""To"" in Nopiosee is ""y"", correct (Yes/No)?", "yes")
            qs.Add("Translate ""How are you doing"" to Nopiosee", "toh qi doon")
            qs.Add("Yes in Nopiosee is ""ja"", correct (Yes/No)?", "yes")
            qs.Add("Yes in Nopiosee is ""ya"", correct (Yes/No)?", "no")
            qs.Add("Translate ""yes"" to Nopiosee", "ja")
            qs.Add("Does Nopiosee use the upside down question mark?", "yes")
            qs.Add("Translate ""mei am a man"" to English", "i am a man")
            qs.Add("wha un understand zae, tik la", "la")
            qs.Add("""type"" Nopiosee is ""tik"", correct (Yes/No)?", "yes")
            qs.Add("""are"" Nopiosee is ""q"", correct (Yes/No)?", "yes")
            qs.Add("""you"" Nopiosee is ""un"", correct (Yes/No)?", "yes")
            qs.Add("""are you"" Nopiosee is ""q un"", correct (Yes/No)?", "no")
            qs.Add("""are you"" Nopiosee is ""qi"", correct (Yes/No)?", "yes")
            qs.Add("""y"" is a word in Nopiosee, correct (Yes/No)?", "yes")
            qs.Add("""ye"" is a word in Nopiosee, correct (Yes/No)?", "no")
            qs.Add("""lo"" is a word in Nopiosee, correct (Yes/No)?", "no")
            qs.Add("""ten"" (10) in Nopiosee is ""thijn"", correct (Yes/No)?", "yes")
            qs.Add("""Hello"" in Nopiosee is ""henlo"", correct (Yes/No)?", "yes")
            qs.Add("""the"" in Nopiosee is ""da"", correct (Yes/No)?", "yes")
            qs.Add("""zero"" in Nopiosee is ""nul"", correct (Yes/No)?", "no")
        End If
        Question()
    End Sub
    Sub Question()
        Label4.Text = qDone.ToString + "/" + qCount.ToString
        Dim n As Integer = random.Next(0, qs.Count)
        If prev = n Then
            Question()
            Return
        End If
        prev = n
        Label2.Text = qs.ElementAt(n).Key
        answer = qs.ElementAt(n).Value
        If answer = "[AUDIO]" Then
            Dim rng As New Random
            Dim index = rng.Next(5)
            answer = audioNames(index)
            playSound(index)
        End If
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
