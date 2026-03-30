# Scratch – Introduction to Robot Programming (Scratch — Úvod)

Basics of programming in the Scratch environment for controlling a virtual robot. The ideal first step before working with physical hardware.

## Step-by-Step Guide

### 1. Environment Setup
Open Scratch at scratch.mit.edu or install Scratch Desktop. Create a new project.

> [!TIP]
> Scratch runs in the browser without installation. Scratch Desktop is available for offline use.

### 2. Interface Overview
Explore the interface: code blocks (categories) on the left, workspace in the middle, and the stage with Sprites on the right.

### 3. First Script
Create your first program: drag "When green flag clicked" → "Move 10 steps" → "Wait 1 second" → "Turn 90 degrees".

> [!TIP]
> Blocks snap together like puzzles — only compatible shapes can connect. Scratch guides you on where they fit.

### 4. Loops and Patterns
Add a loop: wrap movement blocks in a "Repeat 4" block — the sprite will trace a square.

```javascript
// Square pattern pseudocode:
// Repeat 4:
//   Move 100 steps
//   Turn 90 degrees
```

### 5. Conditionals
Add a condition: "If on edge, bounce". This causes the sprite to reverse direction when it hits the stage boundary.

### 6. Connecting Hardware
Link Scratch to LEGO WeDo 2.0 or LEGO BOOST: Add the extension (puzzle icon at bottom left). Connect hardware via Bluetooth.

> [!TIP]
> The Scratch Link app must be installed for Bluetooth connection to LEGO hardware.

### 7. Motor Control
Control a physical motor through Scratch: "Set motor power to 75%" → "Start motor for 2 seconds" → "Stop motor".

## Troubleshooting & FAQ

#### Scratch won't connect to LEGO hardware via Bluetooth.
> **Solution:** Install Scratch Link. Ensure Bluetooth is enabled. LEGO WeDo 2.0 must be in pairing mode (flashing blue).

#### The script runs, but nothing happens on the stage.
> **Solution:** Ensure the correct Sprite is selected. Blocks must be attached to a "When green flag clicked" block to execute.

---
[ Back to Overview](../../README.md)