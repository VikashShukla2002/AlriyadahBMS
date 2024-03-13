using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.ApiModels
{
    //public class ImageResponse
    //{

    //}
    public class UploadResult
    {
        public string FileToken { get; set; }
        public ImportFiles Files { get; set; }
    }

    public class ImportFiles
    {
        public List<ImportFile> ImportFile { get; set; }
    }

    public class ImportFile
    {
        public string Name { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}
