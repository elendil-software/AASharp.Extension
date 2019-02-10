using System;
using AASharp.Extension.Coordinates.Earth;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.Earth
{
    public class LongitudeTest
    {
        [Theory]
        [InlineData(180.00001)]
        [InlineData(-180.00001)]
        public void Given_OutOfRangeDoubleLongitude_Instantiation_Should_Raise_ArgumentOutOfRangeException(
            double longitude)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Longitude(longitude));
        }

        [Theory]
        [InlineData(90.00)]
        [InlineData(-90.00)]
        public void Given_InRangeDoubleLongitude_Instantiation_Succeeds(double longitude)
        {
            var lon = new Longitude(longitude);
            Assert.Equal(longitude, lon.DecimalValue);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Given_EmptyOrNullStringLongitude_Instantiation_Should_Raise_ArgumentNullException(string longitude)
        {
            Assert.Throws<ArgumentNullException>(() => new Longitude(longitude));
        }

        [Theory]
        [InlineData("a")]
        public void Given_UnparsableStringLongitude_Instantiation_Should_Raise_FormatException(string longitude)
        {
            Assert.Throws<FormatException>(() => new Longitude(longitude));
        }

        [Theory]
        [InlineData("81°10'20.00\"", 81.172222222222231)]
        [InlineData("-81°10'20.00\"", -81.172222222222231)]
        [InlineData("  80°00'00.01\"  ", 80.00000277777778)]
        [InlineData("  -80°00'00.01\"  ", -80.00000277777778)]
        public void Given_Parsable_StringRightAscension_Instantiation_Succeeds(string longitude, double expectedLongitude)
        {
            var lon = new Longitude(longitude);
            Assert.Equal(expectedLongitude, lon.DecimalValue);
        }

        [Theory]
        [InlineData("181°10'20.00\"")]
        [InlineData("-181°10'20.00\"")]
        [InlineData("180°00'00.01\"")]
        [InlineData("-180°00'00.01\"")]
        public void Given_OutOfRangeStringLongitude_Instantiation_Should_Raise_ArgumentOutOfRangeException(
            string longitude)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Longitude(longitude));
        }

        [Theory]
        [InlineData(10.341777777777779d, "10°20'30.4\"")]
        [InlineData(-10.341777777777779d, "-10°20'30.4\"")]
        [InlineData(0.0, "0°0'0\"")]
        public void Given_DecimalLongitude_DMSValueProperty_ShouldBe_Equivalent(double longitude, string expected)
        {
            var lon = new Longitude(longitude);
            Assert.Equal(expected, lon.DmsValue);
        }

        [Theory]
        [InlineData("10°20'30.4\"", 10.341777777777779d)]
        [InlineData("-10°20'30.4\"", -10.341777777777779d)]
        [InlineData("0°0'0\"", 0.0)]
        public void Given_StringLongitude_DecimalValueProperty_ShouldBe_Equivalent(string longitude, double expected)
        {
            var lon = new Longitude(longitude);
            Assert.Equal(expected, lon.DecimalValue);
        }

        [Theory]
        [InlineData("10°20'30.4\"", "10°20'30.4\"")]
        [InlineData("-10°20'30.4\"", "-10°20'30.4\"")]
        [InlineData("0°0'0\"", "0°0'0\"")]
        public void Given_StringLongitude_DMSValueProperty_ShouldBe_Same(string longitude, string expected)
        {
            var lon = new Longitude(longitude);
            Assert.Equal(expected, lon.DmsValue);
        }
    }
}