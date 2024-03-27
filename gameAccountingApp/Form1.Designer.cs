namespace gameAccountingApp
{
    partial class GameAccountingAppForm
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
            this.PazarSatisiSilBtn = new System.Windows.Forms.Button();
            this.EldenSatisSilBtn = new System.Windows.Forms.Button();
            this.GBSatisiSilBtn = new System.Windows.Forms.Button();
            this.UrunEkleBtn = new System.Windows.Forms.Button();
            this.KullaniciEkleBtn = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PazarSatisiEkleBtn = new System.Windows.Forms.Button();
            this.EldenSatisEkleBtn = new System.Windows.Forms.Button();
            this.GBSatisiEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PazarSatisGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EldenSatisGridWiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbSatisGridWiew)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PazarSatisGridWiew
            // 
            this.PazarSatisGridWiew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PazarSatisGridWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PazarSatisGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PazarSatisGridWiew.Location = new System.Drawing.Point(6, 6);
            this.PazarSatisGridWiew.Name = "PazarSatisGridWiew";
            this.PazarSatisGridWiew.Size = new System.Drawing.Size(1860, 805);
            this.PazarSatisGridWiew.TabIndex = 0;
            // 
            // EldenSatisGridWiew
            // 
            this.EldenSatisGridWiew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EldenSatisGridWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EldenSatisGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EldenSatisGridWiew.Location = new System.Drawing.Point(6, 6);
            this.EldenSatisGridWiew.Name = "EldenSatisGridWiew";
            this.EldenSatisGridWiew.Size = new System.Drawing.Size(1860, 805);
            this.EldenSatisGridWiew.TabIndex = 1;
            // 
            // GbSatisGridWiew
            // 
            this.GbSatisGridWiew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbSatisGridWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GbSatisGridWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GbSatisGridWiew.Location = new System.Drawing.Point(6, 6);
            this.GbSatisGridWiew.Name = "GbSatisGridWiew";
            this.GbSatisGridWiew.Size = new System.Drawing.Size(1860, 805);
            this.GbSatisGridWiew.TabIndex = 2;
            // 
            // PazarSatisiSilBtn
            // 
            this.PazarSatisiSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.PazarSatisiSilBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PazarSatisiSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PazarSatisiSilBtn.Location = new System.Drawing.Point(3, 857);
            this.PazarSatisiSilBtn.Name = "PazarSatisiSilBtn";
            this.PazarSatisiSilBtn.Size = new System.Drawing.Size(1866, 40);
            this.PazarSatisiSilBtn.TabIndex = 7;
            this.PazarSatisiSilBtn.Text = "Pazar Satışı Sil";
            this.PazarSatisiSilBtn.UseVisualStyleBackColor = false;
            // 
            // EldenSatisSilBtn
            // 
            this.EldenSatisSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.EldenSatisSilBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EldenSatisSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EldenSatisSilBtn.Location = new System.Drawing.Point(3, 857);
            this.EldenSatisSilBtn.Name = "EldenSatisSilBtn";
            this.EldenSatisSilBtn.Size = new System.Drawing.Size(1866, 40);
            this.EldenSatisSilBtn.TabIndex = 8;
            this.EldenSatisSilBtn.Text = "Elden Satış Sil";
            this.EldenSatisSilBtn.UseVisualStyleBackColor = false;
            this.EldenSatisSilBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // GBSatisiSilBtn
            // 
            this.GBSatisiSilBtn.BackColor = System.Drawing.Color.LightCoral;
            this.GBSatisiSilBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBSatisiSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBSatisiSilBtn.Location = new System.Drawing.Point(3, 857);
            this.GBSatisiSilBtn.Name = "GBSatisiSilBtn";
            this.GBSatisiSilBtn.Size = new System.Drawing.Size(1866, 40);
            this.GBSatisiSilBtn.TabIndex = 9;
            this.GBSatisiSilBtn.Text = "GB Satışı Sil";
            this.GBSatisiSilBtn.UseVisualStyleBackColor = false;
            // 
            // UrunEkleBtn
            // 
            this.UrunEkleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UrunEkleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.UrunEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunEkleBtn.Location = new System.Drawing.Point(1390, 973);
            this.UrunEkleBtn.Name = "UrunEkleBtn";
            this.UrunEkleBtn.Size = new System.Drawing.Size(231, 40);
            this.UrunEkleBtn.TabIndex = 10;
            this.UrunEkleBtn.Text = "Ürün Ekle";
            this.UrunEkleBtn.UseVisualStyleBackColor = false;
            // 
            // KullaniciEkleBtn
            // 
            this.KullaniciEkleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KullaniciEkleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.KullaniciEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciEkleBtn.Location = new System.Drawing.Point(1651, 973);
            this.KullaniciEkleBtn.Name = "KullaniciEkleBtn";
            this.KullaniciEkleBtn.Size = new System.Drawing.Size(231, 40);
            this.KullaniciEkleBtn.TabIndex = 11;
            this.KullaniciEkleBtn.Text = "Kullanıcı Ekle";
            this.KullaniciEkleBtn.UseVisualStyleBackColor = false;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1880, 938);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PazarSatisiEkleBtn);
            this.tabPage1.Controls.Add(this.PazarSatisGridWiew);
            this.tabPage1.Controls.Add(this.PazarSatisiSilBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1872, 900);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pazar Satış";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EldenSatisEkleBtn);
            this.tabPage2.Controls.Add(this.EldenSatisGridWiew);
            this.tabPage2.Controls.Add(this.EldenSatisSilBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1872, 900);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Elden Satış";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GBSatisiEkleBtn);
            this.tabPage3.Controls.Add(this.GbSatisGridWiew);
            this.tabPage3.Controls.Add(this.GBSatisiSilBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1872, 900);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GB Satış";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1872, 900);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Toplam Satış";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PazarSatisiEkleBtn
            // 
            this.PazarSatisiEkleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.PazarSatisiEkleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PazarSatisiEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PazarSatisiEkleBtn.Location = new System.Drawing.Point(3, 817);
            this.PazarSatisiEkleBtn.Name = "PazarSatisiEkleBtn";
            this.PazarSatisiEkleBtn.Size = new System.Drawing.Size(1866, 40);
            this.PazarSatisiEkleBtn.TabIndex = 8;
            this.PazarSatisiEkleBtn.Text = "Pazar Satışı Ekle";
            this.PazarSatisiEkleBtn.UseVisualStyleBackColor = false;
            this.PazarSatisiEkleBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // EldenSatisEkleBtn
            // 
            this.EldenSatisEkleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.EldenSatisEkleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EldenSatisEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EldenSatisEkleBtn.Location = new System.Drawing.Point(3, 817);
            this.EldenSatisEkleBtn.Name = "EldenSatisEkleBtn";
            this.EldenSatisEkleBtn.Size = new System.Drawing.Size(1866, 40);
            this.EldenSatisEkleBtn.TabIndex = 9;
            this.EldenSatisEkleBtn.Text = "Elden Satış Ekle";
            this.EldenSatisEkleBtn.UseVisualStyleBackColor = false;
            // 
            // GBSatisiEkleBtn
            // 
            this.GBSatisiEkleBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.GBSatisiEkleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBSatisiEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBSatisiEkleBtn.Location = new System.Drawing.Point(3, 817);
            this.GBSatisiEkleBtn.Name = "GBSatisiEkleBtn";
            this.GBSatisiEkleBtn.Size = new System.Drawing.Size(1866, 40);
            this.GBSatisiEkleBtn.TabIndex = 10;
            this.GBSatisiEkleBtn.Text = "GB Satışı Ekle";
            this.GBSatisiEkleBtn.UseVisualStyleBackColor = false;
            // 
            // GameAccountingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.UrunEkleBtn);
            this.Controls.Add(this.KullaniciEkleBtn);
            this.Name = "GameAccountingAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Accounting App";
            ((System.ComponentModel.ISupportInitialize)(this.PazarSatisGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EldenSatisGridWiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GbSatisGridWiew)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PazarSatisGridWiew;
        private System.Windows.Forms.DataGridView EldenSatisGridWiew;
        private System.Windows.Forms.DataGridView GbSatisGridWiew;
        private System.Windows.Forms.Button PazarSatisiSilBtn;
        private System.Windows.Forms.Button EldenSatisSilBtn;
        private System.Windows.Forms.Button GBSatisiSilBtn;
        private System.Windows.Forms.Button UrunEkleBtn;
        private System.Windows.Forms.Button KullaniciEkleBtn;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button PazarSatisiEkleBtn;
        private System.Windows.Forms.Button EldenSatisEkleBtn;
        private System.Windows.Forms.Button GBSatisiEkleBtn;
    }
}

