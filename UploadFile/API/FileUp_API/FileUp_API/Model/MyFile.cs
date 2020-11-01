using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUp_API.Model
{
    public class MyFile
    {
        public IFormFile Photo { set; get; }
    }
}
