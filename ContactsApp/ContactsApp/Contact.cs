using System;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Контакт, содержащий номер телефона, имя, фамилию, день рождения,
    /// E-mail и id в vk.com контакта.
    /// </summary>
    public class Contact : ICloneable
    {
        private const int MaxLineLength = 50;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name = "Name";

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname = "Surname";

        /// <summary>
        /// День рождения контакта.
        /// </summary>
        private DateTime _birthday = DateTime.Now;

        /// <summary>
        /// E-mail контакта.
        /// </summary>
        private string _email = "email@example.com";

        /// <summary>
        /// ID на vk.com.
        /// </summary>
        private string _vkId = "ID000001";

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private PhoneNumber _phoneNumber = new PhoneNumber();


        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// Длина фаимлии ограничена в 50 символов.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (value.Length > MaxLineLength)
                {
                    throw new ArgumentException("The surname can contain no more than" + MaxLineLength 
                        + " characters, and you have " + value.Length);
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("The surname can contain at least 1 character");
                }
                var firstLetter = value[0];
                value = value.Substring(1);
                value = firstLetter.ToString().ToUpper() + value;
                _surname = value;
                
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// Длина имени ограничена в 50 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length > MaxLineLength)
                {
                    throw new ArgumentException("The name can contain no more than" + MaxLineLength
                        + " characters, and you have " + value.Length);
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("The name can contain at least 1 character");
                }
                var firstLetter = value[0];
                value = value.Substring(1);
                value = firstLetter.ToString().ToUpper() + value;
                _name = value;
            }
        }

        /// <summary>
        /// Возвращеает и задает дату рождения.
        /// Дата рождения не может быть больше текущей даты и меньше 01.01.1900.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("The date cannot be greater than the current date, " +
                                                "and you entered: " + value.Date.Day 
                                                + "." + value.Date.Month + "." + value.Date.Year);
                }
                DateTime minDate = new DateTime(1900, 1, 1);
                if (value < minDate)
                {
                    throw new ArgumentException("The date cannot be less than 01.01.1900, " +
                                                "and you entered: " + value.Date.Day 
                                                + "." + value.Date.Month + "." + value.Date.Year);
                }
                _birthday = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }

            set { _phoneNumber = value; }
        }

        /// <summary>
        /// Возвращает и задает электронную почту.
        /// Длина электронной почты не может быть больше 50 символов.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                value = value.Trim();
                if (value.Length > MaxLineLength)
                {
                    throw new ArgumentException("E-mail can contain no more than" + MaxLineLength
                        + " characters, and you have " + value.Length);
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("E-mail can contain at least 1 character");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задает значение Id в vk.com.
        /// </summary>
        public string VkId
        {
            get
            {
                return _vkId;
            }
            set
            {
                value = value.Trim();

                if (value.Length > MaxLineLength)
                {
                    throw new ArgumentException("VK ID can contain no more than" + MaxLineLength
                        + " characters, and you have " + value.Length);
                }
                _vkId = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона контакта в виде объекта класса PhoneNumber.</param>
        /// <param name="name">Имя контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="birthday">День рождения контакта.</param>
        /// <param name="email">E-mail контакта.</param>
        /// <param name="vkId">ID на vk.com контакта.</param>
        [JsonConstructor]
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
        /// <returns>Возвращает экземпляр <see cref="Contact"> с такими же значениями.
        /// </returns>
        public object Clone()
        {
            return new Contact(PhoneNumber, Name, Surname, Birthday, Email, VkId);
        }
    }
}
