namespace MeetManagerConnection
{
    partial class TestDb
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
            this.butSetMdb = new System.Windows.Forms.Button();
            this.txtMdbPath = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // butSetMdb
            // 
            this.butSetMdb.Location = new System.Drawing.Point(345, 10);
            this.butSetMdb.Name = "butSetMdb";
            this.butSetMdb.Size = new System.Drawing.Size(75, 23);
            this.butSetMdb.TabIndex = 0;
            this.butSetMdb.Text = "Set mdb";
            this.butSetMdb.UseVisualStyleBackColor = true;
            this.butSetMdb.Click += new System.EventHandler(this.butSetMdb_Click);
            // 
            // txtMdbPath
            // 
            this.txtMdbPath.Location = new System.Drawing.Point(13, 13);
            this.txtMdbPath.Name = "txtMdbPath";
            this.txtMdbPath.Size = new System.Drawing.Size(326, 20);
            this.txtMdbPath.TabIndex = 1;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(13, 40);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(407, 265);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // TestDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 317);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.txtMdbPath);
            this.Controls.Add(this.butSetMdb);
            this.Name = "TestDb";
            this.Text = "DB anbindung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSetMdb;
        private System.Windows.Forms.TextBox txtMdbPath;
        private System.Windows.Forms.RichTextBox rtbLog;

    }
}