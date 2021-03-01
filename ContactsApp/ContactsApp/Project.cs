using System.Collections.Generic;

namespace ContactsApp
{
    /// <summary>
    /// Класс "проект", содержащий список всех контактов, созданных в приложении.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список объектов класса Contact
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Возвращает и задает список контактов. 
        /// </summary>
        public List<Contact> Contacts
        {
            get { return _contacts; }

            set
            {
                _contacts = value;
            }
        }

        /// <summary>
        /// Добавление нового контакта в сортированом порядке.
        /// </summary>
        /// <param name="newContact">Объект класса Contact нового контакта</param>
        public int AddNewContact(Contact newContact)
        {
            if (_contacts == null)
            {
                _contacts = new List<Contact> {newContact};
                return 0;
            }
            else
            {
                string newContactNameSurname = newContact.Surname + newContact.Name;
                for (int i = 0; i < _contacts.Count; i++)
                {
                    string currentContactNameSurname = _contacts[i].Surname + _contacts[i].Name;

                    if (string.Compare(newContactNameSurname, currentContactNameSurname) <= 0)
                    {
                        _contacts.Insert(i,newContact);
                        return i;
                    }
                }
                _contacts.Add(newContact);
                return _contacts.Count - 1;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Project()
        {
            _contacts = null;
        }

        /// <summary>
        /// Конструктор класса, инициализирующий списко элементов класса Contact.
        /// </summary>
        /// <param name="contacts">
        /// Списко элементов класса Contact.
        /// </param>
        public Project(List<Contact> contacts)
        {
            _contacts = contacts;
        }

    }
}
