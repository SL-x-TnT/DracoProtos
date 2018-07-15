using System;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
	public class ItemService
	{
		public Async<bool> DiscardItems(ItemType type, int count)
		{
			return new Async<bool>("ItemService", "discardItems", new object[]
			{
				type,
				count
			});
		}

		public Async<FBagUpdate> GetUserItems()
		{
			return new Async<FBagUpdate>("ItemService", "getUserItems", new object[0]);
		}

		public Async<FAvaUpdate> UseExperienceBooster()
		{
			return new Async<FAvaUpdate>("ItemService", "useExperienceBooster", new object[0]);
		}

		public Async<FAvaUpdate> UseIncense()
		{
			return new Async<FAvaUpdate>("ItemService", "useIncense", new object[0]);
		}

		public Async<FUpdate> UseShovel(FClientRequest request)
		{
			return new Async<FUpdate>("ItemService", "useShovel", new object[]
			{
				request
			});
		}

		public Async<FAvaUpdate> UseSuperVision(GeoCoords geoCoords)
		{
			return new Async<FAvaUpdate>("ItemService", "useSuperVision", new object[]
			{
				geoCoords
			});
		}
	}
}
