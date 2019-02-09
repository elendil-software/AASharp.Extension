using System;
using AASharp.Extension.Coordinates.Earth;

namespace AASharp.Extension.SolarSystem
{
    public static class MoonIlluminatedFraction
    {
        public static double GetIlluminatedFraction(EarthLocation earthLocation, DateTime dateTime)
        {
            SunCoordinates sun = new SunCoordinates(earthLocation);
            MoonCoordinates moonCoordinates = new MoonCoordinates(earthLocation);

            (double moonAlpha, double moonDelta) = moonCoordinates.GetEquatorialCoordinates(dateTime);
            (double sunAlpha, double sunDelta) = sun.GetEquatorialCoordinates(dateTime);

            double geocentricElongation = AASMoonIlluminatedFraction.GeocentricElongation(moonAlpha, moonDelta, sunAlpha, sunDelta);

            //TODO : compute EarthObjectDistance and EarthSunDistance
            double phaseAngle = AASMoonIlluminatedFraction.PhaseAngle(geocentricElongation, 368410.0, 149971520.0);
            double illuminatedFraction = AASMoonIlluminatedFraction.IlluminatedFraction(phaseAngle);

            return illuminatedFraction;
        }
    }
}