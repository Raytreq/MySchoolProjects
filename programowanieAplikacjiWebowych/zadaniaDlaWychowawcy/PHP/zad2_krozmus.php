<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="keywords" content="Informatyka, ZSEEiM Bielsko-Biała">
    <meta name="descripion" content="ikot.edu.pl PAI/WAI lekcje">

    <title>ikot.edu.pl - PHP zadania krok po kroku</title>

    <link rel="stylesheet" href="arkusz_stylow.css">
    <script src="js/funkcje.js"></script>
</head>

<body>
    <header class="gora">
        <h2>PHP zadania krok po kroku</h2>
    </header>

    <?php
        echo '<h1>Zadanie 2 - instrukcja warunkowa switch</h1>';
        echo '<h2>2.1 Najprostsza postać instrukcji switch</h2>';

        $x = 3;

        switch($x) {
            case 0:
                echo '<div>X jest równe zero</div>';
                break;

            case 1:
                echo '<div>X jest równe jeden</div>';
                break;

                case 2:
                echo '<div>X jest równe dwa</div>';
                break;

            case 3:
                echo '<div>X jest równe trzy</div>';
                break;

            case 4:
                echo '<div>X jest równe cztery</div>';
                break;
                
            default:
                echo '<div>X nie jest równe 1,2,3 lub 4</div>';
        }

        echo '<h2>2.2 Zmienne o małym zakresie dni</h2>';

        $numer_dnia_tyg = 6;

        switch($numer_dnia_tyg) {
            case 1:
                echo "<div>$numer_dnia_tyg dzień tygodnia to poniedziałek</div>";
                break;
                
            case 2:
                echo "<div>$numer_dnia_tyg dzień tygodnia to wtorek</div>";
                break;
                
            case 3:
                echo "<div>$numer_dnia_tyg dzień tygodnia to środa</div>";
                break;
            case 4:
                echo "<div>$numer_dnia_tyg dzień tygodnia to czwartek</div>";
                break;
                
            case 5:
                echo "<div>$numer_dnia_tyg dzień tygodnia to piątek</div>";
                break;
                
            case 6:
                echo "<div>$numer_dnia_tyg dzień tygodnia to sobota</div>";
                break;
                
            case 7:
                echo "<div>$numer_dnia_tyg dzień tygodnia to niedziela</div>";
                break;
            
            default:
                echo "<div>Nieprawidłowy numer tygodnia! Podano numer: $numer_dnia_tyg.</div>";
        }

        echo '<h2>2.3 Sprawdzanie napisów</h2>';

        $nazwa_broni = "Toporek";
        switch($nazwa_broni) {
            case "Toporek":
                $dmg_broni = 2;
                break;
                
            case "Minigun":
                $dmg_broni = 35;
                break;
                
            case "Shotgun":
                $dmg_broni = 15;
                break;
                
            case "Laser Rifle":
                $dmg_broni = 70;
                break;

            case "Łzy osób nierozumiejących PHP":
                $dmg_broni = 500;
                break;

            default:
                echo '<div>Nieznany typ broni!</div>';
                $dmg_broni = -1;
                break;
        }

        echo "<div>Eustachy korzysta z broni: $nazwa_broni.</div>";
        echo "<div>Obrażenia broni: $dmg_broni.</div>";

        echo '<h2>2.4 Zmienne IFa na swithca</h2>';

        $i=5;

        if ($i == 0) {
            echo "<div>i equals 0</div>";

        }
        elseif ($i == 1) {
            echo "<div>i euqals 1</div>";
        }
        elseif ($i == 2) {
            echo "<div>i equals 2</div>";
        }

        switch ($i) {
            case 0:
                echo "<div>i equals 0</div>";
                break;
                
            case 1:
                echo "<div>i equals 1</div>";
                break;
                
            case 2:
                echo "<div>i equals 2</div>";
                break;

            default:
                echo "<div>i is not equal to 0, 1 or 2</div>";
        }
    ?>
</body>
</html>
