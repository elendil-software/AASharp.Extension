using System;

namespace AASharp.Extension.Coordinates.Earth
{
	/// <summary>
	/// Represents a longitude coordinate
	/// </summary>
	public sealed class Longitude : EarthCoordinateBase
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="Longitude"/> class.
		/// </summary>
		/// <param name="longitude">The longitude.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">if <paramref name="longitude" /> is not between -90 and 90</exception>
		public Longitude(double longitude)
		{
			InitFromDouble(longitude);
        }

		/// <summary>
		/// </summary>
		/// <param name="longitude">DD°MM'SS.SSs" formated longitude value</param>
		/// <exception cref="ArgumentOutOfRangeException"><paramref name="longitude" /> is not between -90 and 90</exception>
		public Longitude(string longitude)
		{
			if (string.IsNullOrEmpty(longitude))
			{
				throw new ArgumentNullException(nameof(longitude));
			}

            InitFromString(longitude);
        }

		protected override bool IsInValidRange(double coordinateValue)
		{
            return (coordinateValue <= 180 && coordinateValue >= -180);
		}
	}
}