using System.Data;
using System.Linq;
using System.Resources;
using Timer = System.Windows.Forms.Timer;

namespace NBKRemindeMe
{
    public partial class frmRemindMe : Form
    {
        public frmRemindMe()
        {
            InitializeComponent();
        }

        private void itemAdd_Click(object sender, EventArgs e)
        {
            using (frmReminderEdit frm = new frmReminderEdit())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    DateTime reminderDate = frm.ReminderDate;
                    ListViewItem item = new ListViewItem(new string[] { reminderDate.ToString(), frm.ReminderMessage });
                    item.Tag = reminderDate;
                    lstReminders.Items.Add(item);
                    SortReminders();
                }
            }
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void itemRemove_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void frmRemindMe_Load(object sender, EventArgs e)
        {
        }

        private void frmRemindMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO - Implement logic to minimize to tray
        }

        private void SortReminders()
        {
            var items = lstReminders.Items.Cast<ListViewItem>().OrderBy(x => ((DateTime)x.Tag).Ticks).ToList();
            lstReminders.Items.Clear();
            lstReminders.Items.AddRange(items.ToArray());
        }

        private void menuShowReminders_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
