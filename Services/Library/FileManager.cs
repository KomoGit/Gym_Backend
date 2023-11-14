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

        public string Upload(IFormFile file, string _PATH)
        {
            if (!IsImageFile(file))
            {
                throw new Exception("Uploaded File is not .JPG or .PNG");
            }
            string writePath = Path.Combine(Directory.GetCurrentDirectory(), _ROOT, _PATH);
            Directory.CreateDirectory(writePath);

            string extension = file.FileName.Split('.').Last();
            string newName = $"{Guid.NewGuid()}.{extension}";

            using FileStream stream = new(Path.Combine(writePath, newName), FileMode.Create);
            file.CopyTo(stream);
            return $"{_ROOT}/{_PATH}/{newName}";
        }
        #region Image Validation
        private bool IsImageFile(IFormFile file)
        {
            // Limit the read to the first 512 bytes
            byte[] buffer = new byte[512];

            using (Stream? stream = file.OpenReadStream())
            {
                stream.Read(buffer, 0, buffer.Length);
            }

            // Check the magic number
            return IsJpeg(buffer) || IsPng(buffer);
        }

        private bool IsJpeg(byte[] buffer)
        {
            // JPEG magic number: FF D8 FF
            return buffer.Length >= 3 &&
                   buffer[0] == 0xFF &&
                   buffer[1] == 0xD8 &&
                   buffer[2] == 0xFF;
        }

        private bool IsPng(byte[] buffer)
        {
            // PNG magic number: 89 50 4E 47 0D 0A 1A 0A
            return buffer.Length >= 8 &&
                   buffer[0] == 0x89 &&
                   buffer[1] == 0x50 &&
                   buffer[2] == 0x4E &&
                   buffer[3] == 0x47 &&
                   buffer[4] == 0x0D &&
                   buffer[5] == 0x0A &&
                   buffer[6] == 0x1A &&
                   buffer[7] == 0x0A;
        }
        #endregion
    }
}
