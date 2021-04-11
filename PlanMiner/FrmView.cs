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
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();

            pnlResults.AutoScroll = true;
            txtEditor.Visible = false;
            txtEditor.Font = new Font("Consolas", 9);
            txtEditor.IsReadOnly = true;
            //txtEditor.Location = new Point(0, 0);
            //txtEditor.Size = new Size(this.Width, this.Height);

            dataGridView1.Visible = false;
            dataGridView1.ReadOnly = true;
            //dataGridView1.Location = new Point(0, 0);
            //dataGridView1.Size = new Size(this.Width, this.Height);

            lblResext_formView.Visible = false;
            lblResName_formView.Visible = false;
            lblResHow_formView.Visible = false;
            lblResTime_formView.Visible = false;
            picRes_formView.Visible = false;
        }


        public Image imgs;
        public void ShowFileContent(string filepath)
        {
            pnlResults.AutoScroll = false;
            if (string.IsNullOrEmpty(filepath)) return;
            if (Path.GetExtension(filepath).Equals(".csv"))
            {
                dataGridView1.Visible = true;
                
                OleDbConnection conn = new OleDbConnection
                       ("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " +
                         Path.GetDirectoryName(filepath) +
                         "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");

                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + Path.GetFileName(filepath), conn);

                DataSet ds = new DataSet("Temp");
                adapter.Fill(ds);

                conn.Close();

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Table";
            }
            else
            {
                txtEditor.Visible = true;
                string strFileContent = File.ReadAllText(filepath);
                txtEditor.LoadFile(filepath);
            }

            lblResext_formView.Visible = true;
            lblResName_formView.Visible = true;
            lblResHow_formView.Visible = false;
            lblResTime_formView.Visible = true;
            picRes_formView.Visible = true;

            lblResName_formView.Text = Path.GetFileNameWithoutExtension(filepath);
            lblResext_formView.Text = Path.GetExtension(filepath);
            FileInfo finfo = new FileInfo(filepath);
            lblResTime_formView.Text = finfo.CreationTime.ToString();
            

            FileInfo fInfo = new FileInfo(filepath);
            if (fInfo.Extension.Equals(".txt"))
            {
                imgs = Image.FromFile("res\\txt_icon.png");
            }
            else if (fInfo.Extension.Equals(".xml"))
            {
                imgs = Image.FromFile("res\\xml_icon.png");
            }
            else if (fInfo.Extension.Equals(".java"))
            {
                imgs = Image.FromFile("res\\java_icon.png");
            }
            else if (fInfo.Extension.Equals(".csv"))
            {
                imgs = Image.FromFile("res\\csv_icon.png");
            }
            picRes_formView.Image = imgs;
        }
    }
}
