using System;

namespace DracoProtos.Core.Extensions
{
    [Serializable]
	public class Coordinates
	{
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double altitude { get; set; }
        public double horizontalAccuracy { get; set; }
        public bool _withOutTime { get; set; }

        public Coordinates(double latitude, double longitude, double altitude) : this(latitude, longitude, altitude, false)
		{
		}
        
		public Coordinates(double latitude, double longitude, double altitude, bool withOutTime)
		{
			this.latitude = latitude;
			this.longitude = longitude;
			this.altitude = altitude;
            this._withOutTime = withOutTime;
		}
	}
}
