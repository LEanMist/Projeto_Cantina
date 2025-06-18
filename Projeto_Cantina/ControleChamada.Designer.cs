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
            this.SuspendLayout();
            // 
            // ListaConcluidos
            // 
            this.ListaConcluidos.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaConcluidos.FormattingEnabled = true;
            this.ListaConcluidos.ItemHeight = 27;
            this.ListaConcluidos.Location = new System.Drawing.Point(272, 42);
            this.ListaConcluidos.Name = "ListaConcluidos";
            this.ListaConcluidos.Size = new System.Drawing.Size(256, 139);
            this.ListaConcluidos.TabIndex = 0;
            // 
            // ListaClientesPendentes
            // 
            this.ListaClientesPendentes.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientesPendentes.FormattingEnabled = true;
            this.ListaClientesPendentes.ItemHeight = 27;
            this.ListaClientesPendentes.Location = new System.Drawing.Point(517, 278);
            this.ListaClientesPendentes.Name = "ListaClientesPendentes";
            this.ListaClientesPendentes.Size = new System.Drawing.Size(256, 139);
            this.ListaClientesPendentes.TabIndex = 2;
            // 
            // ListaClientesConcluidos
            // 
            this.ListaClientesConcluidos.Font = new System.Drawing.Font("Arimo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientesConcluidos.FormattingEnabled = true;
            this.ListaClientesConcluidos.ItemHeight = 27;
            this.ListaClientesConcluidos.Location = new System.Drawing.Point(29, 278);
            this.ListaClientesConcluidos.Name = "ListaClientesConcluidos";
            this.ListaClientesConcluidos.Size = new System.Drawing.Size(256, 139);
            this.ListaClientesConcluidos.TabIndex = 3;
            // 
            // btnPedidoConcluido
            // 
            this.btnPedidoConcluido.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoConcluido.Location = new System.Drawing.Point(283, 207);
            this.btnPedidoConcluido.Name = "btnPedidoConcluido";
            this.btnPedidoConcluido.Size = new System.Drawing.Size(94, 53);
            this.btnPedidoConcluido.TabIndex = 4;
            this.btnPedidoConcluido.Text = "Pedido Concluido";
            this.btnPedidoConcluido.UseVisualStyleBackColor = true;
            this.btnPedidoConcluido.Click += new System.EventHandler(this.btnPedidoConcluido_Click);
            // 
            // btnPedidoPendente
            // 
            this.btnPedidoPendente.Font = new System.Drawing.Font("Arimo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoPendente.Location = new System.Drawing.Point(428, 207);
            this.btnPedidoPendente.Name = "btnPedidoPendente";
            this.btnPedidoPendente.Size = new System.Drawing.Size(94, 53);
            this.btnPedidoPendente.TabIndex = 5;
            this.btnPedidoPendente.Text = "Pedido Pendente";
            this.btnPedidoPendente.UseVisualStyleBackColor = true;
            this.btnPedidoPendente.Click += new System.EventHandler(this.btnPedidoPendente_Click);
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(122)))), ((int)(((byte)(106)))));
            this.btnVoltarInicio.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnVoltarInicio.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarInicio.TabIndex = 23;
            this.btnVoltarInicio.Text = "Voltar";
            this.btnVoltarInicio.UseVisualStyleBackColor = false;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // ControleChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaConcluidos;
        private System.Windows.Forms.ListBox ListaClientesPendentes;
        private System.Windows.Forms.ListBox ListaClientesConcluidos;
        private System.Windows.Forms.Button btnPedidoConcluido;
        private System.Windows.Forms.Button btnPedidoPendente;
        private System.Windows.Forms.Button btnVoltarInicio;
    }
}