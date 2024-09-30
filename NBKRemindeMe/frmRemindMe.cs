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
            if (lstReminders.SelectedItems.Count == 0)
            {
                return;
            }

            using (frmReminderEdit frm = new frmReminderEdit())
            {
                frm.ReminderDate = (DateTime)lstReminders.SelectedItems[0].Tag;
                frm.ReminderMessage = lstReminders.SelectedItems[0].SubItems[1].Text;
                frm.EditMode = true;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    lstReminders.SelectedItems[0].SubItems[1].Text = frm.ReminderMessage;
                }
            }
        }

        private void itemRemove_Click(object sender, EventArgs e)
        {
            if (lstReminders.SelectedItems.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove the reminder at - " + lstReminders.SelectedItems[0].SubItems[0].Text, "Confirm Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lstReminders.Items.Remove(lstReminders.SelectedItems[0]);
            }
        }

        private void frmRemindMe_Load(object sender, EventArgs e)
        {
            reminderTimer.Start();
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

        private void notifyRemindMe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            menuShowReminders_Click(sender, new EventArgs() { });
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;

            foreach (ListViewItem reminderItem in lstReminders.Items.Cast<ListViewItem>().Where(item => ((DateTime)item.Tag) <= current).ToList())
            {
                notifyRemindMe.ShowBalloonTip(3000, "Reminder", reminderItem.SubItems[1].Text, ToolTipIcon.Info);
                lstReminders.Items.Remove(reminderItem);
            }
        }
    }
}
