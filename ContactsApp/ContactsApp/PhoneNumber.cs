using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс номера телефона.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// Номер должен содержать ровно 11 цифр. Первая цифра должна быть ‘7’.
        /// </summary>
        public string Number
        {
            get { return _number; }

            set
            {
                for (var i = 0; i < value.Length; i++)
                {
                    if (char.IsNumber(value.ToString(), i) != true)
                    {
                        throw new ArgumentException("Вводимое значение должно состоять из чисел");
                    }
                }
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "Количество чисел в номере телефона должны быть равны 11 вместе с 7, а их было " +
                        value.Length);
                }

                if (value[0] != '7')
                {
                    throw new ArgumentException("Номер должен начинаться с 7, а вы ввели " + value[0]);
                }
                else
                {
                    _number = value;
                }
            }
        }

        public PhoneNumber(string number)
        {
            Number = number;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// Занчение по умолчанию: "70000000000".
        /// </summary>
        public PhoneNumber()
        {
            _number = "70000000000";
        }
    }
}
