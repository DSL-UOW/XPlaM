namespace PlanMiner
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlResultInfo = new System.Windows.Forms.Panel();
            this.lblResHow_formView = new System.Windows.Forms.Label();
            this.lblResTime_formView = new System.Windows.Forms.Label();
            this.lblResext_formView = new System.Windows.Forms.Label();
            this.lblResName_formView = new System.Windows.Forms.Label();
            this.picRes_formView = new System.Windows.Forms.PictureBox();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlView.SuspendLayout();
            this.pnlResultInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes_formView)).BeginInit();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.pnlResultInfo);
            this.pnlView.Controls.Add(this.pnlResults);
            this.pnlView.Controls.Add(this.lblTitle);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlView.Location = new System.Drawing.Point(0, 98);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1049, 449);
            this.pnlView.TabIndex = 2;
            // 
            // pnlResultInfo
            // 
            this.pnlResultInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultInfo.Controls.Add(this.lblResHow_formView);
            this.pnlResultInfo.Controls.Add(this.lblResTime_formView);
            this.pnlResultInfo.Controls.Add(this.lblResext_formView);
            this.pnlResultInfo.Controls.Add(this.lblResName_formView);
            this.pnlResultInfo.Controls.Add(this.picRes_formView);
            this.pnlResultInfo.Location = new System.Drawing.Point(677, 72);
            this.pnlResultInfo.Name = "pnlResultInfo";
            this.pnlResultInfo.Size = new System.Drawing.Size(347, 344);
            this.pnlResultInfo.TabIndex = 4;
            // 
            // lblResHow_formView
            // 
            this.lblResHow_formView.AutoSize = true;
            this.lblResHow_formView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResHow_formView.Location = new System.Drawing.Point(76, 111);
            this.lblResHow_formView.Name = "lblResHow_formView";
            this.lblResHow_formView.Size = new System.Drawing.Size(41, 16);
            this.lblResHow_formView.TabIndex = 9;
            this.lblResHow_formView.Text = "label2";
            // 
            // lblResTime_formView
            // 
            this.lblResTime_formView.AutoSize = true;
            this.lblResTime_formView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTime_formView.Location = new System.Drawing.Point(76, 82);
            this.lblResTime_formView.Name = "lblResTime_formView";
            this.lblResTime_formView.Size = new System.Drawing.Size(41, 16);
            this.lblResTime_formView.TabIndex = 8;
            this.lblResTime_formView.Text = "label1";
            // 
            // lblResext_formView
            // 
            this.lblResext_formView.AutoSize = true;
            this.lblResext_formView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResext_formView.Location = new System.Drawing.Point(76, 51);
            this.lblResext_formView.Name = "lblResext_formView";
            this.lblResext_formView.Size = new System.Drawing.Size(41, 16);
            this.lblResext_formView.TabIndex = 7;
            this.lblResext_formView.Text = "label1";
            // 
            // lblResName_formView
            // 
            this.lblResName_formView.AutoSize = true;
            this.lblResName_formView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResName_formView.Location = new System.Drawing.Point(76, 24);
            this.lblResName_formView.Name = "lblResName_formView";
            this.lblResName_formView.Size = new System.Drawing.Size(54, 18);
            this.lblResName_formView.TabIndex = 6;
            this.lblResName_formView.Text = "label1";
            // 
            // picRes_formView
            // 
            this.picRes_formView.Location = new System.Drawing.Point(28, 37);
            this.picRes_formView.Name = "picRes_formView";
            this.picRes_formView.Size = new System.Drawing.Size(30, 30);
            this.picRes_formView.TabIndex = 5;
            this.picRes_formView.TabStop = false;
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.White;
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.dataGridView1);
            this.pnlResults.Controls.Add(this.txtEditor);
            this.pnlResults.Location = new System.Drawing.Point(59, 72);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(597, 344);
            this.pnlResults.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtEditor
            // 
            this.txtEditor.IsReadOnly = false;
            this.txtEditor.Location = new System.Drawing.Point(-1, -1);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(597, 344);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "textEditorControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "View";
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 547);
            this.Controls.Add(this.pnlView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmView";
            this.Text = "PlanMiner";
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlResultInfo.ResumeLayout(false);
            this.pnlResultInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes_formView)).EndInit();
            this.pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlResultInfo;
        private System.Windows.Forms.Label lblResTime_formView;
        private System.Windows.Forms.Label lblResext_formView;
        private System.Windows.Forms.Label lblResName_formView;
        private System.Windows.Forms.PictureBox picRes_formView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ICSharpCode.TextEditor.TextEditorControl txtEditor;
        private System.Windows.Forms.Label lblResHow_formView;
    }
}