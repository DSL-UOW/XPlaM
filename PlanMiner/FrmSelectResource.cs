using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMiner
{
    public partial class FrmSelectResource : Form
    {
        List<Button> button;
        string selectedFile="";
        FrmAction frmAction;
        int num = 0;
        public FrmSelectResource(FrmAction frmAction, int num)
        {
            InitializeComponent();
            this.frmAction = frmAction;
            this.num = num;
            //this.selectedFile = path;
            btnImportedRes.Visible = false;

            button = new List<Button>();
            foreach (string filepath in Directory.EnumerateFiles(".\\Resources", "*.*"))
            {
                createNewButton(filepath);
            }
            initialBtnBack();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if ( selectedFile == frmAction.selectedFile)
            {
                MessageBox.Show("This file already was selected at first");
                return;
            }
            if (num == 1) frmAction.selectedFile1 = selectedFile;
            if (num==2) frmAction.str_path2 = selectedFile;
            this.Close();
        }

        private void createNewButton(string filepath)
        {
            Image img;
            FileInfo fInfo = new FileInfo(filepath);
            if (fInfo.Extension.Equals(".txt"))
            {
                img = Image.FromFile("res\\txt_icon.png");
            }
            else if (fInfo.Extension.Equals(".xml"))
            {
                img = Image.FromFile("res\\xml_icon.png");
            }
            else if (fInfo.Extension.Equals(".java"))
            {
                img = Image.FromFile("res\\java_icon.png");
            }
            else if (fInfo.Extension.Equals(".csv"))
            {
                img = Image.FromFile("res\\csv_icon.png");
            }
            else return;

            Button btn = new Button();
            //btn.Location = new Point(0, button.Count * btnImportedRes.Height);
            btn.Width = btnImportedRes.Width;
            btn.Height = btnImportedRes.Height;
            btn.Image = img;
            btn.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = Path.GetFileNameWithoutExtension(filepath);
            btn.Tag = fInfo.Extension;
            btn.Click += new System.EventHandler(Button_Click);
            btn.Dock = DockStyle.Top;

            if (filepath.Equals(selectedFile))
            {
                btn.BackColor = Color.Silver;
                btn.Focus();
            }

            pnlImportedRes.Controls.Add(btn);
            button.Add(btn);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            initialBtnBack();
            Button btn = sender as Button;
            string strTemp = ".\\Resources\\" + btn.Text + btn.Tag;
            if (strTemp == selectedFile)
            {
                selectedFile = "";
                ((Button)sender).BackColor = Color.White;
            }
            else
            {
                selectedFile = strTemp;
                ((Button)sender).BackColor = Color.Silver;
            }
        }

        private void initialBtnBack()
        {
            foreach (Button btn in button)
            {
                btn.BackColor = Color.White;
            }
        }
    }
}
