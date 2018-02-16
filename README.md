# StorytellersRevenge
This repository contains a Unity 3D mobile application for iOS and Andriod devices called **_Storyteler's Revenge_**. It was built and tested using the Google Cardboard Viewer.**_Storyteler's Revenge_** is a 360 video application where the user can watch two different videos simultaneously. The user has control over which of the videos they want to watch, to play and pause the videos, and also to restart them. A particle effect is used to give the videos more life with Gvr audio sources surrouding the video sphere. The videos are edited to have title and end credits done in Adobe Premiere Pro.
<br /> ![screen shot 2018-02-09 at 3 15 36 pm](https://user-images.githubusercontent.com/35173600/36048120-297415fe-0dac-11e8-8659-3d7ae04d1276.png)

## Getting Started

### Prerequisites
The software you will need to download in order to build and run the game on a mobile device:
<br /> • The cross-platform engine [Unity 3D](https://unity3d.com/unity/qa/patch-releases/2017.1.0p4 "Unity 3D download") Patch Release 2017.1.0p4
<br />
- For iOS builds, the latest version of [Xcode](https://developer.apple.com/download/ "Xcode 9.3 Beta")
- NOTE! You will need to have an [Apple ID](https://appleid.apple.com/account#!&page=create "Developer Account") in order to download Xcode and build for iOS
- NOTE! Make sure to have the latest software version; 11 and up
- For Android builds, you need [Android Studio](https://developer.android.com/studio/index.html "Android Studio download") and the [Java JDK 8](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html "JDK download")

### Installing
To build and run a copy of this application to your mobile device:
<br />
<br /> • On the **Storyteller's Revenge** repository, go to the green "Clone or download" button and click "Download Zip"
<br />
<br /> • Once the zip file has loaded onto your desktop, double click the zip file to open. Navigate to the folder Assets > Storyteller's Revenge.unity and double click the scene to open it in Unity 3D
<br />
<br /> -NOTE! The scene may not be located at the top of the folder. If not, you will have to scroll through the folder to find it. It will be titled exactly Storyteller's Revenge.unity with the Unity logo-
<br />
<br /> After opening the scene in Unity 3D choose to build to either an iOS or Android mobile device
<br />
1. For iOS builds:
   - Go to File > Build Settings and switch the platform to iOS (this can take a while) then click the Player Settings button below that and with this open you can change the name of the application and bundle identifier, if you would like to change them, before pressing Build and Run to then be prompted to name the build and save it. (I usually save the build to my desktop so I can delete it later) 
     - The build will open in Xcode. Make sure to check your Apple ID is correct, the bundle identifier and the name of the application is what you would like it to be then press the play button in the upper left corner and the application will build and run directly to your iOS device.
2. For Android builds:
   - First, go to the top left corner and click Unity > Preferences. Then, select External Tools in the list and add the locations of Android Studio and Java JDK 8 in the correct section.
     - Afterwards, go to File > Build Settings and switch platform to Android (this can take a while to do) then click the Player Settings button below that and you can change the name of the application and bundle identifier, if you would like to change them, before pressing Build and Run to then be prompted to name the build and save it. The application will be built right to your Android device from Unity. 

### Deployment
When building the application to your phone a few important things to note:
<br />
<br /> • In Player Settings, you are able to not only change the name of the application and bundle identifier to whatever you would like you can also add a photo to be the icon for the application on your phone. It will be one of the first things you can do in Player Settings. Right under renaming the application.
<br /> • The Google VR SDK used in the game tracks your head movement. Meaning, wherever the phone is facing, the application will open and start your game from that position. If you would like to be facing a certain direction to play the game right after building to your phone I would suggest facing your device in that direction and hold it horizontally so you can start the experience in the most comfortable position for you.


## How to play
The instructions to play the application **_Storyteler's Revenge_**:
<br />
<br /> • After opening application the user will see only blackness. What they need to do is look down in order to find the video control panel. When the user presses "Play" the video will start playing and they are able to pause, restart, or switch the videos after the play button is pressed
<br />
<br /> ![screen shot 2018-02-09 at 3 15 04 pm](https://user-images.githubusercontent.com/35173600/36048181-5770213c-0dac-11e8-9cbd-0f8a3856f03a.png)
<br /> 
<br /> • To play the second video, after pressing the "Switch Video" button, the user must hit the "Play" button on that control panel for the second video to begin. The user will have to do this everytime when switching between the videos
<br />
<br /> ![screen shot 2018-02-09 at 3 19 11 pm](https://user-images.githubusercontent.com/35173600/36048268-9f340f10-0dac-11e8-9338-b806e03f3754.png)

# Authors
• Samantha Cayla Bajis - _Initial work_ - SamBajis

# Acknowledgments
To make **_Storyteller's Revenge_** possible:
<br /> 
<br /> • Udacity - Coding for Video Sphere Shader, Providing the 360 footage used
<br /> 
<br /> • Google VR SDK- Head tracking, sound system and ability for the users interaction with the Google Cardboard Viewer
<br /> 
<br /> • AutoPano Video Pro - Stitched together the 360 videos using this software
<br /> 
<br /> • Adobe Premiere Pro - Edited both 360 videos to have title and credits and added in effect as video changes to them
