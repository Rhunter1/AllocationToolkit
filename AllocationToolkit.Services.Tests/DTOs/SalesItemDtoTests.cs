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
    public class SalesItemDtoTests
    {
        private SalesItemDto _sut;

        #region Helpers

        #endregion

        #region Tests

        #region Class Tests
        [Fact]
        public void SalesItemDto_IsImmutable()
        {
            // Arrange
            _sut = new();

            // Act
            var isImmutable = ImmutableHelper.IsImmutable(_sut.GetType());

            // Assert
            isImmutable.Should().BeTrue();
        }

        [Fact]
        public void SalesItemDto_InheritsFromIEntity()
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

        #region TotalQuantity Tests
        [Fact]
        public void TotalQuantity_ShouldBe0_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.TotalQuantity.Should().Be(0);
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(250)]
        public void TotalQuantity_ShouldBeValue_WhenSetInConstructor(uint totalQuantity)
        {
            // Arrange

            // Act
            _sut = new()
            {
                TotalQuantity = totalQuantity
            };

            // Assert
            _sut.TotalQuantity.Should().Be(totalQuantity);
        }

        #endregion

        #region Name Tests
        [Fact]
        public void Name_ShouldBeEmptyString_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.Name.Should().BeEmpty();
        }
        [Fact]
        public void Name_ShouldBeValue_WhenSetInConstructor()
        {
            // Arrange
            var name = "Sales Item Name";

            // Act
            _sut = new()
            {
                Name = name
            };

            // Assert
            _sut.Name.Should().Be(name);
        }

        #endregion

        #region IsArchived Tests
        [Fact]
        public void IsArchived_ShouldBeFalse_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.IsArchived.Should().BeFalse();
        }
        [Fact]
        public void IsArchived_ShouldBeTrue_WhenSetToTrueInConstructor()
        {
            // Arrange

            // Act
            _sut = new()
            {
                IsArchived = true
            };

            // Assert
            _sut.IsArchived.Should().BeTrue();
        }

        #endregion

        #region CreationDate Tests
        [Fact]
        public void CreationDate_ShouldBeJanuary1st2019_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.CreationDate.Should().BeSameDateAs(new DateTime(2019, 1, 1));
        }
        [Fact]
        public void CreationDate_ShouldBeTrue_WhenSetInConstructor()
        {
            // Arrange

            // Act
            _sut = new()
            {
                CreationDate = new DateTime(2021, 5, 10)
            };

            // Assert
            _sut.CreationDate.Should().BeSameDateAs(new DateTime(2021, 5, 10));
        }

        #endregion

        #region CreationDate Tests
        [Fact]
        public void ReleaseDate_ShouldBeJanuary1st2019_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.ReleaseDate.Should().BeSameDateAs(new DateTime(2019, 1, 1));
        }
        [Fact]
        public void ReleaseDate_ShouldBeTrue_WhenSetInConstructor()
        {
            // Arrange

            // Act
            _sut = new()
            {
                ReleaseDate = new DateTime(2021, 5, 10)
            };

            // Assert
            _sut.ReleaseDate.Should().BeSameDateAs(new DateTime(2021, 5, 10));
        }

        #endregion

        #endregion

        #endregion
    }
}
