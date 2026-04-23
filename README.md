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
