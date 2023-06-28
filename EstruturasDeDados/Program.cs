using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Series> lstSeries = new List<Series>
            {
                new Series { NomeDaSerie = "The Diplomat", Streaming = "Netflix" },
                new Series { NomeDaSerie = "Secreat Invasion", Streaming = "Disney+" },
                new Series { NomeDaSerie = "American Dad!", Streaming = "Star+" },
                new Series { NomeDaSerie = "Girls", Streaming = "HBO Max" },
                new Series { NomeDaSerie = "Good Omens", Streaming = "Prime Video" },
            };

            foreach (var item in lstSeries)
            {
                Console.WriteLine($"Série: {item.NomeDaSerie} - Streaming: {item.Streaming}");
            }

            Console.ReadLine();
        }
    }
}
