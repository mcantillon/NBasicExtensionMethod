using NUnit.Framework;
using FluentAssertions;
using NBasicExtensionMethod;

namespace NBasicExtensionMethod.Test.Fast
{
    [TestFixture]
    public class BooleanExtensionTests
    {

        [Test]
        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        [TestCase(false, false, false)]
        public void And_Should_Return_False_When_One_Value_Is_False(bool bValueA, bool bValueB, bool bExpectedResult)
        {
            // Arrange
          
            // Act & Assert
            bValueA.And(bValueB).Should().Be(bExpectedResult);
        }

        [Test]
        [TestCase(false, true, true)]
        [TestCase(true, false, true)]
        [TestCase(true, true, true)]
        [TestCase(false, false, false)]
        public void Or_Should_Return_True_When_One_Value_Is_True(bool bValueA, bool bValueB, bool bExpectedResult)
        {
            // Arrange

            // Act & Assert
            bValueA.Or(bValueB).Should().Be(bExpectedResult);
        }

        [Test]
        [TestCase(true, false)]    
        [TestCase(false, true)]    
        public void Not_ReturnsOppositeOfPassedValue(bool bValueA, bool bExpectedResult)
        {
            bValueA.Not().Should().Be(bExpectedResult);
        }

        [Test]
        [TestCase(true,true,false)]
        [TestCase(false,false,true)]
        [TestCase(true,false,true)]
        [TestCase(false,true,true)]
        public void Nand_ReturnsExpectedValueForPassedParameters(bool bValueA, bool bValueB, bool bExpectedResult)
        {
            bValueA.NAnd(bValueB).Should().Be(bExpectedResult);
        }

        [Test]
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void XNOr_WhenValuesAreTheSame_ReturnsTrue(bool bValueA, bool bValueB, bool bExpectedResult)
        {
            bValueA.XNOr(bValueB).Should().Be(bExpectedResult);
        }

        [Test]
        [TestCase(true, true, false)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void NOr_WhenBothValuesAreFalse_ReturnsTrue(bool bValueA, bool bValueB, bool bExpectedResult)
        {
            bValueA.NOr(bValueB).Should().Be(bExpectedResult);
        }

        [Test]
        [TestCase(true, true, false)]
        [TestCase(false, false, false)]
        [TestCase(true, false, true)]
        [TestCase(false, true, true)]
        public void XOr_WhenValuesAreDifferent_ReturnsTrue(bool bValueA, bool bValueB, bool bExpectedResult)
        {
            bValueA.XOr(bValueB).Should().Be(bExpectedResult);
        }
    }
}