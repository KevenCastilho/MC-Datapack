using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MC_Data_Pack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(appdata + @"\.minecraft\saves\"))
            {
                Directory.CreateDirectory(appdata + @"\.minecraft\saves\");
            }
            string PastaMinecraft = appdata + @"\.minecraft\saves\";
            TempInfo = PastaMinecraft.ToString();
            DirectoryInfo pasta = new DirectoryInfo(PastaMinecraft);
            DirectoryInfo[] subPasta = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPasta)
            {
                cbPastas.Items.Add(dir.Name);
            }
        }

        public static string TempInfo { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbPastas.SelectedItem == null){
                MessageBox.Show("Selecione um item valido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cbPastas.SelectedItem.ToString()) == true)
            {
                MessageBox.Show("Selecione um item valido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Item = cbPastas.SelectedItem.ToString();
            DataPack.PastaMine = Form1.TempInfo + Item + "\\";
            this.Visible = false;
            DataPack DP = new DataPack();
            DP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string PastaMinecraft = appdata + @"\.minecraft\saves\";
            Form1.TempInfo = PastaMinecraft.ToString();
            DirectoryInfo pasta = new DirectoryInfo(PastaMinecraft);
            DirectoryInfo[] subPasta = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPasta)
            {
                cbPastas.Items.Remove(dir.Name);
                cbPastas.Items.Add(dir.Name);
            }
        }

        private void cbPastas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
