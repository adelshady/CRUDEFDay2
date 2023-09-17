namespace CRUDEFDay2
{
    partial class Login
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
            btn_login = new Button();
            txt_username = new TextBox();
            txt_passlogin = new TextBox();
            label9 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(284, 342);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 24;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(284, 69);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(125, 27);
            txt_username.TabIndex = 23;
            // 
            // txt_passlogin
            // 
            txt_passlogin.Location = new Point(284, 224);
            txt_passlogin.Name = "txt_passlogin";
            txt_passlogin.PasswordChar = '*';
            txt_passlogin.Size = new Size(125, 27);
            txt_passlogin.TabIndex = 22;
            txt_passlogin.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 72);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 21;
            label9.Text = "User Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 231);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 20;
            label8.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(txt_username);
            Controls.Add(txt_passlogin);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_passlogin;
        private Label label9;
        private Label label8;
    }
}