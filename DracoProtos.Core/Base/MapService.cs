using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class MapService
	{
		public Async<FBuilding> CancelBuildingPersonalization(FBuildingRequest building)
		{
			return new Async<FBuilding>("MapService", "cancelBuildingPersonalization", new object[]
			{
				building
			});
		}

		public Async<FUpdate> GetUpdate(FUpdateRequest request)
		{
			return new Async<FUpdate>("MapService", "getUpdate", new object[]
			{
				request
			});
		}

		public Async<FBuilding> InsertLure(FBuildingRequest building)
		{
			return new Async<FBuilding>("MapService", "insertLure", new object[]
			{
				building
			});
		}

		public Async<FUpdate> LeaveDungeon(FClientRequest request)
		{
			return new Async<FUpdate>("MapService", "leaveDungeon", new object[]
			{
				request
			});
		}

		public Async<FOpenChestResult> OpenChestResult(FChest dto)
		{
			return new Async<FOpenChestResult>("MapService", "openChestResult", new object[]
			{
				dto
			});
		}

		public Async<FBuilding> PersonalizeBuilding(FBuildingRequest building, PersonalizedStop type)
		{
			return new Async<FBuilding>("MapService", "personalizeBuilding", new object[]
			{
				building,
				type
			});
		}

		public Async<object> StartOpeningChest(FChest dto)
		{
			return new Async<object>("MapService", "startOpeningChest", new object[]
			{
				dto
			});
		}

		public Async<FUpdate> TryUseBuilding(FClientRequest request, FBuildingRequest building)
		{
			return new Async<FUpdate>("MapService", "tryUseBuilding", new object[]
			{
				request,
				building
			});
		}
	}
}
