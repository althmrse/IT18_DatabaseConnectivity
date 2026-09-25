Sketch Jump! (Guided Simple Unity Game Prototype)

IT18_J4S
Members:
- Garcia, Ezikiel M.
- Guico, Alain Kenneth D.
- Manalo, Althea Merise M.

This project is a 2D endless runner inspired by the classic offline browser dinosaur game. The player controls a dinosaur that must jump over endlessly spawning cactus obstacles. As the player survives longer, the game world gradually speeds up, increasing the difficulty. The game features a main menu, a dynamic scoring system based on survival time, and a fully functional leaderboard that saves and retrieves the top 10 global high scores over the internet.

**Tools and Technologies Used**
Game Engine: Unity 6.3 LTS (6000.3.24f1)
Programming Language: C# (Unity Scripting API)
Version Control: Unity VCS / GitHub (via GitSync)
Backend & Database: Firebase Realtime Database (REST API)

**Database or Storage Option Used**
Database Management System: Firebase Realtime Database (Cloud NoSQL)

Architecture: The game uses Unity's UnityWebRequest to communicate directly with the Firebase REST API. It securely sends and receives leaderboard data in JSON format over the cloud, completely eliminating the need for local servers like XAMPP.

**Instructions on How to Run the Prototype**
1. Download the Game: Navigate to our GitHub repository and download the provided project .7z archive containing the compiled game.

2. Extract the Files: Use an archiving tool (like 7-Zip or WinRAR) to extract the .7z file contents into a new folder on your computer.

3. Run the Game: Open the extracted folder and double-click the game's executable file (e.g., .exe) to launch it.

4. Internet Requirement: Please ensure your computer is connected to the internet so the game can successfully fetch and submit scores to the live global leaderboard.

**Explanation of What Data is Saved and Retrieved**
- Data Saved (Insert): When the player hits an obstacle, a Game Over panel appears. The player inputs their name, and the game sends a POST request to Firebase containing a JSON payload with the player's name (String) and final score (Integer).

- Data Retrieved (Select): When the player opens the Leaderboard panel, the game sends a GET request to Firebase asking for the Top 10 highest scores. The C# script parses the returned JSON data and displays it as a cleanly formatted list on the user interface.

**Known Limitations or Unfinished Parts**
The game does not have any music or sound effects.

**References or Tutorials Used**
https://youtu.be/xcmYsc2BY-U?si=boA09u9F9AQqn-OZ
