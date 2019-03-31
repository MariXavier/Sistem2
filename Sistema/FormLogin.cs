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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private Boolean verificarLogin(string usuario, string senha)
        {
            if (usuario == "Bob" && senha == "bob123")      { return true; }
            else                                            { return false;  }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login, senha;

             login = txtUsuario.Text;
             senha = txtSenha.Text;

             if(verificarLogin(login, senha))
             {
                 FormMenu telaMenu = new FormMenu();
                 telaMenu.ShowDialog();
                //Sistema.FormLogin.ActiveForm.Visible = false;
                Sistema.FormLogin.ActiveForm.Close();
             }
             else
             {
                 MessageBox.Show("Login incorreto. Por favor, tente novamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtUsuario.Text = "";
                 txtSenha.Text = "";
             }
        }

    }
}
