namespace Cantina1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Adicionar = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.ListaProdutos = new System.Windows.Forms.ListBox();
            this.ListaCarrinho = new System.Windows.Forms.ListBox();
            this.Total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.Adicionar.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Adicionar.Location = new System.Drawing.Point(396, 147);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(86, 32);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Remover
            // 
            this.Remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.Remover.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Remover.Location = new System.Drawing.Point(396, 214);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(86, 32);
            this.Remover.TabIndex = 1;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = false;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaProdutos.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ListaProdutos.FormattingEnabled = true;
            this.ListaProdutos.ItemHeight = 22;
            this.ListaProdutos.Location = new System.Drawing.Point(2, 2);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.Size = new System.Drawing.Size(299, 180);
            this.ListaProdutos.TabIndex = 2;
            // 
            // ListaCarrinho
            // 
            this.ListaCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaCarrinho.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ListaCarrinho.FormattingEnabled = true;
            this.ListaCarrinho.ItemHeight = 22;
            this.ListaCarrinho.Location = new System.Drawing.Point(542, 93);
            this.ListaCarrinho.Name = "ListaCarrinho";
            this.ListaCarrinho.Size = new System.Drawing.Size(299, 180);
            this.ListaCarrinho.TabIndex = 3;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.Total.Font = new System.Drawing.Font("Arimo", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.Total.Location = new System.Drawing.Point(350, 301);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(177, 34);
            this.Total.TabIndex = 4;
            this.Total.Text = "Total : R$ 0,00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListaProdutos);
            this.panel1.Location = new System.Drawing.Point(26, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 184);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(540, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 184);
            this.panel2.TabIndex = 5;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.BackgroundImage")));
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizar.Font = new System.Drawing.Font("Arimo", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnFinalizar.Location = new System.Drawing.Point(306, 420);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(276, 58);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ListaCarrinho);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.ListBox ListaProdutos;
        private System.Windows.Forms.ListBox ListaCarrinho;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

