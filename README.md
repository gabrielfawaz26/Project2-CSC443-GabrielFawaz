# Gabriel Fawaz\_20231159

## Assignment 4 – FPS Game Project: Flower Fury

# 

# 

## **1. Project Overview**

# 

##### Flower Fury is a first-person shooter game where the player progresses through a combat environment filled with enemies, weapon pickups, and interactive systems. The project combines gameplay mechanics, AI spawning systems, UI menus, animations, and audio feedback into a complete playable experience.

##### 

##### The goal of the project was to build a modular FPS system using clean architecture principles such as event-driven programming, component separation, and reusable gameplay systems.

# 

# 

## **2. Gameplay Core Mechanics**

### 

* ### Weapon System



##### The player can collect and use multiple weapons throughout the game. Each weapon has its own behavior, animation, and audio feedback. Weapons are unlocked through pickups and managed using a WeaponSwitcher system.

### 

* ### Weapon Switching



##### The player can switch between unlocked weapons using a key input. Only one weapon is active at a time, ensuring clear combat control and preventing visual or mechanical overlap.

# 

* ### Shooting System



##### Each weapon supports shooting with visual and audio feedback. Shooting includes:

##### 

##### \-Gun animations

##### \-Muzzle flash particle effects

##### \-Screen or camera impulse feedback

##### \-Shooting sound effects triggered through an event system

# 

# 

## **3. Enemy System \& Spawners**



* ### Enemy Spawners



##### Enemy spawners are placed in the level to continuously or conditionally generate enemies during gameplay.

# 

* ### Purpose:



##### \-Maintain gameplay pressure

##### \-Control pacing of combat encounters

##### \-Increase difficulty over time

# 

* ### Gameplay Impact:

### Players must constantly react to enemy waves, creating tension and engagement throughout the level.

# 

* ### Integration:



##### Spawner system works independently from player logic but influences combat flow dynamically.

# 

# 

## **4. Pickup System**



* ### Weapon Pickups



##### Weapon pickups allow players to unlock new weapons by interacting with objects in the environment.

# 

* ### Purpose:



#### \-Reward exploration

#### \-Provide progression system

#### \-Introduce new combat tools gradually

# 

* ### Gameplay Impact:



##### Encourages players to explore the map rather than rushing through it.

# 

* ### Ammo \& Health Pickups



##### Additional pickups include ammo and healing items.

# 

* ### Purpose:



##### \-Sustain player during combat

##### \-Encourage resource management

# 

# 

## **5. Animation \& Combat Feedback**



* ### Weapon Animation System



##### Each weapon includes animations that trigger during shooting or interaction.

# 

* ### Features:



##### \-Shooting animation synced with input

##### \-Reload animation support

##### \-Smooth transitions between weapon states

##### \-Visual Feedback

##### \-Muzzle flash particles

##### \-Camera impulse on shooting

##### \-Hit feedback effects on enemies through sound

# 

* ### Justification:



##### These elements increase immersion and make combat feel responsive and impactful.

# 

# 

## **6. Audio System**

# 

### The game uses an event-driven audio system to separate gameplay logic from sound logic.

# 

##### \-Audio Features

##### \-Shooting sound

##### \-Weapon pickup sound

##### \-Weapon switching sound

##### \-Hit sound

##### \-Healing sound

##### \-Ammo pickup sound

##### \-Death sound

# 

* ### System Design



##### Instead of playing sounds directly inside gameplay scripts, events are triggered and handled by a centralized AudioManager.

# 

* ### Benefits:



##### \-Clean architecture

##### \-Easy scalability

##### \-No duplicated audio logic

##### \-Easy to add new sounds

# 

# 

## **7. Level Design \& Map**

# 

### The game takes place in a designed combat environment that supports exploration and combat encounters.

# 

* ### Map Design Goals:



##### \-Encourage exploration for weapon pickups

##### \-Create combat zones for enemy encounters

##### \-Guide player movement naturally through layout

# 

* ### Gameplay Flow:



##### Players move through the environment, collect weapons, fight enemies, and survive increasing difficulty waves.

# 

# 

## **8. Story – Flower Fury**

# 

#### The story of Flower Fury follows a world where nature has become corrupted and aggressive. The “flowers” are no longer peaceful symbols of life — they have turned into hostile forces that attack anything that enters their territory.

#### 

#### The player is a survivor navigating this corrupted world, using weapons to fight back against the mutated environment and enemy forces.

# 

* ### Narrative Purpose:



##### \-Provides thematic identity to the FPS mechanics

##### \-Explains enemy presence in a stylized way

##### \-Connects environment and combat into a unified concept

# 

# 

## **9. UI System (Menu, Buttons, Shop)**

# 

* ## Main Menu



### The game includes a main menu system that allows the player to:



##### \-Start the game

##### \-Open information panels

##### \-Navigate UI screens

##### \-Buttons System

# 

### Buttons are fully interactive and include:

# 

##### \-Click feedback sound effects

##### \-Open/close panel functionality

##### \-Scene loading for gameplay

##### \-Shop Menu

# 

#### A shop interface is included to simulate progression systems.

# 

### Features:

# 

##### \-Weapon-related UI elements

##### \-Organized layout for selection

##### \-Clear navigation system

# 

# 

# **10. Game Feedback Systems**

# 

### The game includes multiple feedback systems to improve player experience:

# 

### \-Audio feedback (sound effects for all major actions)

### \-Visual feedback (particles, animations, camera shake)

### \-UI feedback (ammo, health, collected items, menus)

# 

### These systems ensure that every player action has a clear response.

# 

# 

# **11. Features I am most proud of**

# 

### Map Design

### 

##### The map is one of the strongest parts of the project. It is designed to support both exploration and combat, guiding the player naturally through different areas. It also helps control pacing by balancing open spaces with combat zones and placing pickups in meaningful locations. Overall, it connects all gameplay systems into one cohesive experience.

### 

### Sound Effects System

### 

##### The sound system is another key feature I am proud of. It uses an event-driven AudioManager to handle all game audio instead of playing sounds directly in gameplay scripts. This keeps the code clean and makes the system easy to expand. All major actions like shooting, switching weapons, and pickups have clear audio feedback, improving immersion and responsiveness.

# 

# 



# **12. Conclusion**

# 

#### Flower Fury is a complete FPS game project that combines multiple gameplay systems into a unified experience. The project includes weapon mechanics, enemy spawning systems, pickups, animation feedback, UI menus, and a centralized audio system.

#### 

#### The use of event-driven architecture improves modularity and keeps gameplay systems independent from audio and UI logic. Overall, the project demonstrates a strong understanding of Unity development, including gameplay programming, system design, and interactive user experience design.





# (ALL ASSETS IN THE SCENE ARE EITHER FROM THE STARTER KIT, OR AI GENERATED ASSETS)

