using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Click += (s, e) =>
            //{
            //    MessageBox.Show("마우스 눌림");
            //};

            menuRefresh.Click += menuRefresh_Click;
            menuExit.Click += menuExit_Click;
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새로 고침 버튼 눌림");
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("마우스 눌림");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("폼이 보이기 전임");
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //string oldText = txtView.Text;

            //string newText = string.Format($"You said: {txtChat.Text}{Environment.NewLine}");
            //txtView.Text = oldText + newText;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button == MouseButtons.Right)
            {
                ContextMenu ctxMenu = new ContextMenu();

                MenuItem menuItem = new MenuItem("새로 고침");
                menuItem.Click += menuRefresh_Click;
                ctxMenu.MenuItems.Add(menuItem);

                menuItem = new MenuItem("종료");
                menuItem.Click += menuExit_Click;
                ctxMenu.MenuItems.Add(menuItem);

                ctxMenu.Show(this, e.Location);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            using (Graphics g = this.CreateGraphics())
            {
                using (Brush brush = new SolidBrush(Color.Brown))
                using (Pen bluePen = new Pen(brush))
                {
                    g.DrawArc(bluePen, 10, 10, 100, 100, 10, 90);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Brushes.Black))
            {
                e.Graphics.DrawArc(pen, 10, 10, 100, 100, 10, 90);
            }
        }
    }
}