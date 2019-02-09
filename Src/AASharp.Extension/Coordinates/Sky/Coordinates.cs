using System;

namespace AASharp.Extension.Coordinates.Sky
{
	/// <summary>
	/// Represents the coordinates of an astronomical object (star, galaxy, ...) or of an arbitrary position in the sky
	/// </summary>
	public class Coordinates
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="rightAscension">The right ascension coordinate value</param>
        /// <param name="declination">The declination coordinate value</param>
        /// <param name="epoch">The epoch of the coordinates</param>
        public Coordinates(double rightAscension, double declination, Epoch epoch)
		{
			RightAscension = new RightAscension(rightAscension);
			Declination = new Declination(declination);
			Epoch = epoch;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="rightAscension">The right ascension coordinate value</param>
        /// <param name="declination">The declination coordinate value</param>
        /// <param name="epoch">The epoch of the coordinates</param>
        public Coordinates(string rightAscension, string declination, Epoch epoch)
        {
            RightAscension = new RightAscension(rightAscension);
            Declination = new Declination(declination);
            Epoch = epoch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="rightAscension">The right ascension.</param>
        /// <param name="declination">The declination.</param>
        /// <param name="epoch">The epoch of the coordinates</param>
        /// <exception cref="System.ArgumentNullException">if <paramref name="rightAscension"/> or <paramref name="declination"/> is null</exception>
        public Coordinates(RightAscension rightAscension, Declination declination, Epoch epoch)
		{
		    RightAscension = rightAscension ?? throw new ArgumentNullException(nameof(rightAscension));
			Declination = declination ?? throw new ArgumentNullException(nameof(declination));
			Epoch = epoch;
		}

        public RightAscension RightAscension { get; }
		public Declination Declination { get; }
        public Epoch Epoch { get; }
    }
}