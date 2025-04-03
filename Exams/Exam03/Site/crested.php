<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hodowla świnek morskich - zamów świnkowe maluszki</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <header><h1>Hodowla świnek morskich - zamów świnkowe maluszki</h1></header>
    <div id = "menu">
        <a href="peruwianka.php">Rasa Peruwianka</a>
        <a href="american.php">Rasa American</a>
        <a href="crested.php">Rasa Crested</a>
    </div>
    <div id="prawy">
        <h3>Poznaj wszystkie rasy świnek morskich</h3>
        <?php include 'skrypt1.php' ?>
    </div>
    <div id="lewy">
        <img src="crested.jpg" alt="Świnka morska rasy peruwianka">
        <?php include 'skrypt2_2.php' ?>
        <hr>
            <h2> Świnki w tym miocie</h2>

        <?php include 'skrypt3_2.php' ?>

    </div>
    <footer> <p>Strone wykonał: Jakub Jabłoński</p></footer>
</body>
</html>