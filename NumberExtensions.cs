namespace System
{
    public static class NumberExtensions
    {
        /// <summary>
        /// Returns an indication whether the value is zero.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The number to convert.</param>
        /// <returns>true if value is zero; otherwise, false.</returns>
        static public bool IsZero<T>(this T value) where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            return !Convert.ToBoolean(value);
        }
    }
}

