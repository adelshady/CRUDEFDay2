namespace CRUDEFDay2.UserControll
{
    partial class MyProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            num_age = new NumericUpDown();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            txt_name = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            btn_edit = new Guna.UI2.WinForms.Guna2Button();
            txt_conpass = new TextBox();
            label1 = new Label();
            btn_savechanges = new Guna.UI2.WinForms.Guna2Button();
            pictureBox = new PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // num_age
            // 
            num_age.Location = new Point(118, 99);
            num_age.Name = "num_age";
            num_age.ReadOnly = true;
            num_age.Size = new Size(168, 27);
            num_age.TabIndex = 29;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(118, 175);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(168, 27);
            txt_email.TabIndex = 28;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(118, 249);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.ReadOnly = true;
            txt_pass.Size = new Size(168, 27);
            txt_pass.TabIndex = 27;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(118, 19);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(168, 27);
            txt_name.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 106);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 24;
            label7.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 182);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 23;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 252);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 22;
            label5.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 26);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 20;
            label3.Text = "Name";
            // 
            // btn_edit
            // 
            btn_edit.CustomizableEdges = customizableEdges1;
            btn_edit.DisabledState.BorderColor = Color.DarkGray;
            btn_edit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_edit.FillColor = Color.Olive;
            btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(821, 222);
            btn_edit.Name = "btn_edit";
            btn_edit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_edit.Size = new Size(142, 74);
            btn_edit.TabIndex = 30;
            btn_edit.Text = "Edit";
            btn_edit.Click += btn_edit_Click;
            // 
            // txt_conpass
            // 
            txt_conpass.Location = new Point(133, 303);
            txt_conpass.Name = "txt_conpass";
            txt_conpass.PasswordChar = '*';
            txt_conpass.ReadOnly = true;
            txt_conpass.Size = new Size(168, 27);
            txt_conpass.TabIndex = 32;
            txt_conpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 310);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 31;
            label1.Text = "Confirm Password";
            // 
            // btn_savechanges
            // 
            btn_savechanges.CustomizableEdges = customizableEdges3;
            btn_savechanges.DisabledState.BorderColor = Color.DarkGray;
            btn_savechanges.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_savechanges.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_savechanges.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_savechanges.FillColor = Color.Olive;
            btn_savechanges.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_savechanges.ForeColor = Color.White;
            btn_savechanges.Location = new Point(821, 135);
            btn_savechanges.Name = "btn_savechanges";
            btn_savechanges.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_savechanges.Size = new Size(142, 74);
            btn_savechanges.TabIndex = 33;
            btn_savechanges.Text = "Save Changes";
            btn_savechanges.Click += btn_savechanges_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(319, 19);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(453, 394);
            pictureBox.TabIndex = 34;
            pictureBox.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.SteelBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(821, 26);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(142, 70);
            guna2Button1.TabIndex = 35;
            guna2Button1.Text = "Upload Pic";
            guna2Button1.Click += btn_addimage;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(pictureBox);
            Controls.Add(btn_savechanges);
            Controls.Add(txt_conpass);
            Controls.Add(label1);
            Controls.Add(btn_edit);
            Controls.Add(num_age);
            Controls.Add(txt_email);
            Controls.Add(txt_pass);
            Controls.Add(txt_name);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Name = "MyProfile";
            Size = new Size(1158, 416);
            Load += MyProfile_Load;
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown num_age;
        private TextBox txt_email;
        private TextBox txt_pass;
        private TextBox txt_name;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private TextBox txt_conpass;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_savechanges;
        private PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
