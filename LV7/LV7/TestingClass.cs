using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace LV7
{
    [TestFixture]
    class TestingClass
    {
        [TestCase("testOne")]
        [TestCase("testTwo")]
        [TestCase("testThree")]
        public void SimpleFalse(string input)
        {
            //Arrange
            bool expected = false;
            //Act
            bool actual = Pali.GetIsWordPali("kjkszpj");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ko to tamo peva")]
        [TestCase("cak i nema veze s vezom tamo vamo namo")]
        public void MediumFalse(String input)
        {
            //Arrange
            bool expected = false;
            //Act
            bool actual = Pali.GetIsWordPali("kjkszpj");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Ana voli milovana")]
        [TestCase("asdffdsa")]
        [TestCase("anjavolimilovanja")]
        public void TruePali(String input)
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Pali.GetIsWordPali("anjavolimilovanja");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
