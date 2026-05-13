using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace Filevy.Models
{
    public enum ConversionStatus { Pending, Running, Done, Failed }

    public class ConversionJob : INotifyPropertyChanged
    {
        private int _progress;
        private ConversionStatus _status;
        private string _outputFilePath = string.Empty;

        public string InputFilePath { get; set; } = string.Empty;
        public string InputFileName => Path.GetFileName(InputFilePath);

        public string OutputFilePath
        {
            get => _outputFilePath;
            set { _outputFilePath = value; OnPropertyChanged(); OnPropertyChanged(nameof(OutputFileName)); }
        }
        public string OutputFileName => Path.GetFileName(OutputFilePath);

        public string ConversionType { get; set; } = string.Empty;

        public int Progress
        {
            get => _progress;
            set { _progress = value; OnPropertyChanged(); }
        }

        public ConversionStatus Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}