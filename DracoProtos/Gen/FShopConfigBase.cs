using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FShopConfigBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.artifacts = stream.ReadStaticMap<ArtifactName, int>(true, true);
			this.bagUpgrade = (ProductLot)stream.ReadStaticObject(typeof(ProductLot));
			this.coins = stream.ReadStaticMap<string, ProductLot>(true, true);
			this.creatureStorageUpgrade = (ProductLot)stream.ReadStaticObject(typeof(ProductLot));
			this.products = stream.ReadStaticList<ProductGroup>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticMap(this.artifacts, true, true);
			stream.WriteStaticObject(this.bagUpgrade);
			stream.WriteStaticMap(this.coins, true, true);
			stream.WriteStaticObject(this.creatureStorageUpgrade);
			stream.WriteStaticCollection(this.products, true);
		}

		public List<ProductGroup> products;

		public Dictionary<ArtifactName, int> artifacts;

		public ProductLot bagUpgrade;

		public ProductLot creatureStorageUpgrade;

		public Dictionary<string, ProductLot> coins;
	}
}
