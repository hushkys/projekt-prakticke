# Line Follower – Line Tracking (EV3 Line Follower)

Build a robot that follows a black line on a white surface using a light/color sensor. A classic project for understanding PID control.

## Step-by-Step Guide

### 1. Chassis Build
Build a basic chassis with two large motors (ports B and C) and one free-moving wheel for stability.

> [!TIP]
> A symmetrical chassis is key — motors must be equally distant from the center for straight movement.

### 2. Sensor Placement
Connect the Color Sensor to port 1. Place it forward and down, approximately 1 cm above the surface, exactly in the center.

> [!WARNING]
> The sensor must be centered — if offset, the robot will systematically turn to one side.

### 3. Track Preparation
Create a black line (2–3 cm width) on a white background. Avoid extremely sharp turns for the basic version.

> [!TIP]
> Ideal line width is 2–2.5 cm. Too thin and the robot will lose the line during turns.

### 4. Sensor Calibration
Measure Reflected Light Intensity on both white and black surfaces. Calculate the threshold.

```javascript
// Typical values:
// White: 60–70
// Black: 5–15
// Threshold = average: (70 + 10) / 2 = 40
```

### 5. Basic Control (ON/OFF)
Program a simple logic: if light > threshold → turn left, if light < threshold → turn right.

> [!TIP]
> This works but is jerky. For smooth movement, implement PID control.

### 6. Advanced Control (PID)
Calculate error, multiply by coefficients Kp (Proportional), Ki (Integral), Kd (Derivative) to adjust motor speed.

```javascript
// PID pseudocode:
// error = sensor_value - threshold
// P = Kp * error
// I = I + error
// D = error - last_error
// correction = P + Ki*I + Kd*D
// motor_left = base_speed + correction
// motor_right = base_speed - correction
```

### 7. Testing and Tuning
Test on the track. Gradually increase base speed and fine-tune PID coefficients for smooth operation.

## Troubleshooting & FAQ

#### Robot wobbles aggressively and loses the line.
> **Solution:** Reduce the Kp (Proportional) coefficient. High Kp causes overshooting. Start with 0.3.

#### Robot fails to follow the line — goes straight.
> **Solution:** Check calibration — the threshold must be between black and white values. Ensure the sensor is in "Reflected Light" mode.

---
[ Back to Overview](../../README.md)