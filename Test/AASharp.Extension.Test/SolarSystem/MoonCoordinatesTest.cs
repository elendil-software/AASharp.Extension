using System;
using System.Collections.Generic;
using AASharp.Extension.Coordinates.Earth;
using AASharp.Extension.SolarSystem;
using Xunit;

namespace AASharp.Extension.Test.SolarSystem
{
    public class MoonCoordinatesTest
    {
        public static IEnumerable<object[]> GetHorizontalCoordinatesTest => new[]
       {
            new object[] { new DateTime(2018, 5, 29, 16, 20, 48), 2, 63.679288010021594, -44.44493044009706 },
            new object[] { new DateTime(2018, 5, 29, 21, 9, 14), 2, 117.92450346513874, 0.95507179389623187 },
            new object[] { new DateTime(2018, 6, 6, 20, 34, 8), 2, 19.02028769552453, -49.947812918411 },
            new object[] { new DateTime(2018, 6, 13, 21, 45, 04), 2, 307.45053878947823, -5.8503957784324943 },
            new object[] { new DateTime(2018, 6, 20, 12, 52, 34), 2, 78.284894690611, -5.0948267238774392 }
        };

        [Theory]
        [MemberData(nameof(GetHorizontalCoordinatesTest))]
        public void GetHorizontalCoordinatesReturnsCorrectValue(DateTime dateTime, double timeZone, double expectedAzimuth, double expectedAltitude)
        {
            var earthLocation = new EarthLocation(new Latitude(47.1640833333), new Longitude(6.9894500000), 1072, timeZone);

            var moon = new MoonCoordinates(earthLocation);
            (double azimuth, double altitude) = moon.GetHorizontalCoordinates(dateTime);

            Assert.Equal(expectedAzimuth, azimuth);
            Assert.Equal(expectedAltitude, altitude);
        }
    }
}