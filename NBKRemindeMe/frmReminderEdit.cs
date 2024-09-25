using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBKRemindeMe
{
    public partial class frmReminderEdit : Form
    {
        private DateTime dtReminder = DateTime.Now;
        public DateTime ReminderDate
        {
            get
            {
                return GetControlDate();
            }
        }

        public string ReminderMessage
        {
            get
            {
                return txtMessage.Text.Trim();
            }
        }

        public frmReminderEdit()
        {
            InitializeComponent();
            UpdateControlDate(dtReminder);
        }

        private void UpdateControlDate(DateTime date)
        {
            dtReminder = date;

            dtpReminderDate.Value = dtReminder;
            dtpReminderTime.Value = dtReminder;
        }

        private DateTime GetControlDate()
        {
            dtReminder = dtpReminderDate.Value.Date + dtpReminderTime.Value.TimeOfDay;

            return dtReminder;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Trim().Length == 0)
            {
                lblMessage.Text = "*What :";
                lblMessage.ForeColor = Color.Red;
                txtMessage.BackColor = Color.MistyRose;
                txtMessage.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMessage.BackColor != SystemColors.Window)
            {
                lblMessage.Text = "What  :";
                lblMessage.ForeColor = SystemColors.WindowText;
                txtMessage.BackColor = SystemColors.Window;
            }
        }
    }
}
