using System;
using AASharp.Extension.Coordinates.Earth;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.Earth
{
    public class LatitudeTest
    {
        [Theory]
        [InlineData(180.00001)]
        [InlineData(-180.00001)]
        public void Given_OutOfRangeDoubleLatitude_Instantiation_Should_Raise_ArgumentOutOfRangeException(
            double latitude)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Latitude(latitude));
        }

        [Theory]
        [InlineData(90.0)]
        [InlineData(45.0)]
        [InlineData(0.00)]
        [InlineData(-45.0)]
        [InlineData(-90.0)]
        public void Given_InValidRangeDoubleLatitude_Instantiation_Succeeds(double latitude)
        {
            var lat = new Latitude(latitude);
            Assert.Equal(latitude, lat.DecimalValue);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Given_EmptyOrNullStringLatitude_Instantiation_Should_Raise_ArgumentNullException(string latitude)
        {
            Assert.Throws<ArgumentNullException>(() => new Latitude(latitude));
        }

        [Theory]
        [InlineData("a")]
        public void Given_UnparsableStringLatitude_Instantiation_Should_Raise_FormatException(string latitude)
        {
            Assert.Throws<FormatException>(() => new Latitude(latitude));
        }

        [Theory]
        [InlineData("81°10'20.00\"", 81.172222222222231)]
        [InlineData("-81°10'20.00\"", -81.172222222222231)]
        [InlineData("  80°00'00.01\"  ", 80.00000277777778)]
        [InlineData("  -80°00'00.01\"  ", -80.00000277777778)]
        public void Given_Parsable_StringRightAscension_Instantiation_Succeeds(string latitude, double expectedLatitude)
        {
            var lat = new Latitude(latitude);
            Assert.Equal(expectedLatitude, lat.DecimalValue);
        }

        [Theory]
        [InlineData("91°10'20.00\"")]
        [InlineData("-91°10'20.00\"")]
        [InlineData("90°00'00.01\"")]
        [InlineData("-90°00'00.01\"")]
        public void Given_OutOfRangeStringLatitude_Instantiation_Should_Raise_ArgumentOutOfRangeException(
            string latitude)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Latitude(latitude));
        }

        [Theory]
        [InlineData(10.341777777777779d, "10°20'30.4\"")]
        [InlineData(-10.341777777777779d, "-10°20'30.4\"")]
        [InlineData(0.0, "0°0'0\"")]
        public void Given_DecimalLatitude_DMSValueProperty_ShouldBe_Equivalent(double latitude, string expected)
        {
            var lat = new Latitude(latitude);
            Assert.Equal(expected, lat.DmsValue);
        }

        [Theory]
        [InlineData("10°20'30.4\"", 10.341777777777779d)]
        [InlineData("-10°20'30.4\"", -10.341777777777779d)]
        [InlineData("0°0'0\"", 0.0)]
        public void Given_StringLatitude_DecimalValueProperty_ShouldBe_Equivalent(string latitude, double expected)
        {
            var lat = new Latitude(latitude);
            Assert.Equal(expected, lat.DecimalValue);
        }

        [Theory]
        [InlineData("10°20'30.4\"", "10°20'30.4\"")]
        [InlineData("-10°20'30.4\"", "-10°20'30.4\"")]
        [InlineData("0°0'0\"", "0°0'0\"")]
        public void Given_StringLatitude_DMSValueProperty_ShouldBe_Same(string latitude, string expected)
        {
            var lat = new Latitude(latitude);
            Assert.Equal(expected, lat.DmsValue);
        }
    }
}