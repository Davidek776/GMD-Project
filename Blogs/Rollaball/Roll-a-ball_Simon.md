# Rollaball

## Simon's blog

### Introduction
A simple game in Unity to learn basics about this engine.

# Playable version WebGL
Try out the playable version of this game here (with slight modifications such as jumping): [Roll-a-ball](https://simonfrayer.github.io/Rollaball/)

### Setting up the game
Set up was interesting as it was my first ecounter with the editor. I tryed to set up the game so that I have a 'playing field' with walls all around to serve as a natural barrier of the field. As a player I created a ball to which I applyed a Rigidbody element to react to gravity. I also added a 'collectables' to act as game objects that the player will try to collect to win the game. I created a unique materials for different objects in the game as well.

##### Game setup

![Final view](../Screenshots/final-view.png?raw=true)

##### Materials

![Materials](../Screenshots/materials.png?raw=true)

### Camera
To make the game 3rd person I set up the camera si that it would see the player in 45°. I also created a script for the camera to follow the player as it moves

##### Camera setup

![Camera view](../Screenshots/camera-view.png?raw=true)

##### Camera controller

![Camera controller](../Screenshots/camera-controller.png?raw=true)

### Game mechanics
To make the ball move I used the InputSystem packege in Unity to take the inputs from a keyboard and transfer the movement onto the ball, I also multiplyed the value of the movement by a certain positive number to make the ball go faster. For the collectables I made them spin on the place to make the game more visual. I edited the PlayerScript file so that when the ball (player) would collide with the collectable it would dissapear and increas the overall count of collected items.

##### Rotator controller to spin the collectables

![Rotator controller](../Screenshots/rotator-controller.png?raw=true)

##### OnTriggerEnter funtion in a Player controller to make the collectables dissapear on collision

![OnTriggerEnter function](../Screenshots/on-trigger-enter.png?raw=true)

### Some text to finish it up
To keep the player informed I added a text to the game that would display how many collectables the player already collected and if he would collect all of them a text saying 'You WIN!' would be displayed.

![Text](../Screenshots/text.png?raw=true)
