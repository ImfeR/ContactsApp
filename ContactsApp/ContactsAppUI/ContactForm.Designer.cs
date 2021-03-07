namespace ContactsAppUI
{
    partial class ContactForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.VKIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SurnameBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BirthdayDateTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.VKIdBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.EmailBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PhoneBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 162);
            this.panel2.TabIndex = 22;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(64, 3);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(487, 20);
            this.SurnameBox.TabIndex = 8;
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
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
            // BirthdayDateTime
            // 
            this.BirthdayDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTime.Location = new System.Drawing.Point(64, 55);
            this.BirthdayDateTime.Name = "BirthdayDateTime";
            this.BirthdayDateTime.Size = new System.Drawing.Size(93, 20);
            this.BirthdayDateTime.TabIndex = 14;
            this.BirthdayDateTime.CloseUp += new System.EventHandler(this.BirthdayDateTime_CloseUp);
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
            // VKIdBox
            // 
            this.VKIdBox.Location = new System.Drawing.Point(64, 133);
            this.VKIdBox.Name = "VKIdBox";
            this.VKIdBox.Size = new System.Drawing.Size(487, 20);
            this.VKIdBox.TabIndex = 13;
            this.VKIdBox.TextChanged += new System.EventHandler(this.VKIdBox_TextChanged);
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
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(64, 109);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(487, 20);
            this.EmailBox.TabIndex = 12;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
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
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(64, 81);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(487, 20);
            this.PhoneBox.TabIndex = 11;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail: ";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(64, 29);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(487, 20);
            this.NameBox.TabIndex = 9;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "vk.com: ";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(407, 198);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 23;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(488, 198);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 233);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.panel2);
            this.Name = "AddEditContact";
            this.Text = "Add/Edit Contact";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthdayDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VKIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}