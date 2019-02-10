using System;
using System.Collections.Generic;
using AASharp.Extension.Coordinates.Earth;
using AASharp.Extension.Coordinates.HorizontalCoordinates;
using AASharp.Extension.SolarSystem;
using Xunit;

namespace AASharp.Extension.Test.SolarSystem
{
    
    public class SunCoordinatesTest
    {
        public static IEnumerable<object[]> GetHorizontalCoordinatesTest => new[]
        {
            new object[] { new DateTime(2018, 6, 21, 0, 0, 0), 2, 337.66261755003188, -16.308340633798597 },
            new object[] { new DateTime(2018, 6, 21, 6, 0, 0), 2, 57.415252660804128, 2.4906240564566184 },
            new object[] { new DateTime(2018, 6, 21, 12, 0, 0), 2, 133.52406067786023, 59.75884431120852 },
            new object[] { new DateTime(2018, 6, 21, 18, 0, 0), 2, 270.16857955650283, 32.685473030246392 },
            new object[] { new DateTime(2018, 12, 21, 0, 0, 0), 1, 343.29569075595396, -65.5285174729199 },
            new object[] { new DateTime(2018, 12, 21, 6, 0, 0), 1, 101.35658868432125, -21.897589697766414 },
            new object[] { new DateTime(2018, 12, 21, 12, 0, 0), 1, 172.70221317669723, 19.073578900337385 },
            new object[] { new DateTime(2018, 12, 21, 18, 0, 0), 1, 248.471959626103, -12.106439387296032 }
        };

        [Theory]
        [MemberData(nameof(GetHorizontalCoordinatesTest))]
        public void GetHorizontalCoordinatesReturnsCorrectValue(DateTime dateTime, int timeZone, double expectedAzimuth, double expectedAltitude)
        {
            var earthLocation = new EarthLocation(new Latitude(47.1640833333), new Longitude(6.9894500000), 1072, timeZone);

            var sun = new SunCoordinates(earthLocation);
            (double azimuth, double altitude) = sun.GetHorizontalCoordinates(dateTime);

            Assert.Equal(expectedAzimuth, azimuth);
            Assert.Equal(expectedAltitude, altitude);
        }
    }
}


