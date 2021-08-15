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
    public record AllocationDto : IEntity
    {
        /// <summary>
        /// Gets the identifier for the <see cref="AllocationDto"/>.
        /// </summary>
        public Guid Id { get; init; }
        /// <summary>
        /// Gets the user identifier associated with the <see cref="AllocationDto"/>.
        /// </summary>
        public Guid UserId { get; init; }
        /// <summary>
        /// Gets the sales item identifier associated with the <see cref="AllocationDto"/>.
        /// </summary>
        public Guid SalesItemId { get; init; }

        /// <summary>
        /// Gets the quantity of items that have been allocated.
        /// </summary>
        public uint AllocatedQuantity { get; init; }
        /// <summary>
        /// Gets the quantity of items that have been paid for.
        /// </summary>
        public uint PaidQuantity { get; init; }
        /// <summary>
        /// Gets the quantity of items that have been sent.
        /// </summary>
        public uint SentQuantity { get; init; }

        /// <summary>
        /// Gets the <see cref="AllocationDto"/> request date.
        /// </summary>
        public DateTime RequestedDate { get; init; } = new DateTime(2019, 1, 1);

    }
}
