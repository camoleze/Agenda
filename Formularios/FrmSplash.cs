using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Formularios
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.05;//deixar o frmsplash opaco
            if (Opacity <= 0)
            {
                //para desativar o timer
                tmrSplash.Enabled = false;
                this.Close();//fecha o frmSplash
            }

        }
    }
}
