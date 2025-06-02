namespace Projeto_Cantina
{
    partial class Forma_de_Pagamento
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
            this.Extrato = new System.Windows.Forms.ListBox();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCartao = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Extrato
            // 
            this.Extrato.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extrato.FormattingEnabled = true;
            this.Extrato.ItemHeight = 23;
            this.Extrato.Location = new System.Drawing.Point(217, 126);
            this.Extrato.Name = "Extrato";
            this.Extrato.Size = new System.Drawing.Size(367, 96);
            this.Extrato.TabIndex = 4;
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.Location = new System.Drawing.Point(72, 310);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(137, 40);
            this.btnDinheiro.TabIndex = 5;
            this.btnDinheiro.Text = "Dinheiro";
            this.btnDinheiro.UseVisualStyleBackColor = true;
            this.btnDinheiro.Click += new System.EventHandler(this.btnDinheiro_Click);
            // 
            // btnCartao
            // 
            this.btnCartao.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartao.Location = new System.Drawing.Point(332, 304);
            this.btnCartao.Name = "btnCartao";
            this.btnCartao.Size = new System.Drawing.Size(137, 52);
            this.btnCartao.TabIndex = 6;
            this.btnCartao.Text = "Cartão Debito Credito";
            this.btnCartao.UseVisualStyleBackColor = true;
            this.btnCartao.Click += new System.EventHandler(this.btnCartao_Click);
            // 
            // btnPix
            // 
            this.btnPix.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.Location = new System.Drawing.Point(590, 310);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(137, 40);
            this.btnPix.TabIndex = 7;
            this.btnPix.Text = "Pix";
            this.btnPix.UseVisualStyleBackColor = true;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // Forma_de_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnCartao);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.Extrato);
            this.Name = "Forma_de_Pagamento";
            this.Text = "Forma_de_Pagamento";
            this.Load += new System.EventHandler(this.Forma_de_Pagamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Extrato;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnCartao;
        private System.Windows.Forms.Button btnPix;
    }
}