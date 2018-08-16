using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class MagicService
	{
		public Async<FUpdate> CastSpell(FBuildingRequest request)
		{
			return new Async<FUpdate>("MagicService", "castSpell", new object[]
			{
				request
			});
		}

		public Async<FAltarDetails> ChangeAltarSpell(FBuildingRequest request, RecipeType recipeName)
		{
			return new Async<FAltarDetails>("MagicService", "changeAltarSpell", new object[]
			{
				request,
				recipeName
			});
		}

		public Async<FBagUpdate> ConvertRunes(ItemType type)
		{
			return new Async<FBagUpdate>("MagicService", "convertRunes", new object[]
			{
				type
			});
		}

		public Async<FUpdate> GetAltarDetailsV2(FBuildingRequest request, string passwordHash)
		{
			return new Async<FUpdate>("MagicService", "getAltarDetailsV2", new object[]
			{
				request,
				passwordHash
			});
		}

		public Async<FUpdate> PutAltar(GeoCoords avatarCoords, RecipeType recipeName, bool shared, string passwordHash)
		{
			return new Async<FUpdate>("MagicService", "putAltar", new object[]
			{
				avatarCoords,
				recipeName,
				shared,
				passwordHash
			});
		}

		public Async<FUpdate> PutRune(FBuildingRequest request, string passwordHash, int slot)
		{
			return new Async<FUpdate>("MagicService", "putRune", new object[]
			{
				request,
				passwordHash,
				slot
			});
		}

		public Async<FUpdate> RemoveAltar(GeoCoords avatarCoords)
		{
			return new Async<FUpdate>("MagicService", "removeAltar", new object[]
			{
				avatarCoords
			});
		}

		public Async<FUpdate> TakeRune(FBuildingRequest request, string passwordHash, int slot)
		{
			return new Async<FUpdate>("MagicService", "takeRune", new object[]
			{
				request,
				passwordHash,
				slot
			});
		}
	}
}
