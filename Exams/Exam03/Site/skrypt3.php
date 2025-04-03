<?php
$host = 'localhost';
$user = 'root';
$pass = '';
$db = 'swinki';

$conn = new mysqli($host,$user,$pass,$db);
$conn -> set_charset("utf8mb4");

if($conn->connect_error){
    die("błąd: " . $conn->connect_error);
}
$sql = 'SELECT swinki.imie, swinki.cena, swinki.opis FROM swinki WHERE swinki.rasy_id LIKE 1';
$result = $conn->query($sql);
if($result-> num_rows > 0){
    while($row = $result->fetch_assoc()){
        echo "<h3>" . $row['imie'] . " " . $row['cena'] . "zł" . "</h3>";
        echo "<p>" . $row['opis'] . "</p>";
    }
}else{
    echo "brak wyników";
}
$conn->close();
?>