namespace Projeto_Cantina
{
    partial class ControleChamada
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
            this.ListaConcluidos = new System.Windows.Forms.ListBox();
            this.ListaClientesPendentes = new System.Windows.Forms.ListBox();
            this.ListaClientesConcluidos = new System.Windows.Forms.ListBox();
            this.btnPedidoConcluido = new System.Windows.Forms.Button();
            this.btnPedidoPendente = new System.Windows.Forms.Button();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaConcluidos
            // 
            this.ListaConcluidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaConcluidos.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaConcluidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaConcluidos.FormattingEnabled = true;
            this.ListaConcluidos.ItemHeight = 27;
            this.ListaConcluidos.Location = new System.Drawing.Point(301, 126);
            this.ListaConcluidos.Name = "ListaConcluidos";
            this.ListaConcluidos.Size = new System.Drawing.Size(296, 139);
            this.ListaConcluidos.TabIndex = 0;
            // 
            // ListaClientesPendentes
            // 
            this.ListaClientesPendentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaClientesPendentes.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientesPendentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaClientesPendentes.FormattingEnabled = true;
            this.ListaClientesPendentes.ItemHeight = 27;
            this.ListaClientesPendentes.Location = new System.Drawing.Point(610, 400);
            this.ListaClientesPendentes.Name = "ListaClientesPendentes";
            this.ListaClientesPendentes.Size = new System.Drawing.Size(256, 139);
            this.ListaClientesPendentes.TabIndex = 2;
            // 
            // ListaClientesConcluidos
            // 
            this.ListaClientesConcluidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.ListaClientesConcluidos.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientesConcluidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.ListaClientesConcluidos.FormattingEnabled = true;
            this.ListaClientesConcluidos.ItemHeight = 27;
            this.ListaClientesConcluidos.Location = new System.Drawing.Point(33, 400);
            this.ListaClientesConcluidos.Name = "ListaClientesConcluidos";
            this.ListaClientesConcluidos.Size = new System.Drawing.Size(256, 139);
            this.ListaClientesConcluidos.TabIndex = 3;
            // 
            // btnPedidoConcluido
            // 
            this.btnPedidoConcluido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnPedidoConcluido.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoConcluido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnPedidoConcluido.Location = new System.Drawing.Point(321, 299);
            this.btnPedidoConcluido.Name = "btnPedidoConcluido";
            this.btnPedidoConcluido.Size = new System.Drawing.Size(94, 53);
            this.btnPedidoConcluido.TabIndex = 4;
            this.btnPedidoConcluido.Text = "Pedido Concluido";
            this.btnPedidoConcluido.UseVisualStyleBackColor = false;
            this.btnPedidoConcluido.Click += new System.EventHandler(this.btnPedidoConcluido_Click);
            // 
            // btnPedidoPendente
            // 
            this.btnPedidoPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnPedidoPendente.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoPendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnPedidoPendente.Location = new System.Drawing.Point(483, 299);
            this.btnPedidoPendente.Name = "btnPedidoPendente";
            this.btnPedidoPendente.Size = new System.Drawing.Size(94, 53);
            this.btnPedidoPendente.TabIndex = 5;
            this.btnPedidoPendente.Text = "Pedido Pendente";
            this.btnPedidoPendente.UseVisualStyleBackColor = false;
            this.btnPedidoPendente.Click += new System.EventHandler(this.btnPedidoPendente_Click);
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarInicio.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarInicio.Location = new System.Drawing.Point(12, 81);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(83, 26);
            this.btnVoltarInicio.TabIndex = 23;
            this.btnVoltarInicio.Text = "Voltar";
            this.btnVoltarInicio.UseVisualStyleBackColor = false;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 64);
            this.panel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.label3.Font = new System.Drawing.Font("Arimo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Controle Chamada";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf__12_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(786, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf__5_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 45);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ControleChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(898, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltarInicio);
            this.Controls.Add(this.btnPedidoPendente);
            this.Controls.Add(this.btnPedidoConcluido);
            this.Controls.Add(this.ListaClientesConcluidos);
            this.Controls.Add(this.ListaClientesPendentes);
            this.Controls.Add(this.ListaConcluidos);
            this.Name = "ControleChamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleChamada";
            this.Load += new System.EventHandler(this.ControleChamada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaConcluidos;
        private System.Windows.Forms.ListBox ListaClientesPendentes;
        private System.Windows.Forms.ListBox ListaClientesConcluidos;
        private System.Windows.Forms.Button btnPedidoConcluido;
        private System.Windows.Forms.Button btnPedidoPendente;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}