<?php
$host = 'localhost';
$db = 'motory';
$user = 'root';
$pass = '';  // Brak hasła

// Połączenie z bazą danych
$mysqli = new mysqli($host, $user, $pass, $db);

// Sprawdzanie połączenia
if ($mysqli->connect_error) {
    die("Błąd połączenia z bazą danych: " . $mysqli->connect_error);
}

// Ustawienie kodowania połączenia na UTF-8
$mysqli->set_charset("utf8mb4");

// Zapytanie do bazy danych
$query = "SELECT wycieczki.nazwa, wycieczki.opis, wycieczki.poczatek, zdjecia.zrodlo 
          FROM wycieczki 
          INNER JOIN zdjecia ON wycieczki.id = zdjecia.id";
$result = $mysqli->query($query);

// Sprawdzanie wyników zapytania
if ($result->num_rows > 0) {
    // Przetwarzanie wyników zapytania
    while ($row = $result->fetch_assoc()) {
        $nazwa = $row['nazwa'];
        $poczatek = $row['poczatek'];
        $opis = $row['opis'];
        $zdjecie = $row['zrodlo'];

        // Wyświetlanie wyników z białym kolorem linku
        echo "<p id =\"naglowek\"style=\"color: white;\"> $nazwa, rozpoczyna się w $poczatek, <a href=\"$zdjecie.jpg\" style=\"color: white;\">Zobacz zdjęcie</a> </p>";
        
        // Wyświetlanie opisu z efektem zmiany koloru na jasny zielony po najechaniu
        echo "<p id=\"opis\"> $opis</p>";
    }
} else {
    echo "Brak wyników.";
}

// Zamykanie połączenia
$mysqli->close();
?>  
