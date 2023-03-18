class DataGeneric<T>{
    T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data.ToString());
    }
}

class Program
{
    public static void Main()
    {
        DataGeneric<String> dataGeneric = new DataGeneric<String>("1302210057");
        dataGeneric.printData();
    }
}