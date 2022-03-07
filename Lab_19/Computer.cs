using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19
{
    //Модель компьютера  характеризуется кодом  и названием  марки компьютера,
    //    типом  процессора,  частотой работы  процессора,  объемом оперативной памяти, 
    //    объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных 
    //    единицах и количеством экземпляров, имеющихся в наличии.Создать список, содержащий 6-10 
    //        записей с различным набором значений характеристик.
    class Computer
    {
        public int Code { get; set; }
        public string MarkId { get; set; }
        public string CpuType { get; set; }
        public int CpuFreq { get; set; }
        public int RamValue { get; set; }
        public int HddValue { get; set; }
        public int VramValue { get; set; }
        public int Cost { get; set; }
        public int Value { get; set; }
    }
}
