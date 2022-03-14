namespace Tugas_AD_Week4_terbaru
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        string[,] data = new string[10,3];
        int jumlahdata = 0; 
        private void BtnLihatData_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(data,jumlahdata);
            frm2.ShowDialog();            
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            data[jumlahdata, 0] = TbNama.Text;
            data[jumlahdata, 1] = TbAlamat.Text;
            data[jumlahdata, 2] = TbTelp.Text;          
            jumlahdata++;
        }
    }
}