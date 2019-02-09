using System;

namespace AASharp.Extension.Coordinates.Sky
{
    /// <summary>
    /// Represents a declination coordinate (https://en.wikipedia.org/wiki/Declination) 
    /// </summary>
    /// <seealso cref="RightAscension"/>
    public class Declination
	{
		private readonly double _declination;

		/// <summary>
		/// Initializes a new instance of the <see cref="Declination"/> for the given declination.
		/// </summary>
		/// <param name="declination">The declination value</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="declination" /> is not between -90 and 90</exception>
		public Declination(double declination)
		{
			if (!IsInValidRange(declination))
			{
				throw new ArgumentOutOfRangeException(nameof(declination));
			}

			_declination = declination;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="Declination"/> for the given declination.
        /// </summary>
        /// <param name="declination">DD°MM'SS.SSs" formated declination value</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="declination" /> is not between -90 and 90</exception>
        public Declination(string declination)
		{
			if (string.IsNullOrEmpty(declination))
			{
				throw new ArgumentNullException(nameof(declination));
			}

            _declination = CoordinatesConverter.DmsToDecimal(declination);

			if (!IsInValidRange(_declination))
			{
				throw new ArgumentOutOfRangeException(nameof(declination));
			}
		}

		/// <summary>
		/// Get the decimal representation of the declination
		/// </summary>
		public double DecimalValue => _declination;

	    /// <summary>
		/// Get the DD°MM'SS.SS" representation of the declination
		/// </summary>
		public string DmsValue => CoordinatesConverter.DecimalToDms(_declination);

		private static bool IsInValidRange(double dec)
		{
			return dec <= 90 && dec >= -90;
		}
	}
}