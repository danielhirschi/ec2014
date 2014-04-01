namespace WindowsFormsApplication1
{
    partial class Master
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
            this.components = new System.ComponentModel.Container();
            this.bu_Logo = new System.Windows.Forms.Button();
            this.lbl_uhr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_statusdauer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.but_Lauf_p = new System.Windows.Forms.Button();
            this.label_r8 = new System.Windows.Forms.Label();
            this.label_r7 = new System.Windows.Forms.Label();
            this.label_r6 = new System.Windows.Forms.Label();
            this.label_r5 = new System.Windows.Forms.Label();
            this.label_r4 = new System.Windows.Forms.Label();
            this.label_r3 = new System.Windows.Forms.Label();
            this.label_r2 = new System.Windows.Forms.Label();
            this.label_r1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.but_zeit = new System.Windows.Forms.Button();
            this.lbl_zeit = new System.Windows.Forms.Label();
            this.but_Lauf_m = new System.Windows.Forms.Button();
            this.but_Rennen_m = new System.Windows.Forms.Button();
            this.but_Rennen_p = new System.Windows.Forms.Button();
            this.txt_lauf = new System.Windows.Forms.TextBox();
            this.lbl_lauf = new System.Windows.Forms.Label();
            this.txt_rennen = new System.Windows.Forms.TextBox();
            this.lbl_rennen = new System.Windows.Forms.Label();
            this.timerzeit = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_sponor_interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_sponsoren = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.timeruhr = new System.Windows.Forms.Timer(this.components);
            this.timerstatus = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bu_Logo
            // 
            this.bu_Logo.Location = new System.Drawing.Point(403, 12);
            this.bu_Logo.Name = "bu_Logo";
            this.bu_Logo.Size = new System.Drawing.Size(96, 42);
            this.bu_Logo.TabIndex = 0;
            this.bu_Logo.Text = "Logo ausblenden";
            this.bu_Logo.UseVisualStyleBackColor = true;
            this.bu_Logo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_uhr
            // 
            this.lbl_uhr.AutoSize = true;
            this.lbl_uhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uhr.Location = new System.Drawing.Point(72, 35);
            this.lbl_uhr.Name = "lbl_uhr";
            this.lbl_uhr.Size = new System.Drawing.Size(63, 20);
            this.lbl_uhr.TabIndex = 1;
            this.lbl_uhr.Text = "lbl_uhr";
            this.lbl_uhr.TextChanged += new System.EventHandler(this.lbl_uhr_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_statusdauer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.but_Lauf_p);
            this.groupBox1.Controls.Add(this.label_r8);
            this.groupBox1.Controls.Add(this.label_r7);
            this.groupBox1.Controls.Add(this.label_r6);
            this.groupBox1.Controls.Add(this.label_r5);
            this.groupBox1.Controls.Add(this.label_r4);
            this.groupBox1.Controls.Add(this.label_r3);
            this.groupBox1.Controls.Add(this.label_r2);
            this.groupBox1.Controls.Add(this.label_r1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.but_zeit);
            this.groupBox1.Controls.Add(this.lbl_zeit);
            this.groupBox1.Controls.Add(this.but_Lauf_m);
            this.groupBox1.Controls.Add(this.but_Rennen_m);
            this.groupBox1.Controls.Add(this.but_Rennen_p);
            this.groupBox1.Controls.Add(this.txt_lauf);
            this.groupBox1.Controls.Add(this.lbl_lauf);
            this.groupBox1.Controls.Add(this.txt_rennen);
            this.groupBox1.Controls.Add(this.lbl_rennen);
            this.groupBox1.Location = new System.Drawing.Point(32, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 407);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schwimmen";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(221, 128);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(177, 34);
            this.button13.TabIndex = 37;
            this.button13.Text = "Zeit Reset";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "400m Freistil Herren";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Disziplin";
            // 
            // textBox_statusdauer
            // 
            this.textBox_statusdauer.Location = new System.Drawing.Point(322, 57);
            this.textBox_statusdauer.Name = "textBox_statusdauer";
            this.textBox_statusdauer.Size = new System.Drawing.Size(89, 20);
            this.textBox_statusdauer.TabIndex = 34;
            this.textBox_statusdauer.Text = "6000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Anzeigedauer [ms]:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(220, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(203, 22);
            this.button12.TabIndex = 32;
            this.button12.Text = "Status ausblenden";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(221, 168);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 34);
            this.button10.TabIndex = 31;
            this.button10.Text = "Zeit Stoppen";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(132, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // but_Lauf_p
            // 
            this.but_Lauf_p.Location = new System.Drawing.Point(132, 54);
            this.but_Lauf_p.Name = "but_Lauf_p";
            this.but_Lauf_p.Size = new System.Drawing.Size(0, 0);
            this.but_Lauf_p.TabIndex = 4;
            this.but_Lauf_p.Text = "+";
            this.but_Lauf_p.UseVisualStyleBackColor = true;
            this.but_Lauf_p.Click += new System.EventHandler(this.but_Lauf_p_Click);
            // 
            // label_r8
            // 
            this.label_r8.Location = new System.Drawing.Point(84, 368);
            this.label_r8.Name = "label_r8";
            this.label_r8.Size = new System.Drawing.Size(102, 13);
            this.label_r8.TabIndex = 29;
            // 
            // label_r7
            // 
            this.label_r7.Location = new System.Drawing.Point(84, 346);
            this.label_r7.Name = "label_r7";
            this.label_r7.Size = new System.Drawing.Size(102, 13);
            this.label_r7.TabIndex = 28;
            // 
            // label_r6
            // 
            this.label_r6.Location = new System.Drawing.Point(84, 323);
            this.label_r6.Name = "label_r6";
            this.label_r6.Size = new System.Drawing.Size(102, 13);
            this.label_r6.TabIndex = 27;
            // 
            // label_r5
            // 
            this.label_r5.Location = new System.Drawing.Point(84, 301);
            this.label_r5.Name = "label_r5";
            this.label_r5.Size = new System.Drawing.Size(102, 13);
            this.label_r5.TabIndex = 26;
            // 
            // label_r4
            // 
            this.label_r4.Location = new System.Drawing.Point(84, 278);
            this.label_r4.Name = "label_r4";
            this.label_r4.Size = new System.Drawing.Size(102, 13);
            this.label_r4.TabIndex = 25;
            // 
            // label_r3
            // 
            this.label_r3.Location = new System.Drawing.Point(84, 258);
            this.label_r3.Name = "label_r3";
            this.label_r3.Size = new System.Drawing.Size(102, 13);
            this.label_r3.TabIndex = 24;
            // 
            // label_r2
            // 
            this.label_r2.Location = new System.Drawing.Point(84, 237);
            this.label_r2.Name = "label_r2";
            this.label_r2.Size = new System.Drawing.Size(102, 13);
            this.label_r2.TabIndex = 23;
            // 
            // label_r1
            // 
            this.label_r1.Location = new System.Drawing.Point(84, 212);
            this.label_r1.Name = "label_r1";
            this.label_r1.Size = new System.Drawing.Size(102, 13);
            this.label_r1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Rang 8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rang 7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rang 6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rang 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rang 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rang 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rang 2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(194, 357);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 34);
            this.button8.TabIndex = 14;
            this.button8.Text = "Bahn 5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(386, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "Bahn 8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(322, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 34);
            this.button6.TabIndex = 12;
            this.button6.Text = "Bahn 7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(258, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "Bahn 6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Bahn 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Bahn 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bahn 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bahn 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rang 1";
            // 
            // but_zeit
            // 
            this.but_zeit.Location = new System.Drawing.Point(20, 168);
            this.but_zeit.Name = "but_zeit";
            this.but_zeit.Size = new System.Drawing.Size(177, 34);
            this.but_zeit.TabIndex = 5;
            this.but_zeit.Text = "Zeit Starten";
            this.but_zeit.UseVisualStyleBackColor = true;
            this.but_zeit.Click += new System.EventHandler(this.but_zeit_Click);
            // 
            // lbl_zeit
            // 
            this.lbl_zeit.AutoSize = true;
            this.lbl_zeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zeit.Location = new System.Drawing.Point(16, 133);
            this.lbl_zeit.Name = "lbl_zeit";
            this.lbl_zeit.Size = new System.Drawing.Size(66, 20);
            this.lbl_zeit.TabIndex = 1;
            this.lbl_zeit.Text = "lbl_zeit";
            this.lbl_zeit.TextChanged += new System.EventHandler(this.lbl_zeit_TextChanged);
            // 
            // but_Lauf_m
            // 
            this.but_Lauf_m.Location = new System.Drawing.Point(171, 54);
            this.but_Lauf_m.Name = "but_Lauf_m";
            this.but_Lauf_m.Size = new System.Drawing.Size(33, 23);
            this.but_Lauf_m.TabIndex = 4;
            this.but_Lauf_m.Text = "-";
            this.but_Lauf_m.UseVisualStyleBackColor = true;
            this.but_Lauf_m.Click += new System.EventHandler(this.but_Lauf_m_Click);
            // 
            // but_Rennen_m
            // 
            this.but_Rennen_m.Location = new System.Drawing.Point(171, 19);
            this.but_Rennen_m.Name = "but_Rennen_m";
            this.but_Rennen_m.Size = new System.Drawing.Size(33, 23);
            this.but_Rennen_m.TabIndex = 4;
            this.but_Rennen_m.Text = "-";
            this.but_Rennen_m.UseVisualStyleBackColor = true;
            this.but_Rennen_m.Click += new System.EventHandler(this.but_Rennen_m_Click);
            // 
            // but_Rennen_p
            // 
            this.but_Rennen_p.Location = new System.Drawing.Point(132, 19);
            this.but_Rennen_p.Name = "but_Rennen_p";
            this.but_Rennen_p.Size = new System.Drawing.Size(33, 23);
            this.but_Rennen_p.TabIndex = 4;
            this.but_Rennen_p.Text = "+";
            this.but_Rennen_p.UseVisualStyleBackColor = true;
            this.but_Rennen_p.Click += new System.EventHandler(this.but_Rennen_p_Click);
            // 
            // txt_lauf
            // 
            this.txt_lauf.Location = new System.Drawing.Point(76, 56);
            this.txt_lauf.Name = "txt_lauf";
            this.txt_lauf.Size = new System.Drawing.Size(50, 20);
            this.txt_lauf.TabIndex = 3;
            this.txt_lauf.Text = "1";
            this.txt_lauf.TextChanged += new System.EventHandler(this.txt_lauf_TextChanged);
            // 
            // lbl_lauf
            // 
            this.lbl_lauf.AutoSize = true;
            this.lbl_lauf.Location = new System.Drawing.Point(10, 56);
            this.lbl_lauf.Name = "lbl_lauf";
            this.lbl_lauf.Size = new System.Drawing.Size(28, 13);
            this.lbl_lauf.TabIndex = 2;
            this.lbl_lauf.Text = "Lauf";
            // 
            // txt_rennen
            // 
            this.txt_rennen.Location = new System.Drawing.Point(76, 20);
            this.txt_rennen.Name = "txt_rennen";
            this.txt_rennen.Size = new System.Drawing.Size(50, 20);
            this.txt_rennen.TabIndex = 1;
            this.txt_rennen.Text = "1";
            this.txt_rennen.TextChanged += new System.EventHandler(this.txt_rennen_TextChanged);
            // 
            // lbl_rennen
            // 
            this.lbl_rennen.AutoSize = true;
            this.lbl_rennen.Location = new System.Drawing.Point(10, 20);
            this.lbl_rennen.Name = "lbl_rennen";
            this.lbl_rennen.Size = new System.Drawing.Size(45, 13);
            this.lbl_rennen.TabIndex = 0;
            this.lbl_rennen.Text = "Rennen";
            // 
            // timerzeit
            // 
            this.timerzeit.Tick += new System.EventHandler(this.timerzeit_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_uhr);
            this.groupBox2.Location = new System.Drawing.Point(32, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uhr";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_sponor_interval);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.but_sponsoren);
            this.groupBox3.Location = new System.Drawing.Point(35, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sponsoren";
            // 
            // textBox_sponor_interval
            // 
            this.textBox_sponor_interval.Location = new System.Drawing.Point(111, 13);
            this.textBox_sponor_interval.Name = "textBox_sponor_interval";
            this.textBox_sponor_interval.Size = new System.Drawing.Size(89, 20);
            this.textBox_sponor_interval.TabIndex = 2;
            this.textBox_sponor_interval.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzeigedauer [ms]:";
            // 
            // but_sponsoren
            // 
            this.but_sponsoren.Location = new System.Drawing.Point(10, 39);
            this.but_sponsoren.Name = "but_sponsoren";
            this.but_sponsoren.Size = new System.Drawing.Size(190, 37);
            this.but_sponsoren.TabIndex = 0;
            this.but_sponsoren.Text = "Sponsoren zeigen";
            this.but_sponsoren.UseVisualStyleBackColor = true;
            this.but_sponsoren.Click += new System.EventHandler(this.but_sponsoren_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(403, 60);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 42);
            this.button11.TabIndex = 5;
            this.button11.Text = "Uhr ausblenden";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // timeruhr
            // 
            this.timeruhr.Interval = 500;
            this.timeruhr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerstatus
            // 
            this.timerstatus.Tick += new System.EventHandler(this.timerstatus_Tick);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 630);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bu_Logo);
            this.Name = "Master";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Master_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bu_Logo;
        private System.Windows.Forms.Label lbl_uhr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_rennen;
        private System.Windows.Forms.TextBox txt_lauf;
        private System.Windows.Forms.Label lbl_lauf;
        private System.Windows.Forms.TextBox txt_rennen;
        private System.Windows.Forms.Button but_Rennen_m;
        private System.Windows.Forms.Button but_Rennen_p;
        private System.Windows.Forms.Button but_Lauf_m;
        private System.Windows.Forms.Button but_Lauf_p;
        private System.Windows.Forms.Timer timerzeit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_zeit;
        private System.Windows.Forms.Button but_zeit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_sponor_interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_sponsoren;
        private System.Windows.Forms.Label label_r8;
        private System.Windows.Forms.Label label_r7;
        private System.Windows.Forms.Label label_r6;
        private System.Windows.Forms.Label label_r5;
        private System.Windows.Forms.Label label_r4;
        private System.Windows.Forms.Label label_r3;
        private System.Windows.Forms.Label label_r2;
        private System.Windows.Forms.Label label_r1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer timeruhr;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_statusdauer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timerstatus;
        private System.Windows.Forms.Button button13;
    }
}

