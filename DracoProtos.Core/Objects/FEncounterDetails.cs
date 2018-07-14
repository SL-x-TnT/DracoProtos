using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FEncounterDetails : FEncounterDetailsBase
	{

		public static void UpdateLastEncounterTime()
		{
			//FEncounterDetails._lastEncounterTime = Time.realtimeSinceStartup;
		}

        public override void Handle()
        {
            
        }

        private static float _lastEncounterTime;

		private static int _encounterNeededActiveUserTime = -1;
	}
}
