using NUnit.Framework;
using System;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class PhoneNumberTest
    {
        private PhoneNumber _phoneNumber;

        [SetUp]
        public void Setup()
        {
            _phoneNumber = new PhoneNumber();
        }


        [Test(Description = "Positive Getter test number")]
        public void TestNumberGet_CorrectValue()
        {
            var expected = "74566542565";

            _phoneNumber.Number = expected;
            var actual = _phoneNumber.Number;

            Assert.AreEqual(expected, actual, "The Number getter returns an incorrect number");
        }

        [TestCase("7456654aaaa", "An exception should occur if the number has characters other than numbers",
            TestName = "Value assignments with characters other than numbers")]
        [TestCase("94566548558", "An exception should occur if the number starts not with '7'",
            TestName = "Assign a value that does not start with '7'")]
        [TestCase("94", "An exception should occur if the number contains less than 11 numbers",
            TestName = "Assign a value with less than 11 numbers")]
        public void TestSurnameSet_ArgumentException(string wrongPhone, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { _phoneNumber.Number = wrongPhone; },
                message);
        }
    }
}
