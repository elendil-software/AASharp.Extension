using System;
using AASharp.Extension.Coordinates.Earth;
using AASharp.Extension.Coordinates.HorizontalCoordinates;
using AASharp.Extension.Coordinates.Sky;

namespace AASharp.Extension.SolarSystem
{
    public class SunCoordinates : HorizontalCoordinates
    {
        private readonly EarthLocation _earthLocation;

        public SunCoordinates(EarthLocation earthLocation)
        {
            _earthLocation = earthLocation ?? throw new ArgumentNullException(nameof(earthLocation));
        }

        public (double azimuth, double altitude) GetHorizontalCoordinates(DateTime dateTime)
        {
            AASDate date = new AASDate(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour - _earthLocation.TimeZone, dateTime.Minute, dateTime.Second, true);
            double jd = AASDynamicalTime.UTC2TT(date.Julian);

            (double ra, double dec) = GetEquatorialCoordinates(jd);
            Coordinates.Sky.Coordinates coordinates = new Coordinates.Sky.Coordinates(ra, dec, Epoch.LocalTopocentric);

            return GetHorizontalCoordinates(coordinates, _earthLocation, dateTime);
        }

        public (double ra, double dec) GetEquatorialCoordinates(DateTime dateTime)
        {
            AASDate dateSunCalc = new AASDate(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour - _earthLocation.TimeZone, dateTime.Minute, dateTime.Second, true);
            var jd = AASDynamicalTime.UTC2TT(dateSunCalc.Julian);
            return GetEquatorialCoordinates(jd);
        }

        public (double ra, double dec) GetEquatorialCoordinates(double jd)
        {
            double lambda = AASSun.ApparentEclipticLongitude(jd, false);
            double beta = AASSun.ApparentEclipticLatitude(jd, false);
            double epsilon = AASNutation.TrueObliquityOfEcliptic(jd);
            AAS2DCoordinate solarCoordinate = AASCoordinateTransformation.Ecliptic2Equatorial(lambda, beta, epsilon);

            return (solarCoordinate.X, solarCoordinate.Y);
        }
    }
}