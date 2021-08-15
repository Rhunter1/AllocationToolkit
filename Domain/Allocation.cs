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

namespace AllocationToolkit.Domain
{
    public record Allocation
    {
        #region Private Fields
        /// <summary>
        /// The paid quantity.
        /// </summary>
        private uint _paidQuantity = 0;
        /// <summary>
        /// The sent quantity.
        /// </summary>
        private uint _sentQuantity = 0;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets the identifier for the <see cref="Allocation"/>.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Gets the <see cref="Domain.User"/> the <see cref="Allocation"/> is allocated to.
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Gets the <see cref="Domain.SalesItem"/> that is allocated.
        /// </summary>
        public SalesItem SalesItem { get; }

        /// <summary>
        /// Gets or sets the quantity of items that have been allocated.
        /// </summary>
        public uint AllocatedQuantity { get; set; }
        /// <summary>
        /// Gets or sets the quantity of items that have been paid for.
        /// </summary>
        public uint PaidQuantity
        {
            get { return _paidQuantity; }
            set
            {
                if (value > AllocatedQuantity)
                    throw new ArgumentException("PaidQuantity cannot be greater than the AllocatedQuantity.");

                _paidQuantity = value;
            }
        }
        /// <summary>
        /// Gets or sets the quantity of items that have already been sent.
        /// </summary>
        public uint SentQuantity
        {
            get { return _sentQuantity; }
            set
            {
                if (value > AllocatedQuantity)
                    throw new ArgumentException("SentQuantity cannot be greater than the AllocatedQuantity.");

                _sentQuantity = value;
            }
        }

        /// <summary>
        /// Gets the allocation request date.
        /// </summary>
        public DateTime RequestedDate { get; init; } = DateTime.Now;

        #endregion

        #region Constructors/Destructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation"/> class with the specified <see cref="Domain.User"/> and <see cref="Domain.SalesItem"/>.
        /// </summary>
        /// <param name="user">The <see cref="Domain.User"/> the <see cref="Allocation"/> should be associated with.</param>
        /// <param name="salesItem">The <see cref="Domain.SalesItem"/> the <see cref="Allocation"/> should be associated with.</param>
        public Allocation(User user, SalesItem salesItem)
        {
            User = user;
            SalesItem = salesItem;
        }

        #endregion

    }
}
