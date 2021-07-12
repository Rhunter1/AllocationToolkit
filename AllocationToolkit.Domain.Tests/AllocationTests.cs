/* 
 * Copyright (c) 2021 Rhunter1 <https://github.com/Rhunter1>
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using AllocationToolkit.Domain.Tests.Helpers;
using FluentAssertions;
using System;
using Xunit;

namespace AllocationToolkit.Domain.Tests
{
    public class AllocationTests
    {
        private Allocation _sut;

        #region Helpers

        #endregion

        #region Tests

        #region Class Tests
        [Fact]
        public void Allocation_IsNotImmutable()
        {
            // Arrange
            _sut = new(null, null);

            // Act
            var isImmutable = ImmutableHelper.IsImmutable(_sut.GetType());

            // Assert
            isImmutable.Should().BeFalse();
        }

        #endregion

        #region Property Tests

        #region Id Tests
        [Fact]
        public void Id_ShouldBeEmptyGuid_ByDefault()
        {
            // Arrange
            _sut = new(null, null);

            // Act

            // Assert
            _sut.Id.Should().BeEmpty();
        }
        [Fact]
        public void Id_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var guid = new Guid();

            // Act
            _sut = new(null, null)
            {
                Id = guid
            };

            // Assert
            _sut.Id.Should().Be(guid);
        }

        #endregion

        #region User Tests
        [Fact]
        public void User_ShouldNull_WhenSetInConstructor()
        {
            // Arrange

            // Act
            _sut = new(null, null);

            // Assert
            _sut.User.Should().BeNull();
        }
        [Fact]
        public void User_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var user = new User();

            // Act
            _sut = new(user, null);

            // Assert
            _sut.User.Should().Be(user);
        }

        #endregion

        #region SalesItem Tests
        [Fact]
        public void SaledItem_ShouldNull_WhenSetInConstructor()
        {
            // Arrange

            // Act
            _sut = new(null, null);

            // Assert
            _sut.SalesItem.Should().BeNull();
        }
        [Fact]
        public void SalesItem_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var salesItem = new SalesItem();

            // Act
            _sut = new(null, salesItem);

            // Assert
            _sut.SalesItem.Should().Be(salesItem);
        }

        #endregion

        #region AllocatedQuantity Tests
        [Fact]
        public void AllocatedQuantity_ShouldBe0_WhenNotSetInConstructor()
        {
            // Arrange

            // Act
            _sut = new(null, null);

            // Assert
            _sut.AllocatedQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(1)]
        [InlineData(30)]
        public void AllocatedQuantity_ShouldBeValue_WhenSetInConstructor(uint allocatedQuantity)
        {
            // Arrange

            // Act
            _sut = new(null, null)
            {
                AllocatedQuantity = allocatedQuantity
            };

            // Assert
            _sut.AllocatedQuantity.Should().Be(allocatedQuantity);
        }


        #endregion

        #region PaidQuantity Tests
        [Fact]
        public void PaidQuantity_ShouldBe0_WhenNotSet()
        {
            // Arrange

            // Act
            _sut = new(null, null);

            // Assert
            _sut.PaidQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(1)]
        [InlineData(30)]
        public void PaidQuantity_ShouldBeValue_WhenSet(uint paidQuantity)
        {
            // Arrange
            _sut = new(null, null)
            {
                AllocatedQuantity = paidQuantity
            };

            // Act
            _sut.PaidQuantity = paidQuantity;

            // Assert
            _sut.PaidQuantity.Should().Be(paidQuantity);
        }
        [Fact]
        public void PaidQuantity_ShouldThrowArgumentException_WhenValueHigherThanAllocatedQuantity()
        {
            // Arrange
            _sut = new(null, null)
            {
                AllocatedQuantity = 2
            };

            // Act
            Action action = () => _sut.PaidQuantity = 3;

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("PaidQuantity cannot be greater than the AllocatedQuantity.");
        }

        #endregion

        #region SentQuantity Tests
        [Fact]
        public void SentQuantity_ShouldBe0_WhenNotSet()
        {
            // Arrange

            // Act
            _sut = new(null, null);

            // Assert
            _sut.SentQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(1)]
        [InlineData(30)]
        public void SentQuantity_ShouldBeValue_WhenSet(uint sentQuantity)
        {
            // Arrange
            _sut = new(null, null)
            {
                AllocatedQuantity = sentQuantity
            };

            // Act
            _sut.SentQuantity = sentQuantity;

            // Assert
            _sut.SentQuantity.Should().Be(sentQuantity);
        }
        [Fact]
        public void SentQuantity_ShouldThrowArgumentException_WhenValueHigherThanAllocatedQuantity()
        {
            // Arrange
            _sut = new(null, null)
            {
                AllocatedQuantity = 2
            };

            // Act
            Action action = () => _sut.SentQuantity = 3;

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("SentQuantity cannot be greater than the AllocatedQuantity.");
        }

        #endregion

        #region RequestedDate Tests
        [Fact]
        public void RequestedDate_ShouldBeWithin1SecondOfDateTimeNow_WhenNotSet()
        {
            // Arrange

            // Act
            _sut = new(null, null);

            // Assert
            _sut.RequestedDate.Should().BeWithin(new TimeSpan(0, 0 , 1));
        }
        [Fact]
        public void RequestedDate_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var date = new DateTime(2021, 1, 15, 18, 15, 22);

            // Act
            _sut = new(null, null)
            {
                RequestedDate = date
            };

            // Assert
            _sut.RequestedDate.Should().Be(date);
        }

        #endregion

        #endregion

        #endregion
    }
}
