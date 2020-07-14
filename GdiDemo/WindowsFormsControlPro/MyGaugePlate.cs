using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlPro
{
    public partial class MyGaugePlate : UserControl
    {
        public MyGaugePlate()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);

        }

        #region 属性设置

        private Color _pointcolor=Color.BlueViolet;

        [Category("自定义属性")]
        [Description("指针颜色")]
        public Color Pointcolor
        {
            get { return _pointcolor; }
            set { _pointcolor = value;

                this.Invalidate();
            }
        }




        private Color _circlecolor=Color.FromArgb(20,10,30);

        [Category("自定义属性")]
        [Description("外环颜色")]
        public Color Circlecolor
        {
            get { return _circlecolor; }
            set { _circlecolor = value;

                this.Invalidate();
              }
        }

        [Category("自定义属性")]
        [Description("文本圆占的比例、设置要小于1.0")]

        private float _textscale=0.8f;
        public float Textscale
        {
            get { return _textscale; }
            set {

                if (value>1.0)
                {
                    return;
                }
                _textscale=value;

                this.Invalidate();
            }
        }

        [Category("属性设置")]
        [Description("文本显示高度比例")]
        private float _textshowscale=0.85f;

        public float Textshowscale
        {
            get { return _textshowscale; }
            set {

                if (value>1.0)
                {
                    return;
                }
                _textshowscale=value;

                this.Invalidate();
            }
        }


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        #endregion

        #region 渐变色设置

        private Color GetStartLinearColor(Color EndLinearColor,float lineareScale)
        {
            return Color.FromArgb((int)(EndLinearColor.R-(EndLinearColor.R)* lineareScale), (int)(EndLinearColor.G - EndLinearColor.G * lineareScale), (int)(EndLinearColor.B - EndLinearColor.B * lineareScale));
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g =e.Graphics;



            //var pen = new Pen(Pointcolor, 5);

            var pen = new Pen(GetStartLinearColor(Pointcolor, 0.3f), 5);

            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

           

            g.DrawLine(pen, new Point(0, 0), new Point(this.Width/3, this.Height/3));

             pen = new Pen(GetStartLinearColor(Pointcolor, 0.5f), 5);

            g.DrawLine(pen, new Point(this.Width / 3, this.Height / 3), new Point(2*this.Width / 3, 2*this.Height / 3));

             pen = new Pen(GetStartLinearColor(Pointcolor, 0.8f), 5);

            g.DrawLine(pen, new Point(2 * this.Width / 3, 2 * this.Height / 3), new Point(this.Width, this.Height));


        }
    }
}
