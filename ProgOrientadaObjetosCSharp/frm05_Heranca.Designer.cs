namespace ProgOrientadaObjetosCSharp
{
    partial class frm05_Heranca
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
            this.btnHeranca = new System.Windows.Forms.Button();
            this.btnBase = new System.Windows.Forms.Button();
            this.btnVirtualOverride = new System.Windows.Forms.Button();
            this.btnColaboradorGer = new System.Windows.Forms.Button();
            this.btnVeicUsado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHeranca
            // 
            this.btnHeranca.Location = new System.Drawing.Point(28, 40);
            this.btnHeranca.Name = "btnHeranca";
            this.btnHeranca.Size = new System.Drawing.Size(167, 64);
            this.btnHeranca.TabIndex = 0;
            this.btnHeranca.Text = "Herança";
            this.btnHeranca.UseVisualStyleBackColor = true;
            this.btnHeranca.Click += new System.EventHandler(this.btnHeranca_Click);
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(227, 40);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(167, 64);
            this.btnBase.TabIndex = 1;
            this.btnBase.Text = "Base";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnVirtualOverride
            // 
            this.btnVirtualOverride.Location = new System.Drawing.Point(438, 40);
            this.btnVirtualOverride.Name = "btnVirtualOverride";
            this.btnVirtualOverride.Size = new System.Drawing.Size(167, 64);
            this.btnVirtualOverride.TabIndex = 2;
            this.btnVirtualOverride.Text = "Virtual\r\nOverride";
            this.btnVirtualOverride.UseVisualStyleBackColor = true;
            this.btnVirtualOverride.Click += new System.EventHandler(this.btnVirtualOverride_Click);
            // 
            // btnColaboradorGer
            // 
            this.btnColaboradorGer.Location = new System.Drawing.Point(28, 129);
            this.btnColaboradorGer.Name = "btnColaboradorGer";
            this.btnColaboradorGer.Size = new System.Drawing.Size(167, 64);
            this.btnColaboradorGer.TabIndex = 3;
            this.btnColaboradorGer.Text = "Colaborador\r\nGerente";
            this.btnColaboradorGer.UseVisualStyleBackColor = true;
            this.btnColaboradorGer.Click += new System.EventHandler(this.btnColaboradorGer_Click);
            // 
            // btnVeicUsado
            // 
            this.btnVeicUsado.Location = new System.Drawing.Point(227, 133);
            this.btnVeicUsado.Name = "btnVeicUsado";
            this.btnVeicUsado.Size = new System.Drawing.Size(157, 60);
            this.btnVeicUsado.TabIndex = 4;
            this.btnVeicUsado.Text = "Veículos\r\nUsados\r\n";
            this.btnVeicUsado.UseVisualStyleBackColor = true;
            this.btnVeicUsado.Click += new System.EventHandler(this.btnVeicUsado_Click);
            // 
            // frm05_Heranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 303);
            this.Controls.Add(this.btnVeicUsado);
            this.Controls.Add(this.btnColaboradorGer);
            this.Controls.Add(this.btnVirtualOverride);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.btnHeranca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm05_Heranca";
            this.Text = "Herança";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeranca;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnVirtualOverride;
        private System.Windows.Forms.Button btnColaboradorGer;
        private System.Windows.Forms.Button btnVeicUsado;
    }
}