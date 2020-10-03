namespace ProgOrientadaObjetosCSharp
{
    partial class frm06_AssociacaoUnidirecional
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
            this.btnFuncComp = new System.Windows.Forms.Button();
            this.btnFuncCompTablet = new System.Windows.Forms.Button();
            this.btnPosJogador = new System.Windows.Forms.Button();
            this.btnArtigoAutor = new System.Windows.Forms.Button();
            this.btnVendedorCliente = new System.Windows.Forms.Button();
            this.btnAeronaveTrecho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncComp
            // 
            this.btnFuncComp.Location = new System.Drawing.Point(30, 34);
            this.btnFuncComp.Name = "btnFuncComp";
            this.btnFuncComp.Size = new System.Drawing.Size(222, 79);
            this.btnFuncComp.TabIndex = 22;
            this.btnFuncComp.Text = "Funcionário\r\nComputador";
            this.btnFuncComp.UseVisualStyleBackColor = true;
            this.btnFuncComp.Click += new System.EventHandler(this.btnFuncComp_Click);
            // 
            // btnFuncCompTablet
            // 
            this.btnFuncCompTablet.Location = new System.Drawing.Point(290, 34);
            this.btnFuncCompTablet.Name = "btnFuncCompTablet";
            this.btnFuncCompTablet.Size = new System.Drawing.Size(222, 79);
            this.btnFuncCompTablet.TabIndex = 23;
            this.btnFuncCompTablet.Text = "Funcionário\r\nComp - Tablet";
            this.btnFuncCompTablet.UseVisualStyleBackColor = true;
            this.btnFuncCompTablet.Click += new System.EventHandler(this.btnFuncCompTablet_Click);
            // 
            // btnPosJogador
            // 
            this.btnPosJogador.Location = new System.Drawing.Point(545, 34);
            this.btnPosJogador.Name = "btnPosJogador";
            this.btnPosJogador.Size = new System.Drawing.Size(222, 79);
            this.btnPosJogador.TabIndex = 24;
            this.btnPosJogador.Text = "Posição\r\nJogador";
            this.btnPosJogador.UseVisualStyleBackColor = true;
            this.btnPosJogador.Click += new System.EventHandler(this.btnPosJogador_Click);
            // 
            // btnArtigoAutor
            // 
            this.btnArtigoAutor.Location = new System.Drawing.Point(30, 146);
            this.btnArtigoAutor.Name = "btnArtigoAutor";
            this.btnArtigoAutor.Size = new System.Drawing.Size(222, 79);
            this.btnArtigoAutor.TabIndex = 25;
            this.btnArtigoAutor.Text = "Artigo\r\nAutor";
            this.btnArtigoAutor.UseVisualStyleBackColor = true;
            this.btnArtigoAutor.Click += new System.EventHandler(this.btnArtigoAutor_Click);
            // 
            // btnVendedorCliente
            // 
            this.btnVendedorCliente.Location = new System.Drawing.Point(290, 146);
            this.btnVendedorCliente.Name = "btnVendedorCliente";
            this.btnVendedorCliente.Size = new System.Drawing.Size(222, 79);
            this.btnVendedorCliente.TabIndex = 26;
            this.btnVendedorCliente.Text = "Vendedor\r\nCliente";
            this.btnVendedorCliente.UseVisualStyleBackColor = true;
            this.btnVendedorCliente.Click += new System.EventHandler(this.btnVendedorCliente_Click);
            // 
            // btnAeronaveTrecho
            // 
            this.btnAeronaveTrecho.Location = new System.Drawing.Point(545, 146);
            this.btnAeronaveTrecho.Name = "btnAeronaveTrecho";
            this.btnAeronaveTrecho.Size = new System.Drawing.Size(222, 79);
            this.btnAeronaveTrecho.TabIndex = 27;
            this.btnAeronaveTrecho.Text = "Aeronave\r\nTrechoVoo";
            this.btnAeronaveTrecho.UseVisualStyleBackColor = true;
            this.btnAeronaveTrecho.Click += new System.EventHandler(this.btnAeronaveTrecho_Click);
            // 
            // frm06_AssociacaoUnidirecional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 283);
            this.Controls.Add(this.btnAeronaveTrecho);
            this.Controls.Add(this.btnVendedorCliente);
            this.Controls.Add(this.btnArtigoAutor);
            this.Controls.Add(this.btnPosJogador);
            this.Controls.Add(this.btnFuncCompTablet);
            this.Controls.Add(this.btnFuncComp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm06_AssociacaoUnidirecional";
            this.Text = "Associação Unidirecional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncComp;
        private System.Windows.Forms.Button btnFuncCompTablet;
        private System.Windows.Forms.Button btnPosJogador;
        private System.Windows.Forms.Button btnArtigoAutor;
        private System.Windows.Forms.Button btnVendedorCliente;
        private System.Windows.Forms.Button btnAeronaveTrecho;
    }
}