# SSH Access to Ubuntu (SSH Access)

How to connect to an Ubuntu server via SSH from Windows — more convenient than typing directly into the VM.

## Step-by-Step Guide

### 1. SSH Server Installation
If you did not check SSH server during installation, install it now.

```bash
sudo apt update
sudo apt install openssh-server
sudo systemctl enable ssh
sudo systemctl start ssh
```

### 2. Service Verification
Verify that SSH is running and find the server IP address.

```bash
sudo systemctl status ssh.service
hostname -I
```

### 3. PowerShell Connection
From Windows open PowerShell and connect. Replace username and IP with your server details.

```powershell
ssh username@ip_address
# Example:
ssh admin@10.15.0.69
```

> [!TIP]
> On first connection confirm the fingerprint by typing "yes". Then enter the password.

### 4. Basic Navigation
You are connected via SSH. Basic commands for navigating the server:

```bash
ls -la                    # list files in directory
pwd                       # show current directory
cd /var/www               # change directory
sudo su                   # switch to root user
systemctl status apache2  # check Apache status
```

## Troubleshooting & FAQ

#### SSH connection fails — "Connection refused" or timeout.
> **Solution:** Check: 1) SSH service is running on Ubuntu. 2) IP address is correct. 3) Network adapter in VirtualBox — for SSH from the host it must be NAT with port forwarding or Bridged.

#### "WARNING: REMOTE HOST IDENTIFICATION HAS CHANGED".
> **Solution:** The server SSH key changed (reinstallation, VM clone). Delete the old record on Windows: `ssh-keygen -R server_IP` and reconnect.

---
[ Back to Overview](../../README.md)