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
### Activity 2: Table#5
I add my Rigidbodies to the ball and the cat, and only check the goal as in trigger. I gave the Cat a Rigidbody so it could interact with the ball physically but still be controlled smoothly by the player. The SoccerBall with a Rigidbody could respond to gravity, collisions, and bouncing naturally. The Goal’s BoxCollider was set as a trigger because I wanted the ball to pass through it while still detecting when a goal was made.
My cat rotated in the sky when it hit the ball at first. Then I freeze the rotation of the x-axis and z-axis, so it could move along the right direction. Moreover, the ball didn’t react when entering the goal. I realized it was because the Goal’s collider didn’t have Is Trigger enabled and the tag “Goal” wasn’t assigned. After fixing those two things, the game works perfectly. 

### W5
### Activity 1：
My question is about the page 13 on the Week 5 pre-learning slide. My question is that what does if (ball != null) mean in this code? And now I know that GetComponent<BallW3>() returns a reference to the BallW3 component if it exists on the collided GameObject. If that object actually has the script, it gives us a reference to it. But if it doesn’t, Unity gives us null, which basically means “nothing there.” So if (ball != null) is just checking, “hey, did we actually find a BallW3 script or not?”
### Activity 2: 
The member variables I need for the DeerW5: I plan to use the transform to change the position and rotation of the deer to let it walk, and directly to walk to the position of the object.
The methods the DeerW5 class need: I think we need the methods of starts() to start the game, and use updates() to change the direction and way. 
what should the methods do: I plan to use Call GetComponent<NavMeshAgent>() to get the NavMeshAgent on the same Deer GameObject and store it in _agent. And also use agent to set the destination to the target’s position by calling _agent.SetDestination(_target.position);

### W6
### Acitivity 1:
General C# Coding
Variable, types, names, value W2
Int, float, boolean, string 
Variable scope W3
Methods W3
Class W3, W4
    i. data (variables)  & actions (methods)
If statement W2
Else if statement
Conditions
&&, ||
==, >=, <=, >, <
For loop W6pre
Private and public
Calculation W2
+, -, *, /
+=, -=, *=, /=
How to write notes // or /* */
; must appear at the end of a line W2
Array W6pre

Link of google doc:https://docs.google.com/document/d/1exNqQE_zGuOoztND9FT3ldDwkXjJ6m8a8oRDWERaMyg/edit?usp=sharing
### Activity 2:
My plan for this activity What member variables does this class need?
I need variables of public float speed to lets us control how fast the bat moves (editable in the Inspector), I need public Transform target to stores a reference to the Cat object so the bat knows what to chase, and I need private bool _isChasing to keeps track of whether the bat is currently chasing the Cat or not.
What methods does this class need?
I need the methods of Start(), Update(), and need the public void StartChasing() to set _isChasing to true, allowing the bat to start moving toward the Cat.
What should the method(s) do?
The methods of Start() can call StartChasing() so the bat immediately begins chasing when the game starts. And the Update() needs check if _isChasing is true; if yes, move the bat toward the Cat using Vector2.MoveTowards() at the given speed. While the StartChasing() can turn chasing on, and the StopChasing(): turn chasing off.
