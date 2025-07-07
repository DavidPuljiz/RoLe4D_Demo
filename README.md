# RoLe4D_DH - Virtual Reality Robotics Learning Environment

A Unity-based VR application for robotics education, featuring interactive robot control, teachpad interface, and immersive learning experiences.

## Overview

RoLe4D_DH is a Virtual Reality educational platform demonstrator designed to teach robotics concepts in an immersive environment. The project combines Unity 3D with VR technologies to create interactive learning experiences with robotic arms and teachpads.

## Features

### 🤖 Robot Simulation
- **Multi-robot support**: UR10, KUKA industrial robots
- **Real-time articulation control**: Joint-by-joint manipulation

### 🎮 VR Interface
- **Immersive VR environment** with Oculus/OpenXR support
- **Hand tracking and controller interaction**
- **Spatial UI elements** and 3D manipulation
- **Room-scale navigation** with teleportation

### 📱 Teachpad System
- **Interactive teachpad interface** for robot programming
- **Visual programming elements** with buttons and controls
- **Real-time feedback** and status indicators
- **E-Stop emergency controls** for safety

### 🏛️ Educational Environment
- **Multiple learning rooms**: Cinema, DH Room, Hallway
- **Interactive whiteboards** and information displays
- **Coordinate system visualization**
- **HSK branding integration**

## Technical Specifications

- **Unity Version**: 2022.3.5f1
- **Target Framework**: .NET 4.7.1
- **Language**: C# 9.0
- **VR Support**: OpenXR, Oculus
- **Physics**: Unity Physics with Articulation Bodies

## Key Scripts

### Robot Control
- `RobotController.cs` - Main robot control logic
- `ArticulationJointController.cs` - Joint movement control
- `PincherController.cs` - Gripper operations
- `RobotManualInput.cs` - Manual control interface

### VR Interaction
- `TeachpadController.cs` - Teachpad interface management
- `XRPlatformControllerSetup.cs` - VR controller configuration
- `player_navigator.cs` - VR locomotion system

### UI Systems
- `angle_button.cs` / `AngleButtonClick.cs` - Interactive buttons
- `submit.cs` - Form submission handling
- `StartStop.cs` - Control system management

## Setup Instructions

### Prerequisites
- Unity 2022.3.5f1 or later
- VR headset (Oculus Rift/Quest, OpenXR compatible device)
- Windows 10/11 (recommended)

### Installation
1. Clone the repository:
   ```bash
   git clone [repository-url]
   cd RoLe4D_DH_Improved_Teachpad
   ```

2. Open in Unity:
   - Launch Unity Hub
   - Click "Open" and select the project folder
   - Unity will automatically import packages and dependencies

3. Configure VR:
   - Ensure your VR headset is connected and configured
   - Check XR Management settings in Project Settings
   - Verify OpenXR providers are enabled

### Build and Run
1. Open the main scene from `Assets/Scenes/`
2. Configure build settings for your target platform
3. Build and deploy to your VR device

## Usage

### Basic Controls
- **VR Controllers**: Point and click to interact with objects
- **Teleportation**: Use controller to move around the environment
- **Teachpad**: Use the virtual teachpad to program robot movements
- **Robot Control**: Manual joint control via UI elements

### Learning Modules
1. **Robot Basics**: Learn fundamental robot operations
2. **Programming**: Use the teachpad to create movement sequences
3. **Safety**: Practice emergency stop procedures

## Version History

### V 0.3 - TEACHPAD
- **New Features**:
  - E-Stop toggle functionality
  - Inverse kinematics exploration
- **Improvements**:
  - Enhanced robot safety systems
  - Teachpad interface refinements

### V 0.2
- **Graphics**:
  - Removed backgrounds, added alpha channels
  - Unified button sizing
  - HSK logo integration
- **Scene Improvements**:
  - Low poly skybox
  - Enhanced lighting system
  - Controller ray fixes
  - Snap rotation support
- **Room Updates**:
  - Cinema room with video controls
  - DH room robot scaling
  - Interactive whiteboards
  - Coordinate system visualization

## Contributing

When contributing to this project, please:
1. Follow Unity coding conventions
2. Test VR functionality thoroughly
3. Update documentation for new features
4. Ensure compatibility with target Unity version

## Technical Dependencies

### Unity Packages
- XR Interaction Toolkit
- OpenXR Plugin
- URDF Importer for robotics
- TextMeshPro for UI
- Visual Scripting
- AI Navigation

### External Assets
- Farland Skies (skybox system)
- Low Poly vegetation
- Industrial robot models (KUKA, UR10)

## Performance Considerations

- **VR Optimization**: Maintains 90fps for smooth VR experience
- **LOD Systems**: Reduces polygon count for distant objects
- **Occlusion Culling**: Improves rendering performance
- **Physics Optimization**: Efficient articulation body usage

## Troubleshooting

### Common Issues
- **VR not detected**: Check OpenXR runtime installation
- **Robot movement issues**: Verify articulation joint configurations
- **Performance problems**: Adjust quality settings in Player Settings
- **Build errors**: Ensure all required packages are installed

### Support
For technical issues or questions about the educational content, please refer to the project documentation or contact the development team.

## License

This project is developed for educational purposes. Please refer to individual asset licenses for usage rights and restrictions.

---

**RoLe4D_DH** - Advancing robotics education through immersive virtual reality experiences.
