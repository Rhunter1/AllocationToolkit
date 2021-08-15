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
using System.Linq;
using System.Reflection;

namespace AllocationToolkit.TestsHelpers
{
    public class ImmutableHelper
    {
        /// <summary>
        /// Determines whether the generic type <typeparamref name="T"/> is immutable.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <returns>Whether the generic type <typeparamref name="T"/> is immutable.</returns>
        public static bool IsImmutable<T>()
        {
            return IsImmutable(typeof(T));
        }
        /// <summary>
        /// Determines whether the input type is immutable.
        /// </summary>
        /// <param name="type">The input type to check.</param>
        /// <returns>Determines whether the input type is immutable.</returns>
        public static bool IsImmutable(Type type)
        {
            if (type.IsPrimitive
                || type.IsValueType
                || type.IsEnum) 
                return true;

            if (type == typeof(string)) 
                return true;

            var fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (!fieldInfos.All(f => f.IsInitOnly)) 
                return false;

            return fieldInfos.All(f => IsImmutable(f.FieldType));
        }
        /// <summary>
        /// Determines whether the input field info is immutable.
        /// </summary>
        /// <param name="fieldInfo">The input field info to check.</param>
        /// <returns>Whether the input field info is immutable.</returns>
        public static bool IsImmutable(FieldInfo fieldInfo)
        {
            if (!fieldInfo.IsInitOnly)
                return false;

            return IsImmutable(fieldInfo.FieldType);
        }
    }
}
