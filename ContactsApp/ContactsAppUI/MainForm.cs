using ContactsApp;
using System;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            var addContactForm = new AddEditContact();

            addContactForm.Contact = newContact;
            addContactForm.ShowDialog();

            var index = _project.AddNewContact(newContact);
            var surname = newContact.Surname;

            ContactsList.Items.Insert(index, surname);
        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SurnameBox.Text = _project.Contacts[ContactsList.SelectedIndex].Surname;
            NameBox.Text = _project.Contacts[ContactsList.SelectedIndex].Name;
            BirthdayDateTime.Value = _project.Contacts[ContactsList.SelectedIndex].Birthday;
            EmailBox.Text = _project.Contacts[ContactsList.SelectedIndex].Email;
            PhoneBox.Text = _project.Contacts[ContactsList.SelectedIndex].PhoneNumber;
            VKIdBox.Text = _project.Contacts[ContactsList.SelectedIndex].VkId;
        }
    }
}
