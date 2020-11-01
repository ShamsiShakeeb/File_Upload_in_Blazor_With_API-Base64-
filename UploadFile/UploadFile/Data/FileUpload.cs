using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace UploadFile.Data
{
    public class FileUpload : IFileUpload
    {
        public void getBase64(string Text)
        {
            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("Text", Text);
            HttpClient http = new HttpClient();
            http.PostJsonAsync("https://localhost:44365/api/FileUp", dct);
        }
    }
}
