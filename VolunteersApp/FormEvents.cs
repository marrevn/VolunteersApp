using Microsoft.EntityFrameworkCore;
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

            var colName = new DataGridViewTextBoxColumn();
            colName.Name = "colName";
            colName.FillWeight = 20;
            colName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colProcent = new DataGridViewTextBoxColumn();
            colProcent.Name = "colProcent";
            colProcent.FillWeight = 10;
            colName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEvents.Columns.AddRange([
                colName, colInfo, colProcent
            ]);


            LoadEvents();

        }

        private void LoadEvents()
        {
            using (var db = new DbVolunteersContext())
            {
                var events = db.Events
                    .Include(i => i.Category)
                    .Include(i => i.Place)
                    .Include(i => i.User)
                    .Include(i => i.EventStatus)
                    .ToList();

                dgvEvents.SuspendLayout();
                dgvEvents.Rows.Clear();

                foreach (var eventt in events)
                {
                    int rowIndex = dgvEvents.Rows.Add();
                    var row = dgvEvents.Rows[rowIndex];
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
