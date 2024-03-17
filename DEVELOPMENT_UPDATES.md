# Game Development Blog posts - Lost Together

## Dev Update 1
First milestone for this project is on 17th March. Goal of this milestone was to create Character controllers, Obstacles, Menu and Split Screen.

### Menu
Menu UI was created at the start of application. It has 3 options (Play, Options, Quit). Also if the user presses ESC-key, then the pause menu will 
pop-out with 3 options(Resume, Menu, Quit).
For creating Menu UI was used Canvas and Buttons game objects. Buttons have also zoom-in animation, when they are selected.

<img width="400" alt="Screenshot 2024-03-17 at 16 44 28" src="https://github.com/Davidek776/GMD-Project/assets/62095094/2a9b0a21-9c00-43cd-85d4-cb1506ec79f8">
<img width="400" alt="Screenshot 2024-03-17 at 16 44 55" src="https://github.com/Davidek776/GMD-Project/assets/62095094/9e8aa114-c86a-4091-8e8b-bc033e1a568b">

### Character controllers
For controlling characters(currenlty just simple Cubes) was used new Input System from Unity. The reason for using new Input system was that we do not have to manually map gamepad(Arcade machine controller) in the code, but we can do it easily by using the UI. So, it is more convenient.

There are two characters and each of them has Input Actions which are Move and Jump. First character can be moved by either using left stick on gamepad or WASD keys on keyboard and can jump by pressing a space on keyboard or button south on gamepad. Second charactes can be moved by using right stick on gamepad or arrows on keyboard and can jump with pressing J on keyboard or button south on gamepad. Inputs for gamepad could be changed in the future, because we will see how it works on Arcade machine which is using gamepad underneath the hood.

### Split screen
In the game is used Vertical split screen. This effect was accomplished by using two cameras, where each character has one camera. Each camera is following one player. What can be updated in the future is to have cameras that are smoothly following characters, because right now they are moving immidiately, when characters are moving.

<img width="800" alt="Screenshot 2024-03-17 at 17 29 51" src="https://github.com/Davidek776/GMD-Project/assets/62095094/e40df375-d22e-40ef-9ae5-26cbde831466">




