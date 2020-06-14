namespace Digital_Club_Remainder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.f_username = new System.Windows.Forms.TextBox();
            this.f_pass = new System.Windows.Forms.TextBox();
            this.f_code = new System.Windows.Forms.TextBox();
            this.f_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label1.Location = new System.Drawing.Point(198, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label2.Location = new System.Drawing.Point(193, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label3.Location = new System.Drawing.Point(211, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLUBCODE:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // f_username
            // 
            this.f_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.f_username.Location = new System.Drawing.Point(404, 176);
            this.f_username.Name = "f_username";
            this.f_username.Size = new System.Drawing.Size(317, 33);
            this.f_username.TabIndex = 3;
            this.f_username.TextChanged += new System.EventHandler(this.F_username_TextChanged);
            // 
            // f_pass
            // 
            this.f_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.f_pass.Location = new System.Drawing.Point(404, 256);
            this.f_pass.Name = "f_pass";
            this.f_pass.PasswordChar = '*';
            this.f_pass.Size = new System.Drawing.Size(317, 33);
            this.f_pass.TabIndex = 4;
            // 
            // f_code
            // 
            this.f_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.f_code.Location = new System.Drawing.Point(404, 336);
            this.f_code.Name = "f_code";
            this.f_code.Size = new System.Drawing.Size(317, 33);
            this.f_code.TabIndex = 5;
            // 
            // f_login
            // 
            this.f_login.BackColor = System.Drawing.Color.White;
            this.f_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f_login.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.f_login.Location = new System.Drawing.Point(404, 402);
            this.f_login.Name = "f_login";
            this.f_login.Size = new System.Drawing.Size(152, 50);
            this.f_login.TabIndex = 6;
            this.f_login.Text = "LOGIN";
            this.f_login.UseVisualStyleBackColor = false;
            this.f_login.Click += new System.EventHandler(this.F_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label4.Location = new System.Drawing.Point(398, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "INVALID CREDENTIALS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.label5.Location = new System.Drawing.Point(231, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "DIGITAL CLUB REMAINDER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImage = global::Digital_Club_Remainder.Properties.Resources.post_it_clipart_piece_paper_725697_3201086;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 565);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f_login);
            this.Controls.Add(this.f_code);
            this.Controls.Add(this.f_pass);
            this.Controls.Add(this.f_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f_username;
        private System.Windows.Forms.TextBox f_pass;
        private System.Windows.Forms.TextBox f_code;
        private System.Windows.Forms.Button f_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

