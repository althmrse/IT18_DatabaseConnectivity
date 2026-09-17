Sketch Jump (Guided Simple Unity Game Prototype)

IT18_J4S
Members:
- Garcia, Ezikiel M.
- Guico, Alain Kenneth D.
- Manalo, Althea Merise M.

This project is a 2D endless runner inspired by the classic offline browser dinosaur game. The player controls a dinosaur that
must jump over endlessly spawning cactus obstacles. As the player survives longer, the game world gradually speeds up,
increasing the difficulty. The game features a main menu, a dynamic scoring system based on survival time, and a fully
functional leaderboard that saves and retrieves the top 10 local high scores.

**Tools and Technologies Used**
Game Engine: Unity 6.3 LTS (6000.3.24f1)
Programming Language: C# (Unity Scripting API)
Version Control: Unity VCS / GitHub (via GitSync)
Backend API: PHP

**Database or Storage Option Used**
Database Management System: MySQL
Local Hosting Environment: XAMPP (Apache and MySQL modules)
Architecture: The game uses Unity's UnityWebRequest to communicate with standard PHP scripts 
(submit_score.php and get_scores.php), which execute SQL queries against the local dino_game database.

**Instructions on How to Run the Prototype**
1. Database Setup
   - Open XAMPP and start both the Apache and MySQL modules.
   - Open phpMyAdmin (http://localhost/phpmyadmin) and import the dino_game.sql file located in the Database folder

2. API Setup
   - Place the provided submit_score.php and get_scores.php files into your XAMPP htdocs directory.
  
3. Running the Game:
   - Open the project in Unity 6.3 LTS (6000.3.24f1).
   - Open the Main Scene.
   - Press the Play button in the Unity Editor.

**Explanation of What Data is Saved and Retrieved**
- Data Saved (Insert): When the player hits an obstacle, a Game Over panel appears. The player inputs their name, and the game
  sends a POST request containing the name (String) and the final score (Integer) to the database.
- Data Retrieved (Select): When the player opens the Leaderboard panel, the game sends a GET request to the database.
  The database sorts the records by score in descending order and returns a formatted text list of the Top 10 highest scores
  to be displayed on the UI.

**Known Limitations or Unfinished Parts**
The game does not have any music or sound effects.

**References or Tutorials Used**
https://youtu.be/xcmYsc2BY-U?si=boA09u9F9AQqn-OZ
