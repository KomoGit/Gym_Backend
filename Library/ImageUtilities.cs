using API.Library.Repository;
using ImageMagick;

namespace API.Library
{
    public class ImageUtilities : IImageUtility
    {
        public void CompressImage(FileInfo rawImage)
        {
            ImageOptimizer optimizer = new();
            optimizer.LosslessCompress(rawImage);
        }
    }
}
