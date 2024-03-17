
﻿public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
﻿public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T nim)
    {
        this.data = nim;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang di tampilkan " + this.data);

    }
}

class Program
{
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("adrian fahren setiawan");

        DataGeneric<string> data = new DataGeneric<string>("1302220018");
        data.PrintData();
    }
}