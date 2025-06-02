namespace Projeto_Cantina
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaProdutos = new System.Windows.Forms.ListBox();
            this.ListaCarrinho = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProdutos.FormattingEnabled = true;
            this.ListaProdutos.ItemHeight = 23;
            this.ListaProdutos.Location = new System.Drawing.Point(12, 132);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.Size = new System.Drawing.Size(259, 142);
            this.ListaProdutos.TabIndex = 5;
            // 
            // ListaCarrinho
            // 
            this.ListaCarrinho.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCarrinho.FormattingEnabled = true;
            this.ListaCarrinho.ItemHeight = 23;
            this.ListaCarrinho.Location = new System.Drawing.Point(531, 132);
            this.ListaCarrinho.Name = "ListaCarrinho";
            this.ListaCarrinho.Size = new System.Drawing.Size(259, 142);
            this.ListaCarrinho.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(356, 164);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 29);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(356, 218);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(91, 29);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(328, 347);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(146, 30);
            this.Total.TabIndex = 9;
            this.Total.Text = "Total: R$ 0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 481);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ListaCarrinho);
            this.Controls.Add(this.ListaProdutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaProdutos;
        private System.Windows.Forms.ListBox ListaCarrinho;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label Total;
    }
}

