class HaloGeneric
{
    public void SapaUser<T>(T x)
    {
        Console.WriteLine("Halo user " + x);

    }
    

}

class Program
{
    static void  Main()
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        haloGeneric.SapaUser<String>("Tio");

    }
}