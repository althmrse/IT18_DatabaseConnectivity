<?php
$servername = "localhost";
$username = "root"; 
$password = ""; 
$dbname = "dino_game"; 

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

// Get the top 10 scores ordered from highest to lowest
$sql = "SELECT name, score FROM leaderboard ORDER BY score DESC LIMIT 10";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  $rank = 1;
  while($row = $result->fetch_assoc()) {
    // Formats the text as "1. Alice - 500" for the Unity UI
    echo $rank . ". " . $row["name"]. " - " . $row["score"] . "\n";
    $rank++;
  }
} else {
  echo "No scores yet! Be the first!";
}
$conn->close();
?>