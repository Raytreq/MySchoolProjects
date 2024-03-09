class Animal 
{
    getVoice(): void{
        console.log("No voice");
    }

    constructor(public name: string){

    }

    ShowMessage(){
        console.log("Name: ", this.name);
    }
}


class Dog extends Animal 
{
    constructor(name: string, public numberOfLegs: number){
        super(name);
    }

    getVoice(): void{
        console.log("Hau hau!");
    }

    ShowMessage(){
        super.ShowMessage();
        console.log("Number of legs: ", this.numberOfLegs);
    }
}


class Bird extends Animal 
{
    constructor(name: string,public isFlying: boolean){
        super(name);
    }

    getVoice(): void{
        console.log("Ku ku!");
    }

    ShowMessage(){
        super.ShowMessage();
        console.log("Is flying bird: ",this.isFlying);
    }
}



let piesek = new Dog("Reksio", 4);
piesek.ShowMessage();
piesek.getVoice();


let zwierze = new Animal("Zwierzę");
zwierze.ShowMessage();
zwierze.getVoice();


let ptak = new Bird("Hen", false);
ptak.ShowMessage();
ptak.getVoice();