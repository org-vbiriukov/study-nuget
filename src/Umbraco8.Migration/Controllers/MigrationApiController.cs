using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using Umbraco.Migration.Contract;
using Umbraco.Web.WebApi;

namespace Umbraco.Migration
{
    public class MigrationApiController : UmbracoAuthorizedApiController
    {
        private readonly IExportService exportService;

        private const string Attachment = "attachment";

        public MigrationApiController(IExportService exportService)
        {
            this.exportService = exportService;
        }

        [HttpGet]
        public HttpResponseMessage Export()
        {
            return null;
            /*
            var exportModel = exportService.ExportAll();
            var fileName = "export " + exportModel.FileName;

            var result = Request.CreateResponse(HttpStatusCode.OK);
            result.Content = new StreamContent(new MemoryStream(exportModel.Data));
            result.Content.Headers.ContentType = new MediaTypeHeaderValue(MimeMapping.GetMimeMapping(fileName));
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue(Attachment)
            {
                FileName = fileName
            };

            return result;*/
        }
    }
}
