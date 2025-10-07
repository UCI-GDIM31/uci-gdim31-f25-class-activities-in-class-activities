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

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 