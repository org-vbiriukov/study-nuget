using Umbraco.Core.Models.Sections;

namespace Umbraco.Migration
{
    internal class MigrationSection : ISection
    {
        public string Alias => "umbracoMigrationSection";

        public string Name => "Umbraco migration";
    }
}
