Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim somm As Integer
        Dim meslist As List(Of Integer)
        Dim i As Integer = 0

        Dim longueur As Integer = ListBox1.Items.Count

        'On ajoute des valeurs dans notre liste 
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()

        If ListBox1.Items.Count = 11 Then ' on prend la valeur 11 vue que le item debute à zero
            MsgBox("Les douze nombre sont entrés")

            ' Do While (i < longueur - 1)
            'Dim max = Val(ListBox1.Items(0))
            'If CInt(Val(ListBox1.Items(i))) > max Then max = CInt(Val(ListBox1.Items(i)))

            'i += 1

            'Label2.Text = ("Le gagnant du concours a vendu " & max)
            ' Loop

            '

        End If

        'On declare une variable somme qui prendre la somme du contenu de notre liste
        Dim Somme As Integer

        For Each Elem As Object In Me.ListBox1.Items

            Somme += CInt(Elem)

        Next

        Me.TextBox3.Text = Somme.ToString


    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
