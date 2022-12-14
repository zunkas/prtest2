using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SwedbankPay.Sdk
{
    internal static class TypeExtensions
    {
        public static IList<TFieldType> GetFieldsOfType<TFieldType>(this Type type)
        {
            return type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(p => type.IsAssignableFrom(p.FieldType))
                .Select(pi => (TFieldType)pi.GetValue(null))
                .ToList();
        }
    }
}