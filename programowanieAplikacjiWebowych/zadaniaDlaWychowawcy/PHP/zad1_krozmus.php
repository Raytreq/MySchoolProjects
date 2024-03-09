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
        echo '<h1>Zadanie 1 - instruckcja warunkowa IF</h1>';
        echo '<h2>1.1 Najprostsza postać instrukcji if</h2>';

        $czy_potw_zyje = true;
        $hp_potw = 50;
        $mana_potw = 0;

        if($czy_potw_zyje) echo "<div>Potworek żyje!</div>";

        echo '<h2>1.2 Blok instrukcji</h2>';

        if($czy_potw_zyje) {
            echo "<div>Potworek żyje!</div>";
            echo "<div>Potworek ma $hp_potw hp</div>";
        }

        echo '<h2>1.3 Wykorzystanie operatora ==</h2>';

        if($czy_potw_zyje == true) echo "<div>Potworek żyje!</div>";

        echo '<h2>1.4 Wykorzystywanie operatorów &gt;,&nbsp;&lt;&nbsp;&nbsp, &gt=&nbsp;&nbsp, &lt;= </h2>';

        $hp_potw = 60;

        if($hp_potw > 0) echo "<div>Potworek żyje i ma $hp_potw hp!</div>";
        if($hp_potw >= 50) echo "<div>Potworek żyje i ma conajmniej 50 hp!</div>";
        if($hp_potw < 100) echo "<div>Potworek żyje i ma mniej niż 100 hp!</div>";
        if($hp_potw <= 10) echo "<div>Potworek ledwo żyje, bo ma tylko $hp_potw hp!</div>";

        echo '<h2>1.4 Operator zaprzeczenia ! </h2>';

        $czy_potw_zyje = false;

        if(!$czy_potw_zyje) echo "<div>Potworek is dead... RIP</div>";
        else echo "<div>Potworek jeszcze żyje...</div>";

        echo '<h2>1.5 IF z elsem, czyli alternatywą </h2>';

        $x = 20;
        $y = 15;

        if($x > $y) echo "<div> x=$x i jest wieksze od y=$y</div>";
        else echo "<div>x=$x i jest mniejsze od y=$y</div>";

        echo '<h2>1.6 IF z więcej niż jedną alternatywą </h2>';

        $x=1;

        if($x>0) {
            echo'<div>Zmienna jest dodatnia</div>';
        }
        else if($x<0) {
            echo '<div>Zmienna jest ujemna</div>';
        }
        else {
            echo '<div>Zmienna jest zerem</div>';
        }

        echo '<h2>1.7 IF z rozbudowanym else if</h2>';

        $ile_potw = 56;

        if($ile_potw == 0) {
            echo "<div>Brak potworków</div>";
        }
        else if($ile_potw == 1) {
            echo "<div>Jeden jedyny samotny potworek</div>";
        }        
        else if($ile_potw == 2) {
            echo "<div>Dwa potworki</div>";
        }
        else if($ile_potw < 10) {
            echo "<div>Kilka potworków</div>";
        }
        else if($ile_potw < 20) {
            echo "<div>Kilkanaście potworków</div>";
        }
        else if($ile_potw < 50) {
            echo "<div>Horda potworków</div>";
        }
        else if($ile_potw < 100) {
            echo "<div>Wataha potworków</div>";
        }
        else if($ile_potw < 800) {
            echo "<div>Setki potworków</div>";
        }
        else if($ile_potw < 2000) {
            echo "<div>Legion potworków</div>";
        }
        else {
            echo "<div>Legiony potworków arghhh!!!</div>";
        }

        echo '<h2>1.8 Operator &&</h2>';

        $potw1_hp = 2;
        $potw2_hp = 5;
        $potw3_hp = 20;

        if($potw1_hp > 0 && $potw2_hp > 0 && $potw3_hp > 0) {
            echo "<div>Wszystkie potworki żyją!</div>";
        }

        echo '<h2>1.9 Operator ||</h2>';

        $potw1_hp = 0;
        $potw2_hp = 0;
        $potw3_hp = 15;

        if ($potw1_hp > 0 || $potw2_hp > 0 || $potw3_hp > 0) {
            echo "<div>Przynajmniej jeden potworek żyje</div>";
        }

        echo '<h2>1.10 Połączenie operatorów && i ||</h2>';

        $potw1_hp = 10;
        $potw2_hp = 20;
        $gracz_hp = 10;

        printf("<div> Potworek 1: %d hp.</div>", $potw1_hp);
        printf("<div> Potworek 2: %d hp.</div>", $potw2_hp);
        printf("<div> Gracz: %d hp.</div>", $gracz_hp);

        if($gracz_hp > 0 && ($potw1_hp <=0 || $potw2_hp <=0)) {
            echo "<div>Gracz żyje, przynajmniej jeden potworek poległ</div>";
        }
        else if($gracz_hp <= 0 && ($potw1_hp >=0 || $potw2_hp >=0)) {
            echo "<div>Gracz poległ, przynajmniej jeden potworek żyje</div>";
        }
        else if($gracz_hp > 0 && $potw1_hp <=0 && $potw2_hp <=0) {
            echo "<div>Gracz zwyciężył, oba potworki poległy</div>";
        }
        else {
            echo "<div>Nieokreślona sytuacja!</div>";
        }
    ?>
</body>
</html>
