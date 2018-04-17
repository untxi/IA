using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athosa.GUI
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        private void myDraw(int horizontal, int vertical, int block)
        {
            int width = 700;
            int height = 350;
            Graphics panel1;
            Pen myPen = new Pen(Brushes.Black, 1);
            Font myFont = new Font("Arial", 10);
            int verticalBlock = vertical;
            int horizontalBlock = horizontal;
            int blockWidth = block;
            float x = 0f;
            float y = 0f;
            float xSpace = ((width - myPen.Width) * 1.0f / verticalBlock);
            float ySpace = ((height - myPen.Width) * 1.0f / horizontalBlock);

            //vertical lines
            for (int i = 0; i < verticalBlock + 1; i++)
            {
                panel1.DrawLine(myPen, x, y, x, ySpace * verticalBlock);
                x += xSpace;
            }
            //horizontal lines
            for (int i = 0; i < horizontalBlock + 1; i++)
            {
                panel1.DrawLine(myPen, x, y, xSpace * horizontalBlock, y);
            }
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
