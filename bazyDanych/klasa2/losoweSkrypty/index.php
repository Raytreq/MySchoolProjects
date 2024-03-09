<?php
    $link= mysqli_connect('localhost', 'root','') or die("Could not connect");

    mysqli_select_db($link, 'biblioteka')
            or die("Could not select database");

    $query= "SELECT imie, nazwisko, count(Data_wypozyczenia) as 'Ilosc Wypozyczonych' FROM wypozyczenia JOIN czytelnicy USING(Nr_czytelnika) GROUP BY Nr_czytelnika;";
    $result = mysqli_query($link, $query) or die("Query failed");

    echo "<table border='1'>";

    while ($row=mysqli_fetch_array($result)){
        echo "<tr>";
        echo "<td>" . $row['imie'] . "</td>";
        echo "<td>" . $row['nazwisko'] . "</td>";
        echo "<td>" . $row['Ilość Wypożyczonych'] . "</td>";
        echo "</tr>";     
}

        echo "</table>";
    mysqli_close($link);
?>