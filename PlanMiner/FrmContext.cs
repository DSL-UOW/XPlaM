using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlanMiner
{
    public partial class FrmContext : Form
    {
        public string filepath1, filepath2, filepath3;
        public Thread thread1;
        public int threadStarted = 0;
        private bool stopProcess = false;
        
        private delegate void UpdateStatusDelegate( );
        private delegate void FinishThreadDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;
        private FinishThreadDelegate finishThreadDelegate = null;
        
        public List<string> checked_actor, listactor;
        public ContextThread conThread;
        public FrmContext( string path1, string path2, string path3)
        {
            InitializeComponent();
            this.filepath1 = path1;
            this.filepath2 = path2;
            this.filepath3 = path3;

            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
            finishThreadDelegate = new FinishThreadDelegate(this.EndTask);

            checked_actor = new List<string>(); listactor = new List<string>();
            foreach (string line in File.ReadLines(filepath2))
            {
                if (line.EndsWith("Actor")) continue;
                string[] temp = line.Split(',');
                if (listactor.Contains(temp[2].Trim()) || string.IsNullOrEmpty(temp[2])) continue;
                listactor.Add(temp[2].Trim());
            }
            checked_actor.AddRange(listactor);
            conThread = new ContextThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSelectAgent selagent = new FrmSelectAgent(checked_actor, listactor);
            selagent.frmcon = this;
            selagent.ShowDialog();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            if (stopProcess) return;
            if (threadStarted == 0)
            {
                this.stopProcess = false;

                // Initialise and start worker thread
                this.thread1 = new Thread(new ThreadStart(this.startCalc));
                this.thread1.Start();
                //this.thread1.Join();
                threadStarted = 1;
                button2.TextAlign = ContentAlignment.MiddleRight;
                button2.Text = "Pause     ";
                return;
            }

            if (thread1.ThreadState == ThreadState.Suspended)
            {
                thread1.Resume();
                button2.TextAlign = ContentAlignment.MiddleRight;
                button2.Text = "Pause     ";
            }
            else
            {
                button2.Text = "Resume   ";
                button2.TextAlign = ContentAlignment.MiddleRight;
                thread1.Suspend();
            }
            
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (threadStarted == 0)
            {
                this.Close();
                return;
            }
            if (stopProcess == false)
            {
                if (thread1.ThreadState == ThreadState.Running || thread1.ThreadState == ThreadState.WaitSleepJoin)
                {
                    thread1.Abort();
                }
                else
                {
                    stopProcess = true;
                    thread1.Resume();
                }
            }
            this.Close();
        }
        private void EndTask()
        {
            button2.Enabled = false;
        }
        private void UpdateStatus()
        {
            listBox1.Items.Add(output0);
            listBox1.Items.Add(agent);
        }

     
        string output0 = "", agent = "";
        private void startCalc()
        {
            bool flag = false;

            // The second input is Plan.XML
            var Hypotheses = XDocument.Load(filepath1).Descendants("Plan");
            if (Hypotheses == null) return;
            //var explain = new Dictionary<string, List<string>>();
            // mapping function
            Dictionary<string, List<string>> parent = (Dictionary<string, List<string>>)conThread.getParentDict(Hypotheses, filepath1, filepath2);

            var plLable = Hypotheses.Select(e => e.Attribute("lable").Value);
            
            List<string> Data = new List<string>();
            foreach (string line in File.ReadLines(filepath2))
            {
                if (this.stopProcess)
                {
                    thread1.Abort();
                    return;
                }
                string[] column = line.Split(',');
                if (column.Length < 2) return;
                if (!flag)
                {
                    flag = true;
                    continue;
                }
                string temp = column[1].Trim();
                //if (column[1].IndexOf("location") > -1) temp = column[1] + "," + column[2];
                //if (Data.Contains(temp)) continue;
                if (temp[temp.Length - 1] == ')')
                {
                    string action = temp.Substring(0, temp.IndexOf("("));
                    var me = Hypotheses.Where(e => e.Element("PlanBody").Elements("BodyLiteral").Any(ee => ee.Attribute("Type").Value == "action" && ee.Element("Name").Value == action))
                                        .Select(e => e.Attribute("lable").Value).First();
                    conThread.getPreCondition(Data, ref output0);
                    string strtemp = Hypotheses.Where(e => e.Attribute("lable").Value == me).Select(e => e.Element("Context").Value).Single();
                    conThread.checkContext(strtemp, ref output0);
                    strtemp = conThread.getParentContext(parent, Hypotheses, me, plLable);
                    conThread.checkContextParent(strtemp, ref output0);

                    while (true)
                    {
                        int t = 0;
                        foreach (var li in File.ReadLines(filepath3))
                        {
                            t += conThread.changeContext(li, ref output0);
                        }
                        if (t == 0) break;
                    }

                    conThread.repeatChecking(ref output0);
                    agent = column[2] + " doing " + temp;
                    if (checked_actor.Contains(column[2]))
                    {
                        this.Invoke(this.updateStatusDelegate);
                        Thread.Sleep(1000);
                    }

                    Data.Clear();
                }
                else Data.Insert(0, temp);
            }

            this.stopProcess = true;
            this.Invoke(this.finishThreadDelegate);
        }

        
    }
}
