# Blog Post #1: Roll-a-ball

## David's Blog

## Introduction
This blog describes the implementation of my first Unity game called Roll-a-ball based on the tutorial posted on the Unity website.

## Implementation steps

![Game overiew](./Screenshots/introduction_image.png?raw=true)

### Setting up the Game
In this step, I initialized the project and created a scene from a Basic URP template. After that, I added Ground and Player objects and I modified them for the purpose of this game.


### Moving the Player
To make the player move, I needed first of all to add the RigidBody component to the Player GameObject. After that, I added an input component to Player and wrote a C# script that will move the player based on the arrow keys.

#### OnMove Function
![Player on move function](./Screenshots/player-on-move-function.png?raw=true)


### Moving the Camera
The goal of this step was to make the Camera follow the Player with the fixed offset. To achieve that I had to set the Camera position and angle to the desired values. After that, I wrote a CameraController script that is updating the Camera position based on the Player position.

### Setting up the Play Area
In this step, I created Wall game objects and positioned them around the game area. The purpose of walls is to create a border around the game area, so the ball does not jump out.

![Setting up the play area](./Screenshots/setting-up-the-wall.png?raw=true)

### Creating Collectibles
I created PickUp game objects for the player to collect. To rotate PickUp objects, I wrote a Rotator script that is using transform values for rotation. To simplify the manipulation of PickUp game objects, I used Prefab to be able to make changes to all instances of PickUp objects on one place.

### Detecting Collisions with Collectibles
In this part of the tutorial, I made PickUp game objects disappear when they collide with the Player object. I added a new function OnTriggerenter in PlayerController, to deactivate Pick-up game objects after collision. To distinguish PickUp objects from other game objects, I added a unique tag. I also added a kinematic Rigidbody component to the PickUp game object so it does not react to physical forces and is animated by transform.

### Displaying Score and text
In this part, I added in PlayerController script to store the amount of collected PickUp game objects. I also added UI text elements to display the count value and the winning message if all collectibles were picked.

![Displaying count value](./Screenshots/displaying-count-value.png?raw=true)

### Building the Game
In the last step of the tutorial, I built the game for macOS.
 


