using System;

namespace AASharp.Extension.Coordinates.Sky
{
    /// <summary>
    /// Represents a right ascension coordinate (https://en.wikipedia.org/wiki/Right_ascension)
    /// </summary>
    /// <seealso cref="Declination"/>
    public class RightAscension
	{
		private readonly double _rightAscension;

		/// <summary>
		/// Initializes a new instance of the <see cref="RightAscension"/> class.
		/// </summary>
		/// <param name="rightAscension">The right ascension.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">if <paramref name="rightAscension"/> is out of a valid range.</exception>
		public RightAscension(double rightAscension)
		{
			if (!IsInValidRange(rightAscension))
			{
				throw new ArgumentOutOfRangeException(nameof(rightAscension));
			}

			_rightAscension = rightAscension;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RightAscension"/> class.
		/// </summary>
		/// <param name="rightAscension">The right ascension in HHhMMhSS format</param>
		/// <exception cref="System.ArgumentNullException">if <paramref name="rightAscension"/> is null</exception>
		/// <exception cref="System.ArgumentOutOfRangeException">if, after being parsed, the coordinate is out of a valid range.</exception>
		public RightAscension(string rightAscension)
		{
			if (string.IsNullOrEmpty(rightAscension))
			{
				throw new ArgumentNullException(nameof(rightAscension));
			}

            _rightAscension = CoordinatesConverter.HmsToDecimal(rightAscension);

			if (!IsInValidRange(_rightAscension))
			{
				throw new ArgumentOutOfRangeException(nameof(rightAscension));
			}
		}

		/// <summary>
		/// Get the decimal representation of the right ascension
		/// </summary>
		public double DecimalValue => _rightAscension; 

	    /// <summary>
		/// Get the HHhMMmSS.SSs" representation of the right ascension
		/// </summary>
		public string HmsValue => CoordinatesConverter.DecimalToHms(_rightAscension);

		private static bool IsInValidRange(double ra)
		{
			return ra <= 24 && ra >= 0;
		}
	}
}