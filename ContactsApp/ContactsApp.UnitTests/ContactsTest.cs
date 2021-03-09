using NUnit.Framework;
using System;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactsTest
    {
        private Contact _contact;

       [SetUp]
        public void Setup()
        {
            _contact = new Contact();

        }

        #region Surname

        [Test(Description = "Positive Getter test Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Wick";

            _contact.Surname = expected;
            var actual = _contact.Surname;
            Assert.AreEqual(expected, actual, "The Surname getter returns an incorrect surname");
        }

        [TestCase("", "An exception should occur if the surname is an empty string",
            TestName = "Assigning an empty string as a surname")]
        [TestCase("Wick-Wick-Wick-Wick-Wick-Wick-Wick-Wick-Wick-Wick-Wick-Wick-Wick", "An exception should occur if the surname is longer than 50 characters",
            TestName = "Assigning the wrong surname more than 50 characters")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Surname = wrongSurname; },
                message);
        }

        #endregion

        #region Name

        [Test(Description = "Positive Getter test Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Jhon";

            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual, "The Name getter returns an incorrect name");
        }

        [TestCase("", "An exception should occur if the name is an empty string",
            TestName = "Assigning an empty string as a name")]
        [TestCase("Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon-Jhon", "An exception should occur if the name is longer than 50 characters",
            TestName = "Assigning the wrong name more than 50 characters")]
        public void TestNameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Name = wrongSurname; },
                message);
        }

        #endregion

        #region Birthday

        [Test(Description = "Positive Getter test Birthday")]
        public void TestBirthdayGet_CorrectValue()
        {
            var expected = new DateTime(2000, 01, 01);

            _contact.Birthday = expected;
            var actual = _contact.Birthday;
            Assert.AreEqual(expected, actual, "The Surname getter returns an incorrect surname");
        }

        [TestCase( "1899.12.30", "An exception should occur if the birthday is less than 1900.01.01",
            TestName = "Assign a date less than 1900.01.01 as the birthday")]
        [TestCase("2100.01.01", "An exception should occur if the birthday is more than current date",
            TestName = "Assign a date more than current date as the birthday")]
        public void TestBirthdaySet_ArgumentException(DateTime wrongBirthday, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Birthday = wrongBirthday; },
                message);
        }

        #endregion

        #region PhoneNumber

        [Test(Description = "Positive Getter test PhoneNumber")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            var expected = new PhoneNumber();
            expected.Number = "74566542565";

            _contact.PhoneNumber = expected;
            var actual = _contact.PhoneNumber;
            Assert.AreEqual(expected,actual, "The PhoneNumber getter returns an incorrect phone number");
        }

        #endregion

        #region E-mail

        [Test(Description = "Positive Getter test Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "somemail@mail.com";

            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "The Email getter returns an incorrect e-mail");
        }

        [TestCase("", "An exception should occur if the e-mail is an empty string",
            TestName = "Assigning an empty string as a e-mail")]
        [TestCase("somemail@mail.com-somemail@mail.com-somemail@mail.com-somemail@mail.com", "An exception should occur if the e-mail is longer than 50 characters",
            TestName = "Assigning the wrong e-mail more than 50 characters")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Email = wrongEmail; },
                message);
        }

        #endregion

        #region VkId

        [Test(Description = "Positive Getter test VkId")]
        public void TestVkIdGet_CorrectValue()
        {
            var expected = "ID00001";

            _contact.VkId = expected;
            var actual = _contact.VkId;
            Assert.AreEqual(expected, actual, "The VkId getter returns an incorrect vk id");
        }

        [TestCase("ID00001-ID00001-ID00001-ID00001-ID00001-ID00001-ID00001-ID00001", "An exception should occur if the vk id is longer than 50 characters",
            TestName = "Assigning the wrong vk id more than 50 characters")]
        public void TestVkIdSet_ArgumentException(string wrongVkId, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.VkId = wrongVkId; },
                message);
        }

        #endregion

        #region Clone

        [Test(Description = "Clone test")]
        public void TestClone_CorrectValue()
        {
            Contact original = new Contact();

            Contact clone = (Contact)original.Clone();

            Assert.AreEqual(original.Email, clone.Email, "Incorrect clone value");
            Assert.AreEqual(original.PhoneNumber, clone.PhoneNumber, "Incorrect clone value");
            Assert.AreEqual(original.VkId, clone.VkId, "Incorrect clone value");
            Assert.AreEqual(original.Birthday, clone.Birthday, "Incorrect clone value");
            Assert.AreEqual(original.Surname, clone.Surname, "Incorrect clone value");
            Assert.AreEqual(original.Name, clone.Name, "Incorrect clone value");
        }

        #endregion

        #region Constructor

        [Test(Description = "Constructor test")]
        public void TestConstructor_CorrectValue()
        {
            var actualPhone = new PhoneNumber();
            var actualName = "Jhon";
            var actualSurname = "Wick";
            var actualEmail = "JhonWick@lovedogs.com";
            var actualBirthday = new DateTime(1983, 10,13);
            var actualVkId = "IDBaba_Yaga";

            var expected = new Contact(actualPhone, actualName, actualSurname, actualBirthday, actualEmail, actualVkId);

            Assert.AreEqual(expected.Birthday, actualBirthday, "Incorrect clone value");
            Assert.AreEqual(expected.Name, actualName, "Incorrect clone value");
            Assert.AreEqual(expected.Surname, actualSurname, "Incorrect clone value");
            Assert.AreEqual(expected.Email, actualEmail, "Incorrect clone value");
            Assert.AreEqual(expected.VkId, actualVkId, "Incorrect clone value");
            Assert.AreEqual(expected.PhoneNumber.Number, actualPhone.Number, "Incorrect clone value");
        }

        #endregion
    }
}