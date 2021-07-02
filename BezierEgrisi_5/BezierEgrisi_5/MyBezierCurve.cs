using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierEgrisi_5
{
    public partial class MyBezierCurve : Control
    {
        float a;

        public float X1 { get; set; }
        public float Y1 { get; set; }
        public float X2 { get; set; }
        public float Y2 { get; set; }
        public float X3 { get; set; }
        public float Y3 { get; set; }
        public float X4 { get; set; }
        public float Y4 { get; set; }
        public int Pen_width { get; set; }

        public MyBezierCurve()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Doğruluğunu kontrol etmek için Grafik sınıfının Bezier methodunu kullandım.
        /// Kendi yazmış olduğum methoda parametreler aktardım.
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            //Pen pen = new Pen(Color.Black, 1);
            //pe.Graphics.DrawBezier(pen, 10, 20, 45, 67, 55, 36, 74, 30);
          
            MyDrawBezier(new Pen(ForeColor,Pen_width), X1,Y1,X2,Y2,X3,Y3,X4,Y4);
        }
        /// <summary>
        /// Bezier eğrisi çizdirmek için gerekli olan denklemi ifade ettim. Noktalar halinde yerlerini belirledim ve onları birleştirdim.
        /// Daha sonra hafızada yer kaplamaması için ürettiğim nesneyi sildim 
        /// </summary>
        /// <param name="pen"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <param name="x4"></param>
        /// <param name="y4"></param>
        public void MyDrawBezier(Pen pen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
        {
            float t = 0F;
            float u = 1 - t;
            Graphics g = this.CreateGraphics();
            a = 0.001f;
            float baslangıc_x1 = Convert.ToSingle(Math.Pow(u, 3) * x1 + 3 * Math.Pow(u, 2) * t * x2 + 3 * u * Math.Pow(t, 2) * x3 + Math.Pow(t, 3) * x4);
            float baslangıc_y1 = Convert.ToSingle(Math.Pow(u, 3) * y1 + 3 * Math.Pow(u, 2) * t * y2 + 3 * u * Math.Pow(t, 2) * y3 + Math.Pow(t, 3) * y4);

            for (t = 0.001F; t <= 1.0F; t += a)
            {
                u = 1 - t;

                float bx2 = Convert.ToSingle(Math.Pow(u, 3) * x1 + 3 * Math.Pow(u, 2) * t * x2 + 3 * u * Math.Pow(t, 2) * x3 + Math.Pow(t, 3) * x4);
                float by2 = Convert.ToSingle(Math.Pow(u, 3) * y1 + 3 * Math.Pow(u, 2) * t * y2 + 3 * u * Math.Pow(t, 2) * y3 + Math.Pow(t, 3) * y4);

                g.DrawLine(pen, baslangıc_x1, baslangıc_y1, bx2, by2);

                baslangıc_x1 = bx2;
                baslangıc_y1 = by2;
            }
            pen.Dispose();
        }
    }
}
