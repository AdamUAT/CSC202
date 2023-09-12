using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "This is the new form title";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleBaseSize = new Size(5, 13);
            this.ClientSize = new Size(400, 200);
            this.MaximizeBox = false;
        }

        private void UserSingleClick(object sender, EventArgs e)
        {
            MessageBox.Show("A click was detected!", "User Clicked");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is about to exit.", "EXIT");
            Application.Exit();
        }
    }
}
