using System;
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

        public Project ContactContainsLine(string line)
        {
            Project contactsWithLine = new Project();

            for (int i = 0; i < Contacts.Count; i++)
            {
                var nameAndSurname = Contacts[i].Surname + Contacts[i].Name;

                if (nameAndSurname.Contains(line))
                {
                    contactsWithLine.Contacts.Add(Contacts[i]);
                }
            }

            return contactsWithLine;
        }

        public Stack<string> BirthdayToday(DateTime date)
        {
            Stack<string> surnames = new Stack<string>();

            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].Birthday.Day == date.Day && Contacts[i].Birthday.Month == date.Month)
                {
                    surnames.Push(Contacts[i].Surname);
                }
            }

            return surnames;
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
