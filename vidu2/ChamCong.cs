using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu2
{
    internal class ChamCong
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public string Department { get; set; }
        public int WorkDay { get; set; }
        public int PAbsentDay { get; set; }
        public int NPAbsentDay { get; set; }
        public int LateDay { get; set; }
        public ChamCong() 
        {
            PAbsentDay = 0;
            NPAbsentDay = 0;
            LateDay = 0;
            Gender = 0;
        }
    }
}
