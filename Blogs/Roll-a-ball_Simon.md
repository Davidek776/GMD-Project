# Rollaball

## Simon's blog

### Introduction
A simple game in Unity to learn basics about this engine.

### Setting up the game
Set up was interesting as it was my first ecounter with the editor. I tryed to set up the game so that I have a 'playing field' with walls all around to serve as a natural barrier of the playing field. As a player I created a ball to which I applyed a Rigidbody element to react to gravity. I also added a 'collectables' to act as game objects that the player will try to collect to win the game

### Game mechanics
To make the ball move I used the InputSystem packege in Unity to take the inputs from a keyboard and transfer the movement onto the ball, I also multiplyed the value of the movement by a certain positive number to make the ball go faster. For the collectables I made them spin on the place to make the game more visual. I edited the PlayerScript file so that when the ball (player) would collide with the collectable it would dissapear and increas the overall count of collected items.

### Some text to finish it up
To keep the player informed I added a text to the game that would display how many collectables the player already collected and if he would collect all of them a text saying 'You WIN!' would be displayed.