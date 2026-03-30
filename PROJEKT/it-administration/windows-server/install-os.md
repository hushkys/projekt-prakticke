# Windows Server Installation (OS Installation)

Step-by-step guide to installing Windows Server 2019/2022 with a graphical user interface (Desktop Experience) in VirtualBox.

## Step-by-Step Guide

### 1. Boot from ISO and Start VM
Launch the installation wizard — select language, time format, and keyboard layout. Click "Install now".

![Step 1](../../images/ServerWin/Instalace (1)/Instalce Server1.png)

### 2. Operating System Version
Select "Windows Server 2019 Standard (Desktop Experience)" from the list — this edition includes the full graphical interface.

![Step 2](../../images/ServerWin/Instalace (1)/WinServer - výběr Desktop edice 2.png)

> [!WARNING]
> Versions without "Desktop Experience" (Server Core) have no GUI — they are controlled only via the command line. Not recommended for beginners.

### 3. Installation Type
Choose "Custom: Install Windows only", select the target disk, and start the installation. The system will install and restart.

![Step 3](../../images/ServerWin/Instalace (1)/WinServer instalace 3.png)

### 4. Progress Tracking
The installer copies files and prepares the system. Wait for completion — it may take 10–20 minutes.

![Step 4](../../images/ServerWin/Instalace (1)/WinServer instalace4.png)

### 5. Administrator Password Configuration
After the restart, set the administrator password. It must meet complexity requirements — uppercase letters, numbers, and special characters.

![Step 5](../../images/ServerWin/Instalace (1)/WinServer Instalace 5.png)

> [!TIP]
> Recommended password: Admin123! — meets all requirements and is easy to remember.

### 6. Password Confirmation
Enter and confirm the password. The system will only accept it if all complexity requirements are satisfied.

![Step 6](../../images/ServerWin/Instalace (1)/NastaveniHeslaSpecialniZnaky.png)

### 7. Post-Installation State
After logging in, the Server Manager dashboard will appear. Installation is successful — the server is ready for roles and features configuration.

![Step 7](../../images/ServerWin/Instalace (1)/UspesneNainstalovano.png)

## Troubleshooting & FAQ

#### Installation is stuck or VM boots from ISO again after restart.
> **Solution:** After the initial file copy phase, detach the ISO: Settings → Storage → click the optical drive → "Remove disk from virtual drive". Otherwise, the VM keeps booting from the installer.

#### Administrator password is not accepted — "does not meet requirements".
> **Solution:** Windows Server requires passwords with uppercase letters, numbers, and special characters. Use e.g., Admin123! — simple and meets all criteria.

#### Only a black screen or command prompt appears instead of GUI after install.
> **Solution:** You selected the version without "Desktop Experience" (Server Core). You must reinstall and select the "Desktop Experience" edition.

#### VM is extremely slow after installation, Server Manager takes minutes to load.
> **Solution:** Allocate more RAM (2–4 GB recommended) and enable 3D acceleration in Settings → Display. Also, ensure VirtualBox Guest Additions are installed.

---
[ Back to Overview](../../README.md)