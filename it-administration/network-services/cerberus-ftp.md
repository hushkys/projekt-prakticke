# Cerberus FTP Server (Cerberus FTP Server)

Alternative FTP server Cerberus with SSL/TLS support — installation, configuration, and user management.

## Step-by-Step Guide

### 1. Installation
Install Cerberus FTP Server from the installer. Choose "Personal Use" during the setup wizard.

> [!TIP]
> A folder named "ftproot" will be automatically created on drive C: — this serves as the default directory for your users.

### 2. User Configuration
Fill in the username and password, check all permission boxes at the bottom. If a dialog box appears, click "No" and continue through the wizard.

> [!TIP]
> Cerberus supports FTP, FTPS, and SFTP. For secure transfers, choose FTPS (SSL/TLS).

### 3. Client Setup (Total Commander)
Launch Total Commander. Use the "FTP" button in the top toolbar to open the connection window and click "New Connection".

> [!WARNING]
> Ensure the "SSL/TLS" option is checked. Without this, the connection will not be encrypted.

### 4. Library Issues
If you encounter an "OpenSSL library not found" error, try connecting again or launch Total Commander directly from the provided source media.

## Troubleshooting & FAQ

#### "OpenSSL library not found" during SSL/TLS connection.
> **Solution:** Use the version of Total Commander that includes OpenSSL binaries. Alternatively, try connecting without SSL for initial testing.

#### Certificate error during FTPS connection.
> **Solution:** Cerberus uses a self-signed certificate by default. Total Commander will ask if you trust it — click "Yes/Accept".

---
[ Back to Overview](../../README.md)