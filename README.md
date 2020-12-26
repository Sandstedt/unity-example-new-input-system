# unity-example-new-input-system

Example for showcasing performence issues in the new input system in Unity 2020.2 containing a simple character controller.

The main branch is using the old input manager, and the branch new is using the new input system.

## Unity version:

2020.2.1.f1

## Platform:

PC, Mac & Linux standalone

## Other dependencies:

This project is also using the Universal Rendering Pipeline.

## Performence testing scrores

Tested using the old input manager (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Avarage FPS:** 90-100 FPS
**CPU main:** 10-15ms
**Batches:** 8

Tested using the new input system package (on a Asus Rog G14 in Performence mode, directly in the Unity Editor)

**Avarage FPS:** 87-95 FPS
**CPU main:** 10-11ms
**Batches:** 8

![screenshot](screenshot.gif)
