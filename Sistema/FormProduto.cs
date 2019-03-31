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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string categoria, fornecedor;
            categoria = comboCategoria.Items[comboCategoria.SelectedIndex].ToString();
            fornecedor = comboFornecedor.Items[comboFornecedor.SelectedIndex].ToString();

            cadastrarProduto(txtNome.Text, Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(txtQuantidade.Text), categoria, fornecedor, Convert.ToDouble(txtValorUnitario.Text), txtObservacao.Text);
            limparProduto();
        }

        private void cadastrarProduto(string nome, int codigo, int quantidade, string categoria, string fornecedor, double valorUnitario, string observacao)
        {
            StreamWriter arquivo;
            string caminho = "C:\\Users\\C-3PO\\Desktop\\eu\\produtos.txt";
            arquivo = File.AppendText(caminho);

            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Produto");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Código: " + codigo);
            arquivo.WriteLine("Quantidade: " + quantidade);
            arquivo.WriteLine("Categoria: " + categoria);
            arquivo.WriteLine("Fornecedor: " + fornecedor);
            arquivo.WriteLine("Valor unitário: " + valorUnitario);
            arquivo.WriteLine("Observação: " + observacao);
            arquivo.WriteLine("---------------------------------------------------------");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Produto salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void limparProduto()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtQuantidade.Clear();
            txtValorUnitario.Clear();
            txtObservacao.Clear();
            comboFornecedor.SelectedIndex = -1;
            comboCategoria.SelectedIndex = -1;
        }
    }
}
