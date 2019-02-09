using System;

namespace AASharp.Extension.Coordinates.Earth
{
	/// <summary>
	/// Represents a longitude coordinate
	/// </summary>
	public abstract class EarthCoordinateBase
    {
        private double _coordinateValue;

		/// <summary>
		/// Get the decimal representation of the coordinate
		/// </summary>
		public double DecimalValue => _coordinateValue;

        /// <summary>
        /// Get the DD°MM'SS.SS" representation of the coordinate
        /// </summary>
        public string DmsValue => CoordinatesConverter.DecimalToDms(_coordinateValue);

        protected void InitFromString(string coordinate)
        {
            _coordinateValue = CoordinatesConverter.DmsToDecimal(coordinate);

            if (!IsInValidRange(_coordinateValue))
            {
                throw new ArgumentOutOfRangeException(nameof(coordinate));
            }
        }

        protected void InitFromDouble(double coordinate)
        {
            if (!IsInValidRange(coordinate))
            {
                throw new ArgumentOutOfRangeException(nameof(coordinate));
            }

            _coordinateValue = coordinate;
        }

        protected abstract bool IsInValidRange(double coordinateValue);
    }
}