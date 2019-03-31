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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cidade, estado, estadoCivil, vegetariano, vegano, intoleranteLactose, diabetico;

            cidade = comboCidade.Items[comboCidade.SelectedIndex].ToString();
            estado = comboEstado.Items[comboEstado.SelectedIndex].ToString();

            if (rbCasado.Checked)                   { estadoCivil = "Casado"; }
            else                                    { estadoCivil = "Solteiro"; }

            if(checkVegetariano.Checked)            { vegetariano = "Sim"; }
            else                                    { vegetariano = "Não"; }

            if (checkVegano.Checked)                { vegano = "Sim"; }
            else                                    { vegano = "Não"; }

            if (checkIntoleranteLactose.Checked)    { intoleranteLactose = "Sim"; }
            else                                    { intoleranteLactose = "Não"; }

            if (checkDiabetico.Checked)             { diabetico = "Sim"; }
            else                                    { diabetico = "Não"; }

            salvarCliente(txtNome.Text, maskTelefone.Text,maskCelular.Text, cidade, estado, estadoCivil, txtEmail.Text, vegetariano, vegano, intoleranteLactose, diabetico);
            limparCliente();
        }

        private void salvarCliente(string nome, string telefone, string celular, string cidade, string estado, string estadoCivil, string email, string vegetariano, string vegano, string intoleranteLactose, string diabetico)
        {
            StreamWriter arquivo;
            string caminho = "C:\\Users\\C-3PO\\Desktop\\eu\\clientes.txt";
            arquivo = File.AppendText(caminho);

            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Cliente");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Celular: " + celular);
            arquivo.WriteLine("Cidade: " + cidade + ", " + estado);
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Vegetariano? " + vegetariano);
            arquivo.WriteLine("Vegano? " + vegano);
            arquivo.WriteLine("Intolerante à lactose? " + intoleranteLactose);
            arquivo.WriteLine("Diabético? " + diabetico);
            arquivo.WriteLine("---------------------------------------------------------");
            arquivo.WriteLine();

            arquivo.Close();

            MessageBox.Show("Cliente salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparCliente()
        {
            txtNome.Clear();
            maskTelefone.Clear();
            maskCelular.Clear();
            comboCidade.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            txtEmail.Clear();
            rbSolteiro.Checked = false;
            rbCasado.Checked = false;
            checkVegetariano.Checked = false;
            checkVegano.Checked = false;
            checkDiabetico.Checked = false;
            checkIntoleranteLactose.Checked = false;
        }
    }

    
}
