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
using System.Diagnostics;

namespace MC_Data_Pack
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private async void SplashScreen_Load(object sender, EventArgs e)
        {
            int x;
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string PastaMinecraft = appdata+ @"\.minecraft\";
            for (x = 0; x < 3; x++)
            {
                await Task.Delay(1000);
            }
            if (!Directory.Exists(PastaMinecraft))
            {
                MessageBox.Show("Pasta .minecraft não encontrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            Form1 MainScreen = new Form1();
            this.Visible = false;
            MainScreen.Show();
        }
    }
}
