# DDTank/Gunny Full-Stack Local Execution Guide

This repository contains the architecture required to resurrect a full localized DDTank environment including dynamic infrastructure routing.

## 🛠️ Prerequisites
- **Windows OS** (required for active PPAPI execution branches)
- **IIS Express**
- **MS SQL Server LocalDB** (pre-targeted for `(localdb)\MSSQLLocalDB`)

## 🏗️ Deployment Sequence

### 1. Database Configuration
Restore the provided backups into your localized instance:
- `Db_Membership`
- `Project_Player34`
- `Project_Game34`

Ensure testing account schemas match proper assignment states.

### 2. Desktop Orchestrator Execution
The desktop WinForms orchestrator controls the stack lifecycles and provides integrated routing.

To compile:
```powershell
cd "Source Launcher\TestHost"
dotnet build
```

To run:
Execute the compiled binary: `\Source Launcher\TestHost\bin\x86\Debug\win-x86\TestHost.exe`

## 🎛️ Automated Routing
The desktop orchestrator sequentially initializes supporting sub-modules to eliminate external binding constraints:
1. **Static Payload Host** (Bound on port 19999)
2. **Reverse API Routing** (Proxies mapped `/Request/*.ashx` routes directly)
3. **Internal Process Chains** (`Center.Service.exe`, `Fighting.Service.exe`, `Road.Service.exe`)
