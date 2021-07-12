﻿/* 
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
    public record User
    {
        #region Members

        #region Private

        #endregion

        #region Public
        /// <summary>
        /// Gets the <see cref="User"/> identifier.
        /// </summary>
        public Guid Id { get; init; } = Guid.Empty;

        /// <summary>
        /// Gets the name of the <see cref="User"/>.
        /// </summary>
        public string FullName { get; init; } = "";
        /// <summary>
        /// Gets the mailing address of the <see cref="User"/>.
        /// </summary>
        public string MailingAddress { get; init; } = "";

        #endregion

        #endregion

        #region Constructors/Destructor

        #endregion

    }
}
