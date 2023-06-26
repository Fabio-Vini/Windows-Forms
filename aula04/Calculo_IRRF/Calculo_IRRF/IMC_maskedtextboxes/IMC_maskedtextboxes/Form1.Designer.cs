namespace IMC_maskedtextboxes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.btnIMC = new System.Windows.Forms.Button();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "IMC:";
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(92, 156);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(195, 42);
            this.btnIMC.TabIndex = 10;
            this.btnIMC.Text = "Calcular IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(187, 99);
            this.mskPeso.Mask = "000.00";
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(100, 22);
            this.mskPeso.TabIndex = 9;
            this.mskPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Peso";
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(187, 38);
            this.mskAltura.Mask = "0.00";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(100, 22);
            this.mskAltura.TabIndex = 7;
            this.mskAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(87, 31);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(74, 29);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(67, 249);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 12;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "images.jpg");
            this.imageList.Images.SetKeyName(1, "f5d0be33ae3316c7a800f80fdfd20f7452cbeef6244813bbc178263148e7ac5f_1.jpg");
            this.imageList.Images.SetKeyName(2, "download.jpg");
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(306, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(230, 195);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 294);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.mskPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.MaskedTextBox mskPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

