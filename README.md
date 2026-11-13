# SaleAndMarketing (SAM)

WinForms (VB.NET) project.

## Setup
1. Copy `connections.config.example` -> `connections.config` and fill in real SQL Server values.
2. Copy `secrets.config.example` -> `secrets.config` and fill in FTP / URL values.
3. Both files are git-ignored. Never commit them.
4. Add required libraries yourself (not stored in git): `GrTeamSystem.dll`, `KsbLibrary.dll`
   (project references them via `bin\Debug\`), plus the Crystal Reports / DevExpress dependencies.
