# Unity Airplane Game

A simple Unity game featuring a 3D airplane controlled by keyboard arrows.

## Controls

- **Up Arrow**: Pitch down (nose down)
- **Down Arrow**: Pitch up (nose up)
- **Left Arrow**: Turn left (yaw left)
- **Right Arrow**: Turn right (yaw right)
- **Q Key**: Roll left
- **E Key**: Roll right

The airplane moves forward automatically at a constant speed.

## Features

- 3D airplane model built using Unity primitives (cubes)
- Smooth keyboard-based flight controls
- Rigidbody physics with gravity disabled for arcade-style flight

## Scene Setup

The game includes:
- **Airplane**: Main player-controlled object with AirplaneController script
  - Body: Main fuselage (elongated cube)
  - Left Wing: Port wing
  - Right Wing: Starboard wing
- **Main Camera**: Positioned behind and above the airplane
- **Directional Light**: Scene lighting

## Getting Started

1. Open the project in Unity 6000.0.36f1 or compatible version
2. Load the `SampleScene` from Assets/Scenes/
3. Press Play to start the game
4. Use arrow keys to control the airplane

## Technical Details

- **Movement Speed**: 10 units/second
- **Rotation Speed**: 100 degrees/second (yaw)
- **Pitch Speed**: 50 degrees/second
- **Roll Speed**: 50 degrees/second
- **Physics**: Kinematic Rigidbody (gravity disabled, direct transform control)
