namespace Tugas_AD_Week4_terbaru
{
    partial class Form2
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
            this.BtnPrevData = new System.Windows.Forms.Button();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.Tb2Alamat = new System.Windows.Forms.TextBox();
            this.Tb2Telp = new System.Windows.Forms.TextBox();
            this.Tb2Nama = new System.Windows.Forms.TextBox();
            this.Lbl2Telp = new System.Windows.Forms.Label();
            this.Lbl2Alamat = new System.Windows.Forms.Label();
            this.Lbl2Nama = new System.Windows.Forms.Label();
            this.BtnNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrevData
            // 
            this.BtnPrevData.Location = new System.Drawing.Point(209, 244);
            this.BtnPrevData.Name = "BtnPrevData";
            this.BtnPrevData.Size = new System.Drawing.Size(94, 29);
            this.BtnPrevData.TabIndex = 15;
            this.BtnPrevData.Text = "Prev Data";
            this.BtnPrevData.UseVisualStyleBackColor = true;
            this.BtnPrevData.Click += new System.EventHandler(this.BtnPrevData_Click);
            // 
            // BtnKembali
            // 
            this.BtnKembali.Location = new System.Drawing.Point(48, 244);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(94, 29);
            this.BtnKembali.TabIndex = 14;
            this.BtnKembali.Text = "Kembali";
            this.BtnKembali.UseVisualStyleBackColor = true;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // Tb2Alamat
            // 
            this.Tb2Alamat.Location = new System.Drawing.Point(183, 113);
            this.Tb2Alamat.Name = "Tb2Alamat";
            this.Tb2Alamat.ReadOnly = true;
            this.Tb2Alamat.Size = new System.Drawing.Size(551, 27);
            this.Tb2Alamat.TabIndex = 13;
            // 
            // Tb2Telp
            // 
            this.Tb2Telp.Location = new System.Drawing.Point(183, 166);
            this.Tb2Telp.Name = "Tb2Telp";
            this.Tb2Telp.ReadOnly = true;
            this.Tb2Telp.Size = new System.Drawing.Size(271, 27);
            this.Tb2Telp.TabIndex = 12;
            // 
            // Tb2Nama
            // 
            this.Tb2Nama.Location = new System.Drawing.Point(183, 62);
            this.Tb2Nama.Name = "Tb2Nama";
            this.Tb2Nama.ReadOnly = true;
            this.Tb2Nama.Size = new System.Drawing.Size(443, 27);
            this.Tb2Nama.TabIndex = 11;
            // 
            // Lbl2Telp
            // 
            this.Lbl2Telp.AutoSize = true;
            this.Lbl2Telp.Location = new System.Drawing.Point(48, 173);
            this.Lbl2Telp.Name = "Lbl2Telp";
            this.Lbl2Telp.Size = new System.Drawing.Size(44, 20);
            this.Lbl2Telp.TabIndex = 10;
            this.Lbl2Telp.Text = "Telp :";
            // 
            // Lbl2Alamat
            // 
            this.Lbl2Alamat.AutoSize = true;
            this.Lbl2Alamat.Location = new System.Drawing.Point(48, 120);
            this.Lbl2Alamat.Name = "Lbl2Alamat";
            this.Lbl2Alamat.Size = new System.Drawing.Size(64, 20);
            this.Lbl2Alamat.TabIndex = 9;
            this.Lbl2Alamat.Text = "Alamat :";
            // 
            // Lbl2Nama
            // 
            this.Lbl2Nama.AutoSize = true;
            this.Lbl2Nama.Location = new System.Drawing.Point(48, 69);
            this.Lbl2Nama.Name = "Lbl2Nama";
            this.Lbl2Nama.Size = new System.Drawing.Size(56, 20);
            this.Lbl2Nama.TabIndex = 8;
            this.Lbl2Nama.Text = "Nama :";
            // 
            // BtnNextData
            // 
            this.BtnNextData.Location = new System.Drawing.Point(360, 244);
            this.BtnNextData.Name = "BtnNextData";
            this.BtnNextData.Size = new System.Drawing.Size(94, 29);
            this.BtnNextData.TabIndex = 16;
            this.BtnNextData.Text = "Next Data";
            this.BtnNextData.UseVisualStyleBackColor = true;
            this.BtnNextData.Click += new System.EventHandler(this.BtnNextData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNextData);
            this.Controls.Add(this.BtnPrevData);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.Tb2Alamat);
            this.Controls.Add(this.Tb2Telp);
            this.Controls.Add(this.Tb2Nama);
            this.Controls.Add(this.Lbl2Telp);
            this.Controls.Add(this.Lbl2Alamat);
            this.Controls.Add(this.Lbl2Nama);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPrevData;
        private Button BtnKembali;
        private TextBox Tb2Alamat;
        private TextBox Tb2Telp;
        private TextBox Tb2Nama;
        private Label Lbl2Telp;
        private Label Lbl2Alamat;
        private Label Lbl2Nama;
        private Button BtnNextData;
    }
}