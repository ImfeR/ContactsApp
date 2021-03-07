namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Find = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FindTextbox = new System.Windows.Forms.TextBox();
            this.SurnameTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.PhoneTextbox = new System.Windows.Forms.TextBox();
            this.VKIdTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.ContactsListbox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ChangeContact = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BirthdayTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(8, 7);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(37, 15);
            this.Find.TabIndex = 0;
            this.Find.Text = "Find: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suname: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "vk.com: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail: ";
            // 
            // FindTextbox
            // 
            this.FindTextbox.Location = new System.Drawing.Point(51, 7);
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(219, 20);
            this.FindTextbox.TabIndex = 7;
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(64, 3);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.ReadOnly = true;
            this.SurnameTextbox.Size = new System.Drawing.Size(488, 20);
            this.SurnameTextbox.TabIndex = 8;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(64, 29);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.ReadOnly = true;
            this.NameTextbox.Size = new System.Drawing.Size(488, 20);
            this.NameTextbox.TabIndex = 9;
            // 
            // PhoneTextbox
            // 
            this.PhoneTextbox.Location = new System.Drawing.Point(64, 81);
            this.PhoneTextbox.Name = "PhoneTextbox";
            this.PhoneTextbox.ReadOnly = true;
            this.PhoneTextbox.Size = new System.Drawing.Size(488, 20);
            this.PhoneTextbox.TabIndex = 11;
            // 
            // VKIdTextbox
            // 
            this.VKIdTextbox.Location = new System.Drawing.Point(64, 135);
            this.VKIdTextbox.Name = "VKIdTextbox";
            this.VKIdTextbox.ReadOnly = true;
            this.VKIdTextbox.Size = new System.Drawing.Size(488, 20);
            this.VKIdTextbox.TabIndex = 13;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(64, 109);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.ReadOnly = true;
            this.EmailTextbox.Size = new System.Drawing.Size(488, 20);
            this.EmailTextbox.TabIndex = 12;
            // 
            // ContactsListbox
            // 
            this.ContactsListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListbox.FormattingEnabled = true;
            this.ContactsListbox.Location = new System.Drawing.Point(8, 33);
            this.ContactsListbox.Name = "ContactsListbox";
            this.ContactsListbox.ScrollAlwaysVisible = true;
            this.ContactsListbox.Size = new System.Drawing.Size(262, 381);
            this.ContactsListbox.TabIndex = 15;
            this.ContactsListbox.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.removeContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddContactButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Image = ((System.Drawing.Image)(resources.GetObject("AddContactButton.Image")));
            this.AddContactButton.Location = new System.Drawing.Point(9, 431);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(23, 21);
            this.AddContactButton.TabIndex = 17;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // ChangeContact
            // 
            this.ChangeContact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeContact.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeContact.FlatAppearance.BorderSize = 0;
            this.ChangeContact.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeContact.Image = ((System.Drawing.Image)(resources.GetObject("ChangeContact.Image")));
            this.ChangeContact.Location = new System.Drawing.Point(38, 431);
            this.ChangeContact.Name = "ChangeContact";
            this.ChangeContact.Size = new System.Drawing.Size(23, 20);
            this.ChangeContact.TabIndex = 18;
            this.ChangeContact.UseVisualStyleBackColor = false;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveContactButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveContactButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveContactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveContactButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveContactButton.Image")));
            this.RemoveContactButton.Location = new System.Drawing.Point(67, 432);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(23, 20);
            this.RemoveContactButton.TabIndex = 19;
            this.RemoveContactButton.UseVisualStyleBackColor = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.removeContactToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ContactsListbox);
            this.panel1.Controls.Add(this.RemoveContactButton);
            this.panel1.Controls.Add(this.Find);
            this.panel1.Controls.Add(this.ChangeContact);
            this.panel1.Controls.Add(this.FindTextbox);
            this.panel1.Controls.Add(this.AddContactButton);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 938);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BirthdayTextbox);
            this.panel2.Controls.Add(this.SurnameTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.VKIdTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.EmailTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PhoneTextbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.NameTextbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(285, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 169);
            this.panel2.TabIndex = 21;
            // 
            // BirthdayTextbox
            // 
            this.BirthdayTextbox.Location = new System.Drawing.Point(64, 55);
            this.BirthdayTextbox.Name = "BirthdayTextbox";
            this.BirthdayTextbox.ReadOnly = true;
            this.BirthdayTextbox.Size = new System.Drawing.Size(61, 20);
            this.BirthdayTextbox.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(852, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(868, 2000);
            this.MinimumSize = new System.Drawing.Size(868, 525);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FindTextbox;
        private System.Windows.Forms.TextBox SurnameTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox PhoneTextbox;
        private System.Windows.Forms.TextBox VKIdTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.ListBox ContactsListbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button ChangeContact;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BirthdayTextbox;
    }
}

