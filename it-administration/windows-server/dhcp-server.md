# DHCP Server and IP Configuration (DHCP Server and IP Configuration)

Configuring a static IP address for the server and setting up DHCP for automatic address assignment to clients.

## Step-by-Step Guide

### 1. Static IP Configuration
First set a static IP address for the server. Open Network Adapter Settings → IPv4 Properties and fill in manually.

![Step 1](../../images/ServerWin/DHCP a nastaveni IP (3)/NastaveniIPServeru.png)

> [!TIP]
> Recommended config: IP 192.168.1.1, mask 255.255.255.0, gateway 192.168.1.1, DNS 127.0.0.1

### 2. DHCP Role Addition
In Server Manager add the "DHCP Server" role. After installation click the yellow exclamation mark and complete the post-install configuration.

![Step 2](../../images/ServerWin/DHCP a nastaveni IP (3)/KonfiguraceDHCP1.png)

### 3. New Scope Wizard
Open DHCP Manager and create a new scope: right-click IPv4 → New Scope. The wizard will start.

![Step 3](../../images/ServerWin/DHCP a nastaveni IP (3)/KonfiguraceDHCP2.png)

### 4. IP Address Range
Enter the scope name and define the IP address range for client devices.

![Step 4](../../images/ServerWin/DHCP a nastaveni IP (3)/TvorbaOboru1.png)

> [!TIP]
> Example range: Start 192.168.1.100 — End 192.168.1.200. The server IP (192.168.1.1) must be outside this range.

### 5. Address Exclusions
Set exclusions for addresses you do not want assigned automatically — printers, static servers, or networking equipment.

![Step 5](../../images/ServerWin/DHCP a nastaveni IP (3)/TvorbaOboru2.png)

### 6. Lease Duration
Set the lease duration. The default 8 days is suitable for stable office networks.

![Step 6](../../images/ServerWin/DHCP a nastaveni IP (3)/TvorbaOboru3.png)

### 7. Scope Activation
Enter the default gateway (server IP) and DNS server IP. Activate the scope by clicking "Yes, I want to activate this scope now".

![Step 7](../../images/ServerWin/DHCP a nastaveni IP (3)/TvorbaOboru4.png)

### 8. Scope Status Verification
The scope should now be active (indicated by a green icon). Clients on the network will automatically receive IP addresses.

![Step 8](../../images/ServerWin/DHCP a nastaveni IP (3)/TvorbaOboru5.png)

### 9. Address Leases Monitoring
Verify functionality in DHCP Manager — the "Address Leases" tab shows all addresses currently assigned to clients.

![Step 9](../../images/ServerWin/DHCP a nastaveni IP (3)/KonfiguraceDHCP3.png)

## Troubleshooting & FAQ

#### Client does not get an IP address — stays on 169.254.x.x (APIPA).
> **Solution:** Most often a forgotten Internal Network adapter on the client, or the DHCP scope is not activated. Ensure client and server use the same Internal Network name in VirtualBox.

#### DHCP Manager conflict — "Another DHCP server exists".
> **Solution:** Multiple DHCP servers are present. Check if NAT adapter is enabled on the client — VirtualBox NAT has its own DHCP. Disable NAT and use only Internal Network.

#### Scope is created but is red or inactive.
> **Solution:** Manually activate the scope: right-click the scope → Activate. Also check if the DHCP server completed post-install authorization.

---
[ Back to Overview](../../README.md)