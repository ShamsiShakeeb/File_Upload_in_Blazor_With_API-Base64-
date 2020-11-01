using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileUp_API.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace FileUp_API.Controllers
{
  
    public class Upload : Controller
    {
      

        private readonly IWebHostEnvironment _hostingEnvironment;
        public Upload(IWebHostEnvironment hostingEnvironment)
        {
           
            _hostingEnvironment = hostingEnvironment;
        }
        [Route("api/FileUp")]
        [HttpPost]
        public ActionResult Files([FromBody] ModelFromBlazor apiModel)
        {
            MyFile myFile = new MyFile();

            UploadFile uu = new UploadFile();
            uu.UP(apiModel.Text);

            return Json(true);
        }
    }
}
