using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLibrary;
using System.Collections.Generic;

namespace StringLibraryTests
{
    [TestClass]
    public class StringLibraryTests
    {
        [TestMethod]
        public void GetLetters_RusLetter_True()
        {
            //Arrange
            string text = "Ананас";
            List<char> expected = new List<char> { 'А', 'Н', 'С' };

            //Act
            List<char> actual = StringCheckClass.GetLetters(text);
            
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLetters_RepeatingWords_True()
        {
            //Arrange
            string text = "дгвба_дгвба";
            List<char> expected = new List<char> { 'А', 'Б', 'В', 'Г', 'Д' };

            //Act
            List<char> actual = StringCheckClass.GetLetters(text);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLetters_EnglishLetters_True()
        {
            //Arrange
            string text = "Bob";
            List<char> expected = new List<char> { 'B', 'O' };

            //Act
            List<char> actual = StringCheckClass.GetLetters(text);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLetters_SpecialCharactersAndNumbers_True()
        {
            //Arrange
            string text = "123 @#$%^&*()";
            List<char> expected = new List<char> {};

            //Act
            List<char> actual = StringCheckClass.GetLetters(text);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
