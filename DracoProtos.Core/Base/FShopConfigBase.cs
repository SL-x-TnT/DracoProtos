using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FShopConfigBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.artifactsPrice = stream.ReadStaticMap<ArtifactName, FPrice>(true, true);
			this.bagUpgrade = (ProductLot)stream.ReadStaticObject(typeof(ProductLot));
			this.coins = stream.ReadStaticMap<string, ProductLot>(true, true);
			this.creatureStorageUpgrade = (ProductLot)stream.ReadStaticObject(typeof(ProductLot));
			this.creatures = stream.ReadStaticMap<string, FItemCreatureGroup>(true, true);
			this.extraPacks = stream.ReadStaticMap<string, ExtraPack>(true, true);
			this.marketFees = stream.ReadStaticMap<string, float>(true, true);
			this.products = stream.ReadStaticList<ProductGroup>(true);
			this.saleSets = stream.ReadStaticList<SaleSetConfig>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticMap(this.artifactsPrice, true, true);
			stream.WriteStaticObject(this.bagUpgrade);
			stream.WriteStaticMap(this.coins, true, true);
			stream.WriteStaticObject(this.creatureStorageUpgrade);
			stream.WriteStaticMap(this.creatures, true, true);
			stream.WriteStaticMap(this.extraPacks, true, true);
			stream.WriteStaticMap(this.marketFees, true, true);
			stream.WriteStaticCollection(this.products, true);
			stream.WriteStaticCollection(this.saleSets, true);
		}

		public List<ProductGroup> products;

		public Dictionary<ArtifactName, FPrice> artifactsPrice;

		public ProductLot bagUpgrade;

		public ProductLot creatureStorageUpgrade;

		public Dictionary<string, FItemCreatureGroup> creatures;

		public Dictionary<string, ProductLot> coins;

		public Dictionary<string, float> marketFees;

		public List<SaleSetConfig> saleSets;

		public Dictionary<string, ExtraPack> extraPacks;
	}
}
