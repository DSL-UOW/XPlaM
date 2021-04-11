namespace PlanMiner
{
    partial class FrmSelectResource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectResource));
            this.pnlImportedRes = new System.Windows.Forms.Panel();
            this.btnImportedRes = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlImportedRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImportedRes
            // 
            this.pnlImportedRes.AutoScroll = true;
            this.pnlImportedRes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlImportedRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImportedRes.Controls.Add(this.btnImportedRes);
            this.pnlImportedRes.Location = new System.Drawing.Point(17, 44);
            this.pnlImportedRes.Name = "pnlImportedRes";
            this.pnlImportedRes.Size = new System.Drawing.Size(613, 395);
            this.pnlImportedRes.TabIndex = 3;
            // 
            // btnImportedRes
            // 
            this.btnImportedRes.BackColor = System.Drawing.Color.White;
            this.btnImportedRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportedRes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportedRes.Location = new System.Drawing.Point(0, 0);
            this.btnImportedRes.Name = "btnImportedRes";
            this.btnImportedRes.Size = new System.Drawing.Size(611, 63);
            this.btnImportedRes.TabIndex = 0;
            this.btnImportedRes.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.Location = new System.Drawing.Point(528, 445);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(101, 28);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Select      ";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(18, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel    ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Select resource";
            // 
            // FrmSelectResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 483);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.pnlImportedRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelectResource";
            this.Text = "FrmSelectResource";
            this.pnlImportedRes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImportedRes;
        private System.Windows.Forms.Button btnImportedRes;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
    }
}