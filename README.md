Everything that Grows, Remembers

IT18_J4S Members:

Garcia, Ezikiel M.

Guico, Alain Kenneth D.

Manalo, Althea Merise M.

Short Description of the Game Prototype

This project is a 2D choice-based narrative game inspired by titles like Life is Strange. The player navigates through a 2D environment, interacts with various characters and objects, and evaluates narrative scenarios by selecting dialogue and branch choices through UI panels. The game features a main menu, save slot management, and cloud-based data persistence that securely saves and retrieves player progress over the internet.

Tools and Technologies Used

Game Engine: Unity 6.3 LTS

Programming Language: C# (Unity Scripting API)

Version Control: GitHub

Backend & Database: Firebase Realtime Database

Database or Storage Option Used

Database Management System: Firebase Realtime Database (Cloud NoSQL)

Architecture: The game uses the Firebase SDK to communicate directly with the cloud backend. It securely sends and receives player save slot data (including name and 2D position coordinates) in real-time, eliminating the need for local servers like XAMPP.

Instructions on How to Run the Prototype
Download the Repository:

Navigate to our GitHub repository, click on the Code button, and select Download ZIP (or clone the repository using Git).

Extract the Files:

Right-click the downloaded .zip file and select Extract All... to unpack the project folder onto your computer.

Open in Unity Hub:

Launch Unity Hub, click Add (or Open > Add project from disk), and select the extracted project folder. Ensure you are using the required Unity Editor version if prompted.

Launch and Play:

Open the project, navigate to the Assets/Scenes folder in the Project window, and double-click the main scene file. Click the Play button at the top of the Unity Editor to start the game.

Internet Requirement:

Ensure your computer is connected to the internet before pressing Play so the game can successfully sync save data with the live cloud database.

Explanation of What Data is Saved and Retrieved

Data Saved (Insert): When the player pauses and exits to the main menu or reaches a checkpoint, the game updates the active save slot. It pushes a data payload to Firebase containing the player identifier (Lily) and their precise 2D/3D position coordinates (x, y, z).

Data Retrieved (Select): When the player launches the game or loads a specific save slot, the game queries Firebase to fetch the stored position data and user details, allowing them to resume seamlessly from where they left off.

Known Limitations or Unfinished Parts

The game does not currently feature complete audio, background music, or full voice acting for all narrative branches.

References or Tutorials Used
Unity documentation and Firebase C# SDK integration guides.
