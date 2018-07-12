using System.Diagnostics;
using Serilog;

namespace DotnetCoreCorrelationIdSample
{
    public class SomeDependency
    {
        public string GetHello(string param)
        {
            var correlationId = Activity.Current.ParentId;
            Log.Debug($"SomeDependency CorrelcationId: {correlationId}");
            var hello = new AnotherDependency().GetHello(param);
            return hello;
        }
    }
}