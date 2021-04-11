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
using System.Xml.Serialization;

namespace PlanMiner
{
    public partial class FrmAction : Form
    {
        public FrmMain formMain;
        public string selectedFile, selectedFile1;
        public string statue = string.Empty;
        public Image imges;
        public string str_path2 = "";
        public FrmAction(string filepath, string filepath1)
        {
            InitializeComponent();
            lblActionIfo.MaximumSize = new Size(950, 0);
            lblActionIfo.AutoSize = true;

            initialBtnBack();
            this.selectedFile = filepath;
            this.selectedFile1 = filepath1;
            btnOutput.Visible = false;
            showButtonInfo(btnInput1, filepath);
            if (!string.IsNullOrEmpty(filepath1)) showButtonInfo(btnInput2, filepath1);
        }
        public void showButtonInfo(Button btn, string filepath)
        {
            FileInfo fInfo = new FileInfo(filepath);
            btn.Text = Path.GetFileNameWithoutExtension(filepath);

            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleCenter;

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
            btn.Image = imges;
        }

        private void btnAbdPlanRec_Click(object sender, EventArgs e)
        {
            btnOutput.Visible = false;
            initialBtnBack();
            ((Button)sender).BackColor = Color.Silver;
            lblActionIfo.Text = @"Abductive Design of BDI Agents involves some mechanism takes (1) A set of AgentSpeak(L) plans that serve as potential explanations, and (2) An observed action sequence that we want to explain, and infer a composite of plans and selection functions, such that the execution of these plans thus identified generates precisely the observed action sequence given the selection functions thus identified. " + Environment.NewLine + "\u25BA" + "Abductive Design of BDI Agent-based Digital Twins of Organizations. Alelaimat, A., Aditya Ghose, and Hoa Khanh Dam.";
            lblActionIfo.Dock = System.Windows.Forms.DockStyle.Fill;
            btnInput2.Text = "Action Sequence";
            btnInput2.TextAlign = ContentAlignment.MiddleCenter;
            btnOutput.Visible = true;
            btnOutput.Text = "Abductive BDI Design  ";
            btnOutput.Image = Image.FromFile("res\\txt_icon.png");
            btnOutput.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutput.TextAlign = ContentAlignment.MiddleRight;

            statue = ((Button)sender).Tag.ToString();

        }

        private void btnAbdSelectionRec_Click_1(object sender, EventArgs e)
        {
            btnOutput.Visible = false;
            initialBtnBack();
            ((Button)sender).BackColor = Color.Silver;
            lblActionIfo.Text = ((Button)sender).Text;

            statue = "";
            //btnInput1.Text = "Plan sequence";
            //btnInput1.Image = Image.FromFile("res\\xml_icon.png");
            //btnInput1.ImageAlign = ContentAlignment.MiddleLeft;
            //btnInput1.TextAlign = ContentAlignment.MiddleCenter;
            //btnInput2.Visible = false;
            //btnOutput.Text = "Agent Class";
            //btnOutput.Image = Image.FromFile("res\\java_icon.png");
            //btnOutput.ImageAlign = ContentAlignment.MiddleLeft;
            //btnOutput.TextAlign = ContentAlignment.MiddleCenter;
            //lblActionIfo.Visible = true;
            //lblActionIfo.Text = "Abducing BDI selections recognition allows inferring a way in which event, option, and intention selection functions can be customized";
        }

        private void btnSimilarityRec_Click(object sender, EventArgs e)
        {
            btnOutput.Visible = false;

            initialBtnBack();
            ((Button)sender).BackColor = Color.Silver;
            lblActionIfo.Text = ((Button)sender).Text;

            statue = "";
            //btnInput1.Text = "Action sequence";
            //btnInput1.Image = Image.FromFile("res\\csv_icon.png");
            //btnInput1.ImageAlign = ContentAlignment.MiddleLeft;
            //btnInput1.TextAlign = ContentAlignment.MiddleCenter;
            //btnInput2.Visible = true;
            //btnInput2.Text = "Plan library";
            //btnInput2.Image = Image.FromFile("res\\xml_icon.png");
            //btnInput2.ImageAlign = ContentAlignment.MiddleLeft;
            //btnInput2.TextAlign = ContentAlignment.MiddleCenter;
            //btnOutput.Text = "Plan sequence";
            //btnOutput.Image = Image.FromFile("res\\xml_icon.png");
            //btnOutput.ImageAlign = ContentAlignment.MiddleLeft;
            //btnOutput.TextAlign = ContentAlignment.MiddleCenter;
            //lblActionIfo.Visible = true;
        }

        private void btnConvertTxttoXML_Click(object sender, EventArgs e)
        {
            initialBtnBack();
            ((Button)sender).BackColor = Color.Silver;
            lblActionIfo.Text = "Serialize a text plan library to XML.";

            if (!Path.GetExtension(selectedFile).Equals(".txt"))
            {
                statue = "";
                return;
            }

            btnOutput.Visible = true;
            btnOutput.Text = Path.GetFileNameWithoutExtension(selectedFile);
            btnOutput.Image = Image.FromFile("res\\xml_icon.png");
            btnOutput.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutput.TextAlign = ContentAlignment.MiddleCenter;

            statue = ((Button)sender).Tag.ToString();
        }

        private void btnActionLearning_Click(object sender, EventArgs e)
        {
            initialBtnBack();
            ((Button)sender).BackColor = Color.Silver;
            lblActionIfo.Text = ((Button)sender).Text;
            btnInput2.Text = "Observation log";
            btnInput2.TextAlign = ContentAlignment.MiddleCenter;
            btnInput3.Text = "Knowledge base";
            btnInput3.TextAlign = ContentAlignment.MiddleCenter;
            btnInput3.Visible = true;
            btnOutput.Visible = true;
            btnOutput.Text = "Context Recognition  ";
            btnOutput.TextAlign = ContentAlignment.MiddleRight;
            btnOutput.Image = Image.FromFile("res\\xml_icon.png");
            btnOutput.ImageAlign = ContentAlignment.MiddleLeft;
            //btnOutput.TextAlign = ContentAlignment.MiddleCenter;
            lblActionIfo.Text = @"\n Context recognition takes (1) An AgentSpeak(L) plan library, (2) An alternative state-transition log, and (3) A knowledge base as input, and tries to annotate each action with it context conditions" + Environment.NewLine + "\u25BA"+ "Spelling Out the Context of BDI Agents Alelaimat, A., Aditya Ghose, and Hoa Khanh Dam.";
            lblActionIfo.Dock = System.Windows.Forms.DockStyle.Fill;

            statue = ((Button)sender).Tag.ToString();

        }
        private void btnCovertToText_Click_1(object sender, EventArgs e)
        {
            initialBtnBack();
            lblActionIfo.Text = "Deserialize an Xml plan library to Text.";
            ((Button)sender).BackColor = Color.Silver;
            if (!Path.GetExtension(selectedFile).Equals(".xml"))
            {
                statue = "";
                return;
            }

            btnOutput.Visible = true;
            btnOutput.Text = Path.GetFileNameWithoutExtension(selectedFile);
            btnOutput.Image = Image.FromFile("res\\xml_icon.png");
            btnOutput.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutput.TextAlign = ContentAlignment.MiddleCenter;

            statue = ((Button)sender).Tag.ToString();
        }

        private void initialBtnBack()
        {
            btnOutput.Visible = false;
            btnInput3.Visible = false;
            btnAbdPlanRec.BackColor = Color.White;
            //btnAbdSelectionRec.BackColor = Color.White;
            btnActionLearning.BackColor = Color.White;
            btnConvertTxttoXML.BackColor = Color.White;
            btnCovertToText.BackColor = Color.White;
            //btnPreferenceLearning.BackColor = Color.White;
            btnSimilarityRec.BackColor = Color.White;
            lblActionIfo.Text = "";
        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pnlActionList_Paint_1(object sender, PaintEventArgs e)
        {
        }
        private void lblActionIfo_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            

            if (statue.Equals("ab_de_bd"))
            {
                if (!Path.GetExtension(selectedFile).Equals(".xml") || string.IsNullOrEmpty(selectedFile1) || !Path.GetExtension(selectedFile1).Equals(".csv"))
                {
                    //statue = "";
                    MessageBox.Show("Please select correct file.");
                    return;
                }

                AbductivePlanRecognition abRec = new AbductivePlanRecognition(selectedFile, selectedFile1);
                string res = abRec.GegerateFile();
                if (string.IsNullOrEmpty(res))
                {
                    MessageBox.Show("Unsupported content type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                formMain.selectedFile = res;
                formMain.selectedFile1 = "";
                formMain.updated = true;
                formMain.showViewPanel();

            }
            else if (statue.Equals("ab_rd_se_re"))
            {

            }
            else if (statue.Equals("si_ab_rd_pl_re"))
            {

            }
            else if (statue.Equals("pl_xm"))
            {
                TextToXml tToX = new TextToXml(selectedFile);
                string res = tToX.GetXml();
                if (string.IsNullOrEmpty(res))
                {
                    MessageBox.Show("Unsupported content type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                formMain.selectedFile = res;
                formMain.updated = true;
                formMain.showViewPanel();

            }
            else if (statue.Equals("pr_rd_se_le"))
            {

            }
            else if (statue.Equals("ac_mo_le"))
            {
                if (!Path.GetExtension(selectedFile).Equals(".xml") || !Path.GetExtension(selectedFile1).Equals(".csv") || !Path.GetExtension(str_path2).Equals(".txt"))
                {
                    MessageBox.Show("Select correct file.");
                    statue = "";
                    return;
                }

                FrmContext frmCon = new FrmContext(selectedFile, selectedFile1, str_path2);
                frmCon.ShowDialog();
            }
            else if (statue.Equals("pl_te"))
            {
                XmlToText xToT = new XmlToText(selectedFile);
                string res = xToT.GetText();
                if (res.Substring(0, 6).Equals("Error "))
                {
                    MessageBox.Show("Unsupported content type: " + res.Substring(5));
                    return;
                }

                formMain.selectedFile = res;
                formMain.updated = true;
                formMain.showViewPanel();
            }
        }


        private void btnInput2_Click(object sender, EventArgs e)
        {
            FrmSelectResource frmSelect = new FrmSelectResource(this, 1);
            frmSelect.ShowDialog();
            if (!string.IsNullOrEmpty(selectedFile1)) showButtonInfo(btnInput2, selectedFile1);
            else
            {
                btnInput2.Text = "";
                btnInput2.Image = null;
            }
        }
        private void btnInput3_Click(object sender, EventArgs e)
        {
            FrmSelectResource frmSelect = new FrmSelectResource(this, 2);
            frmSelect.ShowDialog();
            if (!string.IsNullOrEmpty(str_path2)) showButtonInfo(btnInput3, str_path2);
            else
            {
                btnInput3.Text = "";
                btnInput3.Image = null;
            }

        }
    }
}
