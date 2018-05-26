using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;
using System.Collections.Generic;

namespace DracoProtos.Core.Base
{
    public abstract class FWizardBattleRatingBase : IFObject
    {
        public List<FWizardBattleRatingListRecord> topRecords;

        public void ReadExternal(FInputStream stream)
        {
            this.topRecords = stream.ReadStaticList<FWizardBattleRatingListRecord>(true);
        }

        public void WriteExternal(FOutputStream stream)
        {
            stream.WriteStaticCollection(this.topRecords, true);
        }
    }
}
