# WordPress on Ubuntu (LAMP stack) (WordPress na Ubuntu)

Complete installation of a WordPress website on Ubuntu Server — including Apache, MariaDB, PHP, and WordPress.

## Step-by-Step Guide

### 1. Apache Web Server
Update the system and install the Apache web server. Enable automatic startup.

```bash
sudo apt update
sudo apt upgrade -y
sudo apt install apache2 -y
sudo systemctl enable apache2
sudo systemctl start apache2
```

> [!TIP]
> Verify Apache is working in your browser: http://server_IP

### 2. MariaDB Database
Install the MariaDB database server and run the security script.

```bash
sudo apt install mariadb-server -y
sudo mysql_secure_installation
```

> [!TIP]
> Recommendation: Switch to unix_socket? Y · Change root password? Y · Remove anonymous users? Y · Disallow root login remotely? Y · Remove test database? Y · Reload privilege tables? Y

### 3. Database Preparation
Log into MariaDB and create a database and user for WordPress.

```sql
sudo mysql
CREATE DATABASE wordpress CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'wpuser'@'localhost' IDENTIFIED BY 'StrongPassword123!';
GRANT ALL PRIVILEGES ON wordpress.* TO 'wpuser'@'localhost';
FLUSH PRIVILEGES;
EXIT;
```

### 4. PHP Modules
Install PHP and all required modules for WordPress functionality.

```bash
sudo apt install php libapache2-mod-php php-mysql php-curl php-gd php-mbstring php-xml php-xmlrpc php-soap php-intl php-zip -y
sudo systemctl restart apache2
```

### 5. Download WordPress
Download the latest WordPress package, extract it to the web directory, and set permissions.

```bash
cd /var/www/
sudo wget https://wordpress.org/latest.tar.gz
sudo tar -xvzf latest.tar.gz
sudo chown -R www-data:www-data /var/www/wordpress
sudo chmod -R 755 /var/www/wordpress
```

### 6. Apache VirtualHost
Create a configuration file for the WordPress site.

```bash
sudo nano /etc/apache2/sites-available/wordpress.conf
```

> [!TIP]
> Paste this configuration:
> ```apache
> <VirtualHost *:80>
>   ServerAdmin admin@example.com
>   DocumentRoot /var/www/wordpress
>   <Directory /var/www/wordpress>
>     AllowOverride All
>     Require all granted
>   </Directory>
>   ErrorLog ${APACHE_LOG_DIR}/wordpress_error.log
>   CustomLog ${APACHE_LOG_DIR}/wordpress_access.log combined
> </VirtualHost>
> ```

### 7. Site Activation
Enable the site, mod_rewrite, disable the default site, and restart Apache.

```bash
sudo a2ensite wordpress.conf
sudo a2enmod rewrite
sudo a2dissite 000-default.conf
sudo systemctl restart apache2
```

### 8. WordPress Configuration (wp-config.php)
Copy the sample config and update the database connection details.

```bash
cd /var/www/wordpress
sudo cp wp-config-sample.php wp-config.php
sudo nano wp-config.php
```

> [!TIP]
> Change DB_NAME to "wordpress", DB_USER to "wpuser", and DB_PASSWORD to your set password.

### 9. Firewall Setup
Allow HTTP traffic through the firewall.

```bash
sudo ufw allow Apache
sudo ufw enable
sudo systemctl reload apache2
```

### 10. Web-Based Setup
Navigate to http://server_IP in your browser and complete the WordPress installation wizard.

![WordPress](../../images/wordpress.png)

## Troubleshooting & FAQ

#### Browser shows default Apache page instead of WordPress.
> **Solution:** Disable the default config: `sudo a2dissite 000-default.conf && sudo systemctl reload apache2`. Ensure `wordpress.conf` is enabled.

#### Permission errors when uploading files.
> **Solution:** Ensure the web server owns the directory: `sudo chown -R www-data:www-data /var/www/wordpress`.

---
[ Back to Overview](../../README.md)