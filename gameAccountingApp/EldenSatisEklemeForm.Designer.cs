namespace gameAccountingApp
{
    partial class EldenSatisEklemeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaticicomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UruncomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MiktartextBox = new System.Windows.Forms.TextBox();
            this.PazarFiyatitextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elden Satış Ekle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SaticicomboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.UruncomboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MiktartextBox);
            this.panel2.Controls.Add(this.PazarFiyatitextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 285);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Satıcı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyatı:";
            // 
            // SaticicomboBox
            // 
            this.SaticicomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaticicomboBox.FormattingEnabled = true;
            this.SaticicomboBox.Location = new System.Drawing.Point(186, 30);
            this.SaticicomboBox.Name = "SaticicomboBox";
            this.SaticicomboBox.Size = new System.Drawing.Size(139, 28);
            this.SaticicomboBox.TabIndex = 1;
            this.SaticicomboBox.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miktar:";
            // 
            // UruncomboBox
            // 
            this.UruncomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UruncomboBox.FormattingEnabled = true;
            this.UruncomboBox.Location = new System.Drawing.Point(186, 80);
            this.UruncomboBox.Name = "UruncomboBox";
            this.UruncomboBox.Size = new System.Drawing.Size(139, 28);
            this.UruncomboBox.TabIndex = 2;
            this.UruncomboBox.Text = "Ürün Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün:";
            // 
            // MiktartextBox
            // 
            this.MiktartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MiktartextBox.Location = new System.Drawing.Point(186, 131);
            this.MiktartextBox.Name = "MiktartextBox";
            this.MiktartextBox.Size = new System.Drawing.Size(139, 26);
            this.MiktartextBox.TabIndex = 3;
            // 
            // PazarFiyatitextBox
            // 
            this.PazarFiyatitextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PazarFiyatitextBox.Location = new System.Drawing.Point(186, 176);
            this.PazarFiyatitextBox.Name = "PazarFiyatitextBox";
            this.PazarFiyatitextBox.Size = new System.Drawing.Size(139, 26);
            this.PazarFiyatitextBox.TabIndex = 4;
            // 
            // EldenSatisEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "EldenSatisEklemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elden Satış Ekle";
            this.Load += new System.EventHandler(this.EldenSatisEklemeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox SaticicomboBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox UruncomboBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox MiktartextBox;
        public System.Windows.Forms.TextBox PazarFiyatitextBox;
    }
}