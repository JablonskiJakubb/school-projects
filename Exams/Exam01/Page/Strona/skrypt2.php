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

// Zapytanie do bazy danych, zliczające liczbę wycieczek
$query = "SELECT COUNT(wycieczki.id) AS ilosc_wycieczek FROM wycieczki";
$result = $mysqli->query($query);

// Sprawdzanie wyników zapytania
if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $ilosc_wycieczek = $row['ilosc_wycieczek'];

    // Wyświetlanie wyniku w paragrafie
    echo "<p>wpisanych wycieczek: $ilosc_wycieczek</p>";
} else {
    echo "<p>Brak wyników.</p>";
}

// Zamykanie połączenia
$mysqli->close();
?>
