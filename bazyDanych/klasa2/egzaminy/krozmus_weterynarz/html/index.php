<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Weterynarz</title>
    <link rel="stylesheet" href="weterynarz.css">
</head>
<body>
    <!-- Baner -->
    <header>
        <h1>GABINET WETERYNARYJNY</h1>
        
    </header>
    <!-- Lewy panel -->
    <aside class="left">
        <h2>PSY</h2>
        <!-- Pierwszy skrypt -->
        <?php

        $link=mysqli_connect('localhost','root','') or die("Could not connect");

            mysqli_select_db($link,'weterynarz')
                or die ("Could not select database");

        $query = "SELECT id, imie, wlasciciel FROM zwierzeta WHERE rodzaj LIKE '1'";
        $result=mysqli_query($link,$query) or die("Query failed");

        while($row=mysqli_fetch_array($result)) {
            echo"<div>".$row['id']. " ".$row['imie']. " ".$row['wlasciciel']. "</div>\n";

        }

        mysqli_close($link);

        ?>
        <h2>KOTY</h2>
        <!-- Drugi skrypt -->
        <?php

        $link=mysqli_connect('localhost','root','') or die("Could not connect");

            mysqli_select_db($link,'weterynarz')
                or die ("Could not select database");

        $query = "SELECT id, imie, wlasciciel FROM zwierzeta WHERE rodzaj LIKE '2'";
        $result=mysqli_query($link,$query) or die("Query failed");

        while($row=mysqli_fetch_array($result)) {
            echo"<div>".$row['id']. " ".$row['imie']. " ".$row['wlasciciel']. "</div>\n";

        }

        mysqli_close($link);

        ?>
    </aside>
    <!-- Główny panel -->
    <main>
        <h2>SZCZEGÓŁOWA INFORMACJA O ZWIERZĘTACH</h2>
        <!-- Trzeci skrypt -->
        <?php

        $link=mysqli_connect('localhost','root','') or die("Could not connect");

            mysqli_select_db($link,'weterynarz')
                or die ("Could not select database");

        $query = "SELECT imie, telefon, szczepienie, opis FROM zwierzeta";
        $result=mysqli_query($link,$query) or die("Query failed");

        while($row=mysqli_fetch_array($result)) {
            echo"<div>"."Pacjent: ".$row['imie']. "<br>","Telefon właściciela: ".$row['telefon']. " ","Ostatnie szczepienie: ".$row['szczepienie']. " ", "Informacje: ".$row['opis']. "</div>\n <hr>";

        }

        mysqli_close($link);

        ?>
    </main>
    <!-- Prawy panel -->
    <aside class="right">
        <h2>WETERYNARZ</h2>
        <img src="img/logo-mini.jpg" alt="Logo firmy">
        <p>Krzysztof Nowakowski, lekarz weterynarii</p>
        <h2>GODZINY PRZYJĘĆ</h2>
        <table class="rozklad">
            <tr>
                <td>Poniedziałek</td>
                <td>15:00-19:00</td>
            </tr>
            <tr>
                <td>Wtorek</td>
                <td>15:00-19:00</td>
            </tr>
        </table>
    </aside>
</body>
</html>