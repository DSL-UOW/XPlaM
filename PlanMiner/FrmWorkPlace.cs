using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMiner
{
    public partial class FrmWorkPlace : Form
    {
        public string selectedFile;
        public FrmMain formMain;
        public FrmWorkPlace( String filepath)
        {
            InitializeComponent();
            lblResext.Visible = false;
            lblResName.Visible = false;
            lblResHow.Visible = false;
            lblResTime.Visible = false;
            picRes.Visible = false;
            btnDoAction.Visible = false;
            btnDoDelete.Visible = false;
            btnDoExport.Visible = false;
            btnDoView.Visible = false;
            btnImportedRes.Visible = false;

            this.selectedFile = filepath;
            
            toolTip1.SetToolTip(btnDoView, "View Resource");
            toolTip1.SetToolTip(btnDoAction, "Use Resource");
            toolTip1.SetToolTip(btnDoDelete, "Delete Resource");
            toolTip1.SetToolTip(btnDoExport, "Export to Disk");
            importAllBtn();
            showFileInfo(selectedFile);
        }

        List<Button> button;
        private void importAllBtn()
        {
            button = new List<Button>();
            foreach (string filepath in Directory.EnumerateFiles(".\\Resources", "*.*"))
            {
                createNewButton(filepath);
            }
            if (string.IsNullOrEmpty(selectedFile)) initialBtnBack();

        }

        private void createNewButton( string filepath)
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
            selectedFile = ".\\Resources\\" + btn.Text + btn.Tag;
            formMain.selectedFile = selectedFile;

            showFileInfo(selectedFile);
         
            ((Button)sender).BackColor = Color.Silver;
        }

        private void initialBtnBack()
        {
            foreach (Button btn in button)
            {
                btn.BackColor = Color.White;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File|*.csv|Text File|*.txt|XML File|*.xml|Java File|*.java";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strTemp= ".\\Resources\\" + Path.GetFileName(ofd.FileName);
                if (File.Exists(strTemp))
                {
                    MessageBox.Show("A resource with the same name already exists.");
                    return;
                }
                selectedFile = strTemp;
                formMain.selectedFile = selectedFile;

                File.Copy(ofd.FileName, selectedFile, true);
                initialBtnBack();
                createNewButton(selectedFile);
                showFileInfo(selectedFile);
            }
        }
        
        public Image imges;
        private void showFileInfo( string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) return;
            picRes.Visible = true;
            lblResext.Visible = true;
            lblResName.Visible = true;
            lblResTime.Visible = true;
            lblResHow.Visible = false;
            btnDoView.Visible = true;

            btnDoDelete.Visible = true;
            btnDoView.Visible = true;
            btnDoExport.Visible = true;
            btnDoAction.Visible = true;
            
            string ext = Path.GetExtension(filepath);
            lblResName.Text = Path.GetFileNameWithoutExtension(filepath);
            lblResext.Text = ext;
            FileInfo finfo = new FileInfo(filepath);
            lblResTime.Text = finfo.CreationTime.ToString();
            lblResHow.Text = "Imported, or generated by + name of the Action";

            
            FileInfo fInfo = new FileInfo(filepath);
            if (fInfo.Extension.Equals(".txt"))
            {
                imges = Image.FromFile("res\\txt_icon.png");
            }
            else if (fInfo.Extension.Equals(".xml"))
            {
                imges = Image.FromFile("res\\xml_icon.png");
            }
            else if (fInfo.Extension.Equals(".java"))
            {
                imges = Image.FromFile("res\\java_icon.png");
            }
            else if (fInfo.Extension.Equals(".csv"))
            {
                imges = Image.FromFile("res\\csv_icon.png");
            }
            picRes.Image = imges;
        }

        private void btnDoView_Click(object sender, EventArgs e)
        {
            formMain.initailBtnColor();
            formMain.showViewPanel();
        }

        private void btnDoDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete " + Path.GetFileName(selectedFile) + "?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (res == DialogResult.Cancel) return;

            foreach(Button btn in button)
            {
                if ( (btn.Text + btn.Tag).Equals(Path.GetFileName(selectedFile))) {
                    button.Remove(btn);
                    pnlImportedRes.Controls.Remove(btn);
                    break;
                }
            }
            File.Delete(selectedFile);
            if (selectedFile.Equals(formMain.selectedFile1))
                formMain.selectedFile = formMain.selectedFile1 = selectedFile = "";
            else formMain.selectedFile = selectedFile = "";
            
        }

        private void btnDoExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "CSV File|*.csv|Text File|*.txt|XML File|*.xml|Java File|*.java";
            string ext = Path.GetExtension(selectedFile).ToLower();
            if (ext.Equals(".csv")) ofd.FilterIndex = 1;
            else if (ext.Equals(".txt")) ofd.FilterIndex = 2;
            else if (ext.Equals(".xml")) ofd.FilterIndex = 3;
            else if (ext.Equals(".java")) ofd.FilterIndex =4;
            

            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.Copy(selectedFile, ofd.FileName, true);
                MessageBox.Show("Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDoAction_Click(object sender, EventArgs e)
        {
            formMain.initailBtnColor();
            formMain.showActionPanel();
        }
    }
}
