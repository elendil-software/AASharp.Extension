using System;
using AASharp.Extension.Coordinates.Earth;
using AASharp.Extension.Coordinates.HorizontalCoordinates;
using AASharp.Extension.Coordinates.Sky;

namespace AASharp.Extension.SolarSystem
{
    public class MoonCoordinates : HorizontalCoordinates
    {
        private readonly EarthLocation _earthLocation;

        public MoonCoordinates(EarthLocation earthLocation)
        {
            _earthLocation = earthLocation ?? throw new ArgumentNullException(nameof(earthLocation));
        }

        public (double ra, double dec) GetEquatorialCoordinates(DateTime dateTime)
        {
            AASDate date = new AASDate(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour - _earthLocation.TimeZone, dateTime.Minute, dateTime.Second, true);
            double jd = AASDynamicalTime.UTC2TT(date.Julian);
            return GetEquatorialCoordinates(jd);
        }

        public (double ra, double dec) GetEquatorialCoordinates(double jd)
        {
            double lambda = AASMoon.EclipticLongitude(jd);
            double beta = AASMoon.EclipticLatitude(jd);
            double epsilon = AASNutation.TrueObliquityOfEcliptic(jd);
            AAS2DCoordinate lunarCoordinates = AASCoordinateTransformation.Ecliptic2Equatorial(lambda, beta, epsilon);

            return (lunarCoordinates.X, lunarCoordinates.Y);
        }

        public (double azimuth, double altitude) GetHorizontalCoordinates(DateTime dateTime)
        {
            AASDate date = new AASDate(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour - _earthLocation.TimeZone, dateTime.Minute, dateTime.Second, true);
            double jd = AASDynamicalTime.UTC2TT(date.Julian);

            (double ra, double dec) = GetEquatorialCoordinates(jd);
            Coordinates.Sky.Coordinates coordinates = new Coordinates.Sky.Coordinates(ra, dec, Epoch.LocalTopocentric);

            return GetHorizontalCoordinates(coordinates, _earthLocation, dateTime);
        }

        protected override double GetRadiusVector(double jd)
        {
            return AASMoon.RadiusVector(jd);
        }
    }
}