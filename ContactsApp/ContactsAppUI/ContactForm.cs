using ContactsApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
        private Contact _contact;

        private readonly string[] _exceptionMessages = 
        {
            "", "", "", "", "", ""
        };

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (_contact != null)
                {
                    NameTextbox.Text = _contact.Name;
                    SurnameTextbox.Text = _contact.Surname;
                    BirthdayDateTimebox.Value = _contact.Birthday;
                    PhoneTextbox.Text = _contact.PhoneNumber.Number;
                    EmailTextbox.Text = _contact.Email;
                    VKIdTextbox.Text = _contact.VkId;
                }
            }
        }


        public ContactForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!CheckExceptionMessage())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _exceptionMessages[0] = "";
                SurnameTextbox.BackColor = SystemColors.Control;
                _contact.Surname = SurnameTextbox.Text;
            }
            catch (ArgumentException exception)
            {
                _exceptionMessages[0] = "Surname: " + exception.Message + "\n";
                SurnameTextbox.BackColor = Color.LightSalmon;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _exceptionMessages[1] = "";
                NameTextbox.BackColor = SystemColors.Control;
                _contact.Name = NameTextbox.Text;
            }
            catch (ArgumentException exception)
            {
                _exceptionMessages[1] = "Name: " + exception.Message + "\n";
                NameTextbox.BackColor = Color.LightSalmon;
            }
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _exceptionMessages[2] = "";
                PhoneTextbox.BackColor = SystemColors.Control;
                _contact.PhoneNumber.Number = PhoneTextbox.Text;
            }
            catch (ArgumentException exception)
            {
                _exceptionMessages[2] = "Phone: " + exception.Message + "\n";
            }
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _exceptionMessages[3] = "";
                EmailTextbox.BackColor = SystemColors.Control;
                _contact.Email = EmailTextbox.Text;
            }
            catch (ArgumentException exception)
            {
                _exceptionMessages[3] = "E-mail: " + exception.Message + "\n";
                EmailTextbox.BackColor = Color.LightSalmon;
            }
        }

        private void VKIdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _exceptionMessages[4] = "";
                VKIdTextbox.BackColor = SystemColors.Control;
                _contact.VkId = VKIdTextbox.Text;
            }
            catch (ArgumentException exception)
            {
                _exceptionMessages[4] = "VkID: " + exception.Message + "\n";
                VKIdTextbox.BackColor = Color.LightSalmon;
            }
        }

        private void BirthdayDateTime_CloseUp(object sender, EventArgs e)
        {
            try
            {
                _exceptionMessages[5] = "";
                _contact.Birthday = BirthdayDateTimebox.Value;
            }
            catch (ArgumentException exception)
            {
                _exceptionMessages[5] = "Birthday: " + exception.Message + "\n";
            }
        }

        private string MessageFormation(string[] arr)
        {
            string message = "";

            foreach (var messages in arr)
            {
                message += messages;
            }

            return message;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult result = MessageBox.Show(@"Are you sure you want to cancel the action",
                    "", MessageBoxButtons.YesNo);
                e.Cancel = (result != DialogResult.Yes);
            }
        }

        private bool CheckExceptionMessage()
        {
            for (int i = 0; i < 6; i++)
            {
                if (_exceptionMessages[i] != "")
                {
                    var message = MessageFormation(_exceptionMessages);
                    MessageBox.Show(
                        message,
                        @"Input errors",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return true;
                }
            }
            return false;
        }
    }
}
