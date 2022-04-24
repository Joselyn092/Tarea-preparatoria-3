Module Module1
    Public Index = 0

    Public Numeroplaca(7) As Double
    Public Tipoauto(7) As String
    Public Cobrobase(7) As Double
    Public kilometrajeinicial(7) As Double
    Public kilometrajefinal(7) As Double
    Public Pagofinal(7) As Double

    Public Const base1 = 500
    Public Const base2 = 400
    Public Const base3 = 300
    Public Const base4 = 200

    Public placa As Double


    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()

        Index = 0
    End Sub

End Module
