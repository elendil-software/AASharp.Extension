using System;
using System.Collections.Generic;
using AASharp.Extension.Coordinates.Earth;
using AASharp.Extension.Coordinates.Sky;
using Xunit;

namespace AASharp.Extension.Test.Coordinates.HorizontalCoordinates
{
    public class HorizontalCoordinatesTest
    {
        public static IEnumerable<object[]> GetHorizontalCoordinatesTest => new[]
        {
            new object[] { new DateTime(2018, 6, 21, 0, 0, 0), 2, 69.269898157835428, 26.798507895622787 }
        };

        [Theory]
        [MemberData(nameof(GetHorizontalCoordinatesTest))]
        public void GetHorizontalCoordinatesReturnsCorrectValue(DateTime dateTime, int timeZone, double expectedAzimuth, double expectedAltitude)
        {
            var earthLocation = new EarthLocation(new Latitude(47.1640833333), new Longitude(6.9894500000), 1072, timeZone);
            var objectCoordinates = new AASharp.Extension.Coordinates.Sky.Coordinates(new RightAscension(18.9048396), new Declination(33.05527), Epoch.LocalTopocentric);
            var localDateTime = new DateTime(2018, 7, 3, 20, 0, 0);

            (double azimuth, double altitude) = new Extension.Coordinates.HorizontalCoordinates.HorizontalCoordinates().GetHorizontalCoordinates(objectCoordinates, earthLocation, localDateTime);

            Assert.Equal(expectedAzimuth, azimuth);
            Assert.Equal(expectedAltitude, altitude);
        }
    }
}