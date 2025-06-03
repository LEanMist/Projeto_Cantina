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
            this.SuspendLayout();
            // 
            // btnIniciarPedido
            // 
            this.btnIniciarPedido.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPedido.Location = new System.Drawing.Point(299, 342);
            this.btnIniciarPedido.Name = "btnIniciarPedido";
            this.btnIniciarPedido.Size = new System.Drawing.Size(187, 55);
            this.btnIniciarPedido.TabIndex = 0;
            this.btnIniciarPedido.Text = "Iniciar Pedido";
            this.btnIniciarPedido.UseVisualStyleBackColor = true;
            this.btnIniciarPedido.Click += new System.EventHandler(this.btnIniciarPedido_Click);
            // 
            // btnAcessoRestrito
            // 
            this.btnAcessoRestrito.Location = new System.Drawing.Point(699, 12);
            this.btnAcessoRestrito.Name = "btnAcessoRestrito";
            this.btnAcessoRestrito.Size = new System.Drawing.Size(89, 29);
            this.btnAcessoRestrito.TabIndex = 1;
            this.btnAcessoRestrito.Text = "Acesso Restrito";
            this.btnAcessoRestrito.UseVisualStyleBackColor = true;
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcessoRestrito);
            this.Controls.Add(this.btnIniciarPedido);
            this.Name = "MenuInicial";
            this.Text = "MenuInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarPedido;
        private System.Windows.Forms.Button btnAcessoRestrito;
    }
}