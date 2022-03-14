using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_AD_Week4_terbaru
{
    
    public partial class Form2 : Form
    {
        string[,] dataOrang;
        int jumlahdata = 0;
        int totalData = 0;
        

        public Form2(string[,] data, int dataCount)
        {
            totalData = dataCount;
            dataOrang = data;
            InitializeComponent();           
        }   
        private void Form2_Load(object sender, EventArgs e)
        {    
            Tb2Nama.Text = dataOrang[jumlahdata, 0];
            Tb2Alamat.Text = dataOrang[jumlahdata, 1];
            Tb2Telp.Text = dataOrang[jumlahdata,2];

        }

        private void BtnPrevData_Click(object sender, EventArgs e)
        {
            if (jumlahdata ==0)
            {
                MessageBox.Show("Data sudah yang pertama");
            }
            else
            {
                jumlahdata--;
                Tb2Nama.Text = dataOrang[jumlahdata, 0];
                Tb2Alamat.Text = dataOrang[jumlahdata, 1];
                Tb2Telp.Text = dataOrang[jumlahdata, 2];
            } 
        }

        private void BtnNextData_Click(object sender, EventArgs e)
        {
            if (jumlahdata == totalData-1) 
            {
                MessageBox.Show("Data sudah yang Terakhir");
            }
            else
            {
                jumlahdata++;
                Tb2Nama.Text = dataOrang[jumlahdata, 0];
                Tb2Alamat.Text = dataOrang[jumlahdata, 1];
                Tb2Telp.Text = dataOrang[jumlahdata, 2];
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
