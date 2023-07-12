namespace Consulta_CEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o CEP :";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.Lime;
            this.txtCep.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold);
            this.txtCep.Location = new System.Drawing.Point(419, 42);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(267, 64);
            this.txtCep.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Lime;
            this.btnConsultar.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.Location = new System.Drawing.Point(309, 133);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(190, 55);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Black;
            this.lblCEP.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Lime;
            this.lblCEP.Location = new System.Drawing.Point(12, 252);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(84, 31);
            this.lblCEP.TabIndex = 3;
            this.lblCEP.Text = "CEP: ";
            this.lblCEP.Visible = false;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Black;
            this.lblBairro.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Lime;
            this.lblBairro.Location = new System.Drawing.Point(595, 252);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(109, 31);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro: ";
            this.lblBairro.Visible = false;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.BackColor = System.Drawing.Color.Black;
            this.lblLogradouro.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.ForeColor = System.Drawing.Color.Lime;
            this.lblLogradouro.Location = new System.Drawing.Point(12, 310);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(169, 31);
            this.lblLogradouro.TabIndex = 5;
            this.lblLogradouro.Text = "Logradouro: ";
            this.lblLogradouro.Visible = false;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Black;
            this.lblComplemento.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.Lime;
            this.lblComplemento.Location = new System.Drawing.Point(12, 370);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(200, 31);
            this.lblComplemento.TabIndex = 6;
            this.lblComplemento.Text = "Complemento: ";
            this.lblComplemento.Visible = false;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Black;
            this.lblCidade.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Lime;
            this.lblCidade.Location = new System.Drawing.Point(595, 310);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(113, 31);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade: ";
            this.lblCidade.Visible = false;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Black;
            this.lblUF.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.Color.Lime;
            this.lblUF.Location = new System.Drawing.Point(595, 370);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(69, 31);
            this.lblUF.TabIndex = 8;
            this.lblUF.Text = "UF: ";
            this.lblUF.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consultar CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF;
    }
}

