using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCFileUpload.Models
{
    public class ApiFile
    {
        public ApiFile()
        {

        }
        public ApiFile(string localFileName, string fileName, string origin)
        {
            this.fileName = fileName.Trim('"');
            var fileFolderPath = System.Web.Hosting.HostingEnvironment.MapPath(Controllers.FileController.FileFolder);
            var fileFullPath = Path.Combine(fileFolderPath, this.fileName);

            File.Copy(localFileName, fileFullPath, true);
            File.Delete(localFileName);

            this.fileUrl = origin + "/" + Controllers.FileController.FileFolder.TrimStart('~') + "/" + this.fileName;
        }
        public string fileName { get; set; }
        public string fileUrl { get; set; }
    }
}