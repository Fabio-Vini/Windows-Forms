namespace Desconto_INSS
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
            this.mskTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.cb_selecione = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu salário:";
            // 
            // mskTextBox1
            // 
            this.mskTextBox1.Location = new System.Drawing.Point(271, 163);
            this.mskTextBox1.Mask = "0000.00";
            this.mskTextBox1.Name = "mskTextBox1";
            this.mskTextBox1.Size = new System.Drawing.Size(100, 22);
            this.mskTextBox1.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(197, 219);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(205, 60);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qtd de horas trabalhada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor da hora trabalhada:";
            // 
            // mskTextBox2
            // 
            this.mskTextBox2.Location = new System.Drawing.Point(315, 19);
            this.mskTextBox2.Mask = "000";
            this.mskTextBox2.Name = "mskTextBox2";
            this.mskTextBox2.Size = new System.Drawing.Size(100, 22);
            this.mskTextBox2.TabIndex = 5;
            // 
            // mskTextBox3
            // 
            this.mskTextBox3.Location = new System.Drawing.Point(319, 92);
            this.mskTextBox3.Mask = "000.00";
            this.mskTextBox3.Name = "mskTextBox3";
            this.mskTextBox3.Size = new System.Drawing.Size(100, 22);
            this.mskTextBox3.TabIndex = 6;
            // 
            // cb_selecione
            // 
            this.cb_selecione.FormattingEnabled = true;
            this.cb_selecione.Items.AddRange(new object[] {
            "Horista",
            "Professor"});
            this.cb_selecione.Location = new System.Drawing.Point(467, 20);
            this.cb_selecione.Name = "cb_selecione";
            this.cb_selecione.Size = new System.Drawing.Size(121, 24);
            this.cb_selecione.TabIndex = 7;
            this.cb_selecione.Text = "Selecione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 303);
            this.Controls.Add(this.cb_selecione);
            this.Controls.Add(this.mskTextBox3);
            this.Controls.Add(this.mskTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.mskTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTextBox1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTextBox2;
        private System.Windows.Forms.MaskedTextBox mskTextBox3;
        private System.Windows.Forms.ComboBox cb_selecione;
    }
}

