# Thunderbird Client Configuration (Thunderbird — Client Configuration)

Setting up Mozilla Thunderbird to connect to a local Kerio Connect mail server.

## Step-by-Step Guide

### 1. Account Creation
Launch Thunderbird. Add a new email account — enter your full name, email address (e.g., user@skola.localhost), and the password you set in Kerio.

### 2. Manual Configuration
Thunderbird will fail to auto-detect settings for a local server. Click "Manual Config" or "Advanced Settings".

> [!WARNING]
> Thunderbird will warn about an insecure connection. For local lab testing, click "Accept Security Exception".

### 3. Incoming Server (POP3)
Set the incoming server to: `localhost`, Port `110`, Encryption `None`, Authentication `Normal password`.

### 4. Outgoing Server (SMTP)
Set the outgoing server to: `localhost`, Port `25`, Encryption `None`, Authentication `Normal password`.

> [!TIP]
> The username for SMTP must be your full email address: user@skola.localhost.

### 5. Multi-User Testing
Add a second user account following the same steps. Try sending a test email from the first account to the second.

### 6. Delivery Verification
Switch to the second account's inbox and verify the email arrived. If it didn't, check if "Open Relay" is enabled in Kerio.

## Troubleshooting & FAQ

#### Thunderbird warns about an insecure connection.
> **Solution:** Click "Accept Security Exception". Since you are running in a local isolated network, unencrypted communication is acceptable for testing.

#### Email sent from one account doesn't arrive in the other.
> **Solution:** Check Kerio Connect's "Message Queues" to see if the mail is stuck. Ensure the Kerio antivirus isn't blocking local traffic.

---
[ Back to Overview](../../README.md)