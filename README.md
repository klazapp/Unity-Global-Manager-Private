# Global Manager Utility for Unity

## Introduction
The `Global Manager` utility, part of the `com.Klazapp.Utility` namespace, is a design pattern or architectural concept used to manage and coordinate various aspects of a game or application from a central location. A global manager typically encapsulates functionality related to game state management, resource management, scene management, event handling, and more.

## Features
- A global manager can manage the overall state of the game, including aspects such as game initialization, loading, pausing, resuming, and quitting. It may maintain variables or properties representing the current game state (e.g., playing, paused, game over).
- Global managers can handle the loading, unloading, and caching of game assets and resources, such as textures, models, audio files, and prefabs. They may provide methods to efficiently load assets on-demand and manage memory usage.
  
## Dependencies
To use `Global Manager`, certain dependencies are required. Ensure these are included in your Unity project.
- **Unity Version**: Minimum Unity 2020.3 LTS.
- **Unity Mathematics DLL**

## Compatibility
| Compatibility        | URP | BRP | HDRP |
|----------------------|-----|-----|------|
| Compatible           | ✔️  | ✔️  | ✔️   |

## Installation
1. Open the Unity Package Manager (`Window` > `Package Manager`).
2. Click `+`, select `Add package from git URL...`, and enter `https://github.com/klazapp/Unity-Global-Manager-Public.git`.
3. Unity will download and make the package available in your project.

## Usage
```csharp
Write Something here
```

## To-Do List (Future Features)
- 

## License
This utility is released under the [MIT License](LICENSE).
