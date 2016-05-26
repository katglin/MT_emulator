using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace mt_emulyator
{
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }

        public double f(int x)
        {
            if (x % 2 == 0) return (2.5*x+3);
            else return (2*x+2);

        }

        public void DrawGraph(int M, int [] maxIt)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Title.FontSpec.FontColor = Color.Blue;
            pane.YAxis.Title.FontSpec.FontColor = Color.Blue;
            pane.XAxis.Title.Text = "Длина слова n";
            pane.YAxis.Title.Text = "Количество тактов";
            pane.Title.Text = "График";

            pane.Title.FontSpec.Fill.Brush = new SolidBrush(Color.Red);
            pane.Title.FontSpec.Fill.IsVisible = true;
            pane.Title.FontSpec.IsBold = false;

            pane.CurveList.Clear();

            PointPairList list = new PointPairList();
            PointPairList listAn = new PointPairList();
            for (int x = 0; x < M; x++)
            {
                list.Add(x, maxIt[x]);
                listAn.Add(x, f(x));
            }
            LineItem myCurve2 = pane.AddCurve("Аналитический", listAn, Color.Red, SymbolType.None);
            LineItem myCurve1 = pane.AddCurve("Экспериментальный", list, Color.Blue, SymbolType.Star);
            myCurve1.Line.Style = System.Drawing.Drawing2D.DashStyle.DashDot;
            myCurve2.Line.IsSmooth = true;
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
    }
}
