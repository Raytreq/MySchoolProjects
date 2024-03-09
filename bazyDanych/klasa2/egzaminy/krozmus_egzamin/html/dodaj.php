<?php
    $con = mysqli_connect('localhost', 'root', '', 'dane');

    if(isset($_POST['wyslij'])) {
        $tytul = $_POST['title'];
        $gatunek = $_POST['genre'];
        $rok = $_POST['year'];
        $ocena = $_POST['rating'];

        $sql = "insert into filmy(tytul, gatunki_id, rok, ocena) values ('".$tytul."', '".$gatunek."', '".$rok."', '".$ocena."')";

        $zapyt = mysqli_query($con, $sql);

        if($zapyt) {
            echo "Film o nazwie: ".$tytul." został dodany do bazy danych";
        }
    }
    mysqli_close($con);
?>