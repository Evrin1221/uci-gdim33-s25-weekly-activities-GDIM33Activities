# GDIM 33 In-Class Activities
## W1
### Activity 1

[My moodboard](https://docs.google.com/drawings/d/1t-PRnmojF-f7GRGk9lbGjSOMPYckyZY9VhQW2mp6QRo/edit)

1. Night time and liminal spaces are a recurring pattern. I'm super into the night scene with tons of neon lighting too. Anything dark with shiny lighting. Most of my favorite game genres are metroidvania and narrative rpgs. I also think a lot of them have a heavy exploration aspect.
2. We seem to both be into some form of sci fi and cyberpunk in terms of aesthetics.
3. One of my LAs said they like Deaths Door and I was really surprised because this game isn't that well known and I think it's so good. It is really simple, basically traverse area with small enemies then defeat the boss of that area, but the art and worldbuilding is so good and the npcs are so fun. 


### Activity 2

1. Genre: 2D platformer
2. Core mechanic: The player must run through the map while dodging or destroying obstacles (which get progressively harder). The player will have a "sanity" and "awakeness" bar. The sanity bar will lower as the player gets hit and the lower it gets, the more disorienting effects I will add. The awakeness bar can be raised as you hit obstacles and destroy them, and this will apply buffs to the player. Every checkpoint, the player will have to mark one of their arms (shown in a separate UI) however if the sanity bar is really low, I will add disorienting effects to confuse the player to mark the wrong arm.   

[break down draft](https://docs.google.com/drawings/d/1uJg0dZvA5N5NgQdQd8dcje9uOtP9B7NRDVVP-FqppEg/edit)

## W2


[final commit of the day](https://github.com/Evrin1221/uci-gdim33-s25-weekly-activities-GDIM33Activities/commit/78fbc3aa4fde7daa51668336d50dc614b7cf816f)


## W3

### Activity 1


![alt text](<Screenshot 2026-04-15 172020.png>)



### Activity 2

#### Q1

We need to use it to call the event, which is in GameController, but we're trying to call it in walrus, and we can hook the variable name to the script if it's a scene variable instead of naming it in the node in the GameController.

#### Q2

I used a debug node to test the firing of the event from when I click the screen. This part worked, but the game wasn't responding how it should. By adding a debug statement to the receiving end of the event, I could identify that although the event was being fired, something was wrong with how it was being received. 

#### Q3

It's not relevent to my vertical slice because there isn't a moment where the mouse needs to be used for two different things in the same screen. The only time the mouse is used is really brief, and there's an entire screen change instead of just a UI, so I don't think I will be using this. 

#### Q4

Yes. Aside from animations, the sanity bar of my game determines which vfx will be activated. Furthermore I plan on making it so that on low sanity modes, there will be nerf items spawning more often, so I think I will definitely be using a state machine. 



## W4

### Activity 1


#### What is playable:
- Movement
- Small slice of terrain that can be navigated
- Automatic side scrolling
- Jump with hold detection


#### Playtesting Goals:
- Make sure movement is intuitive
- get feedback for tighter platforming movement especially for the jump (is it floaty, is it too weak etc)


#### Playtesting team:
- Romarick Anderson, Nicole Yang


#### Playtesting notes:
- jump looks kinda floaty
- I didn't freeze the rotation
- make sure obstacle jump platforming is somewhat "timed" nicely


### Activity 2

#### Q1

Yes a writer would be able to add more dialogue, because it's done with scriptable object as opposed to strings stuck in code. The writer just has to make more scriptable objects and type the dialogue, and the programmer can take care of hooking them up

#### Q2

The writer could probably add all the dialogue lines they want without writing any code if the code is written to scale well

#### Q3

Regenerate nodes allows the visual scripting machine in unity to make nodes out of classes you write yourself, so that you can access code in script in the script machine. 

## W5

### Activity 1

(I already have my selected system (tilemaps) implemented so I will be working on something else)

I will need an enemy manager for my game. My game will have different enemies, varying in movement, visuals, difficulty and spawn rate

1. Create enemy class for all enemy types to inherit from
    - create member variables of this class such as:
        - health
        - spawn rate
        - attack
        - speed
        - detection range
    - make prefabs for a variety of enemy types.
        - have each script inherit from the enemy class
    - code shared behavior like player detection
        - uses a state machine
    - override their respective Attack() methods to match the enemy's attack
    - add a new tilemap in the grid so the autoscroller applies to the enemies

2. Make them spawn
    - instantiate enemies from the right side of the screen according to the value of their spawn rate variable
3. **Disable them once they go off screen so they don't attack from behind the player**
    - I need to ask someone how to do this because my original thought was to just have a collider that follows from behind and disable everything once it hits it and that doesn't seem like a great idea
    - basically how do I detect if something is "off screen"
    - and make the player not able to go "off screen" at all

### Activity 2

[Work from today](https://github.com/Evrin1221/VerticalSlice/commit/23627e2ad2aac693c21dbd03591815729688921c)

I set up the state machine for the base behavior of all of the enemies, and added an enemy variation that inherits from this script.
I have set up the Attack() method, which is different for all enemies, therefore can be overriden by the individual enemy scripts.
I've also set up the state machine that handles the behavior of all enemies for roaming, chasing, attacking, and retreating scripts. I've set the enemies to just move in a straight line when they spawn, which will be handled by the autoscroller. Once they're in chasing range, they will follow the player, and once they're in attacking range they'll attack while still sticking to the player unless the player manages to kill or outrun them. 
There's also an attack duration. Each enemy has a set amount of time they attack for, and if they don't die before that maximum time is over, they retreat and don't go after the player again.

##  W6

### Activity 1

#### Playtesting goals:
- enemies are challenging enough to affect gameplay
- player understands why they're losing health
- enemy spawning looks good
- controls feel good

#### New stuff:
- enemies exist
- there's a sanity bar

#### [Itch link](https://evrin-lee.itch.io/sleepless-playtest-2) 

#### Playtest notes:
- need visual indicator before reversing controls (this is probably applicable for all)
- enemy system is good, need to build the melee fighting asap for game balance


### Activity 2

#### Q1

Because if you multiply values together they get bigger, and larger values represent darker colours

#### Q2

The values get lighter because the values get smaller, and smaller values mean more transparency

#### Q3

The UV map...?

#### Q4

Yes. I also do digital art so I recognized the blending mode names which was just a fun thing I noticed


## W7

### Q1

The UV map of the shiba...?

### Q2

Because the values of two different coloured vertices are interpolated across the triangles between them, making the different colours blend

### Q3

Because the texture from last week was probably made/painted to have all of the details in, such as flush and different shades of shiba fur across the body, and when we coloured it this week with just code, we just let the colours blend using interpolation. Vertex colour could be useful for low poly or anything you might not want to paint a detailed texture for. 

### Q4

The normals are "backwards" which is probably why it got lit backwards when we tried to apply lighting to it

### Q5

We could use it to identify if the normals in the model match our intended x,y,z directions. It could be useful if a texture isn't being applied as intended because it might be something to do with which component we're assinging stuff to

### Q6

Because the normals of the shiba (the ones that face the light) are pointing at the opposite direction of the light. The dot product of opposite facing vectors results in a negative value, therefore the shadows appear on the light and the light in the shadows. 

### Q7

I think we use it because we want the noise texture below to be preserved. From what I know from digital painting, the "add" blending mode makes the stuff in the layer bright and shiny and transparent, so I'm assuming it's doing something similar here. 


## W8

### Activity 1

#### Playtest goals:
- is it intuitive
- do players understand the loop - enemies spawn, you kill them, or they bring your sanity down
- animation that plays when your controls get reversed

* new stuff since milestone 2: more animations

[link](https://evrin-lee.itch.io/sleepless-playtest2)

#### Playtest notes:
- people like the grenades
- need more vfx or sfx to indicate when something is happening/changing
- gotta actually finish the terrain

* note to self: tech support for: whys the dizzy halo appearing early, why's the UI appearing somewhere weird


### Activity 2B

