Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports System.Data

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private Const key As String = "uncheckedInLegendList"

    Private inUpdate As Boolean
    Private uncheckedSeriesIndexes As New List(Of Integer)()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub chart_LegendItemChecked(ByVal sender As Object, ByVal e As LegendItemCheckedEventArgs)
        If inUpdate Then
            Return
        End If
        Dim series As Series = TryCast(e.CheckedElement, Series)
        If series Is Nothing Then
            Return
        End If
        If e.NewCheckState = True Then
            uncheckedSeriesIndexes.Remove(chart.Series.IndexOf(series))
        Else
            uncheckedSeriesIndexes.Add(chart.Series.IndexOf(series))
        End If
        Session(key) = uncheckedSeriesIndexes
    End Sub
    Protected Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Session(key) IsNot Nothing Then
            uncheckedSeriesIndexes = DirectCast(Session(key), List(Of Integer))
        End If
        inUpdate = True

        For i As Integer = 0 To chart.Series.Count - 1
            If uncheckedSeriesIndexes.Contains(i) Then
                chart.Series(i).CheckedInLegend = False
            End If
        Next i
        inUpdate = False
    End Sub
End Class