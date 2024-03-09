<style>
    html{
            font-family: 'Montserrat', sans-serif;s
        }
</style>

<?php
$polaczenie=new mysqli('localhost','root','','egzamin') or die('Błąd połączenia z bazą danych');
mysqli_set_charset($polaczenie, "utf8");
error_reporting(E_ALL & ~E_WARNING & ~E_NOTICE);

$sel = "SELECT id, answer FROM pytania;";
$zapyt = $polaczenie->query($sel);
$nr = 1;

while($rekord = mysqli_fetch_row($zapyt)) {
    if($_POST['pyt'.$nr] != null) {
        if($_POST['pyt'.$nr] == $rekord[1]) {
            echo $rekord[0].': Prawidłowa odpowiedź.<br>';
        }
         else {
            echo $rekord[0].': Niepoprawna odpowiedź - poprawną odpowiedzią jest odpowiedz "'.$rekord[1].'".<br>';
        }
    }
    else {
        echo $rekord[0].': Żadna odpowiedź nie została wybrana.<br>';
    }
    $nr = $nr + 1;
    }

$polaczenie->close();
?>