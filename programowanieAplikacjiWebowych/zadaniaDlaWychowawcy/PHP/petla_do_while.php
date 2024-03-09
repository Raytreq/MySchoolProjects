<!DOCTYPE HTML>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="keywords" content="Infromatyka, ZSEEiM Bielsko-Biała">
    <meta name="description" content="ikot.edu.pl PAW/WAI lekcje">

    <title>ikot.edu.pl - PHP zadania krok po kroku</title>

    <link rel="stylesheet" href="css/style.css">
    <script src="nazwa_pliku.js"></script>
</head>
<body>
    <header class="gora">
        <h2>PHP zadania krok po kroku</h2>
    </header>

    <?php
    echo '<h1>Zadanie 2 - pętla do while</h1>';
    echo '<h2>2.1 Najprostsza postać pętli do...while</h2>';

    $hp_potworka = 200;
    do {
        echo 'Potworek ma '.$hp_potworka.' hp<br>';
        $hp_potworka -= 50;
    }while($hp_potworka > 0);

    echo '<h2>2.2 Pętla z warunkiem IF</h2>';

    $magiczna_liczba = 5;

    do {
        $liczba = rand(0,10);

        if($liczba == $magiczna_liczba) {
            echo "Wylosowano magiczną liczbę $liczba!<br>";
            echo "Pętla kończy działanie";
        }
        else {
            echo "Wylosowano liczbę $liczba, pudło!<br>";
        }
    }while($liczba != $magiczna_liczba);
    ?>
</body>
</html>