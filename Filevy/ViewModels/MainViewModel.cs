using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using Filevy.Commands;
using Filevy.Models;
using Microsoft.Win32;

namespace Filevy.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _selectedFilePath = string.Empty;
        private string _selectedFormat = string.Empty;
        private ConversionJob? _selectedJob;

        public enum ChooseConversion
        {
            ImageConversion = 1,
            XLSXConversion = 2
        }

        public string SelectedFilePath
        {
            get => _selectedFilePath;
            set { _selectedFilePath = value; OnPropertyChanged(); OnPropertyChanged(nameof(SelectedFileName)); }
        }

        public string SelectedFileName => Path.GetFileName(SelectedFilePath);

        public string SelectedFormat
        {
            get => _selectedFormat;
            set { _selectedFormat = value; OnPropertyChanged(); }
        }

        public ConversionJob? SelectedJob
        {
            get => _selectedJob;
            set { _selectedJob = value; OnPropertyChanged(); }
        }

        private bool _isDarkTheme = true;
        public bool IsDarkTheme
        {
            get => _isDarkTheme;
            set { _isDarkTheme = value; OnPropertyChanged(); OnPropertyChanged(nameof(ThemeIcon)); }
        }
        public string ThemeIcon => IsDarkTheme ? "☀️" : "🌙";

        public ObservableCollection<string> AvailableFormats { get; } = new();
        public ObservableCollection<ConversionJob> Jobs { get; } = new();

        public RelayCommand SelectFileCommand { get; }
        public RelayCommand ConvertCommand { get; }
        public RelayCommand ShowOutputFolderCommand { get; }
        public RelayCommand ToggleThemeCommand { get; }
        ChooseConversion Conversion = new ChooseConversion();
        public MainViewModel()
        {
            SelectFileCommand = new RelayCommand(SelectFile);
            ConvertCommand = new RelayCommand(AddConversionJob);
            ShowOutputFolderCommand = new RelayCommand(ShowOutputFolder);
            ToggleThemeCommand = new RelayCommand(ToggleTheme);

        }

        private void ToggleTheme()
        {
            IsDarkTheme = !IsDarkTheme;
            App.SwitchTheme(IsDarkTheme);
        }

        private void SelectFile()
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg;*.webp|CSV Files|*.csv|All Files|*.*"
            };
            if (dialog.ShowDialog() != true) return;

            SelectedFilePath = dialog.FileName;
            UpdateAvailableFormats();
        }

        private void UpdateAvailableFormats()
        {
            AvailableFormats.Clear();

            var ext = Path.GetExtension(SelectedFilePath).ToLower();

            switch (ext)
            {
                case ".png":
                    AvailableFormats.Add("JPG");
                    AvailableFormats.Add("WEBP");
                    Conversion = ChooseConversion.ImageConversion;
                    break;
                case ".jpg":
                case ".jpeg":
                    AvailableFormats.Add("PNG");
                    AvailableFormats.Add("WEBP");
                    Conversion = ChooseConversion.ImageConversion;
                    break;
                case ".webp":
                    AvailableFormats.Add("PNG");
                    AvailableFormats.Add("JPG");
                    Conversion = ChooseConversion.ImageConversion;
                    break;
                case ".csv":
                    AvailableFormats.Add("XLSX");
                    Conversion = ChooseConversion.XLSXConversion;
                    break;
            }

            SelectedFormat = AvailableFormats.FirstOrDefault() ?? string.Empty;
        }

        private async void AddConversionJob()
        {
            if (string.IsNullOrEmpty(SelectedFilePath) || string.IsNullOrEmpty(SelectedFormat))
            {
                MessageBox.Show("Please select a file and a target format first.", "Filevy");
                return;
            }

            var inputExt = Path.GetExtension(SelectedFilePath).TrimStart('.').ToUpper();
            var outputPath = Path.ChangeExtension(SelectedFilePath, SelectedFormat.ToLower());

            var job = new ConversionJob
            {
                InputFilePath = SelectedFilePath,
                OutputFilePath = outputPath,
                ConversionType = $"{inputExt} → {SelectedFormat}",
                Status = ConversionStatus.Running,
                Progress = 0
            };

            Jobs.Add(job);

            var progress = new Progress<int>(value => job.Progress = value);

            try
            {
                switch (Conversion)
                {
                    case ChooseConversion.ImageConversion:
                        await Task.Run(() => Converters.ImageConverter.Convert(job.InputFilePath, job.OutputFilePath, progress));
                        break;
                    case ChooseConversion.XLSXConversion:
                        await Task.Run(() => Converters.XLSXConverter.Convert(job.InputFilePath, job.OutputFilePath, progress));
                        break;
                }


                job.Status = ConversionStatus.Done;
            }
            catch (Exception ex)
            {
                job.Status = ConversionStatus.Failed;
                MessageBox.Show($"Conversion failed: {ex.Message}", "Filevy");
            }
        }

        private void ShowOutputFolder()
        {
            if (SelectedJob == null) return;

            if (SelectedJob.Status != ConversionStatus.Done)
            {
                MessageBox.Show("This file has not been converted yet.", "Filevy");
                return;
            }

            var folder = Path.GetDirectoryName(SelectedJob.OutputFilePath);
            if (!string.IsNullOrEmpty(folder))
                Process.Start("explorer.exe", folder);
        }
    }
}