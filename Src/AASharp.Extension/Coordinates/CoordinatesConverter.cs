using System;
using System.Globalization;

namespace AASharp.Extension.Coordinates
{
    internal static class CoordinatesConverter
    {
        /// <summary>
		/// Convert an HHhMMmSS.SSs declination coordinate to its corresponding decimal value (hour or angle value)
		/// </summary>
		/// <param name="hmsCoordinate">HHhMMmSS.SSs formated RA value</param>
		/// <returns>the decimal value of the given  HHhMMmSS.SSs value</returns>
		/// <exception cref="ArgumentNullException"><paramref name="hmsCoordinate"/> is null or empty</exception>
		/// <exception cref="FormatException"><paramref name="hmsCoordinate"/> is not correctly formated</exception>
		public static double HmsToDecimal(string hmsCoordinate)
        {
            hmsCoordinate = hmsCoordinate.Trim();

            var match = CoordinateParser.ParseHmsValue(hmsCoordinate);

            var ra = double.Parse(match.Groups[1].ToString());
            ra += double.Parse(match.Groups[3].ToString()) / 60.0d;
            ra += double.Parse(match.Groups[5].ToString(), CultureInfo.InvariantCulture) / 3600.0d;

            return ra;
        }

        /// <summary>
        /// Convert a decimal RA value to its corresponding HHhMMmSS.SSs value 
        /// </summary>
        /// <param name="decimalCoordinate">The decimal value to convert. It can be an hour value or a degree value</param>
        /// <returns>The RA in HHhMMmSS.SSs format</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="decimalCoordinate"/> is not in valid range</exception>
        public static string DecimalToHms(double decimalCoordinate)
        {
            var h = Math.Floor(decimalCoordinate);
            var tmpM = (decimalCoordinate - h) * 60;
            var m = Math.Floor(tmpM);
            var s = Math.Round((tmpM - m) * 60, 2);

            return h + "h" + m + "m" + s.ToString(CultureInfo.InvariantCulture) + "s";
        }

        /// <summary>
		/// Convert an DD°MM'SS.SSs" declination coordinate to its corresponding decimal value
		/// </summary>
		/// <param name="dmsCoordinate">DD°MM'SS.SSs" formated declination value</param>
		/// <returns>the decimal value of the given DD°MM'SS.SSs" value</returns>
		/// <exception cref="ArgumentNullException"><paramref name="dmsCoordinate" /> is null or empty</exception>
		/// <exception cref="FormatException"><paramref name="dmsCoordinate" /> is not correctly formated</exception>
		public static double DmsToDecimal(string dmsCoordinate)
        {
            var match = CoordinateParser.ParseDmsValue(dmsCoordinate);

            var dec = double.Parse(match.Groups[2].ToString());
            dec += double.Parse(match.Groups[4].ToString()) / 60.0f;
            dec += double.Parse(match.Groups[6].ToString(), CultureInfo.InvariantCulture) / 3600.0f;

            if (match.Groups[1].ToString() == "-")
            {
                dec *= -1;
            }

            return dec;
        }

        /// <summary>
        /// Convert a decimal declination value to its corresponding DD°MM'SS.SSs" value
        /// </summary>
        /// <param name="decimalCoordinate">Decimal value of a declination coordinate</param>
        /// <returns>The declination in DD°MM'SS.SS" format</returns>
        public static string DecimalToDms(double decimalCoordinate)
        {
            var d = decimalCoordinate >= 0 ? Math.Floor(decimalCoordinate) : Math.Ceiling(decimalCoordinate);
            var tmp = (decimalCoordinate - d) * 60;
            var m = tmp >= 0 ? Math.Floor(tmp) : Math.Ceiling(tmp);
            var s = Math.Round((tmp - m) * 60, 2);

            return d + "°" + Math.Abs(m) + "'" + Math.Abs(s).ToString(CultureInfo.InvariantCulture) + "\"";
        }
    }
}