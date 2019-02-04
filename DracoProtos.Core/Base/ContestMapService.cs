using System.Collections.Generic;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class ContestMapService
	{
		public Async<FUpdate> AcceptStartContest(bool accept)
		{
			return new Async<FUpdate>("ContestMapService", "acceptStartContest", new object[]
			{
				accept
			});
		}

		public Async<FUpdate> CreateContest(GeoCoords userCoords)
		{
			return new Async<FUpdate>("ContestMapService", "createContest", new object[]
			{
				userCoords
			});
		}

		public Async<FUpdate> CreateContestWithPassword(GeoCoords userCoords, string passwordHash)
		{
			return new Async<FUpdate>("ContestMapService", "createContestWithPassword", new object[]
			{
				userCoords,
				passwordHash
			});
		}

		public Async<object> DevTimeoutInContest()
		{
			return new Async<object>("ContestMapService", "devTimeoutInContest", new object[0]);
		}

		public Async<FUpdate> FinishContestBattle(FFightRequest fightRequest, string opponentNickname)
		{
			return new Async<FUpdate>("ContestMapService", "finishContestBattle", new object[]
			{
				fightRequest,
				opponentNickname
			});
		}

		public Async<FContestUpdate> GetContestUpdate(BuildingType requestBuildingType, ClientScreen clientScreen)
		{
			return new Async<FContestUpdate>("ContestMapService", "getContestUpdate", new object[]
			{
				requestBuildingType,
				clientScreen
			});
		}

		public Async<FUserCreaturesList> GetPossibleAttackers()
		{
			return new Async<FUserCreaturesList>("ContestMapService", "getPossibleAttackers", new object[0]);
		}

		public Async<FUpdate> JoinContest(GeoCoords coords, string id)
		{
			return new Async<FUpdate>("ContestMapService", "joinContest", new object[]
			{
				coords,
				id
			});
		}

		public Async<FUpdate> JoinContestWithPassword(GeoCoords coords, string id, string passwordHash)
		{
			return new Async<FUpdate>("ContestMapService", "joinContestWithPassword", new object[]
			{
				coords,
				id,
				passwordHash
			});
		}

		public Async<FUpdate> LeaveContest()
		{
			return new Async<FUpdate>("ContestMapService", "leaveContest", new object[0]);
		}

		public Async<FUpdate> StartContest()
		{
			return new Async<FUpdate>("ContestMapService", "startContest", new object[0]);
		}

		public Async<FFightUpdate> StartContestBattle(List<string> attackerIds, string opponentNickname)
		{
			return new Async<FFightUpdate>("ContestMapService", "startContestBattle", new object[]
			{
				attackerIds,
				opponentNickname
			});
		}

		public Async<FUpdate> SurrenderContest()
		{
			return new Async<FUpdate>("ContestMapService", "surrenderContest", new object[0]);
		}
	}
}
