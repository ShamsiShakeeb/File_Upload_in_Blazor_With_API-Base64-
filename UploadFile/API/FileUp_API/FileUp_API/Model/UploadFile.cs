using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUp_API.Model
{
    public class UploadFile
    {
        public void UP(String Text)
        {
            String[] split = Text.Split(',');
            byte[] imageBytes = Convert.FromBase64String(split[1]);
            File.WriteAllBytes(@"file.jpg", imageBytes);
        }
    }
}
