namespace Tugas_AD_Week4_terbaru
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNama = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.LblTelp = new System.Windows.Forms.Label();
            this.TbNama = new System.Windows.Forms.TextBox();
            this.TbTelp = new System.Windows.Forms.TextBox();
            this.TbAlamat = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.Location = new System.Drawing.Point(51, 55);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(56, 20);
            this.LblNama.TabIndex = 0;
            this.LblNama.Text = "Nama :";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.Location = new System.Drawing.Point(51, 106);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(64, 20);
            this.LblAlamat.TabIndex = 1;
            this.LblAlamat.Text = "Alamat :";
            // 
            // LblTelp
            // 
            this.LblTelp.AutoSize = true;
            this.LblTelp.Location = new System.Drawing.Point(51, 159);
            this.LblTelp.Name = "LblTelp";
            this.LblTelp.Size = new System.Drawing.Size(44, 20);
            this.LblTelp.TabIndex = 2;
            this.LblTelp.Text = "Telp :";
            // 
            // TbNama
            // 
            this.TbNama.Location = new System.Drawing.Point(186, 48);
            this.TbNama.Name = "TbNama";
            this.TbNama.Size = new System.Drawing.Size(443, 27);
            this.TbNama.TabIndex = 3;
            // 
            // TbTelp
            // 
            this.TbTelp.Location = new System.Drawing.Point(186, 152);
            this.TbTelp.Name = "TbTelp";
            this.TbTelp.Size = new System.Drawing.Size(271, 27);
            this.TbTelp.TabIndex = 4;
            // 
            // TbAlamat
            // 
            this.TbAlamat.Location = new System.Drawing.Point(186, 99);
            this.TbAlamat.Name = "TbAlamat";
            this.TbAlamat.Size = new System.Drawing.Size(551, 27);
            this.TbAlamat.TabIndex = 5;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(107, 230);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(94, 29);
            this.BtnSimpan.TabIndex = 6;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnLihatData
            // 
            this.BtnLihatData.Location = new System.Drawing.Point(262, 230);
            this.BtnLihatData.Name = "BtnLihatData";
            this.BtnLihatData.Size = new System.Drawing.Size(94, 29);
            this.BtnLihatData.TabIndex = 7;
            this.BtnLihatData.Text = "Lihat Data";
            this.BtnLihatData.UseVisualStyleBackColor = true;
            this.BtnLihatData.Click += new System.EventHandler(this.BtnLihatData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLihatData);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TbAlamat);
            this.Controls.Add(this.TbTelp);
            this.Controls.Add(this.TbNama);
            this.Controls.Add(this.LblTelp);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LblNama);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNama;
        private Label LblAlamat;
        private Label LblTelp;
        private TextBox TbNama;
        private TextBox TbTelp;
        private TextBox TbAlamat;
        private Button BtnSimpan;
        private Button BtnLihatData;
    }
}