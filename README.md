Recommended Unity version: 2022.3.20f1 LTS

Game name: TBA

Based on the Unity project, Unit 3 example game.

Installation:

0.  Download the game as a ZIP archive 
1.	Extract the ZIP archive with the tool of your choice 
2.	Go to Unity HUB
3.	Go to “Projects”
4.	Press the grey “Add” button
5.	Select “Add project from disk”
6.	Navigate to the extracted zip archive
7.	Selected the extracted archive
8.	Wait for unity to finish installing everything.
9.	In case the project looks empty in Unity, navigate to Assets > Scenes 
and select the Prototype 3 Scene.


Objective: Avoid the obstacles by jumping over them.


To start the game, press the "Start game" button.

Controls:
SPACE - Jump.

Mouse 1 / Left mouse button – Select options

Collision with an obstacle causes a game over and you can reset by pressing the "Restart game" button.

I have personally added a very rudimentary UI to the game and a system that gives the player points based on how they do in the game.
Points system is based on the time the player is without colliding with an obstacle. Points displayed in the upper right corner of the screen.

Things of note: 
For some reason the players’ upwards momentum seems to be nearly nonexistent after restarting the game via the “Restart game” button. 
I could not figure out why by all logic it should not happen since the restart game button reloads the whole scene and I would expect the reloading of the scene to load to the same state when starting the game for the first time.

