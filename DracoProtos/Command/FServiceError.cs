using DracoProtos.Gen;

namespace DracoProtos.Command
{
    public class FServiceError : FServiceErrorBase
    {
        public FServiceError()
        {
        }
        
        public FServiceError(string cause, params object[] args)
        {
            this.cause = cause;
            this.args = args;
        }
    }
}
