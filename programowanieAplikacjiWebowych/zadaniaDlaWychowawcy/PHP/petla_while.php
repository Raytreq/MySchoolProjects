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
    echo '<h1>Zadanie 1 - pętla while</h1>';
    echo '<h2>1.1 Najprostsza postać pętli while</h2>';

    $x = 1;

    while($x <= 5) {
        echo "X ma wartość $x<br>";
        $x++;
    }

    echo '<h2>1.2 Warunek złożony</h2>';

    $x = 8;
    $y = 5;

    while($x > 0 && $y > 0) {
        printf("X=%d, Y=%d<br>",$x,$y);
        $x++;
        $y--;
    }

    echo '<h2>1.3 Prostszy zapis warunku pętli</h2>';

    $hp_potworka = 50;

    while($hp_potworka) {
        echo 'Potworkowi zostało '.$hp_potworka.' hp<br>';
        $hp_potworka -= 5;
    }

    echo '<h2>1.4 Pętla while z IFem</h2>';

    $ileRzutow = 0;
    $ileOrlow = 0;
    $ileResztek = 0;

    while($ileRzutow < 10) {
        $rzut = rand(0,1);
        $ileRzutow++;

        echo "<div><b>Rzut nr $ileRzutow</b>: ";

        if($rzut) {
            $ileOrlow++;
            echo "Orzeł";
        }
        else {
            $ileResztek++;
            echo "Resztka";
        }
        echo "</div>";
    }

    echo "<p>Po $ileRzutow rzutach wynik to $ileOrlow orłów i $ileResztek resztek</p>";

    ?>
</body>
</html>