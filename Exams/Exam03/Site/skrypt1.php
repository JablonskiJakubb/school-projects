<?php
$host = "localhost";
$user = "root";
$pass = "";
$db = "swinki";

$conn = new mysqli($host,$user,$pass,$db);
if ($conn -> connect_error){
    die("błąd: " . $conn -> connect_error);
}
$conn->set_charset("utf8mb4");

$sql = 'SELECT rasy.rasa FROM rasy;';

$result =  $conn->query($sql);

if ($result->num_rows > 0){
    echo "<ol>";
    while($row = $result->fetch_assoc()){
        echo  "<li>" . $row['rasa']  . "</li>";
    }
    echo "</ol>";
}else{
    echo "brak wynikow";
}
$conn->close();
?>