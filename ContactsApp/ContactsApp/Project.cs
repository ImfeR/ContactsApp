using System.Collections.Generic;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс "проект", содержащий список всех контактов, созданных в приложении.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает и задает список контактов. 
        /// </summary>
        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Добавление нового контакта в сортированом порядке.
        /// </summary>
        /// <param name="newContact">Объект класса Contact нового контакта</param>
        public int AddNewContact(Contact newContact)
        {
            if (Contacts == null)
            {
                Contacts = new List<Contact> {newContact};
                return 0;
            }
            else
            {
                string newContactNameSurname = newContact.Surname + newContact.Name;
                for (int i = 0; i < Contacts.Count; i++)
                {
                    string currentContactNameSurname = Contacts[i].Surname + Contacts[i].Name;

                    if (string.Compare(newContactNameSurname, currentContactNameSurname) <= 0)
                    {
                        Contacts.Insert(i,newContact);
                        return i;
                    }
                }
                Contacts.Add(newContact);
                return Contacts.Count - 1;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Project()
        {
            Contacts = null;
        }

        /// <summary>
        /// Конструктор класса, инициализирующий списко элементов класса Contact.
        /// </summary>
        /// <param name="contacts">
        /// Списко элементов класса Contact.
        /// </param>
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }

    }
}
