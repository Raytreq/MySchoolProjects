class Student {
    imie: string;
    nazwisko: string;
    numerIndeksu: number;
    rokStudiow: number;
    listaPrzedmiotow: string[50];

    public constructor(imie: string,
        nazwisko: string,
        numerIndeksu: number,
        rokStudiow: number,
        listaPrzedmiotow: string[50])
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerIndeksu = numerIndeksu;
            this.rokStudiow = rokStudiow;
            this.listaPrzedmiotow = listaPrzedmiotow
    }
}

function WypiszDane(student: Student) {
    console.log(`Imie: ${student.imie}, Nazwisko: ${student.nazwisko}, Numer Indeksu: ${student.numerIndeksu}, Rok Studiów: ${student.rokStudiow}`);
    for (var i = 0; i < 50;  i++) {
        console.log(`${student.listaPrzedmiotow[i]}`)
    }

}

WypiszDane();

function WypiszImie(student: Student) {
    console.log(`Imie: ${student.imie}, Nazwisko: ${student.nazwisko}`);
}

WypiszImie()

function WypiszNrIndeksu(student: Student) {
    console.log(`Numer Indeksu: ${student.numerIndeksu}`);
}

WypiszNrIndeksu()

function WypiszRok(student: Student) {
    console.log(`Rok Studiów: ${student.rokStudiow}`);
}

WypiszRok()

function ZwiekszRok(student: Student) {
    var dodane = student.rokStudiow + 1;
    console.log(`${dodane}`)
}

ZwiekszRok()

function DodajPrzedmiot(student: Student) {
    student.listaPrzedmiotow.push();
}

DodajPrzedmiot()