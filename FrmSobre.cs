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

namespace SysDiarias
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.logoSobreSysDiarias;
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Start();

        }
        private void btnSobreFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSobreFechar_MouseMove(object sender, MouseEventArgs e) {
            btnSobreFechar.BackgroundImage = Properties.Resources.icone_Fechar;
        }

        private void BtnSobreFechar_MouseLeave(object sender, EventArgs e) {
            btnSobreFechar.BackgroundImage = Properties.Resources.icone_FecharC;
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            this.BackgroundImage = Properties.Resources.logoSobre2;
            timer1.Stop();
        }
    }
}
