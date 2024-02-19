public abstract class OrganismoVivente{
    protected string verso; 
    protected int velocita;
    protected string specie;
    public int numeroCaratteristico;

    public override string ToString()
    {
        string s="";
        s+=base.ToString();
        s+="_"+numeroCaratteristico;
        return s;
    }
    public abstract int Muovi();
    public string emettiVerso(){
        return verso;
    }
    public int getVelocita(){
        return velocita;
    }
    public string getSpecie(){
        return specie;
    }


}