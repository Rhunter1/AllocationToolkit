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
using AllocationToolkit.Services.DTOs;
using AllocationToolkit.Services.Tests.Helpers;
using FluentAssertions;
using System;
using Xunit;

namespace AllocationToolkit.Services.Tests.DTOs
{
    public class AllocationDtoTests
    {
        private AllocationDto _sut;

        #region Helpers

        #endregion

        #region Tests

        #region Class Tests
        [Fact]
        public void AllocationItemDto_IsImmutable()
        {
            // Arrange
            _sut = new();

            // Act
            var isImmutable = ImmutableHelper.IsImmutable(_sut.GetType());

            // Assert
            isImmutable.Should().BeTrue();
        }

        [Fact]
        public void AllocationItemDto_InheritsFromIEntity()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.Should().BeAssignableTo<IEntity>();
        }

        #endregion

        #region Property Tests

        #region Id Tests
        [Fact]
        public void Id_ShouldBeEmptyGuid_ByDefault()
        {
            // Arrange
            _sut = new();

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
            _sut = new()
            {
                Id = guid
            };

            // Assert
            _sut.Id.Should().Be(guid);
        }

        #endregion

        #region UserId Tests
        [Fact]
        public void UserId_ShouldBeEmptyGuid_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.UserId.Should().BeEmpty();
        }
        [Fact]
        public void UserId_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var guid = new Guid();

            // Act
            _sut = new()
            {
                UserId = guid
            };

            // Assert
            _sut.UserId.Should().Be(guid);
        }

        #endregion

        #region Id Tests
        [Fact]
        public void SalesItemId_ShouldBeEmptyGuid_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.SalesItemId.Should().BeEmpty();
        }
        [Fact]
        public void SalesItemId_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var guid = new Guid();

            // Act
            _sut = new()
            {
                SalesItemId = guid
            };

            // Assert
            _sut.SalesItemId.Should().Be(guid);
        }

        #endregion

        #region AllocatedQuantity Tests
        [Fact]
        public void AllocatedQuantity_ShouldBe0_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.AllocatedQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(250)]
        public void AllocatedQuantity_ShouldBeValue_WhenSetInConstructor(uint allocatedQuantity)
        {
            // Arrange

            // Act
            _sut = new()
            {
                AllocatedQuantity = allocatedQuantity
            };

            // Assert
            _sut.AllocatedQuantity.Should().Be(allocatedQuantity);
        }

        #endregion

        #region PaidQuantity Tests
        [Fact]
        public void PaidQuantity_ShouldBe0_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.PaidQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(250)]
        public void PaidQuantity_ShouldBeValue_WhenSetInConstructor(uint paidQuantity)
        {
            // Arrange

            // Act
            _sut = new()
            {
                PaidQuantity = paidQuantity
            };

            // Assert
            _sut.PaidQuantity.Should().Be(paidQuantity);
        }

        #endregion

        #region SentQuantity Tests
        [Fact]
        public void SentQuantity_ShouldBe0_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.SentQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(250)]
        public void SentQuantity_ShouldBeValue_WhenSetInConstructor(uint sentQuantity)
        {
            // Arrange

            // Act
            _sut = new()
            {
                SentQuantity = sentQuantity
            };

            // Assert
            _sut.SentQuantity.Should().Be(sentQuantity);
        }

        #endregion

        #region RequestedDate Tests
        [Fact]
        public void RequestedDate_ShouldBeJanuary1st2019_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.RequestedDate.Should().BeSameDateAs(new DateTime(2019, 1, 1));
        }
        [Fact]
        public void RequestedDate_ShouldBeTrue_WhenSetInConstructor()
        {
            // Arrange

            // Act
            _sut = new()
            {
                RequestedDate = new DateTime(2021, 5, 10)
            };

            // Assert
            _sut.RequestedDate.Should().BeSameDateAs(new DateTime(2021, 5, 10));
        }

        #endregion

        #endregion

        #endregion
    }
}
