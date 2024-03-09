<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>LUX Parkiet</title>
    <meta name="description" content="Sklep z deskami podłogowymi drewnianymi.">
    
    <link rel="stylesheet" type="text/css" href="style.css"/>
    <link rel="icon" href="img/logo.png" type="image/gif">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600&family=Open+Sans:wght@400;500;600&display=swap" rel="stylesheet"> 
</head>

<body>
    <?php
        include 'strony/gora.php'
    ?>

    <div class="menuGlowne">
        <ul>
            <li>
                <a href="index.php">Strona główna</a>
            </li>
            <li>
                <a href="index.php?strona=o_firmie">O firmie</a>
            </li>
            <li>
                <a href="index.php?strona=produkty">Produkty</a>
            </li>
            <li>
                <a href="index.php?strona=kontakt">Kontakt</a>
            </li>  
        </ul>
    </div>

    <main>
    <?php
        include 'strony/menu.php';

        if(!isset($_GET['strona']))$_GET['strona']=NULL;
        switch($_GET['strona']) {
            case 'o_firmie':
                include 'strony/tresc/ofirmie.php';
                break;

            case 'produkty':
                include 'strony/tresc/produkty.php';
                break;

            case 'kontakt':
                include 'strony/tresc/kontakt.php';
                break;
            
            default:
                include 'strony/tresc/glowna.php';
                break;
        }
    ?>
    </main>
    <?php 
        include 'strony/stopka.php';
    ?>
</body>
</html>