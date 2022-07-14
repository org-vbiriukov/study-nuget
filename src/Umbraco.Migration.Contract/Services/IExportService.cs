using System.Collections.Generic;

namespace Umbraco.Migration.Contract
{
    public interface IExportService
    {
        ExportDataModel ExportAll();
        IEnumerable<IDataTypeModel> GetAllDataTypes();
    }
}
