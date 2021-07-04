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
using System.IO.Compression;

namespace MC_Data_Pack
{
    public partial class DataPack : Form
    {
        public DataPack()
        {
            InitializeComponent();
            string TempInfo = Form1.TempInfo;
            string PastaDataPack = PastaMine + "\\datapacks\\";
            DataPack.PastaDataPack = PastaDataPack.ToString();
            if (!Directory.Exists(DataPack.PastaDataPack))
            {
                Directory.CreateDirectory(DataPack.PastaDataPack);
            }
            DirectoryInfo pasta = new DirectoryInfo(PastaDataPack);
            DirectoryInfo[] subPasta = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPasta)
            {
                lbDatapacks.Items.Add(dir.Name);
            }
        }

        public static string PastaMine { get; set; }
        public static string PastaDataPack { get; set; }
        public static string datapack { get; set; }
        public static string nomeDatapack { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            string TempInfo = Form1.TempInfo;
            string PastaDataPack = PastaMine + "\\datapacks\\";
            DataPack.PastaDataPack = PastaDataPack.ToString();
            DirectoryInfo pasta = new DirectoryInfo(PastaDataPack);
            DirectoryInfo[] subPasta = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPasta)
            {
                lbDatapacks.Items.Remove(dir.Name);
                lbDatapacks.Items.Add(dir.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbDatapacks.SelectedItem == null)
            {
                return;
            }
            string datapack = lbDatapacks.SelectedItem.ToString();
            string PastaDataPack = DataPack.PastaDataPack + datapack;
            Directory.Delete(PastaDataPack, true);
            lbDatapacks.Items.Remove(datapack);
        }

        private void btnEscolherArquivo_Click(object sender, EventArgs e)
        {
            string nome;
            this.ofdDatapack.Title = "Selecione o datapack";
            this.ofdDatapack.Filter = "Zip Files (*.zip)|*.zip";
            this.ofdDatapack.CheckFileExists = true;
            this.ofdDatapack.CheckPathExists = true;
            this.ofdDatapack.FilterIndex = 2;
            this.ofdDatapack.RestoreDirectory = true;
            this.ofdDatapack.ReadOnlyChecked = true;
            this.ofdDatapack.ShowReadOnly = true;
            ofdDatapack.ShowDialog();
            lblCaminho.Text = ofdDatapack.FileName.ToString();
            DataPack.datapack = ofdDatapack.FileName.ToString();
            nome = Path.GetFileNameWithoutExtension(ofdDatapack.FileName);
            DataPack.nomeDatapack = nome;
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            string caminho = DataPack.PastaDataPack + DataPack.nomeDatapack;
            ZipFile.ExtractToDirectory(DataPack.datapack, caminho);
            MessageBox.Show("Datapack instalado com sucesso", "Aviso", MessageBoxButtons.OK);
        }
    }
}
