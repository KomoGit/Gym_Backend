using API.Library.Repository;
using ImageMagick;

namespace API.Library
{
    public class ImageCompressor : IImageUtility
    {
        private readonly ImageOptimizer _optimizer;
        public ImageCompressor(ImageOptimizer optimizer)
        {
            _optimizer = optimizer;
        }

        public async Task CompressImageAsync(FileInfo rawImage)
        {
            await Task.Run(() => _optimizer.LosslessCompress(rawImage));
        }
    }
}
