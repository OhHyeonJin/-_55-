using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EATON_MONITOR_55
{
    public partial class Circle : UserControl
    {
        Color ChangeColor = Color.Yellow;

        public Circle(Color c)
        {
            InitializeComponent();
            ChangeColor = c;
        }

        public Circle()
        {
            InitializeComponent();
        }

        public void Circle_Color_Chagne(Color c)
        {
            ChangeColor = c;
            PA_Circle.Invalidate();
        }

        private void PA_Circle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(ChangeColor), new Rectangle(20, 5, 40, 40));
        }
    }
}
