using System;
using System.Collections.Generic;
using AASharp.Extension.Coordinates.Sky;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.Sky
{
    public class CoordinatesTest
    {
        public static IEnumerable<object[]> ConstructorData => new[]
        {
            new object[] {null, null, null},
            new object[] {null, new Declination(0.0), Epoch.J2000},
            new object[] {new RightAscension(0.0), null, Epoch.J2000}
        };


        [Theory, MemberData(nameof(ConstructorData))]
        public void Given_EmptyOrNullParameter_Instantiation_Should_Raise_ArgumentNullException(
            RightAscension rightAscension, Declination declination, Epoch epoch)
        {
            Assert.Throws<ArgumentNullException>(
               () => new AASharp.Extension.Coordinates.Sky.Coordinates(rightAscension, declination, epoch));
        }

        [Fact]
        public void AfterInitialization_CoordinatesObject_ContainsGivenValues()
        {
            var rightAscension = new RightAscension(10);
            var declination = new Declination(20);
            var epoch = Epoch.LocalTopocentric;

            var coordinates = new AASharp.Extension.Coordinates.Sky.Coordinates(rightAscension, declination,
                epoch);

            Assert.Equal(epoch, coordinates.Epoch);
            Assert.Same(rightAscension, coordinates.RightAscension);
            Assert.Same(declination, coordinates.Declination);
        }

        [Fact]
        public void AfterInitializationWithDecimal_CoordinatesObject_ContainsGivenValues()
        {
            var rightAscension = 10.0;
            var declination = 20.0;
            var epoch = Epoch.LocalTopocentric;

            var coordinates = new AASharp.Extension.Coordinates.Sky.Coordinates(rightAscension, declination,
                epoch);

            Assert.Equal(epoch, coordinates.Epoch);
            Assert.Equal(rightAscension, coordinates.RightAscension.DecimalValue);
            Assert.Equal(declination, coordinates.Declination.DecimalValue);
        }
    }
}