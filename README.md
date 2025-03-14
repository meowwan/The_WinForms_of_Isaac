> [See in spanish/Ver en español](https://github.com/LuisMiSanVe/The_WinForms_of_Isaac/blob/main/README.es.md)
# 💧 The WinForms of Isaac
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

The WinForms of Isaac is a fan-made recreation of a 'The Binding of Isaac' Boss Fight, but using WinForms.

## 📝 Technology Explanation
The most technical part is the Boss' **moving pattern**, which changes it's direction when it hits the wall.

The hitboxes for the main Character, it's Attack and the Boss are made with the `Rectangle` object, to detect collisions with others.

In the [code]()'s comments, all the moving pattern and functionality is explained.

## 🛠️ Setup
Just download the binary file from the [Releases]() or from the [itch.io Page]() and play!

You can also clone this repository and compile it yourself in [Visual Studio](https://visualstudio.microsoft.com/).

## 🎮 Project Usage Explanation
There is an in-game controls aid, which pops up a window with all the game's controls by pressing the `C` key.\
These are the controls:
- W,A,S,D: Move the Character.
- Arrows: Move the Attack.
- E: Place bombs.
- Space: Accept/Skip.
- Escape: Exit.

## 📖 About the Project
This is one of the projects I made while studying for my Programming degree. It involved creating an object that bounces off the screen's edges and changes its direction accordingly.

>[!IMPORTANT]
>All the sprites of the game are made from scratch, based on the original game's textures.
>
>Background music is 'Innocence Glitched' from the 'Antibirth' Mod, which is free to use as stated in this [Reddit thread](https://www.reddit.com/r/bindingofisaac/comments/5kr7nm/antibirth_music_update_now_on_spotify_and_more/?rdt=47694) by the music designer himself.
>You can [contribute](https://antibirth.com/) to support their great work!

## 🚀 Releases
The version will be released using these versioning policies:\
New major features and critical bug fixes will cause the immediate release of a new version, while other minor changes/fixes will wait one week from the time the change is introduced in the repository before being included in the new version, so that other potential changes can be added.
>[!NOTE]
>These potencial new changes will not increase the wait time for the new version beyond one week.

The version number will follow this format: \
\[Major Feature\].\[Minor Feature\].\[Bug Fixes\]

## 💻 Technologies Used
- Programming Language: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
- Recommended IDE: [Visual Studio](https://visualstudio.microsoft.com/)
