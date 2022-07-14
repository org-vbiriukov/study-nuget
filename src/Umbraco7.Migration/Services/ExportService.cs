using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Services;
using Umbraco.Migration.Contract;

namespace Umbraco.Migration
{
    public class ExportService : IExportService
    {
        private readonly IMigrationBuilder migrationBuilder;
        private readonly IDataTypeService dataTypeService;

        public ExportService(
            IMigrationBuilder migrationBuilder, 
            IDataTypeService dataTypeService)
        {
            this.dataTypeService = dataTypeService;
            this.migrationBuilder = migrationBuilder;
        }

        public object[] GetAllDataTypes()
        {
            throw new NotImplementedException();
        }
        /*
public ExportDataModel ExportAll()
{
   return new ExportDataModel
   {
       //TODO
       Data = Array.Empty<byte>(),
       FileName = $"{DateTime.UtcNow:yyyy-MM-ddThh-mmZ}.json"
   };
}

public virtual IEnumerable<IDataTypeModel> GetAllDataTypes()
{
   var dataTypes = dataTypeService.GetAll();

   return dataTypes.Select(migrationBuilder.Map);
}
*/
    }
}
