using EntitySandbox.application;
using EntitySandbox.context;
using EntitySandbox.model;
using EntitySandbox.view;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntitySandbox
{
    public partial class Form1 : Form
    {
        private ProdutoAplicacao appProduto;

        public Form1()
        {
            InitializeComponent();
            appProduto = new ProdutoAplicacao();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            new FormNovoProduto().ShowDialog();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            listBoxProdutos.Items.Clear();

            foreach(var produtoNaLista in appProduto.listar())
            {
                listBoxProdutos.Items.Add(produtoNaLista.Id + "\t" + produtoNaLista.Nome);
            }            
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            new FormAlterarProduto().ShowDialog();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            new FormExcluirProduto().ShowDialog();
        }
    }
}
