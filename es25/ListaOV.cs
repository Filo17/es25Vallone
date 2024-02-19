using System.Globalization;
using System.Text;

public class ListaOV{
    NodoOV t;
    public ListaOV(){
        t = null;
    }
    public void add(NodoOV n){ //aggiungi un nodo alla lista
        if (this.t == null)
            t=n;       
        else {
            n.setSucc(t);
            t=n;
        }
    }
    static public ListaOV generaAnimali(int numeroAnimali){
        Random random = new Random();
        NodoOV n;
        ListaOV l = new ListaOV();
        int numero;
        for (int i = 0; i < numeroAnimali; i++)
        {
            int nc = random.Next(1,100);
            numero = random.Next(1,5);
            switch(numero)
            {
                case 1:
                    n = new NodoOV(new Gatto(nc));
                    break;
                case 2:
                    n = new NodoOV(new Ghepardo(nc));
                    break;
                case 3:
                    n = new NodoOV(new Iena(nc));
                    break;
                case 4:
                    n = new NodoOV(new Lumaca(nc));
                    break;
                default:
                    n = new NodoOV(new Lumaca(nc));
                    break;
            }
            l.add(n); // l sarebbe la lista dei nuovi animali creati
            
        }
        return l;
    }
        public NodoOV getNodoXPos(int posizione){ //ritorno il nodo numerato in una certa posizione
            NodoOV curr = t;
            int idx= 0;
            while (idx< posizione)
            {
                idx++;
                curr = curr.getSucc();
            }
            return curr;
        }

    public override string ToString()
    {
        string val="I concorrenti della gara sono i seguenti:\n";
        NodoOV curr = t;
        while(curr != null){
            val += curr.getOV() + " // ";
            curr=curr.getSucc();
        }
        return val;
    }
    public NodoOV getTesta(){
        return t;
    }
}