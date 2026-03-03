namespace VolunteersApp
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            panelMain = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(142, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(btnGuest);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(lblPassword);
            panelMain.Controls.Add(txtLogin);
            panelMain.Controls.Add(lblLogin);
            panelMain.Location = new Point(12, 118);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(360, 231);
            panelMain.TabIndex = 1;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(76, 175, 80);
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(105, 189);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(76, 175, 80);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(105, 148);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click_2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(55, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(151, 81);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(55, 44);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 26);
            txtLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(154, 14);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 19);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(panelMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel panelMain;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtLogin;
        private Label lblLogin;
    }
}
