namespace A4
{
    partial class lbl2
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblImc = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.textpeso = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 69);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(12, 118);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 1;
            this.labelAltura.Text = "Altura:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(62, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(169, 25);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Calcule seu IMC";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(38, 137);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(260, 60);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(17, 210);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(29, 13);
            this.lblImc.TabIndex = 4;
            this.lblImc.Text = "IMC:";
            this.lblImc.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(64, 210);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "label2";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(17, 250);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 6;
            this.lblSituacao.Text = "Situação:";
            this.lblSituacao.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textpeso
            // 
            this.textpeso.Location = new System.Drawing.Point(52, 62);
            this.textpeso.Name = "textpeso";
            this.textpeso.Size = new System.Drawing.Size(246, 20);
            this.textpeso.TabIndex = 7;
            this.textpeso.TextChanged += new System.EventHandler(this.textpeso_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lbl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textpeso);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "lbl2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox textpeso;
        private System.Windows.Forms.TextBox textBox1;
    }
}

