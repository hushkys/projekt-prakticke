# CaesarFTP Server Setup (CaesarFTP)

Setting up the CaesarFTP server on Windows — creating users, folders, and access permissions.

## Step-by-Step Guide

### 1. Directory Structure
Install CaesarFTP and Total Commander. In File Explorer on drive C: create a folder "FTP" with subfolders "Upload" and "Download".

![Step 1](../../images/Snímek obrazovky 2025-09-29 091642.png)

> [!TIP]
> This folder will be the FTP server root directory — users will only see its contents.

### 2. User Management
Launch CaesarFTP. Click the person icon for user management. Click "Add User" at the bottom left and fill in the username and password.

![Step 2](../../images/Snímek obrazovky 2025-09-29 091728.png)

> [!TIP]
> Remember the username and password — you will enter them in Total Commander.

### 3. Access Rights
Click on "File Access Rights". In the lower left square check: Read, Write, Append and Sub, List, SubDir Access. Drag the Upload and Download folders into the field.

![Step 3](../../images/Snímek obrazovky 2025-09-29 091754.png)

### 4. Server Settings
In the "Settings" tab open "Edit Server Options" and check "Launch on system start". Confirm with OK.

> [!TIP]
> This ensures the FTP server starts automatically after Windows restarts.

### 5. Firewall Configuration
The FTP server is running on port 21. Ensure Windows Firewall allows this port.

> [!WARNING]
> Port 21 must be allowed in Windows Firewall. Add an exception for CaesarFTP or TCP port 21.

## Troubleshooting & FAQ

#### Total Commander cannot connect — "Connection refused" or timeout.
> **Solution:** Check: 1) CaesarFTP is running. 2) Hostname is correct (localhost for same machine). 3) Port 21 is allowed in Firewall.

#### User logs in but sees no files or folders.
> **Solution:** In CaesarFTP user settings you must drag folders into the "File Access Rights" field. Without this the user has no access to any directory.

---
[ Back to Overview](../../README.md)