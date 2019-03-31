using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            Sistema.FormLogin.ActiveForm.Visible = false;
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCliente telaCliente = new FormCliente();
            telaCliente.ShowDialog();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario telaFuncionario = new FormFuncionario();
            telaFuncionario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sistema.FormMenu.ActiveForm.Visible = false;
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            FormProduto telaProduto = new FormProduto();
            telaProduto.ShowDialog();
        }
    }
}
