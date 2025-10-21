# in-class-activities
## Devlogs
### W1
Hello World

### W2

Question 1 Response: The r, g, and b variables are floats because color values
represented by decimal numbers between 0.0 and 1.0. Using floats allows for smooth and
gradual color transitions, which wouldn't be possible with integers, booleans or strings.

Question 2 Response: The _bounce variable is an integer because it keeps track of how
many times the ball has bounced, which is always a whole number. A float would be unncessary, a boolan
could only represent true or flase, and a string coulnd't be used for counting.

Question 3 Response: The error that appeared after Step X of Part 2 showed 
that there was a type of mismatch in the code. It revealed that the program
was trying to use float values where a Color type was expected, which
explained why the line didn't work. This helped show that the correct way to 
set a color is by using "Color (r, g, b)" instead of adding the numbers together.


### W3
Start writing my Devlog Here.

Discussion:
For this week’s discussion, our group explored ideas for designing a 
GetResponse method that determines a character’s dialogue reply in a 
visual novel. The goal was to make the system respond dynamically to 
the player’s choices and their relationship with the character.

partner 1 idea: output is the string for dialogue, which comes its repsonses beased 
on the input, the input are the dialogue options you choose

partner 2 idea: we can integrate integer values from -4 to 4, which determines
your relationship with characters level; less and negative values being integers to represent
your low honor of friendship, and positive values being integers to represent your high honor 
of friendship

My idea: 
I suggested incorporating boolean values to represent whether certain 
relationship conditions are true or false—such as whether the player knows 
the character’s secret, or whether they are currently on good or bad terms. 
This adds a layer of logic-based branching that can determine the type of
response beyond just numeric friendship levels. For example, even with a 
high friendship score, a hidden truth (boolean flag) could unlock a unique, 
more personal dialogue line.



MonoBehaviour coding activity:

Discussion:
This week, our group focused on understanding the relationship between classes 
and Components in Unity, using a metaphor to make the concept more intuitive.

Metaphor:
We compared a class to a blueprint for a robot, and a Component to an actual part 
installed on the robot. The class defines what kind of part it is—what it looks like, 
what it can do, and how it interacts with other parts—but it doesn’t physically exist 
until you attach it to a robot (which would be the GameObject in Unity).


In this metaphor:

Classes are like the design documents or templates for different robot parts.
Components are the real, functional parts attached to the robot, each 
fulfilling its designed purpose.
Member variables represent the traits or settings of each part—like size, 
color, or power level—that make every instance unique.
Methods represent the actions that part can perform, like moving, glowing, 
or reacting to collisions.

Together, they create a system where each GameObject can be customized and 
brought to life by mixing and matching Components that follow their class blueprints.

Why the balls get extremely bright:
When the balls bounce too many times, their brightness increases rapidly because 
the energy or intensity value (often tied to emission color or light intensity in 
the material) isn’t being limited or reset. Each collision adds to the value, stacking 
continuously and causing an overexposed glow in the Scene view. This might mean the 
collision method keeps amplifying a property—like color intensity—without a maximum cap.

Reflection:
This activity really helped me visualize how Unity’s Component-based structure works. 
Thinking in metaphors—like robots with interchangeable parts—made it easier to see how 
scripts, variables, and behaviors fit together to make dynamic gameplay systems. It also 
reminded me of the importance of controlling variable limits to prevent unexpected effects 
(like the over-bright ball glitch), which ties directly into good coding habits and debugging awareness.



### W4

Activity 1: *activity 2 is skipped*

My Table; Table 7: . Lines to describe: 5, 22, and 25:

Lines 5:[SerializeField] private float _moveSpeed = 1.0f;

Explanation: _moveSpeed is a member variable of type float, used to store how fast the cat moves. The [SerializeField] 
attribute makes it appear in the Inspector window even though it’s private.

Line 22: float translation = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

Explanation:This line creates a local float variable called translation that multiplies the player’s input from 
Input.GetAxis("Vertical") by _moveSpeed and Time.deltaTime to calculate smooth movement.

Line 25:transform.Translate(0, 0, translation);

Explanation: Calls the method transform.Translate() to move the GameObject by (0, 0, translation), meaning it 
moves forward or backward along the z-axis.



Other Tables 11-19. Lines to describe: 17, 28, and 32:

Line 17: if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)

Explanation: Line 17: Uses an if statement to check if the spacebar is pressed (Input.GetKeyDown(KeyCode.Space)) and 
if _isGrounded is true, meaning the cat can jump.

Line 28: _animator.SetBool(_isWalkingName, true);

Explanation: Line 28: Calls _animator.SetBool() with the parameters _isWalkingName and true to play the walking 
animation when moving.

Line 32: private void OnCollisionStay(Collision collision)

Explanation: Defines the method OnCollisionStay(Collision collision), which runs whenever the GameObject 
stays in contact with another collider.""


Activity 3:

Table # 7

Answer the questions:

1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
2. IF your game did not work perfectly the first time you tested it, talk about what you had to fix.

Response 1: Collider Activity Solution:

We added Rigidbody components to the Cat and the SoccerBall so they could move and interact with physics. 
The Goal did not need a Rigidbody because it doesn’t move. We checked Is Trigger on the Goal’s collider 
so the ball could pass through it but still detect when it scores. The Cat and SoccerBall colliders were 
left as solid so they could bounce off each other and the walls.

Response 2: Fixes We Made:

At first, the ball didn’t detect the goal correctly. We realized we forgot to check Is Trigger on 
the Goal’s collider. After fixing that, the ball could score properly. We also had to freeze rotation 
on the X and Z axes for the Cat and SoccerBall to stop them from falling over.