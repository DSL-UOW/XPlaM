using System;
using System.Windows.Forms;

namespace PlanMiner
{
    partial class FrmAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAction));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblActionIfo = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlActionList = new System.Windows.Forms.Panel();
            this.btnCovertToText = new System.Windows.Forms.Button();
            this.btnActionLearning = new System.Windows.Forms.Button();
            this.btnConvertTxttoXML = new System.Windows.Forms.Button();
            this.btnSimilarityRec = new System.Windows.Forms.Button();
            this.btnAbdPlanRec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.btnOutput = new System.Windows.Forms.Button();
            this.pnlTopOutput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnInput3 = new System.Windows.Forms.Button();
            this.pnlTopinput = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInput2 = new System.Windows.Forms.Button();
            this.btnInput1 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlActionList.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.pnlTopOutput.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlTopinput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlInfo);
            this.panel2.Controls.Add(this.pnlActions);
            this.panel2.Controls.Add(this.pnlOutput);
            this.panel2.Controls.Add(this.pnlInput);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 449);
            this.panel2.TabIndex = 2;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblActionIfo);
            this.pnlInfo.Controls.Add(this.panel12);
            this.pnlInfo.Location = new System.Drawing.Point(44, 307);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(955, 128);
            this.pnlInfo.TabIndex = 11;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // lblActionIfo
            // 
            this.lblActionIfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblActionIfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionIfo.Location = new System.Drawing.Point(14, 49);
            this.lblActionIfo.Multiline = true;
            this.lblActionIfo.Name = "lblActionIfo";
            this.lblActionIfo.Size = new System.Drawing.Size(926, 10);
            this.lblActionIfo.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.panel12.Controls.Add(this.label2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(953, 34);
            this.panel12.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(394, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Action information";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.btnRun);
            this.pnlActions.Controls.Add(this.pnlActionList);
            this.pnlActions.Controls.Add(this.label7);
            this.pnlActions.Location = new System.Drawing.Point(270, 21);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(502, 280);
            this.pnlActions.TabIndex = 10;
            // 
            // btnRun
            // 
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(204, 238);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 28);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pnlActionList
            // 
            this.pnlActionList.AutoScroll = true;
            this.pnlActionList.Controls.Add(this.btnCovertToText);
            this.pnlActionList.Controls.Add(this.btnActionLearning);
            this.pnlActionList.Controls.Add(this.btnConvertTxttoXML);
            this.pnlActionList.Controls.Add(this.btnSimilarityRec);
            this.pnlActionList.Controls.Add(this.btnAbdPlanRec);
            this.pnlActionList.Location = new System.Drawing.Point(9, 59);
            this.pnlActionList.Name = "pnlActionList";
            this.pnlActionList.Size = new System.Drawing.Size(481, 166);
            this.pnlActionList.TabIndex = 0;
            this.pnlActionList.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActionList_Paint_1);
            // 
            // btnCovertToText
            // 
            this.btnCovertToText.BackColor = System.Drawing.Color.White;
            this.btnCovertToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCovertToText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCovertToText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCovertToText.Image = ((System.Drawing.Image)(resources.GetObject("btnCovertToText.Image")));
            this.btnCovertToText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCovertToText.Location = new System.Drawing.Point(0, 216);
            this.btnCovertToText.Name = "btnCovertToText";
            this.btnCovertToText.Size = new System.Drawing.Size(464, 54);
            this.btnCovertToText.TabIndex = 7;
            this.btnCovertToText.Tag = "pl_te";
            this.btnCovertToText.Text = "Convert AgentSpeak(L) Plan Library to Text";
            this.btnCovertToText.UseVisualStyleBackColor = false;
            this.btnCovertToText.Click += new System.EventHandler(this.btnCovertToText_Click_1);
            // 
            // btnActionLearning
            // 
            this.btnActionLearning.BackColor = System.Drawing.Color.White;
            this.btnActionLearning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActionLearning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActionLearning.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionLearning.Image = ((System.Drawing.Image)(resources.GetObject("btnActionLearning.Image")));
            this.btnActionLearning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActionLearning.Location = new System.Drawing.Point(0, 162);
            this.btnActionLearning.Name = "btnActionLearning";
            this.btnActionLearning.Size = new System.Drawing.Size(464, 54);
            this.btnActionLearning.TabIndex = 6;
            this.btnActionLearning.Tag = "ac_mo_le";
            this.btnActionLearning.Text = "Context Recognition";
            this.btnActionLearning.UseVisualStyleBackColor = false;
            this.btnActionLearning.Click += new System.EventHandler(this.btnActionLearning_Click);
            // 
            // btnConvertTxttoXML
            // 
            this.btnConvertTxttoXML.BackColor = System.Drawing.Color.White;
            this.btnConvertTxttoXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvertTxttoXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvertTxttoXML.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertTxttoXML.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertTxttoXML.Image")));
            this.btnConvertTxttoXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertTxttoXML.Location = new System.Drawing.Point(0, 108);
            this.btnConvertTxttoXML.Name = "btnConvertTxttoXML";
            this.btnConvertTxttoXML.Size = new System.Drawing.Size(464, 54);
            this.btnConvertTxttoXML.TabIndex = 4;
            this.btnConvertTxttoXML.Tag = "pl_xm";
            this.btnConvertTxttoXML.Text = "Convert AgentSpeak(L) Plan Library to XML";
            this.btnConvertTxttoXML.UseVisualStyleBackColor = false;
            this.btnConvertTxttoXML.Click += new System.EventHandler(this.btnConvertTxttoXML_Click);
            // 
            // btnSimilarityRec
            // 
            this.btnSimilarityRec.BackColor = System.Drawing.Color.White;
            this.btnSimilarityRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimilarityRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimilarityRec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimilarityRec.Image = ((System.Drawing.Image)(resources.GetObject("btnSimilarityRec.Image")));
            this.btnSimilarityRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimilarityRec.Location = new System.Drawing.Point(0, 54);
            this.btnSimilarityRec.Name = "btnSimilarityRec";
            this.btnSimilarityRec.Size = new System.Drawing.Size(464, 54);
            this.btnSimilarityRec.TabIndex = 3;
            this.btnSimilarityRec.Tag = "si_ab_rd_pl_re";
            this.btnSimilarityRec.Text = "Abducive Design of BDI Agents (Plus)";
            this.btnSimilarityRec.UseVisualStyleBackColor = false;
            this.btnSimilarityRec.Click += new System.EventHandler(this.btnSimilarityRec_Click);
            // 
            // btnAbdPlanRec
            // 
            this.btnAbdPlanRec.BackColor = System.Drawing.Color.White;
            this.btnAbdPlanRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbdPlanRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbdPlanRec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbdPlanRec.Image = ((System.Drawing.Image)(resources.GetObject("btnAbdPlanRec.Image")));
            this.btnAbdPlanRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbdPlanRec.Location = new System.Drawing.Point(0, 0);
            this.btnAbdPlanRec.Name = "btnAbdPlanRec";
            this.btnAbdPlanRec.Size = new System.Drawing.Size(464, 54);
            this.btnAbdPlanRec.TabIndex = 1;
            this.btnAbdPlanRec.Tag = "ab_de_bd";
            this.btnAbdPlanRec.Text = "Abducive Design of BDI Agents";
            this.btnAbdPlanRec.UseVisualStyleBackColor = false;
            this.btnAbdPlanRec.Click += new System.EventHandler(this.btnAbdPlanRec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(209, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Actions";
            // 
            // pnlOutput
            // 
            this.pnlOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutput.Controls.Add(this.btnOutput);
            this.pnlOutput.Controls.Add(this.pnlTopOutput);
            this.pnlOutput.Controls.Add(this.panel4);
            this.pnlOutput.Location = new System.Drawing.Point(750, 60);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(250, 200);
            this.pnlOutput.TabIndex = 9;
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.Transparent;
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnOutput.Location = new System.Drawing.Point(34, 52);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(200, 45);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutput.UseVisualStyleBackColor = false;
            // 
            // pnlTopOutput
            // 
            this.pnlTopOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.pnlTopOutput.Controls.Add(this.label1);
            this.pnlTopOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopOutput.Location = new System.Drawing.Point(0, 0);
            this.pnlTopOutput.Name = "pnlTopOutput";
            this.pnlTopOutput.Size = new System.Drawing.Size(248, 46);
            this.pnlTopOutput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Location = new System.Drawing.Point(-10, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1026, 118);
            this.panel4.TabIndex = 5;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnInput3);
            this.pnlInput.Controls.Add(this.pnlTopinput);
            this.pnlInput.Controls.Add(this.btnInput2);
            this.pnlInput.Controls.Add(this.btnInput1);
            this.pnlInput.Controls.Add(this.panel17);
            this.pnlInput.Location = new System.Drawing.Point(44, 59);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(250, 212);
            this.pnlInput.TabIndex = 4;
            // 
            // btnInput3
            // 
            this.btnInput3.BackColor = System.Drawing.Color.Transparent;
            this.btnInput3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnInput3.Location = new System.Drawing.Point(14, 153);
            this.btnInput3.Name = "btnInput3";
            this.btnInput3.Size = new System.Drawing.Size(200, 45);
            this.btnInput3.TabIndex = 9;
            this.btnInput3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInput3.UseVisualStyleBackColor = false;
            this.btnInput3.Click += new System.EventHandler(this.btnInput3_Click);
            // 
            // pnlTopinput
            // 
            this.pnlTopinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.pnlTopinput.Controls.Add(this.label8);
            this.pnlTopinput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopinput.Location = new System.Drawing.Point(0, 0);
            this.pnlTopinput.Name = "pnlTopinput";
            this.pnlTopinput.Size = new System.Drawing.Size(248, 46);
            this.pnlTopinput.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(97, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Input";
            // 
            // btnInput2
            // 
            this.btnInput2.BackColor = System.Drawing.Color.Transparent;
            this.btnInput2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnInput2.Location = new System.Drawing.Point(14, 102);
            this.btnInput2.Name = "btnInput2";
            this.btnInput2.Size = new System.Drawing.Size(200, 45);
            this.btnInput2.TabIndex = 7;
            this.btnInput2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInput2.UseVisualStyleBackColor = false;
            this.btnInput2.Click += new System.EventHandler(this.btnInput2_Click);
            // 
            // btnInput1
            // 
            this.btnInput1.BackColor = System.Drawing.Color.Transparent;
            this.btnInput1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnInput1.Location = new System.Drawing.Point(14, 52);
            this.btnInput1.Name = "btnInput1";
            this.btnInput1.Size = new System.Drawing.Size(200, 45);
            this.btnInput1.TabIndex = 6;
            this.btnInput1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInput1.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Lavender;
            this.panel17.Location = new System.Drawing.Point(-10, 265);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1026, 118);
            this.panel17.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Actions";
            // 
            // FrmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 547);
            this.Controls.Add(this.panel2);
            this.Name = "FrmAction";
            this.Text = "PlanMiner";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlActionList.ResumeLayout(false);
            this.pnlOutput.ResumeLayout(false);
            this.pnlTopOutput.ResumeLayout(false);
            this.pnlTopOutput.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlTopinput.ResumeLayout(false);
            this.pnlTopinput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlTopinput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInput2;
        private System.Windows.Forms.Button btnInput1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.Panel pnlTopOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlActionList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnAbdPlanRec;
        private System.Windows.Forms.Button btnSimilarityRec;
        private System.Windows.Forms.Button btnConvertTxttoXML;
        private System.Windows.Forms.Button btnActionLearning;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCovertToText;
        private Button btnInput3;
        private TextBox lblActionIfo;
    }
}