<?php

$polaczenie=new mysqli('localhost', 'root' ,'','pracownicy') or die ('Błąd połączenia z bazą danych');
mysqli_set_charset($polaczenie, "utf8"); 


$imie=$_POST['imie'];
$nazwisko=$_POST['nazwisko'];
$stanowisko=$_POST['id_stanowisko'];
$identyfikator = "SELECT id_stanowiska FROM stanowiska WHERE nazwa LIKE '$stanowisko'";
$id=$polaczenie->query($identyfikator);
$row = mysqli_fetch_array($id);

$idstanowiska=$row['id_stanowiska'];
$polecenie="insert into pracownik values('default','$imie' , '$nazwisko' , '$stanowisko')";

$zapytanie=$polaczenie->query($polecenie);


if ($zapytanie==true)
    print 'Rekord pomyslnie dodany.';
else 
    print 'Wystapil blad.';
$polaczenie->close()

?>