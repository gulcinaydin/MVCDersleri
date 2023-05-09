using MVCFileUpload.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MVCFileUpload.Controllers
{
    public class FileController : ApiController
    {
        internal const string FileFolder = "~/Files";
        internal const string TempFolder = "~/Temp";
        private string e;

        public object Files { get; private set; }

        [HttpPost]
        public async Task<HttpResponseMessage> UploadFile()
        {
            MultipartFormDataStreamProvider streamProvider = new MultipartFormDataStreamProvider
                (HttpContext.Current.Server.MapPath(TempFolder));
            try
            {

                await Request.Content.ReadAsMultipartAsync(streamProvider);
                var origin = Request.Headers.Host;

                List<ApiFile> result = streamProvider.FileData.Select(i => new ApiFile(i.LocalFileName,
                    i.Headers.ContentDisposition.FileName, origin)).ToList();


                using (FileUploadEntities entity = new FileUploadEntities())
                {
                    Files file = new Files();
                    file.fileUrl = result[0].fileUrl;
                    file.fileName = result[0].fileName;
                    entity.Files.Add(file);
                    entity.SaveChanges();
                }

                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetAllFiles()
        {
            using (FileUploadEntities entity = new FileUploadEntities())
            {
                try
                {
                    var files = entity.Files.ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, files);
                }
                catch (Exception)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
                }
            }
        }

        public bool DeleteFile(string fileName, int fileId)
        {
            fileName = "/Files" + fileName;
            bool status;

            try
            {
                System.IO.File.Delete(HttpContext.Current.Server.MapPath("~/" + fileName));

                using (FileUploadEntities entity = new FileUploadEntities())
                {
                    var file = entity.Files.FirstOrDefault(i => fileId == i.fileId);
                    entity.Files.Remove(file);
                    entity.SaveChanges();
                }

                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
