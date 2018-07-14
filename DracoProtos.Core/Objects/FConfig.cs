using DracoProtos.Core.Base;
using DracoProtos.Core.Enums;
using DracoProtos.Core.Serializer;
using System;

namespace DracoProtos.Core.Objects
{
    public class FConfig : FConfigBase
    {
        public override void Handle()
        {
        }

        public FRecipeConfig GetRecipeConfig(RecipeType recipeName, int level)
        {
            return (FRecipeConfig)this.recipes[recipeName][level - 1];
        }

        public sbyte[] GetMd5Hash()
        {
            return FConfig.GetMd5HashAsSbyte(this);
        }

        public static sbyte[] GetMd5HashAsSbyte(object data)
        {
            byte[] md5Hash = FConfig.GetMd5Hash(data);
            return Array.ConvertAll<byte, sbyte>(md5Hash, (byte input) => (sbyte)input);
        }

        public static byte[] GetMd5Hash(object data)
        {
            byte[] buffer = SerializerContext.Context.Serialize(data);
            System.Security.Cryptography.MD5 md = System.Security.Cryptography.MD5.Create();
            return md.ComputeHash(buffer);
        }

        private const string MAP_VERSION_PREF = "MAP_VERSION_PREF";
    }
}
