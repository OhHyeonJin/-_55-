using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EATON_MONITOR_55
{
    public partial class Manu_Circle : UserControl
    {
        readonly Color ChangeColor = Color.Yellow;

        public Manu_Circle(Color c)
        {
            InitializeComponent();
            ChangeColor = c;
            PA_Circle.Invalidate();
        }

        private void PA_Circle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(ChangeColor), new Rectangle(32, 4, 40, 40));
        }
    }
}
