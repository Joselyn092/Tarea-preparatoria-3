Public Class Form1
    Private Sub CálcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálcularToolStripMenuItem.Click
        If Index < 6 Then
            Numeroplaca(Index) = Txtplaca.Text
            Tipoauto(Index) = Cbxtipo.SelectedItem
            kilometrajeinicial(Index) = Txtkminicial.Text
            kilometrajefinal(Index) = Txtkmfinal.Text

            If Cbxtipo.SelectedItem = "Tipo 1" Then
                Cobrobase(Index) = base1
            ElseIf Cbxtipo.SelectedItem = "Tipo 2" Then
                Cobrobase(Index) = base2
            ElseIf Cbxtipo.SelectedItem = "Tipo 3" Then
                Cobrobase(Index) = base3
            ElseIf Cbxtipo.SelectedItem = "Tipo 4" Then
                Cobrobase(Index) = base4
            End If

            Pagofinal(Index) = Cobrobase(Index)

        End If


            DataGridView1.Rows.Add(Numeroplaca(Index), Tipoauto(Index), Cobrobase(Index), kilometrajeinicial(Index), kilometrajefinal(Index), Pagofinal(Index))

        Index = 0 + 1

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        DataGridView1.Rows.Add(Numeroplaca(Index), Tipoauto(Index), Cobrobase(Index), kilometrajeinicial(Index), kilometrajefinal(Index), Pagofinal(Index))

        Index = 0 + 1
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        Index = 0
        While (Index <= 6) And Not (existe)
            If (Numeroplaca(Index) = Val(Txtconsulta.Text)) Then
                existe = True
            Else
                Index = Index + 1

            End If
        End While
        If (existe) Then
            MsgBox("Registro Econtrado Exitosamente")
            Txtplaca.Text = Numeroplaca(Index)
            Txtkminicial.Text = kilometrajeinicial(Index)
            Txtkmfinal.Text = kilometrajefinal(Index)
            Cbxtipo.SelectedItem = Tipoauto(Index)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Numeroplaca(Index), Tipoauto(Index), Cobrobase(Index), kilometrajeinicial(Index), kilometrajefinal(Index), Pagofinal(Index))

        Else
            MsgBox("Número de placa no  encontrado")
            Txtconsulta.Focus()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

        Tipoauto(Index) = Cbxtipo.SelectedItem
        kilometrajeinicial(Index) = Txtkminicial.Text
        kilometrajefinal(Index) = Txtkmfinal.Text

        If Cbxtipo.SelectedItem = "Tipo 1" Then
            Cobrobase(Index) = base1
        ElseIf Cbxtipo.SelectedItem = "Tipo 2" Then
            Cobrobase(Index) = base2
        ElseIf Cbxtipo.SelectedItem = "Tipo 3" Then
            Cobrobase(Index) = base3
        ElseIf Cbxtipo.SelectedItem = "Tipo 4" Then
            Cobrobase(Index) = base4
        End If

        Pagofinal(Index) = Cobrobase(Index)

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Tipoauto(Index) = Nothing
        Numeroplaca(Index) = Nothing
        Cobrobase(Index) = Nothing
        kilometrajeinicial(Index) = Nothing
        kilometrajefinal(Index) = Nothing
        Pagofinal(Index) = Nothing
        For Index = Index To 3
            Tipoauto(Index) = Tipoauto(Index + 1)
            Numeroplaca(Index) = Numeroplaca(Index + 1)
            Cobrobase(Index) = Cobrobase(Index + 1)
            kilometrajeinicial(Index) = kilometrajeinicial(Index + 1)
            kilometrajefinal(Index) = kilometrajefinal(Index + 1)
            Pagofinal(Index) = Pagofinal(Index + 1)
        Next
        MsgBox("Registro eliminado exitosamente")

        Tipoauto(Index) = Nothing
        Numeroplaca(Index) = Nothing
        Cobrobase(Index) = Nothing
        kilometrajeinicial(Index) = Nothing
        kilometrajefinal(Index) = Nothing
        Pagofinal(Index) = Nothing
        DataGridView1.Rows.Clear()
    End Sub
End Class
