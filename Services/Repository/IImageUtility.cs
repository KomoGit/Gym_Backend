namespace API.Library.Repository
{
    public interface IImageUtility
    {
        public void CompressImage(FileInfo rawImage) { }

        public void AddImageWatermark(FileInfo rawImage) { }
    }
}
