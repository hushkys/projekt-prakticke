# Users, Groups and OUs (Users, Groups and OUs)

Creating an organizational structure in Active Directory — organizational units, groups, and user accounts.

## Step-by-Step Guide

### 1. Creating Organizational Units (OUs)
Open "Active Directory Users and Computers" (ADUC). Right-click the domain → New → Organizational Unit. Create an OU for each department.

![Step 1](../../images/ServerWin/Uživatelé (4)/VytvoreniOrganizacniJednotky.png)

### 2. Group Structure Overview
Overview of created groups in the domain — Management, Teachers, Students, Accounting, THP. Each group has its own OU.

![Step 2](../../images/ServerWin/Uživatelé (4)/Skupiny.png)

### 3. New User Creation
Create a new user: right-click the OU → New → User. Fill in first name, last name and login name.

![Step 3](../../images/ServerWin/Uživatelé (4)/VytvoreniUzivatele1.png)

### 4. Password Security
Set the user password. Check "User must change password at next logon" for improved security.

![Step 4](../../images/ServerWin/Uživatelé (4)/VytvoreniUzivatele2.png)

### 5. Group Membership Assignment
Add the user to a group: right-click the user → "Add to a group".

![Step 5](../../images/ServerWin/Uživatelé (4)/PridaniDoSkupin1.png)

### 6. Name Verification
Enter the group name and click "Check Names" to verify the group name is correct.

![Step 6](../../images/ServerWin/Uživatelé (4)/PridaniDoSkupin2.png)

### 7. Confirmation
Confirm adding to the group. The user is now a member of the selected group.

![Step 7](../../images/ServerWin/Uživatelé (4)/PridaniDoSkupin3.png)

### 8. Example: Management Group
The Management group with assigned users — school managers and directors.

![Step 8](../../images/ServerWin/Uživatelé (4)/Vedeni.png)

### 9. Example: Teachers Group
The Teachers group with assigned users — teaching staff.

![Step 9](../../images/ServerWin/Uživatelé (4)/Ucitele.png)

### 10. Backup User (backup_user)
Creating a backup user (backup_user) with limited rights only for backup tasks.

![Step 10](../../images/ServerWin/Uživatelé (4)/TvorbaBackup_user.png)

> [!TIP]
> The backup account should follow the principle of least privilege — only rights necessary for backup tasks.

### 11. Final Organizational Structure
The resulting final domain structure with all OUs, groups and users.

![Step 11](../../images/ServerWin/Uživatelé (4)/StrukturaFinal.png)

## Troubleshooting & FAQ

#### User cannot log in — password is rejected.
> **Solution:** Check if "Account is disabled" or "User must change password at next logon" is checked without the user having changed it. In ADUC right-click the user → Properties → Account.

#### "Check Names" cannot find the group or user.
> **Solution:** The name must be exact. Try entering just part of the name and click Check Names. Also verify you are logged in as a domain admin.

#### Cannot create OU — "New → Organizational Unit" option is missing.
> **Solution:** Ensure you are right-clicking directly on the domain name or an existing OU, not on empty space in the right panel.

---
[ Back to Overview](../../README.md)