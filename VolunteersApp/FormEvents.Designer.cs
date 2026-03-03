namespace VolunteersApp
{
    partial class FormEvents
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
            panel1 = new Panel();
            lblUsername = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 10);
            panel1.Size = new Size(964, 40);
            panel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Right;
            lblUsername.Location = new Point(769, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(45, 19);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "label1";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(76, 175, 80);
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(814, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // FormEvents
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormEvents";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEvents";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUsername;
        private Button btnExit;
    }
}