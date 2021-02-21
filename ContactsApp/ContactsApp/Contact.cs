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
        /// Номер телефона контакта.
        /// </summary>
        private PhoneNumber _phoneNumber;

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
        public PhoneNumber PhoneNumber
        {
            get { return _phoneNumber; }

            set
            {
                PhoneNumber number = new PhoneNumber(value.ToString());
                _phoneNumber = number;
            }
        }

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
                    throw new ArgumentException("Имя может содержать не больше 50 символов");
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
                if (value.Date > DateTime.Today.Date)
                {
                    throw new ArgumentException("Дата не может быть больше текущей даты.");
                }

                DateTime minDate = new DateTime(1900, 1, 1);
                if (value.Date < minDate.Date)
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
        /// Создает копию объекта класса контакт.
        /// </summary>
        /// <returns>Возвращает экземпляр класса с такими же значениями.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
