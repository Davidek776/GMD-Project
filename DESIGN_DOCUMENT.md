<!-- This document serves as a design document of a game project in unity -->
<!-- Simon 1 -->
<!-- David 2 -->

# Game Design Document - Lost Together

Current version: 1.0

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

## Product Design

<!-- David 2 -->
### Platform
The game is developed for VIA Arcade Machine.

<!-- Simon 1 -->
### Genre
2D cooperative platformer 🕹️
<!-- David 2 -->
### Art Style
The game is designed to give players a feeling of having more freedom than other 2D cooperative games usually provide and to use a game environment that is rarely seen. To achieve this visual sensation is used parallax animation which is triggered when game characters are moving. Parallax animations will be achieved by moving each layer of the 2D background asset at a different speed. Each level will consist of nicely designed 2D assets, that will be also huge enough to give the players a sensation of freedom.

<!-- Simon 1 -->
### Sound Design
The overall approach to sound design is to have a thematic background music and unique sound effects. The aim is to also have an AI generated voiceovers.

## Detailed & Game System Design

<!-- David 2 -->
### Game Mechanics
Game characters have to avoid obstacles and enemies and progress at the game level. Characters have to as well collaborate together to help each other pass through the level.
## Characters
The movement for both characters is the same but they have different skills. One of them is strong and can move stuf around and the other one can jump twice as high, this enables the character to get over obstacles that are much higher than others.
## Obstacles
There are multiple types of obstacles. Heavy obstacles, high obstacles, mechanical obstacles whichcan only be moved by trigger, there are 2 types of triggers - one for each character

<!-- Simon 1 -->
### Level Design
There are 5 differrent levels in differrent environments. Each of them has a different style of obstacles and enemies to keep the player entertained and guessing. 

The average time for completing a level should besomewhere between 5-8 minutes. ⏱️ 

<!-- David 2 -->
### Characters
The main characters are called Ethan and Amelia. 

Ethan is a young adventurous character known for his strength and energy. He is full of energy and therefore his abilities are that he can move heavy stuff. Also thanks to his energy, he can be a source of light and illuminate dark areas in the game.

Amelia is a bit calmer character that has a deep connection with nature. Thanks to her connection with nature she can manipulate water or use wind force to slow down enemies.

They come from a land called Eldonia. Because of the ancient prophecy which tells that once in a thousand years when planets Eldonia, Venius and Plutomius are aligned behind each other somewhere on the planet Eldonia will be generated Astral Relic. As the prophecy foretold, those who touch it will be teleported to planet Venius. With a mission to find the next 11 missing Astral Relics. After all 12 Astral Relics are collected, they will generate an ancient energy that will .......... and that will teleport the characters back to Eldonia.  

Ethan and Amelia were those who randomly found the first Astral Relic and they were sent to a Venius. On a mission to find each 11 missing Astral Relics they have to collaborate to avoid obstacles and enemies.


<!-- Simon 1 -->
### User Interface (UI)
Describe the user interface elements, including menus, HUD, and other on-screen displays.

There should be following UI elements in the game:

- General menu
- Level selection menu
- General settings

<!-- David 2 -->
### Controls
The game is developed for an arcade machine, which consists of two joysticks, where each has 8 directions. There are also 6 buttons for each player. 
<!-- Simon 1 -->
### Technical Specifications
- Must be playable on the VIA Arcade Machine
- NVIDIA GeForce GTX 980 Ti, i5-6600K CPU, 3.50 GHz, 8GB RAM
- Custom input with two 8-directional sticks and six buttons for each player + two start buttons.
- The deployed build must not take up more than 500MB of disk space.


# 3 Milestones:
1. 30.04.2024 - MVP, or minimum viable product, that includes working game mechanics, parallax background, and split camera with 2 players (1 for each camera).
2. 31.05.2024 - Final Game, a producttaht includes all the effects, sounds, game mechanics, graphics, playable and ready to be deployed.
3. 06.06.2024 - Hand-In, hand-in of the final version of the game, together with all the documents and videos needed.
