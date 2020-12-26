# unity-example-new-input-system

Example for showcasing performence issues in the new input system in Unity 2020.2 containing a simple character controller.

The main branch is using the old input manager, and the branch new is using the new input system.

## Unity version:

2020.2.1.f1

## Platform:

PC, Mac & Linux standalone

## Other dependencies:

This project is also using the Universal Rendering Pipeline, XR plugin (have only tested this on a VR headset)

## Performence testing scores

Tested using the old input manager (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Branch:** [main](https://github.com/Sandstedt/unity-example-new-input-system/tree/main)

**Avarage FPS:** 90-100 FPS\
**CPU main:** 10-15ms\
**Batches:** 8

Tested using the new input system package (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Branch:** [new](https://github.com/Sandstedt/unity-example-new-input-system/tree/new)

**Avarage FPS:** 87-95 FPS\
**CPU main:** 10-11ms\
**Batches:** 8

Tested using the new input system package using a PlayerInput component with Auto-Switch (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Branch:** [new-player-input](https://github.com/Sandstedt/unity-example-new-input-system/tree/new-player-input)

**Avarage FPS:** 87-96 FPS\
**CPU main:** 10-11.4ms\
**Batches:** 8

![screenshot](screenshot.gif)
