using Umbraco.Core.Composing;
using Umbraco.Web;

namespace Umbraco.Migration
{
    public class MigrationSectionComposer : IComposer
    {
        public void Compose(Composition composition)
        {
            composition.Sections().Append<MigrationSection>();
        }
    }
}
