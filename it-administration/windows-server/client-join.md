# Joining a Client to the Domain (Joining a Client to the Domain)

How to join a Windows client to an Active Directory domain — DNS setup, domain join, and logging in with a domain account.

## Step-by-Step Guide

### 1. DNS Setup on the Client
After logging into Windows verify network connectivity — the client must see the server. Set the client DNS server to the DC IP address (e.g. 192.168.1.1).

> [!TIP]
> The client DNS server MUST be the Domain Controller IP — not 8.8.8.8 or automatic. Without this, domain join will fail.

```powershell
ping 192.168.1.1
```

### 2. Domain Change
Open System Properties (Win+Pause) → Change settings → Change. Switch from "Workgroup" to "Domain" and enter the domain name (e.g. skola.local).

> [!TIP]
> The domain name must exactly match what you entered when creating the domain on the server.

### 3. Domain Admin Login
Enter the domain administrator credentials. The computer will join and show a welcome message.

### 4. Restart and First Login
Restart the client. On the login screen choose "Other user" and log in with a domain account (DOMAIN\user).

### 5. ADUC Verification
Client is successfully joined to the domain. In ADUC on the server you will see the new computer in the Computers section.

```powershell
whoami
echo %USERDOMAIN%
```

> [!TIP]
> The whoami command should show DOMAIN\user. If not, check the client DNS settings.

### 6. Successful Login
Domain user login was successful. The client is fully integrated into the domain.

## Troubleshooting & FAQ

#### Domain join fails — "An Active Directory Domain Controller for the domain could not be contacted".
> **Solution:** Client cannot see the server. Check: 1) Client has the DC IP as DNS server (not 8.8.8.8!). 2) Ping to server IP works. 3) Both VMs have Internal Network adapter on the same network. Most common mistake: forgetting to switch DNS from automatic to the server IP.

#### After joining the domain the client cannot log in with a domain account.
> **Solution:** On the login screen click "Other user" and enter DOMAIN\user (e.g. SKOLA\jan.novak). Just the username without domain logs in a local account, not a domain account.

#### Ping to server works but domain join still fails.
> **Solution:** Check that the client DNS server is set to the DC IP address. Open cmd and run: ipconfig /all — the "DNS Servers" line must point to the server IP, not 192.168.0.1 or 8.8.8.8.

---
[ Back to Overview](../../README.md)