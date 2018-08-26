namespace DracoProtos.Core.Extensions
{
    public class Async<T>
    {
        private string service;
        private string methodName;
        private object[] args;

        public Async(string service, string methodName, object[] args)
        {
            this.service = service;
            this.methodName = methodName;
            this.args = args;
        }
    }
}