using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoFile.Controller{
    [ApiController]
    [Route("[controller]")]
    public class FileController: ControllerBase{
        private readonly ILogger<FileController> _logger;
        private readonly IHostingEnvironment _environment;

        public FileController(ILogger<FileController> logger, IHostingEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        [HttpPost]
        public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
        {
            var size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                if (formFile.Length <= 0) continue;

                await using var stream = System.IO.File.Create(Path.Combine(GetLocalPath(), formFile.FileName));
                await formFile.CopyToAsync(stream);
            }
            
            return Ok(new { count = files.Count, size });
        }
        
        [HttpPost("binary")]
        public async Task<IActionResult> PostBinaryAsync()
        {
            using var sr = new StreamReader(Request.Body);
            var body = await sr.ReadToEndAsync();
            return Ok(new { count = body.Length });
        }

        private string GetLocalPath()
        {
            var rootPath = _environment.ContentRootPath;

            var path = Path.Combine(rootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }
    }
}