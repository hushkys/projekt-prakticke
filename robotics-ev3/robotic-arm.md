# Robotic Arm – Pick and Place (EV3 Robot Arm)

Build and program a robotic arm with EV3 that can grasp and move objects. A project for understanding coordinate systems and precise positioning.

## Step-by-Step Guide

### 1. Robust Base Build
Construct a solid base — a rigid foundation is critical for accuracy. Secure the EV3 Brick to the base.

### 2. Rotational Joint
Build the rotation assembly — the Large Motor in port A rotates the entire arm left/right.

> [!TIP]
> Add a touch sensor or use the motor's encoder to detect the home position (0° reference).

### 3. Vertical Joint (Elevation)
Build the elevation mechanism — the Large Motor in port B raises and lowers the arm. Use a counterweight for easier control.

> [!WARNING]
> Without a counterweight, the motor must hold the arm's weight — this causes rapid overheating. Add weight to the opposite side.

### 4. Gripper Assembly
Construct the gripper — the Medium Motor in port C opens and closes the claw. Add a touch sensor for grip detection.

### 5. Calibration Logic
Program a startup routine: move the arm to the home position and zero the motor encoders.

```javascript
// Reset encoders:
// Motor A: Reset Rotation → Port A
// Motor B: Reset Rotation → Port B
// Motor C: Reset Rotation → Port C
```

### 6. Coordinate-Based Movement
Define target positions as a combination of motor angles (A: rotation, B: height, C: gripper). Store them as constants.

> [!TIP]
> Manually position the arm and write down the encoder angles for each target location. Use these in your software.

### 7. Pick and Place Sequence
Program the sequence: move to "pick" → close gripper → move to "place" → open gripper → return to home.

### 8. Speed and Precision
Tune the motor speeds. Slow movements are more precise — set speed to 20–40% for accurate placement.

> [!TIP]
> Add short pauses (Wait 0.2s) between movements — motors need time to stabilize before the next action.

## Troubleshooting & FAQ

#### The arm moves inaccurately — positions vary each time.
> **Solution:** Use encoder-based positioning (Move to Position), not time-based. Encoders are precise; time depends on battery and friction.

#### The motor overheats and stops working.
> **Solution:** Add counterweights or springs to offload the motor. Reduce movement speed and add pauses.

#### The gripper fails to hold objects — they fall out.
> **Solution:** Add rubber bands to the gripper jaws for better friction. Increase the clamping force (higher power for Motor C).

---
[ Back to Overview](../../README.md)