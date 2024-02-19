//Gara di animali Ambrogiani Filippo
public class Program {   //dato che la classe OrganismoVivente è astratta, non posso istanziarla
    static void Main()
    {
        
        Random random = new Random();
        int distanza = 100;
        int numeroAnimali = 10;

        ListaOV l = ListaOV.generaAnimali(numeroAnimali); //genero n animali
        System.Console.WriteLine("____________________________________________________\nBENVENUTO ALLA GARA CLANDESTINA DI ANIMALI\n____________________________________________________");
        System.Console.WriteLine("Quanta distanza dovranno percorrere i concorrenti per vincere?? (distanza consigliata: 100 metri)");
        distanza = Convert.ToInt32(Console.ReadLine()) ;
        Console.WriteLine(l);
        
        Gara(l,distanza);


        void Gara(ListaOV l, int distanza){
            bool arrivato = false;
            int pos = 0; 
            while(!arrivato){
                pos = random.Next(0,numeroAnimali);
                NodoOV nodoCorrente = l.getNodoXPos(pos);
                string specieCorrente = nodoCorrente.getOV().ToString();

                //muovo l'animale corrente
                nodoCorrente.distanzaPercorsa += nodoCorrente.getOV().Muovi();
                if (nodoCorrente.getOV().getSpecie() == "Lumaca")
                    System.Console.WriteLine($"\n{specieCorrente} striscia verso la vittoria; {nodoCorrente.distanzaPercorsa}/{distanza} metri di distanza percorsa ");
                else{
                System.Console.WriteLine($"\n{specieCorrente} con uno scatto arriva a {nodoCorrente.distanzaPercorsa}/{distanza} metri di distanza percorsa ");
                }
                //controllo se l'animale è arrivato a destinazione
                if (nodoCorrente.distanzaPercorsa>=distanza)
                {
                    arrivato=true;
                    System.Console.WriteLine($"{specieCorrente} ANNICHILISCE TUTTI E ARRIVA PRIMO");
                    System.Console.WriteLine(nodoCorrente.getOV().emettiVerso());
                }
                Thread.Sleep(2000);
            }
            
        }
    }
}