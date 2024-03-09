<?php
$polaczenie=new mysqli('localhost','root','','forum') or die ('Błąd połączenia z bazą danych');
mysqli_set_charset($polaczenie, "utf8");

$nick=$_POST['nick'];
$hobby=$_POST['hobby'];
$praca=$_POST['praca'];
$plec=$_POST['plec'];
$login=$_POST['login'];
$haslo=$_POST['haslo'];

$polecenie="INSERT INTO uzytkownicy VALUES('default','$nick','$hobby','$praca','$plec')";
$zapytanie=$polaczenie->query($polecenie);
if ($zapytanie==true) 
    echo 'Użytkownik został dodany <br>';
else
    echo 'Wystąpił błąd podczas dodawania rekordu <br>';

$polecenie2="INSERT INTO konta VALUES('default','$login','$haslo')";
$zapytanie2=$polaczenie->query($polecenie2);
if ($zapytanie2==true)
    echo 'Dane logowania zostały pomyślnie dodane <br>';
else
    echo 'Wystąpił błąd podczas dodawania rekordu <br>';
$polaczenie->close();
?>