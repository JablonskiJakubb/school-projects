<?php
// Ustawienia połączenia z serwerem MySQL
$host = 'localhost';
$username = 'root';  // Domyślny użytkownik MySQL
$password = '';      // Domyślne hasło (jeśli jest puste, zostaw tak)
$servername = 'localhost';

// Sprawdzenie, czy formularz został wysłany
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Pobranie danych z formularza
    $db_name = $_POST['db_name'];
    $column1_name = $_POST['column1_name'];
    $column2_name = $_POST['column2_name'];

    // Połączenie z serwerem MySQL
    $conn = new mysqli($servername, $username, $password);

    // Sprawdzenie połączenia
    if ($conn->connect_error) {
        die("Połączenie nie powiodło się: " . $conn->connect_error);
    }

    // Tworzenie bazy danych
    $sql = "CREATE DATABASE IF NOT EXISTS `$db_name`";
    if ($conn->query($sql) === TRUE) {
        echo "Baza danych '$db_name' została utworzona lub już istnieje.<br>";
    } else {
        echo "Błąd podczas tworzenia bazy danych: " . $conn->error;
    }

    // Połączenie z nową bazą danych
    $conn->select_db($db_name);

    // Tworzenie tabeli
    $sql = "CREATE TABLE IF NOT EXISTS `my_table` (
        `id` INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
        `$column1_name` VARCHAR(255) NOT NULL,
        `$column2_name` VARCHAR(255) NOT NULL
    )";

    if ($conn->query($sql) === TRUE) {
        echo "Tabela została utworzona pomyślnie.<br>";
    } else {
        echo "Błąd podczas tworzenia tabeli: " . $conn->error;
    }

    // Zamknięcie połączenia
    $conn->close();
}
?>
