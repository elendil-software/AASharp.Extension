using System;
using AASharp.Extension.Coordinates.Sky;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.Sky
{
    public class DeclinationTest
    {
        [Theory]
        [InlineData(90.00001)]
        [InlineData(-90.00001)]
        public void Given_OutOfRangeDoubleDeclination_Instantiation_Should_Raise_ArgumentOutOfRangeException(
            double declination)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Declination(declination));
        }

        [Theory]
        [InlineData(90.00)]
        [InlineData(-90.00)]
        public void Given_InRangeDoubleDeclination_Instantiation_Succeeds(double declination)
        {
            var dec = new Declination(declination);

            Assert.Equal(declination, dec.DecimalValue);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Given_EmptyOrNullStringDeclination_Instantiation_Should_Raise_ArgumentNullException(
            string declination)
        {
            Assert.Throws<ArgumentNullException>(() => new Declination(declination));
        }

        [Theory]
        [InlineData("1")]
        public void Given_UnparsableStringDeclination_Instantiation_Should_Raise_FormatException(string declination)
        {
            Assert.Throws<FormatException>(() => new Declination(declination));
        }

        [Theory]
        [InlineData("81°10'20.00\"", 81.172222222222231)]
        [InlineData("-81°10'20.00\"", -81.172222222222231)]
        [InlineData("  80°00'00.01\"  ", 80.00000277777778)]
        [InlineData("  -80°00'00.01\"  ", -80.00000277777778)]
        public void Given_Parsable_StringRightAscension_Instantiation_Succeeds(string declination, double expectedDeclination)
        {
            var dec = new Declination(declination);
            Assert.Equal(expectedDeclination, dec.DecimalValue);
        }

        [Theory]
        [InlineData("91°10'20.00\"")]
        [InlineData("-91°10'20.00\"")]
        [InlineData("90°00'00.01\"")]
        [InlineData("-90°00'00.01\"")]
        public void Given_OutOfRangeStringDeclination_Instantiation_Should_Raise_ArgumentOutOfRangeException(
            string declination)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Declination(declination));
        }

        [Theory]
        [InlineData(90.0)]
        [InlineData(0.0)]
        [InlineData(-90.0)]
        public void Given_DecimalDeclination_DecimalValueProperty_ShouldBe_Same(double declination)
        {
            var dec = new Declination(declination);
            Assert.Equal(declination, dec.DecimalValue);
        }

        [Theory]
        [InlineData(10.341777777777779d, "10°20'30.4\"")]
        [InlineData(-10.341777777777779d, "-10°20'30.4\"")]
        [InlineData(0.0, "0°0'0\"")]
        public void Given_DecimalDeclination_DMSValueProperty_ShouldBe_Equivalent(double declination, string expected)
        {
            var dec = new Declination(declination);
            Assert.Equal(expected, dec.DmsValue);
        }

        [Theory]
        [InlineData("10°20'30.4\"", 10.341777777777779d)]
        [InlineData("-10°20'30.4\"", -10.341777777777779d)]
        [InlineData("0°0'0\"", 0.0)]
        public void Given_StringDeclination_DecimalValueProperty_ShouldBe_Equivalent(string declination, double expected)
        {
            var dec = new Declination(declination);
            Assert.Equal(expected, dec.DecimalValue);
        }

        [Theory]
        [InlineData("10°20'30.4\"", "10°20'30.4\"")]
        [InlineData("-10°20'30.4\"", "-10°20'30.4\"")]
        [InlineData("0°0'0\"", "0°0'0\"")]
        public void Given_StringDeclination_DMSValueProperty_ShouldBe_Same(string declination, string expected)
        {
            var dec = new Declination(declination);
            Assert.Equal(expected, dec.DmsValue);
        }
    }
}