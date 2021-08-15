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
using System;
using System.Collections.Generic;

namespace AllocationToolkit.Services
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// Gets all of the <typeparamref name="TEntity"/> items in the <see cref="IRepository{TEntity}"/>.
        /// </summary>
        /// <returns>All of the <typeparamref name="TEntity"/> items.</returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Gets the <typeparamref name="TEntity"/> from the <see cref="IRepository{TEntity}"/> by ID.
        /// </summary>
        /// <param name="id">The <typeparamref name="TEntity"/> ID.</param>
        /// <returns>A <typeparamref name="TEntity"/> with the specified <paramref name="id"/>.</returns>
        TEntity GetById(Guid id);
        /// <summary>
        /// Saves a <typeparamref name="TEntity"/> to the <see cref="IRepository{TEntity}"/>.
        /// </summary>
        /// <param name="entity">The <typeparamref name="TEntity"/> to save.</param>
        /// <returns>The saved <typeparamref name="TEntity"/> on success; else <see langword="null"/>.</returns>
        TEntity Save(TEntity entity);
        /// <summary>
        /// Updates a <typeparamref name="TEntity"/> in the <see cref="IRepository{TEntity}"/>.
        /// </summary>
        /// <param name="entity">The <typeparamref name="TEntity"/> to update.</param>
        void Update(TEntity entity);
        /// <summary>
        /// Deletes a <typeparamref name="TEntity"/> from the <see cref="IRepository{TEntity}"/>.
        /// </summary>
        /// <param name="entity">The <typeparamref name="TEntity"/> to delete.</param>
        void Delete(TEntity entity);

    }
}
