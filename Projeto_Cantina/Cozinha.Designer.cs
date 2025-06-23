namespace Projeto_Cantina
{
    partial class Cozinha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaCozinha = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaConcluidosCozinha = new System.Windows.Forms.ListBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnVoltarStatus = new System.Windows.Forms.Button();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 79);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf__12_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(860, 7);
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
            this.label1.Location = new System.Drawing.Point(363, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pedidos Cozinha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "PEDIDOS";
            // 
            // ListaCozinha
            // 
            this.ListaCozinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaCozinha.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaCozinha.FormattingEnabled = true;
            this.ListaCozinha.ItemHeight = 27;
            this.ListaCozinha.Location = new System.Drawing.Point(90, 194);
            this.ListaCozinha.Name = "ListaCozinha";
            this.ListaCozinha.Size = new System.Drawing.Size(578, 112);
            this.ListaCozinha.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "PEDIDOS CONCLUÍDOS";
            // 
            // ListaConcluidosCozinha
            // 
            this.ListaConcluidosCozinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaConcluidosCozinha.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaConcluidosCozinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaConcluidosCozinha.FormattingEnabled = true;
            this.ListaConcluidosCozinha.ItemHeight = 27;
            this.ListaConcluidosCozinha.Location = new System.Drawing.Point(90, 395);
            this.ListaConcluidosCozinha.Name = "ListaConcluidosCozinha";
            this.ListaConcluidosCozinha.Size = new System.Drawing.Size(578, 112);
            this.ListaConcluidosCozinha.TabIndex = 22;
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnConcluir.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnConcluir.Location = new System.Drawing.Point(782, 227);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(131, 66);
            this.btnConcluir.TabIndex = 23;
            this.btnConcluir.Text = "Adicionar Concluido";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnVoltarStatus
            // 
            this.btnVoltarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarStatus.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarStatus.Location = new System.Drawing.Point(782, 431);
            this.btnVoltarStatus.Name = "btnVoltarStatus";
            this.btnVoltarStatus.Size = new System.Drawing.Size(131, 66);
            this.btnVoltarStatus.TabIndex = 24;
            this.btnVoltarStatus.Text = "Voltar Status";
            this.btnVoltarStatus.UseVisualStyleBackColor = false;
            this.btnVoltarStatus.Click += new System.EventHandler(this.btnVoltarStatus_Click);
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarInicio.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarInicio.Location = new System.Drawing.Point(12, 97);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(83, 26);
            this.btnVoltarInicio.TabIndex = 25;
            this.btnVoltarInicio.Text = "Voltar";
            this.btnVoltarInicio.UseVisualStyleBackColor = false;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // Cozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 579);
            this.Controls.Add(this.btnVoltarInicio);
            this.Controls.Add(this.btnVoltarStatus);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.ListaConcluidosCozinha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaCozinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Cozinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cozinha";
            this.Load += new System.EventHandler(this.Cozinha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListaCozinha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListaConcluidosCozinha;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnVoltarStatus;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}