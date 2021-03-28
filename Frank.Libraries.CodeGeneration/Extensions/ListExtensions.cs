﻿using System;
using System.Collections.Generic;

namespace Frank.Libraries.CodeGeneration.Extensions
{
    public static class ListExtensions
    {
        public static List<T> Add<T>(this List<T> source, params T[] values)
        {
            source.AddRange(values);
            return source;
        }

        public static List<T> TryAdd<T>(this List<T> source, T value)
        {
            try
            {
                source.Add(value);
            }
            catch (Exception)
            {
            }

            return source;
        }

        public static List<T> TryAdd<T>(this List<T> source, IEnumerable<T> values)
        {
            try
            {
                source.AddRange(values);
            }
            catch (Exception)
            {
            }

            return source;
        }

        //public static List<T> DoForAll<T>(this List<T> source, Action action)
        //{
        //    try
        //    {
        //        source.AddRange(values);
        //    }
        //    catch (Exception)
        //    {
        //    }

        //    return source;
        //}
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<string> ToStrings<T>(this IEnumerable<T> source)
        {
            var output = new List<string>();

            foreach (var value in source)
            {
                output.TryAdd(value!.ToString());
            }

            return output;
        }

        public static IEnumerable<T> DoForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var value in source)
            {
                action.Invoke(value);
            }

            return source;
        }
    }
}