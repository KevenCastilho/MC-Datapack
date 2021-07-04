
namespace MC_Data_Pack
{
    partial class DataPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPack));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDatapacks = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnEscolherArquivo = new System.Windows.Forms.Button();
            this.ofdDatapack = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecrafter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datapack Tools";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MC_Data_Pack.Properties.Resources.Minecraft_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, -54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbDatapacks);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datapacks Instalados";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(386, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDatapacks
            // 
            this.lbDatapacks.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatapacks.FormattingEnabled = true;
            this.lbDatapacks.ItemHeight = 21;
            this.lbDatapacks.Location = new System.Drawing.Point(6, 19);
            this.lbDatapacks.Name = "lbDatapacks";
            this.lbDatapacks.Size = new System.Drawing.Size(455, 130);
            this.lbDatapacks.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnInstalar);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instalar novo DataPack";
            // 
            // btnInstalar
            // 
            this.btnInstalar.ForeColor = System.Drawing.Color.Black;
            this.btnInstalar.Location = new System.Drawing.Point(386, 24);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(75, 23);
            this.btnInstalar.TabIndex = 2;
            this.btnInstalar.Text = "Instalar";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCaminho);
            this.panel1.Controls.Add(this.btnEscolherArquivo);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 32);
            this.panel1.TabIndex = 0;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(128, 10);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(0, 13);
            this.lblCaminho.TabIndex = 2;
            // 
            // btnEscolherArquivo
            // 
            this.btnEscolherArquivo.ForeColor = System.Drawing.Color.Black;
            this.btnEscolherArquivo.Location = new System.Drawing.Point(3, 5);
            this.btnEscolherArquivo.Name = "btnEscolherArquivo";
            this.btnEscolherArquivo.Size = new System.Drawing.Size(119, 23);
            this.btnEscolherArquivo.TabIndex = 1;
            this.btnEscolherArquivo.Text = "Escolher Arquivo";
            this.btnEscolherArquivo.UseVisualStyleBackColor = true;
            this.btnEscolherArquivo.Click += new System.EventHandler(this.btnEscolherArquivo_Click);
            // 
            // ofdDatapack
            // 
            this.ofdDatapack.DefaultExt = "zip";
            this.ofdDatapack.Title = "Selecione o Datapack a ser instalado";
            // 
            // DataPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MC_Data_Pack.Properties.Resources.d4m00v3_e3ad6c0b_c466_4eff_9eec_4ac7dad60bff;
            this.ClientSize = new System.Drawing.Size(493, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbDatapacks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInstalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Button btnEscolherArquivo;
        private System.Windows.Forms.OpenFileDialog ofdDatapack;
    }
}