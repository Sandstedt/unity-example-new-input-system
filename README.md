# unity-example-new-input-system

**This branch contains a basic version with the old input manager**

Example for showcasing the new input system in Unity 2020.2 containing a simple character controller.

The main branch is using the old input manager, and the branch new, new-player-input & with-xr are using the new input system.

## Unity version:

2020.2.1.f1

## Platform:

PC, Mac & Linux standalone

## Other dependencies:

This project is also using the Universal Rendering Pipeline, XR plugin (have only tested this on a VR headset)

## Performence testing scores

### Old Input Manager
Tested using the old input manager (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Branch:** [main](https://github.com/Sandstedt/unity-example-new-input-system/tree/main)

**Platform:** PC, Mac & Linux Standalone running in editor\
**Avarage FPS:** 90-100 FPS\
**CPU main:** 10-15ms\
**Batches:** 8

### New Input System
Tested using the new input system package (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Branch:** [new](https://github.com/Sandstedt/unity-example-new-input-system/tree/new)

**Platform:** PC, Mac & Linux Standalone running in editor\
**Avarage FPS:** 87-95 FPS\
**CPU main:** 10-11ms\
**Batches:** 8

### New Input System + PlayerInput
Tested using the new input system package using a PlayerInput component with Auto-Switch (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Branch:** [new-player-input](https://github.com/Sandstedt/unity-example-new-input-system/tree/new-player-input)

**Platform:** PC, Mac & Linux Standalone\
**Avarage FPS:** 87-96 FPS\
**CPU main:** 10-11.4ms\
**Batches:** 8

Day 2: ( cold start )

**Platform:** PC, Mac & Linux Standalone running in editor\
**Avarage FPS:** 100-120 FPS\
**CPU main:** 8-10ms\
**Batches:** 5

### New Input System + PlayerInput + XR support / OVR Plugin

Tested using the new input system package using a PlayerInput component with Auto-Switch with XR Package, OVRplugin, optimized build using OVR Performence Lint Tool and running on the Oculus Quest 2

**Branch:** [with-xr](https://github.com/Sandstedt/unity-example-new-input-system/tree/with-xr)

**Platform:** PC, Mac & Linux Standalone running in editor & Android - API level 23 running on Quest 2\
**Avarage FPS:** 100-120 FPS in Editor & 90 FPS (current top cap) on Quest 2\
**CPU main:** 8-10ms\
**Batches:** 5

![screenshot](screenshot.gif)
