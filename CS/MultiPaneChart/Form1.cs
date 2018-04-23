using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace MultiPaneChart
{
    public partial class Form1 : Form
    {
        private int seriesName = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chartControl1.Visible = true;
            int arraySize = 12;
            int maxValue = 0;
            int.TryParse(barEditItem1.EditValue.ToString(), out maxValue);
            object[] workValues = new object[arraySize];
            string[] monthStrings = new string[arraySize];
            Random generator = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                workValues[i] = generator.NextDouble() * maxValue;
                monthStrings[i] = DateTime.Now.AddMonths(-i).ToString("yyyy-MM");
            }
            AddSeriesPaneToChart(string.Format("Series:{0}", seriesName), workValues, monthStrings, Color.Aqua);
            seriesName += 1;
        }
        private Series GetSeries(string name, Color color, object[] array, string[] months)
        {
            Series series = new Series(name, ViewType.Spline);
            series.ArgumentScaleType = ScaleType.Qualitative;
            ((SplineSeriesView)series.View).LineMarkerOptions.Kind = MarkerKind.Circle;
            ((SplineSeriesView)series.View).LineMarkerOptions.Visible = true;

            ((SplineSeriesView)series.View).LineStyle.DashStyle = DashStyle.Solid;
            ((SplineSeriesView)series.View).Color = color;

            series.Label.Visible = false;


            int i = 0;
            foreach (object value in array)
            {
                series.Points.Add(new SeriesPoint(months[i], value));
                i += 1;
            }
            return series;
        }

        public void AddSeriesPaneToChart(string textFormatString, object[] values, string[] labelStrings, Color color)
        {
            object[] array = values;
            string[] months = labelStrings;
            Series series = GetSeries(textFormatString, color, array, months);

            int seriesPosition = chartControl1.Series.Add(series);
            XYDiagramSeriesViewBase view = (XYDiagramSeriesViewBase)series.View;

            XYDiagram diag = chartControl1.Diagram as XYDiagram;
            int axesPosition = diag.SecondaryAxesY.Add(new SecondaryAxisY());

            if (seriesPosition > 0)
            {

                XYDiagramPane pane = new XYDiagramPane();
                pane.SizeMode = PaneSizeMode.UseWeight;

                diag.Panes.Add(pane);
                diag.SecondaryAxesY[axesPosition].Alignment = AxisAlignment.Near;
                diag.SecondaryAxesY[axesPosition].GridLines.Visible = true;
                view.AxisY = diag.SecondaryAxesY[axesPosition];
                view.Pane = pane;

            }
            else
            {
                diag.SecondaryAxesY[seriesPosition].Visible = false;
                view.AxisX.Label.Angle = 90;
            }

            diag.EnableZooming = true;
            diag.EnableScrolling = true;

            chartControl1.Height += 400;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            chartControl1.Width = this.ClientSize.Width;
        }
    }
}