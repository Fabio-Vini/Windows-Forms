namespace SalarioHorista
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
            this.label2 = new System.Windows.Forms.Label();
            this.mskTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.cb_selecione = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qtd de horas trabalhada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor da hora trabalhada:";
            // 
            // mskTextBox1
            // 
            this.mskTextBox1.Location = new System.Drawing.Point(299, 23);
            this.mskTextBox1.Mask = "000";
            this.mskTextBox1.Name = "mskTextBox1";
            this.mskTextBox1.Size = new System.Drawing.Size(78, 22);
            this.mskTextBox1.TabIndex = 2;
            this.mskTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskTextBox2
            // 
            this.mskTextBox2.Location = new System.Drawing.Point(299, 98);
            this.mskTextBox2.Mask = "000.00";
            this.mskTextBox2.Name = "mskTextBox2";
            this.mskTextBox2.Size = new System.Drawing.Size(78, 22);
            this.mskTextBox2.TabIndex = 3;
            // 
            // cb_selecione
            // 
            this.cb_selecione.FormattingEnabled = true;
            this.cb_selecione.Items.AddRange(new object[] {
            "Horista",
            "Professor"});
            this.cb_selecione.Location = new System.Drawing.Point(115, 142);
            this.cb_selecione.Name = "cb_selecione";
            this.cb_selecione.Size = new System.Drawing.Size(147, 24);
            this.cb_selecione.TabIndex = 4;
            this.cb_selecione.Text = "Selecione";
            this.cb_selecione.SelectedIndexChanged += new System.EventHandler(this.cb_selecione_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(52, 206);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(293, 50);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 277);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cb_selecione);
            this.Controls.Add(this.mskTextBox2);
            this.Controls.Add(this.mskTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTextBox1;
        private System.Windows.Forms.MaskedTextBox mskTextBox2;
        private System.Windows.Forms.ComboBox cb_selecione;
        private System.Windows.Forms.Button btnCalc;
    }
}

