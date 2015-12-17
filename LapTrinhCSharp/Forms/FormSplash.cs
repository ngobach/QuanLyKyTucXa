using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhCSharp
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
            Opacity = 0;
        }
        private void FormSplash_Shown(object sender, EventArgs e)
        {

            double i = 0;
            for (; i < .9; i += 0.02)
            {
                this.Opacity = i;
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            System.Threading.Thread.Sleep(1000 * 3);
            for (; i > .3; i -= 0.02)
            {
                this.Opacity = i;
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            Hide();
            (new FormLogin()).Show();
        }
    }
}
