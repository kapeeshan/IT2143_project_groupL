namespace WindowsFormsApp1
{
    partial class signIn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SignIn_Text = new System.Windows.Forms.Button();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SignUp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.SignIn_Text);
            this.groupBox1.Controls.Add(this.Password_Text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UserName_Text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(613, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Create new Account";
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.LinkColor = System.Drawing.Color.Blue;
            this.SignUp.Location = new System.Drawing.Point(153, 353);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(55, 16);
            this.SignUp.TabIndex = 9;
            this.SignUp.TabStop = true;
            this.SignUp.Text = "Sign Up";
            this.SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(185, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignIn_Text
            // 
            this.SignIn_Text.BackColor = System.Drawing.SystemColors.Highlight;
            this.SignIn_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_Text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignIn_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignIn_Text.Location = new System.Drawing.Point(3, 384);
            this.SignIn_Text.Name = "SignIn_Text";
            this.SignIn_Text.Size = new System.Drawing.Size(328, 62);
            this.SignIn_Text.TabIndex = 6;
            this.SignIn_Text.Text = "Sign In";
            this.SignIn_Text.UseVisualStyleBackColor = false;
            this.SignIn_Text.Click += new System.EventHandler(this.SignIn_Text_Click);
            // 
            // Password_Text
            // 
            this.Password_Text.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Password_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Password_Text.Location = new System.Drawing.Point(9, 221);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(318, 38);
            this.Password_Text.TabIndex = 5;
            this.Password_Text.Text = "Password";
            this.Password_Text.TextChanged += new System.EventHandler(this.pswd_textchanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserName_Text
            // 
            this.UserName_Text.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UserName_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Text.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.UserName_Text.Location = new System.Drawing.Point(9, 141);
            this.UserName_Text.Name = "UserName_Text";
            this.UserName_Text.Size = new System.Drawing.Size(318, 38);
            this.UserName_Text.TabIndex = 4;
            this.UserName_Text.Text = "Username /  Email";
            this.UserName_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(79, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = "SmartDesk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(100, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Think fast, learn smart";
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(952, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "signIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.TextBox UserName_Text;
        private System.Windows.Forms.Button SignIn_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel SignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

