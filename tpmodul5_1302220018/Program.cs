public class DataGeneric<T>
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
        DataGeneric<string> data = new DataGeneric<string>("1302220018");
        data.PrintData();
    }
}