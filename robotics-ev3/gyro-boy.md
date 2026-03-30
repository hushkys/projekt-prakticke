# GYRO BOY – Balancing Robot (GYRO BOY)

Build the two-wheeled GYRO BOY robot that maintains balance using a gyroscopic sensor. An advanced project demonstrating inverted pendulum mechanics.

## Step-by-Step Guide

### 1. Building Instructions
Download the GYRO BOY instructions from LEGO Education. GYRO BOY is a core project for the EV3 expansion set.

> [!TIP]
> Instructions are also available within the EV3 Software under the "Robot Educator" section.

### 2. Precision Assembly
Precision is critical for self-balancing robots. Ensure the center of gravity is high and cables are tucked away symmetrically.

> [!WARNING]
> Any deviation from the instructions (different brick placement, loose cables) shifts the balance point and causes failure.

### 3. Gyro Sensor Orientation
Connect the Gyro Sensor to port 2. The arrow on the sensor must point in the direction of the robot's forward movement.

### 4. Motor Sync
Connect large motors to ports B and C. Ensure they are plugged in symmetrically for balanced output.

### 5. Calibration Protocol
Place the robot on a flat surface and keep it perfectly still for 2 seconds after starting the program for calibration.

> [!WARNING]
> Do NOT move the robot during the first 2 seconds of startup. Movement during calibration causes "drift", preventing the robot from balancing.

### 6. Tuning the Offset
If the robot falls forward, increase the "Gyro Offset" value in the program. If it falls backward, decrease it. Use small increments (±0.1).

## Troubleshooting & FAQ

#### Robot falls immediately and never tries to balance.
> **Solution:** Verify Gyro sensor orientation (arrow forward). Check motor ports (Left B, Right C). Ensure the robot was still during calibration.

#### Robot balances but drifts slowly.
> **Solution:** Fine-tune the Gyro Offset in the software. This compensates for slight variations in the physical build.

---
[ Back to Overview](../../README.md)