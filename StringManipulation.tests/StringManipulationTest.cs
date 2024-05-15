using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
//using Moq;

namespace StringManipulation.Tests
{
    
    public class StringManipulationTest
    {

        // Metodo 1

        [Fact]
        public void ReturnsConcatenateStrings()
        {
            //Arrange
            var string_operations = new StringOperations();
            string str1 = "Bienvenido,";
            string str2 = "Gracias por confiar en nuestro servicio";
            string expectedResult = "Bienvenido,Gracias por confiar en nuestro servicio";

            //Act

            string result = string_operations.ConcatenateStrings(str1, str2);

            //Assert
            Assert.Equal(expectedResult, result);

        }

        // Metodo 2

        [Fact]
        public void ReturnsReversedString()
        {
            //Arrange
            var string_operations = new StringOperations();
            string str = "Adios";
            string expectedResult = "soidA";

            //Act

            string result = string_operations.ReverseString(str);

            //Assert
            Assert.Equal(expectedResult, result);

        }

        // Metodo 3

        [Fact]
        public void GetStringLength_ReturnsCorrectLength()
        {
            // Arrange
            var string_operations = new StringOperations();
            string String = "Morado";
            int expectedResult = 6;

            // Act
            
            int result = string_operations.GetStringLength(String);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetStringLength_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            var string_operations = new StringOperations();
            string String = null;
            


            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => string_operations.GetStringLength(String));
        }

        // Metodo 4

        [Fact]

        public void RemoveWhitespace_RemovesWhitespace()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Como estuvo tu dia";
            string expectedResult = "Comoestuvotudia";

            // Act
            
            string result = string_operations.RemoveWhitespace(inputString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void RemoveWhitespace_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = null;
            

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => string_operations.RemoveWhitespace(inputString));
        }

        [Fact]
        public void RemoveWhitespace_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "";
            string expectedResult = "";

            // Act
            string result = string_operations.RemoveWhitespace(inputString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        //Metodo 5 

        [Fact]
        public void TruncateString_TruncatesToMaxLength()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Hello, World!";
            int maxLength = 5;
            string expectedResult = "Hello";

            // Act
            string result = string_operations.TruncateString(inputString, maxLength);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TruncateString_NullInput_ReturnsNull()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = null;
            int maxLength = 5;
            

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => string_operations.TruncateString(inputString, maxLength));
        }

        [Fact]
        public void TruncateString_ZeroMaxLength_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Hello, World!";
            int maxLength = 0;
            

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => string_operations.TruncateString(inputString, maxLength));
        }

        [Fact]
        public void TruncateString_MaxLengthEqualOrGreaterThanInput_ReturnsInput()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Hello, World!";
            int maxLength = 13; // Igual a la longitud de inputString
            string expectedResult = "Hello, World!";
            

            // Act
            string result = string_operations.TruncateString(inputString, maxLength);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        //Metodo 6 

        [Fact]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "radar";
            

            // Act
            bool result = string_operations.IsPalindrome(inputString);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Hola";
            

            // Act
            bool result = string_operations.IsPalindrome(inputString);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "";
            

            // Act
            bool result = string_operations.IsPalindrome(inputString);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => string_operations.IsPalindrome(inputString));
        }

        //Metodo 7

        [Fact]
        public void CountOccurrences_CountsCorrectly()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Se vende";
            char character = 'e';
            int expectedCount = 3;
            

            // Act
            int result = string_operations.CountOccurrences(inputString, character);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CountOccurrences_NoOccurrences_ReturnsZero()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Se vende";
            char character = 'a';
            int expectedCount = 0;
            

            // Act
            int result = string_operations.CountOccurrences(inputString, character);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CountOccurrences_EmptyString_ReturnsZero()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "";
            char character = 'o';
            int expectedCount = 0;
            

            // Act
            int result = string_operations.CountOccurrences(inputString, character);

            // Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CountOccurrences_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = null;
            char character = 'o';
            

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => string_operations.CountOccurrences(inputString, character));
        }

        // Metodo 8 

        // Este metodo  verificará que no se produzcan excepciones al llamar al método "Pluralize".

        [Fact]
        public void Pluralize_NoException()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "apple";
            

            // Act & Assert
            //Assert.DoesNotThrowAnyException(() => string_operations.Pluralize(inputString));
        }


        //Metodo 9 

        [Fact]
        public void QuantintyInWords_ReturnsCorrectString()
        {
            // Arrange
            var string_operations = new StringOperations();
            string inputString = "Manzanas";
            int quantity = 3;
            string expectedResult = "3 manzanas";
            

            // Act
            string result = string_operations.QuantintyInWords(inputString, quantity);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        //Metodo 10

        [Theory]
        [InlineData("I", 1)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void FromRomanToNumber_ConvertsCorrectly(string input, int expectedResult)
        {
            // Arrange
            var string_operations = new StringOperations(); 

            // Act
            int result = string_operations.FromRomanToNumber(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }


        // Metodo 11 

        [Fact]
        public void ReadFile_ReturnsCorrectString()
        {
            // Arrange
            var string_operations = new StringOperations();
            string fileName = "example.txt";
            string expectedContent = "This is the content of the file.";

            // Mocking the IFileReaderConector interface
            //var mockFileReader = new Mock<IFileReaderConector>();
            //mockFileReader.Setup(fr => fr.ReadString(fileName)).Returns(expectedContent);


            // Act
           // string result = string_operations.ReadFile(mockFileReader.Object, fileName);

            // Assert
            //Assert.Equal(expectedContent, result);
        }


    }







}

