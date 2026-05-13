using SkiaSharp;
using System;
using System.IO;

namespace Filevy.Converters
{
    public static class ImageConverter
    {
        public static void Convert(string inputPath, string outputPath, IProgress<int>? progress = null)
        {
            progress?.Report(20);

            using var input = File.OpenRead(inputPath);
            using var bitmap = SKBitmap.Decode(input);

            progress?.Report(60);

            var ext = Path.GetExtension(outputPath).ToLower();
            SKEncodedImageFormat format = ext switch
            {
                ".jpg" or ".jpeg" => SKEncodedImageFormat.Jpeg,
                ".png" => SKEncodedImageFormat.Png,
                ".webp" => SKEncodedImageFormat.Webp,
                _ => throw new NotSupportedException($"Format '{ext}' is not supported.")
            };

            progress?.Report(80);

            using var output = File.Create(outputPath);
            bitmap.Encode(output, format, 90);

            progress?.Report(100);
        }
    }
}