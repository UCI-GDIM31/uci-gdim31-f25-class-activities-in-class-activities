# in-class-activities
## Devlogs
### W1
The player is a component of the Cat GameObject, so they will always be allowed to maintain control over its movements,
while the camera is its own GameObject independent from the Cat; so if the Camera were to suddenly be removed from being a 
child of the Cat GameObject, the player would still be able to move the cat, but the camera will remain fixed as it is no longer
attached to the cat's model, and therefore player movement. 

### W2
r, g, and b, are all considered floats being that that the rgb value of an asset is calculated as fractional values in order to capture the most color variety possible. 
Inversely, _bounce is represented as an integer being that bounces are a complete action, so it would naturally be represented through whole numbers as there is no such thing as 
an an incomplete bounce, it either does or it doesn't.
Step 4 of Part 2 makes the mistake of of forgetting a semicolon at the end of the statement, which results in an error message that states "Assets\W2\Scripts\Ball.cs(67,18): error CS1002: ; expected"
essentially telling the developer that the program couldn't find a semicolon on line 67, and now has no way calculating the color for the ball asset being that it can't output
a g-value.

### W3
voidSetLightDimness(intSanity)
{
	intbrightness = 100 - intSanity
}

Music is a very broad form of art that encapsulates several different genres, or "classes," many with their own set of each with their own signiture style, which can be dictated 
in several ways. Songs of the same "class" may share instruments, which can be considered the specific "member variables," of the song, or by using similar techniques, such as a 
riff during a rock song, which can be attributed to the methods of the song. More broadly, all these factors form the "components" of the song as a whole.

I didn't personally get to this part of the assignment, but if I were to assume, I would say that since the brightness of the ball is directly tied its speed, both on the x and y axis,
and as the ball only gets faster as it continues to bounce against the walls / cat, it only becomes more radiant over time.

### W4
Group 15:
Line 17 sets the member variable "_isgrounded" to a voolean value in order to detect whether or not the player is currently in contact with the ground. Line 28 sets a conditional in which if both 
conditions are met, being whether the player is currently on the ground and if the space bar is pressed, the player will be allowed to jump. In order to prevent players from inifinitely utilizing the 
ability to jump, the conditional sets "_isgrounded" to false in order to prevent the conditions from being met.

Worked with Group 15 and came to the conclusion that being that the cat and ball were both gameObjects that required freeform movement, they needed rigbodies. If the ball were to be kicked, for instance, 
it would be necessary for Unity to determine how it interacts depending on the force exerted by the cat, simulating movement physics. Inversely, the goal post did not require this property, it will not 
move and rather works as a physical goal to the player, hence Is Trigger would be enage to detect whenever a goal is being made.

### W5
Why would _moveSpeed need to be multiplyed by Time.deltaTime, what effect does it have?
Removes dependency on frame rate and standardizes movement to be based on the time that passes between each frame.

1. Looking at the script for the cat, it can be understood that the deer will need a SerializeField so that both movement speed and turn speed could be adjusted within the inspector.
2. Considering that target will need to be determined witbin the inspector as well, there will probably need to be SerializeField to determine the game object target will represent.
3. Transform variable SerializeField in order to set path
4. Set _target to the user inputted GameObject.
5. Set _target to _path
6. Set destination to _path position.

### W6
[User Resouce Guide]{https://docs.google.com/document/d/12El8B1DVwCrcYU4DHfi3xilsWEET20KrlgRqnEkWHi4/edit?tab=t.0#heading=h.b9ney94anmsi}

Plan to create BatW6 class (made with Jasmine Caicedo):

Make serialized value for speed 
Make a transform so the bats move
Make a transform var for the player so we can keep track of them and move to their position later
Set it to 1 originally (the speed)
Use on enable to make the chasing true
Then make another function on disable turn off the chasing, this goes inside the void start so that they don't all immediately flock you as soon as the game starts, they will move once you get close to them
Then make a function that constantly updates your bats to go and fly to the player, this doesn't happen until the bats are triggered to move though

### W7
#### I
The game design concept shares a document with the Unity Resource Guide, and is found as a seperate tab within said document. 
[Game Design Concept] {https://docs.google.com/document/d/12El8B1DVwCrcYU4DHfi3xilsWEET20KrlgRqnEkWHi4/edit?tab=t.n15fr0ty9u79#heading=h.q4s6t27voqk3}

#### II
Step 2 transforms the Mustrat GameObject in regards to its position but that only allows it to move in relation to the world space instead of its own axis. Translate specifies that the movement 
taking place is in accordance to the specified GameObject, and will therefore use the correct axis when calculating its movement across the world space.

### W8
[Final Plan] {https://docs.google.com/document/d/1WG5pIYocxg5BKKZbXrPqvhCKxZF10_GiZn3kfh60V9w/edit?tab=t.0#heading=h.9z308e8idhyq}

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 