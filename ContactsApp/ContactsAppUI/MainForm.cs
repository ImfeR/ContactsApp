using ContactsApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project _project;

        private Project _projectWithLine;

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

                Stack<string> birthdaySurnames = _project.BirthdayToday(DateTime.Today);

                if (birthdaySurnames.Count != 0)
                {
                    BirthdayPanel.Visible = true;

                    string surnames = "";

                    var count = birthdaySurnames.Count;

                    for (int i = 0; i < count ; i++)
                    {
                        if (birthdaySurnames.Count == 1)
                        {
                            surnames = surnames + birthdaySurnames.Pop() + ".";
                        }
                        else
                        {
                            surnames = surnames + birthdaySurnames.Pop() + ", ";
                        }
                    }

                    BirthdaySurnamesLabel.Text = surnames;
                }
                else
                {
                    BirthdayPanel.Visible = false;
                }
            }
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            var addContactForm = new ContactForm {Contact = newContact};

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
            Project selectedProject;
            if (FindTextbox.Text != "")
            {
                selectedProject = _projectWithLine;
            }
            else
            {
                selectedProject = _project;
            }

            if (ContactsListbox.SelectedIndex > -1)
            {
                SurnameTextbox.Text = selectedProject.Contacts[ContactsListbox.SelectedIndex].Surname;
                NameTextbox.Text = selectedProject.Contacts[ContactsListbox.SelectedIndex].Name;
                if (selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Day < 10)
                {
                    BirthdayTextbox.Text = @"0" + selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Day + @".";
                }
                else
                {
                    BirthdayTextbox.Text = selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Day + @".";
                }
                if (selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Month < 10)
                {
                    BirthdayTextbox.Text += @"0" + selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Month + @".";
                }
                else
                {
                    BirthdayTextbox.Text += selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Month + @".";
                }
                BirthdayTextbox.Text += selectedProject.Contacts[ContactsListbox.SelectedIndex].Birthday.Year;
                EmailTextbox.Text = selectedProject.Contacts[ContactsListbox.SelectedIndex].Email;
                PhoneTextbox.Text = @"+" + selectedProject.Contacts[ContactsListbox.SelectedIndex].PhoneNumber.Number;
                VKIdTextbox.Text = selectedProject.Contacts[ContactsListbox.SelectedIndex].VkId;
            }
            else
            {
                SurnameTextbox.Text = "";
                NameTextbox.Text = "";
                BirthdayTextbox.Text = "";
                PhoneTextbox.Text = "";
                VKIdTextbox.Text = "";
                EmailTextbox.Text = "";
            }
        }

        internal void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show(@"Select contact for Edit");
            }
            else
            {
                Contact newContact = (Contact)_project.Contacts[ContactsListbox.SelectedIndex].Clone();
                var addContactForm = new ContactForm {Contact = newContact};

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

        private void FindTextbox_TextChanged(object sender, EventArgs e)
        {
            ContactsListbox.Items.Clear();

            ContactsListbox.SelectedIndex = -1;

            SurnameTextbox.Text = "";
            NameTextbox.Text = "";
            BirthdayTextbox.Text = "";
            PhoneTextbox.Text = "";
            VKIdTextbox.Text = "";
            EmailTextbox.Text = "";

            if (FindTextbox.Text == "")
            {
                for (int i = 0; i < _project.Contacts.Count; i++)
                {
                    ContactsListbox.Items.Insert(i, _project.Contacts[i].Surname);
                }
                return;
            }

            var line = FindTextbox.Text.Trim(' ');

            var firstLetter = line[0];
            line = line.Substring(1);
            line = firstLetter.ToString().ToUpper() + line;

            _projectWithLine = _project.ContactContainsLine(line);

            if (_projectWithLine.Contacts.Count != 0)
            {
                for (int i = 0; i < _projectWithLine.Contacts.Count; i++)
                {
                    ContactsListbox.Items.Insert(i, _projectWithLine.Contacts[i].Surname);
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                removeContactToolStripMenuItem_Click(RemoveContactButton, null);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();

            form.ShowDialog();
        }
    }
}
