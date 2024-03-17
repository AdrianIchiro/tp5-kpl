public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("adrian fahren setiawan");
    }
}