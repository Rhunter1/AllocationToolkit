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
using System;
using System.Collections.Generic;

namespace AllocationToolkit.Services.DTOs
{
    /// <summary>
    /// Represents a set of items to sell.
    /// </summary>
    public record SalesItemDto : IEntity
    {
        /// <summary>
        /// Gets the identifier for the <see cref="SalesItemDto"/>.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Gets or sets the total number of <see cref="SalesItemDto"/>s available.
        /// </summary>
        public uint TotalQuantity { get; init; }

        /// <summary>
        /// Gets or sets the name of the <see cref="SalesItemDto"/>.
        /// </summary>
        public string Name { get; init; } = "";

        /// <summary>
        /// Gets or sets whether the <see cref="SalesItemDto"/> is archived.
        /// </summary>
        public bool IsArchived { get; init; }

        /// <summary>
        /// Gets or sets the creation date of the <see cref="SalesItemDto"/>.
        /// </summary>
        public DateTime CreationDate { get; init; } = new DateTime(2019, 1, 1);
        /// <summary>
        /// Gets or sets the release date of the <see cref="SalesItemDto"/>.
        /// </summary>
        public DateTime ReleaseDate { get; init; } = new DateTime(2019, 1, 1);

    }
}
