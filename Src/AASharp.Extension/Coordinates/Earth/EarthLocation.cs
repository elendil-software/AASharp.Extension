using System;

namespace AASharp.Extension.Coordinates.Earth
{
	/// <summary>
	/// Represents the coordinates of a location on  Earth
	/// </summary>
	public sealed class EarthLocation
	{
	    /// <summary>
	    /// Initializes a new instance of the <see cref="EarthLocation"/> class.
	    /// </summary>
	    /// <param name="latitude">The latitude, north latitudes are positive</param>
	    /// <param name="longitude">The longitude, east longitude are positive</param>
	    /// <param name="altitude">The altitude in meters</param>
	    /// <param name="timeZone">Timezone, including DST</param>
	    public EarthLocation(double latitude, double longitude, double altitude, double timeZone)
		{
			Latitude = new Latitude(latitude);
			Longitude = new Longitude(longitude);
		    Altitude = altitude;
		    TimeZone = timeZone;
		}

        public EarthLocation(string latitude, string longitude, double altitude, double timeZone)
        {
            Latitude = new Latitude(latitude);
            Longitude = new Longitude(longitude);
            Altitude = altitude;
            TimeZone = timeZone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EarthLocation"/> class.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="altitude">The altitude in meters</param>
        /// <param name="timeZone">Timezone, including DST</param>
        /// <exception cref="System.ArgumentNullException">if <paramref name="latitude"/> or <paramref name="longitude"/> is null</exception>
        public EarthLocation(Latitude latitude, Longitude longitude, double altitude, double timeZone)
		{
            Latitude = latitude ?? throw new ArgumentNullException(nameof(latitude));
			Longitude = longitude ?? throw new ArgumentNullException(nameof(longitude));
            Altitude = altitude;
            TimeZone = timeZone;
        }

		public Latitude Latitude { get; }
		public Longitude Longitude { get; }
        public double Altitude { get; }
	    public double TimeZone { get; }
	}
}