using System.Collections.Generic;

namespace ContactsApp
{
    /// <summary>
    /// Класс "проект", содержащий список всех контактов, созданных в приложении.
    /// </summary>
    public class Project
    {
        private List<Contact> _contactsList;
        
        /// <summary>
        /// Конструктор по умолчанию.
        /// Создает пустой список элементов класса Contact
        /// </summary>
        public Project()
        {
            _contactsList = new List<Contact>();
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
