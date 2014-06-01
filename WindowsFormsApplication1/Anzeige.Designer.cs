namespace WindowsFormsApplication1
{
    partial class Anzeige
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
            this.timersponsoren = new System.Windows.Forms.Timer(this.components);
            this.panel_sponsoren = new System.Windows.Forms.Panel();
            this.pictureBox_Sponsoren = new System.Windows.Forms.PictureBox();
            this.timerzwischenzeit = new System.Windows.Forms.Timer(this.components);
            this.lblRemark = new System.Windows.Forms.Label();
            this.pnlLane8 = new System.Windows.Forms.Panel();
            this.lblLane8 = new System.Windows.Forms.Label();
            this.panel_rang8 = new System.Windows.Forms.Panel();
            this.lbl_rang8 = new System.Windows.Forms.Label();
            this.panel_rang7 = new System.Windows.Forms.Panel();
            this.lbl_rang7 = new System.Windows.Forms.Label();
            this.panel_rang6 = new System.Windows.Forms.Panel();
            this.lbl_rang6 = new System.Windows.Forms.Label();
            this.panel_rang5 = new System.Windows.Forms.Panel();
            this.lbl_rang5 = new System.Windows.Forms.Label();
            this.panel_rang4 = new System.Windows.Forms.Panel();
            this.lbl_rang4 = new System.Windows.Forms.Label();
            this.panel_rang3 = new System.Windows.Forms.Panel();
            this.lbl_rang3 = new System.Windows.Forms.Label();
            this.panel_rang2 = new System.Windows.Forms.Panel();
            this.lbl_rang2 = new System.Windows.Forms.Label();
            this.panel_rang1 = new System.Windows.Forms.Panel();
            this.lbl_rang1 = new System.Windows.Forms.Label();
            this.panel_disziplin = new System.Windows.Forms.Panel();
            this.label_disziplin = new System.Windows.Forms.Label();
            this.panel_status = new System.Windows.Forms.Panel();
            this.lbl_lauf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rennen = new System.Windows.Forms.Label();
            this.panelzeit = new System.Windows.Forms.Panel();
            this.lbl_Zeit = new System.Windows.Forms.Label();
            this.panel_uhr = new System.Windows.Forms.Panel();
            this.lbl_uhr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLane7 = new System.Windows.Forms.Panel();
            this.lblLane7 = new System.Windows.Forms.Label();
            this.pnlLane6 = new System.Windows.Forms.Panel();
            this.lblLane6 = new System.Windows.Forms.Label();
            this.pnlLane5 = new System.Windows.Forms.Panel();
            this.lblLane5 = new System.Windows.Forms.Label();
            this.pnlLane4 = new System.Windows.Forms.Panel();
            this.lblLane4 = new System.Windows.Forms.Label();
            this.pnlLane3 = new System.Windows.Forms.Panel();
            this.lblLane3 = new System.Windows.Forms.Label();
            this.pnlLane2 = new System.Windows.Forms.Panel();
            this.lblLane2 = new System.Windows.Forms.Label();
            this.pnlLane1 = new System.Windows.Forms.Panel();
            this.lblLane1 = new System.Windows.Forms.Label();
            this.timerLanes = new System.Windows.Forms.Timer(this.components);
            this.timerSponsorenPause = new System.Windows.Forms.Timer(this.components);
            this.panel_sponsoren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sponsoren)).BeginInit();
            this.pnlLane8.SuspendLayout();
            this.panel_rang8.SuspendLayout();
            this.panel_rang7.SuspendLayout();
            this.panel_rang6.SuspendLayout();
            this.panel_rang5.SuspendLayout();
            this.panel_rang4.SuspendLayout();
            this.panel_rang3.SuspendLayout();
            this.panel_rang2.SuspendLayout();
            this.panel_rang1.SuspendLayout();
            this.panel_disziplin.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.panelzeit.SuspendLayout();
            this.panel_uhr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLane7.SuspendLayout();
            this.pnlLane6.SuspendLayout();
            this.pnlLane5.SuspendLayout();
            this.pnlLane4.SuspendLayout();
            this.pnlLane3.SuspendLayout();
            this.pnlLane2.SuspendLayout();
            this.pnlLane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timersponsoren
            // 
            this.timersponsoren.Interval = 5000;
            this.timersponsoren.Tick += new System.EventHandler(this.timersponsoren_Tick);
            // 
            // panel_sponsoren
            // 
            this.panel_sponsoren.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_sponsoren.Controls.Add(this.pictureBox_Sponsoren);
            this.panel_sponsoren.Location = new System.Drawing.Point(229, 23);
            this.panel_sponsoren.Name = "panel_sponsoren";
            this.panel_sponsoren.Size = new System.Drawing.Size(360, 137);
            this.panel_sponsoren.TabIndex = 8;
            this.panel_sponsoren.Visible = false;
            // 
            // pictureBox_Sponsoren
            // 
            this.pictureBox_Sponsoren.Location = new System.Drawing.Point(3, 23);
            this.pictureBox_Sponsoren.Name = "pictureBox_Sponsoren";
            this.pictureBox_Sponsoren.Size = new System.Drawing.Size(354, 114);
            this.pictureBox_Sponsoren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Sponsoren.TabIndex = 5;
            this.pictureBox_Sponsoren.TabStop = false;
            // 
            // timerzwischenzeit
            // 
            this.timerzwischenzeit.Interval = 500;
            this.timerzwischenzeit.Tick += new System.EventHandler(this.timerzwischenzeit_Tick);
            // 
            // lblRemark
            // 
            this.lblRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemark.Location = new System.Drawing.Point(19, 554);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(712, 23);
            this.lblRemark.TabIndex = 16;
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemark.Visible = false;
            // 
            // pnlLane8
            // 
            this.pnlLane8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane8.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane8.Controls.Add(this.lblLane8);
            this.pnlLane8.Location = new System.Drawing.Point(28, 523);
            this.pnlLane8.Name = "pnlLane8";
            this.pnlLane8.Size = new System.Drawing.Size(347, 27);
            this.pnlLane8.TabIndex = 17;
            this.pnlLane8.Visible = false;
            // 
            // lblLane8
            // 
            this.lblLane8.AutoSize = true;
            this.lblLane8.BackColor = System.Drawing.Color.Transparent;
            this.lblLane8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane8.Location = new System.Drawing.Point(7, 6);
            this.lblLane8.Name = "lblLane8";
            this.lblLane8.Size = new System.Drawing.Size(59, 16);
            this.lblLane8.TabIndex = 7;
            this.lblLane8.Text = "label10";
            this.lblLane8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang8
            // 
            this.panel_rang8.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang8.Controls.Add(this.lbl_rang8);
            this.panel_rang8.Location = new System.Drawing.Point(28, 217);
            this.panel_rang8.Name = "panel_rang8";
            this.panel_rang8.Size = new System.Drawing.Size(120, 27);
            this.panel_rang8.TabIndex = 12;
            this.panel_rang8.Visible = false;
            // 
            // lbl_rang8
            // 
            this.lbl_rang8.AutoSize = true;
            this.lbl_rang8.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang8.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang8.Name = "lbl_rang8";
            this.lbl_rang8.Size = new System.Drawing.Size(59, 16);
            this.lbl_rang8.TabIndex = 7;
            this.lbl_rang8.Text = "label10";
            this.lbl_rang8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang7
            // 
            this.panel_rang7.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang7.Controls.Add(this.lbl_rang7);
            this.panel_rang7.Location = new System.Drawing.Point(28, 189);
            this.panel_rang7.Name = "panel_rang7";
            this.panel_rang7.Size = new System.Drawing.Size(120, 27);
            this.panel_rang7.TabIndex = 15;
            this.panel_rang7.Visible = false;
            // 
            // lbl_rang7
            // 
            this.lbl_rang7.AutoSize = true;
            this.lbl_rang7.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang7.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang7.Name = "lbl_rang7";
            this.lbl_rang7.Size = new System.Drawing.Size(51, 16);
            this.lbl_rang7.TabIndex = 7;
            this.lbl_rang7.Text = "label9";
            this.lbl_rang7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang6
            // 
            this.panel_rang6.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang6.Controls.Add(this.lbl_rang6);
            this.panel_rang6.Location = new System.Drawing.Point(28, 161);
            this.panel_rang6.Name = "panel_rang6";
            this.panel_rang6.Size = new System.Drawing.Size(120, 27);
            this.panel_rang6.TabIndex = 14;
            this.panel_rang6.Visible = false;
            // 
            // lbl_rang6
            // 
            this.lbl_rang6.AutoSize = true;
            this.lbl_rang6.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang6.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang6.Name = "lbl_rang6";
            this.lbl_rang6.Size = new System.Drawing.Size(51, 16);
            this.lbl_rang6.TabIndex = 7;
            this.lbl_rang6.Text = "label8";
            this.lbl_rang6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang5
            // 
            this.panel_rang5.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang5.Controls.Add(this.lbl_rang5);
            this.panel_rang5.Location = new System.Drawing.Point(28, 133);
            this.panel_rang5.Name = "panel_rang5";
            this.panel_rang5.Size = new System.Drawing.Size(120, 27);
            this.panel_rang5.TabIndex = 13;
            this.panel_rang5.Visible = false;
            // 
            // lbl_rang5
            // 
            this.lbl_rang5.AutoSize = true;
            this.lbl_rang5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang5.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang5.Name = "lbl_rang5";
            this.lbl_rang5.Size = new System.Drawing.Size(51, 16);
            this.lbl_rang5.TabIndex = 7;
            this.lbl_rang5.Text = "label7";
            this.lbl_rang5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang4
            // 
            this.panel_rang4.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang4.Controls.Add(this.lbl_rang4);
            this.panel_rang4.Location = new System.Drawing.Point(28, 105);
            this.panel_rang4.Name = "panel_rang4";
            this.panel_rang4.Size = new System.Drawing.Size(120, 27);
            this.panel_rang4.TabIndex = 12;
            this.panel_rang4.Visible = false;
            // 
            // lbl_rang4
            // 
            this.lbl_rang4.AutoSize = true;
            this.lbl_rang4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang4.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang4.Name = "lbl_rang4";
            this.lbl_rang4.Size = new System.Drawing.Size(51, 16);
            this.lbl_rang4.TabIndex = 7;
            this.lbl_rang4.Text = "label6";
            this.lbl_rang4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang3
            // 
            this.panel_rang3.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang3.Controls.Add(this.lbl_rang3);
            this.panel_rang3.Location = new System.Drawing.Point(28, 77);
            this.panel_rang3.Name = "panel_rang3";
            this.panel_rang3.Size = new System.Drawing.Size(120, 27);
            this.panel_rang3.TabIndex = 12;
            this.panel_rang3.Visible = false;
            // 
            // lbl_rang3
            // 
            this.lbl_rang3.AutoSize = true;
            this.lbl_rang3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang3.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang3.Name = "lbl_rang3";
            this.lbl_rang3.Size = new System.Drawing.Size(51, 16);
            this.lbl_rang3.TabIndex = 7;
            this.lbl_rang3.Text = "label5";
            this.lbl_rang3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang2
            // 
            this.panel_rang2.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang2.Controls.Add(this.lbl_rang2);
            this.panel_rang2.Location = new System.Drawing.Point(28, 49);
            this.panel_rang2.Name = "panel_rang2";
            this.panel_rang2.Size = new System.Drawing.Size(120, 27);
            this.panel_rang2.TabIndex = 12;
            this.panel_rang2.Visible = false;
            // 
            // lbl_rang2
            // 
            this.lbl_rang2.AutoSize = true;
            this.lbl_rang2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang2.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang2.Name = "lbl_rang2";
            this.lbl_rang2.Size = new System.Drawing.Size(51, 16);
            this.lbl_rang2.TabIndex = 7;
            this.lbl_rang2.Text = "label4";
            this.lbl_rang2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_rang1
            // 
            this.panel_rang1.BackColor = System.Drawing.Color.Transparent;
            this.panel_rang1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_rang1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_rang1.Controls.Add(this.lbl_rang1);
            this.panel_rang1.Location = new System.Drawing.Point(28, 21);
            this.panel_rang1.Name = "panel_rang1";
            this.panel_rang1.Size = new System.Drawing.Size(120, 27);
            this.panel_rang1.TabIndex = 11;
            this.panel_rang1.Visible = false;
            // 
            // lbl_rang1
            // 
            this.lbl_rang1.AutoSize = true;
            this.lbl_rang1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rang1.Location = new System.Drawing.Point(7, 6);
            this.lbl_rang1.Name = "lbl_rang1";
            this.lbl_rang1.Size = new System.Drawing.Size(72, 16);
            this.lbl_rang1.TabIndex = 7;
            this.lbl_rang1.Text = "lbl_rang1";
            this.lbl_rang1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_disziplin
            // 
            this.panel_disziplin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_disziplin.BackColor = System.Drawing.Color.Transparent;
            this.panel_disziplin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_disziplin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_disziplin.Controls.Add(this.label_disziplin);
            this.panel_disziplin.Location = new System.Drawing.Point(585, 512);
            this.panel_disziplin.Margin = new System.Windows.Forms.Padding(0);
            this.panel_disziplin.Name = "panel_disziplin";
            this.panel_disziplin.Size = new System.Drawing.Size(200, 38);
            this.panel_disziplin.TabIndex = 10;
            // 
            // label_disziplin
            // 
            this.label_disziplin.BackColor = System.Drawing.Color.Transparent;
            this.label_disziplin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disziplin.Location = new System.Drawing.Point(25, 10);
            this.label_disziplin.Name = "label_disziplin";
            this.label_disziplin.Size = new System.Drawing.Size(157, 18);
            this.label_disziplin.TabIndex = 4;
            this.label_disziplin.Text = "label_disziplin";
            this.label_disziplin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_status
            // 
            this.panel_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_status.BackColor = System.Drawing.Color.Transparent;
            this.panel_status.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_status.Controls.Add(this.lbl_lauf);
            this.panel_status.Controls.Add(this.label2);
            this.panel_status.Controls.Add(this.label1);
            this.panel_status.Controls.Add(this.lbl_rennen);
            this.panel_status.Location = new System.Drawing.Point(585, 442);
            this.panel_status.Margin = new System.Windows.Forms.Padding(0);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(200, 38);
            this.panel_status.TabIndex = 9;
            // 
            // lbl_lauf
            // 
            this.lbl_lauf.AutoSize = true;
            this.lbl_lauf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lauf.Location = new System.Drawing.Point(169, 12);
            this.lbl_lauf.Name = "lbl_lauf";
            this.lbl_lauf.Size = new System.Drawing.Size(16, 16);
            this.lbl_lauf.TabIndex = 1;
            this.lbl_lauf.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lauf:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rennen:";
            // 
            // lbl_rennen
            // 
            this.lbl_rennen.AutoSize = true;
            this.lbl_rennen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rennen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rennen.Location = new System.Drawing.Point(93, 12);
            this.lbl_rennen.Name = "lbl_rennen";
            this.lbl_rennen.Size = new System.Drawing.Size(16, 16);
            this.lbl_rennen.TabIndex = 3;
            this.lbl_rennen.Text = "1";
            // 
            // panelzeit
            // 
            this.panelzeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelzeit.BackColor = System.Drawing.Color.Transparent;
            this.panelzeit.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panelzeit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelzeit.Controls.Add(this.lbl_Zeit);
            this.panelzeit.Location = new System.Drawing.Point(585, 477);
            this.panelzeit.Name = "panelzeit";
            this.panelzeit.Size = new System.Drawing.Size(200, 38);
            this.panelzeit.TabIndex = 7;
            // 
            // lbl_Zeit
            // 
            this.lbl_Zeit.AutoSize = true;
            this.lbl_Zeit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Zeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zeit.Location = new System.Drawing.Point(125, 12);
            this.lbl_Zeit.Name = "lbl_Zeit";
            this.lbl_Zeit.Size = new System.Drawing.Size(57, 16);
            this.lbl_Zeit.TabIndex = 7;
            this.lbl_Zeit.Text = "lbl_zeit";
            this.lbl_Zeit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_uhr
            // 
            this.panel_uhr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_uhr.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeit;
            this.panel_uhr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_uhr.Controls.Add(this.lbl_uhr);
            this.panel_uhr.Location = new System.Drawing.Point(672, 142);
            this.panel_uhr.Name = "panel_uhr";
            this.panel_uhr.Size = new System.Drawing.Size(75, 37);
            this.panel_uhr.TabIndex = 2;
            // 
            // lbl_uhr
            // 
            this.lbl_uhr.AutoSize = true;
            this.lbl_uhr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_uhr.Location = new System.Drawing.Point(12, 10);
            this.lbl_uhr.Name = "lbl_uhr";
            this.lbl_uhr.Size = new System.Drawing.Size(51, 17);
            this.lbl_uhr.TabIndex = 1;
            this.lbl_uhr.Text = "lbl_uhr";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Logo_SCEG_4_f;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(647, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLane7
            // 
            this.pnlLane7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane7.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane7.Controls.Add(this.lblLane7);
            this.pnlLane7.Location = new System.Drawing.Point(28, 499);
            this.pnlLane7.Name = "pnlLane7";
            this.pnlLane7.Size = new System.Drawing.Size(347, 27);
            this.pnlLane7.TabIndex = 18;
            this.pnlLane7.Visible = false;
            // 
            // lblLane7
            // 
            this.lblLane7.AutoSize = true;
            this.lblLane7.BackColor = System.Drawing.Color.Transparent;
            this.lblLane7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane7.Location = new System.Drawing.Point(7, 6);
            this.lblLane7.Name = "lblLane7";
            this.lblLane7.Size = new System.Drawing.Size(59, 16);
            this.lblLane7.TabIndex = 7;
            this.lblLane7.Text = "label10";
            this.lblLane7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLane6
            // 
            this.pnlLane6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane6.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane6.Controls.Add(this.lblLane6);
            this.pnlLane6.Location = new System.Drawing.Point(28, 474);
            this.pnlLane6.Name = "pnlLane6";
            this.pnlLane6.Size = new System.Drawing.Size(347, 27);
            this.pnlLane6.TabIndex = 18;
            this.pnlLane6.Visible = false;
            // 
            // lblLane6
            // 
            this.lblLane6.AutoSize = true;
            this.lblLane6.BackColor = System.Drawing.Color.Transparent;
            this.lblLane6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane6.Location = new System.Drawing.Point(7, 6);
            this.lblLane6.Name = "lblLane6";
            this.lblLane6.Size = new System.Drawing.Size(59, 16);
            this.lblLane6.TabIndex = 7;
            this.lblLane6.Text = "label10";
            this.lblLane6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLane5
            // 
            this.pnlLane5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane5.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane5.Controls.Add(this.lblLane5);
            this.pnlLane5.Location = new System.Drawing.Point(28, 449);
            this.pnlLane5.Name = "pnlLane5";
            this.pnlLane5.Size = new System.Drawing.Size(347, 27);
            this.pnlLane5.TabIndex = 18;
            this.pnlLane5.Visible = false;
            // 
            // lblLane5
            // 
            this.lblLane5.AutoSize = true;
            this.lblLane5.BackColor = System.Drawing.Color.Transparent;
            this.lblLane5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane5.Location = new System.Drawing.Point(7, 6);
            this.lblLane5.Name = "lblLane5";
            this.lblLane5.Size = new System.Drawing.Size(59, 16);
            this.lblLane5.TabIndex = 7;
            this.lblLane5.Text = "label10";
            this.lblLane5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLane4
            // 
            this.pnlLane4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane4.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane4.Controls.Add(this.lblLane4);
            this.pnlLane4.Location = new System.Drawing.Point(28, 424);
            this.pnlLane4.Name = "pnlLane4";
            this.pnlLane4.Size = new System.Drawing.Size(347, 27);
            this.pnlLane4.TabIndex = 17;
            this.pnlLane4.Visible = false;
            // 
            // lblLane4
            // 
            this.lblLane4.AutoSize = true;
            this.lblLane4.BackColor = System.Drawing.Color.Transparent;
            this.lblLane4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane4.Location = new System.Drawing.Point(7, 6);
            this.lblLane4.Name = "lblLane4";
            this.lblLane4.Size = new System.Drawing.Size(59, 16);
            this.lblLane4.TabIndex = 7;
            this.lblLane4.Text = "label10";
            this.lblLane4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLane3
            // 
            this.pnlLane3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane3.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane3.Controls.Add(this.lblLane3);
            this.pnlLane3.Location = new System.Drawing.Point(28, 400);
            this.pnlLane3.Name = "pnlLane3";
            this.pnlLane3.Size = new System.Drawing.Size(347, 27);
            this.pnlLane3.TabIndex = 18;
            this.pnlLane3.Visible = false;
            // 
            // lblLane3
            // 
            this.lblLane3.AutoSize = true;
            this.lblLane3.BackColor = System.Drawing.Color.Transparent;
            this.lblLane3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane3.Location = new System.Drawing.Point(7, 6);
            this.lblLane3.Name = "lblLane3";
            this.lblLane3.Size = new System.Drawing.Size(59, 16);
            this.lblLane3.TabIndex = 7;
            this.lblLane3.Text = "label10";
            this.lblLane3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLane2
            // 
            this.pnlLane2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane2.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane2.Controls.Add(this.lblLane2);
            this.pnlLane2.Location = new System.Drawing.Point(28, 375);
            this.pnlLane2.Name = "pnlLane2";
            this.pnlLane2.Size = new System.Drawing.Size(347, 27);
            this.pnlLane2.TabIndex = 18;
            this.pnlLane2.Visible = false;
            // 
            // lblLane2
            // 
            this.lblLane2.AutoSize = true;
            this.lblLane2.BackColor = System.Drawing.Color.Transparent;
            this.lblLane2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane2.Location = new System.Drawing.Point(7, 6);
            this.lblLane2.Name = "lblLane2";
            this.lblLane2.Size = new System.Drawing.Size(59, 16);
            this.lblLane2.TabIndex = 7;
            this.lblLane2.Text = "label10";
            this.lblLane2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLane1
            // 
            this.pnlLane1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLane1.BackColor = System.Drawing.Color.Transparent;
            this.pnlLane1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zeitlang;
            this.pnlLane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLane1.Controls.Add(this.lblLane1);
            this.pnlLane1.Location = new System.Drawing.Point(28, 350);
            this.pnlLane1.Name = "pnlLane1";
            this.pnlLane1.Size = new System.Drawing.Size(347, 27);
            this.pnlLane1.TabIndex = 18;
            this.pnlLane1.Visible = false;
            // 
            // lblLane1
            // 
            this.lblLane1.AutoSize = true;
            this.lblLane1.BackColor = System.Drawing.Color.Transparent;
            this.lblLane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLane1.Location = new System.Drawing.Point(7, 6);
            this.lblLane1.Name = "lblLane1";
            this.lblLane1.Size = new System.Drawing.Size(59, 16);
            this.lblLane1.TabIndex = 7;
            this.lblLane1.Text = "label10";
            this.lblLane1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerLanes
            // 
            this.timerLanes.Interval = 15000;
            this.timerLanes.Tick += new System.EventHandler(this.timerLanes_Tick);
            // 
            // timerSponsorenPause
            // 
            this.timerSponsorenPause.Tick += new System.EventHandler(this.timerSponsorenPause_Tick);
            // 
            // Anzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLane1);
            this.Controls.Add(this.pnlLane2);
            this.Controls.Add(this.pnlLane5);
            this.Controls.Add(this.pnlLane3);
            this.Controls.Add(this.pnlLane6);
            this.Controls.Add(this.pnlLane4);
            this.Controls.Add(this.pnlLane7);
            this.Controls.Add(this.pnlLane8);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.panel_rang8);
            this.Controls.Add(this.panel_rang7);
            this.Controls.Add(this.panel_rang6);
            this.Controls.Add(this.panel_rang5);
            this.Controls.Add(this.panel_rang4);
            this.Controls.Add(this.panel_rang3);
            this.Controls.Add(this.panel_rang2);
            this.Controls.Add(this.panel_rang1);
            this.Controls.Add(this.panel_disziplin);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.panel_sponsoren);
            this.Controls.Add(this.panelzeit);
            this.Controls.Add(this.panel_uhr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anzeige";
            this.Text = "Anzeige";
            this.TopMost = true;
            this.panel_sponsoren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sponsoren)).EndInit();
            this.pnlLane8.ResumeLayout(false);
            this.pnlLane8.PerformLayout();
            this.panel_rang8.ResumeLayout(false);
            this.panel_rang8.PerformLayout();
            this.panel_rang7.ResumeLayout(false);
            this.panel_rang7.PerformLayout();
            this.panel_rang6.ResumeLayout(false);
            this.panel_rang6.PerformLayout();
            this.panel_rang5.ResumeLayout(false);
            this.panel_rang5.PerformLayout();
            this.panel_rang4.ResumeLayout(false);
            this.panel_rang4.PerformLayout();
            this.panel_rang3.ResumeLayout(false);
            this.panel_rang3.PerformLayout();
            this.panel_rang2.ResumeLayout(false);
            this.panel_rang2.PerformLayout();
            this.panel_rang1.ResumeLayout(false);
            this.panel_rang1.PerformLayout();
            this.panel_disziplin.ResumeLayout(false);
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.panelzeit.ResumeLayout(false);
            this.panelzeit.PerformLayout();
            this.panel_uhr.ResumeLayout(false);
            this.panel_uhr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLane7.ResumeLayout(false);
            this.pnlLane7.PerformLayout();
            this.pnlLane6.ResumeLayout(false);
            this.pnlLane6.PerformLayout();
            this.pnlLane5.ResumeLayout(false);
            this.pnlLane5.PerformLayout();
            this.pnlLane4.ResumeLayout(false);
            this.pnlLane4.PerformLayout();
            this.pnlLane3.ResumeLayout(false);
            this.pnlLane3.PerformLayout();
            this.pnlLane2.ResumeLayout(false);
            this.pnlLane2.PerformLayout();
            this.pnlLane1.ResumeLayout(false);
            this.pnlLane1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_uhr;
        public System.Windows.Forms.Panel panel_uhr;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_lauf;
        private System.Windows.Forms.PictureBox pictureBox_Sponsoren;
        private System.Windows.Forms.Timer timersponsoren;
        private System.Windows.Forms.Panel panelzeit;
        private System.Windows.Forms.Label lbl_Zeit;
        private System.Windows.Forms.Panel panel_sponsoren;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_rennen;
        private System.Windows.Forms.Panel panel_disziplin;
        private System.Windows.Forms.Label label_disziplin;
        private System.Windows.Forms.Panel panel_rang1;
        private System.Windows.Forms.Label lbl_rang1;
        private System.Windows.Forms.Panel panel_rang2;
        private System.Windows.Forms.Label lbl_rang2;
        private System.Windows.Forms.Panel panel_rang3;
        private System.Windows.Forms.Label lbl_rang3;
        private System.Windows.Forms.Panel panel_rang4;
        private System.Windows.Forms.Label lbl_rang4;
        private System.Windows.Forms.Panel panel_rang5;
        private System.Windows.Forms.Label lbl_rang5;
        private System.Windows.Forms.Panel panel_rang6;
        private System.Windows.Forms.Label lbl_rang6;
        private System.Windows.Forms.Panel panel_rang7;
        private System.Windows.Forms.Label lbl_rang7;
        private System.Windows.Forms.Panel panel_rang8;
        private System.Windows.Forms.Label lbl_rang8;
        private System.Windows.Forms.Timer timerzwischenzeit;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Panel pnlLane8;
        private System.Windows.Forms.Label lblLane8;
        private System.Windows.Forms.Panel pnlLane7;
        private System.Windows.Forms.Label lblLane7;
        private System.Windows.Forms.Panel pnlLane6;
        private System.Windows.Forms.Label lblLane6;
        private System.Windows.Forms.Panel pnlLane5;
        private System.Windows.Forms.Label lblLane5;
        private System.Windows.Forms.Panel pnlLane4;
        private System.Windows.Forms.Label lblLane4;
        private System.Windows.Forms.Panel pnlLane3;
        private System.Windows.Forms.Label lblLane3;
        private System.Windows.Forms.Panel pnlLane2;
        private System.Windows.Forms.Label lblLane2;
        private System.Windows.Forms.Panel pnlLane1;
        private System.Windows.Forms.Label lblLane1;
        private System.Windows.Forms.Timer timerLanes;
        private System.Windows.Forms.Timer timerSponsorenPause;

    }
}