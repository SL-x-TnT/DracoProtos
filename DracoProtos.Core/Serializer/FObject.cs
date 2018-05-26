namespace DracoProtos.Core.Serializer
{
    public interface IFObject
	{
		void ReadExternal(FInputStream stream);

		void WriteExternal(FOutputStream stream);
	}
}
