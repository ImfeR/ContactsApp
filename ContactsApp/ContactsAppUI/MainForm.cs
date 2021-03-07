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
                ContactsListbox.SelectedIndex = -1;
            }
            else
            {
                ContactSurnameComparer surnameComparer = new ContactSurnameComparer();

                _project.Contacts.Sort(surnameComparer);

                for (int i = 0; i < _project.Contacts.Count; i++)
                {
                    ContactsListbox.Items.Insert(i, _project.Contacts[i].Surname);
                }

                ContactsListbox.SelectedIndex = 0;
            }
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            var addContactForm = new ContactForm();

            addContactForm.Contact = newContact;
            addContactForm.ShowDialog();

            if (addContactForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(newContact);
                var surname = newContact.Surname;

                ContactSurnameComparer surnameComparer = new ContactSurnameComparer();
                _project.Contacts.Sort(surnameComparer);

                var index = _project.Contacts.IndexOf(newContact);

                ContactsListbox.Items.Insert(index, surname);

                ProjectManager.SaveToFile(@"D:\repos\ContactsAppTests\", @"test.JSON", _project);
            }
        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListbox.SelectedIndex > -1)
            {
                SurnameTextbox.Text = _project.Contacts[ContactsListbox.SelectedIndex].Surname;
                NameTextbox.Text = _project.Contacts[ContactsListbox.SelectedIndex].Name;
                if (_project.Contacts[ContactsListbox.SelectedIndex].Birthday.Day < 10)
                {
                    BirthdayTextbox.Text = @"0" + _project.Contacts[ContactsListbox.SelectedIndex].Birthday.Day + @".";
                }
                else
                {
                    BirthdayTextbox.Text = _project.Contacts[ContactsListbox.SelectedIndex].Birthday.Day + @".";
                }
                if (_project.Contacts[ContactsListbox.SelectedIndex].Birthday.Month < 10)
                {
                    BirthdayTextbox.Text += @"0" + _project.Contacts[ContactsListbox.SelectedIndex].Birthday.Month + @".";
                }
                else
                {
                    BirthdayTextbox.Text += _project.Contacts[ContactsListbox.SelectedIndex].Birthday.Month + @".";
                }
                BirthdayTextbox.Text += _project.Contacts[ContactsListbox.SelectedIndex].Birthday.Year;
                EmailTextbox.Text = _project.Contacts[ContactsListbox.SelectedIndex].Email;
                PhoneTextbox.Text = @"+" + _project.Contacts[ContactsListbox.SelectedIndex].PhoneNumber.Number;
                VKIdTextbox.Text = _project.Contacts[ContactsListbox.SelectedIndex].VkId;
            }
            else
            {
                SurnameTextbox.Text = "";
                NameTextbox.Text = "";
                BirthdayTextbox.Text = "";
                PhoneTextbox.Text = "";
                VKIdTextbox.Text = "";
            }
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListbox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Select contact for delete");
            }
            else
            {
                _project.Contacts.RemoveAt(ContactsListbox.SelectedIndex);
                ContactsListbox.Items.RemoveAt(ContactsListbox.SelectedIndex);
                ProjectManager.SaveToFile(@"D:\repos\ContactsAppTests\", @"test.JSON", _project);
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListbox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Select contact for delete");
            }
            else
            {
                Contact newContact = (Contact)_project.Contacts[ContactsListbox.SelectedIndex].Clone();
                var addContactForm = new ContactForm();

                addContactForm.Contact = newContact;
                addContactForm.ShowDialog();

                if (addContactForm.DialogResult == DialogResult.OK)
                {
                    _project.Contacts.RemoveAt(ContactsListbox.SelectedIndex);
                    ContactsListbox.Items.RemoveAt(ContactsListbox.SelectedIndex);

                    _project.Contacts.Add(newContact);
                    var surname = newContact.Surname;

                    ContactSurnameComparer surnameComparer = new ContactSurnameComparer();
                    _project.Contacts.Sort(surnameComparer);

                    var index = _project.Contacts.IndexOf(newContact);

                    ContactsListbox.Items.Insert(index, surname);

                    ProjectManager.SaveToFile(@"D:\repos\ContactsAppTests\", @"test.JSON", _project);
                }
            }
        }
    }
}
