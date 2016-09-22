namespace System
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 取得 UNIX 時間，由指定的 System.DateTime 物件減去 1970/01/01 所得時間的完整秒數。
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns>秒數，其值為指定 System.DateTime 物件之 UNIX 時間。</returns>
        public static double ToUNIXTime(this DateTime dateTime)
        {
            return dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        /// <summary>
        /// 摘要: 
        ///      取得 System.DateTime 物件，由指定的  UNIX 時間轉換之格林威治時間。
        /// </summary>
        /// <param name="value"></param>
        /// <returns> System.DateTime 物件，其為指定 UNIX 時間之格林威治時間。</returns>
        public static DateTime ToDateTime(this int value)
        {
            return (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(value);
        }
    }
}

