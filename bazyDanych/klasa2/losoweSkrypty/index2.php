

<?php
    $polaczenie = mysqli_connect('localhost', 'root', '', 'pracownicy') or die ('Nie można połączyć się z bazą');
    mysqli_set_charset($polaczenie, "utf8");

    $stanowiska = mysqli_query($polaczenie, "SELECT id_stanowiska, nazwa FROM stanowiska");

    echo '<form method="post" action="krozmus_php.php">';

    echo '<b>Dane pracownika </b><br><br>
    <label for="imie">Podaj imię: </label><br/><input type="text" name="imie"><br/>
    <label for="nazwisko">Podaj nazwisko: </label><br/><input type="text" name="nazwisko"><br/><br>
    <select name="id_stanowisko">';

    while($wynik = mysqli_fetch_assoc($stanowiska)){
        echo '<option value="'.$wynik['id_stanowiska'].'">'.$wynik['id_stanowiska'].': '.$wynik['nazwa'].'</option>';
    }

    echo '</select><br><br>
    <input type="reset">
    <input type="submit"><br/>';

    echo '</form>';
    
    mysqli_close($polaczenie);
?>