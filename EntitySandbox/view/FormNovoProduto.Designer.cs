namespace EntitySandbox.view
{
    partial class FormNovoProduto
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
            this.buttonNovoProduto = new System.Windows.Forms.Button();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNovoProduto
            // 
            this.buttonNovoProduto.Location = new System.Drawing.Point(13, 51);
            this.buttonNovoProduto.Name = "buttonNovoProduto";
            this.buttonNovoProduto.Size = new System.Drawing.Size(259, 23);
            this.buttonNovoProduto.TabIndex = 0;
            this.buttonNovoProduto.Text = "Criar Novo Produto";
            this.buttonNovoProduto.UseVisualStyleBackColor = true;
            this.buttonNovoProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(13, 25);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(259, 20);
            this.textBoxNomeProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // FormNovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.buttonNovoProduto);
            this.Name = "FormNovoProduto";
            this.Text = "Novo Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovoProduto;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label label1;
    }
}