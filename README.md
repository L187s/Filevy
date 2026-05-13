# 🗂️ Filevy

> **Convert anything. Share nothing.**

Filevy is a free, open-source file converter for Windows — built with WPF.  
No internet. No cloud. No accounts. No telemetry. Your files never leave your computer. Ever.

---

## 🔒 Privacy First — Always

Most converters upload your files to a server somewhere.  
**Filevy doesn't.** Not even a little bit.

- ❌ No internet connection required
- ❌ No cloud uploads
- ❌ No API calls to external services
- ❌ No accounts or logins
- ❌ No telemetry or usage tracking
- ✅ 100% offline — everything runs locally on your machine
- ✅ Open source — verify it yourself

**Your files are your files. Period.**

---

## ✨ Features

- 🖥️ Clean, modern WPF desktop UI
- ⚡ Fast batch conversions
- 📂 Drag & Drop support
- 🔄 Supports 10+ conversion types (more coming!)
- 🔒 Zero network access — completely air-gap safe

---

## 🔄 Supported Conversions

| # | Conversion | Status |
|---|-----------|--------|
| 01 | PNG / JPG / WEBP ↔ each other | ❌ Not finished yet — [Issue #1](https://github.com/YOUR_USERNAME/Filevy/issues/1) |
| 02 | PDF → DOCX | ❌ Not finished yet — [Issue #2](https://github.com/YOUR_USERNAME/Filevy/issues/2) |
| 03 | DOCX / TXT → PDF | ❌ Not finished yet — [Issue #3](https://github.com/YOUR_USERNAME/Filevy/issues/3) |
| 04 | MP4 → MP3 | ❌ Not finished yet — [Issue #4](https://github.com/YOUR_USERNAME/Filevy/issues/4) |
| 05 | CSV → XLSX (Excel) | ❌ Not finished yet — [Issue #5](https://github.com/YOUR_USERNAME/Filevy/issues/5) |
| 06 | SVG → PNG / PDF | ❌ Not finished yet — [Issue #6](https://github.com/YOUR_USERNAME/Filevy/issues/6) |
| 07 | MP3 / WAV ↔ each other | ❌ Not finished yet — [Issue #7](https://github.com/YOUR_USERNAME/Filevy/issues/7) |
| 08 | HEIC → JPG / PNG | ❌ Not finished yet — [Issue #8](https://github.com/YOUR_USERNAME/Filevy/issues/8) |
| 09 | Markdown → HTML / PDF | ❌ Not finished yet — [Issue #9](https://github.com/YOUR_USERNAME/Filevy/issues/9) |
| 10 | ZIP / RAR ↔ ZIP / 7Z | ❌ Not finished yet — [Issue #10](https://github.com/YOUR_USERNAME/Filevy/issues/10) |

---

## 🚀 Getting Started

### Requirements
- Windows 10 / 11
- .NET 9 (WPF)
- Visual Studio 2022/2026 or Rider

### Desktop Runtime Version 9.0.16 (Microsoft)
The following Runtime version needs to be downloaded to work on this project

#### Download Link 9.0.16 ⚠️Be aware the link auto-downloads the file⚠️
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-9.0.16-windows-x64-installer?cid=getdotnetcore 



### Build & Run

```bash
git clone https://github.com/YOUR_USERNAME/Filevy.git
cd Filevy
dotnet build
dotnet run
```

---

## 🤝 Contributing

This project is perfect for beginners and first-time contributors!

Every conversion above has its own **Good First Issue** on GitHub. Pick one, implement it, and open a pull request.

> ⚠️ Important: All conversions must run **100% locally** using NuGet packages or built-in .NET libraries only. No API calls, no cloud services, no external network requests of any kind.

1. Fork the repo
2. Create a branch: `git checkout -b feature/png-to-jpg`
3. Implement the conversion (locally only!)
4. Open a Pull Request

Please keep each PR to **one conversion type** so reviews stay focused.

---

## 📄 License

MIT — do whatever you want with it.
