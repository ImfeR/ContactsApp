using System;

namespace ContactsApp
{
    public class PhoneNumber
    {
        private string _number;

        public string Number
        {
            get { return _number; }

            set
            {
                for (var i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value, i))
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
    }
}
