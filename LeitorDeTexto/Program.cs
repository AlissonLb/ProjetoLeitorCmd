internal class Program
{
    private static void Main(string[] args)
    {
        string arquivo = args[0];
        string line = "";

        try
        {
            StreamReader ler = new StreamReader(arquivo);
            line = ler.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = ler.ReadLine();
            }
            ler.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro {e.Message}");
        }
    }
}