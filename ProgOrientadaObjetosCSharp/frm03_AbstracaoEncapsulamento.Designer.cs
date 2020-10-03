namespace ProgOrientadaObjetosCSharp
{
    partial class frm03_AbstracaoEncapsulamento
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
            this.btnClasse = new System.Windows.Forms.Button();
            this.btnAtributosPrivados = new System.Windows.Forms.Button();
            this.btnExemplo = new System.Windows.Forms.Button();
            this.btnMaternidade = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClasse
            // 
            this.btnClasse.Location = new System.Drawing.Point(12, 28);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(226, 84);
            this.btnClasse.TabIndex = 1;
            this.btnClasse.Text = "Classe\r\nAtributos Publicos";
            this.btnClasse.UseVisualStyleBackColor = true;
            this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
            // 
            // btnAtributosPrivados
            // 
            this.btnAtributosPrivados.Location = new System.Drawing.Point(510, 28);
            this.btnAtributosPrivados.Name = "btnAtributosPrivados";
            this.btnAtributosPrivados.Size = new System.Drawing.Size(226, 84);
            this.btnAtributosPrivados.TabIndex = 3;
            this.btnAtributosPrivados.Text = "Classe\r\nAtributos Privados";
            this.btnAtributosPrivados.UseVisualStyleBackColor = true;
            this.btnAtributosPrivados.Click += new System.EventHandler(this.btnAtributosPrivados_Click);
            // 
            // btnExemplo
            // 
            this.btnExemplo.Location = new System.Drawing.Point(257, 144);
            this.btnExemplo.Name = "btnExemplo";
            this.btnExemplo.Size = new System.Drawing.Size(226, 84);
            this.btnExemplo.TabIndex = 6;
            this.btnExemplo.Text = "Exemplo\r\nCriptografia";
            this.btnExemplo.UseVisualStyleBackColor = true;
            this.btnExemplo.Click += new System.EventHandler(this.btnExemplo_Click);
            // 
            // btnMaternidade
            // 
            this.btnMaternidade.Location = new System.Drawing.Point(257, 28);
            this.btnMaternidade.Name = "btnMaternidade";
            this.btnMaternidade.Size = new System.Drawing.Size(226, 84);
            this.btnMaternidade.TabIndex = 7;
            this.btnMaternidade.Text = "Maternidade";
            this.btnMaternidade.UseVisualStyleBackColor = true;
            this.btnMaternidade.Click += new System.EventHandler(this.btnMaternidade_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(12, 144);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(226, 84);
            this.btnAluno.TabIndex = 8;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // frm03_AbstracaoEncapsulamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 280);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnMaternidade);
            this.Controls.Add(this.btnExemplo);
            this.Controls.Add(this.btnAtributosPrivados);
            this.Controls.Add(this.btnClasse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm03_AbstracaoEncapsulamento";
            this.Text = "Abstração e Encapsulamento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Button btnAtributosPrivados;
        private System.Windows.Forms.Button btnExemplo;
        private System.Windows.Forms.Button btnMaternidade;
        private System.Windows.Forms.Button btnAluno;
    }
}