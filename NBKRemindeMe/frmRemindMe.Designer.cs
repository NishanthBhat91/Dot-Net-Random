namespace NBKRemindeMe
{
    partial class frmRemindMe
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemindMe));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lstReminders = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ctxMenuReminders = new ContextMenuStrip(components);
            itemAdd = new ToolStripMenuItem();
            itemEdit = new ToolStripMenuItem();
            itemRemove = new ToolStripMenuItem();
            notifyRemindMe = new NotifyIcon(components);
            ctxRemindMe = new ContextMenuStrip(components);
            menuShowReminders = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ctxMenuReminders.SuspendLayout();
            ctxRemindMe.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(lstReminders, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(482, 398);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(379, 20);
            label1.TabIndex = 0;
            label1.Text = "Reminders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstReminders
            // 
            lstReminders.BackColor = SystemColors.Info;
            lstReminders.BorderStyle = BorderStyle.FixedSingle;
            lstReminders.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstReminders.ContextMenuStrip = ctxMenuReminders;
            lstReminders.Dock = DockStyle.Fill;
            lstReminders.FullRowSelect = true;
            lstReminders.GridLines = true;
            lstReminders.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstReminders.HideSelection = true;
            lstReminders.Location = new Point(51, 42);
            lstReminders.MultiSelect = false;
            lstReminders.Name = "lstReminders";
            lstReminders.Size = new Size(379, 312);
            lstReminders.TabIndex = 1;
            lstReminders.UseCompatibleStateImageBehavior = false;
            lstReminders.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "When";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "What";
            columnHeader2.Width = 225;
            // 
            // ctxMenuReminders
            // 
            ctxMenuReminders.Items.AddRange(new ToolStripItem[] { itemAdd, itemEdit, itemRemove });
            ctxMenuReminders.Name = "ctxMenuReminders";
            ctxMenuReminders.Size = new Size(118, 70);
            // 
            // itemAdd
            // 
            itemAdd.Name = "itemAdd";
            itemAdd.Size = new Size(117, 22);
            itemAdd.Text = "Add";
            itemAdd.TextDirection = ToolStripTextDirection.Horizontal;
            itemAdd.Click += itemAdd_Click;
            // 
            // itemEdit
            // 
            itemEdit.Name = "itemEdit";
            itemEdit.Size = new Size(117, 22);
            itemEdit.Text = "Edit";
            itemEdit.Click += itemEdit_Click;
            // 
            // itemRemove
            // 
            itemRemove.Name = "itemRemove";
            itemRemove.Size = new Size(117, 22);
            itemRemove.Text = "Remove";
            itemRemove.Click += itemRemove_Click;
            // 
            // notifyRemindMe
            // 
            notifyRemindMe.BalloonTipIcon = ToolTipIcon.Info;
            notifyRemindMe.BalloonTipText = "Remind me Is running in background";
            notifyRemindMe.BalloonTipTitle = "Running";
            notifyRemindMe.ContextMenuStrip = ctxRemindMe;
            notifyRemindMe.Icon = (Icon)resources.GetObject("notifyRemindMe.Icon");
            notifyRemindMe.Text = "Remind Me";
            notifyRemindMe.Visible = true;
            // 
            // ctxRemindMe
            // 
            ctxRemindMe.Items.AddRange(new ToolStripItem[] { menuShowReminders, toolStripSeparator1, menuExit });
            ctxRemindMe.Name = "ctxRemindMe";
            ctxRemindMe.Size = new Size(163, 54);
            // 
            // menuShowReminders
            // 
            menuShowReminders.Name = "menuShowReminders";
            menuShowReminders.Size = new Size(162, 22);
            menuShowReminders.Text = "Show Reminders";
            menuShowReminders.Click += menuShowReminders_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(159, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(162, 22);
            menuExit.Text = "Exit";
            // 
            // frmRemindMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(482, 398);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmRemindMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remind Me";
            FormClosing += frmRemindMe_FormClosing;
            Load += frmRemindMe_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ctxMenuReminders.ResumeLayout(false);
            ctxRemindMe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ListView lstReminders;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ContextMenuStrip ctxMenuReminders;
        private ToolStripMenuItem itemAdd;
        private ToolStripMenuItem itemEdit;
        private ToolStripMenuItem itemRemove;
        private NotifyIcon notifyRemindMe;
        private ContextMenuStrip ctxRemindMe;
        private ToolStripMenuItem menuShowReminders;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuExit;
    }
}