using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        int[] talLista = { 1234, 2345, 3456, 4567, 5678 };
        await Delay(talLista);
        Console.WriteLine("Programmet har slutförts");
        Console.ReadKey();
    }
    public static async Task Delay(int[] talLista)
    {
        foreach (int tal in talLista)
        {
            await Task.Delay(1000);
            string talSträng = tal.ToString();

            foreach (char siffra in talSträng)
            {
                Console.Write(siffra);
                await Task.Delay(500);
            }
            Console.WriteLine();
        }
    }
}