using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Classes;

namespace Agenda.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        ClnPessoa pessoa = new ClnPessoa();

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmSplash splash = new FrmSplash();
            splash.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Util limpar = new Util();
            limpar.limparTextBoxes(this.gpbPessoa.Controls);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {try
            {
            pessoa.nome = txtNome.Text;
            pessoa.apelido = txtApelido.Text;
            pessoa.fone = mtbFone.Text;
            pessoa.celular = Convert.ToInt64(mtbCelular.Text);
            pessoa.email = txtemail.Text;
            pessoa.cod_profissional = 1;
            }catch (Exception erro)
            {
                MessageBox.Show("Digite os valores corretos nos campos" + erro);
            }
            
            MessageBox.Show (pessoa.inserir());
        }
    }
}
