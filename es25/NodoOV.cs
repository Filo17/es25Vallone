public class NodoOV{
    private OrganismoVivente organismoVivente;
    private NodoOV succ;
    public int distanzaPercorsa;
    public NodoOV(OrganismoVivente ov){
        organismoVivente = ov;
        succ = null;
        distanzaPercorsa =0;

    }
    public NodoOV getSucc(){
        return succ;
    }
    public void setSucc(NodoOV n){
        succ = n;
    }
    public OrganismoVivente getOV(){
        return organismoVivente;
    }
}