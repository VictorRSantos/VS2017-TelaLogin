using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashForm
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (progressBar.Value < 100)
            {
                progressBar.Value = progressBar.Value + 2;
            }
            else
            {
                timer.Enabled = false;
                this.Visible = false;

                TelaLoginForm login = new TelaLoginForm();

                login.ShowDialog();

            }


        }
    }
}
