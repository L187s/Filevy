# Changelog

All notable changes to Filevy are documented in this file.
This project follows the [Keep a Changelog](https://keepachangelog.com/en/1.1.0/) format.

---

## [Unreleased]

- Remaining conversion types in progress — see open issues

---

## [0.2.1] — 2026-05-13

### Added
- Dark and light theme support with instant toggle, no restart required
- Custom title bar replacing the default Windows chrome (minimize, maximize, close)
- WEBP read and write support via SkiaSharp — full PNG / JPG / WEBP interconversion now available
- Live progress bar per conversion job with percentage display
- Job history list showing input file, output file, conversion type and progress
- "Show in Explorer" button — opens the output directory once a conversion completes

### Changed
- Image converter rewritten using SkiaSharp, replacing the previous WPF-native codec implementation
- Main window fully wired to MVVM — no logic in code-behind

### Fixed
- Application crash when attempting to convert to WEBP due to missing WPF encoder

---

## [0.2.0] — 2026-05-12

### Added
- PNG and JPG interconversion using built-in WPF codecs
- Initial GUI layout for conversion workflow

### Known Issues
- Conversion to WEBP causes a crash — resolved in 0.2.1
- Requires NuGet package: SkiaSharp

---

## [0.1.2] — 2026-05-12

### Added
- MVVM folder structure (Models, Views, ViewModels, Commands, Converters)
- ViewModelBase with INotifyPropertyChanged
- RelayCommand implementing ICommand
- MainViewModel wired as DataContext

---

## [0.1.1] — 2026-05-12

### Changed
- Updated .NET target version in README from 8.0 to 9.0

### Added
- Direct download link for .NET Desktop Runtime 9.0 (official Microsoft installer)

### References
- Closes [Issue #12](https://github.com/L187s/Filevy/issues/12)

---

## [0.1.0] — 2026-05-11

### Added
- Initial project setup (WPF, .NET 9)
- README with project description and privacy policy
- 10 planned conversion types, each tracked as a Good First Issue on GitHub:
  - PNG / JPG / WEBP ↔ each other
  - PDF → DOCX
  - DOCX / TXT → PDF
  - MP4 → MP3
  - CSV → XLSX
  - SVG → PNG / PDF
  - MP3 / WAV ↔ each other
  - HEIC → JPG / PNG
  - Markdown → HTML / PDF
  - ZIP / RAR ↔ ZIP / 7Z
