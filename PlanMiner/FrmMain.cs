using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PlanMiner
{
    public partial class FrmMain : Form
    {
        public string selectedFile, selectedFile1;
        public bool updated = false;
        public FrmMain()
        {
            InitializeComponent();
            deleteAllFiles();
            showWorksPanel();
            //btnWork.BackColor = Color.Silver;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("Please select some file.");
                return;
            }
            initailBtnColor();
            showViewPanel();
        }

        private void btnWork_Click_1(object sender, EventArgs e)
        {
            showWorksPanel();
            //FrmSelectAgent temp = new FrmSelectAgent(new List<string>(), new List<string>() { "a", "b", "c" });
            //temp.ShowDialog();
        }
        private void btnActions_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("Please select a resource.");
                return;
            }
            initailBtnColor();
            showActionPanel();
        }

        public void initailBtnColor()
        {
            btnActions.BackColor = Color.White;
            btnView.BackColor = Color.White;
            btnWork.BackColor = Color.White;
        }

        public void showViewPanel()
        {
            btnView.Image = System.Drawing.Image.FromFile(@".\res\viewclik.png");
            btnWork.Image = System.Drawing.Image.FromFile(@".\res\work_unclik.png");
            this.pnlFormLoader.Controls.Clear();
            btnActions.Image = System.Drawing.Image.FromFile(@".\res\ActionUnclik.png");
            FrmView FrmView_Vrb = new FrmView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            FrmView_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmView_Vrb);
            FrmView_Vrb.ShowFileContent(selectedFile);
            FrmView_Vrb.Show();
        }

        public void showWorksPanel()
        {
            this.pnlFormLoader.Controls.Clear();
            if ( updated == true)
            {
                updated = false;
                selectedFile = "";
            }
            //btnWork.BackColor = Color.Silver;
            btnWork.Image = System.Drawing.Image.FromFile(@".\res\work_clik.png");
            btnActions.Image = System.Drawing.Image.FromFile(@".\res\ActionUnclik.png");
            btnView.Image = System.Drawing.Image.FromFile(@".\res\viewunclik.png");
            FrmWorkPlace FrmWorkPlace_Vrb = new FrmWorkPlace(selectedFile) { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            FrmWorkPlace_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmWorkPlace_Vrb);
            FrmWorkPlace_Vrb.formMain = this;
            FrmWorkPlace_Vrb.Show();
        }

        
        public void showActionPanel()
        {
            this.pnlFormLoader.Controls.Clear();
            btnWork.Image = System.Drawing.Image.FromFile(@".\res\work_unclik.png");
            btnActions.Image = System.Drawing.Image.FromFile(@".\res\action_clk.png");
            btnView.Image = System.Drawing.Image.FromFile(@".\res\viewunclik.png");
            FrmAction FrmAction_Vrb = new FrmAction(selectedFile, selectedFile1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            FrmAction_Vrb.FormBorderStyle = FormBorderStyle.None;
            FrmAction_Vrb.formMain = this;
            this.pnlFormLoader.Controls.Add(FrmAction_Vrb);
            FrmAction_Vrb.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Process.Start(@".\res\PlaMWeb.html");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            deleteAllFiles();
        }

        private void deleteAllFiles()
        {
            foreach (string filepath in Directory.EnumerateFiles(".\\Resources", "*.*"))
            {
                string ext = Path.GetExtension(filepath).ToLower();
                if (ext.Equals(".txt") || ext.Equals(".xml") || ext.Equals(".java") || ext.Equals(".csv"))
                {
                    File.Delete(filepath);
                }
            }
        }
    }
}
