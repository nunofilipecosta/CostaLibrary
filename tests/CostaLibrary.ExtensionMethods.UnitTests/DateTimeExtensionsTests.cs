namespace CostaLibrary.ExtensionMethods.UnitTests
{
    using System;
    using System.Xml;
    using Xunit;

    public class DateTimeExtensionsTests
    {
        [Fact]
        public void ToLelacyFormat_C20()
        {
            var date = new DateTime(1920, 12, 31);
            var result = date.ToLegacyFormat();

            Assert.Equal("0201231", result);
        }

        [Fact]
        public void ToLelacyFormat_C21()
        {
            var date = new DateTime(2013, 10, 31);
            var result = date.ToLegacyFormat();

            Assert.Equal("1131031", result);
        }

        [Fact]
        public void ToXmlDateTime()
        {
            var date = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            var result = date.ToXmlDateTime();
            var result2 = date.ToXmlDateTime(XmlDateTimeSerializationMode.Local);

            Assert.Equal("2013-10-24T13:10:15.951Z", result);
            Assert.Equal("2013-10-24T13:10:15.951+02:00", result2);

        }
    }
}
