﻿namespace Cantina1
{
    partial class FormFormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormaPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCartao = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.label1.Font = new System.Drawing.Font("Arimo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(201, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha Forma de Pagamento";
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnDinheiro.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnDinheiro.Location = new System.Drawing.Point(70, 154);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(119, 47);
            this.btnDinheiro.TabIndex = 1;
            this.btnDinheiro.Text = "Dinheiro";
            this.btnDinheiro.UseVisualStyleBackColor = false;
            this.btnDinheiro.Click += new System.EventHandler(this.btnDinheiro_Click);
            // 
            // btnCartao
            // 
            this.btnCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnCartao.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnCartao.Location = new System.Drawing.Point(309, 142);
            this.btnCartao.Name = "btnCartao";
            this.btnCartao.Size = new System.Drawing.Size(180, 69);
            this.btnCartao.TabIndex = 2;
            this.btnCartao.Text = "Cartão (débito/crédito)";
            this.btnCartao.UseVisualStyleBackColor = false;
            this.btnCartao.Click += new System.EventHandler(this.btnCartao_Click);
            // 
            // btnPix
            // 
            this.btnPix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.btnPix.Font = new System.Drawing.Font("Arimo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnPix.Location = new System.Drawing.Point(610, 156);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(120, 45);
            this.btnPix.TabIndex = 3;
            this.btnPix.Text = "Pix";
            this.btnPix.UseVisualStyleBackColor = false;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // FormFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnCartao);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FormFormaPagamento";
            this.Text = "FormFormaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button btnCartao;
        private System.Windows.Forms.Button btnPix;
    }
}