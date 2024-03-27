namespace gameAccountingApp
{
    partial class Form1
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
            this.PazarSatisGridWiew = new System.Windows.Forms.DataGridView();
            this.EldenSatisGridWiew = new System.Windows.Forms.DataGridView();
            this.GbSatisGridWiew = new System.Windows.Forms.DataGridView();
            this.ToplamGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            ((System.ComponentModel.ISupportInitialize)(this.PazarSatisGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EldenSatisGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbSatisGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToplamGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PazarSatisGridWiew
            // 
            this.PazarSatisGridWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PazarSatisGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PazarSatisGridWiew.Location = new System.Drawing.Point(12, 52);
            this.PazarSatisGridWiew.Name = "PazarSatisGridWiew";
            this.PazarSatisGridWiew.Size = new System.Drawing.Size(932, 332);
            this.PazarSatisGridWiew.TabIndex = 0;
            // 
            // EldenSatisGridWiew
            // 
            this.EldenSatisGridWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EldenSatisGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EldenSatisGridWiew.Location = new System.Drawing.Point(960, 52);
            this.EldenSatisGridWiew.Name = "EldenSatisGridWiew";
            this.EldenSatisGridWiew.Size = new System.Drawing.Size(932, 332);
            this.EldenSatisGridWiew.TabIndex = 1;
            // 
            // GbSatisGridWiew
            // 
            this.GbSatisGridWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GbSatisGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GbSatisGridWiew.Location = new System.Drawing.Point(12, 529);
            this.GbSatisGridWiew.Name = "GbSatisGridWiew";
            this.GbSatisGridWiew.Size = new System.Drawing.Size(932, 332);
            this.GbSatisGridWiew.TabIndex = 2;
            // 
            // ToplamGridView1
            // 
            this.ToplamGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToplamGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToplamGridView1.Location = new System.Drawing.Point(960, 529);
            this.ToplamGridView1.Name = "ToplamGridView1";
            this.ToplamGridView1.Size = new System.Drawing.Size(932, 332);
            this.ToplamGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pazar Satış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elden Satış";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(354, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pazar Satışı Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1350, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Elden Satış Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(338, 867);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "GB Satışı Ekle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1661, 956);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ürün Ekle";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(1661, 898);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Kullanıcı Ekle";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(363, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "GB Satış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1349, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toplam Satış";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToplamGridView1);
            this.Controls.Add(this.GbSatisGridWiew);
            this.Controls.Add(this.EldenSatisGridWiew);
            this.Controls.Add(this.PazarSatisGridWiew);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Accounting App";
            ((System.ComponentModel.ISupportInitialize)(this.PazarSatisGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EldenSatisGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbSatisGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToplamGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PazarSatisGridWiew;
        private System.Windows.Forms.DataGridView EldenSatisGridWiew;
        private System.Windows.Forms.DataGridView GbSatisGridWiew;
        private System.Windows.Forms.DataGridView ToplamGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}

