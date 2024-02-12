using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Delio_so
{
    public partial class window : UserControl
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public window()
        {
            InitializeComponent();


        }

        public void changeName(string name)
        {
            appname.Text = name;
        }

        public event EventHandler CloseButtonClicked;

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)

        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
