using ContactsApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AddEditContact : Form
    {
        private Contact _contact;

        public Contact Contact
        {
            get { return _contact; }

            set
            {
                _contact = value;
                if (_contact != null)
                {
                    NameBox.Text = _contact.Name;
                    SurnameBox.Text = _contact.Surname;
                    BirthdayDateTime.Value = _contact.Birthday;
                    PhoneBox.Text = _contact.PhoneNumber.Number;
                    EmailBox.Text = _contact.Email;
                    VKIdBox.Text = _contact.VkId;
                }
            }
        }


        public AddEditContact()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SurnameBox.BackColor = SystemColors.Control;
                _contact.Surname = SurnameBox.Text;
            }
            catch (ArgumentException TooMuchSymbolsException)
            {
                SurnameBox.BackColor = Color.LightSalmon;
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameBox.BackColor = SystemColors.Control;
                _contact.Name = NameBox.Text;
            }
            catch (ArgumentException exception)
            {
                NameBox.BackColor = Color.LightSalmon; ;
            }
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhoneBox.BackColor = SystemColors.Control;
                _contact.PhoneNumber.Number = PhoneBox.Text;
            }
            catch (ArgumentException exception)
            {
                PhoneBox.BackColor = Color.LightSalmon;
            }
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EmailBox.BackColor = SystemColors.Control;
                _contact.Email = EmailBox.Text;
            }
            catch (ArgumentException exception)
            {
                EmailBox.BackColor = Color.LightSalmon;
            }
        }

        private void VKIdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                VKIdBox.BackColor = SystemColors.Control;
                _contact.VkId = VKIdBox.Text;
            }
            catch (ArgumentException exception)
            {
                VKIdBox.BackColor = Color.LightSalmon;
            }
        }

        private void BirthdayDateTime_CloseUp(object sender, EventArgs e)
        {
            try
            {
                BirthdayDateTime.BackColor = SystemColors.Control;
                _contact.Birthday = BirthdayDateTime.Value;
            }
            catch (ArgumentException exception)
            {
                BirthdayDateTime.BackColor = Color.LightSalmon;
            }
        }
    }
}
