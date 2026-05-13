using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace Filevy.Converters
{
    public static class ImageConverter
    {
        public static void Convert(string inputPath, string outputPath, IProgress<int>? progress = null)
        {
            progress?.Report(20);

            BitmapFrame frame;
            using (var stream = File.OpenRead(inputPath))
            {
                var decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                frame = decoder.Frames[0];
                frame.Freeze();
            }

            progress?.Report(60);

            var ext = Path.GetExtension(outputPath).ToLower();
            BitmapEncoder encoder = ext switch
            {
                ".jpg" or ".jpeg" => new JpegBitmapEncoder { QualityLevel = 90 },
                ".png" => new PngBitmapEncoder(),
                _ => throw new NotSupportedException($"Format '{ext}' is not supported.")
            };

            encoder.Frames.Add(BitmapFrame.Create(frame));
            progress?.Report(80);

            using var outStream = File.Create(outputPath);
            encoder.Save(outStream);

            progress?.Report(100);
        }
    }
}