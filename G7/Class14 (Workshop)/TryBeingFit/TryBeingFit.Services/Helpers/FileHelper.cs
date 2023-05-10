using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit.Services.Helpers
{
    public static class FileHelper
    {
        public static bool FileExists(string _filePath)
        {
            return File.Exists(_filePath);
        }
    }
}
