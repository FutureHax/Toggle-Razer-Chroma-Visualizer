# Razer Chroma Connect Quick Toggles

This program allows you to setup hotkeys for toggling the Chroma Streamer Companion on and off.
This is helpful since the Chroma apps take precedence over your profiles. For example, when the Streamer Companion is controlling your Emote display, you lose your animated profiles for your other devices such as your keyboard. 

## Features
- Toggling your Razer Streamer Companion with only one button on or off
- The program will be absolutely invisible while execution
- No performance loss
- No background tasks

## Requirements
- Razer Synapse 3.0
- Razer Streaming Companion 
- .NET Framework version 4.7.2 only needed if you want to edit the source
- Windows

## Setup
The setup of the program can be done in two different ways
### Method One:
1. Download the release of the program
2. Place the .exe file in any directory
3. Go into Razer Synapses keyboard options
4. Click the key which should start the program
5. Click on the "execute program" tab and set the value to the path of the .exe file
6. Enjoy
### Method Two:
1. Clone the repository using `git clone https://github.com/FutureHax/Toggle-Razer-Chroma-Visualizer`
2. Open the Visual Studio Solution file (.sln) in Visual Studio (not Visual Studio Code)
3. Set the Build Configuration the "Release"
4. Hit `CTRL + B` to build the solution
5. Now perform method 1 beginning at step 3
6. Enjoy
