<?php
$servername = "localhost";
$username = "root"; // Change to your database username
$password = "";     // Change to your database password
$dbname = "dino_game";

// Connect to the database
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

// Grab the data sent by Unity's WWWForm
$name = $_POST['name'];
$score = $_POST['score'];

if(!empty($name) && isset($score)) {
    // Use prepared statements to prevent SQL Injection hacks
    $stmt = $conn->prepare("INSERT INTO leaderboard (name, score) VALUES (?, ?)");
    $stmt->bind_param("si", $name, $score); // 's' for string, 'i' for integer
    
    if ($stmt->execute()) {
        echo "Success";
    } else {
        echo "Error: " . $stmt->error;
    }
    $stmt->close();
} else {
    echo "Error: Missing data";
}
$conn->close();
?>