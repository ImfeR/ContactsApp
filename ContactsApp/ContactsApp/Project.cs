using System.Collections.Generic;

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
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Project()
        {
            Contacts = new List<Contact>();
        }

        /// <summary>
        /// Конструктор класса, инициализирующий списоков элементов класса Contact.
        /// </summary>
        /// <param name="contacts">
        /// Список элементов класса Contact.
        /// </param>
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }

    }
}
