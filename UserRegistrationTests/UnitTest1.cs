using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UserRegistrationTests
{
    [TestClass]
    public class PasswordStrengthChekerTests
    {
        [TestMethod]
        public void GetPasswordStrength_AllCahrs_5Points()
        {
            string password = "P2ssw0rd#";
            int expected = 5;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Points()
        {
            string password = "Password";
            int expected = 3;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_0_4Points()
        {
            string password = "Passw0rd";
            int expected = 4;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_1_4Points()
        {
            string password = "Passw1rd";
            int expected = 4;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_at_5Points()
        {
            string password = "Passw0rd@";
            int expected = 5;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Hash_5Points()
        {
            string password = "Passw0rd#";
            int expected = 5;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Excl_5Points()
        {
            string password = "Passw0rd!";
            int expected = 5;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Doll_5Points()
        {
            string password = "Passw0rd$";
            int expected = 5;
            int actual = PasswordStrengthChecker.GetPasswordStrengthChecker(password);
            Assert.AreEqual(expected, actual);
        }
    }
}