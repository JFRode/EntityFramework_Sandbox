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
    public partial class FormExcluirProduto : Form
    {
        private ProdutoAplicacao appProduto;

        public FormExcluirProduto()
        {
            InitializeComponent();
            appProduto = new ProdutoAplicacao();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxIdProduto.Text);
            appProduto.excluir(id);
            this.Dispose();
        }
    }
}
