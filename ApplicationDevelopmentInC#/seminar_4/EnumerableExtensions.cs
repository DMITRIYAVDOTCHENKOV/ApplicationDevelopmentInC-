﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_4
{
    internal static class EnumerableExtensions
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> values, Func<T, bool> predicate)
        {
            foreach (var value in values)
            {
                if (predicate(value)) yield return value;
            }
        }
    }
}

