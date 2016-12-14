using EntitySandbox.application;
using EntitySandbox.context;
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
    public partial class FormNovoProduto : Form
    {
        private ProdutoAplicacao appProduto;

        public FormNovoProduto()
        {
            InitializeComponent();
            appProduto = new ProdutoAplicacao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from c in appProduto.banco.Produtos select c;

            Produto produto = new Produto()
            {
                Id = query.Count(),
                Nome = textBoxNomeProduto.Text
            };
            appProduto.salvar(produto);
            this.Dispose();
        }
    }
}
