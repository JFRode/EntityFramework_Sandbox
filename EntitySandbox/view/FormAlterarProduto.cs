using EntitySandbox.application;
using EntitySandbox.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySandbox.view
{
    public partial class FormAlterarProduto : Form
    {
        private ProdutoAplicacao appProduto;
        private int idProdutoAtual;

        public FormAlterarProduto()
        {
            InitializeComponent();
            appProduto = new ProdutoAplicacao();
        }

        private void textBoxIdProduto_TextChanged(object sender, EventArgs e)
        {
            idProdutoAtual = Int32.Parse(textBoxIdProduto.Text); // verificar aqui
            textBoxNomeAtual.Text = appProduto.banco.Produtos.Where(x => x.Id == idProdutoAtual).First().ToString();
            Console.WriteLine(textBoxNomeAtual.Text);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = idProdutoAtual,
                Nome = textBoxNovoNome.Text
            };
            appProduto.alterar(produto);
            this.Close();
        }
    }
}
