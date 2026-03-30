# BRICK SORT3R – LEGO Brick Sorter (BRICK SORT3R – Třídička)

Build and program the BRICK SORT3R robot from LEGO MINDSTORMS EV3, which automatically sorts bricks by color using a color sensor.

## Step-by-Step Guide

### 1. Preparation
Download building instructions from Robotsquare.com or use official LEGO documentation. Prepare your LEGO MINDSTORMS EV3 set.

> [!TIP]
> Robotsquare.com is a leading resource for LEGO MINDSTORMS projects by Laurens Valkenburgh.

### 2. Main Frame Assembly
Construct the core frame. Attach the EV3 Brick (the brain) centrally to ensure stability and easy cable access.

### 3. Motor Integration
Connect the Large Motor to port B (drives the conveyor belt). Connect the Medium Motor to port A (operates the sorting arm).

> [!WARNING]
> Ensure cables are fully seated. Loose connections are the primary cause of motor failure during operation.

### 4. Color Sensor Calibration
Connect the Color Sensor to port 3. Position it 1–2 cm above the conveyor belt, facing directly downward.

> [!TIP]
> Distance is critical. Too far or too close results in unreliable color detection. Experiment to find the sweet spot.

### 5. Programming Logic
Calibrate sensor values for each brick color (red, blue, yellow, green). Use the EV3 Color ID values.

```javascript
// EV3 Color IDs:
// 0=None, 1=Black, 2=Blue, 3=Green, 4=Yellow, 5=Red, 6=White
```

### 6. Operation Loop
Program the main loop: Start belt → Wait for color detection → Stop belt → Move arm to bin position → Restart belt.

### 7. Arm Positioning
Fine-tune the rotation angles for each collection bin. Use 30–50% motor power for higher sorting accuracy.

## Troubleshooting & FAQ

#### Inconsistent color detection.
> **Solution:** Check ambient lighting. Direct sunlight or heavy shadows interfere with the sensor. Add a small LEGO shield around the sensor.

#### Bricks jamming on the conveyor.
> **Solution:** Verify gear alignment. Ensure the belt is neither too tight nor too loose. Lower the belt motor speed.

---
[ Back to Overview](../../README.md)