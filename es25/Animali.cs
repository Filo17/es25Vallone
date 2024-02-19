public class Gatto:OrganismoVivente{
    public Gatto(int nc){
        base.velocita = 40; //posso variare la velocità da qui
        base.verso = "Meow!";
        base.specie = "Gatto";
        base.numeroCaratteristico = nc;
    }
    public override int Muovi(){
        return velocita;
    }
}
public class Ghepardo:OrganismoVivente{
    public Ghepardo(int nc){
        base.velocita = 80; //posso variare la velocità da qui
        base.verso = "Roawrr!";
        base.specie = "Ghepardo";
        base.numeroCaratteristico = nc;
    }
    public override int Muovi(){
        return velocita;
    }
}
public class Iena:OrganismoVivente{
    public Iena(int nc){
        base.velocita = 60; //posso variare la velocità da qui
        base.verso = "Hahaha!";
        base.specie = "Iena";
        base.numeroCaratteristico = nc;
    }
    public override int Muovi(){
        return velocita;
    }
}
public class Lumaca:OrganismoVivente{
    public Lumaca(int nc){
        base.velocita = 1; //posso variare la velocità da qui
        base.verso = "Sneeze!";
        base.specie = "Lumaca";
        base.numeroCaratteristico = nc;
    }
    public override int Muovi(){
        return velocita;
    }
}