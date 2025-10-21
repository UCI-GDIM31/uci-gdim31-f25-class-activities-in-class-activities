# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.

### W2
### Answer1 Because ints can only show the integers which aren't fluet, bool also represents true or false, the string can only show the words or not numbers. So r,g,b variable can only be shown as floats clearly with changes.
### Answer2 Because the number of Bounce could be the integers like 1, 21, 35... And it couldn't be the floats with decimal points, not the bool with true or false, or not the string with words 
## Open-Source Assets

### W3
### Answer1 I belong to Table 5, and I will be answering question 1.
The input will include float x and float y. Float x refers to the moment when player's finger touches the screen. Float y refers to the moment when player's finger leaves the screen. In the body part of the method, we will substract y from x to obtain float z. If z is greater than 0.2s, then bool whetherHit equals true. The boolean type whetherHit variable will be the output. Input: float x (touch time); float y (leave time)； Output type: boolean
### Answer2 Metaphor
Class is a family recipe for how to make and present a dish that has been passed down through different generations. Components are the printed version of the recipe in a cookbook. Method is the cooking steps for this dish. Member variables are the ingredients of this dish.
### Answer3 
Regarding why balls get very bright after bouncing many times: each time a ball collides, its speed is multiplied by a speed factor, and if the speed exceeds a certain threshold, its color brightness is increased. Because balls in the scene collide frequently, the speed and brightness accumulate over time, causing balls that bounce many times to become extremely bright.

- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

### W4
### Actvity 1: Table#5 
Line 5: _moveSpeed is a member variable, and the type is float. It is marked with [SerializeField] so it can be edited in Unity’s Inspector even though it is private. This variable controls how fast the cat moves. 
Line 22: transform is a Component of the cat GameObject. The method parameters are (0, 0, translation), which means it moves the cat forward or backward on the z-axis, but does not move it on the x-axis or y-axis.
Line 25: _rigidBody is a Component of type Rigidbody. This line is setting the linearVelocity property. The type of linearVelocity is Vector3, which stores speed in the x, y, and z directions. The new value keeps the x and z speeds the same but sets the y speed to 0, so the cat’s jump starts from zero vertical speed.
### Activity 2:
I add my Rigidbodies to the ball and the cat, and only check the goal as in trigger. I gave the Cat a Rigidbody so it could interact with the ball physically but still be controlled smoothly by the player. The SoccerBall with a Rigidbody could respond to gravity, collisions, and bouncing naturally. The Goal’s BoxCollider was set as a trigger because I wanted the ball to pass through it while still detecting when a goal was made.
My cat rotated in the sky when it hit the ball at first. Then I freeze the rotation of the x-axis and z-axis, so it could move along the right direction. Moreover, the ball didn’t react when entering the goal. I realized it was because the Goal’s collider didn’t have Is Trigger enabled and the tag “Goal” wasn’t assigned. After fixing those two things, the game works perfectly. 
