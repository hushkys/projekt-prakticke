# Domain Controller and AD DS (Domain Controller and AD DS)

How to promote a server to a Domain Controller, install Active Directory, and create a domain structure.

## Step-by-Step Guide

### 1. Launching the Wizard
In Server Manager click "Add Roles and Features". The roles and features wizard will start.

![Step 1](../../images/ServerWin/DomenoveHratky (2)/RoleAFunkce1.png)

### 2. Installation Type Selection
Select installation type "Role-based or feature-based installation" and choose the local server.

![Step 2](../../images/ServerWin/DomenoveHratky (2)/RoleAFunkce2.png)

### 3. Active Directory Role
From the roles list check "Active Directory Domain Services". Confirm adding dependent features by clicking "Add Features".

![Step 3](../../images/ServerWin/DomenoveHratky (2)/RoleAFunkce3.png)

### 4. Installation Progress
Start the installation and wait for completion. Progress of AD DS role and dependent components installation.

![Step 4](../../images/ServerWin/DomenoveHratky (2)/RoleAFunkceInstalace.png)

### 5. Promoting to DC
After installation click the yellow exclamation mark in Server Manager and choose "Promote this server to a domain controller".

![Step 5](../../images/ServerWin/DomenoveHratky (2)/PovyseniNaRadic.png)

> [!WARNING]
> This action is irreversible — the server will become a DC. Ensure your network settings are correctly configured beforehand.

### 6. New Forest and Domain Name
Choose "Add a new forest" and enter the domain name (e.g. skola.local). Set the DSRM (Directory Services Restore Mode) password.

![Step 6](../../images/ServerWin/DomenoveHratky (2)/VytvoreniDomeny1.png)

> [!TIP]
> The domain name must have a suffix — .local, .lan or .internal are recommended for internal networks.

### 7. Restart and Domain Login
Complete the wizard and let the server restart. After restart log in as DOMAIN\Administrator.

![Step 7](../../images/ServerWin/DomenoveHratky (2)/VytvoreniDomeny2.png)

### 8. Final Status Check
The server is now a Domain Controller. In Server Manager you will see new tools — AD DS, DNS and DHCP.

![Step 8](../../images/ServerWin/DomenoveHratky (2)/ServerPoInstalaci.png)

## Troubleshooting & FAQ

#### "Promote to DC" wizard reports an error during prerequisites check.
> **Solution:** Most often a misconfigured static IP or DNS. The server must have a static IP and use itself as DNS server (127.0.0.1). Check the network adapter settings.

#### Cannot log in after restart — login screen does not show the domain.
> **Solution:** Log in as DOMAIN\Administrator (e.g. SKOLA\Administrator). If the domain is not visible, click "Other user" and type the full domain name manually.

#### DNS not working after promoting to DC — clients cannot find the domain.
> **Solution:** Check that the DNS role is installed and running. On the server run: `nslookup skola.local` — it must respond. Clients must use the DC IP address as their DNS server.

---
[ Back to Overview](../../README.md)