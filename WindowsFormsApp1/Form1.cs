using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            label1.Visible = true;

            Refresh();
            Thread.Sleep(3000);

            this.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Red;

            label2.Visible = true;
            button2.Visible = true;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            Application.Exit();
        }
    }
}
