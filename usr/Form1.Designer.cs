namespace usr
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
            this.check_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.RadioButton();
            this.moder = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.RadioButton();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.errors = new System.Windows.Forms.TextBox();
            this.clean_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.RadioButton();
            this.Stats = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(182, 572);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(240, 71);
            this.check_button.TabIndex = 0;
            this.check_button.Text = "Ввійти";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1166, 572);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(240, 71);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(179, 237);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(37, 13);
            this.login.TabIndex = 2;
            this.login.Text = "Логін:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(179, 259);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(48, 13);
            this.password.TabIndex = 3;
            this.password.Text = "Пароль:";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(0, 0);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(54, 17);
            this.admin.TabIndex = 4;
            this.admin.Text = "Адмін";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
            // 
            // moder
            // 
            this.moder.AutoSize = true;
            this.moder.Location = new System.Drawing.Point(0, 35);
            this.moder.Name = "moder";
            this.moder.Size = new System.Drawing.Size(58, 17);
            this.moder.TabIndex = 5;
            this.moder.Text = "Модер";
            this.moder.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Checked = true;
            this.user.Location = new System.Drawing.Point(0, 69);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(83, 17);
            this.user.TabIndex = 6;
            this.user.TabStop = true;
            this.user.Text = "Користувач";
            this.user.UseVisualStyleBackColor = true;
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(247, 230);
            this.login_textbox.Multiline = true;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(134, 20);
            this.login_textbox.TabIndex = 7;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(247, 256);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(134, 20);
            this.password_textbox.TabIndex = 8;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(247, 204);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(134, 20);
            this.name_textbox.TabIndex = 10;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(179, 207);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 9;
            this.name.Text = "Ім\'я:";
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(428, 572);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(240, 71);
            this.register_button.TabIndex = 11;
            this.register_button.Text = "Зареєструватися";
            this.register_button.UseVisualStyleBackColor = true;
            // 
            // errors
            // 
            this.errors.Location = new System.Drawing.Point(247, 292);
            this.errors.Multiline = true;
            this.errors.Name = "errors";
            this.errors.ReadOnly = true;
            this.errors.Size = new System.Drawing.Size(134, 39);
            this.errors.TabIndex = 15;
            this.errors.Visible = false;
            // 
            // clean_button
            // 
            this.clean_button.Location = new System.Drawing.Point(920, 572);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(240, 71);
            this.clean_button.TabIndex = 16;
            this.clean_button.Text = "Очистити";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.moder);
            this.panel1.Controls.Add(this.user);
            this.panel1.Location = new System.Drawing.Point(182, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.register);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Location = new System.Drawing.Point(182, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 30);
            this.panel2.TabIndex = 18;
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Checked = true;
            this.register.Location = new System.Drawing.Point(154, 4);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(81, 17);
            this.register.TabIndex = 1;
            this.register.TabStop = true;
            this.register.Text = "Реєстрація";
            this.register.UseVisualStyleBackColor = true;
            this.register.CheckedChanged += new System.EventHandler(this.register_CheckedChanged);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(45, 17);
            this.exit.TabIndex = 0;
            this.exit.Text = "Вхід";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.CheckedChanged += new System.EventHandler(this.exit_CheckedChanged);
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(780, 203);
            this.Stats.Multiline = true;
            this.Stats.Name = "Stats";
            this.Stats.ReadOnly = true;
            this.Stats.Size = new System.Drawing.Size(380, 247);
            this.Stats.TabIndex = 19;
            this.Stats.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 697);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.errors);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.check_button);
            this.Name = "Form1";
            this.Text = "Вхід";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton moder;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox errors;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton register;
        private System.Windows.Forms.RadioButton exit;
        private System.Windows.Forms.TextBox Stats;
    }
}

