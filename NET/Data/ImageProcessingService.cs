using System.IO;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace NET.Data
{
    public class ImageProcessingService
    {
        private readonly string outputPath = "wwwroot/processed-images/";

        public ImageProcessingService()
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
        }

        public async Task<string[]> ProcessImageAsync(Stream fileStream, string fileName)
        {
            var baseFileName = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName);

            var grayscaleFilePath = Path.Combine(outputPath, $"{baseFileName}_grayscale{extension}");
            var blurFilePath = Path.Combine(outputPath, $"{baseFileName}_blur{extension}");
            var binaryFilePath = Path.Combine(outputPath, $"{baseFileName}_binary{extension}");

            using var image = await Image.LoadAsync<Rgba32>(fileStream);

            // Convert to grayscale and save
            var grayscaleImage = image.Clone(ctx => ctx.Grayscale());
            await grayscaleImage.SaveAsync(grayscaleFilePath);

            // Apply Gaussian blur and save
            var blurImage = image.Clone(ctx => ctx.GaussianBlur());
            await blurImage.SaveAsync(blurFilePath);

            // Binarize and save
            var binaryImage = image.Clone(ctx => ctx.BinaryThreshold(0.5f));
            await binaryImage.SaveAsync(binaryFilePath);

            return new[] { grayscaleFilePath, blurFilePath, binaryFilePath };
        }
    }
}
