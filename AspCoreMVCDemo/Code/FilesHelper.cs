namespace AspCoreMVCDemo.Code
{
    public class FilesHelper
    {

        private readonly IWebHostEnvironment webHost;
        public FilesHelper(IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
        }
        public string UploadFile(IFormFile file, string folder)// collcatin.ima , "images"
        {
            if (file != null)
            {
                var fileDir = Path.Combine(webHost.WebRootPath, folder);//~/images
                var fileName = Guid.NewGuid() + "-" + file.FileName;//6567-book.png
                var filePath = Path.Combine(fileDir, fileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                    return fileName;
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
