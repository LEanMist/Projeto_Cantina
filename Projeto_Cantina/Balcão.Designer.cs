namespace Projeto_Cantina
{
    partial class Balcão
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
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnVoltarStatus = new System.Windows.Forms.Button();
            this.ListaPedidos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaConcluidos = new System.Windows.Forms.ListBox();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.ListaEmPreparo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEmPreparo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnConcluir.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnConcluir.Location = new System.Drawing.Point(815, 348);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(114, 55);
            this.btnConcluir.TabIndex = 15;
            this.btnConcluir.Text = "Adicionar Concluido";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnVoltarStatus
            // 
            this.btnVoltarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarStatus.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarStatus.Location = new System.Drawing.Point(815, 260);
            this.btnVoltarStatus.Name = "btnVoltarStatus";
            this.btnVoltarStatus.Size = new System.Drawing.Size(114, 55);
            this.btnVoltarStatus.TabIndex = 16;
            this.btnVoltarStatus.Text = "Voltar Status";
            this.btnVoltarStatus.UseVisualStyleBackColor = false;
            this.btnVoltarStatus.Click += new System.EventHandler(this.btnVoltarStatus_Click);
            // 
            // ListaPedidos
            // 
            this.ListaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaPedidos.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaPedidos.FormattingEnabled = true;
            this.ListaPedidos.ItemHeight = 27;
            this.ListaPedidos.Location = new System.Drawing.Point(101, 172);
            this.ListaPedidos.Name = "ListaPedidos";
            this.ListaPedidos.Size = new System.Drawing.Size(564, 85);
            this.ListaPedidos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "PEDIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "PEDIDOS CONCLUÍDOS";
            // 
            // ListaConcluidos
            // 
            this.ListaConcluidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaConcluidos.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaConcluidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaConcluidos.FormattingEnabled = true;
            this.ListaConcluidos.ItemHeight = 27;
            this.ListaConcluidos.Location = new System.Drawing.Point(101, 466);
            this.ListaConcluidos.Name = "ListaConcluidos";
            this.ListaConcluidos.Size = new System.Drawing.Size(564, 85);
            this.ListaConcluidos.TabIndex = 20;
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarInicio.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarInicio.Location = new System.Drawing.Point(12, 96);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(83, 26);
            this.btnVoltarInicio.TabIndex = 21;
            this.btnVoltarInicio.Text = "Voltar";
            this.btnVoltarInicio.UseVisualStyleBackColor = false;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // ListaEmPreparo
            // 
            this.ListaEmPreparo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaEmPreparo.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaEmPreparo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaEmPreparo.FormattingEnabled = true;
            this.ListaEmPreparo.ItemHeight = 27;
            this.ListaEmPreparo.Location = new System.Drawing.Point(101, 318);
            this.ListaEmPreparo.Name = "ListaEmPreparo";
            this.ListaEmPreparo.Size = new System.Drawing.Size(564, 85);
            this.ListaEmPreparo.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "PEDIDOS EM PREPARO";
            // 
            // btnEmPreparo
            // 
            this.btnEmPreparo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnEmPreparo.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmPreparo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEmPreparo.Location = new System.Drawing.Point(815, 172);
            this.btnEmPreparo.Name = "btnEmPreparo";
            this.btnEmPreparo.Size = new System.Drawing.Size(114, 55);
            this.btnEmPreparo.TabIndex = 24;
            this.btnEmPreparo.Text = "Adicionar Em Preparo\r\n";
            this.btnEmPreparo.UseVisualStyleBackColor = false;
            this.btnEmPreparo.Click += new System.EventHandler(this.btnEmPreparo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltar.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltar.Location = new System.Drawing.Point(815, 457);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 55);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar a Pendentes";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 79);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf__12_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(861, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 64);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf__5_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 64);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arimo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(353, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Balcão de Pedidos";
            // 
            // Balcão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(980, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEmPreparo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaEmPreparo);
            this.Controls.Add(this.btnVoltarInicio);
            this.Controls.Add(this.ListaConcluidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaPedidos);
            this.Controls.Add(this.btnVoltarStatus);
            this.Controls.Add(this.btnConcluir);
            this.Name = "Balcão";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balcão";
            this.Load += new System.EventHandler(this.Balcão_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnVoltarStatus;
        private System.Windows.Forms.ListBox ListaPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListaConcluidos;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.ListBox ListaEmPreparo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEmPreparo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}