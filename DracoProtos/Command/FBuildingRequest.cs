namespace DracoProtos.Command
{
    public class FBuildingRequest : FBuildingRequestBase
	{
		public FBuildingRequest(string id, GeoCoords coords, string dungeonId)
		{
			this.id = id;
			this.coords = coords;
			this.dungeonId = dungeonId;
		}
	}
}
