namespace Login_Ekran
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.adtxtbox = new System.Windows.Forms.TextBox();
            this.sifretxtbox = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.Label();
            this.checkboxev = new System.Windows.Forms.CheckBox();
            this.checkboxsb = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameshow = new System.Windows.Forms.Label();
            this.shownamexet = new System.Windows.Forms.Label();
            this.passshow = new System.Windows.Forms.Label();
            this.passshowxet = new System.Windows.Forms.Label();
            this.ailevezshow = new System.Windows.Forms.Label();
            this.ailevezshowxet = new System.Windows.Forms.Label();
            this.ensevdiyinfenn = new System.Windows.Forms.Label();
            this.ensevdiyinfennxet = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Location = new System.Drawing.Point(12, 49);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(125, 27);
            this.usernametxtbox.TabIndex = 0;
            this.usernametxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernametxt
            // 
            this.usernametxt.AutoSize = true;
            this.usernametxt.BackColor = System.Drawing.Color.Red;
            this.usernametxt.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernametxt.Location = new System.Drawing.Point(12, 25);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(95, 18);
            this.usernametxt.TabIndex = 1;
            this.usernametxt.Text = "UserName";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Black;
            this.password.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.ForeColor = System.Drawing.Color.Crimson;
            this.password.Location = new System.Drawing.Point(12, 104);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(74, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(12, 133);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(125, 27);
            this.passwordtxtbox.TabIndex = 3;
            this.passwordtxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login.ForeColor = System.Drawing.Color.Crimson;
            this.login.Location = new System.Drawing.Point(500, 12);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(288, 453);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // adtxtbox
            // 
            this.adtxtbox.Location = new System.Drawing.Point(83, 166);
            this.adtxtbox.Name = "adtxtbox";
            this.adtxtbox.Size = new System.Drawing.Size(125, 27);
            this.adtxtbox.TabIndex = 5;
            this.adtxtbox.Visible = false;
            this.adtxtbox.TextChanged += new System.EventHandler(this.adtxtbox_TextChanged);
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.Location = new System.Drawing.Point(83, 215);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.Size = new System.Drawing.Size(125, 27);
            this.sifretxtbox.TabIndex = 6;
            this.sifretxtbox.Visible = false;
            // 
            // adtxt
            // 
            this.adtxt.AutoSize = true;
            this.adtxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.adtxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.adtxt.Location = new System.Drawing.Point(12, 173);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(51, 20);
            this.adtxt.TabIndex = 7;
            this.adtxt.Text = "Adiniz";
            this.adtxt.Visible = false;
            // 
            // sifretxt
            // 
            this.sifretxt.AutoSize = true;
            this.sifretxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sifretxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifretxt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sifretxt.ForeColor = System.Drawing.Color.Cyan;
            this.sifretxt.Location = new System.Drawing.Point(12, 215);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(44, 20);
            this.sifretxt.TabIndex = 8;
            this.sifretxt.Text = "Sifre";
            this.sifretxt.Visible = false;
            this.sifretxt.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkboxev
            // 
            this.checkboxev.AutoSize = true;
            this.checkboxev.Location = new System.Drawing.Point(12, 267);
            this.checkboxev.Name = "checkboxev";
            this.checkboxev.Size = new System.Drawing.Size(54, 24);
            this.checkboxev.TabIndex = 9;
            this.checkboxev.Text = "Evli";
            this.checkboxev.UseVisualStyleBackColor = true;
            this.checkboxev.Visible = false;
            // 
            // checkboxsb
            // 
            this.checkboxsb.AutoSize = true;
            this.checkboxsb.Location = new System.Drawing.Point(12, 297);
            this.checkboxsb.Name = "checkboxsb";
            this.checkboxsb.Size = new System.Drawing.Size(71, 24);
            this.checkboxsb.TabIndex = 10;
            this.checkboxsb.Text = "Subay";
            this.checkboxsb.UseVisualStyleBackColor = true;
            this.checkboxsb.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fizika",
            "Kimya",
            "Azerbaycan Dili",
            "Riyaziyyat"});
            this.comboBox1.Location = new System.Drawing.Point(141, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Sevdiyin Fenni Sec";
            this.comboBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "En Sevdiyin Fenn";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 99);
            this.button1.TabIndex = 13;
            this.button1.Text = "Melumatlarimi Ekrana Cixar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(-15, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(828, 14);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // nameshow
            // 
            this.nameshow.AutoSize = true;
            this.nameshow.Location = new System.Drawing.Point(0, 375);
            this.nameshow.Name = "nameshow";
            this.nameshow.Size = new System.Drawing.Size(43, 20);
            this.nameshow.TabIndex = 15;
            this.nameshow.Text = "Adin:";
            this.nameshow.Visible = false;
            // 
            // shownamexet
            // 
            this.shownamexet.AutoSize = true;
            this.shownamexet.Location = new System.Drawing.Point(49, 375);
            this.shownamexet.Name = "shownamexet";
            this.shownamexet.Size = new System.Drawing.Size(33, 20);
            this.shownamexet.TabIndex = 16;
            this.shownamexet.Text = "____";
            this.shownamexet.Visible = false;
            // 
            // passshow
            // 
            this.passshow.AutoSize = true;
            this.passshow.Location = new System.Drawing.Point(0, 401);
            this.passshow.Name = "passshow";
            this.passshow.Size = new System.Drawing.Size(50, 20);
            this.passshow.TabIndex = 17;
            this.passshow.Text = "Sifren:";
            this.passshow.Visible = false;
            // 
            // passshowxet
            // 
            this.passshowxet.AutoSize = true;
            this.passshowxet.Location = new System.Drawing.Point(53, 401);
            this.passshowxet.Name = "passshowxet";
            this.passshowxet.Size = new System.Drawing.Size(33, 20);
            this.passshowxet.TabIndex = 18;
            this.passshowxet.Text = "____";
            this.passshowxet.Visible = false;
            // 
            // ailevezshow
            // 
            this.ailevezshow.AutoSize = true;
            this.ailevezshow.Location = new System.Drawing.Point(0, 421);
            this.ailevezshow.Name = "ailevezshow";
            this.ailevezshow.Size = new System.Drawing.Size(100, 20);
            this.ailevezshow.TabIndex = 19;
            this.ailevezshow.Text = "Aile Veziyyeti:";
            this.ailevezshow.Visible = false;
            this.ailevezshow.Click += new System.EventHandler(this.label6_Click);
            // 
            // ailevezshowxet
            // 
            this.ailevezshowxet.AutoSize = true;
            this.ailevezshowxet.Location = new System.Drawing.Point(106, 421);
            this.ailevezshowxet.Name = "ailevezshowxet";
            this.ailevezshowxet.Size = new System.Drawing.Size(45, 20);
            this.ailevezshowxet.TabIndex = 20;
            this.ailevezshowxet.Text = "______";
            this.ailevezshowxet.Visible = false;
            // 
            // ensevdiyinfenn
            // 
            this.ensevdiyinfenn.AutoSize = true;
            this.ensevdiyinfenn.Location = new System.Drawing.Point(0, 445);
            this.ensevdiyinfenn.Name = "ensevdiyinfenn";
            this.ensevdiyinfenn.Size = new System.Drawing.Size(122, 20);
            this.ensevdiyinfenn.TabIndex = 21;
            this.ensevdiyinfenn.Text = "En Sevdiyin Fenn:";
            this.ensevdiyinfenn.Visible = false;
            // 
            // ensevdiyinfennxet
            // 
            this.ensevdiyinfennxet.AutoSize = true;
            this.ensevdiyinfennxet.Location = new System.Drawing.Point(128, 445);
            this.ensevdiyinfennxet.Name = "ensevdiyinfennxet";
            this.ensevdiyinfennxet.Size = new System.Drawing.Size(39, 20);
            this.ensevdiyinfennxet.TabIndex = 22;
            this.ensevdiyinfennxet.Text = "_____";
            this.ensevdiyinfennxet.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(316, 361);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 23;
            this.listBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ensevdiyinfennxet);
            this.Controls.Add(this.ensevdiyinfenn);
            this.Controls.Add(this.ailevezshowxet);
            this.Controls.Add(this.ailevezshow);
            this.Controls.Add(this.passshowxet);
            this.Controls.Add(this.passshow);
            this.Controls.Add(this.shownamexet);
            this.Controls.Add(this.nameshow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkboxsb);
            this.Controls.Add(this.checkboxev);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.sifretxtbox);
            this.Controls.Add(this.adtxtbox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.usernametxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernametxtbox;
        private Label usernametxt;
        private Label password;
        private TextBox passwordtxtbox;
        private Button login;
        private TextBox adtxtbox;
        private TextBox sifretxtbox;
        private Label adtxt;
        private Label sifretxt;
        private CheckBox checkboxev;
        private CheckBox checkboxsb;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label nameshow;
        private Label shownamexet;
        private Label passshow;
        private Label passshowxet;
        private Label ailevezshow;
        private Label ailevezshowxet;
        private Label ensevdiyinfenn;
        private Label ensevdiyinfennxet;
        private ListBox listBox1;
    }
}