# Kerio Connect Mail Server (Kerio Connect — Mail Server)

Installing and configuring Kerio Connect as a local mail server in an isolated network.

## Step-by-Step Guide

### 1. Installation Preparation
Copy Kerio and Thunderbird from the installation media to the desktop. Install Thunderbird first.

> [!TIP]
> Order matters — install Thunderbird before starting Kerio configuration.

### 2. Network Isolation
In VirtualBox settings go to Network and switch the adapter to "Internal Network". Internet will not work from now on.

> [!WARNING]
> After switching to internal network, internet will not be available — mail is sent locally.

### 3. Custom Installation
Run the Kerio Connect installer. Choose the "Custom" installation type during the wizard.

> [!TIP]
> Leave the username as "Admin", password "123456" is sufficient for local testing.

### 4. Domain Setup
In the domain settings change "localhost" to "skola.localhost". Complete the wizard.

> [!TIP]
> The domain skola.localhost will be part of email addresses: user@skola.localhost

### 5. Engine Monitor
Kerio installs as a service. Find "Kerio" in the Start menu and launch "Engine Monitor". Open it from the system tray.

> [!TIP]
> Enter the administrator password you chose during installation.

### 6. Service Verification
Check "Configuration" → "Services" — all status indicators must be green. Verify the domain name.

### 7. Open Relay Configuration
In "Configuration" → "SMTP Server" check "Open relay" and click "Apply".

> [!WARNING]
> Without Open relay, mail cannot be sent between users! NEVER enable this on a public internet server.

### 8. Message Queue
Go to the "Message Queue Options" tab and set the error message sending interval to 1 minute.

> [!TIP]
> Shorter interval provides faster feedback during delivery troubleshooting.

### 9. User Account Creation
Go to "Domain Settings" → "User Accounts" → "Add". Create at least two test users.

### 10. POP3 Download Setup
For each user: "Configuration" → "POP3 Download" → "Add". Server = localhost, User = username. Choose the delivery address.

## Troubleshooting & FAQ

#### Kerio does not start or Engine Monitor shows nothing.
> **Solution:** Ensure the network adapter is active. Port 25 (SMTP) or 4040 (Admin) might be blocked by Windows Firewall. Run Engine Monitor as administrator.

#### Mails cannot be sent — SMTP error.
> **Solution:** Ensure "Open relay" is enabled in SMTP settings. Without it, Kerio rejects local relaying.

---
[ Back to Overview](../../README.md)