using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта, содержащий номер телефона, имя, фамилию, день рождения,
    /// E-mail и id в vk.com контакта.
    /// </summary>
    public class Contact : ICloneable
    {

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// День рождения контакта.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// E-mail контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// ID на vk.com.
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// Длина имени ограничена в 50 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }

            set
            {
                value = value.Trim();
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя может содержать не больше 50 символов");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("Имя может содержать не менее 1 символа");
                }
                else
                {
                    var firstLetter = value[0];
                    value = value.Substring(1);
                    value = firstLetter.ToString().ToUpper() + value;
                    _name = value;
                }

            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// Длина фаимлии ограничена в 50 символов.
        /// </summary>
        public string Surname
        {
            get { return _surname; }

            set
            {
                value = value.Trim();
                if (value.Length > 50)
                { 
                    throw new ArgumentException("Фамилия может содержать не больше 50 символов");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("Фамилия может содержать не менее 1 символа");
                }
                else
                {
                    var firstLetter = value[0];
                    value = value.Substring(1);
                    value = firstLetter.ToString().ToUpper() + value;
                    _surname = value;
                }
            }
        }

        /// <summary>
        /// Возвращеает и задает дату рождения.
        /// Дата рождения не может быть больше текущей даты и меньше 01.01.1900.
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }

            set
            {
                if (value.Date.CompareTo(DateTime.Today.Date) > 0)
                {
                    throw new ArgumentException("Дата не может быть больше текущей даты.");
                }

                DateTime minDate = new DateTime(1900, 1, 1);
                if (value.Date.CompareTo(minDate) < 0)
                {
                    throw new ArgumentException("Дата не может быть меньше 01.01.1900.");
                }
                else
                {
                    _birthday = value;
                }
            }
        }
        
        /// <summary>
        /// Возвращает и задает электронную почту.
        /// Длина электронной почты не может быть больше 50 символов.
        /// </summary>
        public string Email
        {
            get { return _email; }

            set
            {
                value = value.Trim();
                if (value.Length > 50)
                {
                    throw new ArgumentException("E-mail может содержать не больше 50 символов");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("E-mail может содержать не менее 1 символа");
                }
                else
                {
                    _email = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает значение Id в vk.com.
        /// </summary>
        public string VkId
        {
            get { return _vkId; }

            set
            {
                value = value.Trim();

                _vkId = value;
            }
        }

        /// <summary>
        /// Конструтор класса Contact пол умолчанию.
        /// Имени, фимилии, E-mail, ID на vk.com - null.
        /// Телефон - 70000000000, День рождения - 01.01.1900.
        /// </summary>
        public Contact()
        {
            PhoneNumber = new PhoneNumber();
            Name = " name ";
            Surname = " surname ";
            Birthday = DateTime.Today;
            Email = "email@example.com";
            VkId = "ID000001";
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона контакта в виде объекта класса PhoneNumber.</param>
        /// <param name="name">Имя контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="birthday">День рождения контакта.</param>
        /// <param name="email">E-mail контакта.</param>
        /// <param name="vkId">ID на vk.com контакта.</param>
        public Contact(PhoneNumber phoneNumber, string name, string surname, DateTime birthday, string email, string vkId)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Email = email;
            VkId = vkId;
        }

        /// <summary>
        /// Создает копию экземпляра <see cref="Contact">.
        /// </summary>
        /// <returns>Возвращает экземпляр <see cref="Contact"> с такими же значениями.</returns>
        public object Clone()
        {
            return new Contact(PhoneNumber, Name, Surname, Birthday, Email, VkId);
        }
    }
}
