<?php
$host = 'localhost';
$user = 'root';
$pass = '';
$db = 'swinki';

$conn = new mysqli($host,$user,$pass,$db);

$conn -> set_charset('utf8mb4');

if ($conn -> connect_error){
    die("błąd: " . $conn->connect_error);
}

$sql = 'SELECT swinki.data_ur, swinki.miot, rasy.rasa FROM swinki INNER JOIN rasy ON swinki.rasy_id = rasy.id WHERE rasy.id LIKE 7 GROUP BY swinki.data_ur;';
$result = $conn->query($sql);
if($result->num_rows > 0){
    while($row = $result -> fetch_assoc()){
        echo ("<h2>" . "Rasa: " . $row['rasa'] . "</h2>" . "<br>");
        echo ("<h3>" . "Data urodzenia: " . $row['data_ur'] . "</h3>" . "<br>");
        echo ("<p>" . "Oznaczenie miotu: " . $row['miot'] . "<p>");
    }
}else{
    echo "brak wyników";
}
$conn -> close();
?>