Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace MultiPaneChart
	Partial Public Class Form1
		Inherits Form
		Private seriesName As Integer = 0
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			chartControl1.Visible = True
			Dim arraySize As Integer = 12
			Dim maxValue As Integer = 0
			Integer.TryParse(barEditItem1.EditValue.ToString(), maxValue)
			Dim workValues(arraySize - 1) As Object
			Dim monthStrings(arraySize - 1) As String
			Dim generator As New Random()
			For i As Integer = 0 To arraySize - 1
				workValues(i) = generator.NextDouble() * maxValue
				monthStrings(i) = DateTime.Now.AddMonths(-i).ToString("yyyy-MM")
			Next i
			AddSeriesPaneToChart(String.Format("Series:{0}", seriesName), workValues, monthStrings, Color.Aqua)
			seriesName += 1
		End Sub
		Private Function GetSeries(ByVal name As String, ByVal color As Color, ByVal array() As Object, ByVal months() As String) As Series
			Dim series As New Series(name, ViewType.Spline)
			series.ArgumentScaleType = ScaleType.Qualitative
			CType(series.View, SplineSeriesView).LineMarkerOptions.Kind = MarkerKind.Circle
			CType(series.View, SplineSeriesView).LineMarkerOptions.Visible = True

			CType(series.View, SplineSeriesView).LineStyle.DashStyle = DashStyle.Solid
			CType(series.View, SplineSeriesView).Color = color

			series.Label.Visible = False


			Dim i As Integer = 0
			For Each value As Object In array
				series.Points.Add(New SeriesPoint(months(i), value))
				i += 1
			Next value
			Return series
		End Function

		Public Sub AddSeriesPaneToChart(ByVal textFormatString As String, ByVal values() As Object, ByVal labelStrings() As String, ByVal color As Color)
			Dim array() As Object = values
			Dim months() As String = labelStrings
			Dim series As Series = GetSeries(textFormatString, color, array, months)

			Dim seriesPosition As Integer = chartControl1.Series.Add(series)
			Dim view As XYDiagramSeriesViewBase = CType(series.View, XYDiagramSeriesViewBase)

			Dim diag As XYDiagram = TryCast(chartControl1.Diagram, XYDiagram)
			Dim axesPosition As Integer = diag.SecondaryAxesY.Add(New SecondaryAxisY())

			If seriesPosition > 0 Then

				Dim pane As New XYDiagramPane()
				pane.SizeMode = PaneSizeMode.UseWeight

				diag.Panes.Add(pane)
				diag.SecondaryAxesY(axesPosition).Alignment = AxisAlignment.Near
				diag.SecondaryAxesY(axesPosition).GridLines.Visible = True
				view.AxisY = diag.SecondaryAxesY(axesPosition)
				view.Pane = pane

			Else
				diag.SecondaryAxesY(seriesPosition).Visible = False
				view.AxisX.Label.Angle = 90
			End If

			diag.EnableZooming = True
			diag.EnableScrolling = True

			chartControl1.Height += 400
		End Sub
		Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
			chartControl1.Width = Me.ClientSize.Width
		End Sub
	End Class
End Namespace