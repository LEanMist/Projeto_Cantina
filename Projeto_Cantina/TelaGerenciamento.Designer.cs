namespace Projeto_Cantina
{
    partial class TelaGerenciamento
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Gerenciador = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnVoltarAlterações = new System.Windows.Forms.Button();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoltarPerfis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gerenciador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Gerenciador
            // 
            this.Gerenciador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gerenciador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Gerenciador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gerenciador.Location = new System.Drawing.Point(127, 48);
            this.Gerenciador.Name = "Gerenciador";
            this.Gerenciador.Size = new System.Drawing.Size(546, 220);
            this.Gerenciador.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(127, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 48);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Location = new System.Drawing.Point(538, 333);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(135, 63);
            this.btnAddProduto.TabIndex = 2;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnVoltarAlterações
            // 
            this.btnVoltarAlterações.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarAlterações.Location = new System.Drawing.Point(332, 353);
            this.btnVoltarAlterações.Name = "btnVoltarAlterações";
            this.btnVoltarAlterações.Size = new System.Drawing.Size(130, 26);
            this.btnVoltarAlterações.TabIndex = 3;
            this.btnVoltarAlterações.Text = "Voltar alterações";
            this.btnVoltarAlterações.UseVisualStyleBackColor = true;
            this.btnVoltarAlterações.Click += new System.EventHandler(this.btnVoltarAlterações_Click);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(Projeto_Cantina.Produtos);
            // 
            // btnVoltarPerfis
            // 
            this.btnVoltarPerfis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarPerfis.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarPerfis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarPerfis.Location = new System.Drawing.Point(12, 23);
            this.btnVoltarPerfis.Name = "btnVoltarPerfis";
            this.btnVoltarPerfis.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarPerfis.TabIndex = 16;
            this.btnVoltarPerfis.Text = "Voltar";
            this.btnVoltarPerfis.UseVisualStyleBackColor = false;
            this.btnVoltarPerfis.Click += new System.EventHandler(this.btnVoltarPerfis_Click);
            // 
            // TelaGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarPerfis);
            this.Controls.Add(this.btnVoltarAlterações);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.Gerenciador);
            this.Name = "TelaGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaGerenciamento";
            this.Click += new System.EventHandler(this.TelaGerenciamento_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Gerenciador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridView Gerenciador;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnVoltarAlterações;
        private System.Windows.Forms.Button btnVoltarPerfis;
    }
}