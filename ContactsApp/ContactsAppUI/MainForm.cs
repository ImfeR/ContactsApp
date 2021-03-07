using ContactsApp;
using System;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project _project;

        public MainForm()
        {
            InitializeComponent();

            _project = ProjectManager.LoadFromFile(@"D:\repos\ContactsAppTests\",@"test.JSON");
            if (_project == null || _project.Contacts.Count == 0 )
            {
                _project = new Project();
                ContactsList.SelectedIndex = -1;
            }
            else
            {
                ContactSurnameComparer surnameComparer = new ContactSurnameComparer();

                _project.Contacts.Sort(surnameComparer);

                for (int i = 0; i < _project.Contacts.Count; i++)
                {
                    ContactsList.Items.Insert(i, _project.Contacts[i].Surname);
                }

                ContactsList.SelectedIndex = 0;
            }
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            var addContactForm = new ContactForm();

            addContactForm.Contact = newContact;
            addContactForm.ShowDialog();
            
            _project.Contacts.Add(newContact);
            var surname = newContact.Surname;

            ContactSurnameComparer surnameComparer = new ContactSurnameComparer();
            _project.Contacts.Sort(surnameComparer);

            var index = _project.Contacts.IndexOf(newContact);
            
            ContactsList.Items.Insert(index, surname);

            ProjectManager.SaveToFile(@"D:\repos\ContactsAppTests\", @"test.JSON", _project);
        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex > -1)
            {
                SurnameBox.Text = _project.Contacts[ContactsList.SelectedIndex].Surname;
                NameBox.Text = _project.Contacts[ContactsList.SelectedIndex].Name;
                BirthdayDateTime.Value = _project.Contacts[ContactsList.SelectedIndex].Birthday;
                EmailBox.Text = _project.Contacts[ContactsList.SelectedIndex].Email;
                PhoneBox.Text = @"+" + _project.Contacts[ContactsList.SelectedIndex].PhoneNumber.Number;
                VKIdBox.Text = _project.Contacts[ContactsList.SelectedIndex].VkId;
            }
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex == -1)
            {
                MessageBox.Show(@"Select contact for delete");
            }
            else
            {
                _project.Contacts.RemoveAt(ContactsList.SelectedIndex);
                ContactsList.Items.RemoveAt(ContactsList.SelectedIndex);
                ProjectManager.SaveToFile(@"D:\repos\ContactsAppTests\", @"test.JSON", _project);
            }
            
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex == -1)
            {
                MessageBox.Show(@"Select contact for delete");
            }
            else
            {
                Contact newContact = (Contact)_project.Contacts[ContactsList.SelectedIndex].Clone();
                var addContactForm = new ContactForm();

                addContactForm.Contact = newContact;
                addContactForm.ShowDialog();

                _project.Contacts.RemoveAt(ContactsList.SelectedIndex);
                ContactsList.Items.RemoveAt(ContactsList.SelectedIndex);

                _project.Contacts.Add(newContact);
                var surname = newContact.Surname;

                ContactSurnameComparer surnameComparer = new ContactSurnameComparer();
                _project.Contacts.Sort(surnameComparer);

                var index = _project.Contacts.IndexOf(newContact);

                ContactsList.Items.Insert(index, surname);

                ProjectManager.SaveToFile(@"D:\repos\ContactsAppTests\", @"test.JSON", _project);
            }
            
        }
    }
}
