namespace DMBE
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_file_b = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FILE_P = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help_open = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelnavar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldmbe = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("B Bardiya", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Filemenu,
            this.helpmenu,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(741, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Filemenu
            // 
            this.Filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_file_open,
            this.ToolStripMenuItem_file_b,
            this.ToolStripMenuItem_FILE_P,
            this.ToolStripMenuItem1_file_exit});
            this.Filemenu.Name = "Filemenu";
            this.Filemenu.Size = new System.Drawing.Size(53, 37);
            this.Filemenu.Text = "فایل";
            // 
            // ToolStripMenuItem_file_open
            // 
            this.ToolStripMenuItem_file_open.Name = "ToolStripMenuItem_file_open";
            this.ToolStripMenuItem_file_open.Size = new System.Drawing.Size(210, 38);
            this.ToolStripMenuItem_file_open.Text = "ورود اطلاعات";
            this.ToolStripMenuItem_file_open.Click += new System.EventHandler(this.بازکردنToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_file_b
            // 
            this.ToolStripMenuItem_file_b.Name = "ToolStripMenuItem_file_b";
            this.ToolStripMenuItem_file_b.Size = new System.Drawing.Size(210, 38);
            this.ToolStripMenuItem_file_b.Text = "تعیین b";
            this.ToolStripMenuItem_file_b.Click += new System.EventHandler(this.ذخیرهکردنToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_FILE_P
            // 
            this.ToolStripMenuItem_FILE_P.Name = "ToolStripMenuItem_FILE_P";
            this.ToolStripMenuItem_FILE_P.Size = new System.Drawing.Size(210, 38);
            this.ToolStripMenuItem_FILE_P.Text = "محاسبه فشار متوسط";
            this.ToolStripMenuItem_FILE_P.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1_file_exit
            // 
            this.ToolStripMenuItem1_file_exit.Name = "ToolStripMenuItem1_file_exit";
            this.ToolStripMenuItem1_file_exit.Size = new System.Drawing.Size(210, 38);
            this.ToolStripMenuItem1_file_exit.Text = "خروج";
            this.ToolStripMenuItem1_file_exit.Click += new System.EventHandler(this.خروجToolStripMenuItem1_Click);
            // 
            // helpmenu
            // 
            this.helpmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_help_about,
            this.ToolStripMenuItem_Help_open});
            this.helpmenu.Name = "helpmenu";
            this.helpmenu.Size = new System.Drawing.Size(62, 37);
            this.helpmenu.Text = "راهنما";
            // 
            // ToolStripMenuItem_help_about
            // 
            this.ToolStripMenuItem_help_about.Name = "ToolStripMenuItem_help_about";
            this.ToolStripMenuItem_help_about.Size = new System.Drawing.Size(214, 38);
            this.ToolStripMenuItem_help_about.Text = "درباره نرم افزار";
            // 
            // ToolStripMenuItem_Help_open
            // 
            this.ToolStripMenuItem_Help_open.Name = "ToolStripMenuItem_Help_open";
            this.ToolStripMenuItem_Help_open.Size = new System.Drawing.Size(214, 38);
            this.ToolStripMenuItem_Help_open.Text = "راهنمای ورود اطلاعات";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.persianToolStripMenuItem});
            this.languageToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(93, 37);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.englishToolStripMenuItem.Text = "&English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // persianToolStripMenuItem
            // 
            this.persianToolStripMenuItem.Name = "persianToolStripMenuItem";
            this.persianToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.persianToolStripMenuItem.Text = "&Persian";
            this.persianToolStripMenuItem.Click += new System.EventHandler(this.persianToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.splitContainer1.Panel2.Controls.Add(this.labeldmbe);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(741, 502);
            this.splitContainer1.SplitterDistance = 519;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(512, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 3;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.labelnavar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 50);
            this.panel1.TabIndex = 8;
            // 
            // labelnavar
            // 
            this.labelnavar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelnavar.AutoSize = true;
            this.labelnavar.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelnavar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelnavar.Location = new System.Drawing.Point(167, 10);
            this.labelnavar.Name = "labelnavar";
            this.labelnavar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelnavar.Size = new System.Drawing.Size(345, 31);
            this.labelnavar.TabIndex = 9;
            this.labelnavar.Text = "محاسبه فشار متوسط با کمک فشار جریانی ته چاهی";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(146, 361);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(357, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "فشار متوسط محاسبه گردید و در این فایل ذخیره شد.";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(281, 361);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(222, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "فشار متوسط محاسبه نشده است.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(400, 236);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "b برابر است با";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(326, 236);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "مقدار b تعیین نشده است";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(241, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(373, 109);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "فایل انتخاب شده :";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(307, 109);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "هیچ فایلی انتخاب نشده است";
            // 
            // labeldmbe
            // 
            this.labeldmbe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldmbe.AutoEllipsis = true;
            this.labeldmbe.AutoSize = true;
            this.labeldmbe.Font = new System.Drawing.Font("Times New Roman", 37.75F, System.Drawing.FontStyle.Bold);
            this.labeldmbe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeldmbe.Location = new System.Drawing.Point(24, 19);
            this.labeldmbe.Name = "labeldmbe";
            this.labeldmbe.Size = new System.Drawing.Size(180, 58);
            this.labeldmbe.TabIndex = 3;
            this.labeldmbe.Text = "DMBE";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(29, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 89);
            this.button3.TabIndex = 2;
            this.button3.Text = "محاسبه فشار متوسط";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(29, 207);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(163, 89);
            this.button2.TabIndex = 1;
            this.button2.Text = "تعیین مقدار b";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(29, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "ورود اطلاعات";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 543);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(757, 581);
            this.MinimumSize = new System.Drawing.Size(757, 581);
            this.Name = "Main";
            this.Text = "DMBE AVERAGE PRESSURE CALCULATOR";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Filemenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_file_open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_file_b;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FILE_P;
        private System.Windows.Forms.ToolStripMenuItem helpmenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help_about;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help_open;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelnavar;
        private System.Windows.Forms.Label labeldmbe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persianToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_file_exit;
    }
}

