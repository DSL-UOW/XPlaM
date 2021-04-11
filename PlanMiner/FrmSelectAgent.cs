using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanMiner
{
    public partial class FrmSelectAgent : Form
    {
        List<string> selectedactor = new List<string>(), listactor;
        public FrmContext frmcon;
        public FrmSelectAgent(List<string> selectedactor, List<string> listactor)
        {
            InitializeComponent();
            this.selectedactor.AddRange(selectedactor);
            this.listactor = listactor;
            if (selectedactor.Count == listactor.Count) treeView1.Nodes[0].Checked = true;
            foreach( string nod  in listactor)
            {
                //treeView1.Nodes.Add(nod);
                treeView1.Nodes[0].Nodes.Add(nod);
                if (selectedactor.Contains(nod))
                {
                    treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Checked = true;
                }
            }
            treeView1.Nodes[0].Expand();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var nod = e.Node;
            if (nod.Text == "All")
            {
                foreach (TreeNode n in treeView1.Nodes[0].Nodes)
                {
                    n.Checked = nod.Checked;
                }
            }
            else
            {
                bool pare = true;
                foreach (TreeNode n in treeView1.Nodes[0].Nodes)
                {
                    if (n.Checked == false)
                    {
                        pare = false;
                        break;
                    }
                }
                treeView1.Nodes[0].Checked = pare;
            }
            treeView1.EndUpdate();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            selectedactor.Clear();
            foreach (TreeNode nod in treeView1.Nodes[0].Nodes)
            {
                if (nod.Checked == false) continue;
                selectedactor.Add(nod.Text);
            }
            if (selectedactor.Count == 0)
            {
                MessageBox.Show("You need to select one at least.");
                return;
            }
            frmcon.checked_actor.Clear();
            frmcon.checked_actor.AddRange( selectedactor);
            this.Close();

        }
    }
}
