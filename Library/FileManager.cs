using API.Library.Repository;

namespace API.Library
{
    public class FileManager : IFileManager
    {
        private const string _ROOT = "Uploads";

        public void Delete(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        public bool FileExists(string fileName, string _PATH)
        {
            return File.Exists(Path.Combine(Directory.GetCurrentDirectory(), _ROOT, _PATH, fileName));
        }

        public FileInfo GetFile(string fileName, string _PATH)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), _ROOT, _PATH, fileName);
            Directory.GetFiles(path);
        }

        public string Upload(IFormFile file, string _PATH)
        {
            string writePath = Path.Combine(Directory.GetCurrentDirectory(), _ROOT, _PATH);
            Directory.CreateDirectory(writePath);

            string extension = file.FileName.Split('.').Last();
            string newName = $"{Guid.NewGuid()}.{extension}";

            using FileStream stream = new(Path.Combine(writePath, newName), FileMode.Create);
            file.CopyTo(stream);
            return $"{_ROOT}/{_PATH}/{newName}";
        }
    }
}
