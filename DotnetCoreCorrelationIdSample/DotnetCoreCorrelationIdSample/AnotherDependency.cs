using System.Diagnostics;
using Serilog;

namespace DotnetCoreCorrelationIdSample
{
    public class AnotherDependency
    {
        public string GetHello(string param)
        {
            var correlationId = Activity.Current.ParentId;
            Log.Debug($"AnotherDependency CorrelcationId: {correlationId}");
            return $"Hello {param}";
        }
    }
}