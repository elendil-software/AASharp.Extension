using System;
using System.Collections.Generic;
using AASharp.Extension.Coordinates.Earth;
using AASharp.Extension.SolarSystem;
using Xunit;

namespace AASharp.Extension.Test.SolarSystem
{
    public class MoonIlluminatedFractionTest
    {
        public static IEnumerable<object[]> GetIlluminatedFractionTest => new[]
       {
            new object[] { new DateTime(2018, 5, 29, 16, 20, 48), 2, 0.99855446816678606 },
            new object[] { new DateTime(2018, 6, 6, 20, 34, 8), 2, 0.5010607444260069 },
            new object[] { new DateTime(2018, 6, 13, 21, 45, 04), 2, 0.00097860585943593259 },
            new object[] { new DateTime(2018, 6, 20, 12, 52, 34), 2, 0.50135446782710125 }
        };

        [Theory]
        [MemberData(nameof(GetIlluminatedFractionTest))]
        public void GetIlluminatedFractionReturnsCorrectValue(DateTime dateTime, double timeZone, double expectedIlluminatedFraction)
        {
            var earthLocation = new EarthLocation(new Latitude(47.1640833333), new Longitude(6.9894500000), 1072, timeZone);

            double illuminatedFraction = MoonIlluminatedFraction.GetIlluminatedFraction(earthLocation, dateTime);

            Assert.Equal(expectedIlluminatedFraction, illuminatedFraction);
        }
    }
}