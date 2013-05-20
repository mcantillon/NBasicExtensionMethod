using System;
using FluentAssertions;
using NUnit.Framework;

namespace NBasicExtensionMethod.Test.Fast
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void IsWebUrl_Should_Return_True_When_Passed_Valid_FQ_Web_Url()
        {
            // Arrange
            string sDummyValidWebUrl = "http://www.bbc.co.uk";
            // Act

            // Assert
            sDummyValidWebUrl.IsWebUrl().Should().BeTrue();
        }

        [Test]
        public void IsWebUrl_Should_Return_True_When_Passed_Valid_Web_Url_Containing_Only_Top_Level_Domain()
        {
            // Arrange
            string sDummyValidWebUrl = "http://bbc.co.uk";
            // Act

            // Assert
            sDummyValidWebUrl.IsWebUrl().Should().BeTrue();
        }

        [Test]
        [Ignore]
        public void IsWebUrl_Should_Return_True_When_Passed_Valid_Web_Url_Missing_Protocal()
        {
            // Arrange
            string sDummyValidWebUrl = "bbc.co.uk";
            // Act

            // Assert
            sDummyValidWebUrl.IsWebUrl().Should().BeTrue();
        }

        [Test]
        public void IsWebUrl_Should_Return_False_When_Passed_Invalid_Web_Url()
        {
            // Arrange
            string sDummyInvalidWebUrl = "http:///www.bbc.co.uk";
            // Act

            // Assert
            sDummyInvalidWebUrl.IsWebUrl().Should().BeFalse();
        }

        [Test]
        public void IsWebUrl_Should_Return_True_When_Passed_Valid_FQ_Domain_And_Valid_Page_Path()
        {
            // Arrange
            string sDummyValidFQWebUrlWithPagePath = "http://www.bbc.co.uk/news/london";
            // Act

            // Assert
            sDummyValidFQWebUrlWithPagePath.IsWebUrl().Should().BeTrue();
        }

        [Test]
        public void IsWebUrl_Should_Return_False_When_Passed_An_Empty_Value()
        {
            // Arrange
            string sEmptyValue = string.Empty;
            // Act

            // Assert
            sEmptyValue.IsWebUrl().Should().BeFalse();
        }

        [Test]
        public void IsWebUrl_Should_Return_False_When_Passed_A_Null_Value()
        {
            // Arrange
            string sNullValue = null;
            // Act

            // Assert
            sNullValue.IsWebUrl().Should().BeFalse();
        }

        [Test]
        public void IsWebUrl_Should_Return_False_When_Passed_A_Value_With_Invalid_Characters()
        {
            // Arrange
            string sDummyInvalidUrlWithInvalidCharacters = "http://www.bbc.co.uk/^«";
            // Act

            // Assert
            sDummyInvalidUrlWithInvalidCharacters.IsWebUrl().Should().BeFalse();
        }

        [Test]
        public void IsEmail_Should_Return_False_When_Passed_An_Empty_Value()
        {
            // Arrange
            string sEmptyValue = string.Empty;
            // Act

            // Assert
            sEmptyValue.IsEmail().Should().BeFalse();
        }

        [Test]
        public void IsEmail_Should_Return_False_When_Passed_A_Null_Value()
        {
            // Arrange
            string sNullValue = null;
            // Act

            // Assert
            sNullValue.IsEmail().Should().BeFalse();
        }

        [Test]
        public void IsEmail_Should_Return_True_When_Passed_Valid_Email_Address()
        {
            // Arrange
            string sDummyValidEmailAddress = "firstname.lastname@mydomain.com";
            // Act

            // Assert
            sDummyValidEmailAddress.IsEmail().Should().BeTrue();
        }

        [Test]
        public void IsEmail_Should_Return_True_When_Passed_Valid_Email_Address_With_Multi_TLD()
        {
            // Arrange
            string sDummyValidEmailAddress = "firstname.lastname@mydomain.org.uk";
            // Act

            // Assert
            sDummyValidEmailAddress.IsEmail().Should().BeTrue();
        }

        [Test]
        public void StripWhitespace_Should_Return_Passed_Value_With_Spaces_Removed()
        {
            // Arrange
            string sDummyValueWithSpaces = "    Hello World, How Are You?    ";
            // Act

            // Assert
            sDummyValueWithSpaces.StripWhitespace().Should().Be("HelloWorld,HowAreYou?");
        }

        [Test]
        public void StripWhitespace_Should_Return_Empty_Value_When_Passed_A_Value_Of_Just_A_Space()
        {
            // Arrange
            string sDummyValueOfJustOneSpace = " ";
            // Act

            // Assert
            sDummyValueOfJustOneSpace.StripWhitespace().Should().BeEmpty();
        }

        [Test]
        public void StripWhitespace_Should_Return_Null_Value_When_Passed_A_Null_Value()
        {
            // Arrange
            string sDummyNullValue = null;
            // Act

            // Assert
            sDummyNullValue.Should().BeNull();
        }

        [Test]
        public void NormalizeWhitespaceToSingleSpaces_Should_Return_Passed_Value_With_Normalized_Spaces()
        {
            // Arrange
            string sDummyValueWithUnnormalizedSpaces = "    Hello World,        How    Are You?    ";
            // Act

            // Assert
            sDummyValueWithUnnormalizedSpaces.NormalizeWhitespaceToSingleSpaces().Should().Be(
                " Hello World, How Are You? ");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NormalizeWhitespaceToSingleSpaces_Should_Throw_ArgumentNullException_Exception_When_Passed_Null()
        {
            // Arrange
            string sDummyNullValue = null;
            // Act

            // Assert
            sDummyNullValue.NormalizeWhitespaceToSingleSpaces().Should().BeNull();
        }

        [Test]
        public void WithCapitalizedFirstLetter_WithLowercaseFirstLetter_ReturnsValueWithCapitalizedFirstLetter()
        {            
            string sValue = "test";
            sValue.WithCapitalizedFirstLetter().Should().StartWith("T");
        }
    }
}