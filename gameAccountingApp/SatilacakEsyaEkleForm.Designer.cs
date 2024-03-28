namespace gameAccountingApp
{
    partial class SatilacakEsyaEkleForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemKaydetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemAditextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 93);
            this.label6.TabIndex = 14;
            this.label6.Text = "İtem Ekle";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemKaydetBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ItemAditextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 138);
            this.panel2.TabIndex = 13;
            // 
            // ItemKaydetBtn
            // 
            this.ItemKaydetBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.ItemKaydetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemKaydetBtn.Location = new System.Drawing.Point(0, 83);
            this.ItemKaydetBtn.Name = "ItemKaydetBtn";
            this.ItemKaydetBtn.Size = new System.Drawing.Size(330, 55);
            this.ItemKaydetBtn.TabIndex = 9;
            this.ItemKaydetBtn.Text = "KAYDET";
            this.ItemKaydetBtn.UseVisualStyleBackColor = false;
            this.ItemKaydetBtn.Click += new System.EventHandler(this.ItemKaydetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "İtem Adı:";
            // 
            // ItemAditextBox
            // 
            this.ItemAditextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemAditextBox.Location = new System.Drawing.Point(147, 31);
            this.ItemAditextBox.Name = "ItemAditextBox";
            this.ItemAditextBox.Size = new System.Drawing.Size(139, 26);
            this.ItemAditextBox.TabIndex = 3;
            // 
            // SatilacakEsyaEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 231);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Name = "SatilacakEsyaEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatilacakEsyaEkleForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ItemKaydetBtn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ItemAditextBox;
    }
}