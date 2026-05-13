# Filevy

**Local file conversion. No cloud. No compromise.**

Filevy is a free, open-source desktop file converter for Windows, built with WPF and .NET 9.
Every conversion runs entirely on your machine — no internet connection, no data collection, no external dependencies of any kind.

---

## Privacy

Most file converters route your files through a remote server.
Filevy does not. Every operation is performed locally, using either built-in .NET libraries or verified open-source NuGet packages.

- No internet connection required
- No cloud uploads or remote processing
- No API calls to external services
- No accounts, logins, or registration
- No telemetry or usage tracking
- Fully air-gap safe

Your files remain on your machine at all times.

---

## Features

- Modern WPF desktop interface with dark and light theme support
- Live conversion progress tracking per job
- Job history view with input/output file names and conversion type
- Output folder navigation directly from the UI
- 100% offline — no network access at any point

---

## Supported Conversions

| # | Conversion | Status |
|---|---|---|
| 01 | PNG / JPG / WEBP ↔ each other | ✅ Available — [Issue #1](https://github.com/L187s/Filevy/issues/1) |
| 02 | PDF → DOCX | ⏳ In progress — [Issue #2](https://github.com/L187s/Filevy/issues/2) |
| 03 | DOCX / TXT → PDF | ⏳ In progress — [Issue #3](https://github.com/L187s/Filevy/issues/3) |
| 04 | MP4 → MP3 | ⏳ In progress — [Issue #4](https://github.com/L187s/Filevy/issues/4) |
| 05 | CSV → XLSX | ❌ Not started — [Issue #5](https://github.com/L187s/Filevy/issues/5) |
| 06 | SVG → PNG / PDF | ❌ Not started — [Issue #6](https://github.com/L187s/Filevy/issues/6) |
| 07 | MP3 / WAV ↔ each other | ❌ Not started — [Issue #7](https://github.com/L187s/Filevy/issues/7) |
| 08 | HEIC → JPG / PNG | ❌ Not started — [Issue #8](https://github.com/L187s/Filevy/issues/8) |
| 09 | Markdown → HTML / PDF | ❌ Not started — [Issue #9](https://github.com/L187s/Filevy/issues/9) |
| 10 | ZIP / RAR ↔ ZIP / 7Z | ❌ Not started — [Issue #10](https://github.com/L187s/Filevy/issues/10) |

---

## Requirements

| Requirement | Version |
|---|---|
| Operating System | Windows 10 / 11 (x64) |
| .NET Desktop Runtime | 9.0.16 |
| IDE (for development) | Visual Studio 2022+ or JetBrains Rider |

**.NET 9.0.16 Desktop Runtime** is required to run Filevy.
[Download from Microsoft](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-9.0.16-windows-x64-installer?cid=getdotnetcore)

> The link above initiates an automatic download of the official Microsoft installer.

---

## NuGet Dependencies

| Package | Version | Purpose |
|---|---|---|
| [SkiaSharp](https://github.com/mono/SkiaSharp) | latest stable | Image encoding/decoding (PNG, JPG, WEBP) |

---

## Getting Started

```bash
git clone https://github.com/L187s/Filevy.git
cd Filevy
dotnet build
dotnet run
```

---

## Contributing

Filevy is open to contributions. Every planned conversion type has a corresponding GitHub issue labeled **Good First Issue**.

**Before contributing, please read:**

- All conversions must run **100% locally** — no API calls, no cloud services, no external network requests of any kind
- Each pull request should cover **one conversion type only**
- NuGet packages are permitted provided they are MIT-licensed and do not perform any network activity

**Workflow:**

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-conversion`
3. Implement the conversion
4. Open a pull request against `main`

For questions or discussion, use the relevant GitHub issue.

---

## Changelog

This project follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).
See [CHANGELOG.md](https://github.com/L187s/Filevy/blob/main/CHANGELOG.md) for the full version history.

---

## License

MIT License — see [LICENSE.txt](LICENSE.txt) for details.
