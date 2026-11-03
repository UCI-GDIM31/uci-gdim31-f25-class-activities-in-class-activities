# in-class-activities
## Devlogs
### W1
### Activity 1: Meet your classmates
1. My classmates are Judas, Caedyn, Gregory, and Breonna. My LA is Sahasra.
2. Our table's commonality is that we all have immigrant parents
### Activity 2: Unity Basics
1. Used Unity's Hierarchy, Project, and Game panels to move a cat to another spawnpoint, add a Player component, change the walking and turn speeds, and submit to itch.io.
2. Answer to question: When you take the camera out of the Cat hierarchy, the camera does not move with the character because they are not attached anymore.

[Link to itch.io page](https://asterdust.itch.io/cat-game-w1)

### W2
### Prompt Questions
1. The reason the RGB values of the ball are floats is because they are decimal numbers. Integers deal with whole numbers, and booleans deal with true/false statements. It's not a string either since it's not text, but a number value.
2. The _bounce variable IS an integer because it deals with whole numbers. You can't have 1.5 bounces. you have one, then two, and so on. It deals with numbers, same as the float, so it can't be a string or boolean.
3. The error that shows up is a missing semicolon. This tells me that the code isn't finished; it isn't closed. In order to close it, I add the semicolon. After that, there are no more errors and the code works as intended.
### Process
- Shift game from 3D to 2D mode to better use the assets. Changed color of ball to a more teal color.
- After some issues with Visual Studio, I followed the steps given in the code for the 'ball' Script Component.
- Through the steps, I added a working Bounce counter and added code to make the ball change color more and more as it bounces, shifting from teal to darker teal to changing colors and increasing RGB values as it bounces.

### W3
### Activity 1
Table 6

1. It maybe would define a string variable called GetResponse and it would have float or integer paramters for friendship levels, dependign on how the game is calculating it, and a boolean for the character's secret. Based on that, it would get the responses the character says next.
2. The return type for brightness would be void, and the parameters--the sanity value-- are floats.
3. It would have a boolean return type check whether the key was pressed on time or not with float paramaters that check the time the key was pressed. 
### Activity 2
Classes are blueprints for architecture, and the Component is the building materials that make it up. The member variables are the various traits it has like its shape and style. The methods are the tools used to create the building.
### Activity 3
1. The balls get extremely bright, once all the steps have been completed, because of the ColorMultiplier. The ballRenderer is being multiplied by the GetColorMultiplier and then applied, which means the color values get higher as the ball keeps bouncing. This happens with the code in Step 8, which makes the change happen if it happens at a certain speed. If it crosses this speed threshold, it multiplies by 1.5.

### W4
Table 6

1. We added the Capsule Collider to the Cat parent, and set the Direction to the Z-axis. This made it so the collider could be modified to make a horizontal capsule, and not a sphere or a vertical capsule. This way, the cat's collisions also do not touch the floor and make it float. We changed the X and Z axes' rotation so the cat didn't flip around as it hit the ball.
2. We decided that, in order to make the cat hit the ball, the ball to be able to hit the goalpost but still pass through it to score a goal, and bounce off the wall, the Cat and SoccerBall needed a Rigidbody to be able to collide. The goalpost needed to have "Is Trigger" checked in order to score points once the Ball collided with it.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
