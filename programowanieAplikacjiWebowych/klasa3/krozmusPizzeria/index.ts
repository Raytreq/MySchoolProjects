type Pizze = [string, string, number];

enum Sort {
    asc,
    desc
}

function PobierzPizze(): Pizze[] {
    let lista: Pizze[] = [
            ["Marinara", "img/marinara.jpg", 20.00],
            ["Margherita", "img/margherita.jpg", 24.00],
            ["Amalfi", "img/amalfi.jpg", 28.00],
            ["Napoletana", "img/napoletana.jpg", 26.00],
            ["Rucolina", "img/rucolina.jpg", 28.00],
            ["Vegana", "img/vegana.jpg", 29.00],
            ["Cotto e Funghi", "img/cotto.jpg", 29.00],
            ["Carbonara", "img/carbonara.jpg", 25.00]
        ]
    return lista;
}


function SortujNazwa(tab: Pizze[], mode: Sort = Sort.asc): Pizze[] {
    switch (mode) {
        case Sort.asc:
            return tab.sort();
            break;

        case Sort.desc:
            return tab.sort().reverse();
            break;

        default:
            return tab.sort();
            break;
    }

}

function SortujCenowo(tab: Pizze[], mode: Sort = Sort.asc): Pizze[] {
    switch (mode) {
        case Sort.asc:
            return tab.sort();
            break;

        case Sort.desc:
            return tab.sort().reverse();
            break;

        default:
            return tab.sort();
            break;
    }
}


function PokazHTML(tab: Pizze[]) {
    for (let i = 0; i < tab.length; i++) {
        let kontener = document.createElement("div");
        kontener.className = "flex-container";
        kontener.innerHTML = "<div>" + tab[i][0] + "</div>" + "<div>" + "<img src = '" + tab[i][1] + "'height = 150 width = 150 class='pizza'>" + "</div>" + "<div>" + tab[i][2] + " zł" + "</div>";

        document.body.appendChild(kontener);
    }

}
PokazHTML(SortujCenowo(PobierzPizze(), Sort.desc));



