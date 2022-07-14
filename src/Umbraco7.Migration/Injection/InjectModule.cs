using Compent.Shared.DependencyInjection.Contract;
using Umbraco.Migration.Contract;

namespace Umbraco.Migration.Injection
{
    public class InjectModule : IInjectModule
    {
        public IDependencyCollection Register(IDependencyCollection services)
        {
            services.TryAddScoped<IExportService, ExportService>();
            services.TryAddScoped<IMigrationBuilder, MigrationBuilder>();

            return services;
        }
    }
}
