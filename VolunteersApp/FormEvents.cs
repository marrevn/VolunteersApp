using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VolunteersApp.Models;

namespace VolunteersApp
{
    public partial class FormEvents : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormEvents(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            lblUsername.Text = IsGuest ? "Гость" : CurrentUser.Fio;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
