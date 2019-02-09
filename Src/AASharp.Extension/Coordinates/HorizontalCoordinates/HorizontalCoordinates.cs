using System;
using AASharp.Extension.Coordinates.Earth;

namespace AASharp.Extension.Coordinates.HorizontalCoordinates
{
    public class HorizontalCoordinates
    {
        public (double azimuth, double altitude) GetHorizontalCoordinates(Coordinates.Sky.Coordinates objectCoordinates, EarthLocation earthLocation, DateTime locaDateTime)
        {
            double longitude = -earthLocation.Longitude.DecimalValue;//West is considered positive by AASharp
            double latitude = earthLocation.Latitude.DecimalValue;
            double height = earthLocation.Altitude;
            double ra = objectCoordinates.RightAscension.DecimalValue;
            double dec = objectCoordinates.Declination.DecimalValue;

            AASDate date = new AASDate(locaDateTime.Year, locaDateTime.Month, locaDateTime.Day, locaDateTime.Hour - earthLocation.TimeZone, locaDateTime.Minute, locaDateTime.Second, true);
            double jd = AASDynamicalTime.UTC2TT(date.Julian);

            double radiusVector = GetRadiusVector(jd);

            AAS2DCoordinate topocentricCoordinates = AASParallax.Equatorial2Topocentric(ra, dec, radiusVector, longitude, latitude, height, jd);
            double apparentGreenwichSiderealTime = AASSidereal.ApparentGreenwichSiderealTime(date.Julian);
            double localHourAngle = apparentGreenwichSiderealTime - AASCoordinateTransformation.DegreesToHours(longitude) - topocentricCoordinates.X;
            AAS2DCoordinate horizontalCoordinates = AASCoordinateTransformation.Equatorial2Horizontal(localHourAngle, topocentricCoordinates.Y, latitude);
            horizontalCoordinates.X = (horizontalCoordinates.X + 180) % 360;

            return (horizontalCoordinates.X, horizontalCoordinates.Y);
        }

        protected virtual double GetRadiusVector(double jd)
        {
            return AASEarth.RadiusVector(jd, false);
        }
    }
}