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
    public class UserTests
    {

        private User _sut;

        #region Helpers

        #endregion

        #region Tests

        #region Class Tests
        [Fact]
        public void User_IsImmutable()
        {
            // Arrange
            _sut = new();

            // Act
            var isImmutable = ImmutableHelper.IsImmutable(_sut.GetType());

            // Assert
            isImmutable.Should().BeTrue();
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

        #region FullName Tests
        [Fact]
        public void FullName_ShouldBeEmptyString_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.FullName.Should().BeEmpty();
        }
        [Theory]
        [InlineData("Jane Doe")]
        [InlineData("John Doe")]
        public void FullName_ShouldBeValue_WhenSetInConstructor(string name)
        {
            // Arrange

            // Act
            _sut = new()
            {
                FullName = name
            };

            // Assert
            _sut.FullName.Should().Be(name);
        }

        #endregion

        #region MailingAddress Tests
        [Fact]
        public void MailingAddress_ShouldBeEmptyString_ByDefault()
        {
            // Arrange
            _sut = new();

            // Act

            // Assert
            _sut.MailingAddress.Should().BeEmpty();
        }
        [Theory]
        [InlineData("6 Arnold Ave. Midland, MI 48640")]
        [InlineData("472 Wilson Lane Bowling Green, KY 42101")]
        public void MailingAddressCanBeSet(string mailingAddress)
        {
            // Arrange

            // Act
            _sut = new()
            {
                MailingAddress = mailingAddress
            };

            // Assert
            _sut.MailingAddress.Should().Be(mailingAddress);
        }

        #endregion

        #endregion

        #endregion

    }
}
