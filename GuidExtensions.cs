namespace System
{
    public static class GuidExtensions
    {
        /// <summary>
        /// Returns a 32-bit signed integer converted from a globally unique identifier (GUID).
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A 32-bit signed integer formed by a globally unique identifier (GUID).</returns>
        public static int ToInt32(this Guid value)
        {
            var byteArray = value.ToByteArray();
            var result = Math.Abs(BitConverter.ToInt32(byteArray, 0));

            return result;
        }
    }
}

