using System;
using System.Text.RegularExpressions;

namespace AASharp.Extension.Coordinates
{
    internal static class CoordinateParser
    {
        public static Match ParseDmsValue(string dmsCoordinate)
        {
            dmsCoordinate = dmsCoordinate.Trim();

            var exp = new Regex("^([-+]?)([0-9]{1,3})([\\D]?)([0-9]{1,2})([\\D]?)([0-9]{1,2}[0-9.]*)([\\D]?)$");
            var match = exp.Match(dmsCoordinate);

            if (match.Success)
            {
                return match;
            }
            else
            {
                throw new FormatException("Unable to parse " + dmsCoordinate);
            }
        }

        public static Match ParseHmsValue(string hmsCoordinate)
        {
            var exp = new Regex("^([0-9]{1,2})(.)([0-9]{1,2})(.)([0-9]{1,2}[0-9.]*)(.?)$");
            var match = exp.Match(hmsCoordinate);

            if (match.Success)
            {
                return match;
            }
            else
            {
                throw new FormatException("Unable to parse " + hmsCoordinate);
            }
        }
    }
}