Option Strict On
Option Explicit On
Imports System.Math

Public Class Form1
    'Функция ввода исходн. данных из  TextBox
    Function vvod(ByVal T As TextBox) As Double
        Return Val(T.Text)
    End Function

    'Процедура форматированного вывода результата  в TextBox
    Sub vivod(ByVal Z As Double, ByVal T As TextBox)
        T.Text = Format(Z, "00.0000")
    End Sub

    'Процедура форматированного вывода результата  в ListBox
    Sub vivodList(ByVal Z As Double, ByVal LB As ListBox)
        LB.Items.Add(Format(Z, "00.0000"))
    End Sub

    'Процедура вывода целого результата в TextBox
    Sub vivodint(ByVal Z As Integer, ByVal T As TextBox)
        T.Text = CStr(Z)
    End Sub

    'Функция вычисления значения ф-ции
    Public Function Fun(ByVal x As Double) As Double
        Return Sin(x + 2) * 12 + Cos(x * 4) * 15
    End Function
    Public Sub RegCikl(ByVal a As Double, ByVal b As Double,
                       ByVal h As Double)
        Dim i As Integer, n As Integer, y As Double
        n = CInt((b - a) / h + 1) 'число точек таблицы
        vivodint(n, TextBox4)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nn1 As Integer, nn2 As Integer
        Dim mm1 As Double, mm2 As Double
        Dim a As Double, b As Double, h As Double
        a = vvod(TextBox1)
        b = vvod(TextBox2)
        h = vvod(TextBox3)
        RegCikl(a, b, h) 'вызов проц. реш.задачи

    End Sub
End Class
