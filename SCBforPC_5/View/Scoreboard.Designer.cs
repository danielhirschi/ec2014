namespace SCEG.ScoreboardPc.View
{
    partial class Scoreboard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.butOpenPort = new System.Windows.Forms.Button();
            this.lsbComPort = new System.Windows.Forms.ComboBox();
            this.lsbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butClosePort = new System.Windows.Forms.Button();
            this.txtTime8 = new System.Windows.Forms.TextBox();
            this.txtBahn8 = new System.Windows.Forms.TextBox();
            this.txtRang8 = new System.Windows.Forms.TextBox();
            this.txtTime7 = new System.Windows.Forms.TextBox();
            this.txtBahn7 = new System.Windows.Forms.TextBox();
            this.txtRang7 = new System.Windows.Forms.TextBox();
            this.txtTime6 = new System.Windows.Forms.TextBox();
            this.txtBahn6 = new System.Windows.Forms.TextBox();
            this.txtRang6 = new System.Windows.Forms.TextBox();
            this.txtTime5 = new System.Windows.Forms.TextBox();
            this.txtBahn5 = new System.Windows.Forms.TextBox();
            this.txtRang5 = new System.Windows.Forms.TextBox();
            this.txtTime4 = new System.Windows.Forms.TextBox();
            this.txtBahn4 = new System.Windows.Forms.TextBox();
            this.txtRang4 = new System.Windows.Forms.TextBox();
            this.txtTime3 = new System.Windows.Forms.TextBox();
            this.txtBahn3 = new System.Windows.Forms.TextBox();
            this.txtRang3 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.txtBahn2 = new System.Windows.Forms.TextBox();
            this.txtRang2 = new System.Windows.Forms.TextBox();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRennenNr = new System.Windows.Forms.TextBox();
            this.txtBahn1 = new System.Windows.Forms.TextBox();
            this.txtLaufNr = new System.Windows.Forms.TextBox();
            this.txtRang1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAktuelleZeit = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCommandsIgnored = new System.Windows.Forms.TextBox();
            this.txtCommandsSucces = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // butOpenPort
            // 
            this.butOpenPort.Location = new System.Drawing.Point(149, 18);
            this.butOpenPort.Name = "butOpenPort";
            this.butOpenPort.Size = new System.Drawing.Size(137, 23);
            this.butOpenPort.TabIndex = 0;
            this.butOpenPort.Text = "Open Port";
            this.butOpenPort.UseVisualStyleBackColor = true;
            this.butOpenPort.Click += new System.EventHandler(this.butOpenPort_Click);
            // 
            // lsbComPort
            // 
            this.lsbComPort.FormattingEnabled = true;
            this.lsbComPort.Location = new System.Drawing.Point(8, 21);
            this.lsbComPort.Name = "lsbComPort";
            this.lsbComPort.Size = new System.Drawing.Size(121, 21);
            this.lsbComPort.TabIndex = 14;
            this.lsbComPort.SelectedIndexChanged += new System.EventHandler(this.lsbComPort_SelectedIndexChanged);
            // 
            // lsbBaudRate
            // 
            this.lsbBaudRate.FormattingEnabled = true;
            this.lsbBaudRate.Location = new System.Drawing.Point(8, 72);
            this.lsbBaudRate.Name = "lsbBaudRate";
            this.lsbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.lsbBaudRate.TabIndex = 16;
            this.lsbBaudRate.SelectedIndexChanged += new System.EventHandler(this.lsbBaudRate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ComPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Baudrate";
            // 
            // butClosePort
            // 
            this.butClosePort.Location = new System.Drawing.Point(148, 47);
            this.butClosePort.Name = "butClosePort";
            this.butClosePort.Size = new System.Drawing.Size(137, 23);
            this.butClosePort.TabIndex = 28;
            this.butClosePort.Text = "Close Port";
            this.butClosePort.UseVisualStyleBackColor = true;
            this.butClosePort.Click += new System.EventHandler(this.button_ClosePort_Click);
            // 
            // txtTime8
            // 
            this.txtTime8.Location = new System.Drawing.Point(113, 306);
            this.txtTime8.Name = "txtTime8";
            this.txtTime8.ReadOnly = true;
            this.txtTime8.Size = new System.Drawing.Size(140, 20);
            this.txtTime8.TabIndex = 37;
            // 
            // txtBahn8
            // 
            this.txtBahn8.Location = new System.Drawing.Point(60, 307);
            this.txtBahn8.Name = "txtBahn8";
            this.txtBahn8.ReadOnly = true;
            this.txtBahn8.Size = new System.Drawing.Size(29, 20);
            this.txtBahn8.TabIndex = 36;
            // 
            // txtRang8
            // 
            this.txtRang8.Location = new System.Drawing.Point(8, 306);
            this.txtRang8.Name = "txtRang8";
            this.txtRang8.ReadOnly = true;
            this.txtRang8.Size = new System.Drawing.Size(31, 20);
            this.txtRang8.TabIndex = 35;
            // 
            // txtTime7
            // 
            this.txtTime7.Location = new System.Drawing.Point(113, 280);
            this.txtTime7.Name = "txtTime7";
            this.txtTime7.ReadOnly = true;
            this.txtTime7.Size = new System.Drawing.Size(140, 20);
            this.txtTime7.TabIndex = 34;
            // 
            // txtBahn7
            // 
            this.txtBahn7.Location = new System.Drawing.Point(60, 281);
            this.txtBahn7.Name = "txtBahn7";
            this.txtBahn7.ReadOnly = true;
            this.txtBahn7.Size = new System.Drawing.Size(29, 20);
            this.txtBahn7.TabIndex = 33;
            // 
            // txtRang7
            // 
            this.txtRang7.Location = new System.Drawing.Point(8, 280);
            this.txtRang7.Name = "txtRang7";
            this.txtRang7.ReadOnly = true;
            this.txtRang7.Size = new System.Drawing.Size(31, 20);
            this.txtRang7.TabIndex = 32;
            // 
            // txtTime6
            // 
            this.txtTime6.Location = new System.Drawing.Point(113, 254);
            this.txtTime6.Name = "txtTime6";
            this.txtTime6.ReadOnly = true;
            this.txtTime6.Size = new System.Drawing.Size(140, 20);
            this.txtTime6.TabIndex = 31;
            // 
            // txtBahn6
            // 
            this.txtBahn6.Location = new System.Drawing.Point(60, 255);
            this.txtBahn6.Name = "txtBahn6";
            this.txtBahn6.ReadOnly = true;
            this.txtBahn6.Size = new System.Drawing.Size(29, 20);
            this.txtBahn6.TabIndex = 30;
            // 
            // txtRang6
            // 
            this.txtRang6.Location = new System.Drawing.Point(8, 254);
            this.txtRang6.Name = "txtRang6";
            this.txtRang6.ReadOnly = true;
            this.txtRang6.Size = new System.Drawing.Size(31, 20);
            this.txtRang6.TabIndex = 29;
            // 
            // txtTime5
            // 
            this.txtTime5.Location = new System.Drawing.Point(113, 228);
            this.txtTime5.Name = "txtTime5";
            this.txtTime5.ReadOnly = true;
            this.txtTime5.Size = new System.Drawing.Size(140, 20);
            this.txtTime5.TabIndex = 28;
            // 
            // txtBahn5
            // 
            this.txtBahn5.Location = new System.Drawing.Point(60, 229);
            this.txtBahn5.Name = "txtBahn5";
            this.txtBahn5.ReadOnly = true;
            this.txtBahn5.Size = new System.Drawing.Size(29, 20);
            this.txtBahn5.TabIndex = 27;
            // 
            // txtRang5
            // 
            this.txtRang5.Location = new System.Drawing.Point(8, 228);
            this.txtRang5.Name = "txtRang5";
            this.txtRang5.ReadOnly = true;
            this.txtRang5.Size = new System.Drawing.Size(31, 20);
            this.txtRang5.TabIndex = 26;
            // 
            // txtTime4
            // 
            this.txtTime4.Location = new System.Drawing.Point(113, 202);
            this.txtTime4.Name = "txtTime4";
            this.txtTime4.ReadOnly = true;
            this.txtTime4.Size = new System.Drawing.Size(140, 20);
            this.txtTime4.TabIndex = 25;
            // 
            // txtBahn4
            // 
            this.txtBahn4.Location = new System.Drawing.Point(60, 203);
            this.txtBahn4.Name = "txtBahn4";
            this.txtBahn4.ReadOnly = true;
            this.txtBahn4.Size = new System.Drawing.Size(29, 20);
            this.txtBahn4.TabIndex = 24;
            // 
            // txtRang4
            // 
            this.txtRang4.Location = new System.Drawing.Point(8, 202);
            this.txtRang4.Name = "txtRang4";
            this.txtRang4.ReadOnly = true;
            this.txtRang4.Size = new System.Drawing.Size(31, 20);
            this.txtRang4.TabIndex = 23;
            // 
            // txtTime3
            // 
            this.txtTime3.Location = new System.Drawing.Point(113, 176);
            this.txtTime3.Name = "txtTime3";
            this.txtTime3.ReadOnly = true;
            this.txtTime3.Size = new System.Drawing.Size(140, 20);
            this.txtTime3.TabIndex = 22;
            // 
            // txtBahn3
            // 
            this.txtBahn3.Location = new System.Drawing.Point(60, 177);
            this.txtBahn3.Name = "txtBahn3";
            this.txtBahn3.ReadOnly = true;
            this.txtBahn3.Size = new System.Drawing.Size(29, 20);
            this.txtBahn3.TabIndex = 21;
            // 
            // txtRang3
            // 
            this.txtRang3.Location = new System.Drawing.Point(8, 176);
            this.txtRang3.Name = "txtRang3";
            this.txtRang3.ReadOnly = true;
            this.txtRang3.Size = new System.Drawing.Size(31, 20);
            this.txtRang3.TabIndex = 20;
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(113, 150);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.ReadOnly = true;
            this.txtTime2.Size = new System.Drawing.Size(140, 20);
            this.txtTime2.TabIndex = 19;
            // 
            // txtBahn2
            // 
            this.txtBahn2.Location = new System.Drawing.Point(60, 151);
            this.txtBahn2.Name = "txtBahn2";
            this.txtBahn2.ReadOnly = true;
            this.txtBahn2.Size = new System.Drawing.Size(29, 20);
            this.txtBahn2.TabIndex = 18;
            // 
            // txtRang2
            // 
            this.txtRang2.Location = new System.Drawing.Point(8, 150);
            this.txtRang2.Name = "txtRang2";
            this.txtRang2.ReadOnly = true;
            this.txtRang2.Size = new System.Drawing.Size(31, 20);
            this.txtRang2.TabIndex = 17;
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(113, 124);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.ReadOnly = true;
            this.txtTime1.Size = new System.Drawing.Size(140, 20);
            this.txtTime1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Lauf-Nr";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Zeit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Rennen-Nr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Bahn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rang";
            // 
            // txtRennenNr
            // 
            this.txtRennenNr.Location = new System.Drawing.Point(15, 30);
            this.txtRennenNr.Name = "txtRennenNr";
            this.txtRennenNr.ReadOnly = true;
            this.txtRennenNr.Size = new System.Drawing.Size(56, 20);
            this.txtRennenNr.TabIndex = 11;
            // 
            // txtBahn1
            // 
            this.txtBahn1.Location = new System.Drawing.Point(60, 125);
            this.txtBahn1.Name = "txtBahn1";
            this.txtBahn1.ReadOnly = true;
            this.txtBahn1.Size = new System.Drawing.Size(29, 20);
            this.txtBahn1.TabIndex = 10;
            // 
            // txtLaufNr
            // 
            this.txtLaufNr.Location = new System.Drawing.Point(113, 30);
            this.txtLaufNr.Name = "txtLaufNr";
            this.txtLaufNr.ReadOnly = true;
            this.txtLaufNr.Size = new System.Drawing.Size(55, 20);
            this.txtLaufNr.TabIndex = 9;
            // 
            // txtRang1
            // 
            this.txtRang1.Location = new System.Drawing.Point(8, 124);
            this.txtRang1.Name = "txtRang1";
            this.txtRang1.ReadOnly = true;
            this.txtRang1.Size = new System.Drawing.Size(31, 20);
            this.txtRang1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTime8);
            this.panel2.Controls.Add(this.txtRang1);
            this.panel2.Controls.Add(this.txtBahn8);
            this.panel2.Controls.Add(this.txtLaufNr);
            this.panel2.Controls.Add(this.txtRang8);
            this.panel2.Controls.Add(this.txtBahn3);
            this.panel2.Controls.Add(this.txtTime7);
            this.panel2.Controls.Add(this.txtBahn1);
            this.panel2.Controls.Add(this.txtBahn4);
            this.panel2.Controls.Add(this.txtRennenNr);
            this.panel2.Controls.Add(this.txtBahn2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBahn5);
            this.panel2.Controls.Add(this.txtRang7);
            this.panel2.Controls.Add(this.txtBahn7);
            this.panel2.Controls.Add(this.txtTime6);
            this.panel2.Controls.Add(this.txtBahn6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtRang6);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtTime5);
            this.panel2.Controls.Add(this.txtAktuelleZeit);
            this.panel2.Controls.Add(this.txtTime1);
            this.panel2.Controls.Add(this.txtRang2);
            this.panel2.Controls.Add(this.txtRang5);
            this.panel2.Controls.Add(this.txtTime4);
            this.panel2.Controls.Add(this.txtTime2);
            this.panel2.Controls.Add(this.txtRang3);
            this.panel2.Controls.Add(this.txtRang4);
            this.panel2.Controls.Add(this.txtTime3);
            this.panel2.Location = new System.Drawing.Point(21, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 343);
            this.panel2.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(110, 53);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Aktuell Zeit";
            // 
            // txtAktuelleZeit
            // 
            this.txtAktuelleZeit.Location = new System.Drawing.Point(113, 69);
            this.txtAktuelleZeit.Name = "txtAktuelleZeit";
            this.txtAktuelleZeit.ReadOnly = true;
            this.txtAktuelleZeit.Size = new System.Drawing.Size(140, 20);
            this.txtAktuelleZeit.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butClosePort);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.butOpenPort);
            this.panel3.Controls.Add(this.lsbComPort);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lsbBaudRate);
            this.panel3.Location = new System.Drawing.Point(21, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 107);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCommandsIgnored);
            this.panel4.Controls.Add(this.txtCommandsSucces);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(40, 529);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 100);
            this.panel4.TabIndex = 33;
            // 
            // txtCommandsIgnored
            // 
            this.txtCommandsIgnored.Location = new System.Drawing.Point(120, 47);
            this.txtCommandsIgnored.Name = "txtCommandsIgnored";
            this.txtCommandsIgnored.ReadOnly = true;
            this.txtCommandsIgnored.Size = new System.Drawing.Size(100, 20);
            this.txtCommandsIgnored.TabIndex = 38;
            // 
            // txtCommandsSucces
            // 
            this.txtCommandsSucces.Location = new System.Drawing.Point(8, 47);
            this.txtCommandsSucces.Name = "txtCommandsSucces";
            this.txtCommandsSucces.ReadOnly = true;
            this.txtCommandsSucces.Size = new System.Drawing.Size(100, 20);
            this.txtCommandsSucces.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ignoriert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Verarbeitet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Daten pro Minute";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 668);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard V5 - Copyright 2013 - Wirtten by M.Born";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpenPort;
        private System.Windows.Forms.ComboBox lsbComPort;
        private System.Windows.Forms.ComboBox lsbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butClosePort;
        private System.Windows.Forms.TextBox txtTime8;
        private System.Windows.Forms.TextBox txtBahn8;
        private System.Windows.Forms.TextBox txtRang8;
        private System.Windows.Forms.TextBox txtTime7;
        private System.Windows.Forms.TextBox txtBahn7;
        private System.Windows.Forms.TextBox txtRang7;
        private System.Windows.Forms.TextBox txtTime6;
        private System.Windows.Forms.TextBox txtBahn6;
        private System.Windows.Forms.TextBox txtRang6;
        private System.Windows.Forms.TextBox txtTime5;
        private System.Windows.Forms.TextBox txtBahn5;
        private System.Windows.Forms.TextBox txtRang5;
        private System.Windows.Forms.TextBox txtTime4;
        private System.Windows.Forms.TextBox txtBahn4;
        private System.Windows.Forms.TextBox txtRang4;
        private System.Windows.Forms.TextBox txtTime3;
        private System.Windows.Forms.TextBox txtBahn3;
        private System.Windows.Forms.TextBox txtRang3;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.TextBox txtBahn2;
        private System.Windows.Forms.TextBox txtRang2;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRennenNr;
        private System.Windows.Forms.TextBox txtBahn1;
        private System.Windows.Forms.TextBox txtLaufNr;
        private System.Windows.Forms.TextBox txtRang1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAktuelleZeit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCommandsIgnored;
        private System.Windows.Forms.TextBox txtCommandsSucces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

