using Carter;
using System.Reflection;

namespace BuildingBlocks.Endpoints
{
    public class DependencyContextAssemblyCatalogCustom(Type programType) : DependencyContextAssemblyCatalog
    {

        public override IReadOnlyCollection<Assembly> GetAssemblies()
        {
            return new List<Assembly> { programType.Assembly };
        }

        
    }
}
