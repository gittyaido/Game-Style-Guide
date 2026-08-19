# File-Structure-Guide

We will be using a **context** based approach to file management.

_i.e. files will be primarily organized by the content in them, not the file type_

## Principles
- Keep things as organized as possible. If you cant find a folder that fits the thing you're working on, place it in your DevSanbox folder until you find it a better home

- All folders should be hierarchical and self contained. If we decide that we want to remove an enemy from the game, it should be as simple as deleting that enemies folder. We should not have to hunt for files

- When adding a feature, try your best to keep it decoupled from the rest of the codebase. Avoid adding features to existing game scenes. Use self contained prefabs and scriptable objects as much as possible.

- Game scenes should be a composite of decoupled prefabs. You should be able to remove any prefab from a scene and have nothing break

- When testing a new feature, you may freely add and modify any scenes in your **DevSandbox Folder**

- **Core** is used for high level systems, agnostic to any content of the game. Files in here should be able to be copied into other projects without dependency issues.

- Level scenes will be stored in World/Levels. Menu scenes in UI/Menus. We will not have a dedicated Scenes folder.


## Example

- `Assets/`
    - `Core/`
      - Events/
      - StateMachine/
      - ...
        
    - `Player/`
      - Art/
      - Movement/
      - Data/
      - ...

    - `Enemies/`
      - ...

    - `World/`
      - Objects/
      - Levels/
      - Art/
      - Tiles/
      - ...

    - `UI/`
      - Art/
      - Prefabs/
      - Menus/
      - ...
  
    - `Audio/`
      - Music/
      - SFX/

    - `DevSandbox/`
      - Appa/
      - Momo/
      - ...
     

## Important Note

This is all subject to change. Ideally if we stick to what's here, refactors should be fairly painless.
