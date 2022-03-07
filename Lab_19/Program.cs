using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//public int Code { get; set; }
//public string MarkId { get; set; }
//public string CpuType { get; set; }
//public int CpuFreq { get; set; }
//public int RamValue { get; set; }
//public int HddValue { get; set; }

//public int Cost { get; set; }
//public int Value { get; set; }
namespace Lab_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=1, MarkId="Pentium IV", CpuType= "Intel", CpuFreq= 800, RamValue=1000, HddValue= 240, VramValue=800, Cost= 6000, Value= 3 },
                new Computer(){Code=2, MarkId="HP Pavilion 15", CpuType= "AMD", CpuFreq= 2400, RamValue=4000, HddValue= 540, VramValue=4000, Cost= 27000, Value= 15 },
                new Computer(){Code=3, MarkId="Macbook Air", CpuType= "Mac", CpuFreq= 3000, RamValue=80000, HddValue= 512, VramValue=4000, Cost= 80000, Value= 9 },
                new Computer(){Code=4, MarkId="Macbook Pro", CpuType= "Mac", CpuFreq= 4200, RamValue=16000, HddValue= 1000, VramValue=4000, Cost= 220000, Value= 11 },
                new Computer(){Code=5, MarkId="Asus Zenbook 15", CpuType= "AMD", CpuFreq= 4600, RamValue=16000, HddValue= 1000, VramValue=4000, Cost= 197000, Value= 32 },
                new Computer(){Code=6, MarkId="Lenovo ThinkPad L13", CpuType= "Intel", CpuFreq= 2400, RamValue=8000, HddValue= 512, VramValue=0, Cost= 123000, Value= 14 },
            };

            Console.WriteLine("Укажите тип процессора (Intel, AMD, Mac)");
            string cpuType = Console.ReadLine();
            List<Computer> computer1 = computers.Where(x => x.CpuType == cpuType).ToList();
            Print(computer1);

            Console.WriteLine("Введите объем ОЗУ");
            int ramValue = Convert.ToInt32(Console.ReadLine());
            List<Computer> computer2 = computers.Where(x => x.RamValue >= ramValue).ToList();
            Print(computer2);

            Console.WriteLine("Сортировка по стоимости:");
            List<Computer> computer3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computer3);

            Console.WriteLine("Группировка по типу процессора:");
            IEnumerable<IGrouping<string, Computer>>computer4 = computers.GroupBy(x => x.CpuType);
            foreach (IGrouping<string, Computer> gr in computer4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Code} -  {c.MarkId}, {c.CpuType}, {c.CpuFreq} МГц {c.RamValue} мб, {c.HddValue} гб, {c.VramValue} мб, {c.Cost} руб, {c.Value} шт."); ;
                }
            }

            Console.WriteLine("Самый дорогой:");
            int maxCost = computers.Max(x => x.Cost);
            List<Computer> computer5 = computers.Where(x => x.Cost == maxCost).ToList();
            Print(computer5);
            Console.WriteLine("Самый бюджетный:");
            int minCost = computers.Min(x => x.Cost);
            List<Computer> computer6 = computers.Where(x => x.Cost == minCost).ToList();
            Print(computer6);

            Console.WriteLine("В наличии более 30 шт.?");
            Console.WriteLine(computers.Any(x => x.Value > 30));

            Console.ReadKey();

        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Code} -  {c.MarkId}, {c.CpuType}, {c.CpuFreq} МГц {c.RamValue} мб, {c.HddValue} гб, {c.VramValue} мб, {c.Cost} руб, {c.Value} шт.");
            }
            Console.WriteLine();
        }
    }
}
