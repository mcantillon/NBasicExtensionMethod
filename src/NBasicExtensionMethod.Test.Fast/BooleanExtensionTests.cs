// Copyright 2012, Ben Aston (ben@bj.ma).
// 
// This file is part of NBasicExtensionMethod.
// 
// NBasicExtensionMethod is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// NBasicExtensionMethod is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with NBasicExtensionMethod. If not, see <http://www.gnu.org/licenses/>.

namespace NBasicExtensionMethod.Test.Fast
{
	using FluentAssertions;
	using NUnit.Framework;

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