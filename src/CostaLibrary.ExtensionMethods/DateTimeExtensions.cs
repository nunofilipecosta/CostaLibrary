namespace CostaLibrary.ExtensionMethods
{
    using System;
    using System.Xml;

    public static class DateTimeExtensions
    {
        public static string ToLegacyFormat(this DateTime dateTime)
        {
            var formattedDate = dateTime.Year > 1930
                ? dateTime.ToString("1yyMMdd")
                : dateTime.ToString("0yyMMdd");

            return formattedDate;
        }

        public static string ToXmlDateTime(this DateTime dateTime, XmlDateTimeSerializationMode mode = XmlDateTimeSerializationMode.Utc)
        {
            var result = XmlConvert.ToString(dateTime, mode);

            return result;
        }
    }
}
