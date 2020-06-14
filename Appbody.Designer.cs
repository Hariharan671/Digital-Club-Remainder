namespace Digital_Club_Remainder
{
    partial class Appbody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appbody));
            this.Login_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.slidepanel = new System.Windows.Forms.Panel();
            this.cludinfo = new System.Windows.Forms.Button();
            this.memlist = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.men_info = new System.Windows.Forms.Button();
            this.remainders = new System.Windows.Forms.Button();
            this.iconmode = new System.Windows.Forms.Button();
            this.Slide_timer = new System.Windows.Forms.Timer(this.components);
            this.Co = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.slidepanel.SuspendLayout();
            this.Co.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_timer
            // 
            this.Login_timer.Interval = 50;
            this.Login_timer.Tick += new System.EventHandler(this.Login_timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(933, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(851, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(892, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // slidepanel
            // 
            this.slidepanel.BackColor = System.Drawing.Color.DarkViolet;
            this.slidepanel.Controls.Add(this.cludinfo);
            this.slidepanel.Controls.Add(this.memlist);
            this.slidepanel.Controls.Add(this.about);
            this.slidepanel.Controls.Add(this.men_info);
            this.slidepanel.Controls.Add(this.remainders);
            this.slidepanel.Controls.Add(this.iconmode);
            this.slidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidepanel.Location = new System.Drawing.Point(0, 40);
            this.slidepanel.Name = "slidepanel";
            this.slidepanel.Size = new System.Drawing.Size(241, 643);
            this.slidepanel.TabIndex = 1;
            // 
            // cludinfo
            // 
            this.cludinfo.BackColor = System.Drawing.Color.DarkViolet;
            this.cludinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cludinfo.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.cludinfo.ForeColor = System.Drawing.Color.White;
            this.cludinfo.Location = new System.Drawing.Point(0, 74);
            this.cludinfo.Name = "cludinfo";
            this.cludinfo.Size = new System.Drawing.Size(241, 68);
            this.cludinfo.TabIndex = 5;
            this.cludinfo.Text = "CLUBDETAILS";
            this.cludinfo.UseVisualStyleBackColor = false;
            this.cludinfo.Click += new System.EventHandler(this.Cludinfo_Click);
            // 
            // memlist
            // 
            this.memlist.BackColor = System.Drawing.Color.DarkViolet;
            this.memlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memlist.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.memlist.ForeColor = System.Drawing.Color.White;
            this.memlist.Location = new System.Drawing.Point(0, 148);
            this.memlist.Name = "memlist";
            this.memlist.Size = new System.Drawing.Size(241, 68);
            this.memlist.TabIndex = 4;
            this.memlist.Text = "MEMBERSLIST";
            this.memlist.UseVisualStyleBackColor = false;
            this.memlist.Click += new System.EventHandler(this.Memlist_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.DarkViolet;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.about.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.about.Location = new System.Drawing.Point(0, 370);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(241, 68);
            this.about.TabIndex = 2;
            this.about.Text = "ABOUT";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // men_info
            // 
            this.men_info.BackColor = System.Drawing.Color.DarkViolet;
            this.men_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.men_info.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.men_info.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.men_info.Location = new System.Drawing.Point(0, 222);
            this.men_info.Name = "men_info";
            this.men_info.Size = new System.Drawing.Size(241, 68);
            this.men_info.TabIndex = 1;
            this.men_info.Text = "MEMBERSINFO";
            this.men_info.UseVisualStyleBackColor = false;
            this.men_info.Click += new System.EventHandler(this.Men_info_Click);
            // 
            // remainders
            // 
            this.remainders.BackColor = System.Drawing.Color.DarkViolet;
            this.remainders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remainders.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.remainders.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.remainders.Location = new System.Drawing.Point(0, 296);
            this.remainders.Name = "remainders";
            this.remainders.Size = new System.Drawing.Size(241, 68);
            this.remainders.TabIndex = 3;
            this.remainders.Text = "REMAINDERS";
            this.remainders.UseVisualStyleBackColor = false;
            this.remainders.Click += new System.EventHandler(this.Remainders_Click);
            // 
            // iconmode
            // 
            this.iconmode.BackColor = System.Drawing.Color.DarkViolet;
            this.iconmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconmode.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.iconmode.ForeColor = System.Drawing.Color.Snow;
            this.iconmode.Location = new System.Drawing.Point(0, 0);
            this.iconmode.Name = "iconmode";
            this.iconmode.Size = new System.Drawing.Size(241, 68);
            this.iconmode.TabIndex = 0;
            this.iconmode.Text = "ICONMODE";
            this.iconmode.UseVisualStyleBackColor = false;
            this.iconmode.Click += new System.EventHandler(this.Iconmode_Click);
            // 
            // Slide_timer
            // 
            this.Slide_timer.Interval = 50;
            this.Slide_timer.Tick += new System.EventHandler(this.Slide_timer_Tick);
            // 
            // Co
            // 
            this.Co.Controls.Add(this.panel2);
            this.Co.Dock = System.Windows.Forms.DockStyle.Right;
            this.Co.Location = new System.Drawing.Point(244, 40);
            this.Co.Name = "Co";
            this.Co.Size = new System.Drawing.Size(730, 643);
            this.Co.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 643);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 683);
            this.Controls.Add(this.Co);
            this.Controls.Add(this.slidepanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appbody";
            this.Text = "Appbody";
            this.Load += new System.EventHandler(this.Appbody_Load);
            this.panel1.ResumeLayout(false);
            this.slidepanel.ResumeLayout(false);
            this.Co.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Login_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel slidepanel;
        private System.Windows.Forms.Button cludinfo;
        private System.Windows.Forms.Button memlist;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button men_info;
        private System.Windows.Forms.Button remainders;
        private System.Windows.Forms.Button iconmode;
        private System.Windows.Forms.Timer Slide_timer;
        private System.Windows.Forms.Panel Co;
        private System.Windows.Forms.Panel panel2;
    }
}