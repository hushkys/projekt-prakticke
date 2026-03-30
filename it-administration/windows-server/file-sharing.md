# Shared Folders and Permissions (Shared Folders and Permissions)

Creating shared network folders with access rights configured for different user groups.

## Step-by-Step Guide

### 1. Folder Structure Preparation
Create the folders you want to share — e.g. C:\Shared\Documents, C:\Shared\Teachers.

![Step 1](../../images/ServerWin/Sdileni slozek (5)/VytvoreniSlozek1.png)

### 2. Folder Sharing
Right-click the folder → Properties → Sharing → "Share this folder". Set the share name.

![Step 2](../../images/ServerWin/Sdileni slozek (5)/SdiletTutoSlozku2.png)

### 3. Everyone Group Removal
In the "Security" tab, remove the "Everyone" group — we don't want every user to have access.

![Step 3](../../images/ServerWin/Sdileni slozek (5)/OdebratEveryone3.png)

> [!WARNING]
> Leaving the Everyone group with full access is a security risk — always remove it!

### 4. Group Assignment
Add a specific group (e.g. Teachers or Domain Users). Click "Check Names" for verification.

![Step 4](../../images/ServerWin/Sdileni slozek (5)/PridatDomainUserKontrolaNazvu4.png)

### 5. NTFS Permissions
Set permissions for the added group — Full Control, Modify, or Read as needed.

![Step 5](../../images/ServerWin/Sdileni slozek (5)/PovolitUplneRizeni5.png)

### 6. Confirmation and Test
Confirm the settings. The folder is now available over the network. Test access from a client.

![Step 6](../../images/ServerWin/Sdileni slozek (5)/NastaveniOpravneni6.png)

> [!TIP]
> From the client PC test: Win+R → type \server_IP → Enter. Shared folders should appear.

## Troubleshooting & FAQ

#### Cannot access the shared folder from client — "Network path not found".
> **Solution:** Check: 1) Client can see the server (ping server_IP). 2) Folder is actually shared (Share name set). 3) Windows Firewall on the server allows File and Printer Sharing. 4) Both machines are on the same network.

#### Access denied even though the user is in the correct group.
> **Solution:** Permissions exist in two places — Share permissions AND NTFS permissions (Security tab). Both must be set. The most common issue is missing NTFS permissions in the Security tab.

#### "Everyone" was removed but nobody has access.
> **Solution:** After removing Everyone you must add a specific group or user. Check the Security tab — a group (e.g. Domain Users) must be added with the appropriate permissions.

---
[ Back to Overview](../../README.md)