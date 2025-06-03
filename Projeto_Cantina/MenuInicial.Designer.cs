namespace Projeto_Cantina
{
    partial class MenuInicial
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
            this.btnIniciarPedido = new System.Windows.Forms.Button();
            this.btnAcessoRestrito = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarPedido
            // 
            this.btnIniciarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnIniciarPedido.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnIniciarPedido.Location = new System.Drawing.Point(305, 19);
            this.btnIniciarPedido.Name = "btnIniciarPedido";
            this.btnIniciarPedido.Size = new System.Drawing.Size(187, 55);
            this.btnIniciarPedido.TabIndex = 0;
            this.btnIniciarPedido.Text = "Iniciar Pedido";
            this.btnIniciarPedido.UseVisualStyleBackColor = false;
            this.btnIniciarPedido.Click += new System.EventHandler(this.btnIniciarPedido_Click);
            // 
            // btnAcessoRestrito
            // 
            this.btnAcessoRestrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnAcessoRestrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAcessoRestrito.Location = new System.Drawing.Point(699, 12);
            this.btnAcessoRestrito.Name = "btnAcessoRestrito";
            this.btnAcessoRestrito.Size = new System.Drawing.Size(89, 29);
            this.btnAcessoRestrito.TabIndex = 1;
            this.btnAcessoRestrito.Text = "Acesso Restrito";
            this.btnAcessoRestrito.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnIniciarPedido);
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 45);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Projeto_Cantina.Properties.Resources.Bolt_2024_pdf__3_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(197, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(421, 452);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Arimo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(298, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Projeto Cantina";
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAcessoRestrito);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MenuInicial";
            this.Text = "MenuInicial";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPedido;
        private System.Windows.Forms.Button btnAcessoRestrito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}