using System;

namespace AASharp.Extension.Coordinates.Earth
{
	/// <summary>
	/// Represents a latitude coordinate
	/// </summary>
	public sealed class Latitude : EarthCoordinateBase
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="Latitude"/> class.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <exception cref="System.ArgumentOutOfRangeException">if <paramref name="latitude" /> is not in a valid range (between -90 and 90)</exception>
		public Latitude(double latitude)
		{
            InitFromDouble(latitude);
		}

        /// <summary>
        /// </summary>
        /// <param name="latitude">DD°MM'SS.SSs" formated latitude value</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="latitude" /> is not between -90 and 90</exception>
        public Latitude(string latitude)
        {
            if (string.IsNullOrEmpty(latitude))
            {
                throw new ArgumentNullException(nameof(latitude));
            }

            InitFromString(latitude);
        }

        protected override bool IsInValidRange(double coordinateValue)
		{
            return (coordinateValue <= 90 && coordinateValue >= -90);
		}
	}
}