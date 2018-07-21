using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FEncounterDetails : FEncounterDetailsBase
	{
		public override void Handle()
		{
		}

		private static float _lastEncounterTime;

		private static int _encounterNeededActiveUserTime = -1;
	}
}
