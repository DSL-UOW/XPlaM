namespace PlanMiner
{
    partial class FrmWorkPlace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkPlace));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlImportedRes = new System.Windows.Forms.Panel();
            this.btnImportedRes = new System.Windows.Forms.Button();
            this.pnlResControls = new System.Windows.Forms.Panel();
            this.btnDoExport = new System.Windows.Forms.Button();
            this.btnDoDelete = new System.Windows.Forms.Button();
            this.btnDoAction = new System.Windows.Forms.Button();
            this.btnDoView = new System.Windows.Forms.Button();
            this.lblResHow = new System.Windows.Forms.Label();
            this.lblResTime = new System.Windows.Forms.Label();
            this.lblResext = new System.Windows.Forms.Label();
            this.lblResName = new System.Windows.Forms.Label();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlImportedRes.SuspendLayout();
            this.pnlResControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WorkPlace";
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(986, 14);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(39, 37);
            this.btnImport.TabIndex = 1;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlImportedRes
            // 
            this.pnlImportedRes.AutoScroll = true;
            this.pnlImportedRes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlImportedRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImportedRes.Controls.Add(this.btnImportedRes);
            this.pnlImportedRes.Location = new System.Drawing.Point(39, 72);
            this.pnlImportedRes.Name = "pnlImportedRes";
            this.pnlImportedRes.Size = new System.Drawing.Size(617, 344);
            this.pnlImportedRes.TabIndex = 2;
            // 
            // btnImportedRes
            // 
            this.btnImportedRes.BackColor = System.Drawing.Color.White;
            this.btnImportedRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportedRes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportedRes.Location = new System.Drawing.Point(0, 0);
            this.btnImportedRes.Name = "btnImportedRes";
            this.btnImportedRes.Size = new System.Drawing.Size(615, 63);
            this.btnImportedRes.TabIndex = 0;
            this.btnImportedRes.UseVisualStyleBackColor = false;
            // 
            // pnlResControls
            // 
            this.pnlResControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResControls.Controls.Add(this.btnDoExport);
            this.pnlResControls.Controls.Add(this.btnDoDelete);
            this.pnlResControls.Controls.Add(this.btnDoAction);
            this.pnlResControls.Controls.Add(this.btnDoView);
            this.pnlResControls.Controls.Add(this.lblResHow);
            this.pnlResControls.Controls.Add(this.lblResTime);
            this.pnlResControls.Controls.Add(this.lblResext);
            this.pnlResControls.Controls.Add(this.lblResName);
            this.pnlResControls.Controls.Add(this.picRes);
            this.pnlResControls.Location = new System.Drawing.Point(677, 72);
            this.pnlResControls.Name = "pnlResControls";
            this.pnlResControls.Size = new System.Drawing.Size(347, 344);
            this.pnlResControls.TabIndex = 3;
            // 
            // btnDoExport
            // 
            this.btnDoExport.FlatAppearance.BorderSize = 0;
            this.btnDoExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoExport.Image = ((System.Drawing.Image)(resources.GetObject("btnDoExport.Image")));
            this.btnDoExport.Location = new System.Drawing.Point(164, 169);
            this.btnDoExport.Name = "btnDoExport";
            this.btnDoExport.Size = new System.Drawing.Size(26, 26);
            this.btnDoExport.TabIndex = 8;
            this.btnDoExport.UseVisualStyleBackColor = true;
            this.btnDoExport.Click += new System.EventHandler(this.btnDoExport_Click);
            // 
            // btnDoDelete
            // 
            this.btnDoDelete.FlatAppearance.BorderSize = 0;
            this.btnDoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDoDelete.Image")));
            this.btnDoDelete.Location = new System.Drawing.Point(132, 169);
            this.btnDoDelete.Name = "btnDoDelete";
            this.btnDoDelete.Size = new System.Drawing.Size(26, 26);
            this.btnDoDelete.TabIndex = 7;
            this.btnDoDelete.UseVisualStyleBackColor = true;
            this.btnDoDelete.Click += new System.EventHandler(this.btnDoDelete_Click);
            // 
            // btnDoAction
            // 
            this.btnDoAction.FlatAppearance.BorderSize = 0;
            this.btnDoAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoAction.Image = ((System.Drawing.Image)(resources.GetObject("btnDoAction.Image")));
            this.btnDoAction.Location = new System.Drawing.Point(100, 169);
            this.btnDoAction.Name = "btnDoAction";
            this.btnDoAction.Size = new System.Drawing.Size(26, 26);
            this.btnDoAction.TabIndex = 6;
            this.btnDoAction.UseVisualStyleBackColor = true;
            this.btnDoAction.Click += new System.EventHandler(this.btnDoAction_Click);
            // 
            // btnDoView
            // 
            this.btnDoView.FlatAppearance.BorderSize = 0;
            this.btnDoView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoView.Image = ((System.Drawing.Image)(resources.GetObject("btnDoView.Image")));
            this.btnDoView.Location = new System.Drawing.Point(68, 169);
            this.btnDoView.Name = "btnDoView";
            this.btnDoView.Size = new System.Drawing.Size(26, 26);
            this.btnDoView.TabIndex = 5;
            this.btnDoView.UseVisualStyleBackColor = true;
            this.btnDoView.Click += new System.EventHandler(this.btnDoView_Click);
            // 
            // lblResHow
            // 
            this.lblResHow.AutoSize = true;
            this.lblResHow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResHow.Location = new System.Drawing.Point(65, 107);
            this.lblResHow.Name = "lblResHow";
            this.lblResHow.Size = new System.Drawing.Size(41, 16);
            this.lblResHow.TabIndex = 4;
            this.lblResHow.Text = "label2";
            // 
            // lblResTime
            // 
            this.lblResTime.AutoSize = true;
            this.lblResTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTime.Location = new System.Drawing.Point(65, 78);
            this.lblResTime.Name = "lblResTime";
            this.lblResTime.Size = new System.Drawing.Size(41, 16);
            this.lblResTime.TabIndex = 3;
            this.lblResTime.Text = "label1";
            // 
            // lblResext
            // 
            this.lblResext.AutoSize = true;
            this.lblResext.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResext.Location = new System.Drawing.Point(65, 47);
            this.lblResext.Name = "lblResext";
            this.lblResext.Size = new System.Drawing.Size(41, 16);
            this.lblResext.TabIndex = 2;
            this.lblResext.Text = "label1";
            // 
            // lblResName
            // 
            this.lblResName.AutoSize = true;
            this.lblResName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResName.Location = new System.Drawing.Point(65, 20);
            this.lblResName.Name = "lblResName";
            this.lblResName.Size = new System.Drawing.Size(54, 18);
            this.lblResName.TabIndex = 1;
            this.lblResName.Text = "label1";
            // 
            // picRes
            // 
            this.picRes.Location = new System.Drawing.Point(17, 33);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(30, 30);
            this.picRes.TabIndex = 0;
            this.picRes.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlImportedRes);
            this.panel2.Controls.Add(this.pnlResControls);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 449);
            this.panel2.TabIndex = 1;
            // 
            // FrmWorkPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 547);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWorkPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanMiner";
            this.pnlImportedRes.ResumeLayout(false);
            this.pnlResControls.ResumeLayout(false);
            this.pnlResControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlImportedRes;
        private System.Windows.Forms.Button btnImportedRes;
        private System.Windows.Forms.Panel pnlResControls;
        private System.Windows.Forms.Button btnDoExport;
        private System.Windows.Forms.Button btnDoDelete;
        private System.Windows.Forms.Button btnDoAction;
        private System.Windows.Forms.Button btnDoView;
        private System.Windows.Forms.Label lblResHow;
        private System.Windows.Forms.Label lblResTime;
        private System.Windows.Forms.Label lblResext;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.PictureBox picRes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}