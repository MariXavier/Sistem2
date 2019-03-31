using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cidade, estado, estadoCivil, escolaridade;
            cidade = comboCidade.Items[comboCidade.SelectedIndex].ToString();
            estado = comboEstado.Items[comboEstado.SelectedIndex].ToString();

            if (rbCasado.Checked)               { estadoCivil = "Casado"; }
            else                                { estadoCivil = "Solteiro"; }

            if (rbEnsinoFundamental.Checked)    { escolaridade = "Ensino Fundamental"; }
            else if (rbEnsinoMedio.Checked)     { escolaridade = "Ensino Médio"; }
            else                                { escolaridade = "Ensino Superior";  }

            salvarFuncionario(txtNome.Text, maskTelefone.Text, maskCelular.Text, cidade, estado, estadoCivil, txtEmail.Text, escolaridade, Convert.ToDouble(txtSalario.Text));
            limparFuncionario();
        }

        private void salvarFuncionario(string nome, string telefone, string celular, string cidade, string estado, string estadoCivil, string email, string escolaridade, double salario)
        {
            StreamWriter arquivo;
            string caminho = "C:\\Users\\C-3PO\\Desktop\\eu\\funcionarios.txt";
            arquivo = File.AppendText(caminho);

            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Funcionário");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Celular: " + celular);
            arquivo.WriteLine("Cidade: " + cidade + ", " + estado);
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Escolaridade: " + escolaridade);
            arquivo.WriteLine("Salário: " + salario);
            arquivo.WriteLine("---------------------------------------------------------");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Funcionário salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void limparFuncionario()
        {
            txtNome.Clear();
            maskTelefone.Clear();
            maskCelular.Clear();
            comboCidade.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            txtEmail.Clear();
            txtSalario.Clear();
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            rbEnsinoFundamental.Checked = false;
            rbEnsinoMedio.Checked = false;
            rbEnsinoSuperior.Checked = false;
        }
    }
}
