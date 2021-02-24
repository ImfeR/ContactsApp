using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
        private List<Contact> _contactsList;

        /// <summary>
        /// Возвращает и задает список контактов. 
        /// </summary>
        public List<Contact> ContactsList
        {
            get { return _contactsList; }

            set
            {
                _contactsList = value;
            }
        }

        /// <summary>
        /// Добавление нового контакта
        /// </summary>
        /// <param name="newContact">Объект класса Contact нового контакта</param>
        public void AddNewContact(Contact newContact)
        {
            if (_contactsList == null)
            {
                _contactsList = new List<Contact> {newContact};
            }
            else
            {
                string newContactNameSurname = newContact.Surname + newContact.Name;
                for (int i = 0; i < _contactsList.Count; i++)
                {
                    string currentContactNameSurname = _contactsList[i].Surname + _contactsList[i].Name;

                    if (string.Compare(newContactNameSurname, currentContactNameSurname) <= 0)
                    {
                        _contactsList.Insert(i,newContact);
                        break;
                    }
                }
            }
        }


        public void RemoveContact()
        {

        }





        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Project()
        {
            _contactsList = null;
        }

        /// <summary>
        /// Конструктор класса, инициализирующий списко элементов класса Contact.
        /// </summary>
        /// <param name="contactsList">
        /// Списко элементов класса Contact.
        /// </param>
        public Project(List<Contact> contactsList)
        {
            _contactsList = contactsList;
        }

    }
}
