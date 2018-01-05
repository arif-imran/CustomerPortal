// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The key value pair helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Grosvenor.Mobile.Common.Utils
{
    using System;
    using System.Collections.Generic;

    /// <summary>The key value pair helper.</summary>
    public static class ListExtensions
    {
        /// <summary>The dictionary return type.</summary>
        public enum DictReturnType
        {
            /// <summary>The unknown.</summary>
            Unknown,

            /// <summary>The string.</summary>
            String,

            /// <summary>The guid.</summary>
            Guid,

            /// <summary>The date time.</summary>
            DateTime,

            /// <summary>The int.</summary>
            Int,

            /// <summary>The string list.</summary>
            StringList,

            /// <summary>The boolean.</summary>
            Boolean
        }

        /// <summary>The get value.</summary>
        /// <param name="mapping">The mapping.</param>
        /// <param name="key">The key.</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetValue<TKey, TValue>(this List<KeyValuePair<TKey, TValue>> mapping, TKey key)
        {
            foreach (var kvp in mapping) if (kvp.Key.Equals(key)) return kvp.Value.ToString();

            return string.Empty;
        }

        /// <summary>The get value.</summary>
        /// <param name="mapping">The mapping.</param>
        /// <param name="key">The key.</param>
        /// <param name="isGuid">The is guid.</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns>The <see cref="Guid"/>.</returns>
        public static Guid GetValue<TKey, TValue>(this List<KeyValuePair<TKey, TValue>> mapping, TKey key, bool isGuid)
        {
            foreach (var kvp in mapping)
                if (kvp.Key.Equals(key))
                {
                    if (kvp.Value == null) return Guid.Empty;
                    var parsedGuid = Guid.Empty;
                    Guid.TryParse(kvp.Value.ToString(), out parsedGuid);
                    return parsedGuid;
                }

            return Guid.Empty;
        }

        /// <summary>The get value.</summary>
        /// <param name="mapping">The mapping.</param>
        /// <param name="key">The key.</param>
        /// <param name="returnType">The return type.</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns>The <see cref="object"/>.</returns>
        public static object GetValue<TKey, TValue>(
            this List<KeyValuePair<TKey, TValue>> mapping,
            TKey key,
            DictReturnType returnType)
        {
            foreach (var kvp in mapping)
                if (kvp.Key.Equals(key))
                {
                    if (returnType == DictReturnType.StringList)
                    {
                    }

                    if (returnType == DictReturnType.Guid)
                    {
                        var parsedGuid = Guid.Empty;
                        var success = Guid.TryParse(kvp.Value.ToString(), out parsedGuid);
                        if (success) return parsedGuid;
                        else return Guid.Empty;
                    }
                    else if (returnType == DictReturnType.DateTime)
                    {
                        var parsedDate = DateTime.MinValue;
                        var success = DateTime.TryParse(kvp.Value.ToString(), out parsedDate);
                        if (success) return parsedDate;
                        else return null;
                    }
                    else if (returnType == DictReturnType.Int)
                    {
                        var parsedInt = -1;
                        var success = int.TryParse(kvp.Value.ToString(), out parsedInt);
                        if (success) return parsedInt;
                        else return -1;
                    }
                    else if (returnType == DictReturnType.Boolean)
                    {
                        var parsedBool = false;
                        var success = bool.TryParse(kvp.Value.ToString(), out parsedBool);
                        if (success) return parsedBool;
                        else return false;
                    }
                    else
                    {
                        return kvp.Value.ToString();
                    }
                }

            return null;
        }
    }
}