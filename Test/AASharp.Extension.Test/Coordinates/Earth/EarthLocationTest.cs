using System;
using System.Collections.Generic;
using AASharp.Extension.Coordinates.Earth;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.Earth
{
    public class EarthLocationTest
    {
        public static IEnumerable<object[]> ConstructorData => new[]
        {
            new object[] {null, null, 0.0, 0.0f },
            new object[] {null, new Longitude(0.0), 0.0, 0.0f },
            new object[] {new Latitude(0.0), null, 0.0, 0.0f }
        };

        [Theory, MemberData(nameof(ConstructorData))]
        public void Given_EmptyOrNullParameter_Instantiation_Should_Raise_ArgumentNullException(Latitude latitude, Longitude longitude, double altitude, double timeZone)
        {
            Assert.Throws<ArgumentNullException>(() => new EarthLocation(latitude, longitude, altitude, timeZone));
        }

        [Fact]
        public void AfterInitialization_CoordinatesObject_ContainsGivenValues()
        {
            var latitude = new Latitude(10);
            var longitude = new Longitude(20);
            double altitude = 123.0;
            double timeZone = 2.0;

            var earthLocation = new EarthLocation(latitude, longitude, altitude, timeZone);

            Assert.Same(latitude, earthLocation.Latitude);
            Assert.Same(longitude, earthLocation.Longitude);
            Assert.Equal(altitude, earthLocation.Altitude);
            Assert.Equal(timeZone, earthLocation.TimeZone);
        }

        [Fact]
        public void AfterInitializationWithDecimal_CoordinatesObject_ContainsGivenValues()
        {
            double latitude = 10.0;
            double longitude = 20.0;
            double altitude = 123.0;
            double timeZone = 2.0;
            
            var earthLocation = new EarthLocation(latitude, longitude, altitude, timeZone);

            Assert.Equal(latitude, earthLocation.Latitude.DecimalValue);
            Assert.Equal(longitude, earthLocation.Longitude.DecimalValue);
            Assert.Equal(altitude, earthLocation.Altitude);
            Assert.Equal(timeZone, earthLocation.TimeZone);
        }
    }
}