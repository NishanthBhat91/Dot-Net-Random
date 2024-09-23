namespace NBKRemindeMe
{
    partial class frmReminderEdit
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
            dtpReminderTime = new DateTimePicker();
            btnCancel = new Button();
            btnOk = new Button();
            txtMessage = new TextBox();
            lblMessage = new Label();
            label1 = new Label();
            dtpReminderDate = new DateTimePicker();
            SuspendLayout();
            // 
            // dtpReminderTime
            // 
            dtpReminderTime.Format = DateTimePickerFormat.Time;
            dtpReminderTime.Location = new Point(297, 16);
            dtpReminderTime.Name = "dtpReminderTime";
            dtpReminderTime.ShowUpDown = true;
            dtpReminderTime.Size = new Size(101, 23);
            dtpReminderTime.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(323, 154);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(242, 154);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(84, 45);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(314, 76);
            txtMessage.TabIndex = 3;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(20, 46);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(44, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "What  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 7;
            label1.Text = "When :";
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.CustomFormat = "";
            dtpReminderDate.Location = new Point(84, 16);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(207, 23);
            dtpReminderDate.TabIndex = 1;
            // 
            // frmReminderEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            CancelButton = btnCancel;
            ClientSize = new Size(418, 189);
            Controls.Add(dtpReminderTime);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtMessage);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            Controls.Add(dtpReminderDate);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmReminderEdit";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Reminder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpReminderTime;
        private Button btnCancel;
        private Button btnOk;
        private TextBox txtMessage;
        private Label lblMessage;
        private Label label1;
        private DateTimePicker dtpReminderDate;
    }
}