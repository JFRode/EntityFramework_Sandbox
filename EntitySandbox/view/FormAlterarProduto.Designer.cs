namespace EntitySandbox.view
{
    partial class FormAlterarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.labelIdAlteracao = new System.Windows.Forms.Label();
            this.textBoxNovoNome = new System.Windows.Forms.TextBox();
            this.labelNovoNome = new System.Windows.Forms.Label();
            this.labelNomeAtual = new System.Windows.Forms.Label();
            this.textBoxNomeAtual = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(77, 13);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.Size = new System.Drawing.Size(89, 20);
            this.textBoxIdProduto.TabIndex = 0;
            this.textBoxIdProduto.TextChanged += new System.EventHandler(this.textBoxIdProduto_TextChanged);
            // 
            // labelIdAlteracao
            // 
            this.labelIdAlteracao.AutoSize = true;
            this.labelIdAlteracao.Location = new System.Drawing.Point(12, 16);
            this.labelIdAlteracao.Name = "labelIdAlteracao";
            this.labelIdAlteracao.Size = new System.Drawing.Size(61, 13);
            this.labelIdAlteracao.TabIndex = 1;
            this.labelIdAlteracao.Text = "ID Produto:";
            // 
            // textBoxNovoNome
            // 
            this.textBoxNovoNome.Location = new System.Drawing.Point(77, 65);
            this.textBoxNovoNome.Name = "textBoxNovoNome";
            this.textBoxNovoNome.Size = new System.Drawing.Size(89, 20);
            this.textBoxNovoNome.TabIndex = 2;
            // 
            // labelNovoNome
            // 
            this.labelNovoNome.AutoSize = true;
            this.labelNovoNome.Location = new System.Drawing.Point(10, 68);
            this.labelNovoNome.Name = "labelNovoNome";
            this.labelNovoNome.Size = new System.Drawing.Size(65, 13);
            this.labelNovoNome.TabIndex = 3;
            this.labelNovoNome.Text = "Novo nome:";
            // 
            // labelNomeAtual
            // 
            this.labelNomeAtual.AutoSize = true;
            this.labelNomeAtual.Location = new System.Drawing.Point(10, 42);
            this.labelNomeAtual.Name = "labelNomeAtual";
            this.labelNomeAtual.Size = new System.Drawing.Size(64, 13);
            this.labelNomeAtual.TabIndex = 5;
            this.labelNomeAtual.Text = "Nome atual:";
            // 
            // textBoxNomeAtual
            // 
            this.textBoxNomeAtual.Enabled = false;
            this.textBoxNomeAtual.Location = new System.Drawing.Point(77, 39);
            this.textBoxNomeAtual.Name = "textBoxNomeAtual";
            this.textBoxNomeAtual.Size = new System.Drawing.Size(89, 20);
            this.textBoxNomeAtual.TabIndex = 4;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(77, 92);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(88, 23);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // FormAlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 131);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.labelNomeAtual);
            this.Controls.Add(this.textBoxNomeAtual);
            this.Controls.Add(this.labelNovoNome);
            this.Controls.Add(this.textBoxNovoNome);
            this.Controls.Add(this.labelIdAlteracao);
            this.Controls.Add(this.textBoxIdProduto);
            this.Name = "FormAlterarProduto";
            this.Text = "FormAlterarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdProduto;
        private System.Windows.Forms.Label labelIdAlteracao;
        private System.Windows.Forms.TextBox textBoxNovoNome;
        private System.Windows.Forms.Label labelNovoNome;
        private System.Windows.Forms.Label labelNomeAtual;
        private System.Windows.Forms.TextBox textBoxNomeAtual;
        private System.Windows.Forms.Button buttonAlterar;
    }
}