Public Class Form1
    Dim level As Integer
    Dim y As Integer = 168

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists("level.dat") Then ' Read the data
            IO.File.WriteAllText("level.dat", "1")
        End If
        If Not IO.File.Exists("correct.dat") Then ' Read the data
            IO.File.WriteAllText("correct.dat", "0")
        End If
        If Not IO.File.Exists("wrong.dat") Then ' Read the data
            IO.File.WriteAllText("wrong.dat", "0")
        End If
        Relod()
    End Sub

    Public Sub Relod()
        level = IO.File.ReadAllText("level.dat")
        For i = 1 To level
            Dim Button1 As New Button
            Button1.Size = New Point(364, 53)
            Button1.Location = New Point(31, y)
            Button1.Text = "Start level " + i.ToString
            y += 53
            AddHandler Button1.Click, AddressOf Button1_Click
            Button1.Parent = Me
        Next
    End Sub
    Public Sub IncrementDone(ByVal lvl As Integer, correct As Integer, wrong As Integer)
        IO.File.WriteAllText("level.dat", lvl.ToString)
        Dim corr As Integer = IO.File.ReadAllText("correct.dat")
        Dim wron As Integer = IO.File.ReadAllText("wrong.dat")

        corr += correct
        wron += wrong

        IO.File.WriteAllText("correct.dat", corr.ToString)
        IO.File.WriteAllText("wrong.dat", wron.ToString)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim p As New QuestionForm   ' Show question thing
        p.seed = DirectCast(sender, Button).Text.Replace("Start level ", "")
        p.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim corr As Integer = CInt(IO.File.ReadAllText("correct.dat"))
        Dim wron As Integer = CInt(IO.File.ReadAllText("wrong.dat"))

        MsgBox(CInt(((wron / corr) * 100)).ToString + "% WRONG")
    End Sub
End Class