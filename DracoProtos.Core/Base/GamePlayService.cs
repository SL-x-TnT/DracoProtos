using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class GamePlayService
	{
		public Async<FCatchingCreature> FeedCreature(string creatureId, ItemType type, Tile parentTile)
		{
			return new Async<FCatchingCreature>("GamePlayService", "feedCreature", new object[]
			{
				creatureId,
				type,
				parentTile
			});
		}

		public Async<FCatchingCreature> StartCatchingCreature(FCreatureRequest request)
		{
			return new Async<FCatchingCreature>("GamePlayService", "startCatchingCreature", new object[]
			{
				request
			});
		}

		public Async<object> StopCatchingCreature(string creatureId)
		{
			return new Async<object>("GamePlayService", "stopCatchingCreature", new object[]
			{
				creatureId
			});
		}

		public Async<FCatchCreatureResult> TryCatchCreature(string creatureId, ItemType type, float quality, bool spin)
		{
			return new Async<FCatchCreatureResult>("GamePlayService", "tryCatchCreature", new object[]
			{
				creatureId,
				type,
				quality,
				spin
			});
		}
	}
}
