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

        private void frmRemindMe_Load(object sender, EventArgs e)
        {
        }

        private void frmRemindMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO - Implement logic to minimize to tray
        }
    }
}
