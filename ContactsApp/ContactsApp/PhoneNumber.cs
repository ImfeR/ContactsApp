using System;
using System.Linq;

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
        private string _number = "70000000000";

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// Номер должен содержать ровно 11 цифр. Первая цифра должна быть ‘7’.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                if (value.Where((t, i) => char.IsNumber(value.ToString(), i) != true).Any())
                {
                    throw new ArgumentException("The input value must consist of numbers");
                }
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "The number of numbers in the phone number should be equal to 11 along with 7, and there were " +
                        value.Length);
                }
                if (value[0] != '7')
                {
                    throw new ArgumentException("The number must start with 7, and you entered " + value[0]);
                }
                _number = value;
            }
        }
    }
}
