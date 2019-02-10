using System;
using AASharp.Extension.Coordinates.Sky;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.Sky
{
    public class RightAscensionTest
    {
        [Theory]
        [InlineData(24.00001)]
        [InlineData(-0.00001)]
        public void Given_OutOfRangeDoubleRightAscension_Instantiation_Should_Raise_ArgumentOutOfRangeException(double ra)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RightAscension(ra));
        }

        [Theory]
        [InlineData(24.0000)]
        [InlineData(0.0000)]
        public void Given_InRangeDoubleRightAscension_Instantiation_Succeeds(double ra)
        {
            var rightAscension = new RightAscension(ra);

            Assert.Equal(ra, rightAscension.DecimalValue);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Given_EmptyOrNullStringRightAscension_Instantiation_Should_Raise_ArgumentNullException(string ra)
        {
            Assert.Throws<ArgumentNullException>(() => new RightAscension(ra));
        }

        [Theory]
        [InlineData("1")]
        [InlineData("-01h10m20s")]
        public void Given_Unparsable_StringRightAscension_Instantiation_Should_Raise_FormatException(string ra)
        {
            Assert.Throws<FormatException>(() => new RightAscension(ra));
        }

        [Theory]
        [InlineData("09h56m46.49s", 9.946247222222222)]
        [InlineData("  09h56m46.49s  ", 9.946247222222222)]
        [InlineData("00h43m45.7495", 0.72937486111111116)]
        public void Given_Parsable_StringRightAscension_Instantiation_Succeeds(string ra, double expectedRa)
        {
            var rightAscension = new RightAscension(ra);

            Assert.Equal(expectedRa, rightAscension.DecimalValue);
        }

        [Theory]
        [InlineData("24h10m20s")]
        public void Given_OutOfRange_StringRightAscension_Instantiation_Should_Raise_ArgumentOutOfRangeException(string ra)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RightAscension(ra));
        }

        [Theory]
        [InlineData(24.0)]
        [InlineData(0.0)]
        [InlineData(15.25)]
        public void Given_DecimalRightAscensionDecimalValueProperty_ShouldBe_Same(double ra)
        {
            var rightAscension = new RightAscension(ra);
            Assert.Equal(ra, rightAscension.DecimalValue);
        }

        [Theory]
        [InlineData(15.25d, "15h15m0s")]
        [InlineData(10.341666666666667d, "10h20m30s")]
        [InlineData(0.0d, "0h0m0s")]
        public void Given_DecimalRightAscensionDMSValueProperty_ShouldBe_Equivalent(double ra, string expected)
        {
            var rightAscension = new RightAscension(ra);
            Assert.Equal(expected, rightAscension.HmsValue);
        }

        [Theory]
        [InlineData("15h15m0s", 15.25d)]
        [InlineData("10h20m30s", 10.341666666666667d)]
        [InlineData("0h0m0s", 0.0d)]
        public void Given_StringRightAscensionDecimalValueProperty_ShouldBe_Equivalent(string ra, double expected)
        {
            var rightAscension = new RightAscension(ra);
            Assert.Equal(expected, rightAscension.DecimalValue);
        }

        [Theory]
        [InlineData("15h15m0s", "15h15m0s")]
        [InlineData("10h20m30s", "10h20m30s")]
        [InlineData("10 20 30", "10h20m30s")]
        [InlineData("0h0m0s", "0h0m0s")]
        public void Given_StringRightAscensionDMSValueProperty_ShouldBe_Same(string ra, string expected)
        {
            var rightAscension = new RightAscension(ra);
            Assert.Equal(expected, rightAscension.HmsValue);
        }
    }
}