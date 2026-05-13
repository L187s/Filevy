# Changelog

All notable changes to Filevy will be documented here.

---

## [Unreleased]

- Conversion features in progress — see open issues

---

## [0.2.1] - 2026-05-13

### Added
- Dark / Light theme toggle with instant switching
- Custom title bar (minimize, maximize, close) replacing default Windows chrome
- WEBP conversion support via SkiaSharp (PNG ↔ JPG ↔ WEBP now fully working)
- Job list with progress bar and percentage display
- "Show in Explorer" button — opens output folder after conversion completes

### Changed
- Replaced placeholder UI with a fully structured MVVM-wired main window
- Image converter rewritten using SkiaSharp — handles all three formats consistently

### Fixed
- Crash when converting to WEBP (missing encoder — now handled by SkiaSharp)

---

## [0.2.0] - 2026-05-12

### Added 
- Added functionality to Convert JPG/PNG
- Added GUI MockUp for tests

#### Be Aware ⚠️
- Be aware that when you try to convert to .webp the program cashes.
- Nuget Package needed: SkiaSharp (Documentation: https://skiasharp.com/)

## [0.1.2] - 2026-05-12
### Added 
- Added MVVM Files
- Added MVVM Folder-Structure

## [0.1.1] - 2026-05-12

### Changed
- Changed the .Net version in the Readme file from 8.0 to 9.0

### Added
- Added the download-link to the .Net version 9.0 (official Microsoft site)

### Issue Update
- Closing this Version Closes the Issue: https://github.com/L187s/Filevy/issues/12

## [0.1.0] — 2026-05-11

### Added
- Initial project setup (WPF, .NET 9)
- README with project description and privacy manifesto
- 10 planned conversion types listed as Good First Issues
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
