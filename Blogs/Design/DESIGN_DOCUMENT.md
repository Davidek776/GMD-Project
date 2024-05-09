<!-- This document serves as a design document of a game project in unity -->
<!-- Simon 1 -->
<!-- David 2 -->

# Game Design Document - Lost Together

Current version: 2.0

## High-Level Concept/Design

<!-- Simon 1 -->
### Game Overview
The game is a 2D local multiplayer game for 2 players. There are multiple levels filled with different kind of obstacles and enemies. The player have to colaborate to get through each of the levels. The objective of the game is to complete all the levels, bond with your co-player, and have fun.

To add depth to the 2D game, the background has a parallax effect to spice things up! 🌶️

<!-- David 2 -->
### Target Audience
The game is suitable for everyone who is ready for a unique adventure and is ready to cooperate with another player as well. Therefore the game is suitable for two players who are older than 3 years(EC ESRB rating). 

<!-- Simon 1 -->
### Unique Selling Points
- Local multiplayer
- Parallax background
- Easy controlls
- Beautiful Graphics

## Product Design

<!-- David 2 -->
### Platform
The game is developed for VIA Arcade Machine.

<!-- Simon 1 -->
### Genre
2D cooperative platformer 🕹️
<!-- David 2 -->
### Art Style
The game is designed to give players a feeling of having more freedom than other 2D cooperative games usually provide and to use a game environment that is rarely seen. Since the game is 2D, we wanted to make it more visually interesting by adding a parallax effect to the background, so that different layers of the background move at differrent speeds when the player moves and together add more depth to the game.

<!-- Simon 1 -->
### Sound Design
The overall approach to sound design is to have a thematic background music and unique sound effects. There are general sound settings to manage the volume of each sound.

## Detailed & Game System Design

<!-- David 2 -->
### Game Mechanics
Players have to avoid obstacles, enemies, and collaborate together to help each other progress through the level.

#### Characters
The movement for both characters is the same but they have different skills. One of them is strong and can move heavy objects and the other one has a bigger jumping power, this enables the character to get over obstacles that are much higher than others.

#### Obstacles
There are multiple types of obstacles. Heavy obstacle, high obstacle, mechanical obstacle, which can only be moved by trigger, and there are 2 types of triggers - one for each character

<!-- Simon 1 -->
### Level Design
There are 3 differrent levels. The first level is an introduction level, where players get to know the mechanics of the game. Second level is more complicated as it consist from multiple horizontal layers which makes it much more difficult for the player to navigate through. The final third level is similar to the second level with one small adjustment - light. There is almost no visibility as the level is hidden in darkness, the only soure of light in the game is a light around each of the character. 

There are checkpoint in each of the levels so that when one player dies at the end of the level the other doesn't have to sacrifice himself as well to help the other player to get through the whole map again, as it is not possible for one player to get through the whole level by himself.

The average time for completing a level should be somewhere between 5-10 minutes. ⏱️ 

<!-- Simon 1 -->
### User Interface (UI)
The only user interface in the game are menus to navigate through the game and control sevelar settings, or informational UIs such as controls hint. Those are the menus in the game:

- Main menu
- Pause menu
- Game over menu
- Level selection menu
- Options (Sound settings)

<!-- David 2 -->
### Controls
The game can be played by any gamepad, the left stick is used for horizontal movement and the south button of the gamepad is a jump. The pause menu can be opened and closed by pressing the 'start' button on a gamepad and buttons in the menu are selected by clicking the west button.

<!-- Simon 1 -->
### Technical Specifications
- Must be playable on the VIA Arcade Machine
- NVIDIA GeForce GTX 980 Ti, i5-6600K CPU, 3.50 GHz, 8GB RAM
- Custom input with two 8-directional sticks and six buttons for each player + two start buttons.
- The deployed build must not take up more than 500MB of disk space.


# 3 Milestones:
1. 17.03.2024 - Character controllers, Obstacles, Menu, Split Screen
2. 14.04.2024 - Environment, Triggers, Collaboration logic between characters, Animations, Character sprites
3. 07.05.2024 - Level design (finalize first level), Sound effects, Background music, Dust effect when running/landing a jump, GameLoop (Game over UI), Map controlls with VIA Arcade Machine, Possibly:      Enemies,
