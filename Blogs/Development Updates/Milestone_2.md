# Game Development Blog post #2 - Lost Together

## Dev Update 2
The second milestone for this project is on 14th April. The goal of this milestone was to create an Environment, Triggers, Collaboration logic between characters, Animations and Character Sprites.

### Environment
For the game environment was used asset from Unity Asset Store which is accessible here: https://assetstore.unity.com/packages/2d/environments/2d-hand-painted-platformer-environment-227159. This asset was chosen, because its aesthetics and possibilities match our expectations that were described in Design Document. The asset consists of multiple layers and has a parallax effect. Thanks to the perspective camera it gives the player a sense of depth because it shows each layer on different positions on Z-axis. Moreover, the asset has leaves particle system that adds a more dynamic pattern to the game.

<img width="620" alt="Main menu" src="../Screenshots/Game_Environment.png"> 

### Triggers
Triggers are buttons positioned on the ground and can be pressed by the player to activate or deactivate a game object. Therefore each trigger has a serialized field, where you choose which player can press the trigger and it has also a field where you choose which game object is interacting with the trigger. The implementation of triggers and scripts that are used for the behavior of game objects that are interacting with triggers uses the Dependency Inversion Principle. There is an abstract class ISwitchable that has Activate and Deactivate methods. Currently, we have two classes that are implementing ISwitchable. Those are VerticalMovement and HorizontalMovement. Each of them has different functionality. Thanks to this implementation when the trigger is added to the scene it can be associated with any client(game object) that contains a script that is implementing ISwitchable. In the picture below can be seen trigger that is reacting to only one of the players and is activating the bridge that is using the horizontalMovement class which is implementing the ISwitchable abstract class.


<img width="620" alt="Main menu" src="../Screenshots/Trigger_bridge.png"> 

### Collaboration logic
One of the main challanges in the game, that players have to overcome is to go through the world, where are some obstacles. From time to time there are obstacles, which one player can not overcome alone and therefore neeeds help of other player. This sort of the collaboration between players makes this game fun, challenging and brings to player together. Purpose of obstacles, which require colaboration is also to make gamers think about how to overcome certain obstacle. In the picture below can be seen example of collaboration.

<img width="620" alt="Main menu" src="../Screenshots/Colaboration_Elevator.png"> 


